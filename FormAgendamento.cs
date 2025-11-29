using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace clinica_app;

public partial class FormAgendamento : Form
{
    public FormAgendamento()
    {
        InitializeComponent();
        carregarDados();
        this.WindowState = FormWindowState.Maximized;
        string imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "fundo.jpg");
        this.BackgroundImage = System.Drawing.Image.FromFile(imagePath);
    }

    private void carregarDados()
    {
        using (var conexao = Conexao.ObterConexao())
        {
            conexao.Open();
            string query = "SELECT id, nome_paciente, tipo_sessao, nome_profissional, data_agendamento, status FROM agendamentos order by data_agendamento DESC";
            using (var cmd = new MySqlCommand(query, conexao))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                var dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Paciente";
                dataGridView1.Columns[2].HeaderText = "Tipo de Sessão";
                dataGridView1.Columns[3].HeaderText = "Profissional";
                dataGridView1.Columns[4].HeaderText = "Data do Agendamento";
                dataGridView1.Columns[5].HeaderText = "Status";
                dataGridView1.Columns["data_agendamento"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            }


        }

    }
    
    private void btnAgendar_Click(object sender, EventArgs e)
    {
        // Validar campos preenchidos
        if (string.IsNullOrWhiteSpace(this.txtPaciente.Text))
        {
            MessageBox.Show("Por favor, digite o nome do paciente.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (this.cmbTerapeuta.SelectedIndex < 0)
        {
            MessageBox.Show("Por favor, selecione um terapeuta.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (this.cmbTipo.SelectedIndex < 0)
        {
            MessageBox.Show("Por favor, selecione o tipo de sessão.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Validar data
        DateTime dataSelecionada = this.dtpData.Value.Date;
        DateTime dataHoje = DateTime.Now.Date;


        if (dataSelecionada < dataHoje)
        {
            MessageBox.Show("Não é possível agendar em datas passadas. Por favor, selecione uma data futura.", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Se passou em todas as validações
        string nome_paciente = this.txtPaciente.Text.Trim();
        DateTime data_agendamento = this.dtpData.Value;
        string tipo_sessao = this.cmbTipo.Text.Trim();
        string nome_profissional = this.cmbTerapeuta.Text.Trim();
        string status = this.cmbStatus.Text.Trim();
        
        using (var conexao = Conexao.ObterConexao())
        {
            conexao.Open();
            string query = "INSERT INTO agendamentos (nome_paciente, data_agendamento, tipo_sessao, nome_profissional, status) values(@nome_paciente, @data_agendamento, @tipo_sessao, @nome_profissional, @status)";
            using (var cmd = new MySqlCommand(query, conexao))
            {
                cmd.Parameters.AddWithValue("@nome_paciente", nome_paciente);
                cmd.Parameters.AddWithValue("@data_agendamento", data_agendamento);
                cmd.Parameters.AddWithValue("@tipo_sessao", tipo_sessao);
                cmd.Parameters.AddWithValue("@nome_profissional", nome_profissional);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();

            }


        }
        carregarDados();        
        MessageBox.Show($"Agendamento realizado com sucesso!\n\nPaciente: {this.txtPaciente.Text}\nData: {data_agendamento:dd-MM-yyyy HH:mm}\nTerapeuta: {this.cmbTerapeuta.SelectedItem}\nTipo: {this.cmbTipo.SelectedItem}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        // Limpar campos
        this.txtPaciente.Clear();
        this.cmbTerapeuta.SelectedIndex = -1;
        this.cmbTipo.SelectedIndex = -1;
        this.dtpData.Value = DateTime.Now.AddDays(1);
    }

    private void btnVoltar_Click(object sender, EventArgs e)
    {
        this.Close();
    }



    // Atualizar dados

    private bool Atualizar()
    {
        try
        {
            string nome_paciente = this.txtPaciente.Text.Trim();
            // DateTime data_agendamento = this.dtpData.Value;
            string tipo_sessao = this.cmbTipo.Text.Trim();
            string nome_profissional = this.cmbTerapeuta.Text.Trim();
            string status = this.cmbStatus.Text.Trim();
            int id = 0;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = this.dataGridView1.SelectedRows[0];
                id = Convert.ToInt32(linhaSelecionada.Cells["id"].Value);
            }

            using (var conexao = Conexao.ObterConexao())
            {
                conexao.Open();
                string atualizar = $"UPDATE agendamentos set nome_paciente = '{nome_paciente}', tipo_sessao = '{tipo_sessao}', nome_profissional = '{nome_profissional}', status = '{status}' where id = '{id}'";
                Console.WriteLine(atualizar);
                using (var cmd = new MySqlCommand(atualizar, conexao))
                {
                    cmd.ExecuteNonQuery();
                    return true;

                }
            }
    }
        catch(Exception ex) 
        {
            MessageBox.Show("Erro ao Atualizar dado - Metodo FormAgendamento: " + ex.Message);
            return false;
        }
    }

    private void btnAtualizar_Click(object sender, EventArgs e)
    {
        this.Atualizar();
        this.carregarDados();
        this.txtPaciente.Clear();
        this.cmbTerapeuta.SelectedIndex = -1;
        this.cmbTipo.SelectedIndex = -1;
        this.dtpData.Value = DateTime.Now.AddDays(1);
    }

    private bool Deletar()
    {
        try
        {
            int id = 0;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = this.dataGridView1.SelectedRows[0];
                id = Convert.ToInt32(linhaSelecionada.Cells["id"].Value);
            }
            using (var conexao = Conexao.ObterConexao())
            {
                conexao.Open();
                string deletar = $"delete from agendamentos where id = '{id}';";
                Console.WriteLine(deletar);
                using (var cmd = new MySqlCommand(deletar, conexao))
                {
                    cmd.ExecuteNonQuery();
                    return true;

                }
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao excluir consulta, verifique se os dados estão preechidos" + ex.Message);
            return false;
        }
    }
    private void btnDeletar_Click(object sender, EventArgs e)
    {
        this.Deletar();
        this.carregarDados();
        this.txtPaciente.Clear();
        this.cmbTerapeuta.SelectedIndex = -1;
        this.cmbTipo.SelectedIndex = -1;
        this.dtpData.Value = DateTime.Now.AddDays(1);
    }

}
