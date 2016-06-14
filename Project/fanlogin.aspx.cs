using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class fanlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        ServiceReference1.RegisterServiceClient rsc = new ServiceReference1.RegisterServiceClient();
        int key = rsc.fanlogin(UserNameTextBox.Text, PasswordTextBox.Text);
        if (key != 0)
        {
            Session["key"] = key;
            LabelError.Text = "Welcome";
        }
        else
        {
            LabelError.Text = "Try Again";
        }
    }
}