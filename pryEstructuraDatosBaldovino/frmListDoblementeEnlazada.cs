using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatosBaldovino
{
    public partial class frmListaDoblementeEnlazada : Form
    {
        public frmListaDoblementeEnlazada()
        {
            InitializeComponent();
        }

        clsListaDoble ListaDoble = new clsListaDoble();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaDoble.Primero != null)
            {
                Int32 x = Convert.ToInt32(cbCombo.Text);
                ListaDoble.Eliminar(x);

                ListaDoble.Recorrer(dgvListaDoble);
                ListaDoble.Recorrer(lstListaDoble);
                ListaDoble.Recorrer(cbCombo);
                ListaDoble.RecorrerDes(dgvListaDoble);
                ListaDoble.RecorrerDes(lstListaDoble);
            }
            else
            {
                MessageBox.Show("la lista esta vacia");
            }
            btnEliminar.Enabled = false;
        }

        clsListaDoble Lista = new clsListaDoble();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodos ObjNodo = new clsNodos();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            Lista.Agregar(ObjNodo);
            Lista.Recorrer(dgvListaDoble);
            Lista.Recorrer(lstListaDoble);
            Lista.Recorrer(cbCombo);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }
    }
}
