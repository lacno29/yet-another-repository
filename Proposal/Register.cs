using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Proposal
{
    public partial class Register : UserControl
    {
        DirectoryInfo programData = new DirectoryInfo(@"C:\ProgramData\PassPro\");
        String tempFile = "temp.txt";

        public Register()
        {
            if (!programData.Exists) programData.Create();
            InitializeComponent();
        }

        private void Register_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonNext.PerformClick();
            }
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonStudent.Checked)
            {
                textFieldNo.Hint = "Student No.";
            }
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTeacher.Checked)
            {
                textFieldNo.Hint = "Teacher No.";
            }
        }

        private void raisedButtonLogin_Click(object sender, EventArgs e)
        {
            if (textFieldUsername.Text.Equals("") || textFieldPassword.Text.Equals("") || textFieldNo.Text.Equals(""))
            {
                new Alert(Alert.AlertType.ERROR, "Register Failed!", "Please fill all the required information.").Show();
            }

            else if (radioButtonTeacher.Checked)
            {
                if (usernameExist(textFieldUsername.Text, 0))
                {
                    new Alert(Alert.AlertType.ERROR, "Register Failed!", "Username already exists.").Show();
                }

                else if (IDExist(textFieldNo.Text.ToUpper(), 0))
                {
                    new Alert(Alert.AlertType.ERROR, "Register Failed!", "Teacher's ID already exists.").Show();
                }

                else
                {
                    //new Alert(Alert.AlertType.INFO, "Register Success!", "").Show();
                    using (StreamWriter outfile = new StreamWriter(programData.ToString() + tempFile))
                    {
                        outfile.WriteLine(textFieldUsername.Text);
                        outfile.WriteLine(textFieldPassword.Text);
                        outfile.WriteLine(textFieldNo.Text.ToUpper());
                        outfile.WriteLine(0);
                        outfile.Flush();
                        outfile.Close();
                    }
                    Util.Animate(this, Util.Effect.Slide, 150, 0);
                }
            }
            else
            {
                if (usernameExist(textFieldUsername.Text, 1))
                {
                    new Alert(Alert.AlertType.ERROR, "Register Failed!", "Username already exists.").Show();
                }

                else if (IDExist(textFieldNo.Text.ToUpper(), 1))
                {
                    new Alert(Alert.AlertType.ERROR, "Register Failed!", "Student's ID already exists.").Show();
                }

                else
                {
                    //new Alert(Alert.AlertType.INFO, "Register Success!", "").Show();
                    using (StreamWriter outfile = new StreamWriter(programData.ToString() + tempFile))
                    {
                        outfile.WriteLine(textFieldUsername.Text);
                        outfile.WriteLine(textFieldPassword.Text);
                        outfile.WriteLine(textFieldNo.Text.ToUpper());
                        outfile.WriteLine(0);
                        outfile.Flush();
                        outfile.Close();
                    }
                    Util.Animate(this, Util.Effect.Slide, 150, 0);
                }
            }
        }

        private Boolean usernameExist(string _username, int type)
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
                        if (_username.Equals(reader["strUsername"].ToString()))
                        {
                            return true;
                        }
                    }

                    myConnection.Close();
                }
            }
            return false;
        }

        private Boolean IDExist(string _id, int type)
        {
            String query;
            using (SqlConnection myConnection = new SqlConnection(@"Data Source = Sherwin; Initial Catalog = PassPro; Integrated Security = true"))
            {
                if (type == 0)
                {
                    query = "Select * from tblTeacher where strTeacherID=@id";
                }
                else
                {
                    query = "Select * from tblStudent where strStudentID=@id";
                }
                SqlCommand command = new SqlCommand(query, myConnection);
                command.Parameters.AddWithValue("@id", _id);
                myConnection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (type == 0)
                        {
                            if (_id.Equals(reader["strTeacherID"].ToString()))
                            {
                                return true;
                            }
                        }

                        else
                        {
                            if (_id.Equals(reader["strStudentID"].ToString()))
                            {
                                return true;
                            }
                        }
                    }

                    myConnection.Close();
                }
            }
            return false;
        }
    }
}
