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
    public partial class F_Issue : Form
    {
        public F_Issue()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["packetcon"].ConnectionString);

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void dispSaUpData()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select kapan,Pkt,SaJaNo,SaIsDt,Saop,pcs,weight from MainPacket where SaJaNo = '" + txtjano.Text+"' ";
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
            cmd.CommandText = "select kapan,Pkt,SiJaNo,SiIsDt,Siop,sarepcs,sarewgt from MainPacket where pkt = '" + PktNo.Text + "' and kapan = '" + txtkapan.Text + "' ";
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
            cmd.CommandText = "select kapan,Pkt,FpJaNo,FpIsDt,Fpop,sirepcs,sirewgt from MainPacket where pkt = '" + PktNo.Text + "' and kapan = '" + txtkapan.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dtc = new DataTable();
            SqlDataAdapter dac = new SqlDataAdapter(cmd);
            dac.Fill(dtc);
            dataGridView1.DataSource = dtc;
            con.Close();
        }

        public void dispUpData()
        {
            if(comboBox2.Text == "Sarin")
            {
                dispSaUpData();
            }
            else if (comboBox2.Text == "4P")
            {
                disp4PUpData();
            }
            else if (comboBox2.Text == "Stitching")
            {
                dispStUpData();
            }
            else if (comboBox2.Text == "Party")
            {

            }
        }

        public void UpSarin()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE MainPacket SET SaJaNo='" + txtjano.Text + "',SaisDt='" + dateTimePicker1.Text + "', Saop='" + comboBox1.Text + "' where (kapan='" + txtkapan.Text + "' and pkt='" + PktNo.Text + "')";

            cmd.ExecuteNonQuery();

            con.Close();
            dispUpData();
            MessageBox.Show("Issue successfully");
        }

        public void UpStitching()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE MainPacket SET SiJaNo='" + txtjano.Text + "',SiisDt='" + dateTimePicker1.Text + "', Siop='" + comboBox1.Text + "' where (kapan='" + txtkapan.Text + "' and pkt='" + PktNo.Text + "')";

            cmd.ExecuteNonQuery();

            con.Close();
            dispUpData();
            MessageBox.Show("Issue successfully");
        }
        public void Up4p()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE MainPacket SET FpJaNo='" + txtjano.Text + "',FPisDt='" + dateTimePicker1.Text + "', FPOp='" + comboBox1.Text + "' where (kapan='" + txtkapan.Text + "' and pkt='" + PktNo.Text + "')";

            cmd.ExecuteNonQuery();

            con.Close();
            dispUpData();
            MessageBox.Show("Issue successfully");
        }

        public void UpParty()
        {

        }

        public void UpdatePkt()
        {
            if(comboBox2.Text == "Sarin")
            {
                UpSarin();
            }
            else if (comboBox2.Text == "4P")
            {
                Up4p();
            }
            else if (comboBox2.Text == "Stitching")
            {
                UpStitching();
            }
            else if (comboBox2.Text == "Party")
            {
                
            }
        }

        private void BtnUpdatePacket_Click(object sender, EventArgs e)
        {
            if(txtjano.Text == "")
            {
                if(comboBox2.Text== "Sarin")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select max(SaJaNo) from MainPacket ";

                    cmd.ExecuteNonQuery();
                    var a = cmd.ExecuteScalar();
                   
                    if (a==DBNull.Value)
                    {
                        a = "0";
                    }

                    int b = Convert.ToInt32(a.ToString());
                    int c = b + 1;
                    txtjano.Text = Convert.ToString(c.ToString());

                    con.Close();
                }
                else if(comboBox2.Text == "Stitching")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select max(SiJaNo) from MainPacket ";

                    cmd.ExecuteNonQuery();
                    var a = cmd.ExecuteScalar();
                    if(a==DBNull.Value)
                    {
                        a = "0";
                    }
                  
                    
                    int b = Convert.ToInt32(a.ToString());
                  
                    int c = b + 1;
                    txtjano.Text = Convert.ToString(c.ToString());

                    con.Close();
                }
                else if (comboBox2.Text == "4p")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select max(fpJaNo) from MainPacket ";

                    cmd.ExecuteNonQuery();
                    var a = cmd.ExecuteScalar();
                   
                    if (a == DBNull.Value)
                    {
                        a = "0";
                    }


                    int b = Convert.ToInt32(a.ToString());

                    int c = b + 1;
                    txtjano.Text = Convert.ToString(c.ToString());

                    con.Close();
                }


            }
            if(txtkapan.Text != "" && PktNo.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && txtjano.Text != "" && textBox1.Text != "" && textBox2.Text != "")
            {
                UpdatePkt();
                focus();

            }
            else
            {
                MessageBox.Show("Fill all Details");
            }
        }

        public void enter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        public void focus()
        {
            txtkapan.Clear();
            PktNo.ResetText();
            textBox1.Clear();
            textBox2.Clear();
            txtkapan.Focus();
        }

        private void F_Issue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'packetDataSet4.MainPacket' table. You can move, or remove it, as needed.
            this.mainPacketTableAdapter1.Fill(this.packetDataSet4.MainPacket);
            // TODO: This line of code loads data into the 'packetDataSet3.userTb' table. You can move, or remove it, as needed.
            this.userTbTableAdapter.Fill(this.packetDataSet3.userTb);
            // TODO: This line of code loads data into the 'packetDataSet2.MainPacket' table. You can move, or remove it, as needed.
            this.mainPacketTableAdapter.Fill(this.packetDataSet2.MainPacket);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTbTableAdapter.FillBy(this.packetDataSet3.userTb);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
                if (comboBox2.Text == "Sarin")
               {
                    con.Open();
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select pkt from MainPacket where kapan = '" + txtkapan.Text + "' and sajano is null ";

                    cmd2.ExecuteNonQuery();

                    DataTable dtt = new DataTable();
                    SqlDataAdapter dat = new SqlDataAdapter(cmd2);
                    dat.Fill(dtt);
                    PktNo.DataSource = dtt;
                    PktNo.DisplayMember = "pkt";
                    con.Close();
                }
                else if (comboBox2.Text == "Stitching")
                {
                    con.Open();
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select pkt from MainPacket where kapan = '" + txtkapan.Text + "' and sijano is null ";

                    cmd2.ExecuteNonQuery();

                    DataTable dtt = new DataTable();
                    SqlDataAdapter dat = new SqlDataAdapter(cmd2);
                    dat.Fill(dtt);
                    PktNo.DataSource = dtt;
                    PktNo.DisplayMember = "pkt";
                    con.Close();
                }
                else if (comboBox2.Text == "4p")
                {
                    con.Open();
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select pkt from MainPacket where kapan = '" + txtkapan.Text + "' and jano is null ";

                    cmd2.ExecuteNonQuery();

                    DataTable dtt = new DataTable();
                    SqlDataAdapter dat = new SqlDataAdapter(cmd2);
                    dat.Fill(dtt);
                    PktNo.DataSource = dtt;
                    PktNo.DisplayMember = "pkt";
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("No Packet Available on This Kapan !!");
               // txtkapan.Focus();
            }
           
        }

        public void fillOpe()
        {

            comboBox1.ResetText();
                con.Open();
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select name from userTb where Department = '" + comboBox2.Text + "' ";

                cmd2.ExecuteNonQuery();

                DataTable dtt = new DataTable();
                SqlDataAdapter dat = new SqlDataAdapter(cmd2);
                dat.Fill(dtt);
                comboBox1.DataSource = dtt;
                comboBox1.DisplayMember = "name";
                con.Close();
          

        }


        private void BtnAddPacket_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
           // fillPck();
        }

        private void txtkapan_Leave(object sender, EventArgs e)
        {
            if(txtkapan.Text != "")
            {
                fillPck();
            }
            dispUpData();
        }

        private void txtkapan_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
           // fillOpe();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillOpe();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from userTb where name = '" + comboBox1.Text + "' ";

            cmd.ExecuteNonQuery();
            var a = cmd.ExecuteScalar();
            int b = Convert.ToInt32(a.ToString());
            con.Close();
            if(b != 1)
            {
                comboBox1.ResetText();
            }
        }
        
        public void GetPcsWgt()
        {
            
            if (comboBox2.Text == "Sarin")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select pcs,weight from mainpacket where kapan= '"+txtkapan.Text+"' and pkt = '"+PktNo.Text+"' ";

                cmd.ExecuteNonQuery();

                DataTable dtc = new DataTable();
                SqlDataAdapter dac = new SqlDataAdapter(cmd);
                dac.Fill(dtc);
                textBox1.Text = dtc.Rows[0][0].ToString();
                textBox2.Text = dtc.Rows[0][1].ToString();
                con.Close();
            }
            else if(comboBox2.Text == "Stitching")
            {
                
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select sarepcs,sarewgt from mainpacket where kapan= '" + txtkapan.Text + "' and pkt = '" + PktNo.Text + "' ";

                cmd.ExecuteNonQuery();

                DataTable dtc = new DataTable();
                SqlDataAdapter dac = new SqlDataAdapter(cmd);
                dac.Fill(dtc);
                textBox1.Text = dtc.Rows[0][0].ToString();
                textBox2.Text = dtc.Rows[0][1].ToString();
                con.Close();
            }
            else if(comboBox2.Text == "4p")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select sirepcs,sirewgt from mainpacket where kapan= '" + txtkapan.Text + "' and pkt = '" + PktNo.Text + "' ";

                cmd.ExecuteNonQuery();

                DataTable dtc = new DataTable();
                SqlDataAdapter dac = new SqlDataAdapter(cmd);
                dac.Fill(dtc);
                textBox1.Text = dtc.Rows[0][0].ToString();
                textBox2.Text = dtc.Rows[0][1].ToString();
                con.Close();
            }
        }

        private void PktNo_Leave(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from MainPacket where pkt = '" + PktNo.Text + "' and kapan='"+txtkapan.Text+"' ";

            cmd.ExecuteNonQuery();
            var a = cmd.ExecuteScalar();
            int b = Convert.ToInt32(a.ToString());
            con.Close();
            if (b == 0)
            {
                PktNo.ResetText();
            }
            else
            {
                if (PktNo.Text != "")
                {
                    GetPcsWgt();

                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.ResetText();
            txtjano.Clear();
            txtkapan.Clear();
            PktNo.ResetText();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.ResetText();
        }

        private void txtjano_Leave(object sender, EventArgs e)
        {
            dispUpData();
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void txtjano_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void txtkapan_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void PktNo_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }
    }
}
