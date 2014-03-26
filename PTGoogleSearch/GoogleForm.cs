using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PTGoogleSearch
{
    public partial class GoogleForm : Form 
    {
        bool bExpanded = false;

        public GoogleForm()
        {
            InitializeComponent();
            bExpanded = false;
            this.Height = 104;
        }

        private void chkDomain_CheckedChanged(object sender, EventArgs e)
        {
            txtDomain.Enabled = chkDomain.Checked;
            if (txtDomain.Enabled)
            {
                txtDomain.Focus();
            }
        }

        private void cmdExpand_Click(object sender, EventArgs e)
        {
            int iStep = 0;
            if (bExpanded)
            {
                //Shrink Form
                iStep = -5;
            }
            else
            {
                //Grow Form
                iStep = 5;
            }

            for (int deltaValue = 0; deltaValue < 100; deltaValue += System.Math.Abs(iStep))
            {
                this.Height += iStep;
                this.Refresh();
                System.Threading.Thread.Sleep(5);
            }
            bExpanded = !bExpanded;
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            string SearchURL = BuildSearchURL();

            if (SearchURL != "")
            {
                p.StartInfo.FileName = SearchURL;
                p.Start();
            }
            this.CancelButton.PerformClick();
        }

        string BuildSearchURL()
        {
            string SearchURL = "";
            string SearchString = txtSearchTerms.Text;

            try
            {
                if (optTimeline.Checked)
                {
                    SearchString += " view:timeline";
                }

                if (optMap.Checked)
                {
                    SearchString += " view:map";
                }

                if (chkDomain.Checked && txtDomain.Text != "")
                {
                    SearchString += " site:" + txtDomain.Text;
                }

                SearchURL = "http://www.google.com/search?q=" + System.Web.HttpUtility.UrlEncode(SearchString);

#if DEBUG
                System.Diagnostics.Debug.Print(SearchURL);
#endif

            }
            catch (Exception ex)
            {
                //TODO: Add Exception handling
            }

            return SearchURL;
        }

        private void GoogleForm_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            txtSearchTerms.Focus();
        }
    }
}