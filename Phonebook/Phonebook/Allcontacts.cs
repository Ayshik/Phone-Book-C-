using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Allcontacts : Form
    {

        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }

        public Allcontacts()
        {
            InitializeComponent();
            this.Da = new DataAccess();
          
            this.PopulateGridView();
        }

        private void Allcontacts_Load(object sender, EventArgs e)
        {
            
        }

        private void PopulateGridView(string sql = "select * from contact;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = this.Ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ac = new Form1();
            this.Visible = false;
            ac.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.Sql = @"select * from contact where Name like '" + this.textBox4.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 ac = new Form1();
            this.Visible = false;
            ac.Visible = true;
        }
    }
}
