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
    public partial class Load : Form
    {
        public string id;
        public Load()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void isDisplay(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                passwordBox.PasswordChar = '*';
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Load_Load(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '*';
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = idbox.Text;
            string password = passwordBox.Text;
            if(roles.SelectedItem == "读者") {
                libraryDataSetTableAdapters.readerTableAdapter adapter = new libraryDataSetTableAdapters.readerTableAdapter();
                libraryDataSet.readerDataTable readers;
                
                if(adapter.ScalarQuery(id,password).ToString() == "1")
                {
                    MessageBox.Show("登录成功");
                }
            }
            else if(roles.SelectedItem == "图书管理员")
            {

            }
            else if(roles.SelectedItem == "证件管理员")
            {

            }
            else
            {
                MessageBox.Show("请选择身份!");
            }
        }
    }
}
