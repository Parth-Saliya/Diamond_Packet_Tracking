using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Packet_Tracking
{
    public partial class F_Packet : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["packetcon"].ConnectionString);

        public F_Packet()
        {
            InitializeComponent();
        }

        public void conopen()
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();
            }
        }

        public void disp_userData()
        {
            conopen();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from mainpacket";
            cmd.ExecuteNonQuery();
            DataTable dtc = new DataTable();
            SqlDataAdapter dac = new SqlDataAdapter(cmd);
            dac.Fill(dtc);
            dataGridView1.DataSource = dtc;
            con.Close();
        }

        public void add()
        {
            double a, b;
            a = Convert.ToDouble(txtpcs.Text);
            b = Convert.ToDouble(txtweight.Text);
            double c = a / b;


            conopen();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into mainpacket (dt,party,kapan,pkt,pcs,weight,size,start) values('" + txtdate.Text + "', '" + txtparty.Text + "', '" + txtkapan.Text + "', '" + txtpacket.Text + "', '" + txtpcs.Text + "', '" + txtweight.Text + "', '" + c.ToString() + "', '" + cbsf.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void F_Packet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'packetDataSet1.userTb' table. You can move, or remove it, as needed.
            this.userTbTableAdapter.Fill(this.packetDataSet1.userTb);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clear()
        {
            txtkapan.Clear();
            txtpacket.ResetText();
           // txtparty.ResetText();
            txtpcs.Clear();
            txtweight.Clear();
            txtid.Clear();
        }

        private void BtnAddPacket_Click(object sender, EventArgs e)
        {
            if(txtkapan.Text != "" && txtpacket.Text != "" && txtparty.Text != "" && txtpcs.Text != "" && txtweight.Text != "")
            {
                add();
                DispData();
                MessageBox.Show("Add successfully!!");
                clear();
                txtkapan.Focus();

            }
        }

        public void DispData()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id,dt,party,kapan,pkt,pcs,weight,size from mainpacket order by id desc";
            cmd.ExecuteNonQuery();
            DataTable dtc = new DataTable();
            SqlDataAdapter dac = new SqlDataAdapter(cmd);
            dac.Fill(dtc);
            dataGridView1.DataSource = dtc;
            con.Close();

            DataGridViewColumn column0 = dataGridView1.Columns[0];
            column0.Width = 45;

            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 70;

            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 100;

            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 50;

            DataGridViewColumn column4 = dataGridView1.Columns[4];
            column4.Width = 50;

            DataGridViewColumn column5 = dataGridView1.Columns[5];
            column5.Width = 50;

            DataGridViewColumn column6 = dataGridView1.Columns[6];
            column6.Width = 65;

            DataGridViewColumn column7 = dataGridView1.Columns[7];
            column7.Width = 65;

            //DataGridViewColumn column8 = dataGridView1.Columns[8];
            //column2.Width = 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_user fu = new F_user();
            fu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            F_Issue fi = new F_Issue();
            fi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            F_Return fr = new F_Return();
            fr.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void enter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnUpdatePacket_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Really Want to Update Item ??", txtid.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtid.Text != "" && txtdate.Text != "" && txtkapan.Text != "" && txtpacket.Text != "" && txtparty.Text != "" && txtpcs.Text != "" && txtweight.Text != "")
                {

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE mainpacket SET dt ='" + txtdate.Text + "', kapan ='" + txtkapan.Text + "', party ='" + txtparty.Text + "',pkt ='" + txtpacket.Text + "',pcs ='" + txtpcs.Text + "',weight = '" + txtweight.Text + "' where (id ='" + txtid.Text + "')";

                    cmd.ExecuteNonQuery();
                    con.Close();
                    DispData();
                    MessageBox.Show("Data Updated!!");
                    clear();
                }
            }
        }

        private void BtnDeletePacket_Click(object sender, EventArgs e)
        {

        }

        private void txtdate_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void txtparty_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void txtkapan_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void txtpacket_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void txtpcs_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void txtweight_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtid.Text = row.Cells[0].Value.ToString();
                txtdate.Text = row.Cells[1].Value.ToString();
                txtparty.Text = row.Cells[2].Value.ToString();
                txtkapan.Text = row.Cells[3].Value.ToString();
                txtpacket.Text = row.Cells[4].Value.ToString();
                txtpcs.Text = row.Cells[5].Value.ToString();
                txtweight.Text = row.Cells[6].Value.ToString();
            }
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }
    }
}
