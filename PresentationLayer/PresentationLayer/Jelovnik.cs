using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Jelovnik:Form
    {
        private MenuItemBuisiness menuItemBuisiness;
        public Jelovnik()
        {
            menuItemBuisiness = new MenuItemBuisiness();
            InitializeComponent();
        }

        private void Jelovnik_Load(object sender, EventArgs e)
        {
            List<DataLayer.Models.MenuItem> list = menuItemBuisiness.GetAllMenuItems();
            foreach(DataLayer.Models.MenuItem m in list)
            {
                listBoxMenuItems.Items.Add(m);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox4.Text);
            string title = textBox1.Text;
            string descrtiption = textBox2.Text;
            decimal price = Convert.ToDecimal(textBox3.Text);

            DataLayer.Models.MenuItem x = new DataLayer.Models.MenuItem(id,title, descrtiption, price);

            this.menuItemBuisiness.insertMenuItem(x);

            listBoxMenuItems.Items.Clear();

            List<DataLayer.Models.MenuItem> list = menuItemBuisiness.GetAllMenuItems();

            foreach(DataLayer.Models.MenuItem m in list)
            {
                listBoxMenuItems.Items.Add(m);
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void buttonMinMax_Click(object sender, EventArgs e)
        {
            List<DataLayer.Models.MenuItem> list = this.menuItemBuisiness.getMenuItemsByPrice(Convert.ToDecimal(textBoxMin.Text),
                Convert.ToDecimal(textBoxMax.Text));

            listBoxMinMax.Items.Clear();

            foreach(DataLayer.Models.MenuItem m in list)
            {
                listBoxMinMax.Items.Add(m);
            }
                
        }
    }
}
