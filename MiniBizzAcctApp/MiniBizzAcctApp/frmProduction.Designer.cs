namespace MiniBizzAcctApp
{
    partial class frmProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduction));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateTimePickerProduction = new System.Windows.Forms.TextBox();
            this.salesProductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakayMiniBizzDataSet = new MiniBizzAcctApp.BakayMiniBizzDataSet();
            this.cboProductDescription = new System.Windows.Forms.ComboBox();
            this.inventoryMaintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTotalSalesPrice = new System.Windows.Forms.TextBox();
            this.txtSalesPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.customerMaintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Production = new System.Windows.Forms.Label();
            this.inventoryMaintenanceTableAdapter = new MiniBizzAcctApp.BakayMiniBizzDataSetTableAdapters.InventoryMaintenanceTableAdapter();
            this.customerMaintenanceTableAdapter = new MiniBizzAcctApp.BakayMiniBizzDataSetTableAdapters.CustomerMaintenanceTableAdapter();
            this.salesProductionTableAdapter = new MiniBizzAcctApp.BakayMiniBizzDataSetTableAdapters.SalesProductionTableAdapter();
            this.fKSalesProductionCustomerMaintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesProductionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakayMiniBizzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMaintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerMaintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesProductionCustomerMaintenanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.DateTimePickerProduction);
            this.panel1.Controls.Add(this.cboProductDescription);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtTotalSalesPrice);
            this.panel1.Controls.Add(this.txtSalesPrice);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboCustomerName);
            this.panel1.Controls.Add(this.txtCustomerID);
            this.panel1.Controls.Add(this.txtProductCode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 315);
            this.panel1.TabIndex = 0;
            // 
            // DateTimePickerProduction
            // 
            this.DateTimePickerProduction.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesProductionBindingSource, "SalesDate", true));
            this.DateTimePickerProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerProduction.Location = new System.Drawing.Point(290, 171);
            this.DateTimePickerProduction.Name = "DateTimePickerProduction";
            this.DateTimePickerProduction.Size = new System.Drawing.Size(248, 26);
            this.DateTimePickerProduction.TabIndex = 26;
            // 
            // salesProductionBindingSource
            // 
            this.salesProductionBindingSource.DataMember = "SalesProduction";
            this.salesProductionBindingSource.DataSource = this.bakayMiniBizzDataSet;
            // 
            // bakayMiniBizzDataSet
            // 
            this.bakayMiniBizzDataSet.DataSetName = "BakayMiniBizzDataSet";
            this.bakayMiniBizzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboProductDescription
            // 
            this.cboProductDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryMaintenanceBindingSource, "ProductionDescription", true));
            this.cboProductDescription.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductDescription.FormattingEnabled = true;
            this.cboProductDescription.Location = new System.Drawing.Point(290, 220);
            this.cboProductDescription.Name = "cboProductDescription";
            this.cboProductDescription.Size = new System.Drawing.Size(248, 30);
            this.cboProductDescription.TabIndex = 25;
            // 
            // inventoryMaintenanceBindingSource
            // 
            this.inventoryMaintenanceBindingSource.DataMember = "InventoryMaintenance";
            this.inventoryMaintenanceBindingSource.DataSource = this.bakayMiniBizzDataSet;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.DarkRed;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnter.Location = new System.Drawing.Point(649, 263);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(122, 39);
            this.btnEnter.TabIndex = 24;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkRed;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Snow;
            this.btnPrint.Location = new System.Drawing.Point(788, 263);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 39);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.Maroon;
            this.btnExcel.Location = new System.Drawing.Point(523, 265);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(102, 38);
            this.btnExcel.TabIndex = 22;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Maroon;
            this.btnCalculate.Location = new System.Drawing.Point(386, 265);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 39);
            this.btnCalculate.TabIndex = 21;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Maroon;
            this.btnClear.Location = new System.Drawing.Point(263, 264);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 39);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancel.Location = new System.Drawing.Point(148, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 39);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Location = new System.Drawing.Point(24, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 39);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTotalSalesPrice
            // 
            this.txtTotalSalesPrice.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSalesPrice.Location = new System.Drawing.Point(692, 114);
            this.txtTotalSalesPrice.Name = "txtTotalSalesPrice";
            this.txtTotalSalesPrice.Size = new System.Drawing.Size(197, 29);
            this.txtTotalSalesPrice.TabIndex = 17;
            this.txtTotalSalesPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryMaintenanceBindingSource, "UnitPrice", true));
            this.txtSalesPrice.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesPrice.Location = new System.Drawing.Point(692, 71);
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.Size = new System.Drawing.Size(197, 29);
            this.txtSalesPrice.TabIndex = 16;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(692, 25);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(197, 29);
            this.txtQuantity.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(575, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 26);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(575, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Unit Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(575, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantity:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerMaintenanceBindingSource, "Name", true));
            this.cboCustomerName.DataSource = this.salesProductionBindingSource;
            this.cboCustomerName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.Location = new System.Drawing.Point(290, 123);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(248, 30);
            this.cboCustomerName.TabIndex = 11;
            // 
            // customerMaintenanceBindingSource
            // 
            this.customerMaintenanceBindingSource.DataMember = "CustomerMaintenance";
            this.customerMaintenanceBindingSource.DataSource = this.bakayMiniBizzDataSet;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerMaintenanceBindingSource, "CustomerID", true));
            this.txtCustomerID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(290, 68);
            this.txtCustomerID.Multiline = true;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(248, 32);
            this.txtCustomerID.TabIndex = 6;
            // 
            // txtProductCode
            // 
            this.txtProductCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryMaintenanceBindingSource, "ProductCode", true));
            this.txtProductCode.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(290, 22);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(248, 29);
            this.txtProductCode.TabIndex = 5;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(19, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Production Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(19, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sales Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(19, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Code:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(371, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 152);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales";
            // 
            // Production
            // 
            this.Production.AutoSize = true;
            this.Production.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Production.Location = new System.Drawing.Point(529, 131);
            this.Production.Name = "Production";
            this.Production.Size = new System.Drawing.Size(121, 33);
            this.Production.TabIndex = 2;
            this.Production.Text = "Production";
            // 
            // inventoryMaintenanceTableAdapter
            // 
            this.inventoryMaintenanceTableAdapter.ClearBeforeFill = true;
            // 
            // customerMaintenanceTableAdapter
            // 
            this.customerMaintenanceTableAdapter.ClearBeforeFill = true;
            // 
            // salesProductionTableAdapter
            // 
            this.salesProductionTableAdapter.ClearBeforeFill = true;
            // 
            // fKSalesProductionCustomerMaintenanceBindingSource
            // 
            this.fKSalesProductionCustomerMaintenanceBindingSource.DataMember = "FK_SalesProduction_CustomerMaintenance";
            this.fKSalesProductionCustomerMaintenanceBindingSource.DataSource = this.customerMaintenanceBindingSource;
            // 
            // frmProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(953, 540);
            this.Controls.Add(this.Production);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmProduction";
            this.Text = "Sales Production 1.0";
            this.Load += new System.EventHandler(this.frmSalesProduction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesProductionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakayMiniBizzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMaintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerMaintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesProductionCustomerMaintenanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Production;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.ComboBox cboCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalSalesPrice;
        private System.Windows.Forms.TextBox txtSalesPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboProductDescription;
        private BakayMiniBizzDataSet bakayMiniBizzDataSet;
        private System.Windows.Forms.BindingSource inventoryMaintenanceBindingSource;
        private BakayMiniBizzDataSetTableAdapters.InventoryMaintenanceTableAdapter inventoryMaintenanceTableAdapter;
        private System.Windows.Forms.BindingSource customerMaintenanceBindingSource;
        private BakayMiniBizzDataSetTableAdapters.CustomerMaintenanceTableAdapter customerMaintenanceTableAdapter;
        private System.Windows.Forms.BindingSource salesProductionBindingSource;
        private BakayMiniBizzDataSetTableAdapters.SalesProductionTableAdapter salesProductionTableAdapter;
        private System.Windows.Forms.BindingSource fKSalesProductionCustomerMaintenanceBindingSource;
        private System.Windows.Forms.TextBox DateTimePickerProduction;
    }
}