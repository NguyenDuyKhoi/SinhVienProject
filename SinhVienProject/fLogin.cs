using SinhVienProject.DAO;

namespace SinhVienProject
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }


        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ko?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string passWord = textBox2.Text;
            if (Login(userName, passWord))
            {

                DanhSach f = new DanhSach();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
    }
}