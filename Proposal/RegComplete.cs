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

namespace Proposal
{
    public partial class RegComplete : UserControl
    {
        DirectoryInfo programData = new DirectoryInfo(@"C:\ProgramData\PassPro\");
        String tempFile = "temp.txt";

        public RegComplete()
        {
            InitializeComponent();
        }

        private void raisedButtonLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
