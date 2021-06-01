using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NWLinq
{
    class BUS_DonHang
    {
        DAO_DonHang da;
        public BUS_DonHang()
        { 
            //Goi doi tuong cua lop DAO
            da = new DAO_DonHang();
        }
        public void DSDonHang(DataGridView dg)
        {
            dg.DataSource = da.LayDSDonHang3();
        }
        public void DSKH(ComboBox cb)
        {
            cb.DataSource = da.LayDSKH();
            cb.DisplayMember = "CompanyName";
            cb.ValueMember = "CustomerID";
        }
        public void DSNV(ComboBox cb)
        {
            cb.DataSource = da.LayDSNV();
            cb.DisplayMember = "LastName";
            cb.ValueMember = "EmployeeID";
        }
    }
}
