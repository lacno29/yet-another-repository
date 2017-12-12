using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proposal
{
    public partial class Welcome : MaterialSkin.Controls.MaterialForm
    {
        public Welcome(Boolean state)
        {
            if (state)
            {
                Thread t = new Thread(new ThreadStart(Loading));
                t.Start();
                InitializeComponent();
                for (int i = 0; i < 300; i++)
                {
                    Thread.Sleep(50);
                }
                t.Abort();
            }

            else
            {
                InitializeComponent();
            }
        }

        public void Loading()
        {
            Application.Run(new SplashScreen1());
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skin = MaterialSkin.MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue900, MaterialSkin.Primary.Blue200, MaterialSkin.Accent.Blue200, MaterialSkin.TextShade.WHITE);
            
        }

        private void labelRegister_MouseEnter(object sender, EventArgs e)
        {
            labelRegister.ForeColor = Color.FromArgb(33, 150, 243);
        }

        private void labelRegister_MouseLeave(object sender, EventArgs e)
        {
            labelRegister.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void labelForgotYourPassword_MouseEnter(object sender, EventArgs e)
        {
            labelForgotYourPassword.ForeColor = Color.FromArgb(33, 150, 243);
        }

        private void labelForgotYourPassword_MouseLeave(object sender, EventArgs e)
        {
            labelForgotYourPassword.ForeColor = Color.FromArgb(255, 255, 255);
        }

        public void labelRegister_Click(object sender, EventArgs e)
        {
            Util.Animate(login1, Util.Effect.Slide, 150, 0);
            if(labelRegister.Text.Equals("Register"))
            {
                this.Text = "Register";
                labelRegister.Text = "Already have an account?";
                labelForgotYourPassword.Text = "";
            }
            else
            {
                this.Text = "Welcome to Pass Pro";
                labelRegister.Text = "Register";
                labelForgotYourPassword.Text = "Forgot your password?";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 100)
                this.Opacity += 0.5;
            else
                timer1.Stop();
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Proposal.Welcome FormThread = (Proposal.Welcome)Application.OpenForms["Welcome"];
            if(FormThread != null)
                FormThread.Close();
        }
    }
}