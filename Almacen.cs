using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConListas
{
    class Almacen
    {
        private int contador = 0;
        private Productos inicio;
        public Almacen()
        {
            inicio = null;
        }
        public void agregarProducto(Productos producto)
        {
            bool agregar=true;
            if(inicio == null)
            {
                inicio = producto;
            }
            else
            {
                Productos varTemporal = inicio;
                while (varTemporal.siguiente != null && agregar == true)
                {
                    agregar = false;
                    varTemporal = varTemporal.siguiente;
                }
                if(agregar== true)
                {
                    varTemporal.siguiente = producto;
                }
            }
        }
        public Productos buscarProducto(int codigo)
        {
            Productos varTemporal = inicio;
            while(varTemporal != null)
            {
                varTemporal = varTemporal.siguiente;
            }
            return varTemporal;
        }
        public string reporte()
        {
            string resultado = "";
            Productos varTemporal = inicio;
            while(varTemporal != null)
            {
                resultado += varTemporal.ToString();
                varTemporal = varTemporal.siguiente;
            }
            return resultado;
        }
        public void eliminarProducto(int codigo)
        {
            Productos varTemporal = inicio;
            if(varTemporal != null)
            {
                inicio = varTemporal.siguiente;
                varTemporal = inicio;
            }
            else
            {
                while(varTemporal.siguiente != null)
                {
                    varTemporal = varTemporal.siguiente;
                }
                if(varTemporal.siguiente != null)
                {
                    varTemporal.siguiente = varTemporal.siguiente.siguiente;
                }
            }
        }
        /*public string insertarProducto(int posicion, Productos producto)
        {

        }*/
        public override string ToString()
        {
            return Convert.ToString(contador);
        }
    }
}
