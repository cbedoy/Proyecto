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
using Proyecto.vistas;

namespace Proyecto
{
    public partial class InventoryViewController : UserControl, IViewController
    {
        private ProductoController mBusinessController;
        private List<Producto> productoList;

        public void setBusinessController(ProductoController controller)
        {
            mBusinessController = controller;
        }

        public InventoryViewController()
        {
            InitializeComponent();
        }

        private void InventoryViewController_Load(object sender, EventArgs e)
        {
        }

        public void onReloadData()
        {
            productoList = mBusinessController.obtenerListaDeProductos();

            mGridInventory.DataSource = null;

            mGridInventory.DataSource = productoList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (productoList.Count > 0)
            {
                Producto productoMasCaro = productoList.ElementAt(0);
                foreach (Producto unProductoDe in productoList)
                {
                    if (unProductoDe.Precio > productoMasCaro.Precio)
                    {
                        productoMasCaro = unProductoDe;
                    }
                }
                mGridInventory.DataSource = null;

                List<Producto> productitoLista = new List<Producto>();
                productitoLista.Add(productoMasCaro);

                mGridInventory.DataSource = null;
                mGridInventory.DataSource = productitoLista;
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (productoList.Count > 0)
            {
                Producto productoMenosCaro = productoList.ElementAt(0);
                foreach (Producto unProductoDe in productoList)
                {
                    if (unProductoDe.Precio < productoMenosCaro.Precio)
                    {
                        productoMenosCaro = unProductoDe;
                    }
                }
                mGridInventory.DataSource = null;

                List<Producto> productitoLista = new List<Producto>();
                productitoLista.Add(productoMenosCaro);

                mGridInventory.DataSource = null;
                mGridInventory.DataSource = productitoLista;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            onReloadData();
        }
    }
}
