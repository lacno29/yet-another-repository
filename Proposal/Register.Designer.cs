namespace Proposal
{
    partial class Register
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
            this.textFieldNo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textFieldUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textFieldPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonNext = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioButtonTeacher = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonStudent = new MaterialSkin.Controls.MaterialRadioButton();
            this.SuspendLayout();
            // 
            // textFieldNo
            // 
            this.textFieldNo.Depth = 0;
            this.textFieldNo.Hint = "Teacher No.";
            this.textFieldNo.Location = new System.Drawing.Point(28, 135);
            this.textFieldNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldNo.Name = "textFieldNo";
            this.textFieldNo.PasswordChar = '\0';
            this.textFieldNo.SelectedText = "";
            this.textFieldNo.SelectionLength = 0;
            this.textFieldNo.SelectionStart = 0;
            this.textFieldNo.Size = new System.Drawing.Size(290, 23);
            this.textFieldNo.TabIndex = 9;
            this.textFieldNo.UseSystemPasswordChar = false;
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
            this.textFieldPassword.TabIndex = 12;
            this.textFieldPassword.UseSystemPasswordChar = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Depth = 0;
            this.buttonNext.Location = new System.Drawing.Point(218, 215);
            this.buttonNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Primary = true;
            this.buttonNext.Size = new System.Drawing.Size(100, 31);
            this.buttonNext.TabIndex = 14;
            this.buttonNext.Text = "NEXT";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.raisedButtonLogin_Click);
            // 
            // radioButtonTeacher
            // 
            this.radioButtonTeacher.AutoSize = true;
            this.radioButtonTeacher.Checked = true;
            this.radioButtonTeacher.Depth = 0;
            this.radioButtonTeacher.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonTeacher.Location = new System.Drawing.Point(28, 182);
            this.radioButtonTeacher.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonTeacher.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonTeacher.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonTeacher.Name = "radioButtonTeacher";
            this.radioButtonTeacher.Ripple = true;
            this.radioButtonTeacher.Size = new System.Drawing.Size(79, 30);
            this.radioButtonTeacher.TabIndex = 15;
            this.radioButtonTeacher.TabStop = true;
            this.radioButtonTeacher.Text = "Teacher";
            this.radioButtonTeacher.UseVisualStyleBackColor = true;
            this.radioButtonTeacher.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Depth = 0;
            this.radioButtonStudent.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonStudent.Location = new System.Drawing.Point(117, 182);
            this.radioButtonStudent.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonStudent.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Ripple = true;
            this.radioButtonStudent.Size = new System.Drawing.Size(77, 30);
            this.radioButtonStudent.TabIndex = 16;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            this.radioButtonStudent.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButtonStudent);
            this.Controls.Add(this.radioButtonTeacher);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textFieldPassword);
            this.Controls.Add(this.textFieldUsername);
            this.Controls.Add(this.textFieldNo);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(350, 280);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Register_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldNo;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldPassword;
        private MaterialSkin.Controls.MaterialRaisedButton buttonNext;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonTeacher;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonStudent;
    }
}
