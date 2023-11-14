using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DropDownList1.Items.Add("image1");
                DropDownList1.Items.Add("image2");
                DropDownList1.Items.Add("image3");
                DropDownList1.Items.Add("image4");
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = DropDownList1.SelectedItem.ToString();

            if (selectedItem == "image1")
            {
                Image1.ImageUrl = "image1.jpg";
                Label1.Text = "cost: 50rupees";
            }
            else if (selectedItem == "image2")
            {
                Image1.ImageUrl = "image2.jpg";
                Label1.Text = "cost: 70rupees";
            }
            else if (selectedItem == "image3")
            {
                Image1.ImageUrl = "image3.jpg";
                Label1.Text = "cost: 80rupees";
            }
            else if (selectedItem == "image4")
            {
                Image1.ImageUrl = "image4.jpg";
                Label1.Text = "cost: 100rupees";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = DropDownList1.SelectedItem.ToString();
            Label1.Text = "You have chosen " + selectedItem + " and its cost is " + Label1.Text;
        }
    }

}
    
