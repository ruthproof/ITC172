using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; //for data table

public partial class _Default : System.Web.UI.Page
{

    DataClass dc = new DataClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        LoadDropDownList2();
    }

    protected void LoadDropDownList()
    {
        DataTable tbl = dc.GetServices();
        DropDownList1.DataSource = tbl;
        DropDownList1.DataTextField = "GrantTypeName";
        DropDownList1.DataValueField = "GrantTypeKey";
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, "Choose a Service");
    }

    protected void LoadDropDownList2()
    {
        DataTable tbl = dc.GetAuthors();
        DropDownList1.DataSource = tbl;
        DropDownList1.DataTextField = "authorName";
        DropDownList1.DataValueField = "authorKey";
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, "CHOOSE");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGrid();
    }

    protected void FillGrid()
    {
        if(!DropDownList1.SelectedValue.Equals("Choose:"))
        {

        
        int key = int.Parse(DropDownList1.SelectedValue.ToString());
        DataTable tbl = dc.GetAuthors();
        GridView1.DataSource = tbl;
        GridView1.DataBind();
        }

    }


}