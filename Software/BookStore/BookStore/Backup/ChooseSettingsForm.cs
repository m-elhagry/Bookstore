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
    public partial class ChooseSettingsForm : Form
    {
        public ChooseSettingsForm()
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
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Test();
            CreateBackUpForm Create = new CreateBackUpForm();
            Create.ShowDialog();
            Test();
            this.Close();
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            Test();
            RestoreDatabaseForm Restore = new RestoreDatabaseForm();
            Restore.ShowDialog();
            Test();
            this.Close();
        }
    }
}
