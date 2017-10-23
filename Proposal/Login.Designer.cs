namespace Proposal
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.raisedButtonLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textFieldPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textFieldUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.SuspendLayout();
            // 
            // raisedButtonLogin
            // 
            this.raisedButtonLogin.Depth = 0;
            this.raisedButtonLogin.Location = new System.Drawing.Point(218, 221);
            this.raisedButtonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.raisedButtonLogin.Name = "raisedButtonLogin";
            this.raisedButtonLogin.Primary = true;
            this.raisedButtonLogin.Size = new System.Drawing.Size(100, 31);
            this.raisedButtonLogin.TabIndex = 10;
            this.raisedButtonLogin.Text = "LOGIN";
            this.raisedButtonLogin.UseVisualStyleBackColor = true;
            this.raisedButtonLogin.Click += new System.EventHandler(this.raisedButtonLogin_Click);
            // 
            // textFieldPassword
            // 
            this.textFieldPassword.Depth = 0;
            this.textFieldPassword.Hint = "Password";
            this.textFieldPassword.Location = new System.Drawing.Point(28, 89);
            this.textFieldPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldPassword.Name = "textFieldPassword";
            this.textFieldPassword.PasswordChar = '*';
            this.textFieldPassword.SelectedText = "";
            this.textFieldPassword.SelectionLength = 0;
            this.textFieldPassword.SelectionStart = 0;
            this.textFieldPassword.Size = new System.Drawing.Size(290, 23);
            this.textFieldPassword.TabIndex = 8;
            this.textFieldPassword.UseSystemPasswordChar = true;
            this.textFieldPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textFieldPassword_KeyDown);
            // 
            // textFieldUsername
            // 
            this.textFieldUsername.Depth = 0;
            this.textFieldUsername.Hint = "Username";
            this.textFieldUsername.Location = new System.Drawing.Point(28, 43);
            this.textFieldUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldUsername.Name = "textFieldUsername";
            this.textFieldUsername.PasswordChar = '\0';
            this.textFieldUsername.SelectedText = "";
            this.textFieldUsername.SelectionLength = 0;
            this.textFieldUsername.SelectionStart = 0;
            this.textFieldUsername.Size = new System.Drawing.Size(290, 23);
            this.textFieldUsername.TabIndex = 7;
            this.textFieldUsername.UseSystemPasswordChar = false;
            this.textFieldUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textFieldUsername_KeyDown);
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(117, 149);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(77, 30);
            this.materialRadioButton2.TabIndex = 18;
            this.materialRadioButton2.Text = "Student";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            this.materialRadioButton2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.materialRadioButton2_KeyDown);
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Checked = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(28, 149);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(79, 30);
            this.materialRadioButton1.TabIndex = 17;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Teacher";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.materialRadioButton1_KeyDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialRadioButton2);
            this.Controls.Add(this.materialRadioButton1);
            this.Controls.Add(this.raisedButtonLogin);
            this.Controls.Add(this.textFieldPassword);
            this.Controls.Add(this.textFieldUsername);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(350, 280);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton raisedButtonLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldUsername;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
    }
}
