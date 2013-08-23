using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Divelements.SandRibbon;
using Microsoft.Win32;

namespace shapes
{
    public partial class SettingForm : RibbonForm
    {
        MainForm frm;
        public SettingForm()
        {
            this.LocalRenderer.ColorScheme = Program.colorTheme;
            InitializeComponent(); 
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            frm = this.Owner as MainForm;
            if (frm == null)
            {
                return;
            }

            if (comboBox1.SelectedIndex!=-1)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0: frm.ribbon.Renderer.ColorScheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.System;
                        updateall(Divelements.SandRibbon.Rendering.Office2007ColorScheme.System);
                        break;
                    case 1:frm.ribbon.Renderer.ColorScheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.LunaBlue;
                        updateall(Divelements.SandRibbon.Rendering.Office2007ColorScheme.LunaBlue);
                        break;
                    case 2:frm.ribbon.Renderer.ColorScheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.Silver;
                        updateall(Divelements.SandRibbon.Rendering.Office2007ColorScheme.Silver);
                        break;
                    case 3: frm.ribbon.Renderer.ColorScheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.Vista;
                        updateall(Divelements.SandRibbon.Rendering.Office2007ColorScheme.Vista);
                        break;
                    default:
                        break;
                }
            }
        }

        private void updateall(Divelements.SandRibbon.Rendering.Office2007ColorScheme color) {
            Program.colorTheme = color; ;
            foreach (Form item in Application.OpenForms)
            {
                RibbonForm frm = item as RibbonForm;
                if (frm!=null)
                {
                    frm.LocalRenderer.ColorScheme = color;
                }
            }
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            RegistryKey local = Registry.LocalMachine;

            RegistryKey key = local.CreateSubKey(@"software\gl\setting");
            if (key != null)
            {
                Object theme = key.GetValue("theme");
                if (theme == null)
                {
                    key.SetValue("theme", 0);
                }
                int color = int.Parse(key.GetValue("theme").ToString());
                comboBox1.SelectedIndex = color;
            }
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            frm = this.Owner as MainForm;
            RegistryKey local = Registry.LocalMachine;

            RegistryKey key = local.CreateSubKey(@"software\gl\setting");
            if (key != null)
            {
                Object theme = key.GetValue("theme");
                if (theme == null)
                {
                    key.SetValue("theme", 0);
                }
                
                switch (comboBox1.SelectedIndex)
                {
                    case 0: 
                        key.SetValue("theme", 0);
                        break;
                    case 1: 
                        key.SetValue("theme", 1);
                        break;
                    case 2: 
                        key.SetValue("theme", 2);
                        break;
                    case 3: key.SetValue("theme", 3);
                        break;
                    default: 
                        key.SetValue("theme", 0);
                        break;
                }
                key.Close();
            }
        }

        private void t1_Scroll(object sender, EventArgs e)
        {
            bar.Value = t1.Value;
            l1.Text = t1.Value.ToString();
        }

        private void t2_Scroll(object sender, EventArgs e)
        {
            bar.MasterValue = t2.Value;
            l2.Text = t2.Value.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistryKey local = Registry.LocalMachine;

            RegistryKey key = local.CreateSubKey(@"software\gl\setting");
           
            key.SetValue("f0", String.Empty);
            key.SetValue("f1", String.Empty);
            key.SetValue("f2", String.Empty);
            key.SetValue("f3", String.Empty);
            key.SetValue("f4", String.Empty);
            key.SetValue("f5", String.Empty);
            key.Close();
            (this.Owner as MainForm).loaddocs();
        }
    }
}
