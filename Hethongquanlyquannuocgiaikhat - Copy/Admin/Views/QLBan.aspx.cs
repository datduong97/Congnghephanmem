using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Views_QLDatBan : System.Web.UI.Page
{
    private void LoadChuyenMuc()
    {
        XuLyBan xl = new XuLyBan();
        gvChuyenMuc.DataSource = xl.ListChuyenMuc();
        gvChuyenMuc.DataBind();
    }
    private void EnableThem()
    {
        txtMaChuyenMuc.Text = "Hệ thống tự động sinh mã";
        txtTenChuyenMuc.Text = "";
        txtTrangthai.Text = "";
        txtTenChuyenMuc.Focus();
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
                    btnThemChuyenMuc.Visible = false;
                    if (Request.QueryString["Action"] == "Edit")
                    {                        
                        btnSave.Visible = false;
                        int id = Convert.ToInt32(Request.QueryString["ID"]);
                        XuLyBan xl = new XuLyBan();
                        DataTable dt = xl.GetChuyenMuc(id);
                        txtMaChuyenMuc.Text = dt.Rows[0]["idTable"].ToString();
                        txtTenChuyenMuc.Text = dt.Rows[0]["Name"].ToString();
                        txtTrangthai.Text = dt.Rows[0]["status"].ToString();                        
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

    protected void btnThemChuyenMuc_Click(object sender, EventArgs e)
    {
        Response.Redirect("QLBan.aspx?Action=Add");
        EnableThem();
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        LinkButton b = (LinkButton)sender;
        if (b.CommandName == "Delete")
        {
            XuLyBan xl = new XuLyBan();
            int id = Convert.ToInt16(b.CommandArgument);
            xl.XoaChuyenMuc(id);
            LoadChuyenMuc();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {               
        BanAn obj = new BanAn(txtTenChuyenMuc.Text, txtTrangthai.Text);
        XuLyBan xl = new XuLyBan();
        int result = xl.ThemChuyenMuc(obj);
        if (result <= 0)
        {
            lblError.ForeColor = Color.Red;
            lblError.Text = "Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu";
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
            BanAn obj = new BanAn(maChuyenMuc, txtTenChuyenMuc.Text, txtTrangthai.Text);
            XuLyBan xl = new XuLyBan();
            int result = xl.SuaChuyenMuc(obj);
            if (result <= 0)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Sửa dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu";
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
        Response.Redirect("QLBan.aspx");
    }
}