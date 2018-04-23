using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;

namespace XtraGridExportViewAsPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridView View = gridControl1.MainView as GridView;
            if (View != null)
            {
                View.ExportToPdf("MainViewData.pdf");

                // The following requires Adobe Reader to be installed on the system
                Process pdfExport = new Process();
                pdfExport.StartInfo.FileName = "AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "MainViewData.pdf";
                pdfExport.Start();
            }
        }
    }
}
