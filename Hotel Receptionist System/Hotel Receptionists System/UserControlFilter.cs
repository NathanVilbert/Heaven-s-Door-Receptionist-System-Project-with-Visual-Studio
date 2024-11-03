using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using HotelReceptionistsSystem.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReceptionistsSystem
{
    public partial class UserControlFilter : UserControl
    {
        public UserControlFilter()
        {
            InitializeComponent();
        }

        private void UserControlFilter_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Parameter_Click(object sender, EventArgs e)
        {


        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {


        }

        private void buttonCheckOut_Click_1(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;
            string startDateFormat = startDate.ToString("dddd, MMMM d, yyyy");
            string endDateFormat = endDate.ToString("dddd, MMMM d, yyyy");


            ReportDocument reportDocument = new ReportDocument();


            reportDocument.Load("C:\\Users\\User\\Documents\\Visual Studio 2022\\HotelReceptionistsSystem\\HotelReceptionistsSystem\\HeavensDoor.rpt");


            reportDocument.SetParameterValue("StartDate", startDateFormat);
            reportDocument.SetParameterValue("EndDate", endDateFormat);
        
            tabPage2.Controls.Clear();

            CrystalReportViewer crystalReportViewer = new CrystalReportViewer();
            crystalReportViewer.Dock = DockStyle.Fill;
            crystalReportViewer.ReportSource = reportDocument;

            tabPage2.Controls.Add(crystalReportViewer);

            tabControl1.SelectedTab = tabPage2;
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
