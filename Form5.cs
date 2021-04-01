using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зачетное_задание_Евтушевская
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection())
            {
                connection.ConnectionString = "Host=localhost; Database=diplom; Username=postgres; Password=root";
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "UPDATE public.employer SET id ="+textBox1.Text+" , fio ='"+textBox2.Text+ "', birtday ='" + textBox3.Text + "', gender ='" + textBox4.Text + "', height =" + textBox5.Text + ", weight =" + textBox6.Text + ", head_size =" + textBox8.Text + ", health_category =" + textBox9.Text + ", shoe_size =" + textBox10.Text + "WHERE id = " + textBox1.Text + "; ";
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.Dispose();
                connection.Close();
                this.Close();
            }
        }
    }
}
