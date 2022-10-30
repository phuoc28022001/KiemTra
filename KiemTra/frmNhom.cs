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

namespace KiemTra
{
    public partial class frmNhom : Form
    {
        NhomViewModel nhomViewModel;
        public frmLopHocPhan(NhomViewModel nhomViewModel = null)
        {
            InitializeComponent();
            this.nhomViewModel = nhomViewModel;
            if (this.nhomViewModel != null)
            {
                txtTenNhom.Text = this.nhomViewModel.TenNhom;
                txtTenNhom.Text = this.nhomViewModel.IDNhom.ToString();
            }
            LoadNhom();
        }
     
        void LoadNhom()
        {
            var db = new AppDBContext();
            var ls = db.Nhom.ToList();
            
        }
        public Nhom selectedMonHoc
        {
            get { return cbbIdNhom.SelectedItem as Nhom; }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            var db = new AppDBContext();
            if (nhomViewModel == null)
            {
                Nhom p = new Nhom
                {
                    TenNhom = txtTenNhom.Text,
                    IDNhom = selectedMonHoc.IDNhom,
                };
                db.Nhom.Add(p);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        
        }
    }
}
