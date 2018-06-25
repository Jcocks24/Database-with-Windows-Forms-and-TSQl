namespace NZPropertyBrokersFrontEnd
{
    partial class ViewingsReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nZPropertyBrokersDataSet1 = new NZPropertyBrokersFrontEnd.NZPropertyBrokersDataSet1();
            this.spViewingsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spViewingsReportTableAdapter = new NZPropertyBrokersFrontEnd.NZPropertyBrokersDataSet1TableAdapters.spViewingsReportTableAdapter();
            this.tableAdapterManager = new NZPropertyBrokersFrontEnd.NZPropertyBrokersDataSet1TableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.yEARToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.yEARToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.mONTHToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mONTHToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.queriesTableAdapter1 = new NZPropertyBrokersFrontEnd.NZPropertyBrokersDataSetTableAdapters.QueriesTableAdapter();
            this.spViewingsReportDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nZPropertyBrokersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spViewingsReportBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spViewingsReportDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nZPropertyBrokersDataSet1
            // 
            this.nZPropertyBrokersDataSet1.DataSetName = "NZPropertyBrokersDataSet1";
            this.nZPropertyBrokersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spViewingsReportBindingSource
            // 
            this.spViewingsReportBindingSource.DataMember = "spViewingsReport";
            this.spViewingsReportBindingSource.DataSource = this.nZPropertyBrokersDataSet1;
            // 
            // spViewingsReportTableAdapter
            // 
            this.spViewingsReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CommercialTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.InspectionReportTableAdapter = null;
            this.tableAdapterManager.InspectionsTableAdapter = null;
            this.tableAdapterManager.InspectorsTableAdapter = null;
            this.tableAdapterManager.PropertiesTableAdapter = null;
            this.tableAdapterManager.ResidentialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NZPropertyBrokersFrontEnd.NZPropertyBrokersDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ViewingReportTableAdapter = null;
            this.tableAdapterManager.ViewingsTableAdapter = null;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yEARToolStripLabel,
            this.yEARToolStripTextBox,
            this.mONTHToolStripLabel,
            this.mONTHToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 24);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1087, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // yEARToolStripLabel
            // 
            this.yEARToolStripLabel.Name = "yEARToolStripLabel";
            this.yEARToolStripLabel.Size = new System.Drawing.Size(38, 22);
            this.yEARToolStripLabel.Text = "YEAR:";
            // 
            // yEARToolStripTextBox
            // 
            this.yEARToolStripTextBox.Name = "yEARToolStripTextBox";
            this.yEARToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // mONTHToolStripLabel
            // 
            this.mONTHToolStripLabel.Name = "mONTHToolStripLabel";
            this.mONTHToolStripLabel.Size = new System.Drawing.Size(55, 22);
            this.mONTHToolStripLabel.Text = "MONTH:";
            // 
            // mONTHToolStripTextBox
            // 
            this.mONTHToolStripTextBox.Name = "mONTHToolStripTextBox";
            this.mONTHToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // spViewingsReportDataGridView
            // 
            this.spViewingsReportDataGridView.AutoGenerateColumns = false;
            this.spViewingsReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spViewingsReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.spViewingsReportDataGridView.DataSource = this.spViewingsReportBindingSource;
            this.spViewingsReportDataGridView.Location = new System.Drawing.Point(66, 101);
            this.spViewingsReportDataGridView.Name = "spViewingsReportDataGridView";
            this.spViewingsReportDataGridView.Size = new System.Drawing.Size(943, 220);
            this.spViewingsReportDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Emp_Fname";
            this.dataGridViewTextBoxColumn1.HeaderText = "Emp_Fname";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Emp_Lname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Emp_Lname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Agent_Cert";
            this.dataGridViewTextBoxColumn3.HeaderText = "Agent_Cert";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prop_Num";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prop_Num";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Viewing_Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Viewing_Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Viewing_Type";
            this.dataGridViewTextBoxColumn6.HeaderText = "Viewing_Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Viewing_Numbers";
            this.dataGridViewTextBoxColumn7.HeaderText = "Viewing_Numbers";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Ven_Lname";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ven_Lname";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Prop_Price";
            this.dataGridViewTextBoxColumn9.HeaderText = "Prop_Price";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1087, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 20);
            this.toolStripMenuItem1.Text = "Insert Employee";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 20);
            this.toolStripMenuItem2.Text = "Inspections Report";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // ViewingsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 602);
            this.Controls.Add(this.spViewingsReportDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewingsReport";
            this.Text = "ViewingsReport";
            ((System.ComponentModel.ISupportInitialize)(this.nZPropertyBrokersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spViewingsReportBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spViewingsReportDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NZPropertyBrokersDataSet1 nZPropertyBrokersDataSet1;
        private System.Windows.Forms.BindingSource spViewingsReportBindingSource;
        private NZPropertyBrokersDataSet1TableAdapters.spViewingsReportTableAdapter spViewingsReportTableAdapter;
        private NZPropertyBrokersDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel yEARToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox yEARToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel mONTHToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox mONTHToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private NZPropertyBrokersDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridView spViewingsReportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}