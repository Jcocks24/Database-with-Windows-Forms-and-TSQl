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
    public partial class InspectionReport : Form
    {
        public InspectionReport()
        {
            //initializes the form
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //fills he table using the Data Set
                this.spInspectionsReportTableAdapter.Fill(this.nZPropertyBrokersDataSet1.spInspectionsReport, new System.Nullable<int>(((int)(System.Convert.ChangeType(yEARToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(mONTHToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                //displays error message
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void InspectionReport_Load(object sender, EventArgs e)
        {

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
            ViewingsReport ViewReport = new ViewingsReport();
            ViewReport.Show();
        }
    }
}
