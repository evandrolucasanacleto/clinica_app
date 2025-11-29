namespace clinica_app;

partial class FormAgendamento
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

    //  Required method for Designer support - do not modify
    //  the contents of this method with the code editor.
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.lblTitulo = new System.Windows.Forms.Label();
        this.lblPaciente = new System.Windows.Forms.Label();
        this.txtPaciente = new System.Windows.Forms.TextBox();
        this.lblData = new System.Windows.Forms.Label();
        this.dtpData = new System.Windows.Forms.DateTimePicker();
        this.lblTerapeuta = new System.Windows.Forms.Label();
        this.cmbTerapeuta = new System.Windows.Forms.ComboBox();
        this.lblTipo = new System.Windows.Forms.Label();
        this.cmbTipo = new System.Windows.Forms.ComboBox();
        this.lblStatus = new System.Windows.Forms.Label();
        this.cmbStatus = new System.Windows.Forms.ComboBox();
        this.btnAgendar = new System.Windows.Forms.Button();
        this.btnVoltar = new System.Windows.Forms.Button();
        this.btnAtualizar = new System.Windows.Forms.Button();
        this.btnDeletar = new System.Windows.Forms.Button();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.SuspendLayout();
        
        // 
        // lblTitulo
        // 
        this.lblTitulo.AutoSize = false;
        this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(70, 130, 180);
        this.lblTitulo.Location = new System.Drawing.Point(50, 20);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(700, 40);
        this.lblTitulo.TabIndex = 0;
        this.lblTitulo.Text = "Agendamento de Sessões";
        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        
        // 
        // lblPaciente
        // 
        this.lblPaciente.AutoSize = true;
        this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(100, 149, 237);
        this.lblPaciente.Location = new System.Drawing.Point(50, 80);
        this.lblPaciente.Name = "lblPaciente";
        this.lblPaciente.Size = new System.Drawing.Size(60, 19);
        this.lblPaciente.TabIndex = 1;
        this.lblPaciente.Text = "Paciente:";
        
        // 
        // txtPaciente
        // 
        this.txtPaciente.BackColor = System.Drawing.Color.FromArgb(245, 250, 255);
        this.txtPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtPaciente.Location = new System.Drawing.Point(50, 105);
        this.txtPaciente.Name = "txtPaciente";
        this.txtPaciente.Size = new System.Drawing.Size(300, 25);
        this.txtPaciente.TabIndex = 2;
        
        // 
        // lblData
        // 
        this.lblData.AutoSize = true;
        this.lblData.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblData.ForeColor = System.Drawing.Color.FromArgb(100, 149, 237);
        this.lblData.Location = new System.Drawing.Point(400, 80);
        this.lblData.Name = "lblData";
        this.lblData.Size = new System.Drawing.Size(38, 19);
        this.lblData.TabIndex = 3;
        this.lblData.Text = "Data:";
        
        // 
        // dtpData
        // 
        this.dtpData.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtpData.CustomFormat = "dd-MM-yyyy HH:mm";
        this.dtpData.Location = new System.Drawing.Point(400, 105);
        this.dtpData.Name = "dtpData";
        this.dtpData.Size = new System.Drawing.Size(150, 25);
        this.dtpData.TabIndex = 4;
        this.dtpData.MinDate = System.DateTime.Now.Date;
        this.dtpData.Value = System.DateTime.Now.AddDays(1);
        
        // 
        // lblTerapeuta
        // 
        this.lblTerapeuta.AutoSize = true;
        this.lblTerapeuta.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblTerapeuta.ForeColor = System.Drawing.Color.FromArgb(100, 149, 237);
        this.lblTerapeuta.Location = new System.Drawing.Point(50, 150);
        this.lblTerapeuta.Name = "lblTerapeuta";
        this.lblTerapeuta.Size = new System.Drawing.Size(70, 19);
        this.lblTerapeuta.TabIndex = 5;
        this.lblTerapeuta.Text = "Terapeuta:";
        
        // 
        // cmbTerapeuta
        // 
        this.cmbTerapeuta.BackColor = System.Drawing.Color.FromArgb(245, 250, 255);
        this.cmbTerapeuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbTerapeuta.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.cmbTerapeuta.Items.AddRange(new object[] { "Dra. Ana Silva", "Dra. Maria Santos", "Dr. Carlos Costa" });
        this.cmbTerapeuta.Location = new System.Drawing.Point(50, 175);
        this.cmbTerapeuta.Name = "cmbTerapeuta";
        this.cmbTerapeuta.Size = new System.Drawing.Size(300, 27);
        this.cmbTerapeuta.TabIndex = 6;
        
        // 
        // lblTipo
        // 
        this.lblTipo.AutoSize = true;
        this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(100, 149, 237);
        this.lblTipo.Location = new System.Drawing.Point(400, 150);
        this.lblTipo.Name = "lblTipo";
        this.lblTipo.Size = new System.Drawing.Size(99, 19);
        this.lblTipo.TabIndex = 7;
        this.lblTipo.Text = "Tipo de Sessão:";
        
        // 
        // cmbTipo
        // 
        this.cmbTipo.BackColor = System.Drawing.Color.FromArgb(245, 250, 255);
        this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.cmbTipo.Items.AddRange(new object[] { "Psicoterapia", "Fonoaudiologia", "Fisioterapia" });
        this.cmbTipo.Location = new System.Drawing.Point(400, 175);
        this.cmbTipo.Name = "cmbTipo";
        this.cmbTipo.Size = new System.Drawing.Size(150, 27);
        this.cmbTipo.TabIndex = 8;

        // 
        // lblStatus
        // 
        this.lblStatus.AutoSize = true;
        this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(100, 149, 237);
        this.lblStatus.Location = new System.Drawing.Point(50, 220);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(99, 19);
        this.lblStatus.TabIndex = 7;
        this.lblStatus.Text = "Status da sessão:";


        // 
        // cmbStatus
        // 
        this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(245, 250, 255);
        this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.cmbStatus.Items.AddRange(new object[] { "Agendada", "Realizada", "Cancelada" });
        this.cmbStatus.Location = new System.Drawing.Point(50, 245);
        this.cmbStatus.Name = "cmbStatus";
        this.cmbStatus.Size = new System.Drawing.Size(150, 27);
        this.cmbStatus.TabIndex = 8;
        
        // 
        // btnAgendar
        // 
        this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(173, 216, 230);
        this.btnAgendar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnAgendar.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btnAgendar.Location = new System.Drawing.Point(200, 300);
        this.btnAgendar.Name = "btnAgendar";
        this.btnAgendar.Size = new System.Drawing.Size(100, 35);
        this.btnAgendar.TabIndex = 9;
        this.btnAgendar.Text = "Agendar";
        this.btnAgendar.UseVisualStyleBackColor = false;
        this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
        
        // 
        // btnVoltar
        // 
        this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(230, 230, 250);
        this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btnVoltar.Location = new System.Drawing.Point(320, 300);
        this.btnVoltar.Name = "btnVoltar";
        this.btnVoltar.Size = new System.Drawing.Size(100, 35);
        this.btnVoltar.TabIndex = 10;
        this.btnVoltar.Text = "Voltar";
        this.btnVoltar.UseVisualStyleBackColor = false;
        this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

        // btnAtualizar
        this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(230, 230, 250);
        this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnAtualizar.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btnAtualizar.Location = new System.Drawing.Point(440, 300);
        this.btnAtualizar.Name = "btnAtualizar";
        this.btnAtualizar.Size = new System.Drawing.Size(100, 35);
        this.btnAtualizar.TabIndex = 11;
        this.btnAtualizar.Text = "Atualizar";
        this.btnAtualizar.UseVisualStyleBackColor = false;
        this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);

        // btnDeletar
        this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(230, 230, 250);
        this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnDeletar.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btnDeletar.Location = new System.Drawing.Point(560, 300);
        this.btnDeletar.Name = "btnDeletar";
        this.btnDeletar.Size = new System.Drawing.Size(100, 35);
        this.btnDeletar.TabIndex = 12;
        this.btnDeletar.Text = "Excluir";
        this.btnDeletar.UseVisualStyleBackColor = false;
        this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);

        // 
        // dataGridView1
        // 
        this.dataGridView1.Location = new System.Drawing.Point(50, 400);
        this.dataGridView1.BackColor = System.Drawing.Color.FromArgb(245, 250, 255);
        this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.Size = new System.Drawing.Size(700, 350);
        this.dataGridView1.Visible = true;
        this.dataGridView1.ReadOnly = true;
        this.dataGridView1.AllowUserToAddRows = false;
        this.dataGridView1.AllowUserToDeleteRows = false;
        this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        
        
        // 
        // FormAgendamento
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
        this.ClientSize = new System.Drawing.Size(800, 350);
        this.Controls.Add(this.lblTitulo);
        this.Controls.Add(this.lblPaciente);
        this.Controls.Add(this.txtPaciente);
        this.Controls.Add(this.lblData);
        this.Controls.Add(this.dtpData);
        this.Controls.Add(this.lblTerapeuta);
        this.Controls.Add(this.cmbTerapeuta);
        this.Controls.Add(this.lblTipo);
        this.Controls.Add(this.cmbTipo);
        this.Controls.Add(this.lblStatus);
        this.Controls.Add(this.cmbStatus);
        this.Controls.Add(this.btnAgendar);
        this.Controls.Add(this.btnVoltar);
        this.Controls.Add(this.btnAtualizar);
        this.Controls.Add(this.btnDeletar);
        this.Controls.Add(this.dataGridView1);
        this.Name = "FormAgendamento";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Agendamento - Clínica Terapêutica";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblPaciente;
    private System.Windows.Forms.TextBox txtPaciente;
    private System.Windows.Forms.Label lblData;
    private System.Windows.Forms.DateTimePicker dtpData;
    private System.Windows.Forms.Label lblTerapeuta;
    private System.Windows.Forms.ComboBox cmbTerapeuta;
    private System.Windows.Forms.Label lblTipo;
    private System.Windows.Forms.ComboBox cmbTipo;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.ComboBox cmbStatus;
    private System.Windows.Forms.Button btnAgendar;
    private System.Windows.Forms.Button btnVoltar;
    private System.Windows.Forms.Button btnAtualizar;
    private System.Windows.Forms.Button btnDeletar;
    private System.Windows.Forms.DataGridView dataGridView1;
}
