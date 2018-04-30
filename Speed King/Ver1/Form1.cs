using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace Ver1
{
    public partial class Form1 : Form
    {
        public void SetCarPlay(PictureBox name, int x, int y)
        {
            name.Visible = true;
            if (name.Visible == true)
            {
                y_computer[y] += 5;
            }

            // X [0:493]
            name.Location = new Point(x_computer[x], y_computer[y]);

            if (y_computer[y] >= this.Height)
            {
                diem++;
                lblDiemSo.Text = diem.ToString();
                
                if (diem > 20)
                {
                    xeComputer3.Visible = true;
                    TimerXe3.Start();
                }
                if (diem > 40)
                {
                    xeComputer4.Visible = true;
                    TimerXe4.Start();
                    TimerXe2.Interval = 1;
                }
                if (diem > 60)
                {
                    timerDiChuyenXe.Interval = 1;
                    TimerXe2.Interval = 1;
                    TimerXe3.Interval = 1;
                    TimerXe4.Interval = 1;
                }
                y_computer[y] = 0; // set lại
                Random rd = new Random();
                x_computer[x] = rd.Next(95, this.Width - 95 - name.Width);
            }
            // Kiểm tra va chạm giữa 2 pic
            // if (xeComputer1.Location.Y +xeComputer1.Height == xePlayer.Location.Y)
            if (name.Location.Y < xePlayer.Location.Y)
            {
                //if (y_computer[0] + xeComputer1.Height == y_Player)
                if (name.Location.Y + name.Height >= xePlayer.Location.Y)
                {
                    if (xePlayer.Location.X >= name.Location.X - xePlayer.Width && xePlayer.Location.X <= name.Location.X + xePlayer.Width)
                    //if(x_Player >= x_computer[0] - xePlayer.Width && x_Player <= x_computer[0] + xePlayer.Width)
                    {
                        xeComputer3.Visible = false;
                        xeComputer4.Visible = false;
                        TimerXe2.Stop();
                        timerDiChuyenXe.Stop();
                        TimerBGR.Stop();
                        TimerXe3.Stop();
                        TimerXe4.Stop();
                        VuNo1.Visible = true;
                        VuNo1.Location = new Point(xePlayer.Location.X, xePlayer.Location.Y);
                        VuNo2.Visible = true;
                        VuNo2.Location = new Point(xePlayer.Location.X, xePlayer.Location.Y);
                        VuNo3.Visible = true;
                        VuNo3.Location = new Point(xePlayer.Location.X, xePlayer.Location.Y);
                        VuNo4.Visible = true;
                        VuNo4.Location = new Point(xePlayer.Location.X, xePlayer.Location.Y);
                        xePlayer.Visible = false;
                        name.Visible = false;
                        //timerDiChuyenXe.Stop();
                        //TimerBGR.Stop();
                       
                        Thread.Sleep(100);
                        DialogResult luachon = MessageBox.Show("Bạn có muốn chơi tiếp không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (luachon == DialogResult.Yes)
                        {
                            diem = 0;
                            lblDiemSo.Text = diem.ToString();
                           
                            // CHơi lại từ đâu
                            // CHơi lại từ đâu
                            timerDiChuyenXe.Start();
                            TimerBGR.Start();
                            TimerXe2.Start();
                            //TimerXe3.Start();
                            //TimerXe4.Start();
                            KiemTraNhan = false;
                            VuNo1.Visible = false;
                            VuNo2.Visible = false;
                            VuNo3.Visible = false;
                            VuNo4.Visible = false;
                            xePlayer.Visible = true;
                            name.Visible = true;
                            y_computer[y] = 0;
                            Random rd = new Random();
                            x_computer[x] = rd.Next(95, this.Width - 95 - name.Width);
                            name.Location = new Point(x_computer[x], y_computer[y]);
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
        }

        List<PictureBox> ListXeComputer = new List<PictureBox>();
        int diem = 0;
        internal List<PictureBox> LSTXECOMPUTER
        {
            get { return ListXeComputer; }
            set { ListXeComputer = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }
        int x_Player;
        int y_Player;
        int []x_computer = new int[5];int []y_computer = new int[5];
        int x_background;
        int y_background;
        int x_bgr1=0, y_brg1=0, x_brg2=0, y_brg2=-810;
        int x_VienDan;
        int y_VienDan;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(625, 810);
            xePlayer.BackColor = Color.FromArgb(156, 156, 156); // Lấy mã màu từ photoshop
            xePlayer.Size = new Size(75,150); // resize lại vì form chỉ là chỗ kéo thả mà thôi
            xeComputer1.Size = new Size(75, 150);
            xeComputer2.Size = new Size(75, 150);
            xeComputer3.Size = new Size(75, 150);
            xeComputer4.Size = new Size(75, 150);
            xeComputer5.Size = new Size(75, 160);
            xeComputer1.Visible = false;
            xeComputer2.Visible = false;
            xeComputer3.Visible = false;
            xeComputer4.Visible = false;
            xeComputer5.Visible = false;
            xeComputer1.BackColor = Color.FromArgb(156, 156, 156);
            xeComputer2.BackColor = Color.FromArgb(156, 156, 156);
            xeComputer3.BackColor = Color.FromArgb(156, 156, 156);
            xeComputer4.BackColor = Color.FromArgb(156, 156, 156);
            xeComputer5.BackColor = Color.FromArgb(156, 156, 156);
            //
            Bgr1.Size = new Size(625 ,810);
            Bgr2.Size = new Size(625, 810);
            Bgr1.Location = new Point(0, 0);
            Bgr2.Location = new Point(0, -810);
            //.Size = new Size(650, 810);
            /*Location: dựa theo 2 thông số:
             x chiều ngang bắt đầu từ 0: từ trái sang phải [0, 650]
             y: chiều dọc: từ trên xuống dưới [0,810]
             */
            xePlayer.Location = new Point(250, 620);
            x_Player = xePlayer.Location.X;
            y_Player = xePlayer.Location.Y;
            // Timer
            timerDiChuyenXe.Interval = 10;
            TimerXe2.Interval = 10;
            TimerBGR.Interval = 1;
            TimerXe3.Interval = 10;
            TimerXe4.Interval = 10;
            // Tọa độ
            x_computer[0] = 300;
            y_computer[0] = 0;
            x_computer[1] = 100;
            x_computer[2] = 200;
            y_computer[2] = -250;
            y_computer[1] = -140;
            x_computer[3] = 360;
            y_computer[3] = -300;
            
            // Nút Play
            play.Size = new Size(50, 50);
            play.Location = new Point(10, 270);
            play.BackColor = Color.FromArgb(139, 204, 119);
            // Vụ nổ
            VuNo1.Size = new Size(150, 150);
            VuNo2.Size = new Size(150, 150);
            VuNo3.Size = new Size(150, 150);
            VuNo4.Size = new Size(150, 150);
            VuNo1.BackColor = Color.FromArgb(156, 156, 156);
            VuNo2.BackColor = Color.FromArgb(156, 156, 156);
            VuNo3.BackColor = Color.FromArgb(156, 156, 156);
            VuNo4.BackColor = Color.FromArgb(156, 156, 156);
            VuNo1.Visible = false;
            VuNo2.Visible = false;
            VuNo3.Visible = false;
            VuNo4.Visible = false;
            TimerVuNo.Interval = 3000;
            TimerVuNo.Start();
            //====================  ĐIểm ====================
            lblDiem.Location = new Point(0, 200);
            lblDiem.BackColor = Color.FromArgb(139, 204, 119);
            lblDiemSo.Location = new Point(20, 230);
            lblDiemSo.BackColor = Color.FromArgb(139, 204, 119);
            // ================== Đạn =======================
            VienDan.BackColor = Color.FromArgb(156, 156, 156);
            VienDan.Size = new Size(15, 48);
            VienDan.Visible = false;
            TimerVienDan.Interval = 10;
            TimerVienDan.Start();
            start.Size = new Size(900, 810);
            start.Location = new Point(0, 0);
           btnstart.Visible = false;
            System.Diagnostics.Process.Start("HeishinDuel-V.A-3315637.mp3");
        }
        bool KiemTraNhan = false;
        Point ToaDo;
        private void xePlayer_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void xePlayer_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void xePlayer_MouseUp(object sender, MouseEventArgs e)
        {
        }
        private void TimerXe2_Tick(object sender, EventArgs e)
        {
            SetCarPlay(xeComputer2, 1, 1);
        }
        
        private void timerDiChuyenXe_Tick(object sender, EventArgs e)
        {
            SetCarPlay(xeComputer1, 0, 0); 
        }
        
        private void xePlayer_MouseDown_1(object sender, MouseEventArgs e)
        {
            KiemTraNhan = true;
            ToaDo = e.Location; // cập nhật tọa độ hiện tại khi nhấn chuột xuống
        }
        private void xePlayer_MouseUp_1(object sender, MouseEventArgs e)
        {
            KiemTraNhan = false;
        }
        private void xePlayer_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (KiemTraNhan == true) // còn nhấn chuột mới cho di chuyển
            {
                PictureBox a = (PictureBox)sender; // ép kiểu cho đối tượng sender
                Point toadobandau = a.Location; // lấy tọa độ hiện tại của tấm hình
                toadobandau.X += e.Location.X - ToaDo.X; // e.location là tọa độ mới sau khi di chuột
                toadobandau.Y += e.Location.Y - ToaDo.Y;
                // ko cho nó chạy ra ngoài 
                if (toadobandau.X <= 95)
                {
                    toadobandau.X = 95;
                }
                if (toadobandau.X >= this.Width - xePlayer.Width - 98)
                {
                    toadobandau.X = this.Width - xePlayer.Width - 98;
                }
                if (toadobandau.Y <= 0)
                {
                    toadobandau.Y = 0;
                }
                if (toadobandau.Y >= this.Height - xePlayer.Height - 30)
                {
                    toadobandau.Y = this.Height - xePlayer.Height -30;
                }
        
                xePlayer.Location = toadobandau; // cập nhật vị trí mới sau khi di chuyển 
                x_Player = xePlayer.Location.X;
                y_Player = xePlayer.Location.Y;
            }
        }

        private void TimerBGR_Tick(object sender, EventArgs e)
        {
            y_brg1 += 5;
            y_brg2 += 5;
            Bgr1.Location = new Point(x_bgr1, y_brg1);
            Bgr2.Location = new Point(x_brg2, y_brg2);
            if (y_brg1 >= this.Height)
            {
                y_brg1 = 0;
                y_brg2 = y_brg1 - 810;
            }
            //if (y_brg2 >= this.Height)
            //{
            //    y_brg2 = y_brg1-810;
            //}
        }
        int dem = 1;
        private void play_Click(object sender, EventArgs e)
        {
            if (dem >= 0)
            {
                TimerVuNo.Interval = 300;
            }
            if (dem % 2 != 0)
            {
                timerDiChuyenXe.Start();
                TimerXe2.Start();
                TimerBGR.Start();
            }
            if (dem == 1)
            {
                xeComputer1.Visible = true;
                xeComputer2.Visible = true;
            }
            if(dem % 2==0)
            {
                timerDiChuyenXe.Stop();
                TimerXe2.Stop();
                TimerBGR.Stop();
            }
            dem++;
        }

        private void TimerXe3_Tick(object sender, EventArgs e)
        {

            SetCarPlay(xeComputer3, 2, 2);
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Space)
            {
                VienDan.Visible = true;
                y_VienDan = y_Player - VienDan.Height + 5;
                x_VienDan = (x_Player + xePlayer.Width / 2 -5);
                VienDan.Location = new Point(x_VienDan, y_VienDan);
            }
        }
        public void SetBullet(PictureBox name, int index)
        {
            if (name.Location.Y + name.Height >= VienDan.Location.Y)
            {
                if (VienDan.Location.X >= name.Location.X - (VienDan.Width + 60) && VienDan.Location.X <= name.Location.X + (VienDan.Width + 60))
                //if(x_Player >= x_computer[0] - xePlayer.Width && x_Player <= x_computer[0] + xePlayer.Width)
                {
                    SoundPlayer sound = new SoundPlayer("Explosion+1.wav");
                    sound.LoadAsync();
                    sound.Play();
                    VuNo4.Visible = true;
                    VuNo4.Location = new Point(name.Location.X, name.Location.Y);
                    diem += 2;
                    lblDiemSo.Text = diem.ToString();
                    name.Visible = false;
                    VienDan.Visible = false;
                    y_computer[index] = -200;
                    Random rd = new Random();
                    x_computer[index] = rd.Next(95, this.Width - 95 - name.Width);
                }
            }
        }
        private void TimerVienDan_Tick(object sender, EventArgs e)
        {

            if (VienDan.Visible == true && xeComputer1.Visible == true)
            {
                y_VienDan -= 10;
                VienDan.Location = new Point(x_VienDan, y_VienDan);
                // Kiểm tra va chạm với xe computer
                SetBullet(xeComputer1, 0);
                SetBullet(xeComputer2, 1);
                SetBullet(xeComputer3, 2);
                SetBullet(xeComputer4, 3);

            }
        }

        private void TimerVuNo_Tick(object sender, EventArgs e)
        {
            VuNo4.Visible = false;
            start.Visible = false;
        }

        private void TimerXe4_Tick(object sender, EventArgs e)
        {
            SetCarPlay(xeComputer4, 3, 3);
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            btnstart.Visible = false;
            btnstart.Enabled = false;
            timerDiChuyenXe.Start();
            TimerXe2.Start();
            TimerBGR.Start();
            
        }
    }
}
