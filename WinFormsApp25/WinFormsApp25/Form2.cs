using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp25
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data source=TarikZekikeles;Initial Catalog=siteler; Integrated Security=true");
        private void verileriGoster()
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("Select *from sitebilgi", conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader["id"].ToString();
                listViewItem.SubItems.Add(reader["sitem"].ToString());
                listViewItem.SubItems.Add(reader["oda"].ToString());
                listViewItem.SubItems.Add(reader["metre"].ToString());
                listViewItem.SubItems.Add(reader["fiyat"].ToString());
                listViewItem.SubItems.Add(reader["blok"].ToString());
                listViewItem.SubItems.Add(reader["no"].ToString());
                listViewItem.SubItems.Add(reader["adsoyad"].ToString());
                listViewItem.SubItems.Add(reader["telefon"].ToString());
                listViewItem.SubItems.Add(reader["notlar"].ToString());
                listViewItem.SubItems.Add(reader["satkira"].ToString());

                listView1.Items.Add(listViewItem);
            }
            conn.Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Zambak Sitesi")
            {
                btnZambak.BackColor = Color.Yellow;
                btnGul.BackColor = Color.Gray;
                btnMenekse.BackColor = Color.Gray;
                btnPapatya.BackColor = Color.Gray;
            }
            if (comboBox1.Text == "Papatya Sitesi")
            {
                btnZambak.BackColor = Color.Gray;
                btnGul.BackColor = Color.Gray;
                btnMenekse.BackColor = Color.Gray;
                btnPapatya.BackColor = Color.Yellow;
            }
            if (comboBox1.Text == "Gül Sitesi")
            {
                btnZambak.BackColor = Color.Gray;
                btnGul.BackColor = Color.Yellow;
                btnMenekse.BackColor = Color.Gray;
                btnPapatya.BackColor = Color.Gray;
            }
            if (comboBox1.Text == "Menekşe Sitesi")
            {
                btnZambak.BackColor = Color.Gray;
                btnGul.BackColor = Color.Gray;
                btnMenekse.BackColor = Color.Yellow;
                btnPapatya.BackColor = Color.Gray;
            }
        }

        private void buttonGoruntule_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into sitebilgi (id,sitem,oda,metre,fiyat,blok,no,adsoyad,telefon,notlar,satkira) values ('" + textBox6.Text.ToString() + "' , '" + comboBox1.Text.ToString() + "' , '" + comboBox3.Text.ToString() + "' , '" + textBox8.Text.ToString() + "' , '" + textBox1.Text.ToString() + "' , '" + comboBox4.Text.ToString() + "' , '" + textBox7.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + comboBox2.Text.ToString() + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            verileriGoster();
        }
        int id = 0;
        private void buttonSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from sitebilgi where id = (" + id + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            verileriGoster();


        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox6.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[9].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void buttonDuzelt_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE sitebilgi SET id = @id, sitem = @sitem, oda = @oda, metre = @metre, fiyat = @fiyat, blok = @blok, no = @no, adsoyad = @adsoyad, telefon = @telefon, notlar = @notlar, satkira = @satkira WHERE id = @id", conn);
            sqlCommand.Parameters.AddWithValue("@id", textBox6.Text);
            sqlCommand.Parameters.AddWithValue("@sitem", comboBox1.Text);
            sqlCommand.Parameters.AddWithValue("@oda", comboBox3.Text);
            sqlCommand.Parameters.AddWithValue("@metre", textBox8.Text);
            sqlCommand.Parameters.AddWithValue("@fiyat", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@blok", comboBox4.Text);
            sqlCommand.Parameters.AddWithValue("@no", textBox7.Text);
            sqlCommand.Parameters.AddWithValue("@adsoyad", textBox4.Text);
            sqlCommand.Parameters.AddWithValue("@telefon", textBox5.Text);
            sqlCommand.Parameters.AddWithValue("@notlar", textBox3.Text);
            sqlCommand.Parameters.AddWithValue("@satkira", comboBox2.Text);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            verileriGoster();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
