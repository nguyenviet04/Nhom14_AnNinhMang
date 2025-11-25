using System;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace ANNINHMANG
{
    public partial class Form1 : Form
    {
        RSACore rsa = new RSACore();

        public Form1()
        {
            InitializeComponent();

            this.btnTaoPQ.Click += new EventHandler(this.btnTaoPQ_Click);
            this.btnTaoKhoa.Click += new EventHandler(this.btnTaoKhoa_Click);
            this.btnReset.Click += new EventHandler(this.btnReset_Click);

            this.btnFileKy.Click += new EventHandler(this.btnFileKy_Click);
            this.btnFileWordKy.Click += new EventHandler(this.btnFileWordKy_Click);
            this.btnKy.Click += new EventHandler(this.btnKy_Click);
            this.btnChuyen.Click += new EventHandler(this.btnChuyen_Click);
            this.btnLuuTxt.Click += new EventHandler(this.btnLuuTxt_Click);

            this.btnFileKiemTra.Click += new EventHandler(this.btnFileKiemTra_Click);
            this.btnFileWordKiemTra.Click += new EventHandler(this.btnFileWordKiemTra_Click);
            this.btnFileChuKy.Click += new EventHandler(this.btnFileChuKy_Click);
            this.btnKiemTra.Click += new EventHandler(this.btnKiemTra_Click);
         
            txtB.Text = "65537";
        }

        private async void btnTaoPQ_Click(object sender, EventArgs e)
        {
            btnTaoPQ.Enabled = false;
            txtThongBao.Text = "Đang sinh số nguyên tố...";
            txtLog.Text += "Bắt đầu sinh P, Q...\r\n";

            await Task.Run(() =>
            {
                // Sinh khóa 1024 bit (P, Q ~ 512 bit)
                rsa.GeneratePrimes(1024);
            });

            txtP.Text = rsa.P.ToString();
            txtQ.Text = rsa.Q.ToString();
            txtThongBao.Text = "Đã sinh xong P và Q!";
            txtLog.Text += "Đã sinh xong P và Q.\r\n";
            btnTaoPQ.Enabled = true;
        }

        private void btnTaoKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtP.Text) || string.IsNullOrEmpty(txtQ.Text))
                {
                    MessageBox.Show("Vui lòng tạo P và Q trước!");
                    return;
                }

                // txtB trong Designer đóng vai trò là Public Key (E)
                BigInteger eVal = BigInteger.Parse(txtB.Text);

                // Tính toán N và D
                rsa.CalculateKeys(eVal);

                // txtA trong Designer đóng vai trò là Private Key (D)
                txtA.Text = rsa.D.ToString();

                txtThongBao.Text = "Tạo khóa thành công!";
                txtThongBao.ForeColor = System.Drawing.Color.Blue;
                txtLog.Text += $"Tạo khóa thành công. N length: {rsa.N.ToString().Length} digits\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtP.Clear(); txtQ.Clear(); txtA.Clear();
            txtVanBanKy.Clear(); txtChuKy.Clear();
            txtVanBanKiemTra.Clear(); txtChuKyKiemTra.Clear();
            txtLog.Clear();
            txtThongBao.Text = "";
            txtB.Text = "65537";
            txtThongBao.ForeColor = System.Drawing.Color.Black;
            txtThongBao.BackColor = SystemColors.Control;
        }

        // --- 2. NHÓM KÝ (SENDER) ---
        private void btnFileKy_Click(object sender, EventArgs e)
        {
            OpenTextFileToBox(txtVanBanKy);
        }

        private void btnFileWordKy_Click(object sender, EventArgs e)
        {
            OpenWordFileToBox(txtVanBanKy);
        }

        private void btnKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(txtVanBanKy.Text))
            {
                MessageBox.Show("Chưa có văn bản để ký!");
                return;
            }
            if (string.IsNullOrEmpty(txtA.Text))
            {
                MessageBox.Show("Chưa có khóa bí mật (A)! Hãy bấm 'Tạo khóa' trước.");
                return;
            }

            try
            {
                // B1: Băm văn bản (SHA256 -> BigInteger)
                BigInteger hashVal = FileHandler.HashString(txtVanBanKy.Text);

                // B2: Ký (Mã hóa Hash bằng Private Key A)
                BigInteger signature = rsa.SignData(hashVal);

                // B3: Hiển thị
                txtChuKy.Text = signature.ToString();
                txtThongBao.Text = "Đã tạo chữ ký thành công!";
                txtThongBao.ForeColor = System.Drawing.Color.Green;
                txtLog.Text += "Ký thành công.\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ký: " + ex.Message);
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            // Copy dữ liệu từ bên trái (Sender) sang bên phải (Receiver) để test
            txtChuKyKiemTra.Text = txtChuKy.Text;
            txtVanBanKiemTra.Text = txtVanBanKy.Text;
            txtLog.Text += "Đã chuyển dữ liệu sang panel kiểm tra.\r\n";
        }

        private void btnLuuTxt_Click(object sender, EventArgs e)
        {
            SaveTextFile(txtChuKy.Text);
        }

        // --- 3. NHÓM KIỂM TRA (RECEIVER) ---
        private void btnFileKiemTra_Click(object sender, EventArgs e)
        {
            OpenTextFileToBox(txtVanBanKiemTra);
        }

        private void btnFileWordKiemTra_Click(object sender, EventArgs e)
        {
            OpenWordFileToBox(txtVanBanKiemTra);
        }

        private void btnFileChuKy_Click(object sender, EventArgs e)
        {
            OpenTextFileToBox(txtChuKyKiemTra);
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtVanBanKiemTra.Text) || string.IsNullOrEmpty(txtChuKyKiemTra.Text))
                {
                    MessageBox.Show("Thiếu văn bản hoặc chữ ký để kiểm tra!");
                    return;
                }

                // Nếu người dùng chưa tạo khóa trong phiên này, cần tính lại N từ giao diện
                // (Vì txtN không có trong Designer của bạn, ta phải tính từ P và Q)
                if (rsa.N == 0)
                {
                    if (!string.IsNullOrEmpty(txtP.Text) && !string.IsNullOrEmpty(txtQ.Text))
                    {
                        BigInteger p = BigInteger.Parse(txtP.Text);
                        BigInteger q = BigInteger.Parse(txtQ.Text);
                        BigInteger eVal = BigInteger.Parse(txtB.Text);
                        rsa.CalculateKeys(eVal); // Tính lại N
                    }
                    else
                    {
                        MessageBox.Show("Hệ thống cần P và Q để tính Modulo N cho việc kiểm tra. Vui lòng nhập P, Q bên trái và bấm 'Tạo khóa'.");
                        return;
                    }
                }

                // 1. Lấy chữ ký từ giao diện
                BigInteger signature = BigInteger.Parse(txtChuKyKiemTra.Text);

                // 2. Giải mã chữ ký bằng Public Key (E/txtB) để lấy Hash gốc
                BigInteger decryptedHash = rsa.VerifySignature(signature);

                // 3. Tính Hash của văn bản hiện tại đang kiểm tra
                BigInteger currentHash = FileHandler.HashString(txtVanBanKiemTra.Text);

                // 4. So sánh
                if (decryptedHash == currentHash)
                {
                    txtLog.Text = "Chữ ký chính xác! Dữ liệu toàn vẹn.";
                    txtLog.BackColor = System.Drawing.Color.LightGreen; // Đổi màu nền bảng thành xanh
                    txtLog.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    txtLog.Text = "SAI! Dữ liệu đã bị sửa đổi hoặc chữ ký giả.";
                    txtLog.BackColor = System.Drawing.Color.LightPink; // Đổi màu nền bảng thành đỏ nhạt
                    txtLog.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                txtThongBao.Text = "Lỗi xác thực!";
                MessageBox.Show("Chi tiết: " + ex.Message);
            }
        }

        // --- HÀM HỖ TRỢ (HELPER METHODS) ---
        private void OpenTextFileToBox(TextBox box)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Text Files|*.txt|All Files|*.*" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                box.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void OpenWordFileToBox(TextBox box)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Word Documents|*.docx" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Yêu cầu class FileHandler phải có hàm ReadDocxText
                    box.Text = FileHandler.ReadDocxText(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đọc file Word: " + ex.Message + "\n(Hãy đảm bảo file không đang mở trong Word)");
                }
            }
        }

        private void SaveTextFile(string content)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Text Files|*.txt" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, content);
                MessageBox.Show("Đã lưu file thành công!");
            }
        }
    }
}