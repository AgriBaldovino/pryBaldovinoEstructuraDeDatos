using System;
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
    public partial class frmListaEnlazadaSimple : Form
    {
        public frmListaEnlazadaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple Lista = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodos ObjNodo = new clsNodos();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            Lista.Agregar(ObjNodo);
            Lista.Recorrer(dgvLista);
            Lista.Recorrer(lstLista);
            Lista.Recorrer(cbCombo);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cbCombo.Text);
                Lista.Eliminar(x);
                
                Lista.Recorrer(dgvLista);
                Lista.Recorrer(lstLista);
                Lista.Recorrer(cbCombo);

            }
            else
            {
                MessageBox.Show("la lista esta vacia");
            }
            btnEliminar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
