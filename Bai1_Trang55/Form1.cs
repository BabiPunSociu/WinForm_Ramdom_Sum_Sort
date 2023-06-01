using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_Trang55
{
    public partial class frmMain : Form
    {
        DaySo ds = new DaySo();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            lblTong.Text = ds.tinhTong();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            lblDaySo.Text = "";
            if (txtN.Text == "")
            {
                MessageBox.Show("Cần điền dữ liệu");
                txtN.Focus();
                return;
            }
            else
            {
                try
                {
                    ds.n = int.Parse(txtN.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // Tạo dãy số
                ds.taoDaySo();


                // in ra man hinh
                lblDaySo.Text = ds.inDaySo("Dãy số:");

                btnTinhTong.Enabled = true;
                btnSapXep.Enabled = true;
                btnLamLai.Enabled = true;
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            QuickSort.quickSort(ds.daySo, 0, ds.daySo.Count - 1);
            QuickSort.quickSort(ds.daySo, 0, ds.daySo.Count - 1);
            // in ra man hinh
            lblDayGiamDan.Text = ds.sapXepGiam();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            lblTong.Text = "";
            lblDaySo.Text = "";
            lblDayGiamDan.Text = "";
            ds.daySo.Clear();
            txtN.Text = String.Empty;

            btnNhap.Enabled = false;
            btnTinhTong.Enabled = false;
            btnSapXep.Enabled = false;

            txtN.Focus();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // user clicked yes
                this.Close();
            }
        }

        private void txtN_Enter(object sender, EventArgs e)
        {
            txtN.BackColor = Color.Wheat;
            if (txtN.Text != "")
                btnNhap.Enabled = true;
        }

        private void txtN_Leave(object sender, EventArgs e)
        {
            txtN.BackColor = Color.White;
        }

        private void btnNhap_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;  // Dùng được cho các button có tên khác nhau
            btn.BackColor = Color.NavajoWhite;
            btn.ForeColor = Color.Red;
        }

        private void btnNhap_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)  // Chỉ cho nhập số
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
                btnNhap.Enabled = true;

            if (e.KeyChar == 13)     // Nhấn ENTER     // btnNhap_Click
            {
                btnNhap_Click(sender, e);
            }
        }
    }
}
