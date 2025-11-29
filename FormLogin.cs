using System;
using System.Windows.Forms;

namespace clinica_app;

public partial class FormLogin : Form
{
    public FormLogin()
    {
        InitializeComponent();
        string imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "fundo.jpg");
        this.BackgroundImage = System.Drawing.Image.FromFile(imagePath);
    }

    private void btnAcessar_Click(object sender, EventArgs e)
    {
        string usuario = this.txtUsuario.Text;
        string senha = this.txtSenha.Text;

        if (usuario == "admin" && senha == "admin")
        {
            // Credenciais corretas - abrir formulário de Menu Principal
            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
            formMenuPrincipal.StartPosition = FormStartPosition.CenterScreen;
            formMenuPrincipal.FormClosed += (s, args) => this.Close();
            formMenuPrincipal.Show();
            this.Hide();
        }
        else
        {
            // Credenciais incorretas - exibir mensagem de erro
            MessageBox.Show("Usuário ou senha incorretos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.txtSenha.Clear();
            this.txtUsuario.Focus();
        }
    }
}
