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
    public partial class F_user : Form
    {
        public F_user()
        {
            InitializeComponent();
           
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["packetcon"].ConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_user_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'packetDataSet.userTb' table. You can move, or remove it, as needed.
            this.userTbTableAdapter.Fill(this.packetDataSet.userTb);
            disp_userData();

        }

        public void conopen()
        {
            if (con.State == ConnectionState.Closed)
            {

                con.Open();
            }
        }

        private void BtnAddPacket_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtDep.Text != "")
            {
                add();
                disp_userData();
                MessageBox.Show("Add successfully!!");
                clearForm();
            }
           
        }
        public void clearForm()
        {
            txtDep.ResetText();
            txtName.Clear();
            userId.Clear();
        }

        public void disp_userData()
        {
            conopen();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usertb";
            cmd.ExecuteNonQuery();
            DataTable dtc = new DataTable();
            SqlDataAdapter dac = new SqlDataAdapter(cmd);
            dac.Fill(dtc);
            dataGridView1.DataSource = dtc;
            con.Close();

        }

        public void add()
        {
            conopen();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into userTb values('" + txtName.Text + "', '" + txtDep.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void BtnDeletePacket_Click(object sender, EventArgs e)
        {
            deleteUser();
            
        }
        public void deleteUser()
        {
            if (MessageBox.Show("Do You Really Want to DELETE Person ??", txtName.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (userId.Text != "")
                {
                    conopen();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from userTb where id='" + userId.Text + "'";

                    cmd.ExecuteNonQuery();

                    con.Close();
                    disp_userData();
                    MessageBox.Show("Person deleted successfully");
                    clearForm();


                }
                else
                {
                    MessageBox.Show("Please Fill Up All Details Properly !!");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                userId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtDep.Text = row.Cells[2].Value.ToString();


            }
        }

        public void UpdateData()
        {
            conopen();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE userTb SET name='" + txtName.Text + "', department='" + txtDep.Text + "' where (id='" + userId.Text + "')";

            cmd.ExecuteNonQuery();

            con.Close();
            disp_userData();
            MessageBox.Show("Person Updated successfully");
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
            if (MessageBox.Show("Do You Really Want to Update Person ??", txtName.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtDep.Text != "" && txtName.Text != "") 
                {
                    UpdateData();
                    clearForm();
                }
                else
                {
                    MessageBox.Show("Please Fill Up All Details Properly !!");
                }
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void txtDep_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void userId_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }
    }
}
