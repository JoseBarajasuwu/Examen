using System;
using System.Data;
using System.Windows.Forms;
using apiexamen;
namespace AgregarUsuarios
{
    public partial class Form1 : Form
    {
        private readonly LibreriaApi dllClass;
        DataTable tabla;
        int ExamenID;

        public Form1()
        {
            InitializeComponent();
            dllClass = new LibreriaApi();
            Iniciar();
            dtMostrarDato.ReadOnly = true;
            dtMostrarDato.CellClick += dtMostrarDato_CellContentClick;
            dtMostrarDato.Columns["ExamenID"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Consultar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarNombreDescripcion();
            Consultar();
        }
        private void btnConsultarLista_Click(object sender, EventArgs e)
        {
            Consultar();
        }


        private void dtMostrarDato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la fila correspondiente a la celda seleccionada
                DataGridViewRow filaSeleccionada = dtMostrarDato.Rows[e.RowIndex];

                // Seleccionar toda la fila
                filaSeleccionada.Selected = true;
            }
            ObtenerNombreDescripcion();
        }
        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("ExamenID");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Descripcion");
            dtMostrarDato.DataSource = tabla;
        }
        private void Guardar()
        {
            // Obtener los datos desde los controles del formulario
            string nombre = textNombre.Text;
            string descripcion = textDescripcion.Text;

            // Llamar al método del DLL para insertar los datos
            dllClass.InsertarDatos(nombre, descripcion);

            // Limpiar los controles del formulario después de la inserción
            Limpiar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObtenerNombreDescripcion();
            EliminaPorID();
            Consultar();
        }
        private void Consultar()
        {
            tabla.Clear();
            var datos = dllClass.ConsultarDatos();

            // Llenar el DataGridView con los datos
            foreach (var (id, nombre, descripcion) in datos)
            {
                tabla.Rows.Add(id, nombre, descripcion);
            }

        }
        private void Limpiar()
        {
            textNombre.Text = string.Empty;
            textDescripcion.Text = string.Empty;
        }
        private void ObtenerNombreDescripcion()
        {
            // Verificar si se seleccionó una fila
            if (dtMostrarDato.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dtMostrarDato.SelectedRows[0];

                // Obtener los datos de la fila seleccionada
                string datosExamenID = filaSeleccionada.Cells["ExamenID"].Value.ToString();
                if (datosExamenID != "")
                {
                    string datosNombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                    string datosDescripcion = filaSeleccionada.Cells["Descripcion"].Value.ToString();
                    // Actualizar el contenido del TextBox con los datos de la fila seleccionada
                    ExamenID = int.Parse(datosExamenID);
                    textNombre.Text = datosNombre;
                    textDescripcion.Text = datosDescripcion;

                }
            }
        }

        private void ModificarNombreDescripcion()
        {
            dllClass.ActualizarDatos(ExamenID, textNombre.Text, textDescripcion.Text);
        }
        private void EliminaPorID()
        {
            dllClass.EliminarExamenPorId(ExamenID);
        }

    }
}