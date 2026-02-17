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
                Dashboard formDashboard = new Dashboard();
                formDashboard.Show();
                //this.Hide();

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txt_usuario.Text = "admin";
            txt_senha.Text = "admin";
        }
    }
}
