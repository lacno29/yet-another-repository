using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Data.SqlClient;

namespace Proposal
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void raisedButtonLogin_Click(object sender, EventArgs e)
        {
            if (textFieldUsername.Text.Equals("") || textFieldPassword.Text.Equals(""))
            {
                new Alert(Alert.AlertType.ERROR, "Login Failed", "Please fill all the required information.").Show();
            }

            else if (textFieldUsername.Text.Equals("admin") && textFieldPassword.Text.Equals("admin"))
            {
                ((Form)this.TopLevelControl).Hide();

                //Proposal.Welcome FormThread = (Proposal.Welcome)Application.OpenForms["Welcome"];
                //FormThread.Close();

                //Welcome infoScreen = (Welcome)this.Parent;
                //infoScreen.Close();
                textFieldPassword.Text = "";
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                new Form1(0,"admin").Show();
                new Alert(Alert.AlertType.SUCCESS, "Login Success", null).Show();
                SplashScreenManager.CloseForm();

            }

            else if (materialRadioButton1.Checked)
            {
                if (loginAttempt(textFieldUsername.Text, textFieldPassword.Text, 0))
                {
                    ((Form)this.TopLevelControl).Hide();
                    textFieldPassword.Text = "";
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    new Form1(0, getID(textFieldUsername.Text, textFieldPassword.Text, 0)).Show();
                    new Alert(Alert.AlertType.SUCCESS, "Login Success", null).Show();
                    SplashScreenManager.CloseForm();
                }

                else
                {
                    new Alert(Alert.AlertType.ERROR, "Login Failed", "Invalid Username and Password.").Show();
                }
            }

            else
            {
                if (loginAttempt(textFieldUsername.Text, textFieldPassword.Text, 1))
                {
                    ((Form)this.TopLevelControl).Hide();
                    textFieldPassword.Text = "";
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    new Form1(1, getID(textFieldUsername.Text, textFieldPassword.Text, 1)).Show();
                    new Alert(Alert.AlertType.SUCCESS, "Login Success", null).Show();
                    SplashScreenManager.CloseForm();
                }

                else
                {
                    new Alert(Alert.AlertType.ERROR, "Login Failed", "Invalid Username and Password.").Show();
                }
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                raisedButtonLogin.PerformClick();
            }
        }

        private void textFieldUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                raisedButtonLogin.PerformClick();
            }
        }

        private void textFieldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                raisedButtonLogin.PerformClick();
            }
        }

        private void materialRadioButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                raisedButtonLogin.PerformClick();
            }
        }

        private void materialRadioButton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                raisedButtonLogin.PerformClick();
            }
        }

        private Boolean loginAttempt(string _username, String _password, int type)
        {
            String query;
            using (SqlConnection myConnection = new SqlConnection(@"Data Source = Sherwin; Initial Catalog = PassPro; Integrated Security = true"))
            {
                if (type == 0)
                {
                    query = "Select * from tblTeacher where strUsername=@strUsername";
                }
                else
                {
                    query = "Select * from tblStudent where strUsername=@strUsername";
                }
                SqlCommand command = new SqlCommand(query, myConnection);
                command.Parameters.AddWithValue("@strUsername", _username);
                myConnection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (_password.Equals(reader["strPassword"].ToString()))
                        {
                            return true;
                        }
                    }

                    myConnection.Close();
                }
            }
            return false;
        }

        private String getID(string _username, String _password, int type)
        {
            String query;
            using (SqlConnection myConnection = new SqlConnection(@"Data Source = Sherwin; Initial Catalog = PassPro; Integrated Security = true"))
            {
                if (type == 0)
                {
                    query = "Select * from tblTeacher where strUsername=@strUsername";
                }
                else
                {
                    query = "Select * from tblStudent where strUsername=@strUsername";
                }
                SqlCommand command = new SqlCommand(query, myConnection);
                command.Parameters.AddWithValue("@strUsername", _username);
                myConnection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (type == 0)
                            return reader["strTeacherID"].ToString();
                        else
                            return reader["strStudentID"].ToString();
                    }

                    myConnection.Close();
                }
            }

            return null;
        }
    }
}
