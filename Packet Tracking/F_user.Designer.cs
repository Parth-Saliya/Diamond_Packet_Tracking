namespace Packet_Tracking
{
    partial class F_user
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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.BtnAddPacket = new System.Windows.Forms.Button();
            this.BtnUpdatePacket = new System.Windows.Forms.Button();
            this.BtnDeletePacket = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDep = new System.Windows.Forms.ComboBox();
            this.userId = new System.Windows.Forms.TextBox();
            this.packetDataSet = new Packet_Tracking.packetDataSet();
            this.userTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTbTableAdapter = new Packet_Tracking.packetDataSetTableAdapters.userTbTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 38);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 31);
            this.label5.TabIndex = 206;
            this.label5.Text = "User";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(429, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 34);
            this.button1.TabIndex = 205;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 192;
            this.label1.Text = "Name :";
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(32, 81);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(128, 24);
            this.D.TabIndex = 191;
            this.D.Text = "Department :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(166, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(88, 30);
            this.txtName.TabIndex = 0;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // BtnAddPacket
            // 
            this.BtnAddPacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPacket.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddPacket.ForeColor = System.Drawing.Color.Black;
            this.BtnAddPacket.Location = new System.Drawing.Point(55, 125);
            this.BtnAddPacket.Name = "BtnAddPacket";
            this.BtnAddPacket.Size = new System.Drawing.Size(111, 38);
            this.BtnAddPacket.TabIndex = 2;
            this.BtnAddPacket.Text = "Add";
            this.BtnAddPacket.UseVisualStyleBackColor = true;
            this.BtnAddPacket.Click += new System.EventHandler(this.BtnAddPacket_Click);
            // 
            // BtnUpdatePacket
            // 
            this.BtnUpdatePacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdatePacket.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdatePacket.ForeColor = System.Drawing.Color.Black;
            this.BtnUpdatePacket.Location = new System.Drawing.Point(197, 125);
            this.BtnUpdatePacket.Name = "BtnUpdatePacket";
            this.BtnUpdatePacket.Size = new System.Drawing.Size(111, 38);
            this.BtnUpdatePacket.TabIndex = 3;
            this.BtnUpdatePacket.Text = "Update";
            this.BtnUpdatePacket.UseVisualStyleBackColor = true;
            this.BtnUpdatePacket.Click += new System.EventHandler(this.BtnUpdatePacket_Click);
            // 
            // BtnDeletePacket
            // 
            this.BtnDeletePacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletePacket.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletePacket.ForeColor = System.Drawing.Color.Black;
            this.BtnDeletePacket.Location = new System.Drawing.Point(341, 125);
            this.BtnDeletePacket.Name = "BtnDeletePacket";
            this.BtnDeletePacket.Size = new System.Drawing.Size(111, 38);
            this.BtnDeletePacket.TabIndex = 4;
            this.BtnDeletePacket.Text = "Delete";
            this.BtnDeletePacket.UseVisualStyleBackColor = true;
            this.BtnDeletePacket.Click += new System.EventHandler(this.BtnDeletePacket_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 295);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.txtDep);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.BtnDeletePacket);
            this.panel2.Controls.Add(this.BtnUpdatePacket);
            this.panel2.Controls.Add(this.BtnAddPacket);
            this.panel2.Controls.Add(this.userId);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.D);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 552);
            this.panel2.TabIndex = 3;
            // 
            // txtDep
            // 
            this.txtDep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtDep.FormattingEnabled = true;
            this.txtDep.Items.AddRange(new object[] {
            "4P",
            "Stitching",
            "Sarin",
            "Party"});
            this.txtDep.Location = new System.Drawing.Point(167, 85);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(88, 21);
            this.txtDep.TabIndex = 1;
            this.txtDep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDep_KeyDown);
            // 
            // userId
            // 
            this.userId.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userId.Location = new System.Drawing.Point(166, 8);
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Size = new System.Drawing.Size(50, 30);
            this.userId.TabIndex = 0;
            this.userId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userId_KeyDown);
            // 
            // packetDataSet
            // 
            this.packetDataSet.DataSetName = "packetDataSet";
            this.packetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTbBindingSource
            // 
            this.userTbBindingSource.DataMember = "userTb";
            this.userTbBindingSource.DataSource = this.packetDataSet;
            // 
            // userTbTableAdapter
            // 
            this.userTbTableAdapter.ClearBeforeFill = true;
            // 
            // F_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F_user";
            this.Text = "F_user";
            this.Load += new System.EventHandler(this.F_user_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTbBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button BtnAddPacket;
        private System.Windows.Forms.Button BtnUpdatePacket;
        private System.Windows.Forms.Button BtnDeletePacket;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox userId;
        private packetDataSet packetDataSet;
        private System.Windows.Forms.BindingSource userTbBindingSource;
        private packetDataSetTableAdapters.userTbTableAdapter userTbTableAdapter;
        private System.Windows.Forms.ComboBox txtDep;
        private System.Windows.Forms.Label label5;
    }
}