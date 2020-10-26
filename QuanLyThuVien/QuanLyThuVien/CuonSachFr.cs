using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using Core.DAL;

namespace QuanLyThuVien
{
    public partial class CuonSachFr : Form
    {
        #region Initialization
        private List<CUONSACH> _lstCuonSach;
       

        CUONSACH cs = new CUONSACH(); 
        public CuonSachFr()
        {
            InitializeComponent();
            
        }

      /*  private void CustomDataGridView()
        {
            datagvCuonSach.Columns[0].HeaderText = "Mã cuốn sách";
            datagvCuonSach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            datagvCuonSach.Columns[1].HeaderText = "Mã đầu sách";


            datagvCuonSach.Columns[2].HeaderText = "tình trạng";
            datagvCuonSach.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


        }*/
        private void LoadDataGridView()
        {
            _lstCuonSach= CuonSachDal.dscuonsach();
            datagvCuonSach.DataSource = _lstCuonSach;
            
        }


        #endregion
        #region Event
        #region Thêm 
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            bool canBeDone = true;
            #region Hiện thông báo lỗi
            string errMessage = "";
            if (cbTinhTrang.Text.Trim() == "")
            {
                errMessage = "tinh trang";
                canBeDone = false;
            }
            if (txtMaDauSach.Text.Trim() == "")
            {
                if (errMessage != "")
                {
                    errMessage += ", mã đầu sách";
                }
                else
                {
                    errMessage += "mã đầu sách";
                }
                canBeDone = false;
            }
            if (!canBeDone)
            {
                MessageBox.Show(errMessage + " không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);



            }

            #endregion
            if (canBeDone)
            {

                cs.madausach = Convert.ToInt32(txtMaDauSach.Text);
                cs.tinhtrang = cbTinhTrang.Text.ToString().Trim();
                cs.madausach = int.Parse(txtMaDauSach.Text);
                if (cs.Add())
                {
                    MessageBox.Show("Thêm thành công!");
                    datagvCuonSach.DataSource = CuonSachDal.dscuonsach();
                }
                else
                {
                    MessageBox.Show("Thêm cuốn sách mới không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }
        #endregion
        #region Sửa
        private void button2_Click(object sender, EventArgs e)
        {
            bool canBeDone = true;
            #region Hiện thông báo lỗi
            string errMessage = "";
            if (cbTinhTrang.Text.Trim() == "") 
            {
                errMessage = "";
                canBeDone = false;
            }
            if (txtMaDauSach.Text.Trim() == "")
            {
                if (errMessage != "")
                {
                    errMessage += ", ";
                }
                else
                {
                    errMessage += "";
                }
                canBeDone = false;
            }

            if (!canBeDone)
            {
                MessageBox.Show(errMessage + " Bạn chưa chọn dữ liệu để sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);



            }

            #endregion
            if (canBeDone)
            {
                cs.macuonsach = Convert.ToInt32(txtMaCuonSach.Text);
                cs.madausach = Convert.ToInt32(txtMaDauSach.Text);

                cs.tinhtrang = cbTinhTrang.Text.ToString().Trim();

                if (cs.Update())
                {
                    MessageBox.Show("Sửa thành công!");
                    datagvCuonSach.DataSource = CuonSachDal.dscuonsach();
                }
                /* else
                 {
                     MessageBox.Show("Sữa thông tin cuốn sách  không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                 }*/
            }
        }
            
        #endregion
        #region Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            cs.macuonsach = Convert.ToInt32(txtMaCuonSach.Text);
            DialogResult xoa = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa == DialogResult.Yes)
            {
                if (cs.Delete())
                {
                    MessageBox.Show("Xóa thành công!");
                    datagvCuonSach.DataSource = CuonSachDal.dscuonsach();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
        }
        #endregion
        #region Tìm kiếm
        private void btnTim_Click(object sender, EventArgs e)
        {
            string details = Microsoft.VisualBasic.Interaction.InputBox("Nhập thông tin cần tìm:", "Tìm kiếm");

            _lstCuonSach = CuonSachDal.TimKiemcuonsach( cs, details);


            datagvCuonSach.DataSource = _lstCuonSach;

            if (_lstCuonSach.Count == 0)
            {
                MessageBox.Show("Không tìm thấy cuốn s phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataGridView();

            Reset();
        }


        #endregion
        #region Methods   
        #region Xử lý việc chọn dòng dữ liệu DataGridView
        private void datagvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = datagvCuonSach.CurrentCell.RowIndex;
            //DataGridViewRow drtl = datagvTheLoai.SelectedRows[index];
            txtMaCuonSach.Text = datagvCuonSach.Rows[index].Cells["macuonsach"].Value.ToString().Trim();
            txtMaDauSach.Text = datagvCuonSach.Rows[index].Cells["madausach"].Value.ToString().Trim();
            cbTinhTrang.Text = datagvCuonSach.Rows[index].Cells["tinhtrang"].Value.ToString().Trim();
        }
        private void Showcuonsach(CUONSACH cuonsach)
        {
            if (cuonsach != null)
            {
                txtMaCuonSach.Text = cuonsach.macuonsach.ToString();
                txtMaDauSach.Text = cuonsach.madausach.ToString();
                cbTinhTrang.Text = cuonsach.tinhtrang.ToString();

            }
        }
        #region Chỉ được nhập số
        private void txtMaDausach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        #endregion

        #endregion
        #region Editable + Reset
        private void Editable(bool canBeEdited)
        {
            if (canBeEdited)
            {
                txtMaCuonSach.Enabled = false;

                txtMaDauSach.Enabled = true;
                cbTinhTrang.Enabled = true;


                
            }
            else
            {
                txtMaCuonSach.Enabled = false;

                txtMaDauSach.Enabled = true;
                cbTinhTrang.Enabled = true;

                
              

            }
        }
        private void Reset()
        {
            txtMaCuonSach.ResetText();
            txtMaDauSach.ResetText();
            cbTinhTrang.ResetText();

        }
        #endregion
        #endregion
        #region Menu
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DangNhapFr dn = new DangNhapFr();
            DialogResult thoat = MessageBox.Show("Bạn có muốn thoát?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
                dn.Show();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có muốn thoát?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (thoat == DialogResult.Yes)
                Application.Exit();
        }

        private void quảnLýĐầuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DauSachFr ds = new DauSachFr();
            ds.Show();
            this.Hide();
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TacGiaFr tg = new TacGiaFr();
            tg.Show();
            this.Hide();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocGiaFr dg = new DocGiaFr();
            dg.Show();
            this.Hide();
        }

        private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheLoaiFr tl = new TheLoaiFr();
            tl.Show();
            this.Hide();
        }

        private void quảnLýCuốnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuonSachFr cs = new CuonSachFr();
            cs.Show();
            this.Hide();
        }

        private void quảnLýNXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NXBFr nxb = new NXBFr();
            nxb.Show();
            this.Hide();
        }

        private void quảnLýPhiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuTraFr pt = new PhieuTraFr();
            pt.Show();
            this.Hide();
        }

        

        private void thốngKêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKSachFr tks = new TKSachFr();
            tks.Show();
            this.Hide();
        }

        private void thốngKêMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKPhieuMuonFr tks = new TKPhieuMuonFr();
            tks.Show();
            this.Hide();
        }
        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKTacGiaFr tktg = new TKTacGiaFr();
            tktg.Show();
            this.Hide();
        }

        private void tìnhTrạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhTrangFr tt = new TinhTrangFr();
            tt.Show();
            this.Hide();
        }

        private void quảnLýThủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThuThuFr tt = new ThuThuFr();
            tt.Show();
            this.Hide();
        }

        private void CuonSachFr_Load(object sender, EventArgs e)
        {
            
            datagvCuonSach.DataSource = CuonSachDal.dscuonsach();
            txtMaCuonSach.Enabled = false;
        }

        #endregion

     
    }
}
