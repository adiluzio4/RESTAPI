using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTexample
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestTestForm tf = new RestTestForm(this);
            tf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GraphQLTestForm gqlf = new GraphQLTestForm(this);
            gqlf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Not implemented
            MessageBox.Show("Not yet implemented. Please choose another option.");
        }
    }
}
