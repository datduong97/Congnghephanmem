using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer_Views_menu_admin : System.Web.UI.Page
{
    string conStr = "Data Source=DESKTOP-J0S9OLN;Initial Catalog=CNPM_QLNGK;Integrated Security=True";
    SqlConnection mySqlConnection;
    SqlCommand mySqlCommand;
    protected void Page_Load(object sender, EventArgs e)
    {
        mySqlConnection = new SqlConnection(conStr);
        mySqlConnection.Open();
        string sSql = "select * from DrinkCategory";
        mySqlCommand = new SqlCommand(sSql, mySqlConnection);
        SqlDataReader drDrinkCategory = mySqlCommand.ExecuteReader();
        DataTable dtDrinkCategory = new DataTable();
        dtDrinkCategory.Load(drDrinkCategory);
        DropDownList2.DataSource = dtDrinkCategory;
        DropDownList2.DataValueField = "idCategoryDrink";
        DropDownList2.DataTextField = "name";
        DropDownList2.DataBind();

    }

    protected void DropDownList2_SelectedIndexChanged1(object sender, EventArgs e)
    {
        string sSql = "select * from Drink where idCategoryDrink=" +"2";
        mySqlCommand = new SqlCommand(sSql, mySqlConnection);
        SqlDataReader drDrink = mySqlCommand.ExecuteReader();
        DataTable dtDrink = new DataTable();
        dtDrink.Load(drDrink);
        GridView1.DataSource = dtDrink;
        GridView1.DataBind();


    }
}