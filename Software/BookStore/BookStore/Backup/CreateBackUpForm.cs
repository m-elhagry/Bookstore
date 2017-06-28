using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Backup
{
    public partial class CreateBackUpForm : Form
    {
        public CreateBackUpForm()
        {
            InitializeComponent();
        }
        DAL.DataAcessLayer Flash = new DAL.DataAcessLayer();
        private void Test()
        {
            if (!Flash.Flash())
            {
                MessageBox.Show("There Is A Problem In Flash", "Flash Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            Test();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                LbLocation.Text = folderBrowserDialog1.SelectedPath;
            }
            Test();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            DAL.DataAcessLayer DAL = new DAL.DataAcessLayer();
            try
            {
                Test();
                if (LbLocation.Text != string.Empty)
                {
                    DAL.MakeBackUp(LbLocation.Text + "\\STAC--" + DateTime.Now.ToShortDateString().Replace("/", "-"));
                    MessageBox.Show("Successfully Create Backup", "Create Backup Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Choose Your Backup Location", "Create Backup Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Test();
            }
            catch { return; }
        }
    }
}
