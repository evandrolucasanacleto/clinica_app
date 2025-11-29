using System;
using System.Drawing;
using System.Windows.Forms;

namespace clinica_app;

public partial class FormMenuPrincipal : Form
{
    public FormMenuPrincipal()
    {
        InitializeComponent();
        this.Text = "Menu Principal";

        string imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "fundo.jpg");
        this.BackgroundImage = System.Drawing.Image.FromFile(imagePath);

        Button btnClientes = new Button
        {
            Text = "Área do Cliente",
            Width = 300,
            Height = 100,
            Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
            BackColor = Color.FromArgb(70, 130, 180),
            ForeColor = Color.White,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(200, 300)
        };

        Button btnProfissional = new Button
        {
            Text = "Área do Profissional",
            Width = 300,
            Height = 100,
            Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
            BackColor = Color.FromArgb(70, 130, 180),
            ForeColor = Color.White,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(550, 300)
        };

        Button btnAgendamento = new Button
        {
            Text = "Agendamento",
            Width = 300,
            Height = 100,
            Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
            BackColor = Color.FromArgb(70, 130, 180),
            ForeColor = Color.White,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(900, 300)
        };

        btnAgendamento.Click += (s, e) =>
        {
            FormAgendamento formAgendamento = new FormAgendamento();
            formAgendamento.ShowDialog();
        };

        this.Controls.Add(btnAgendamento);
        this.Controls.Add(btnProfissional);
        this.Controls.Add(btnClientes);

    }

}
