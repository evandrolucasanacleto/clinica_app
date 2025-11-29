namespace clinica_app;

partial class FormLogin
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.lblTitulo = new System.Windows.Forms.Label();
        this.lblUsuario = new System.Windows.Forms.Label();
        this.txtUsuario = new System.Windows.Forms.TextBox();
        this.lblSenha = new System.Windows.Forms.Label();
        this.txtSenha = new System.Windows.Forms.TextBox();
        this.btnAcessar = new System.Windows.Forms.Button();
        this.SuspendLayout();
        
        // 
        // lblTitulo
        // 
        this.lblTitulo.AutoSize = false;
        this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(70, 130, 180);
        this.lblTitulo.Location = new System.Drawing.Point(0, 100);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width, 80);
        this.lblTitulo.TabIndex = 0;
        this.lblTitulo.Text = "Clínica Terapêutica Jardim das Descobertas";
        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        
        // 
        // lblUsuario
        // 
        this.lblUsuario.AutoSize = true;
        this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(100, 149, 237);
        this.lblUsuario.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2 - 150, 220);
        this.lblUsuario.Name = "lblUsuario";
        this.lblUsuario.Size = new System.Drawing.Size(60, 21);
        this.lblUsuario.TabIndex = 1;
        this.lblUsuario.Text = "Usuário:";
        
        // 
        // txtUsuario
        // 
        this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(245, 250, 255);
        this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.txtUsuario.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2 - 150, 245);
        this.txtUsuario.Name = "txtUsuario";
        this.txtUsuario.Size = new System.Drawing.Size(300, 29);
        this.txtUsuario.TabIndex = 2;
        
        // 
        // lblSenha
        // 
        this.lblSenha.AutoSize = true;
        this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(100, 149, 237);
        this.lblSenha.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2 - 150, 290);
        this.lblSenha.Name = "lblSenha";
        this.lblSenha.Size = new System.Drawing.Size(57, 21);
        this.lblSenha.TabIndex = 3;
        this.lblSenha.Text = "Senha:";
        
        // 
        // txtSenha
        // 
        this.txtSenha.BackColor = System.Drawing.Color.FromArgb(245, 250, 255);
        this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 12F);
        this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.txtSenha.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2 - 150, 315);
        this.txtSenha.Name = "txtSenha";
        this.txtSenha.PasswordChar = '*';
        this.txtSenha.Size = new System.Drawing.Size(300, 29);
        this.txtSenha.TabIndex = 4;
        
        // 
        // btnAcessar
        // 
        this.btnAcessar.BackColor = System.Drawing.Color.FromArgb(173, 216, 230);
        this.btnAcessar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.btnAcessar.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btnAcessar.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2 - 50, 380);
        this.btnAcessar.Name = "btnAcessar";
        this.btnAcessar.Size = new System.Drawing.Size(100, 40);
        this.btnAcessar.TabIndex = 5;
        this.btnAcessar.Text = "Acessar";
        this.btnAcessar.UseVisualStyleBackColor = false;
        this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
        
        // 
        // FormLogin
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
        this.ClientSize = new System.Drawing.Size(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
        this.Controls.Add(this.lblTitulo);
        this.Controls.Add(this.lblUsuario);
        this.Controls.Add(this.txtUsuario);
        this.Controls.Add(this.lblSenha);
        this.Controls.Add(this.txtSenha);
        this.Controls.Add(this.btnAcessar);
        this.Name = "FormLogin";
        this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        this.Location = new System.Drawing.Point(0, 0);
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Text = "Clínica Terapêutica Jardim das Descobertas";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblUsuario;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.Label lblSenha;
    private System.Windows.Forms.TextBox txtSenha;
    private System.Windows.Forms.Button btnAcessar;
}
