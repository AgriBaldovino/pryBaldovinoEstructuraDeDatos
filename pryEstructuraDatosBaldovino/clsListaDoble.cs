using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatosBaldovino
{
    internal class clsListaDoble
    {
        private clsNodos pri;
        private clsNodos ult;

        public clsNodos Primero
        {
            get { return pri; }
            set { pri = value; }

        }

        public clsNodos Ultimo
        {
            get { return ult; }
            set { ult = value; }

        }

        public void Agregar (clsNodos Nvo)
        {
            if (Primero == null)
            {
                Primero = Nvo;
                Ultimo = Nvo;
            }
            else
            {
                if (Nvo.Codigo <= Primero.Codigo)
                {
                    Nvo.Siguiente = Primero;
                    Primero.Anterior = Nvo;
                    Primero = Nvo;
                }
                else
                {
                    if (Nvo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nvo;
                        Nvo.Anterior = Ultimo;
                        Ultimo = Nvo;
                    }
                    else
                    {
                        clsNodos aux = Primero;
                        clsNodos ant = Primero;

                        while (aux.Codigo < Nvo.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }

                        ant.Siguiente = Nvo;
                        Nvo.Siguiente = aux;
                        aux.Anterior = Nvo;
                        Nvo.Anterior = ant;
                    }
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                    
                }
                else
                {
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        clsNodos aux = Primero;
                        clsNodos ant = Primero;

                        while (aux.Codigo < Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }

                        ant.Siguiente = aux.Siguiente;
                        aux = aux.Siguiente;
                        aux.Anterior = ant;
                    }
                }
            }
        }

        public void Recorrer(DataGridView dgvListaDoble)
        {
            clsNodos aux = Primero;
            dgvListaDoble.Rows.Clear();

            while (aux != null)
            {
                dgvListaDoble.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox lstListaDoble)
        {
            clsNodos aux = Primero;
            lstListaDoble.Items.Clear();

            while (aux != null)
            {
                lstListaDoble.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodos aux = Primero;
            Combo.Items.Clear();

            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void RecorrerDes(DataGridView dgvListaDoble)
        {
            clsNodos aux = Ultimo;
            dgvListaDoble.Rows.Clear();

            while (aux != null)
            {
                dgvListaDoble.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }

        public void RecorrerDes(ListBox lstListaDoble)
        {
            clsNodos aux = Ultimo;
            lstListaDoble.Items.Clear();

            while (aux != null)
            {
                lstListaDoble.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Anterior;
            }
        }

    }
}
