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
    public partial class F_Return : Form
    {
        public F_Return()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["packetcon"].ConnectionString);


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void dispSaUpData()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Pkt,SareDt,Sarepcs,Sarewgt from MainPacket where pkt = '" + cbpkt.Text + "' and kapan = '" + txtkapan.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dtc = new DataTable();
            SqlDataAdapter dac = new SqlDataAdapter(cmd);
            dac.Fill(dtc);
            dataGridView1.DataSource = dtc;
            con.Close();
        }


        public void dispStUpData()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Pkt,SireDt,Sirepcs,Sirewgt from MainPacket where pkt = '" + cbpkt.Text + "' and kapan = '" + txtkapan.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dtc = new DataTable();
            SqlDataAdapter dac = new SqlDataAdapter(cmd);
            dac.Fill(dtc);
            dataGridView1.DataSource = dtc;
            con.Close();
        }

        public void disp4PUpData()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Pkt,FpreDt,Fprepcs,Fprewgt from MainPacket where pkt = '" + cbpkt.Text + "' and kapan = '" + txtkapan.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dtc = new DataTable();
            SqlDataAdapter dac = new SqlDataAdapter(cmd);
            dac.Fill(dtc);
            dataGridView1.DataSource = dtc;
            con.Close();
        }

        public void dispUpData()
        {
            if (cbdep.Text == "Sarin")
            {
                dispSaUpData();
            }
            else if (cbdep.Text == "4P")
            {
                disp4PUpData();
            }
            else if (cbdep.Text == "Stitching")
            {
                dispStUpData();
            }
            else if (cbdep.Text == "Party")
            {

            }
        }

        public void UpSarin()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE MainPacket SET SareDt='" + dateTimePicker1.Text + "', Sarepcs='" + txtpcs.Text + "', Sarewgt='" + txtwet.Text + "' where (kapan='" + txtkapan.Text + "' and pkt='" + cbpkt.Text + "')";

            cmd.ExecuteNonQuery();

            con.Close();
            dispUpData();
            MessageBox.Show("Customer Updated successfully");
        }

        public void UpStitching()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE MainPacket SET SireDt='" + dateTimePicker1.Text + "', Sirepcs='" + txtpcs.Text + "', Sirewgt='" + txtwet.Text + "' where (kapan='" + txtkapan.Text + "' and pkt='" + cbpkt.Text + "')";

            cmd.ExecuteNonQuery();

            con.Close();
            dispUpData();
            MessageBox.Show("Customer Updated successfully");
        }
        public void Up4p()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE MainPacket SET FPreDt='" + dateTimePicker1.Text + "', FPrepcs='" + txtpcs.Text + "', FPrewgt='" + txtwet.Text + "' where (kapan='" + txtkapan.Text + "' and pkt='" + cbpkt.Text + "')";

            cmd.ExecuteNonQuery();

            con.Close();
            dispUpData();
            MessageBox.Show("Customer Updated successfully");
        }

        public void UpParty()
        {

        }

        public void UpdatePkt()
        {
            if (cbdep.Text == "Sarin")
            {
                UpSarin();
            }
            else if (cbdep.Text == "4P")
            {
                Up4p();
            }
            else if (cbdep.Text == "Stitching")
            {
                UpStitching();
            }
            else if (cbdep.Text == "Party")
            {

            }
        }

        private void BtnUpdatePacket_Click(object sender, EventArgs e)
        {
            if (txtkapan.Text != "" && cbpkt.Text != "" && cbop.Text != "" && cbdep.Text != "" && txtpcs.Text != "" && txtwet.Text != "")
            {
                UpdatePkt();
            }
            else
            {
                MessageBox.Show("Fill all Details");
            }
        }

        public void fillOpe()
        {

            cbop.ResetText();
            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select name from userTb where Department = '" + cbdep.Text + "' ";

            cmd2.ExecuteNonQuery();

            DataTable dtt = new DataTable();
            SqlDataAdapter dat = new SqlDataAdapter(cmd2);
            dat.Fill(dtt);
            cbop.DataSource = dtt;
            cbop.DisplayMember = "name";
            con.Close();


        }

        private void cbdep_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillOpe();
        }

        private void cbop_Leave(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from userTb where name = '" + cbop.Text + "' ";

            cmd.ExecuteNonQuery();
            var a = cmd.ExecuteScalar();
            int b = Convert.ToInt32(a.ToString());
            con.Close();
            if (b != 1)
            {
                cbop.ResetText();
            }
            else
            {
                
            }
        }

        public void fillpcs()
        {
            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select pcs,weight from mainpacket where kapan = '" + txtkapan.Text + "' and pkt = '" + cbpkt.Text + "' ";

            cmd2.ExecuteNonQuery();

            DataTable dtt = new DataTable();
            SqlDataAdapter dat = new SqlDataAdapter(cmd2);
            dat.Fill(dtt);
            txtpcs.Text = dtt.Rows[0][0].ToString();
            txtwet.Text = dtt.Rows[0][1].ToString();
            con.Close();
        }

        private void cbpkt_Leave(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from MainPacket where pkt = '" + cbpkt.Text + "' ";

            cmd.ExecuteNonQuery();
            var a = cmd.ExecuteScalar();
            int b = Convert.ToInt32(a.ToString());
            con.Close();
            if (b == 0)
            {
                cbpkt.ResetText();
            }
            else
            {
                fillpcs();
            }
        }

        public void fillPck()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from MainPacket where kapan = '" + txtkapan.Text + "' ";

            cmd.ExecuteNonQuery();
            var a = cmd.ExecuteScalar();
            int b = Convert.ToInt32(a.ToString());
            con.Close();
            if (b >= 1)
            {
                con.Open();
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select pkt from MainPacket where kapan = '" + txtkapan.Text + "' ";

                cmd2.ExecuteNonQuery();

                DataTable dtt = new DataTable();
                SqlDataAdapter dat = new SqlDataAdapter(cmd2);
                dat.Fill(dtt);
                cbpkt.DataSource = dtt;
                cbpkt.DisplayMember = "pkt";
                con.Close();
            }
            else
            {
                MessageBox.Show("No Packet Available on This Kapan !!");
            }

        }

        private void txtkapan_Leave(object sender, EventArgs e)
        {
            fillPck();
        }

        public void enter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cbdep.ResetText();
            cbop.ResetText();
            cbpkt.ResetText();
            txtkapan.Clear();
            txtpcs.Clear();
            txtwet.Clear();
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void txtkapan_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void cbpkt_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void cbdep_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void cbop_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void txtpcs_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void txtwet_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }
    }
}
