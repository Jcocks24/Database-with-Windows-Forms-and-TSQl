using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace NZPropertyBrokersFrontEnd
{
    public partial class EmployeeDataEntry : Form
    {
        public EmployeeDataEntry()
        {
            //initializes the form
            InitializeComponent();
        }

        private void EmployeeDataEntry_Load(object sender, EventArgs e)
        {
            //sets radio button Agent to unchecked
            radioButtonAgent.Checked = false;                
        }

        private void buttonSubmitAgent_Click(object sender, EventArgs e)
        {
            //reads user input and inputs into stored procedure
            queriesTableAdapter1.spAddNewAgent((Convert.ToInt32(emp_NumTextBox)), "A", Convert.ToInt32(managerTextBox.Text), emp_LnameTextBox.Text, emp_FnameTextBox.Text, emp_StreetTextBox.Text, emp_SuburbTextBox.Text, emp_CityTextBox.Text, emp_StartDateDateTimePicker.Value, agent_CertTextBox.Text, agent_AffilTextBox.Text);
            //displays confirmation message
            MessageBox.Show("Agent has been added successfully.");
            //clears and initializes form
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void buttonSubmitInspector_Click(object sender, EventArgs e)
        {
            //reads user input and inputs into stored procedure
            queriesTableAdapter1.spAddNewInspector((Convert.ToInt32(emp_NumTextBox)), "I", Convert.ToInt32(managerTextBox.Text), emp_LnameTextBox.Text, emp_FnameTextBox.Text, emp_StreetTextBox.Text, emp_SuburbTextBox.Text, emp_CityTextBox.Text, emp_StartDateDateTimePicker.Value, insp_CertTextBox.Text, Convert.ToInt32(insp_Mem_NumTextBox.Text));
            //displays confirmation message
            MessageBox.Show("Inspector has been added successfully.");
            //clears and initializes form
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void buttonSubmitOther_Click(object sender, EventArgs e)
        {
            //reads user input and inputs into stored procedure
            queriesTableAdapter1.spAddNewEmployee((Convert.ToInt32(emp_NumTextBox.Text)), "O", Convert.ToInt32(managerTextBox.Text), emp_LnameTextBox.Text, emp_FnameTextBox.Text, emp_StreetTextBox.Text, emp_SuburbTextBox.Text, emp_CityTextBox.Text, emp_StartDateDateTimePicker.Value);
            //displays confirmation message
            MessageBox.Show("Employee has been added successfully.");
            //clears and initializes form
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //creates new form object to load the form
            InspectionReport inspReport = new InspectionReport();
            inspReport.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //creates new form object to load the form
            ViewingsReport ViewReport = new ViewingsReport();
            ViewReport.Show();
        }

        private void radioButtonAgent_CheckedChanged(object sender, EventArgs e)
        {
            //sets inspector tab to disabled
            tabPageInspector.Enabled = false;
            //sets agent tab to enabled
            tabPageAgent.Enabled = true;
            //sets other tab to disabled
            tabPageOther.Enabled = false;
        }

        private void radioButtonInspector_CheckedChanged(object sender, EventArgs e)
        {
            //sets inspector tab to enabled
            tabPageInspector.Enabled = true;
            //sets agent tab to disabled
            tabPageAgent.Enabled = false;
            //sets other tab to disabled
            tabPageOther.Enabled = false;
        }

        private void radioButtonOther_CheckedChanged(object sender, EventArgs e)
        {
            //sets inspector tab to disabled
            tabPageInspector.Enabled = false;
            //sets agent tab to disabled
            tabPageAgent.Enabled = false;
            //sets other tab to enabled
            tabPageOther.Enabled = true;
        }
    }
}
