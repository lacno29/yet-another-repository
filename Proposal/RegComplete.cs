using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Proposal
{
    public partial class RegComplete : UserControl
    {
        DirectoryInfo programData = new DirectoryInfo(@"C:\ProgramData\PassPro\");
        String tempFile = "temp.txt";
        String username = null;
        String password = null;
        String id = null;
        int type;

        public RegComplete()
        {
            InitializeComponent();
        }

        private void raisedButtonLogin_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(programData.ToString() + tempFile))
            {
                String line = sr.ReadLine();
                username = line;
                line = sr.ReadLine();
                password = line;
                line = sr.ReadLine();
                id = line;
                line = sr.ReadLine();
                type = Convert.ToInt32(line);
                sr.Close();
            }

            SqlConnection _sqlConnect = new SqlConnection(@"Data Source = Sherwin; Initial Catalog = PassPro; Integrated Security = true");
            SqlCommand _sqlCommand;
            if (type == 0)
            {
                _sqlCommand = new SqlCommand("INSERT INTO tblTeacher VALUES (@id, @username, @password, @firstname, @lastname)", _sqlConnect);
            }
            else
            {
                _sqlCommand = new SqlCommand("INSERT INTO tblStudent VALUES (@id, @username, @password, @firstname, @lastname)", _sqlConnect);
            }
            _sqlCommand.Parameters.AddWithValue("@id", id);
            _sqlCommand.Parameters.AddWithValue("@username", username);
            _sqlCommand.Parameters.AddWithValue("@password", password);
            _sqlCommand.Parameters.AddWithValue("@firstname", materialSingleLineTextField3.Text);
            _sqlCommand.Parameters.AddWithValue("@lastname", materialSingleLineTextField4.Text);
            _sqlConnect.Open();
            _sqlCommand.ExecuteNonQuery();
            _sqlConnect.Close();
            new Alert(Alert.AlertType.INFO, "Register Success!", "").Show();
        }
    }
}
