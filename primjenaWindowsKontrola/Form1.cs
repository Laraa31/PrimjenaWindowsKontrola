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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRunProgram_Click(object sender, EventArgs e)
        {

  
            if (cmbRunProgram.SelectedItem.ToString() == "Notepad")
            {
                System.Diagnostics.Process.Start("notepad.exe");
                cmbRunProgram.SelectedItem = null;
            }
            else if (cmbRunProgram.SelectedItem.ToString() == "Paint")
            {
                System.Diagnostics.Process.Start("mspaint.exe");
                cmbRunProgram.SelectedItem= null;

            }
            else
            {
                MessageBox
            }
            

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbProgramName.Clear();
            txtbProgramDescription.Clear();
        }

        private void chbShowProgramAction_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowProgramAction.Checked)
            {
                gbRunProgram.Visible = false;

            }
            else
            {
                gbRunProgram.Visible = true;
            }
        }

        private void tsmiText_Click(object sender, EventArgs e)
        {
            FormaText formaText = new FormaText();

            formaText.Show();

            txtbProgramName.Text = formaText.txtbProgName;
            txtbProgramDescription.Text = formaText.txtbProgDsript;


            
            
        }
    }
}
