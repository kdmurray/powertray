using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PTWikipediaSearch
{
    public partial class WikipediaForm : Form
    {
        public WikipediaForm()
        {
            InitializeComponent();
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
                SearchURL = "http://en.wikipedia.org/wiki/Special:Search?search=" + System.Web.HttpUtility.UrlEncode(SearchString) + "&fulltext=Search";

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
    }
}