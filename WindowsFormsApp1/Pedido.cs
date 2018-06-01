using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Pedido
    {
        string nombre_cliente;
        string nombre_producto;
        string mensaje;
        string direccion_local;
        public Pedido(string nombre_cliente, string nombre_producto, string mensaje, string direccion_local)
        {
            this.nombre_cliente = nombre_cliente;
            this.nombre_producto = nombre_producto;
            this.mensaje = mensaje;
            this.direccion_local = direccion_local;
        }
        public string GetName()
        {
            return this.nombre_producto; 
        }
    }
}
