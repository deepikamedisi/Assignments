using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPASSIGNMENT
{
    public partial class LIST : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set the default image when the page loads
                imgItem.ImageUrl = "Images/default.jfif";
            }
        }

        protected void btnShowCost_Click(object sender, EventArgs e)
        {
            // Replace this with your logic to calculate and display the cost
            // Here, we're just displaying a placeholder message
            string selectedItem = ddlItems.SelectedValue;
            string cost = string.Empty;
            if (selectedItem == "1")
            {
                
                cost = "100000";

            }

            else if (selectedItem == "2")
            {
               
                cost = "150000";
            }

            else if (selectedItem == "3")
            {
               
                cost = "200000";
            }
            else if (selectedItem == "4")
            {
               
                cost = "80000";
            }

            string Item = ddlItems.SelectedItem.Text;

            lblCost.Text = $"Cost of {Item}: {cost}";

        }

        protected  void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When an item is selected, update the image accordingly
            string selectedItem = ddlItems.SelectedValue;
            string cost = string.Empty;
            if (selectedItem == "1")
            {
                imgItem.ImageUrl = $"Images/KTM.jfif";
               
                
            }

            else if (selectedItem == "2")
            {
                imgItem.ImageUrl = $"Images/MT 15.jfif";
                
            }

            else if (selectedItem == "3")
            {
                imgItem.ImageUrl = $"Images/ROYAL ENFIELD.jfif";
               
            }
            else if (selectedItem == "4")
            {
                imgItem.ImageUrl = $"Images/PULSAR.jfif";
                
            }
            else
            {

                imgItem.ImageUrl = $"Images/{"Images/default.jfif"}";
            }
        }
    }
        
    
}