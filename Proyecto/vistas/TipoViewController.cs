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
    public partial class TipoViewController : UserControl
    {
        public TipoController controller;

        private Tipo mCurrentTipo;

        private List<Tipo> mListaTipos;

        public TipoViewController()
        {
            InitializeComponent();
        }

        private void TipoViewController_Load(object sender, EventArgs e)
        {
            //Antes de inciar la ventana o de recargar la venta
            //Se llena en automatico con informacion sobre los tipos

            mListaTipos = controller.obtenerTodosLosTiposDisponibles();

            foreach (Tipo elTipo in mListaTipos)
            {
                //Se llena el combo box con elementos
                //Donde los elementos son el nombre del tipo...
                mTipoSelector.Items.Add(elTipo.Nombre);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Añadir un tipo
            Tipo tipo = new Tipo();
            tipo.Descripcion = mDescripcion.Text;
            tipo.Nombre = mNombre.Text;

            controller.agregarUnNuevoTipo(tipo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Modificar un tipo
            Tipo tipo = new Tipo();
            tipo.Identificador = int.Parse(mIdentificador.Text);
            tipo.Descripcion = mDescripcion.Text;
            tipo.Nombre = mNombre.Text;

            controller.agregarUnNuevoTipo(tipo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Boton para limpiar campos
            //Valido si tengo un tipo seleccionado previamente
            //Operador ternario investiga que es

            mIdentificador.Text = mCurrentTipo != null ? mCurrentTipo.Identificador.ToString() : "" ;

            mDescripcion.Text = mCurrentTipo != null ? mCurrentTipo.Descripcion.ToString() : "";

            mNombre.Text = mCurrentTipo != null ? mCurrentTipo.Nombre.ToString() : "";
            
        }

        private void mTipoSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(mListaTipos != null && mListaTipos.Count > 0){

                //Obvio esto...

                mCurrentTipo = mListaTipos.ElementAt(mTipoSelector.SelectedIndex);

                mIdentificador.Text = mCurrentTipo != null ? mCurrentTipo.Identificador.ToString() : "";

                mDescripcion.Text = mCurrentTipo != null ? mCurrentTipo.Descripcion.ToString() : "";

                mNombre.Text = mCurrentTipo != null ? mCurrentTipo.Nombre.ToString() : "";

            }
        }
    }
}
