namespace Proposal
{
    partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.divider = new MaterialSkin.Controls.MaterialDivider();
            this.labelRegister = new MaterialSkin.Controls.MaterialLabel();
            this.labelForgotYourPassword = new MaterialSkin.Controls.MaterialLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login1 = new Proposal.Login();
            this.register1 = new Proposal.Register();
            this.regComplete1 = new Proposal.RegComplete();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.divider.Depth = 0;
            this.divider.Location = new System.Drawing.Point(12, 347);
            this.divider.MouseState = MaterialSkin.MouseState.HOVER;
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(326, 1);
            this.divider.TabIndex = 12;
            this.divider.Text = "materialDivider1";
            // 
            // labelRegister
            // 
            this.labelRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegister.AutoSize = true;
            this.labelRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegister.Depth = 0;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRegister.Location = new System.Drawing.Point(12, 381);
            this.labelRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(63, 18);
            this.labelRegister.TabIndex = 15;
            this.labelRegister.Text = "Register";
            this.labelRegister.Click += new System.EventHandler(this.labelRegister_Click);
            this.labelRegister.MouseEnter += new System.EventHandler(this.labelRegister_MouseEnter);
            this.labelRegister.MouseLeave += new System.EventHandler(this.labelRegister_MouseLeave);
            // 
            // labelForgotYourPassword
            // 
            this.labelForgotYourPassword.AutoSize = true;
            this.labelForgotYourPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForgotYourPassword.Depth = 0;
            this.labelForgotYourPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelForgotYourPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelForgotYourPassword.Location = new System.Drawing.Point(176, 381);
            this.labelForgotYourPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelForgotYourPassword.Name = "labelForgotYourPassword";
            this.labelForgotYourPassword.Size = new System.Drawing.Size(162, 18);
            this.labelForgotYourPassword.TabIndex = 14;
            this.labelForgotYourPassword.Text = "Forgot your password?";
            this.labelForgotYourPassword.MouseEnter += new System.EventHandler(this.labelForgotYourPassword_MouseEnter);
            this.labelForgotYourPassword.MouseLeave += new System.EventHandler(this.labelForgotYourPassword_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(350, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 427);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pass Pro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(0, 63);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(350, 280);
            this.login1.TabIndex = 16;
            // 
            // register1
            // 
            this.register1.Location = new System.Drawing.Point(0, 63);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(350, 280);
            this.register1.TabIndex = 17;
            // 
            // regComplete1
            // 
            this.regComplete1.Location = new System.Drawing.Point(0, 63);
            this.regComplete1.Name = "regComplete1";
            this.regComplete1.Size = new System.Drawing.Size(350, 280);
            this.regComplete1.TabIndex = 19;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.regComplete1);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.labelForgotYourPassword);
            this.Controls.Add(this.divider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Pro Pass";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Welcome_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider divider;
        private MaterialSkin.Controls.MaterialLabel labelForgotYourPassword;
        private MaterialSkin.Controls.MaterialLabel labelRegister;
        private Login login1;
        private Register register1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RegComplete regComplete1;
    }
}

