using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAMEditorPrototype
{
    public partial class currentoam : Form
    {
        public currentoam()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "TXT (*.txt)|*.txt|OAM (*.oam)|*.oam|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            ofd.ShowDialog();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void up_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void down_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void toggleBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void load_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }
    }
}
