using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApp1
{
    [Serializable()]
    public class Pedido
    {
        string nombre_cliente;
        string nombre_producto;
        string mensaje;
        string direccion_local;
        string codigo_identificador;
        public Pedido(string nombre_cliente, string nombre_producto, string mensaje, string direccion_local, string codigo_identificador)
        {
            this.nombre_cliente = nombre_cliente;
            this.nombre_producto = nombre_producto;
            this.mensaje = mensaje;
            this.direccion_local = direccion_local;
            this.codigo_identificador = codigo_identificador;
        }
        public string GetName()
        {
            return this.nombre_producto; 
        }
        public string Getcodigo_identificador()
        {
            return this.codigo_identificador;
        }
        public string GetNameCliente()
        {
            return this.nombre_cliente;
        }
        public string GetMensaje()
        {
            return this.mensaje;
        }

    }   
  
}
