namespace NotasApp
{
    public partial class RabiscaForm : Form
    {

        readonly List<Nota> notas = [];
        Nota? notaEmEdicao = null;

        public RabiscaForm()
        {
            InitializeComponent();
        }

        private void btnSalvarNota_Click(object sender, EventArgs e)
        {
            string conteudoDaNota = tbxNota.Text;

            if (string.IsNullOrWhiteSpace(conteudoDaNota))
            {
                MessageBox.Show("Por favor, digite o conteúdo da nota.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (notaEmEdicao != null)
            {
                EditarNota(conteudoDaNota);
                return;
            }

            AdicionarNota(conteudoDaNota);
        }

        private void AdicionarNota(string conteudo)
        {
            Nota novaNota = new()
            {
                Id = notas.Count + 1,
                Conteudo = conteudo
            };

            notas.Add(novaNota);
            lbxNotas.Items.Add(novaNota);
            tbxNota.Clear();
        }

        private void lbxNotas_DoubleClick(object sender, EventArgs e)
        {
            Nota? notaSelecionada = lbxNotas.SelectedItem as Nota;

            if (notaSelecionada == null)
            {
                MessageBox.Show("Por favor, selecione uma nota para exibir.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            notaEmEdicao = notaSelecionada;
            tbxNota.Text = notaSelecionada.Conteudo;
        }

        private void EditarNota(string conteudoDaNota)
        {
            Nota? notaSelecionada = notas.FirstOrDefault(n => n.Id == notaEmEdicao.Id);

            if (notaSelecionada == null)
            {
                MessageBox.Show("Não foi possível encontrar a nota selecionada.",
                                 "Erro",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            notaSelecionada.Conteudo = conteudoDaNota;
            tbxNota.Clear();
            lbxNotas.Items.Clear();
            lbxNotas.Items.AddRange([.. notas]);
        }

        private void btnExcluirNota_Click(object sender, EventArgs e)
        {
            Nota? notaSelecionada = lbxNotas.SelectedItem as Nota;

            if (notaSelecionada == null)
            {
                MessageBox.Show("Por favor, selecione uma nota para excluir.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            notas.Remove(notaSelecionada);
            lbxNotas.Items.Remove(notaSelecionada);
            tbxNota.Clear();
            btnExcluirNota.Enabled = false;
        }

        private void lbxNotas_Click(object sender, EventArgs e)
        {
            btnExcluirNota.Enabled = lbxNotas.SelectedItem != null;
        }
    }
}
