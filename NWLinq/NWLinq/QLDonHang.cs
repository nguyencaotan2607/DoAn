using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NWLinq
{
    public partial class QLDonHang : Form
    {
        BUS_DonHang busDonHang;
        public QLDonHang()
        {
            InitializeComponent();
            //Goi doi tuong cua BUS
            busDonHang = new BUS_DonHang();
        }

        private void QLDonHang_Load(object sender, EventArgs e)
        {
            busDonHang.DSNV(cbNhanVien);
            busDonHang.DSKH(cbKhachHang);
            busDonHang.DSDonHang(gVDH);
            //thay doi kích thước dg
            //co 4 cot. moi cot 20%
            gVDH.Columns[0].Width = (int) (0.2 * gVDH.Width);
            gVDH.Columns[1].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[2].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[3].Width = (int)(0.3 * gVDH.Width);

        }

        private void gVDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && e.RowIndex<gVDH.Rows.Count-1)//dòng 0 đến dòng số dòng-1
            {
                txtMaDH.Text = gVDH.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                dtpNgayDH.Text = gVDH.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbNhanVien.Text = gVDH.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbKhachHang.Text = gVDH.Rows[e.RowIndex].Cells[3].Value.ToString(); 
            }
        }
    }
}
