using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Author
{
    public partial class SettingAuthorForm : Form
    {
        public SettingAuthorForm()
        {
            InitializeComponent();
        }
        AuthorClass Author;
        DAL.DataAcessLayer Flash = new DAL.DataAcessLayer();
        private void Test()
        {
            if (!Flash.Flash())
            {
                MessageBox.Show("There Is A Problem In Flash", "Flash Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void SettingAuthorForm_Load(object sender, EventArgs e)
        {
            Test();
            Author = new AuthorClass();
            DgvAuthor.DataSource = Author.BookAuthorSearchAll("");
            Test();
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            Author = new AuthorClass();
            DgvAuthor.DataSource = Author.BookAuthorSearchAll(TxtSearch.Text);
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddNewAuthor Authors = new AddNewAuthor();
            Author = new AuthorClass();
            Authors.ShowDialog();
            DgvAuthor.DataSource = Author.BookAuthorSearchAll(TxtSearch.Text);
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Test();
            Author = new AuthorClass();
            AddNewAuthor Authors = new AddNewAuthor();
            Authors.AddState = false;
            Authors.BtnSave.Text = "Update";
            Authors.TxtId.Text = this.DgvAuthor.CurrentRow.Cells[0].Value.ToString();
            Authors.TxtName.Text = this.DgvAuthor.CurrentRow.Cells[1].Value.ToString();
            Authors.NameForUpdate = this.DgvAuthor.CurrentRow.Cells[1].Value.ToString();
            Authors.ShowDialog();
            DgvAuthor.DataSource = Author.BookAuthorSearchAll(TxtSearch.Text);
            Test();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Test();
            Author = new AuthorClass();
            Author.AuthorDelete(Convert.ToInt32(DgvAuthor.CurrentRow.Cells[0].Value.ToString()));
            MessageBox.Show("Deleted Successfully", "Author Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DgvAuthor.DataSource = Author.BookAuthorSearchAll(TxtSearch.Text);
            Test();
        }
        private void BtnPrintProducts_Click(object sender, EventArgs e)
        {
            try
            {
                Test();
                Report.PrintAuthorBooks RPT = new Report.PrintAuthorBooks();
                RPT.SetParameterValue("@BookAuthor", this.DgvAuthor.CurrentRow.Cells[0].Value.ToString());
                Reports.ReportForm FRM = new Reports.ReportForm();
                FRM.crystalReportViewer1.ReportSource = RPT;
                FRM.ShowDialog();
                Test();
            }
            catch { return; }
        }
        private void BtnPrintThisCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Test();
                Report.PrintThisAuthor RPT = new Report.PrintThisAuthor();
                RPT.SetParameterValue("@AuthorName", this.DgvAuthor.CurrentRow.Cells[1].Value.ToString());
                Reports.ReportForm FRM = new Reports.ReportForm();
                FRM.crystalReportViewer1.ReportSource = RPT;
                FRM.ShowDialog();
                Test();
            }
            catch { return; }
        }
        private void BtnPrintAllCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Test();
                Report.PrintAuthorList RPT = new Report.PrintAuthorList();
                RPT.SetParameterValue("@SearchWord", TxtSearch.Text);
                Reports.ReportForm FRM = new Reports.ReportForm();
                FRM.crystalReportViewer1.ReportSource = RPT;
                FRM.ShowDialog();
                Test();
            }
            catch { return; }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
