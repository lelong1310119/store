using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALReport
    {
        public DataTable getBillCase(int x)
        {
            string time1;
            string time2;
            if (x == 1)
            {
                time1 = "06:00:00";
                time2 = "12:00:00";
            } else
            {
                time1 = "12:00:00";
                time2 = "18:00:00";
            }
            string query = $"select hd.MaHD, hd.MaKH, hd.MaNV, hd.NgayLapHD, SUM(ct.SoLuong * sp.Dongia) AS TongTien from HoaDon hd " +
                $"join ChiTietHD ct ON hd.MaHD = ct.MaHD " +
                $"join SanPham sp ON sp.MaSP = ct.MaSP " +
                $"WHERE NgayLapHD BETWEEN CONCAT(CONVERT(date, GETDATE()),' {time1}') AND CONCAT(CONVERT(date, GETDATE()),' {time2}') " +
                $"group by hd.MaHD, hd.MaKH, hd.MaNV, hd.NgayLapHD;";
            DataTable dt = DataConnection.GetInstance().GetRecords(query);
            return dt;
        }

        public DataTable getBillDateTime(DateTime date)
        {
            string query = $"select hd.MaHD, hd.MaKH, hd.MaNV, hd.NgayLapHD, SUM(ct.SoLuong * sp.Dongia) AS TongTien from HoaDon hd " +
                $"join ChiTietHD ct ON hd.MaHD = ct.MaHD " +
                $"join SanPham sp ON sp.MaSP = ct.MaSP " +
                $"WHERE CONVERT(DATE, NgayLapHD) = CONVERT(DATE, '{date.ToString("yyyy-MM-dd")}') " +
                $"group by hd.MaHD, hd.MaKH, hd.MaNV, hd.NgayLapHD;";
            DataTable dt = DataConnection.GetInstance().GetRecords(query);
            return dt;
        }

        public DataTable getBillMonth(int month, int year)
        {
            string query = $"select hd.MaHD, hd.MaKH, hd.MaNV, hd.NgayLapHD, SUM(ct.SoLuong * sp.Dongia) AS TongTien from HoaDon hd " +
                $"join ChiTietHD ct ON hd.MaHD = ct.MaHD " +
                $"join SanPham sp ON sp.MaSP = ct.MaSP " +
                $"WHERE MONTH(NgayLapHD) = {month} AND YEAR(NgayLapHD) = {year} " +
                $"group by hd.MaHD, hd.MaKH, hd.MaNV, hd.NgayLapHD;";
            DataTable dt = DataConnection.GetInstance().GetRecords(query);
            return dt;
        }

        public DataTable getBillQuarter(int quarter, int year)
        {
            string query = $"SELECT hd.MaHD, hd.MaKH, hd.MaNV, hd.NgayLapHD, SUM(ct.SoLuong * sp.Dongia) AS TongTien " +
                $"FROM HoaDon hd " +
                $"JOIN ChiTietHD ct ON hd.MaHD = ct.MaHD " +
                $"JOIN SanPham sp ON sp.MaSP = ct.MaSP " +
                $"WHERE DATEPART(QUARTER, hd.NgayLapHD) = {quarter} AND DATEPART(YEAR, hd.NgayLapHD) = {year} " +
                $"GROUP BY hd.MaHD, hd.MaKH, hd.MaNV, hd.NgayLapHD";
            DataTable dt = DataConnection.GetInstance().GetRecords(query);
            return dt;
        }

        public DataTable getBillYear(int year)
        {
            string query = $"select hd.MaHD, hd.MaKH, hd.MaNV, hd.NgayLapHD, SUM(ct.SoLuong * sp.Dongia) AS TongTien from HoaDon hd " +
                $"join ChiTietHD ct ON hd.MaHD = ct.MaHD " +
                $"join SanPham sp ON sp.MaSP = ct.MaSP " +
                $"WHERE YEAR(NgayLapHD) = {year} " +
                $"group by hd.MaHD, hd.MaKH, hd.MaNV, hd.NgayLapHD; ";
            DataTable dt = DataConnection.GetInstance().GetRecords(query);
            return dt;
        }

    }
}
