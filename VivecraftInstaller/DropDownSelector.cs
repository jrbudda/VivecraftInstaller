using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VivecraftInstaller
{
    public partial class DropDownSelector : Form
    {
        public DropDownSelector(List<string> items, string helpText)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(items.ToArray());
            label1.Text = helpText;
        }

        public string selection
        {
            get
            {
                return comboBox1.SelectedItem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
