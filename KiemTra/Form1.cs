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
using KiemTra.Services;
using KiemTra.Model;

namespace KiemTra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public NhomViewModel selectedNhom
        {
            get
            {
                return nhomViewModelBindingSource.Current as NhomViewModel;
            }
        }
        public SinhVienViewModel selectedSinhVien
        {
            get
            {
                return sinhVienViewModelBindingSource.Current as SinhVienViewModel;
            }
            ////get
            ////{
            ////    return dataGridView1.SelectedRows[0][0] as String;
            ////}
        }
        void LoadNhom()
        {
            var ls = NhomViewModel.GetList();
            dtgvNhom.DataSource = ls;

        }
        void LoadSinhVien()
        {
            var ls = SinhVienServices.GetList();
            sinhVienViewModelBindingSource.DataSource = ls;
            dtgvSinhVien.DataSource = sinhVienViewModelBindingSource;
        }


        private void btnAddLL_Click(object sender, EventArgs e)
        {
            var f = new frmSinhVien();
            var a = sinhVienViewModelBindingSource.Current as SinhVienViewModel;
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadSinhVien();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNhom();
        }

        private void btnDelLL_Click(object sender, EventArgs e)
        {
            if (selectedSinhVien != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    SinhVienServices.RemoveSinhVien(selectedSinhVien);
                    LoadSinhVien();
                }
            }
        }

        private void btnAddNhom_Click(object sender, EventArgs e)
        {
            var f = new frmNhom();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                LoadNhom();
            }
        }

        private void btnDelNhom_Click(object sender, EventArgs e)
        {
            if (selectedNhom != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    NhomServices.RemoveNhom(selectedNhom);
                    LoadNhom();
                }
            }
        }
    }

}
