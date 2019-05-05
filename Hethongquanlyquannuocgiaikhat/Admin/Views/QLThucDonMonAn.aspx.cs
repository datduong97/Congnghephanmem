﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Views_QLThucDon : System.Web.UI.Page
{
    QLQuanNuocDataContext qlqn;
    private static bool mode;

    public void display()
    {
        qlqn = new QLQuanNuocDataContext();
        var qlb = from item in qlqn.Foods
                  select item;
        gvChuyenMuc.DataSource = qlb;
        gvChuyenMuc.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        qlqn = new QLQuanNuocDataContext();
        var ds = from item in qlqn.FoodCategories
                 select item;
        DropListMaLoai.DataSource = ds;
        DropListMaLoai.DataValueField = "idCategoryFood";
        DropListMaLoai.DataTextField = "name";
        DropListMaLoai.DataBind();
        display();
    }
   
    protected void btnNew_Click(object sender, EventArgs e)
    {
        mode = true;        
        txtTenChuyenMuc.Enabled = true;
        DropListMaLoai.Enabled = true;
        TxtGia.Enabled = true;        
        txtTenChuyenMuc.Text = "";
        TxtGia.Text = "";
    }
    protected void btnSaveChanges_Click(object sender, EventArgs e)
    {
        if (txtTenChuyenMuc.Text.Trim() == "") return;
        qlqn = new QLQuanNuocDataContext();
        if (mode == true)
        {
            Food fc = new Food();            
            fc.name = txtTenChuyenMuc.Text;
            fc.idCategoryFood = Convert.ToInt32(DropListMaLoai.SelectedValue.ToString());
            fc.price = Convert.ToDouble( TxtGia.Text);
            qlqn.Foods.InsertOnSubmit(fc);
            qlqn.SubmitChanges();
            lblError.Text = "Thêm thành công !";            
            txtTenChuyenMuc.Enabled = false;
            DropListMaLoai.Enabled = false;
            TxtGia.Enabled = false;
            display();
        }
        else
        {
            var qlb = from item in qlqn.Foods
                      where item.idFood == Convert.ToInt32(txtMaChuyenMuc.Text)
                      select item;
            Food fc = qlb.First();
            fc.name = txtTenChuyenMuc.Text;
            fc.idCategoryFood = Convert.ToInt32(DropListMaLoai.SelectedValue.ToString());
            fc.price = Convert.ToDouble(TxtGia.Text);
            qlqn.SubmitChanges();
            lblError.Text = "Sửa thành công !";            
            txtTenChuyenMuc.Enabled = false;
            DropListMaLoai.Enabled = false;
            TxtGia.Enabled = false;
            display();
        }   
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("QLThucDonMonAn.aspx");
    }
    protected void gvChuyenMuc_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int row = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName == "btnSua")
        {            
            txtTenChuyenMuc.Enabled = true;
            DropListMaLoai.Enabled = true;
            TxtGia.Enabled = true;
            txtMaChuyenMuc.Text = gvChuyenMuc.Rows[row].Cells[0].Text;
            txtTenChuyenMuc.Text = gvChuyenMuc.Rows[row].Cells[1].Text;
            DropListMaLoai.SelectedValue = gvChuyenMuc.Rows[row].Cells[2].Text;
            TxtGia.Text = gvChuyenMuc.Rows[row].Cells[3].Text;
        }
        else if (e.CommandName == "btnXoa")
        {
            string s = gvChuyenMuc.Rows[row].Cells[0].Text;
            qlqn = new QLQuanNuocDataContext();
            var qlb = from item in qlqn.Foods
                      where item.idFood == Convert.ToInt32(s)
                      select item;
            Food fc = qlb.First();
            if (qlb != null)
            {
                qlqn.Foods.DeleteOnSubmit(fc);
                qlqn.SubmitChanges();
                lblError.Text = "Xóa thành công !";
                display();
            }
        }
    }
}