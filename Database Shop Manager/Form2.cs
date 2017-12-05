using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Shop_Manager
{
    public partial class Form2 : Form
    {
        private DbSet<Customers> customers;

        public Form2()
        {
            InitializeComponent();
            Image myImage = Database_Shop_Manager.Properties.Resources.banner;
            pbxBanner.Image = ScaleImage(myImage, pbxBanner.Width, pbxBanner.Height);
            pbxBanner.SizeMode = PictureBoxSizeMode.CenterImage;

            LoadDate();

        }

        private void LoadDate()
        {
            CustomerEntities db = new CustomerEntities();
            customers = db.Customers;
            foreach (var item in customers)
            {
                //Debug.WriteLine(item.Name + " " + item.Surname);
                dGv_dane_z_bazy.Rows.Add(item.Name, item.Surname);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ReturnForm();
            Program.CloseConnection();
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        private bool log = false;
        private bool log_add = false;
        private int curRow = -1;

        private void dGv_dane_z_bazy_SelectionChanged(object sender, EventArgs e)
        {
            if (log)
            {
                if (dGv_dane_z_bazy.CurrentRow.Index != curRow)
                {
                    curRow = dGv_dane_z_bazy.CurrentRow.Index;
                }
                Customers cust = customers.ToList()[curRow];

                txB_Name.Text = cust.Name;
                txB_Surname.Text = cust.Surname;
                txB_Country.Text = cust.Country;
                txB_City.Text = cust.City;
                dTP_Birthday.Value = new DateTime(cust.Birthday.Value.Year, cust.Birthday.Value.Month, cust.Birthday.Value.Day);
            }
            else
            {
                log = true;
            }
        }

        private void RestartDate() 
        {
            log = false;
            cBx_deleteCustomer.Checked = false;
            dGv_dane_z_bazy.Rows.Clear();
            dGv_dane_z_bazy.Refresh();
            LoadDate();
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            CustomerEntities db = new CustomerEntities();
            if (log_add)
            {
                Customers cst = new Customers();
                cst.Name = txB_Name.Text;
                cst.Surname = txB_Surname.Text;
                cst.Country = txB_Country.Text;
                cst.City = txB_City.Text;
                cst.Birthday = dTP_Birthday.Value;
                db.Customers.Add(cst);                

                log_add = false;
                btn_SaveChanges.Text = "Zapisz zmiany";
                cBx_deleteCustomer.Visible = true;
            }
            else
            {
                Customers cust = customers.ToList()[curRow];
                var customer = db.Customers.Where(s => s.ID == cust.ID).First();

                if (cBx_deleteCustomer.Checked == false)
                {
                    customer.Name = txB_Name.Text;
                    customer.Surname = txB_Surname.Text;
                    customer.Country = txB_Country.Text;
                    customer.City = txB_City.Text;
                    customer.Birthday = dTP_Birthday.Value;
                }
                else
                {
                    db.Customers.Remove(customer);
                }
            }
            db.SaveChanges();
            RestartDate();
        }

        private void btn_AddNewCustomer_Click(object sender, EventArgs e)
        {
            txB_Name.Text = "";
            txB_Surname.Text = "";
            txB_Country.Text = "";
            txB_City.Text = "";
            dTP_Birthday.Value = DateTime.Now;

            log_add = true;
            btn_SaveChanges.Text = "Dodaj";
            cBx_deleteCustomer.Visible = false;
        }
    }
}
