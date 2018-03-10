using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShowBlood.config;
using ShowBlood.func;

namespace ShowBlood
{
    public partial class FormMain : Form
    {
        Config config;
        int number = 100;
        int counter = 100;
        byte[] data;
        int lastNum = 100;
        bool flag;

        Graphics g;
        Pen pen;
        Rectangle rec;

        int counterShow = 0;

        Image bg, bg0;

        public FormMain()
        {
            InitializeComponent();

            initData();
            initUI();
            addEvents();

            new Thread(new ThreadStart(() => Watching())).Start();



        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int sw = Screen.PrimaryScreen.Bounds.Width;
            int sh = Screen.PrimaryScreen.Bounds.Height;

            //MessageBox.Show(panel.Width + "  " + panel.Height);
            panel.Width = sw;
            panel.Height = sh;

            //MessageBox.Show(panel.Width + "  " + panel.Height);

            lblNumber.Width = (int)(panel.Width / 2);
            lblNumber.Height = (int)(panel.Height / 2);

            lblNumber.Font = new Font("微软雅黑", 230, FontStyle.Bold);
           
            //pannelNumber居中
            int left = (int)(0.5 * (panel.Width - lblNumber.Width));
            int top = (int)(0.5 * (panel.Height - lblNumber.Height));
            lblNumber.Top = top;
            lblNumber.Left = left;

            //pannelConfig跟随
            top = lblNumber.Top + lblNumber.Height;
            panelConfig.Top = top;

           

            timer1.Tick += new EventHandler(firstDraw);
            timer2.Tick += new EventHandler(openSerialPort);
           // timerAnimate.Tick += new EventHandler(stopAnimate);
        }

        private void initData()
        {
            flag = true;

            data = new byte[256];


            string cfgStr = new FnFile().getConfig();
            JObject obj = (JObject)JsonConvert.DeserializeObject(cfgStr);
            if (obj != null)
            {
                config = new Config(obj);
            }
            else
            {
                config = new Config();
            }

            

            try
            {
                //sp.PortName = config.port;
                //sp.BaudRate = Int32.Parse(config.baudrate);

                sp.PortName = "COM3";
                sp.BaudRate = 9600;

                sp.Open();
                Console.WriteLine("串口打开");
            }
            catch (Exception e)
            {
               //MessageBox.Show(e.Message);
            } 

            try
            {
                //spTest.PortName = config.portTest; 
                //spTest.BaudRate = Int32.Parse(config.baudrateTest);

                spTest.PortName = "COM2";
                spTest.BaudRate = 9600;

                spTest.Open();
                Console.WriteLine("测试串口打开");
            }
            catch (Exception e)
            {
                btnTest.Enabled = false;
            }

            bg = Image.FromFile(System.Environment.CurrentDirectory + "\\bg.jpg");
            bg0 = Image.FromFile(System.Environment.CurrentDirectory + "\\bg0.gif");

           
        }

        private void addEvents()
        {
            btnExit.Click += new EventHandler(exit);
            btnTest.Click += new EventHandler(test);
            btnUpdateConfig.Click += new EventHandler(update);
            lblNumber.Click += new EventHandler(showWidget);
            sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(dataReceived);

            //timer.Tick += new EventHandler(test);
            //MessageBox.Show("addEvents OK");
        }

        private void initUI()
        {
            for (int i = 0; i < cbxPortTest.Items.Count; i++)
            {
                if (cbxPortTest.Items[i].ToString().Equals(config.portTest))
                {
                    cbxPortTest.SelectedIndex = i;
                }
            }

            for (int i = 0; i < cbxBaudrateTest.Items.Count; i++)
            {
                if (cbxBaudrateTest.Items[i].ToString().Equals(config.baudrateTest))
                {
                    cbxBaudrateTest.SelectedIndex = i;
                }
            }

            //*************************************

            for (int i = 0; i < cbxPort.Items.Count; i++)
            {
                if (cbxPort.Items[i].ToString().Equals(config.port))
                {
                    cbxPort.SelectedIndex = i;
                }
            }

            for (int i = 0; i < cbxBaudrate.Items.Count; i++)
            {
                if (cbxBaudrate.Items[i].ToString().Equals(config.baudrate))
                {
                    cbxBaudrate.SelectedIndex = i;
                }
            }


            //MessageBox.Show("initUI OK");


        }

        /// <summary>
        /// 观察
        /// </summary>
        private void Watching()
        {
            while (flag)
            {
                if (sp.IsOpen && sp.BytesToRead >= 3)
                {
                    int dataLength = sp.BytesToRead;
                    Console.WriteLine(" 满了 " + dataLength);
                    sp.Read(data, 0, dataLength);

                    string temp = "";
                    foreach (byte b in data)
                    {
                        temp += b + " ";
                    }
                    Console.WriteLine("   " + temp);

                    //校验
                    if (data[0] == (data[1] + data[2]))
                    {
                        number = (int)data[1];
                        this.Invoke(new EventHandler(changeNumber));
                    }
                    else
                    {
                        Console.WriteLine(" 校验未通过");
                        sp.ReadExisting();
                    }
                    dataLength = 0;


                }
            }
        }

        
        private void dataReceived(Object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Console.WriteLine("串口数据收到..." + sp.BytesToRead);
        }

