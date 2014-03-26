using System;
using System.Collections.Generic;
using System.Text;

using PTSDK;

namespace PTWikipediaSearch
{
    class WikipediaSearch : IPlugin
    {
        string m_strName = "PTWikipediaSearch";

        string m_strDisplayName = "Wikipedia Search";

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
            WikipediaForm wf = new WikipediaForm();
            wf.ShowDialog();
        }
    }
}
