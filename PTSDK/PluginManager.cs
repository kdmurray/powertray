using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Reflection;
using System.IO;

namespace PTSDK
{
    public class PluginManager
    {
        private Hashtable m_htAvailablePlugins;

        public PluginManager()
        {
            m_htAvailablePlugins = new Hashtable();
        }

        public object InstantiatePlugin(string PluginName)
        {
            object oPlugin = null;
            try
            {
                oPlugin = m_htAvailablePlugins[PluginName];
            }
            catch (Exception ex)
            {
                //TODO: Exception handler
            }
            return oPlugin;

        }

        public ArrayList LoadPlugins()
        {
            ArrayList alPlugins = new ArrayList();

            string[] strPlugins = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.dll");

            foreach (string s in strPlugins)
            {
                object oPlugin = Load(s);
                if (oPlugin != null)
                {
                    string strName = ((IPlugin)oPlugin).Name;
                    alPlugins.Add(strName);
                    m_htAvailablePlugins.Add(strName, oPlugin);
                }
            }
            return alPlugins;
        }

        private object Load(string strFile)
        {
            Type[] ta;
            Assembly a;
            try
            {
                FileInfo fi = new FileInfo(strFile);

                a = Assembly.LoadFrom(fi.FullName);
                ta = a.GetTypes();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message + "\n" + ex.StackTrace);
                return null;
            }

            foreach (Type t in ta)
            {
                try
                {
                    if (t.GetInterface("PTSDK.IPlugin") != null)
                    {
                        IPlugin plugin = (IPlugin)(Activator.CreateInstance(t));
                        return plugin;
                    }
                }
                catch (Exception) { }
            }
            return null;
        }

        public object this[string strPluginName]
        {
            get
            {
                if (strPluginName.Trim() == "")
                {
                    return null;
                }
                if (m_htAvailablePlugins.ContainsKey(strPluginName))
                {
                    return m_htAvailablePlugins[strPluginName];
                }
                else
                {
                    return null;
                }
            }
        }

        public int Count
        {
            get
            {
                return m_htAvailablePlugins.Count;
            }
        }
    }
}