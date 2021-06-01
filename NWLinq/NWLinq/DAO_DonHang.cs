using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NWLinq
{
    class DAO_DonHang
    {
        //Khai bao doi tuong database, sur dungj Linq
        NWDataContext db;

        public DAO_DonHang()
        { 
            //ket noi voi database
            db = new NWDataContext();
        }

        public IEnumerable<Order> LayDSDonHang()
        {//tra ve ds don hang
            IEnumerable<Order> dsDH = db.Orders.Select(s => s);
            return dsDH;
        }
        public List<Order> LayDSDonHang2()
        {//tra ve ds don hang
            //List<Order> dsDH = db.Orders.Select(s => s).ToList();
            List<Order> dsDH = (from i in db.Orders
                                select i).ToList();
            return dsDH;
        }
        //Buoc 2: Xu ly lay duoc tenNv, tenKh, gioi han cot hien thi ra DG
        public dynamic LayDSDonHang3()//phải return vè ds
        { 
            dynamic dsDH = db.Orders.Select(s => new 
            {
                s.OrderID,
                s.OrderDate,
                s.Employee.LastName,//thay vì kết bảng=> linq cho lấy thông qua bảng dựa khóa ngoại
                s.Customer.CompanyName
            });
            return dsDH;
        }

        public dynamic LayDSKH()
        {
            var ds = db.Customers.Select(k => new { k.CustomerID, k.CompanyName });
            return ds;
        }
        public dynamic LayDSNV()
        {
            var ds = db.Employees.Select(k => new { k.EmployeeID, k.LastName });
            return ds;
        }
    }
}
