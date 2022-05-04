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
    public partial class gui_report2dieukien : Form
    {
        private int maNV;
        private DateTime ngaylapMin;
        private DateTime ngayLapMax;

        public gui_report2dieukien(int maNV, DateTime ngaylapMin, DateTime ngayLapMax)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.ngayLapMax = ngayLapMax;
            this.ngaylapMin = ngaylapMin;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"H:\winform\GUI\BTL_Chot\BTL_Chot\report\reportTwoDieuKien.rpt");
            ParameterFieldDefinition pfd = rpt.DataDefinition.ParameterFields["@iMaNV"];
            ParameterValues pv = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pdv.Value = maNV;
            pv.Add(pdv);
            pfd.CurrentValues.Clear();
            pfd.ApplyCurrentValues(pv);

            pfd = rpt.DataDefinition.ParameterFields["@dNgayNhapMin"];
            pv = new ParameterValues();
            pdv = new ParameterDiscreteValue();
            pdv.Value = ngaylapMin;
            pv.Add(pdv);
            pfd.CurrentValues.Clear();
            pfd.ApplyCurrentValues(pv);

            pfd = rpt.DataDefinition.ParameterFields["@dNgayNhapMax"];
            pv = new ParameterValues();
            pdv = new ParameterDiscreteValue();
            pdv.Value = ngayLapMax;
            pv.Add(pdv);
            pfd.CurrentValues.Clear();
            pfd.ApplyCurrentValues(pv);


            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
