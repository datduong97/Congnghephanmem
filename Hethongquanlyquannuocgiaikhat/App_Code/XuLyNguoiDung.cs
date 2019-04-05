using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

public class XuLyNguoiDung
{
    DuLieu dl = new DuLieu();
    public DataTable ListNguoiDung()
    {
        SqlParameter[] sqlParams = { };
        return dl.Select("SELECT * FROM Account", sqlParams);
    }
    public DataTable ListNguoiDungActive()
    {
        SqlParameter[] sqlParams = { };
        return dl.Select("SELECT * FROM Account WHERE Type = 1", sqlParams);
    }
    public DataTable GetNguoiDung(int id)
    {
        SqlParameter idnd = new SqlParameter("@UserName", id);
        SqlParameter[] sqlParams = { idnd };
        return dl.Select("SELECT * FROM Account WHERE UserName = @UserName", sqlParams);
    }
    public DataTable CheckDangNhap(NguoiDung obj)
    {
        SqlParameter tdn = new SqlParameter("@UserName", obj.TenDangNhap);
        SqlParameter mk = new SqlParameter("@Password", obj.MatKhau);
        SqlParameter[] sqlParams = { tdn, mk };
        return dl.Select("SELECT * FROM Account WHERE UserName = @UserName AND Password =@Password AND Type=1", sqlParams);
    }
    public DataTable CheckDangNhapAdmin(NguoiDung obj)
    {
        SqlParameter tdn = new SqlParameter("@UserName", obj.TenDangNhap);
        SqlParameter mk = new SqlParameter("@Password", obj.MatKhau);
        SqlParameter[] sqlParams = { tdn, mk };
        return dl.Select("SELECT * FROM Account WHERE UserName = @UserName AND Password =@Password AND Type=1 ", sqlParams);
    }
    public int SuaNguoiDung(int id)
    {
        SqlParameter idnd = new SqlParameter("@UserName", id);
        SqlParameter[] sqlParams = { idnd };
        return dl.SaveChanges("DELETE FROM Account WHERE UserName = @UserName", sqlParams);
    }
    public int XoaNguoiDung(int id)
    {
        SqlParameter idnd = new SqlParameter("@UserName", id);
        SqlParameter[] sqlParams = { idnd };
        return dl.SaveChanges("DELETE FROM Account WHERE UserName = @UserName", sqlParams);
    }
}
