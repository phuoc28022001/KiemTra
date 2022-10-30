using KiemTra.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KiemTra.Model;
using KiemTra.Services;

namespace KiemTra
{
    public partial class frmSinhVien : Form
    {
        SinhVienViewModel sinhVien;
        public frmSinhVien()
        {
            InitializeComponent();
            SinhVienViewModel sinhVien = null;
            this.sinhVien = sinhVien;
            if (sinhVien != null)
            {
                txtMSV.Text = sinhVien.MSV;
                txtHoDem.Text = sinhVien.HoDem;
                txtTen.Text = sinhVien.Ten;
                txtNgaySinh.Text = sinhVien.NgaySinh.ToString();
                if (sinhVien.GioiTinh == 0)
                {
                    rdbNam.Checked = true;
                }
                else if (sinhVien.GioiTinh == 1)
                {
                    rdbNu.Checked = true;
                }
                else
                {
                    rdbKhac.Checked = true;
                }
                txtEmail.Text = sinhVien.Email;
                txtSDT.Text = sinhVien.SoDienThoai;
                cbbIDNhom.Text = sinhVien.IDNhom.ToString();
            }

    }
        public Nhom selectedNhom
        {
            get { return cbbIDNhom.SelectedItem as Nhom; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                {
                    #region Thêm mới sinh viên
                    var sv = new SinhVien
                    {
                        HoDem = txtHoDem.Text,
                        Ten = txtTen.Text,
                        NgaySinh = txtNgaySinh.Value,
                        MSV = txtMSV.Text,
                    };
                    if (SinhVienServices.AddSinhVien(sv) == KetQua.ThanhCong)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Mã sinh viên trùng", "Thông báo");
                        txtMSV.Focus();
                    }
                    #endregion
                }
              
                }
            }
        }
    

