using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using PTSDK;


namespace PowerTray
{
    public partial class MainForm : Form
    {
        PluginManager pMgr;
        ArrayList alPlugins;
        NotifyIcon nIco;
        ArrayList arlHotkeys;

        DataSet dsSettings;

        public FormModes myMode = FormModes.Normal;

        public MainForm()
        {
            InitializeComponent();
            this.Hide();
            pMgr = new PluginManager();
            alPlugins = new ArrayList();
            arlHotkeys = new ArrayList();

            LoadPlugins();
            dsSettings = PTSettings.LoadSettings();

            ParseSettings();
        }

        private void MenuEventHandler(object sender, System.EventArgs e)
        {
            Krellsoft.Core.SystemHotkey htk = (Krellsoft.Core.SystemHotkey)sender;
            LaunchPlugin(htk.Name);
        }

        private void ParseSettings()
        {
            try
            {
                for (int iPluginCount = 0; iPluginCount < dsSettings.Tables["Plugins"].Rows.Count; iPluginCount++)
                {
                    Krellsoft.Core.SystemHotkey newHotkey = new Krellsoft.Core.SystemHotkey(this.components);
                    newHotkey.Name = dsSettings.Tables["Plugins"].Rows[iPluginCount]["Name"].ToString();
                    newHotkey.Shortcut = Globals.GetShortcutKey(dsSettings.Tables["Plugins"].Rows[iPluginCount]["Shortcut"].ToString());
                    newHotkey.Pressed += new System.EventHandler(this.MenuEventHandler);

                    arlHotkeys.Add(newHotkey);
                } 
            }
            catch (Exception ex)
            {
                //TODO: Handle Exception
                System.Windows.Forms.MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (myMode == FormModes.FirstLoad)
            {
                this.Hide();
                this.myMode = FormModes.Normal;
                
                LoadTrayIcon();
            }
        }

        void LoadPlugins()
        {
            alPlugins = pMgr.LoadPlugins();

            foreach (object o in alPlugins)
            {
                string s = (string)o;
            }

        }

        void LoadTrayIcon()
        {
            nIco = new NotifyIcon();
            nIco.ContextMenu = GenerateContextMenu();
            nIco.Icon = new Icon("app.ico");
            nIco.Visible = true;
        }

        ContextMenu GenerateContextMenu()
        {
            ContextMenu mnu = new ContextMenu();
            mnu.MenuItems.Add(new MenuItem("&Options", new System.EventHandler(PluginMenuOptions_Click)));
            mnu.MenuItems.Add(new MenuItem("-"));
            mnu.MenuItems.Add("PT Plugins", BuildPluginMenu());
            mnu.MenuItems.Add(new MenuItem("-"));
            mnu.MenuItems.Add(new MenuItem("E&xit", new System.EventHandler(PluginMenuExit_Click)));
            return mnu;
        }

        MenuItem[] BuildPluginMenu()
        {

            MenuItem[] mia = new MenuItem[alPlugins.Count];

            for (int i = 0; i < alPlugins.Count; i++)
            {
                string s = (string)alPlugins[i];
                mia[i] = new MenuItem(s, new System.EventHandler(PluginSubMenuItem_Click));
            }

            return mia;
        }

        void ApplyChanges()
        {
        }

        void CloseForm()
        {
        }

        void PluginMenuOptions_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal; 
            this.BringToFront();
            this.Focus();
        }

        void PluginMenuExit_Click(object sender, EventArgs e)
        {
            nIco.Visible = false;
            Application.Exit();
        }

        void PluginSubMenuItem_Click(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            LaunchPlugin(mi.Text);
        }

        bool LaunchPlugin(string PluginName)
        {
            try
            {
                IPlugin currentPlugin = (IPlugin)pMgr.InstantiatePlugin(PluginName);
                currentPlugin.Launch();
                return true;
            }
            catch (Exception ex)
            {
                //TODO: Handle Exception
                System.Windows.Forms.MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                return false;
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            CloseForm();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void cmdApply_Click(object sender, EventArgs e)
        {
            ApplyChanges();
        }
    }
}