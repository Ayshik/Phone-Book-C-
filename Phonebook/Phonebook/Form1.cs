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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Allcontacts ac = new Allcontacts();
            this.Visible = false;
            ac.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Newcontacts ac = new Newcontacts();
            this.Visible = false;
            ac.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Updatecontacts ac = new Updatecontacts();
            this.Visible = false;
            ac.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deletecontacts ac = new Deletecontacts();
            this.Visible = false;
            ac.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
