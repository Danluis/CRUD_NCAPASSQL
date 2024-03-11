using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objectCD = new CD_Productos();
        
        public DataTable MostarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objectCD.Mostrar();
            return tabla;
        }

        public void InsertarProd(string nombre, string desc, string marca, string precio, string stock)
        {
            objectCD.Insertar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void EditarProd(string nombre, string desc, string marca, string precio, string stock, string id)
        {
            objectCD.Editar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }

        public void EliminarProd(string id)
        {
            objectCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
