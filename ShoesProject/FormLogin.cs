using ShoesProject.models;

namespace ShoesProject
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public User CurrentUser { get; private set; }
        public bool IsQuest { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtlogin.Text) ||
                String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new ShopDbContext())
            {
                var user = db.Users
                    .Where(w => w.Login == txtlogin.Text && w.Pass == txtPassword.Text)
                    .FirstOrDefault();

                if (user != null)
                {
                    CurrentUser = user;
                    IsQuest = false;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnQuest_Click(object sender, EventArgs e)
        {
            CurrentUser = null;
            IsQuest = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
