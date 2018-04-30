using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ver2
{
    public partial class SpeedKing : Form
    {
        public SpeedKing()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void SpeedKing_Load(object sender, EventArgs e)
        {
            this.Size = new Size(650, 820);
            pcbBackGround1.Size = new Size(650, 820);
            pcbBackGround1.Location = new Point(-10, 0);
            pcbBackGround2.Size = new Size(650, 820);
            pcbBackGround2.Location = new Point(-10, -820);
            XeComPuter.Size = new Size(75, 150);
            XeComPuter.BackColor = Color.FromArgb(156, 156, 156);
            xePlayer.Size = new Size(75, 150);
            xePlayer.BackColor = Color.FromArgb(156, 156, 156);

        }

        private void XeComPuter_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
