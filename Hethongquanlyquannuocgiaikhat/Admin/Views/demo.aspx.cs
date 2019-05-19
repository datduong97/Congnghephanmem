using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Views_demo : System.Web.UI.Page
{
    QLQuanNuocDataContext qlqn;
    private static bool mode;
    protected void setcontrol(bool edit)
    {
        txtTenChuyenMuc.Enabled = edit;
        txtTrangthai.Enabled = edit;
    }
    public void display()
    {
        qlqn = new QLQuanNuocDataContext();
        var qlb = from item in qlqn.Tables
                  select item;
        gvChuyenMuc.DataSource = qlb;
        gvChuyenMuc.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        display();
    }
    protected void gvChuyenMuc_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int row = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName == "btnSua")
        {
            txtMaChuyenMuc.Text = gvChuyenMuc.Rows[row].Cells[0].Text;
            txtTenChuyenMuc.Text = gvChuyenMuc.Rows[row].Cells[1].Text;
            txtTrangthai.Text = gvChuyenMuc.Rows[row].Cells[2].Text;
        }
        else if (e.CommandName == "btnXoa")
        {
            string s = gvChuyenMuc.Rows[row].Cells[0].Text;
            qlqn = new QLQuanNuocDataContext();
            var qlb = from item in qlqn.Tables
                      where item.idTable == Convert.ToInt32(s)
                      select item;
            Table ban = qlb.First();
            if (qlb != null)
            {               
                qlqn.Tables.DeleteOnSubmit(ban);                
                qlqn.SubmitChanges();
                lblThongBao.Text = "Xóa thành công !";
                display();
            }
        }
    }
    protected void btnSaveChanges_Click(object sender, EventArgs e)
    {
        if (txtTenChuyenMuc.Text.Trim() == "") return;
        qlqn = new QLQuanNuocDataContext();
        if (mode)
        {
            Table ban = new Table();
            ban.name = txtTenChuyenMuc.Text;
            ban.status = txtTrangthai.Text;
            qlqn.Tables.InsertOnSubmit(ban);
            qlqn.SubmitChanges();
            lblThongBao.Text = "Thêm thành công !";
            display();
        }
        else
        {
            var qlb = from item in qlqn.Tables
                      where item.idTable == Convert.ToInt32(txtMaChuyenMuc.Text)
                      select item;
            Table ban = qlb.First();
            ban.name = txtTenChuyenMuc.Text;
            ban.status = txtTrangthai.Text;
            qlqn.SubmitChanges();
            lblThongBao.Text = "Sửa thành công !";
            display();
        }       
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("demo.aspx");
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        mode = true;
        setcontrol(true);
        txtMaChuyenMuc.Text = "";
        txtTenChuyenMuc.Text = "";
        txtTrangthai.Text = "";
    }  
}