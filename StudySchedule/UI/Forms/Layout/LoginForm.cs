using Microsoft.Data.SqlClient;
using StudySchedule.Application.Services.Usuario;
using StudySchedule.Infrastructure.Data;
using StudySchedule.UI.Forms;
using System.Data.Common;


namespace StudySchedule
{
    public partial class LoginForm : Form
    {
        private readonly UsuarioService _usuarioService;
        public LoginForm()
        {
            InitializeComponent();

            _usuarioService = new UsuarioService(new Infrastructure.Repositories.UsuarioRepository());
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var usuario = txt_usuario.Text;
            var senha = txt_senha.Text;

            var result = _usuarioService.Login(usuario, senha);

            if (!result.Success)
            {
                MessageBox.Show(result.Message);
            }
            else
            {
                //Dashboard formDashboard = new Dashboard();
                DashboardForm formDashboard = new DashboardForm();

                formDashboard.Show();
                this.Hide();

                formDashboard.FormClosed += (s, args) => this.Close();

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txt_usuario.Text = "admin";
            txt_senha.Text = "admin";
        }

        private void lbl_sub_titulo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbl_card_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chk_mostrar_senha_CheckedChanged(object sender, EventArgs e)
        {
            txt_senha.UseSystemPasswordChar = !chk_mostrar_senha.Checked;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_sair_MouseEnter(object sender, EventArgs e)
        {
            btn_sair.BackColor = Color.Firebrick;
        }

        private void btn_sair_MouseLeave(object sender, EventArgs e)
        {
            btn_sair.BackColor = Color.IndianRed;
        }
    }
}
