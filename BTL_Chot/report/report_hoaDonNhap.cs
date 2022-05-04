using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Chot.report
{
    public partial class report_hoaDonNhap : Form
    {
        private int iSoHD;

        public report_hoaDonNhap(int iSoHD)
        {
            InitializeComponent();
            this.iSoHD = iSoHD;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"H:\winform\ADO\BTL_Chot\BTL_Chot\report\ChiTietMotHoaDonNhap.rpt");
            ParameterFieldDefinition pfd = rpt.DataDefinition.ParameterFields["iSoHD"];
            ParameterValues pv = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pdv.Value = iSoHD;
            pv.Add(pdv);
            pfd.CurrentValues.Clear();
            pfd.ApplyCurrentValues(pv);

            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
