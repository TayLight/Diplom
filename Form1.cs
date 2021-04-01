using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using CrystalDecisions.CrystalReports.Engine;
using System.Collections;
using Зачетное_задание_Евтушевская.db.dao;
using Зачетное_задание_Евтушевская.db.entities;

namespace Зачетное_задание_Евтушевская
{
    
    public partial class Form1 : Form
    {
        private List<string> employ = new List<string>();
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try /* Select After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = "Host=localhost; Database=diplom; Username=postgres; Password=root";
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Select * from employer";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    connection.Close();
                   
                    employ.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        string strN = "";
                        for (int i = 0; i < 9; i++)
                        {
                            strN += row.ItemArray[i].ToString();
                            strN += " | ";
                        }
                       
                        employ.Add(strN);
                    }
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex) { }
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", null));
            XmlNode rootNode = doc.AppendChild(doc.CreateElement("department"));
            for(int i=0; i<employ.Count; i++)
            {
                XmlNode xmlNode = rootNode.AppendChild(doc.CreateElement("employer"));
                xmlNode.InnerText = employ.GetEnumerator().MoveNext().ToString();
            }
            doc.Save(@".\dataset.xml");
        
            Form2 frm = new Form2(this);
            //Указываем отчёт для CrystalReportViewer
         
            //Открываем форму.
            frm.Show();
        }

        /// <summary>
        /// SELECT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList allPayments = new ArrayList();
            try /* Select After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    DAO dao = new DAO();
                    dataGridView1.DataSource = dao.GetAll(new Employer());
                }
            }
            catch (Exception ex) { }
        }

        //INSERT
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        //DELETE
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        //UPDATE
        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form5 = new Form6();
            form5.Show();
        }

        private void crystalOpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void scrEventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
