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
    public partial class RestoreDatabaseForm : Form
    {
        public RestoreDatabaseForm()
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
            openFileDialog1.Filter = "Backup File |*.bak";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LbLocation.Text = openFileDialog1.FileName;
            }
            Test();
        }
        private void BtnRestore_Click(object sender, EventArgs e)
        {
            DAL.DataAcessLayer DAL = new DAL.DataAcessLayer();
            try
            {
                Test();
                if (LbLocation.Text != string.Empty)
                {
                    DAL.RestorBackUp(LbLocation.Text);
                    MessageBox.Show("Successfully Restore Database", "Restore Database Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Please Choose Your Database Location", "Restore Database Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Test();
            }
            catch { return; }
        }
    }
}
