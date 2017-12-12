using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Proposal
{
    public partial class Upload : DevExpress.XtraEditors.XtraForm
    {
        Byte[] bytes;
        String id;
        public Upload(Byte[] bytes1, String _id)
        {
            id = _id;
            bytes = bytes1;
            InitializeComponent();
            comboBox1.DataSource = GetTeachers();
            comboBox1.DisplayMember = "strFirstName " + "strLastName";
            comboBox1.ValueMember = "strTeacherID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strQuery = "insert into tblProposals(strFilename, strStatus, strContentType, binaryData, strTeacherID, strStudentID) values (@Name, @Status, @ContentType, @Data, @TeacherID, @StudentID)";
            SqlCommand cmd = new SqlCommand(strQuery);
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = "In-Progress";
            cmd.Parameters.Add("@ContentType", SqlDbType.VarChar).Value = "application/vnd.ms-word";
            cmd.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;
            cmd.Parameters.Add("@TeacherID", SqlDbType.VarChar).Value = comboBox1.SelectedValue;
            cmd.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = id;
            InsertUpdateData(cmd);
            this.Close();
        }

        private Boolean InsertUpdateData(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(@"Data Source = Sherwin; Initial Catalog = PassPro; Integrated Security = true");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                new Alert(Alert.AlertType.SUCCESS, "Upload Success!", "").Show();
                return true;
            }
            catch (Exception ex)
            {
                new Alert(Alert.AlertType.ERROR, "Upload Failed!", ex.Message).Show();
                return false;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private object GetTeachers()
        {
            SqlConnection _sqlConnect = new SqlConnection(@"Data Source = Sherwin; Initial Catalog = PassPro; Integrated Security = true");
            SqlDataAdapter _sqlAdapter = new SqlDataAdapter("Select strTeacherID, strFirstName, strLastName FROM tblTeacher", _sqlConnect);
            DataTable _dtTeachers = new DataTable();
            _sqlAdapter.Fill(_dtTeachers);
            return _dtTeachers;
        }
    }
}