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
    public partial class addSizForm : Form
    {
        private Form2 form;
        public addSizForm(Form2 form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection())
            {
          
                    errorMessageLabel.Text = "";
                    connection.ConnectionString = "Host=localhost; Database=diplom; Username=postgres; Password=root";
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.siz( title_siz, life_time) VALUES ('" + nameSizTextBox.Text + "', '" + lifeTimeSiz.Text + "'); ";
                    try
                    {
                        cmd.CommandType = CommandType.Text;
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        cmd.ExecuteScalar();
                        connection.Close();
                        form.updateSizInfo();
                        this.Close();
                    
                    }
                    catch (Exception exception)
                    {
                        errorMessageLabel.Text = "ОШИБКА!!!";
                        errorMessageLabel.ForeColor = Color.Red;
                    }
                    finally
                    {
                        connection.Close();
                    }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
