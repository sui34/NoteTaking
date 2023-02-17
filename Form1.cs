using System.Data;

namespace NoteTaking
{
    public partial class TakingNote : Form
    {

        DataTable table;

        public TakingNote()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title",typeof(string));
            table.Columns.Add("Message",typeof(string));

            dataGridView.DataSource = table; // DGV to be able to connect with table

            dataGridView.Columns["Message"].Visible = false;
            dataGridView.Columns["Title"].Width = 293;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text,txtMessage.Text);

            txtTitle.Clear();
            txtMessage.Clear();
        }

        // for read : need to know which row is selected
        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;

            if (index> -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}