        private void firstDraw(Object sender, EventArgs e)
        {
            timer1.Stop();

            lblNumber.Width = (int)(panel.Width / 1.6);
            lblNumber.Height = (int)(panel.Height / 1.8);
            //pannelNumber居中
            int left = (int)(0.5 * (panel.Width - lblNumber.Width));
            int top = (int)(0.5 * (panel.Height - lblNumber.Height));
            lblNumber.Top = top;
            lblNumber.Left = left;

            //lblNumber.Padding = new Padding(10);
            

            //changeNumber(null, null);
            //int sweep = (int)(360 * ((double)number / 100));

           // MessageBox.Show(sweep + "");
            //GDI+绘出比例图
            //1. 获取数字框的位置
            /*
            int x = panel.Location.X + 45,
                y = panel.Location.Y + 45,
                w = panel.Width - 90,
                h = panel.Height - 90;

            panel.Refresh();

            g = panel.CreateGraphics();

            pen = new Pen(Color.DarkRed, 80);
            rec = new Rectangle(x, y, w, h);
            g.DrawArc(pen, rec, 270, sweep); 
            */
        }

        private void openSerialPort(Object sender, EventArgs e)
        {
            //timer2.Stop();
            //initData();
            //initUI();
            //addEvents();

            //new Thread(new ThreadStart(() => Watching())).Start();
        }

        private void changeNumber(Object sender, EventArgs e)
        {
           

       
            //......................................


            lblNumber.Width = (int)(panel.Width / 1.6);
            lblNumber.Height = (int)(panel.Height / 1.8);

            lblNumber.Font = new Font("微软雅黑", 230, FontStyle.Bold);


            //pannelNumber居中
            int left = (int)(0.5 * (panel.Width - lblNumber.Width));
            int top = (int)(0.5 * (panel.Height - lblNumber.Height));
            lblNumber.Top = top;
            lblNumber.Left = left;

            lblNumber.TextAlign = ContentAlignment.MiddleCenter;

            lblNumber.Text = number + "";

            //如果是0
            if (number == 0 && lastNum != 0)
            {

                //换成动态背景
                //this.BackgroundImage = bg0;
                //ImageAnimator.Animate(bg0, animate);

                lblNumber.Visible = false;
                pb.Image = bg0;

                new Thread(new ThreadStart(() => stopAnimate())).Start();

            }

            lastNum = number;

            //int sweep = (int)(360 * ((double)number / 100));

          

            //GDI+绘出比例图
            //1. 获取数字框的位置
            /*
            int x = panel.Location.X+45,
                y = panel.Location.Y+45,
                w = panel.Width-90,
                h = panel.Height-90;
           
            if (number < 100)
            {
                
            }
            panel.Refresh();

            g = panel.CreateGraphics();
         

            pen = new Pen(Color.DarkRed, 80);
            rec = new Rectangle(x,y,w,h);
            g.DrawArc(pen, rec, 270, sweep);
            */


        }

        private void stopAnimate()
        {
            Thread.Sleep(2500);
            this.Invoke(new EventHandler(recover));
        }

        /// <summary>
        /// 停止动画重现显示数字
        /// </summary>
        private void recover(Object sender, EventArgs e)
        {
            lblNumber.Visible = true;
            pb.Image = null;
           
        }

        private void testBak(Object sender, EventArgs e)
        {
            //持续、定时发送数据
            if (counter > 0)
            {
                counter -= 10;

                byte[] order = new byte[3];
                order[0] = 0xff;
                order[1] = (byte)counter;
                order[2] = (byte)(order[0] - order[1]);

                string temp = "";
                foreach (byte b in order)
                {
                    temp += b + " ";
                }
                Console.WriteLine(" 组织命令：" + temp + "  ");

                spTest.Write(order, 0, order.Length);
            }
            else
            {
                counter = 100;
                number = 100;
                timer.Stop();
            }
            
        }

        private void test(Object sender, EventArgs e)
        {
            //生成一个随机数

            Random ran = new Random();
            int counter = ran.Next(0,5);

            byte[] order = new byte[3];
            order[0] = 0xff;
            order[1] = (byte)counter;
            order[2] = (byte)(order[0] - order[1]);

            string temp = "";
            foreach (byte b in order)
            {
                temp += b + " ";
            }
            Console.WriteLine(" 组织命令：" + temp + "  ");

            spTest.Write(order, 0, order.Length);

        }

        private void update(Object sender, EventArgs e)
        {
            config.portTest = cbxPortTest.SelectedItem.ToString();
            config.baudrateTest = cbxBaudrateTest.SelectedItem.ToString();
            config.port = cbxPort.SelectedItem.ToString();
            config.baudrate = cbxBaudrate.SelectedItem.ToString();
            string str = JsonConvert.SerializeObject(config);
            new FnFile().toConfig(str);

            str = System.DateTime.Now.ToString("HH:mm:ss") + "\r\n" + "已更新";
            lblMsg.Text = str;
        }

        private void showWidget(Object sender, EventArgs e)
        {
            counterShow ++;
            Console.WriteLine("counterShow:" + counterShow + "  " + (counterShow % 10));
            if (counterShow % 10 == 0)
            {
                panelConfig.Visible = true;
            }
            else
            {
                panelConfig.Visible = false;
            }
        }

        private void exit(Object sender, EventArgs e)
        {
            if (sp != null){ sp.Close(); }
            if (spTest != null) { spTest.Close(); }
            flag = false;
            Application.Exit();
        }

        private void lblNumber_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("lblNumber 双击");
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
