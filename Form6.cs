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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try /* Select After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = "Host=localhost; Database=diplom; Username=postgres; Password=root";
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM public.employer WHERE id= " + this.textBox1.Text + "; ";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    connection.Close();
                    Form5 form5 = new Form5();
                    foreach (DataRow row in dt.Rows)
                    {
                        form5.textBox1.Text = row.ItemArray[0].ToString();
                        form5.textBox2.Text = row.ItemArray[1].ToString();
                        form5.textBox3.Text = row.ItemArray[2].ToString();
                        form5.textBox4.Text = row.ItemArray[3].ToString();
                        form5.textBox5.Text = row.ItemArray[4].ToString();
                        form5.textBox6.Text = row.ItemArray[5].ToString();
                        form5.textBox8.Text = row.ItemArray[6].ToString();
                        form5.textBox9.Text = row.ItemArray[7].ToString();
                        form5.textBox10.Text = row.ItemArray[8].ToString();
                    }
                    form5.Show();
                    this.Close();
                }
            }
            catch (Exception ex) { }
        }
    }
}
