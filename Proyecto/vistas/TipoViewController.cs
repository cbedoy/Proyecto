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
    public partial class TipoViewController : UserControl, IViewController
    {
        private TipoController mController;

        public void setBusinessController(TipoController controller)
        {
            mController = controller;
        }

        private Tipo mCurrentTipo;

        private List<Tipo> mListaTipos;

        public TipoViewController()
        {
            InitializeComponent();
        }

        private void TipoViewController_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Añadir un tipo
            Tipo tipo = new Tipo();
            tipo.Descripcion = mDescripcion.Text;
            tipo.Nombre = mNombre.Text;

            mController.agregarUnNuevoTipo(tipo);

            onReloadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Modificar un tipo
            Tipo tipo = new Tipo();
            tipo.Identificador = int.Parse(mIdentificador.Text);
            tipo.Descripcion = mDescripcion.Text;
            tipo.Nombre = mNombre.Text;

            mController.modifcarUnTipo(tipo);

            onReloadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Boton para limpiar campos
            //Valido si tengo un tipo seleccionado previamente
            //Operador ternario investiga que es

            mIdentificador.Text = mCurrentTipo != null ? mCurrentTipo.Identificador.ToString() : "" ;

            mDescripcion.Text = mCurrentTipo != null ? mCurrentTipo.Descripcion.ToString() : "";

            mNombre.Text = mCurrentTipo != null ? mCurrentTipo.Nombre.ToString() : "";

            onReloadData();
            
        }

        private void mTipoSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void onReloadData()
        {
            mCurrentTipo = null;

            mListaTipos = mController.obtenerTodosLosTiposDisponibles();


            mGridView.DataSource = null;
            mGridView.DataSource = mListaTipos;

            mIdentificador.Enabled = false;
        }

        private void mGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                if (mGridView.Rows[e.RowIndex].DataBoundItem != null)
                {
                    mCurrentTipo = (Tipo)mGridView.Rows[e.RowIndex].DataBoundItem;

                    mIdentificador.Text = mCurrentTipo != null ? mCurrentTipo.Identificador.ToString() : "";

                    mDescripcion.Text = mCurrentTipo != null ? mCurrentTipo.Descripcion.ToString() : "";

                    mNombre.Text = mCurrentTipo != null ? mCurrentTipo.Nombre.ToString() : "";
                }
            }
        }

        private void mDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void mNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}
