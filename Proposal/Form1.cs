using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraRichEdit;
using System.IO;
using System.Data.SqlClient;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;

namespace Proposal
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        String id;
        Byte[] bytes;
        DataTable _dtRetrieve;
        int type;
        public Form1(int _type, String _id)
        {
            id = _id;
            type = _type;
            InitializeComponent();
            if (_type == 0)
            {
                _dtRetrieve = new DataTable();
                string _conStr = @"Data Source = SHERWIN; Initial Catalog = PassPro; Integrated Security = true";
                SqlConnection _sqlCon = new SqlConnection(_conStr);
                SqlCommand _sqlComm = new SqlCommand();
                _sqlComm.Connection = _sqlCon;
                _sqlComm.CommandText = "select \"tblProposals\".*, (\"tblStudent\".\"strFirstName\" + ' ' + \"tblStudent\".\"strLastName\") as \"Name\" from (\"dbo\".\"tblProposals\" \"tblProposals\" inner join \"dbo\".\"tblStudent\" \"tblStudent\" on (\"tblStudent\".\"strStudentID\" = \"tblProposals\".\"strStudentID\")) where \"tblProposals\".\"strTeacherID\" = @ID";
                _sqlComm.CommandType = CommandType.Text;
                _sqlComm.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
                SqlDataAdapter _sqlAdp = new SqlDataAdapter(_sqlComm);
                _sqlAdp.Fill(_dtRetrieve);
                colSubmittedby.FieldName = "Name";
                gridControl1.DataSource = _dtRetrieve;
            }
            else
            {
                ribbonPageGroup1.Visible = false;
                colSubmittedby.Caption = "Submitted to";
                _dtRetrieve = new DataTable();
                string _conStr = @"Data Source = SHERWIN; Initial Catalog = PassPro; Integrated Security = true";
                SqlConnection _sqlCon = new SqlConnection(_conStr);
                SqlCommand _sqlComm = new SqlCommand();
                _sqlComm.Connection = _sqlCon;
                _sqlComm.CommandText = "select \"tblProposals\".*, (\"tblTeacher\".\"strFirstName\" + ' ' + \"tblTeacher\".\"strLastName\") as \"Name\" from (\"dbo\".\"tblProposals\" \"tblProposals\" inner join \"dbo\".\"tblTeacher\" \"tblTeacher\" on (\"tblTeacher\".\"strTeacherID\" = \"tblProposals\".\"strTeacherID\")) where \"tblProposals\".\"strStudentID\" = @ID";
                _sqlComm.CommandType = CommandType.Text;
                _sqlComm.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
                SqlDataAdapter _sqlAdp = new SqlDataAdapter(_sqlComm);
                _sqlAdp.Fill(_dtRetrieve);
                colSubmittedby.FieldName = "Name";
                gridControl1.DataSource = _dtRetrieve;
            }
            Console.WriteLine(id);
            gridView1.OptionsFind.AlwaysVisible = true;
            backstageViewControl1.SelectedTab = backstageViewTabItem1;
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void backstageViewButtonItem3_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            this.Close();
        }

        private void backstageViewButtonItem1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            ((Form)this.TopLevelControl).Dispose();
            new Alert(Alert.AlertType.SUCCESS, "Logout Success", null).Show();
            Proposal.Welcome FormThread = (Proposal.Welcome)Application.OpenForms["Welcome"];
                FormThread.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Proposal.Welcome FormThread = (Proposal.Welcome)Application.OpenForms["Welcome"];
            if (FormThread != null)
                FormThread.Close();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            ((Form)this.TopLevelControl).Dispose();
            new Alert(Alert.AlertType.SUCCESS, "Logout Success", null).Show();
            Proposal.Welcome FormThread = (Proposal.Welcome)Application.OpenForms["Welcome"];
            FormThread.Show();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            richEditControl1.SaveDocument("SavedDocument.docx", DocumentFormat.OpenXml);
            FileStream fs = new FileStream("SavedDocument.docx", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            bytes = br.ReadBytes((Int32)fs.Length);
            br.Close();
            fs.Close();

            comboBox1.DataSource = GetTeachers();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "strTeacherID";

            var docServer = new RichEditDocumentServer();
            docServer.WordMLText = richEditControl1.WordMLText;
            PrintingSystem ps = new PrintingSystem();
            documentViewer1.PrintingSystem = ps;
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = docServer as IPrintable;
            link.CreateDocument();

            ribbon.ShowApplicationButtonContentControl();
            backstageViewControl1.SelectedTab = backstageViewTabItem4;

        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            //SplashScreenManager.ShowForm(typeof(WaitForm1));
            if (type == 0)
            {
                _dtRetrieve = new DataTable();
                string _conStr = @"Data Source = SHERWIN; Initial Catalog = PassPro; Integrated Security = true";
                SqlConnection _sqlCon = new SqlConnection(_conStr);
                SqlCommand _sqlComm = new SqlCommand();
                _sqlComm.Connection = _sqlCon;
                _sqlComm.CommandText = "select \"tblProposals\".*, (\"tblStudent\".\"strFirstName\" + ' ' + \"tblStudent\".\"strLastName\") as \"Name\" from (\"dbo\".\"tblProposals\" \"tblProposals\" inner join \"dbo\".\"tblStudent\" \"tblStudent\" on (\"tblStudent\".\"strStudentID\" = \"tblProposals\".\"strStudentID\")) where \"tblProposals\".\"strTeacherID\" = @ID";
                _sqlComm.CommandType = CommandType.Text;
                _sqlComm.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
                SqlDataAdapter _sqlAdp = new SqlDataAdapter(_sqlComm);
                _sqlAdp.Fill(_dtRetrieve);
                colSubmittedby.FieldName = "Name";
                gridControl1.DataSource = _dtRetrieve;
            }
            else
            {
                colSubmittedby.Caption = "Submitted to";
                _dtRetrieve = new DataTable();
                string _conStr = @"Data Source = SHERWIN; Initial Catalog = PassPro; Integrated Security = true";
                SqlConnection _sqlCon = new SqlConnection(_conStr);
                SqlCommand _sqlComm = new SqlCommand();
                _sqlComm.Connection = _sqlCon;
                _sqlComm.CommandText = "select \"tblProposals\".*, (\"tblTeacher\".\"strFirstName\" + ' ' + \"tblTeacher\".\"strLastName\") as \"Name\" from (\"dbo\".\"tblProposals\" \"tblProposals\" inner join \"dbo\".\"tblTeacher\" \"tblTeacher\" on (\"tblTeacher\".\"strTeacherID\" = \"tblProposals\".\"strTeacherID\")) where \"tblProposals\".\"strStudentID\" = @ID";
                _sqlComm.CommandType = CommandType.Text;
                _sqlComm.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
                SqlDataAdapter _sqlAdp = new SqlDataAdapter(_sqlComm);
                _sqlAdp.Fill(_dtRetrieve);
                colSubmittedby.FieldName = "Name";
                gridControl1.DataSource = _dtRetrieve;
            }
           // SplashScreenManager.CloseForm();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            foreach (int rowSelected in gridView1.GetSelectedRows())
            {
                if (_dtRetrieve != null)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source = SHERWIN; Initial Catalog = PassPro; Integrated Security = true");
                    string query = @" SELECT binaryData FROM tblProposals where intProposalID =" + (_dtRetrieve.Rows[rowSelected]["intProposalID"]).ToString();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter objAdapter = new SqlDataAdapter(command);
                    DataTable objTable = new DataTable();
                    DataRow objRow;
                    objAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    SqlCommandBuilder sqlCmdBuilder = new SqlCommandBuilder(objAdapter);
                    objAdapter.Fill(objTable);
                    objRow = objTable.Rows[0];

                    byte[] objData;
                    objData = (byte[])objRow["binaryData"];
                    FileStream objFileStream = new FileStream("DownloadedDocument.docx", FileMode.Create, FileAccess.Write);
                    objFileStream.Write(objData, 0, objData.Length);
                    objFileStream.Close();
                }
            }

            richEditControl1.LoadDocument("DownloadedDocument.docx");
            SplashScreenManager.CloseForm();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            richEditControl1.SaveDocument("SavedDocument.docx", DocumentFormat.OpenXml);
            FileStream fs = new FileStream("SavedDocument.docx", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            bytes = br.ReadBytes((Int32)fs.Length);
            br.Close();
            fs.Close();

            foreach (int rowSelected in gridView1.GetSelectedRows())
            {
                if (_dtRetrieve != null)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source = Sherwin; Initial Catalog = PassPro; Integrated Security = true");
                    SqlCommand command = new SqlCommand("UPDATE tblProposals SET binaryData = @Data WHERE intProposalID = @ID", connection);
                    command.Parameters.Add("@ID", SqlDbType.VarChar).Value = (_dtRetrieve.Rows[rowSelected]["intProposalID"]).ToString();
                    command.Parameters.Add("@Data", SqlDbType.Binary, bytes.Length).Value = bytes;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            new Alert(Alert.AlertType.SUCCESS, "Update Success!", "").Show();
        }

        public DataTable GetTeachers()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            SqlConnection _sqlConnect = new SqlConnection(@"Data Source = SHERWIN; Initial Catalog = PassPro; Integrated Security = true");
            SqlDataAdapter _sqlAdapter = new SqlDataAdapter("Select strTeacherID, (strFirstName + ' ' +strLastName) as \"Name\" FROM tblTeacher", _sqlConnect);
            DataTable _dtAuthors = new DataTable();
            _sqlAdapter.Fill(_dtAuthors);
            SplashScreenManager.CloseForm();
            return _dtAuthors;
        }

        private void recentButtonItem2_ItemClick(object sender, DevExpress.XtraBars.Ribbon.RecentItemEventArgs e)
        { /*
            SqlConnection connection = new SqlConnection(@"Data Source = SHERWIN; Initial Catalog = PassPro; Integrated Security = true");
            SqlDataAdapter objAdapter = new SqlDataAdapter("insert into tblProposals(strFilename, strStatus, strContentType, binaryData, strTeacherID, strStudentID) values (@Name, @Status, @ContentType, @Data, @TeacherID, @StudentID)", connection);
            objAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder objCmdBuilder = new SqlCommandBuilder(objAdapter);
            DataTable objTable = new DataTable();
            FileStream objFileStream = new FileStream("SavedDocument.docx", FileMode.Open, FileAccess.Read);
            int intLength = Convert.ToInt32(objFileStream.Length);
            byte[] objData;
            objData = new byte[intLength];
            DataRow objRow;
            objAdapter.Fill(objTable);

            objFileStream.Read(objData, 0, intLength);
            objFileStream.Close();

            objRow = objTable.NewRow();
            objRow["strFileName"] = textBox1.Text; //clip the full path - we just want last part!
            objRow["strStatus"] = "In-Progress";
            objRow["strContentType"] = "application/vnd.ms-word";
            objRow["binaryData"] = objData;  //our file
            objRow["strTeacherID"] = comboBox1.SelectedValue;
            objRow["strStudentID"] = id;
            objTable.Rows.Add(objRow); //add our new record
            objAdapter.Update(objTable);

            /*
            string filePath = "";
            string connectionString = "";
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            byte[] file = reader.ReadBytes((int)stream.Length);
            reader.Close();
            stream.Close();

            SqlCommand command;
            SqlConnection connection = new SqlConnection(connectionString);
            command = new SqlCommand("INSERT INTO FileTable (File) Values(@File)", connection);
            command.Parameters.Add("@File", SqlDbType.Binary, file.Length).Value = file;
            connection.Open();
            command.ExecuteNonQuery();
            */
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            string strQuery = "insert into tblProposals(strFilename, strStatus, strContentType, binaryData, strTeacherID, strStudentID) values (@Name, @Status, @ContentType, @Data, @TeacherID, @StudentID)";
            SqlCommand cmd = new SqlCommand(strQuery);
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = "In-Progress";
            cmd.Parameters.Add("@ContentType", SqlDbType.VarChar).Value = "application/vnd.ms-word";
            cmd.Parameters.Add("@Data", SqlDbType.Binary, bytes.Length).Value = bytes;
            cmd.Parameters.Add("@TeacherID", SqlDbType.VarChar).Value = comboBox1.SelectedValue;
            cmd.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = id;
            InsertUpdateData(cmd);
            SplashScreenManager.CloseForm();
            new Alert(Alert.AlertType.SUCCESS, "Upload Success!", "").Show();
            backstageViewControl1.Close();
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
                MessageBox.Show(ex.Message);
                //new Alert(Alert.AlertType.ERROR, "Upload Failed!", ex.Message).Show();
                return false;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            foreach (int rowSelected in gridView1.GetSelectedRows())
            {
                if (_dtRetrieve != null)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source = Sherwin; Initial Catalog = PassPro; Integrated Security = true");
                    SqlCommand command = new SqlCommand("UPDATE tblProposals SET strStatus = 'Accepted' WHERE intProposalID = @ID", connection);
                    command.Parameters.Add("@ID", SqlDbType.VarChar).Value = (_dtRetrieve.Rows[rowSelected]["intProposalID"]).ToString(); ;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            barButtonItem16.PerformClick();
            SplashScreenManager.CloseForm();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            foreach (int rowSelected in gridView1.GetSelectedRows())
            {
                if (_dtRetrieve != null)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source = Sherwin; Initial Catalog = PassPro; Integrated Security = true");
                    SqlCommand command = new SqlCommand("UPDATE tblProposals SET strStatus = 'Rejected' WHERE intProposalID = @ID", connection);
                    command.Parameters.Add("@ID", SqlDbType.VarChar).Value = (_dtRetrieve.Rows[rowSelected]["intProposalID"]).ToString(); ;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            barButtonItem16.PerformClick();
            SplashScreenManager.CloseForm();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            foreach (int rowSelected in gridView1.GetSelectedRows())
            {
                if (_dtRetrieve != null)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source = Sherwin; Initial Catalog = PassPro; Integrated Security = true");
                    SqlCommand command = new SqlCommand("UPDATE tblProposals SET strStatus = 'In-Progress' WHERE intProposalID = @ID", connection);
                    command.Parameters.Add("@ID", SqlDbType.VarChar).Value = (_dtRetrieve.Rows[rowSelected]["intProposalID"]).ToString(); ;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            barButtonItem16.PerformClick();
            SplashScreenManager.CloseForm();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            recentLabelItem4.Caption = getName(id,type);
            ribbon.ShowApplicationButtonContentControl();
            backstageViewControl1.SelectedTab = backstageViewTabItem3;
        }

        private String getName(string _id, int type)
        {
            String query;
            using (SqlConnection myConnection = new SqlConnection(@"Data Source = Sherwin; Initial Catalog = PassPro; Integrated Security = true"))
            {
                if (type == 0)
                {
                    query = "Select * from tblTeacher where strTeacherID=@ID";
                }
                else
                {
                    query = "Select * from tblStudent where strStudentID=@ID";
                }
                SqlCommand command = new SqlCommand(query, myConnection);
                command.Parameters.AddWithValue("@ID", _id);
                myConnection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader["strFirstName"].ToString() + " " + reader["strLastName"].ToString();
                    }

                    myConnection.Close();
                }
            }

            return null;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.defaultLookAndFeel1.LookAndFeel.SkinName = comboBox2.SelectedItem.ToString();
        }
    }
}