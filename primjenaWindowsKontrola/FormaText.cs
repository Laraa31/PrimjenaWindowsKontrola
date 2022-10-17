using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primjenaWindowsKontrola
{
    public partial class FormaText : Form
    {
        public string txtbProgName
        {
            get { return txtbProgName; }
            set { txtbProgName = txtbProgramName.Text; }
        }

        public string txtbProgDsript
        {
            get { return txtbProgDsript; }
            set { txtbProgDsript = txtbProgramName.Text; }
        }

        public FormaText()
        {
            InitializeComponent();
        }

        private void txtbProgramName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
           
        }
    }
}
