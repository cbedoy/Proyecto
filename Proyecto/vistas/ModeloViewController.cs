using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.controladores;
using Proyecto.modelos;

namespace Proyecto.vistas
{
    public partial class ModeloViewController : UserControl, IViewController
    {
        private ModeloController mBusinessController;

        public void setBusinessController(ModeloController controller)
        {
            mBusinessController = controller;
        }

        private List<Modelo> mModeloList;

        private Modelo mCurrentModelo;

        public ModeloViewController()
        {
            InitializeComponent();
        }

        private void ModeloViewController_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            modelo.Talla = mNombre.Text;

            mBusinessController.agregarUnNuevoModelo(modelo);

            onReloadData();

            mNombre.Text = String.Empty;
            mIdentificador.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            modelo.Identificador = int.Parse(mIdentificador.Text);
            modelo.Talla = mNombre.Text;

            mBusinessController.modificarUnModelo(modelo);

            onReloadData();

            mNombre.Text = String.Empty;
            mIdentificador.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mNombre.Text = mCurrentModelo != null ? mCurrentModelo.Talla.ToString() : "";
            mIdentificador.Text = mCurrentModelo != null ? mCurrentModelo.Identificador.ToString() : "";

            onReloadData();
        }


        public void onReloadData()
        {
            mCurrentModelo = null;

            mModeloList = mBusinessController.obtenerTodosLosModelosDisponibles();

            mIdentificador.Enabled = false;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mModeloList;
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dataGridView1.Rows[e.RowIndex].DataBoundItem != null)
                {
                    mCurrentModelo = (Modelo)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                    mNombre.Text = mCurrentModelo != null ? mCurrentModelo.Talla.ToString() : "";
                    mIdentificador.Text = mCurrentModelo != null ? mCurrentModelo.Identificador.ToString() : "";
                }

            }
        }

        private void mNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}
