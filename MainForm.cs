using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSchedule
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripAddStudent_Click(object sender, EventArgs e)
        {
            addStudent1.BringToFront();

        }

        private void toolStripAddBusy_Click(object sender, EventArgs e)
        {
            addPotentialDay1.BringToFront();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            showSchedule1.BringToFront();
        }
    }
}
