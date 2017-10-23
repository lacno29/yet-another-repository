using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proposal
{
    public partial class Alert : Form
    {
        private Boolean isClosed = false;
        public enum AlertType
        {
            SUCCESS, ERROR, WARNING, INFO
        }

        public Alert(AlertType alert, String message, String details)
        {
            InitializeComponent();
            switch (alert)
            {
                case AlertType.SUCCESS:
                    {
                        this.BackColor = Color.SeaGreen;
                        labelMessage.Text = message;
                        labelDetails.Text = details;
                        pictureBoxIcon.Image = imageList1.Images[0];
                    }break;

                case AlertType.ERROR:
                    {
                        this.BackColor = Color.Crimson;
                        labelMessage.Text = message;
                        labelDetails.Text = details;
                        pictureBoxIcon.Image = imageList1.Images[1];
                    }
                    break;

                case AlertType.WARNING:
                    {
                        this.BackColor = Color.FromArgb(255,128,0);
                        labelMessage.Text = message;
                        labelDetails.Text = details;
                        pictureBoxIcon.Image = imageList1.Images[2];
                    }
                    break;

                case AlertType.INFO:
                    {
                        this.BackColor = Color.Gray;
                        labelMessage.Text = message;
                        labelDetails.Text = details;
                        pictureBoxIcon.Image = imageList1.Images[3];
                    }
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 50;
            this.Top = 800;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Close();
            isClosed = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        { 
            if (this.Top < 800)
            {
                this.Top += 10;
            }
            else
            {
                this.Close();
            }
        }

        private void Alert_MouseEnter(object sender, EventArgs e)
        {
            if(!isClosed)
            {
                timer1.Stop();
                timer2.Enabled = false;
            }
        }

        private void Alert_MouseLeave(object sender, EventArgs e)
        {
            if(!isClosed)
                timer1.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(this.Top > 600)
            {
                this.Top -= 10;
            }
            else
            {
                timer3.Stop();
            }
        }
    }
}
