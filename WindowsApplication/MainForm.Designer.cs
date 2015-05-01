namespace WindowsApplication
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Column1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.procedureNameUpdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.procedureNameDelete = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.procedureNameCreate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.procedureNameRead = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TexasSwedeLogo = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ProducerCode = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.AgencyZIP = new System.Windows.Forms.TextBox();
            this.AgencyState = new System.Windows.Forms.TextBox();
            this.AgencyCity = new System.Windows.Forms.TextBox();
            this.AgencyAddress2 = new System.Windows.Forms.TextBox();
            this.AgencyAddress1 = new System.Windows.Forms.TextBox();
            this.AgencyName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serverName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TexasSwedeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Column1
            // 
            this.Column1.AutoSize = true;
            this.Column1.Location = new System.Drawing.Point(17, 149);
            this.Column1.Name = "Column1";
            this.Column1.Size = new System.Drawing.Size(0, 13);
            this.Column1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.procedureNameUpdate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.procedureNameDelete);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.procedureNameCreate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.procedureNameRead);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(400, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 128);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stored Procedures";
            // 
            // procedureNameUpdate
            // 
            this.procedureNameUpdate.Location = new System.Drawing.Point(83, 71);
            this.procedureNameUpdate.Name = "procedureNameUpdate";
            this.procedureNameUpdate.Size = new System.Drawing.Size(211, 20);
            this.procedureNameUpdate.TabIndex = 16;
            this.procedureNameUpdate.Text = "UpdateAgency";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Update:";
            // 
            // procedureNameDelete
            // 
            this.procedureNameDelete.Location = new System.Drawing.Point(83, 97);
            this.procedureNameDelete.Name = "procedureNameDelete";
            this.procedureNameDelete.Size = new System.Drawing.Size(211, 20);
            this.procedureNameDelete.TabIndex = 14;
            this.procedureNameDelete.Text = "DeleteAgency";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Delete:";
            // 
            // procedureNameCreate
            // 
            this.procedureNameCreate.Location = new System.Drawing.Point(83, 19);
            this.procedureNameCreate.Name = "procedureNameCreate";
            this.procedureNameCreate.Size = new System.Drawing.Size(211, 20);
            this.procedureNameCreate.TabIndex = 12;
            this.procedureNameCreate.Text = "CreateAgency";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Create:";
            // 
            // procedureNameRead
            // 
            this.procedureNameRead.Location = new System.Drawing.Point(83, 45);
            this.procedureNameRead.Name = "procedureNameRead";
            this.procedureNameRead.Size = new System.Drawing.Size(211, 20);
            this.procedureNameRead.TabIndex = 10;
            this.procedureNameRead.Text = "ReadAgency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Read:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 35);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // TexasSwedeLogo
            // 
            this.TexasSwedeLogo.Image = ((System.Drawing.Image)(resources.GetObject("TexasSwedeLogo.Image")));
            this.TexasSwedeLogo.Location = new System.Drawing.Point(259, 469);
            this.TexasSwedeLogo.Name = "TexasSwedeLogo";
            this.TexasSwedeLogo.Size = new System.Drawing.Size(206, 42);
            this.TexasSwedeLogo.TabIndex = 28;
            this.TexasSwedeLogo.TabStop = false;
            this.TexasSwedeLogo.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(23, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(682, 239);
            this.dataGridView1.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.ProducerCode);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.AgencyZIP);
            this.panel1.Controls.Add(this.AgencyState);
            this.panel1.Controls.Add(this.AgencyCity);
            this.panel1.Controls.Add(this.AgencyAddress2);
            this.panel1.Controls.Add(this.AgencyAddress1);
            this.panel1.Controls.Add(this.AgencyName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Column3);
            this.panel1.Controls.Add(this.Column2);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Location = new System.Drawing.Point(23, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 165);
            this.panel1.TabIndex = 31;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.Location = new System.Drawing.Point(163, 136);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 22);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Location = new System.Drawing.Point(236, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 22);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCreate.Location = new System.Drawing.Point(88, 136);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(69, 22);
            this.btnCreate.TabIndex = 45;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClear.Location = new System.Drawing.Point(236, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 22);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ProducerCode
            // 
            this.ProducerCode.Location = new System.Drawing.Point(88, 4);
            this.ProducerCode.Name = "ProducerCode";
            this.ProducerCode.Size = new System.Drawing.Size(69, 20);
            this.ProducerCode.TabIndex = 43;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(2, 7);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(81, 13);
            this.Label5.TabIndex = 42;
            this.Label5.Text = "Producer Code:";
            // 
            // AgencyZIP
            // 
            this.AgencyZIP.Location = new System.Drawing.Point(248, 110);
            this.AgencyZIP.Name = "AgencyZIP";
            this.AgencyZIP.Size = new System.Drawing.Size(51, 20);
            this.AgencyZIP.TabIndex = 41;
            // 
            // AgencyState
            // 
            this.AgencyState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AgencyState.Location = new System.Drawing.Point(213, 109);
            this.AgencyState.Name = "AgencyState";
            this.AgencyState.Size = new System.Drawing.Size(29, 20);
            this.AgencyState.TabIndex = 40;
            // 
            // AgencyCity
            // 
            this.AgencyCity.Location = new System.Drawing.Point(88, 109);
            this.AgencyCity.Name = "AgencyCity";
            this.AgencyCity.Size = new System.Drawing.Size(119, 20);
            this.AgencyCity.TabIndex = 39;
            // 
            // AgencyAddress2
            // 
            this.AgencyAddress2.Location = new System.Drawing.Point(88, 85);
            this.AgencyAddress2.Name = "AgencyAddress2";
            this.AgencyAddress2.Size = new System.Drawing.Size(211, 20);
            this.AgencyAddress2.TabIndex = 38;
            // 
            // AgencyAddress1
            // 
            this.AgencyAddress1.Location = new System.Drawing.Point(88, 59);
            this.AgencyAddress1.Name = "AgencyAddress1";
            this.AgencyAddress1.Size = new System.Drawing.Size(211, 20);
            this.AgencyAddress1.TabIndex = 37;
            // 
            // AgencyName
            // 
            this.AgencyName.Location = new System.Drawing.Point(88, 35);
            this.AgencyName.Name = "AgencyName";
            this.AgencyName.Size = new System.Drawing.Size(211, 20);
            this.AgencyName.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "AgencyName:";
            // 
            // Column3
            // 
            this.Column3.AutoSize = true;
            this.Column3.Location = new System.Drawing.Point(2, 57);
            this.Column3.Name = "Column3";
            this.Column3.Size = new System.Drawing.Size(0, 13);
            this.Column3.TabIndex = 32;
            // 
            // Column2
            // 
            this.Column2.AutoSize = true;
            this.Column2.Location = new System.Drawing.Point(2, 35);
            this.Column2.Name = "Column2";
            this.Column2.Size = new System.Drawing.Size(0, 13);
            this.Column2.TabIndex = 31;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLoad.Location = new System.Drawing.Point(163, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(65, 22);
            this.btnLoad.TabIndex = 30;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.serverName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dbName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(400, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 55);
            this.panel2.TabIndex = 32;
            // 
            // serverName
            // 
            this.serverName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.serverName.Location = new System.Drawing.Point(83, 3);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(209, 20);
            this.serverName.TabIndex = 26;
            this.serverName.Text = "ParaSQL1\\para_prod";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Server:";
            // 
            // dbName
            // 
            this.dbName.Location = new System.Drawing.Point(83, 29);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(209, 20);
            this.dbName.TabIndex = 24;
            this.dbName.Text = "AgencyPortal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Database:";
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(WindowsApplication.Program);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(729, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TexasSwedeLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Column1);
            this.Name = "frmMain";
            this.Text = "SQL Test Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TexasSwedeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Column1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox procedureNameUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox procedureNameDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox procedureNameCreate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox procedureNameRead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox TexasSwedeLogo;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox ProducerCode;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox AgencyZIP;
        private System.Windows.Forms.TextBox AgencyState;
        private System.Windows.Forms.TextBox AgencyCity;
        private System.Windows.Forms.TextBox AgencyAddress2;
        private System.Windows.Forms.TextBox AgencyAddress1;
        private System.Windows.Forms.TextBox AgencyName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Column3;
        private System.Windows.Forms.Label Column2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dbName;
        private System.Windows.Forms.Label label1;
    }
}

