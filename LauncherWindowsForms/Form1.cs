using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherWindowsForms
{
    public partial class Launcher : Form
    {
        private string arguments = null;
        private string finalarguments = null;
        private string fp = null;
        private string customprms = null;
        private string mods = null;

        public Launcher()
        {
            InitializeComponent();
            LoadAddons();
        }

        private void FilePatching_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void AddonList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CustomParams_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            arguments += " -nosplash";
        }

        private void SkipIntro_CheckedChanged(object sender, EventArgs e)
        {
            arguments += " -skipintro";
        }

        public void CheckForFilePatching()
        {
            fp = null;
            if (FilePatching.Checked == true)
            {
                fp += " -FilePatching";
            }
            else if (!FilePatching.Checked == true)
            {
                fp += " -noFilePatching";
            }
        }

        public void CustomParamsGet()
        {
            customprms = null;
            customprms += " ";
            customprms += CustomParams.Text;
        }

        public void LoadAddons()
        {
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(@"d:\\Games\\Steam\\steamapps\\common\\Arma 3\\list.txt"))
                {
                    AddonList.Items.Clear();
                    while (!sr.EndOfStream)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            string strListItem = sr.ReadLine();
                            if (!String.IsNullOrEmpty(strListItem))
                                AddonList.Items.Add(strListItem);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public void  CheckAddonsList()
        {
            mods = "-mod=";
            // Next show the object title and check state for each item selected.
            foreach (object itemChecked in AddonList.CheckedItems)
            {
                // Use the IndexOf method to get the index of an item.
                mods += itemChecked.ToString();
                mods += ";";
                //System.IO.Directory.GetDirectories;
            }
        }
        private void LaunchGame_Click(object sender, EventArgs e)
        {

            try
            {
                CheckAddonsList();
                CheckForFilePatching();
                CustomParamsGet();
                finalarguments = mods + arguments + fp + customprms;
                System.Diagnostics.Process.Start("D:\\Games\\Steam\\steamapps\\common\\Arma 3\\arma3_x64.exe", finalarguments);
            }
            catch (Exception)
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
