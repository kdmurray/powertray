using System;
using System.Collections.Generic;
using System.Text;

namespace PTGoogleSearch
{
    public class GoogleSearch : PTSDK.IPlugin
    {
        string m_strName = "PTGoogleSearch";
        string m_strDisplayName = "Google Search";

        public string DisplayName
        {
            get
            {
                return m_strDisplayName;
            }
        }

        public string Name
        {
            get
            {
                return m_strName;
            }
        }

        public void Launch()
        {
            GoogleForm gf = new GoogleForm();
            gf.ShowDialog();
            gf.BringToFront();
        }
    }
}
