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
    public partial class Deletecontacts : Form
    {
        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }
        public Deletecontacts()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from contact;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = this.Ds.Tables[0];

        }
        private void Deletecontacts_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            
            label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "")
            {
                MessageBox.Show("select a contact");
            }
            else {
                DialogResult res = MessageBox.Show("Confirm ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res.Equals(DialogResult.Yes))
                {



                    this.Sql = "delete from contact where PhoneNo = '" + this.label2.Text + "';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Phone. no" + label2.Text + " has been deleted");
                        this.PopulateGridView();
                    }

                    else
                    { MessageBox.Show("Eror while deleting data"); }



                }
            }
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ac = new Form1();
            this.Visible = false;
            ac.Visible = true;
        }
    }
}
