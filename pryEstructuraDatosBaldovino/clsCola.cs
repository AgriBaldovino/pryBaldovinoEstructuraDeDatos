using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatosBaldovino
{
    internal class clsCola
    {
        public clsNodos Primero;
        public clsNodos Ultimo;


        public void Agregar(clsNodos Nuevo)
        {
            //Si no existe ninguno en la fila
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                //Si existe uno en la fila ya, el ultimo lo pasa hacia adelante 
                Ultimo.Siguiente = Nuevo;
                //Al nuevo lo pone al ultimo de la fila
                Ultimo = Nuevo;
            }
        }

        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }

        public void Recorrer(DataGridView dgvCola)
        {
            clsNodos aux = Primero;
            dgvCola.Rows.Clear();

            while (aux != null)
            {
                dgvCola.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox lstCola)
        {
            clsNodos aux = Primero;
            lstCola.Items.Clear();

            while (aux != null)
            {
                lstCola.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodos aux = Primero;
            Combo.Items.Clear();

            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
    }
}
