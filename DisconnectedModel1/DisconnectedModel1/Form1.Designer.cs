namespace DisconnectedModel1
{
    partial class Form1
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
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAirflight = new System.Windows.Forms.TextBox();
            this.tbFlightNo = new System.Windows.Forms.TextBox();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.cmbAirplane = new System.Windows.Forms.ComboBox();
            this.cmbFlight = new System.Windows.Forms.ComboBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.week5DataSet = new DisconnectedModel1.Week5DataSet();
            this.week5DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightInfo1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightInfo1TableAdapter = new DisconnectedModel1.Week5DataSetTableAdapters.FlightInfo1TableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airplaneTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.week5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.week5DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfo1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(62, 61);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(47, 17);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Airline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fligt Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Airplane Type";
            // 
            // tbAirflight
            // 
            this.tbAirflight.Location = new System.Drawing.Point(157, 55);
            this.tbAirflight.Name = "tbAirflight";
            this.tbAirflight.Size = new System.Drawing.Size(100, 22);
            this.tbAirflight.TabIndex = 4;
            // 
            // tbFlightNo
            // 
            this.tbFlightNo.Location = new System.Drawing.Point(157, 93);
            this.tbFlightNo.Name = "tbFlightNo";
            this.tbFlightNo.Size = new System.Drawing.Size(100, 22);
            this.tbFlightNo.TabIndex = 5;
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(157, 128);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(100, 22);
            this.tbDestination.TabIndex = 6;
            // 
            // cmbAirplane
            // 
            this.cmbAirplane.FormattingEnabled = true;
            this.cmbAirplane.Items.AddRange(new object[] {
            "Airbus340",
            "Boeing 747",
            "Boeing 777",
            "Boeing 787",
            "Boeing 727"});
            this.cmbAirplane.Location = new System.Drawing.Point(157, 161);
            this.cmbAirplane.Name = "cmbAirplane";
            this.cmbAirplane.Size = new System.Drawing.Size(121, 24);
            this.cmbAirplane.TabIndex = 7;
            // 
            // cmbFlight
            // 
            this.cmbFlight.DataSource = this.flightInfo1BindingSource;
            this.cmbFlight.DisplayMember = "FlightNum";
            this.cmbFlight.FormattingEnabled = true;
            this.cmbFlight.Location = new System.Drawing.Point(157, 15);
            this.cmbFlight.Name = "cmbFlight";
            this.cmbFlight.Size = new System.Drawing.Size(121, 24);
            this.cmbFlight.TabIndex = 8;
            this.cmbFlight.ValueMember = "ID";
            this.cmbFlight.SelectedIndexChanged += new System.EventHandler(this.cmbFlight_SelectedIndexChanged);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(558, 22);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(120, 23);
            this.btnUser.TabIndex = 9;
            this.btnUser.Text = "Update User";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(558, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(558, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(558, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.airLineDataGridViewTextBoxColumn,
            this.flightNumDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.airplaneTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flightInfo1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 230);
            this.dataGridView1.TabIndex = 13;
            // 
            // week5DataSet
            // 
            this.week5DataSet.DataSetName = "Week5DataSet";
            this.week5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // week5DataSetBindingSource
            // 
            this.week5DataSetBindingSource.DataSource = this.week5DataSet;
            this.week5DataSetBindingSource.Position = 0;
            // 
            // flightInfo1BindingSource
            // 
            this.flightInfo1BindingSource.DataMember = "FlightInfo1";
            this.flightInfo1BindingSource.DataSource = this.week5DataSetBindingSource;
            // 
            // flightInfo1TableAdapter
            // 
            this.flightInfo1TableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // airLineDataGridViewTextBoxColumn
            // 
            this.airLineDataGridViewTextBoxColumn.DataPropertyName = "AirLine";
            this.airLineDataGridViewTextBoxColumn.HeaderText = "AirLine";
            this.airLineDataGridViewTextBoxColumn.Name = "airLineDataGridViewTextBoxColumn";
            // 
            // flightNumDataGridViewTextBoxColumn
            // 
            this.flightNumDataGridViewTextBoxColumn.DataPropertyName = "FlightNum";
            this.flightNumDataGridViewTextBoxColumn.HeaderText = "FlightNum";
            this.flightNumDataGridViewTextBoxColumn.Name = "flightNumDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // airplaneTypeDataGridViewTextBoxColumn
            // 
            this.airplaneTypeDataGridViewTextBoxColumn.DataPropertyName = "AirplaneType";
            this.airplaneTypeDataGridViewTextBoxColumn.HeaderText = "AirplaneType";
            this.airplaneTypeDataGridViewTextBoxColumn.Name = "airplaneTypeDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.cmbFlight);
            this.Controls.Add(this.cmbAirplane);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.tbFlightNo);
            this.Controls.Add(this.tbAirflight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.week5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.week5DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfo1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAirflight;
        private System.Windows.Forms.TextBox tbFlightNo;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.ComboBox cmbAirplane;
        private System.Windows.Forms.ComboBox cmbFlight;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource week5DataSetBindingSource;
        private Week5DataSet week5DataSet;
        private System.Windows.Forms.BindingSource flightInfo1BindingSource;
        private Week5DataSetTableAdapters.FlightInfo1TableAdapter flightInfo1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airplaneTypeDataGridViewTextBoxColumn;
    }
}

