using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.RegisterServiceClient rsc = new ServiceReference1.RegisterServiceClient();

        ServiceReference1.Fan fan = new ServiceReference1.Fan();
        ServiceReference1.FanLogin fl = new ServiceReference1.FanLogin();

        fan.FanName = FanName.Text;
        fan.FanEmail = FanEmail.Text;
        fl.FanLoginUserName = FanUsername.Text;
        fl.FanLoginPasswordPlain = FanPassword.Text;

        bool result = rsc.fanregistration(fan, fl);
        if (result)
        {
            Label1.Text = "Success!";
        }else
        {
            Label1.Text = "Try again!";
        }

    }
        /*
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
    
    */

    protected void Submit_Click(object sender, EventArgs e)
    {
       
    }
}