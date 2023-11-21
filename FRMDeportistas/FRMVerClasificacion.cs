using Entidades;
using Etchart.JuanPablo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRMDeportistas
{
    /// <summary>
    /// Formulario para ver y gestionar la clasificación de deportistas.
    /// </summary>
    public partial class FRMVerClasificacion : Form
    {
        private string ultimoBotonPresionado;
        private Form formActivo = null;
        public List<Deportista> baseDatos;

        public AccesoDatos clasificacion;

        /// <summary>
        /// Constructor de la clase FRMVerClasificacion.
        /// </summary>
        /// <param name="clasificacion">Objeto Clasificacion que contiene la lista de deportistas.</param>
        public FRMVerClasificacion(AccesoDatos clasificacion)
        {
            InitializeComponent();
            this.clasificacion = clasificacion;
            this.baseDatos = null;
        }

        /// <summary>
        /// Manejador de eventos para el botón "Escalada".
        /// Muestra la lista de deportistas de escalada en el DataGridView.
        /// </summary>
        private void btnEscalada_Click(object sender, EventArgs e)
        {
            this.dataGrid.DataSource = null; // Limpia el DataGridView

            this.dataGrid.DataSource = clasificacion.listaEscalada;
            this.ultimoBotonPresionado = ETipoDeDeportista.Escalada.ToString();
        }

        /// <summary>
        /// Manejador de eventos para el botón "Atletismo".
        /// Muestra la lista de deportistas de atletismo en el DataGridView.
        /// </summary>
        private void btnAtletismo_Click(object sender, EventArgs e)
        {
            this.dataGrid.DataSource = null; // Limpia el DataGridView
            this.dataGrid.DataSource = clasificacion.listaAtletismo;
            this.ultimoBotonPresionado = ETipoDeDeportista.Atletismo.ToString();
        }

        /// <summary>
        /// Manejador de eventos para el botón "Voley".
        /// Muestra la lista de deportistas de vóley en el DataGridView.
        /// </summary>
        private void btnVoley_Click(object sender, EventArgs e)
        {
            this.dataGrid.DataSource = null; // Limpia el DataGridView
            this.dataGrid.DataSource = clasificacion.listaVoley;
            this.ultimoBotonPresionado = ETipoDeDeportista.Voley.ToString();
        }

        /// <summary>
        /// Manejador de eventos para el botón "Eliminar".
        /// Elimina el deportista seleccionado en el DataGridView de la lista de deportistas.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dataGrid.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dataGrid.SelectedRows[0].Index;
                Deportista deportistaSeleccionado = (Deportista)dataGrid.Rows[indiceSeleccionado].DataBoundItem;

                clasificacion.EliminarDato(deportistaSeleccionado);

                this.dataGrid.DataSource = null; // Limpia el DataGridView
                this.TipoDeObjeto(deportistaSeleccionado); // Establece la nueva base de datos
            }
        }

        /// <summary>
        /// Cambia la lista de deportistas según el tipo de deporte del deportista seleccionado.
        /// </summary>
        /// <param name="deportista">Deportista seleccionado para determinar el tipo de deporte.</param>
        private void TipoDeObjeto(Deportista deportista)
        {
            if (deportista is Escalada)
            {
                this.dataGrid.DataSource = clasificacion.listaEscalada;
            }
            else if (deportista is Atletismo)
            {
                this.dataGrid.DataSource = clasificacion.listaAtletismo;
            }
            else if (deportista is Voley)
            {
                this.dataGrid.DataSource = clasificacion.listaVoley;
            }
        }

        /// <summary>
        /// Manejador de eventos para el botón "Modificar".
        /// Abre un formulario de edición para el deportista seleccionado en el DataGridView.
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form nuevoForm = null;
            if (this.dataGrid.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dataGrid.SelectedRows[0].Index;
                Deportista deportistaSeleccionado = (Deportista)dataGrid.Rows[indiceSeleccionado].DataBoundItem;

                if (ultimoBotonPresionado == ETipoDeDeportista.Escalada.ToString())
                {
                    nuevoForm = new FRMAgregarEscalada(clasificacion, (Escalada)deportistaSeleccionado);
                }
                else if (ultimoBotonPresionado == ETipoDeDeportista.Atletismo.ToString())
                {
                    nuevoForm = new FRMAgregarAtletismo(clasificacion, (Atletismo)deportistaSeleccionado);
                }
                else if (ultimoBotonPresionado == ETipoDeDeportista.Voley.ToString())
                {
                    nuevoForm = new FRMAgregarVoley(clasificacion, (Voley)deportistaSeleccionado);
                }

                if (nuevoForm != null)
                {
                    nuevoForm.ShowDialog();
                    this.dataGrid.DataSource = null; // Limpia el DataGridView
                    this.TipoDeObjeto(deportistaSeleccionado); // Establece la nueva base de datos
                }
            }
        }

        /// <summary>
        /// Manejador de eventos para el botón "Bajar Categoría".
        /// Disminuye la categoría del deportista seleccionado.
        /// </summary>
        private void btnBajarCategoria_Click(object sender, EventArgs e)
        {
            if (this.dataGrid.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dataGrid.SelectedRows[0].Index;
                Deportista deportistaSeleccionado = (Deportista)dataGrid.Rows[indiceSeleccionado].DataBoundItem;
                
                //seteo al deportista con su nueva categoria y lo modifico en la base de datos
                deportistaSeleccionado.BajarCategoria();
                clasificacion.ModificarDato(deportistaSeleccionado);

                this.dataGrid.DataSource = null; // Limpia el DataGridView
                this.TipoDeObjeto(deportistaSeleccionado); // Establece la nueva base de datos del datagrid
            }
        }

        /// <summary>
        /// Manejador de eventos para el botón "Subir Categoría".
        /// Aumenta la categoría del deportista seleccionado.
        /// </summary>
        private void btnSubirCategoria_Click(object sender, EventArgs e)
        {
            if (this.dataGrid.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dataGrid.SelectedRows[0].Index;
                Deportista deportistaSeleccionado = (Deportista)dataGrid.Rows[indiceSeleccionado].DataBoundItem;

                deportistaSeleccionado.SubirCategoria();
                clasificacion.ModificarDato(deportistaSeleccionado);

                this.dataGrid.DataSource = null; // Limpia el DataGridView
                this.TipoDeObjeto(deportistaSeleccionado); // Establece la nueva base de datos
            }
        }

        /// <summary>
        /// Obtiene una lista de deportistas ordenada según un criterio y un orden específicos.
        /// </summary>
        /// <typeparam name="T">Tipo de deportista (Escalada, Voley, Atletismo).</typeparam>
        /// <param name="lista">Lista de deportistas a ordenar.</param>
        /// <returns>Lista de deportistas ordenada.</returns>
        public List<T> ObtenerListaOrdenada<T>(List<T> lista) where T : Deportista
        {
            List<T> listaOrdenada = new List<T>();

            string selectedItem = this.comboBoxOrdenar.Text.ToString();
            switch (selectedItem)
            {
                case "Nombre":
                    if (this.comboBoxOrden.Text == "Ascendente")
                    {
                        listaOrdenada = lista.OrderBy(dep => dep.Nombre).ToList();
                    }
                    else if (this.comboBoxOrden.Text == "Descendente")
                    {
                        listaOrdenada = lista.OrderByDescending(dep => dep.Nombre).ToList();
                    }
                    break;

                case "Apellido":
                    if (this.comboBoxOrden.Text == "Ascendente")
                    {
                        listaOrdenada = lista.OrderBy(dep => dep.Apellido).ToList();
                    }
                    else if (this.comboBoxOrden.Text == "Descendente")
                    {
                        listaOrdenada = lista.OrderByDescending(dep => dep.Apellido).ToList();
                    }
                    break;

                case "Edad":
                    if (this.comboBoxOrden.Text == "Ascendente")
                    {
                        listaOrdenada = lista.OrderBy(dep => dep.Edad).ToList();
                    }
                    else if (this.comboBoxOrden.Text == "Descendente")
                    {
                        listaOrdenada = lista.OrderByDescending(dep => dep.Edad).ToList();
                    }
                    break;
            }

            return listaOrdenada;
        }

        /// <summary>
        /// Manejador de eventos para el botón "Ordenar".
        /// Ordena la lista de deportistas según el criterio y orden seleccionados.
        /// </summary>
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            switch (this.ultimoBotonPresionado)
            {
                case "Escalada":
                    this.dataGrid.DataSource = null; // Limpia el DataGridView
                    this.dataGrid.DataSource = this.ObtenerListaOrdenada<Escalada>(clasificacion.listaEscalada);
                    break;
                case "Voley":
                    this.dataGrid.DataSource = null; // Limpia el DataGridView
                    this.dataGrid.DataSource = this.ObtenerListaOrdenada<Voley>(clasificacion.listaVoley);
                    break;
                case "Atletismo":
                    this.dataGrid.DataSource = null; // Limpia el DataGridView
                    this.dataGrid.DataSource = this.ObtenerListaOrdenada<Atletismo>(clasificacion.listaAtletismo);
                    break;
            }
        }
    }
}
