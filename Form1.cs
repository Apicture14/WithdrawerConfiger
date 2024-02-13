using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny;
using Sunny.UI;
using System.Reflection;

namespace WithdrawerConfiger
{
    public partial class Form1 : UIForm
    {
        public Form1()
        {
            InitializeComponent();
            SentenceUtils.HitokotoReply h = SentenceUtils.Request();
            LBMWord.Text = h.hitokoto;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.Filter = "Yaml File (*.yaml)|*.yaml|All Files (*.*)|*.*";
            if (fd.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show(fd.FileName);
                Load(fd.FileName, 0);
            }
        }

        private void Load(string path, int type)
        {
            try
            {
                string standard = "{0}|{1}|{2}";
                string fp = path;
                if (!File.Exists(fp))
                {
                    MessageBox.Show("No Config Found");
                    return;
                }

                if (type == 1)
                {
                    // daemon
                    DaemonConfig c = DaemonConfiguration.Read(fp);
                    TVD.Nodes.Clear();
                    TVD.Nodes.Add("Root", "CurrentConfig");
                    TreeNode rootNode = TVD.Nodes.Find("Root", false)[0];
                    AddtoNode(rootNode,c);
                    LBDpath.Text = fp;
                    return ;
                }
                else if (type == 0)
                {
                    //executor
                    ExecutorConfig c = ExecutorConfiguration.Read(fp);
                    TVE.Nodes.Clear();
                    TreeNode rootNode = TVE.Nodes.Add("Root", "CurrentConfig");
                    AddtoNode(rootNode, c);
                    LBEpath.Text = fp;
                }
                else
                {
                    return;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return;
                // throw;
            }
        }
        private void AddtoNode(TreeNode root,object obj)
        {
            TreeNode roo = root.Nodes.Add(obj.ToString());
            foreach (var vaProperty in obj.GetType().GetProperties())
            {
                TreeNode nextNode = roo.Nodes.Add(vaProperty.Name + ":" + vaProperty.GetValue(obj));
                TreeNode x = nextNode;
                Type te = vaProperty.PropertyType;
                if (te == typeof(List<TimeSpan>))
                {
                    foreach (var tv in (List<TimeSpan>)vaProperty.GetValue(obj))
                    {
                        AddtoNode(nextNode,tv);
                    }
                    
                }else if (te == typeof(List<Target>))
                {
                    foreach (var tv in (List<Target>)vaProperty.GetValue(obj))
                    {
                        AddtoNode(nextNode, tv);
                    }
                }else if (te == typeof(List<DaemonTarget>))
                {
                    foreach (var tv in (List<DaemonTarget>)vaProperty.GetValue(obj))
                    {
                        AddtoNode(nextNode, tv);
                    }
                }
                else if (te == typeof(DaemonInfo) || te == typeof(TimeSpan) || te == typeof(Target) || te == typeof(DaemonTarget))
                {
                    AddtoNode(nextNode,vaProperty.GetValue(obj));
                }
            }
            
        }

        private void BtnDBrowse_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.Filter = "Yaml File (*.yaml)|*.yaml|All Files (*.*)|*.*";
            if (fd.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show(fd.FileName);
                Load(fd.FileName, 1);
            }
        }

        private void BtnECreate_Click(object sender, EventArgs e)
        {
            FileDialog fd = new SaveFileDialog();
            fd.Filter = "Yaml File (*.yaml)|*.yaml|All Files (*.*)|*.*";
            fd.FileName = "config.yaml";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(fd.FileName);
            }

            ExecutorConfiguration.Write(ExecutorConfiguration.CreateDefault("WITHDRAWER",0x6a), fd.FileName);
            Load(fd.FileName,0);
        }

        private void BtnMRefresh_Click(object sender, EventArgs e)
        {
                
        }
    }
}d