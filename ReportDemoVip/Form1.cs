using Microsoft.Reporting.WinForms;
using ReportDemoVip.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportDemoVip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SachContext context = new SachContext();
            List<SACH> listSach = context.SACHes.ToList();
            List<SachReport> listReport = new List<SachReport>();
            foreach (SACH sach in listSach)
            {
                SachReport temp = new SachReport();
                temp.MaSach = sach.MaSach;
                temp.TenSach = sach.TenSach;
                temp.NamXuatBan = sach.NamXuatBan;
                temp.TenLoai = sach.LOAISACH.TenLoai;
                listReport.Add(temp);
            }
            reportViewer1.LocalReport.ReportPath = "rptSach.rdlc";
            var source = new ReportDataSource("SachDatasets", listReport);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
