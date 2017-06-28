using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Alert
{
    public partial class AlertForm : Form
    {
        AlertClass Alert;
        DataTable DT;
        DAL.DataAcessLayer Flash = new DAL.DataAcessLayer();
        private void Test()
        {
            if (!Flash.Flash()) 

            {
                MessageBox.Show("There Is A Problem In Flash", "Flash Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        public AlertForm()
        {
            InitializeComponent();
        }

        private void AlertForm_Load(object sender, EventArgs e)
        {
            try
            {
                Test();
                DT = new DataTable();
                Alert = new Alert.AlertClass();
                DT = Alert.BookAlertSearch();
                DgvAlert.DataSource = DT;
                Test();
            }
            catch { return; }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnPrintThisCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Test();
                Report.BtnPrintThisAlert RPT = new Report.BtnPrintThisAlert();
                RPT.SetParameterValue("@BookId", this.DgvAlert.CurrentRow.Cells[0].Value.ToString());
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
                Report.PrintAllAlert RPT = new Report.PrintAllAlert();
                Reports.ReportForm FRM = new Reports.ReportForm();
                FRM.crystalReportViewer1.ReportSource = RPT;
                FRM.ShowDialog();
                Test();
            }
            catch { return; }
        }

    }
}
