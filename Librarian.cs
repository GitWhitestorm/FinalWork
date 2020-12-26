using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWork
{
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
            Sreach test1 = new Sreach();
            test1.TopLevel = false;
            test1.panel2.Visible = false;
            test1.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(test1);
            test1.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 功能ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
