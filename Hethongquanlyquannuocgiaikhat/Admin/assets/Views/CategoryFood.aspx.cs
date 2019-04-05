using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Views_Category : System.Web.UI.Page
{
    private void LoadChuyenMuc()
    {
        XuLyChuyenMuc xl = new XuLyChuyenMuc();
        gvChuyenMuc.DataSource = xl.ListChuyenMuc();
        gvChuyenMuc.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = "";
        if (!IsPostBack)
        {
            LoadChuyenMuc();
            if (Request.QueryString["Action"] != null)
            {
                if (Request.QueryString["Action"] == "Add" || Request.QueryString["Action"] == "Edit")
                {
                    pnlThem.Visible = true;
                    txtMaChuyenMuc.Enabled = true;
                    btnThemChuyenMuc.Visible = false;
                    if (Request.QueryString["Action"] == "Edit")
                    {
                        txtMaChuyenMuc.Enabled = false;
                        btnSave.Visible = false;
                        int id = Convert.ToInt32(Request.QueryString["ID"]);
                        XuLyChuyenMuc xl = new XuLyChuyenMuc();
                        DataTable dt = xl.GetChuyenMuc(id);
                        txtMaChuyenMuc.Text = dt.Rows[0]["idCategoryFood"].ToString();
                        txtTenChuyenMuc.Text = dt.Rows[0]["Name"].ToString();                                                
                    }
                }
            }
            else
            {
                pnlThem.Visible = false;
                btnThemChuyenMuc.Visible = true;
            }
        }
    }
    private void EnableThem()
    {
        txtMaChuyenMuc.Text = "";
        txtTenChuyenMuc.Text = "";       
        txtTenChuyenMuc.Focus();
    }
    protected void btnThemChuyenMuc_Click(object sender, EventArgs e)
    {        
        Response.Redirect("CategoryFood.aspx?Action=Add");        
        EnableThem();
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        LinkButton b = (LinkButton)sender;
        if (b.CommandName == "Delete")
        {
            XuLyChuyenMuc xl = new XuLyChuyenMuc();
            int id = Convert.ToInt16(b.CommandArgument);
            xl.XoaChuyenMuc(id);
            LoadChuyenMuc();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        int maChuyenMuc = Convert.ToInt32(txtMaChuyenMuc.Text);
        ChuyenMuc obj = new ChuyenMuc(maChuyenMuc,txtTenChuyenMuc.Text);
        XuLyChuyenMuc xl = new XuLyChuyenMuc();
        int result = xl.ThemChuyenMuc(obj);
        if (result <= 0)
        {
            lblError.ForeColor = Color.Red;
            lblError.Text = "Thêm chuyên mục không thành công. Vui lòng kiểm tra lại dữ liệu";
        }
        else
        {
            lblError.ForeColor = Color.Blue;
            lblError.Text = "Thêm dữ liệu thành công";
            LoadChuyenMuc();
        }
    }
    protected void btnSaveChanges_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["Action"] == "Edit")
        {           
            int maChuyenMuc = Convert.ToInt32(txtMaChuyenMuc.Text);
            ChuyenMuc obj = new ChuyenMuc(maChuyenMuc, txtTenChuyenMuc.Text);
            XuLyChuyenMuc xl = new XuLyChuyenMuc();
            int result = xl.SuaChuyenMuc(obj);
            if (result <= 0)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Sửa chuyên mục không thành công. Vui lòng kiểm tra lại dữ liệu";
            }
            else
            {
                lblError.ForeColor = Color.Blue;
                lblError.Text = "Sửa dữ liệu thành công";
            }

            LoadChuyenMuc();
        }
        else
        {
            btnSave_Click(sender, e);
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CategoryFood.aspx");
    }
}