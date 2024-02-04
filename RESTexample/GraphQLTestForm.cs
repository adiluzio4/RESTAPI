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
    public partial class GraphQLTestForm : Form
    {
        EntryForm ef;

        public GraphQLTestForm(EntryForm ef)
        {
            InitializeComponent();
            this.ef = ef;
        }

        private void GraphQLTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ef.Show();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            GQL client = new GQL(txtEndpoint.Text);
            client.ExecuteGqlQuery(txtQuery.Text);
            txtResponse.Text = client.Response;
        }
    }
}
