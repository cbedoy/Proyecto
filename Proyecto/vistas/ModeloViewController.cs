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
    public partial class ModeloViewController : UserControl
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
            mModeloList = mBusinessController.obtenerTodosLosModelosDisponibles();

            foreach (Modelo elModeloPedorro in mModeloList)
            {
                mModeloSelector.Items.Add(elModeloPedorro.Talla);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            modelo.Talla = mNombre.Text;

            mBusinessController.agregarUnNuevoModelo(modelo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            modelo.Identificador = int.Parse(mIdentificador.Text);
            modelo.Talla = mNombre.Text;

            mBusinessController.modificarUnModelo(modelo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mNombre.Text = mCurrentModelo != null ? mCurrentModelo.Talla.ToString() : "";
            mIdentificador.Text = mCurrentModelo != null ? mCurrentModelo.Identificador.ToString() : "";
        }

        private void mModeloSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            mCurrentModelo = mModeloList.ElementAt(mModeloSelector.SelectedIndex);

            mNombre.Text = mCurrentModelo != null ? mCurrentModelo.Talla.ToString() : "";
            mIdentificador.Text = mCurrentModelo != null ? mCurrentModelo.Identificador.ToString() : "";
  
        }
    }
}
