using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Shop_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Program.CloseForm();
            if (Program.Login(Program.getLogin(), Program.getPassword()))
            {
                Program.ChangeForm(new Form2());
            }            
        }        
    }
}
