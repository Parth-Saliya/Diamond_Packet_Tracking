namespace Packet_Tracking
{
    partial class F_Packet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnDeletePacket = new System.Windows.Forms.Button();
            this.BtnUpdatePacket = new System.Windows.Forms.Button();
            this.BtnAddPacket = new System.Windows.Forms.Button();
            this.txtparty = new System.Windows.Forms.ComboBox();
            this.userTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packetDataSet1 = new Packet_Tracking.packetDataSet1();
            this.txtpacket = new System.Windows.Forms.ComboBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtpcs = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtkapan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.userTbTableAdapter = new Packet_Tracking.packetDataSet1TableAdapters.userTbTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.cbsf = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 38);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(500, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 32);
            this.button1.TabIndex = 205;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(327, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 32);
            this.button5.TabIndex = 2;
            this.button5.Text = "Return";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(203, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 32);
            this.button4.TabIndex = 1;
            this.button4.Text = "Issue";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(77, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 32);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add User";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbsf);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.BtnDeletePacket);
            this.panel2.Controls.Add(this.BtnUpdatePacket);
            this.panel2.Controls.Add(this.BtnAddPacket);
            this.panel2.Controls.Add(this.txtparty);
            this.panel2.Controls.Add(this.txtpacket);
            this.panel2.Controls.Add(this.txtdate);
            this.panel2.Controls.Add(this.txtpcs);
            this.panel2.Controls.Add(this.txtweight);
            this.panel2.Controls.Add(this.txtkapan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 552);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold);
            this.txtid.Location = new System.Drawing.Point(113, 13);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(122, 30);
            this.txtid.TabIndex = 0;
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 237);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.Size = new System.Drawing.Size(525, 230);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(422, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnDeletePacket
            // 
            this.BtnDeletePacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletePacket.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletePacket.ForeColor = System.Drawing.Color.Black;
            this.BtnDeletePacket.Location = new System.Drawing.Point(287, 175);
            this.BtnDeletePacket.Name = "BtnDeletePacket";
            this.BtnDeletePacket.Size = new System.Drawing.Size(111, 38);
            this.BtnDeletePacket.TabIndex = 9;
            this.BtnDeletePacket.Text = "Delete";
            this.BtnDeletePacket.UseVisualStyleBackColor = true;
            this.BtnDeletePacket.Click += new System.EventHandler(this.BtnDeletePacket_Click);
            // 
            // BtnUpdatePacket
            // 
            this.BtnUpdatePacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdatePacket.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdatePacket.ForeColor = System.Drawing.Color.Black;
            this.BtnUpdatePacket.Location = new System.Drawing.Point(152, 175);
            this.BtnUpdatePacket.Name = "BtnUpdatePacket";
            this.BtnUpdatePacket.Size = new System.Drawing.Size(111, 38);
            this.BtnUpdatePacket.TabIndex = 8;
            this.BtnUpdatePacket.Text = "Update";
            this.BtnUpdatePacket.UseVisualStyleBackColor = true;
            this.BtnUpdatePacket.Click += new System.EventHandler(this.BtnUpdatePacket_Click);
            // 
            // BtnAddPacket
            // 
            this.BtnAddPacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPacket.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddPacket.ForeColor = System.Drawing.Color.Black;
            this.BtnAddPacket.Location = new System.Drawing.Point(17, 175);
            this.BtnAddPacket.Name = "BtnAddPacket";
            this.BtnAddPacket.Size = new System.Drawing.Size(111, 38);
            this.BtnAddPacket.TabIndex = 7;
            this.BtnAddPacket.Text = "Add";
            this.BtnAddPacket.UseVisualStyleBackColor = true;
            this.BtnAddPacket.Click += new System.EventHandler(this.BtnAddPacket_Click);
            // 
            // txtparty
            // 
            this.txtparty.DataSource = this.userTbBindingSource;
            this.txtparty.DisplayMember = "Name";
            this.txtparty.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold);
            this.txtparty.FormattingEnabled = true;
            this.txtparty.Location = new System.Drawing.Point(381, 53);
            this.txtparty.Name = "txtparty";
            this.txtparty.Size = new System.Drawing.Size(122, 32);
            this.txtparty.TabIndex = 2;
            this.txtparty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtparty_KeyDown);
            // 
            // userTbBindingSource
            // 
            this.userTbBindingSource.DataMember = "userTb";
            this.userTbBindingSource.DataSource = this.packetDataSet1;
            // 
            // packetDataSet1
            // 
            this.packetDataSet1.DataSetName = "packetDataSet1";
            this.packetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtpacket
            // 
            this.txtpacket.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold);
            this.txtpacket.FormattingEnabled = true;
            this.txtpacket.Location = new System.Drawing.Point(381, 93);
            this.txtpacket.Name = "txtpacket";
            this.txtpacket.Size = new System.Drawing.Size(122, 32);
            this.txtpacket.TabIndex = 4;
            this.txtpacket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpacket_KeyDown);
            // 
            // txtdate
            // 
            this.txtdate.CalendarFont = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold);
            this.txtdate.CustomFormat = "yyyy-MM-dd";
            this.txtdate.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold);
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdate.Location = new System.Drawing.Point(113, 53);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(122, 30);
            this.txtdate.TabIndex = 1;
            this.txtdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdate_KeyDown);
            // 
            // txtpcs
            // 
            this.txtpcs.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpcs.Location = new System.Drawing.Point(113, 133);
            this.txtpcs.Name = "txtpcs";
            this.txtpcs.Size = new System.Drawing.Size(122, 30);
            this.txtpcs.TabIndex = 5;
            this.txtpcs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpcs_KeyDown);
            // 
            // txtweight
            // 
            this.txtweight.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtweight.Location = new System.Drawing.Point(381, 133);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(122, 30);
            this.txtweight.TabIndex = 6;
            this.txtweight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtweight_KeyDown);
            // 
            // txtkapan
            // 
            this.txtkapan.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkapan.Location = new System.Drawing.Point(113, 93);
            this.txtkapan.Name = "txtkapan";
            this.txtkapan.Size = new System.Drawing.Size(122, 30);
            this.txtkapan.TabIndex = 3;
            this.txtkapan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtkapan_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 191;
            this.label2.Text = "Packet No. :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 192;
            this.label1.Text = "Party Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(288, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 24);
            this.label11.TabIndex = 193;
            this.label11.Text = "Weight :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 24);
            this.label10.TabIndex = 194;
            this.label10.Text = "Pcs :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 195;
            this.label3.Text = "ID :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 195;
            this.label9.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 196;
            this.label8.Text = "Kapan :";
            // 
            // userTbTableAdapter
            // 
            this.userTbTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 192;
            this.label4.Text = "Start From :";
            // 
            // cbsf
            // 
            this.cbsf.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold);
            this.cbsf.FormattingEnabled = true;
            this.cbsf.Items.AddRange(new object[] {
            "Sarin",
            "Stitching"});
            this.cbsf.Location = new System.Drawing.Point(381, 13);
            this.cbsf.Name = "cbsf";
            this.cbsf.Size = new System.Drawing.Size(122, 32);
            this.cbsf.TabIndex = 197;
            // 
            // F_Packet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(600, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F_Packet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F_Packet_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnUpdatePacket;
        private System.Windows.Forms.ComboBox txtparty;
        private System.Windows.Forms.ComboBox txtpacket;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtpcs;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtkapan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private packetDataSet1 packetDataSet1;
        private System.Windows.Forms.BindingSource userTbBindingSource;
        private packetDataSet1TableAdapters.userTbTableAdapter userTbTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnDeletePacket;
        private System.Windows.Forms.Button BtnAddPacket;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbsf;
    }
}

