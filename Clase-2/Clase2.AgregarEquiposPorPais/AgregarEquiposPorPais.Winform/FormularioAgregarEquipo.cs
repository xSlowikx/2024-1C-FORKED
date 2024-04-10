using AgregarEquiposPorPais.Entidades;
using AgregarEquiposPorPais.Logica;

namespace AgregarEquiposPorPais.Winform
{
    public partial class FormularioAgregarEquipo : Form
    {
        public FormularioAgregarEquipo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            EquipoServicio equipoServicio = new EquipoServicio();

            Equipo teamToAdd = new Equipo(txtTeamName.Text, txtCountryName.Text);

            equipoServicio.agregarEquipo(teamToAdd);

            addRowToDataView(teamToAdd);
        }

        private void addRowToDataView(Equipo teamReceived)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridViewToFill);

            row.Cells[0].Value = teamReceived.Id;
            row.Cells[1].Value = teamReceived.Nombre;
            row.Cells[2].Value = teamReceived.Pais;

            dataGridViewToFill.Rows.Add(row);

        }
    }
}
