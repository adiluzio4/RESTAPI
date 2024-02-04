using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace RESTexample
{
    public partial class RestTestForm : Form
    {
        EntryForm ef;

        public RestTestForm(EntryForm ef)
        {
            this.ef = ef;
            InitializeComponent();
            rbPOST.Checked = true;
            rbGet.Checked = true;
        }

        public RestTestForm()
        {
            InitializeComponent();
            rbPOST.Checked = true;
            rbGet.Checked = true;
        }

        private void btnGET_Click(object sender, EventArgs e)
        {
            RESTclient http = new RESTclient(txtURL.Text);
            string response;
            if (rbGet.Checked) { response = http.GET(txtUrlParams.Text); }
            else { response = http.DELETE(txtUrlParams.Text); }
            txtResponse.Text = response;
        }

        private void btnPOST_Click(object sender, EventArgs e)
        {
            RESTclient http = new RESTclient(txtURL.Text);
            string response;
            if (rbPOST.Checked) { response = http.POST(txtPostInput.Text, RESTclient.httpContentType.str); }
            else { response = http.PUT(txtPostInput.Text, RESTclient.httpContentType.str); }
            txtResponse.Text = response;
        }

        private void RestTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ef.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ef.Close();
        }
    }
}
