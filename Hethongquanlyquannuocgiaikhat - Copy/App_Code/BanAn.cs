using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class BanAn
{
	public int MaBan { get; set; }
    public string TenBan { get; set; }         
    public string TrangThai { get; set; }
    public BanAn()
    {

    }
    public BanAn(string tenBan, string trangThai)
    {        
        TenBan = tenBan;
        TrangThai = trangThai;
    }
    public BanAn(int maBan, string tenBan, string trangThai)
    {
        MaBan = maBan;
        TenBan = tenBan;        
        TrangThai = trangThai;
    }
}