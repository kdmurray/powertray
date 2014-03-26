using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

namespace Krellsoft.Core
{
    /// <summary>
    /// Handles a System Hotkey
    /// </summary>
    public partial class SystemHotkey : System.ComponentModel.Component, IDisposable
    {
        
        protected DummyWindowWithEvent m_Window = new DummyWindowWithEvent();	//window for WM_Hotkey Messages
        protected Shortcut m_HotKey = Shortcut.None;
        protected bool isRegistered = false;
        public event System.EventHandler Pressed;
        public event System.EventHandler Error;
        private string m_Name = "";

        
        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
            }
        }

        public SystemHotkey(System.ComponentModel.IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            m_Window.ProcessMessage += new MessageEventHandler(MessageEvent);
        }

        public SystemHotkey()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                m_Window.ProcessMessage += new MessageEventHandler(MessageEvent);
            }
        }

        public new void Dispose()
        {
            if (isRegistered)
            {
                if (UnregisterHotkey())
                    System.Diagnostics.Debug.WriteLine("Unreg: OK");
            }
            System.Diagnostics.Debug.WriteLine("Disposed");
        }


        protected void MessageEvent(object sender, ref Message m, ref bool Handled)
        {	//Handle WM_Hotkey event
            if ((m.Msg == (int)Msgs.WM_HOTKEY) && (m.WParam == (IntPtr)this.GetType().GetHashCode()))
            {
                Handled = true;
                System.Diagnostics.Debug.WriteLine("HOTKEY pressed!");
                if (Pressed != null) Pressed(this, EventArgs.Empty);
            }
        }

        protected bool UnregisterHotkey()
        {	//unregister hotkey
            return User32.UnregisterHotKey(m_Window.Handle, this.GetType().GetHashCode());
        }

        protected bool RegisterHotkey(Shortcut key)
        {	//register hotkey
            int mod = 0;
            Keys k2 = Keys.None;
            if (((int)key & (int)Keys.Alt) == (int)Keys.Alt) { mod += (int)Modifiers.MOD_ALT; k2 = Keys.Alt; }
            if (((int)key & (int)Keys.Shift) == (int)Keys.Shift) { mod += (int)Modifiers.MOD_SHIFT; k2 = Keys.Shift; }
            if (((int)key & (int)Keys.Control) == (int)Keys.Control) { mod += (int)Modifiers.MOD_CONTROL; k2 = Keys.Control; }

            System.Diagnostics.Debug.Write(mod.ToString() + " ");
            System.Diagnostics.Debug.WriteLine((((int)key) - ((int)k2)).ToString());

            return User32.RegisterHotKey(m_Window.Handle, this.GetType().GetHashCode(), (int)mod, ((int)key) - ((int)k2));
        }

        public bool IsRegistered
        {
            get { return isRegistered; }
        }


        [DefaultValue(Shortcut.None)]
        public Shortcut Shortcut
        {
            get { return m_HotKey; }
            set
            {
                if (DesignMode) { m_HotKey = value; return; }	//Don't register in Designmode
                if ((isRegistered) && (m_HotKey != value))	//Unregister previous registered Hotkey
                {
                    if (UnregisterHotkey())
                    {
                        System.Diagnostics.Debug.WriteLine("Unreg: OK");
                        isRegistered = false;
                    }
                    else
                    {
                        if (Error != null) Error(this, EventArgs.Empty);
                        System.Diagnostics.Debug.WriteLine("Unreg: ERR");
                    }
                }
                if (value == Shortcut.None) { m_HotKey = value; return; }
                if (RegisterHotkey(value))	//Register new Hotkey
                {
                    System.Diagnostics.Debug.WriteLine("Reg: OK");
                    isRegistered = true;
                }
                else
                {
                    if (Error != null) Error(this, EventArgs.Empty);
                    System.Diagnostics.Debug.WriteLine("Reg: ERR");
                }
                m_HotKey = value;
            }
        }
    }
}