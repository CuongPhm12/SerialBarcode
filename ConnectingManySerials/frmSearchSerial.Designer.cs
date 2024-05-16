namespace ConnectingManySerials
{
    partial class frmSearchSerial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewSerialSearch = new MetroFramework.Controls.MetroGrid();
            this.txtSerialBarcode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.dX_TESTDataSet = new ConnectingManySerials.DX_TESTDataSet();
            this.serialDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialDTableAdapter = new ConnectingManySerials.DX_TESTDataSetTableAdapters.SerialDTableAdapter();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSerialSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dX_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewSerialSearch
            // 
            this.gridViewSerialSearch.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridViewSerialSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewSerialSearch.AutoGenerateColumns = false;
            this.gridViewSerialSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewSerialSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewSerialSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewSerialSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewSerialSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewSerialSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSerialSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.serialMDataGridViewTextBoxColumn,
            this.updTimeDataGridViewTextBoxColumn});
            this.gridViewSerialSearch.DataSource = this.serialDBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewSerialSearch.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewSerialSearch.EnableHeadersVisualStyles = false;
            this.gridViewSerialSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridViewSerialSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridViewSerialSearch.Location = new System.Drawing.Point(14, 155);
            this.gridViewSerialSearch.Name = "gridViewSerialSearch";
            this.gridViewSerialSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewSerialSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridViewSerialSearch.RowHeadersVisible = false;
            this.gridViewSerialSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.gridViewSerialSearch.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridViewSerialSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewSerialSearch.Size = new System.Drawing.Size(396, 428);
            this.gridViewSerialSearch.TabIndex = 0;
            this.gridViewSerialSearch.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridViewSerialSearch_RowPostPaint);
            this.gridViewSerialSearch.DoubleClick += new System.EventHandler(this.gridViewSerialSearch_DoubleClick);
            // 
            // txtSerialBarcode
            // 
            // 
            // 
            // 
            this.txtSerialBarcode.CustomButton.Image = null;
            this.txtSerialBarcode.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtSerialBarcode.CustomButton.Name = "";
            this.txtSerialBarcode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSerialBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSerialBarcode.CustomButton.TabIndex = 1;
            this.txtSerialBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSerialBarcode.CustomButton.UseSelectable = true;
            this.txtSerialBarcode.CustomButton.Visible = false;
            this.txtSerialBarcode.Lines = new string[0];
            this.txtSerialBarcode.Location = new System.Drawing.Point(104, 102);
            this.txtSerialBarcode.MaxLength = 32767;
            this.txtSerialBarcode.Name = "txtSerialBarcode";
            this.txtSerialBarcode.PasswordChar = '\0';
            this.txtSerialBarcode.PromptText = "Enter the Serial Barcode";
            this.txtSerialBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSerialBarcode.SelectedText = "";
            this.txtSerialBarcode.SelectionLength = 0;
            this.txtSerialBarcode.SelectionStart = 0;
            this.txtSerialBarcode.ShortcutsEnabled = true;
            this.txtSerialBarcode.Size = new System.Drawing.Size(187, 23);
            this.txtSerialBarcode.TabIndex = 1;
            this.txtSerialBarcode.UseSelectable = true;
            this.txtSerialBarcode.WaterMark = "Enter the Serial Barcode";
            this.txtSerialBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSerialBarcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(57, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 15);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Serial";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearch.Location = new System.Drawing.Point(307, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dX_TESTDataSet
            // 
            this.dX_TESTDataSet.DataSetName = "DX_TESTDataSet";
            this.dX_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serialDBindingSource
            // 
            this.serialDBindingSource.DataMember = "SerialD";
            this.serialDBindingSource.DataSource = this.dX_TESTDataSet;
            // 
            // serialDTableAdapter
            // 
            this.serialDTableAdapter.ClearBeforeFill = true;
            // 
            // No
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.No.DefaultCellStyle = dataGridViewCellStyle3;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 70;
            // 
            // serialMDataGridViewTextBoxColumn
            // 
            this.serialMDataGridViewTextBoxColumn.DataPropertyName = "SerialM";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serialMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.serialMDataGridViewTextBoxColumn.HeaderText = "Main Serial";
            this.serialMDataGridViewTextBoxColumn.Name = "serialMDataGridViewTextBoxColumn";
            this.serialMDataGridViewTextBoxColumn.Width = 175;
            // 
            // updTimeDataGridViewTextBoxColumn
            // 
            this.updTimeDataGridViewTextBoxColumn.DataPropertyName = "UpdTime";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.updTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.updTimeDataGridViewTextBoxColumn.HeaderText = "Update Time";
            this.updTimeDataGridViewTextBoxColumn.Name = "updTimeDataGridViewTextBoxColumn";
            this.updTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmSearchSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 606);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtSerialBarcode);
            this.Controls.Add(this.gridViewSerialSearch);
            this.Name = "frmSearchSerial";
            this.Text = "Search Serial";
            this.Load += new System.EventHandler(this.frmSearchSerial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSerialSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dX_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridViewSerialSearch;
        private MetroFramework.Controls.MetroTextBox txtSerialBarcode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSearch;
        private DX_TESTDataSet dX_TESTDataSet;
        private System.Windows.Forms.BindingSource serialDBindingSource;
        private DX_TESTDataSetTableAdapters.SerialDTableAdapter serialDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updTimeDataGridViewTextBoxColumn;
    }
}