using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    public partial class uxTextEditor : Form
    {
        public uxTextEditor()
        {
            InitializeComponent();
        }

        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fn = uxOpenFileDialog.FileName;
                MessageBox.Show("We can't open" + fn);
            }
        }

        private void uxSaveAs_Click(object sender, EventArgs e)
        {
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fn = uxSaveFileDialog.FileName;
                MessageBox.Show("We can't save" + fn);
            }
        }
    }
}
