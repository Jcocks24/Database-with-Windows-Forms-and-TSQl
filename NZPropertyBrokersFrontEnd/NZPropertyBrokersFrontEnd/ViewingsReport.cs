using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NZPropertyBrokersFrontEnd
{
    public partial class ViewingsReport : Form
    {
        public ViewingsReport()
        {
            //initializes the form
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //fills he table using the Data Set
                this.spViewingsReportTableAdapter.Fill(this.nZPropertyBrokersDataSet1.spViewingsReport, new System.Nullable<int>(((int)(System.Convert.ChangeType(yEARToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(mONTHToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                //displays error message
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //creates new form object to load the form
            EmployeeDataEntry InsertEmployee = new EmployeeDataEntry();
            InsertEmployee.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //creates new form object to load the form
            InspectionReport inspReport = new InspectionReport();
            inspReport.Show();
        }
    }
}
