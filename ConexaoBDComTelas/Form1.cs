namespace ConexaoBDComTelas
{
    public partial class Form1 : Form
    {
        Tarefa tarefa = new Tarefa();
        public Form1()
        {
            InitializeComponent();
        }

        private void atualizaInterface()
        {
            txtTarefa.Focus();
            txtTarefa.Clear();
            listTarefas.Clear();
            List<Tarefa> tarefas = tarefa.buscaTodos();
            foreach (Tarefa t in tarefas)
            {
                listTarefas.Items.Add($"{t.id} - {t.descricao}");
            }
        }


        // Fim Funções (aqui acabam as funções)

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaInterface();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao = txtTarefa.Text;
            bool concluido = cboxConcluido.Checked;
            tarefa.descricao = descricao;
            tarefa.concluido = concluido;
            tarefa.Insere(tarefa);
            atualizaInterface();
            MessageBox.Show("A tarefa foi cadastrada!");

            txtTarefa.Clear();
            cboxConcluido.Checked = false;
            txtTarefa.Focus();
        }
    }
}