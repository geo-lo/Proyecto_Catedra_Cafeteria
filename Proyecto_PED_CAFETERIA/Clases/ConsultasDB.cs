using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PED_CAFETERIA.Clases
{
    internal class ConsultasDB : ConexionDB
    {

        //Obtener datos (Select) de la tabla Inventario
        public DataTable MostrarInventario()
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

            comando.Connection = AbrirConexion();
            comando.CommandText = "SELECT IdProducto, NombreProducto, CantidadActual, PrecioUnitario FROM Inventario"; //Consulta SQL para obtener todos los productos

            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer); //Cargar los datos en la tabla

            leer.Close();
            CerrarConexion();
            return tabla;
        }

        //Insertar datos (Insert) en la tabla Inventario
        public void Insertar(string nombre, int cantidad, double precio )

        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = AbrirConexion();
            comando.CommandText = "INSERT INTO Inventario (NombreProducto, CantidadActual, PrecioUnitario) VALUES (@nombre, @cantidad, @precio)"; //Consulta SQL para insertar un nuevo producto
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@precio", precio);
            
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        //Actualizar datos (Update) en la tabla Inventario
        public void EditarProducto(string nombre, int cantidad, double precio)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = AbrirConexion();

            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@precio", precio);

            comando.ExecuteNonQuery();
            CerrarConexion() ;
        }

        //Eliminar datos (Delete) de la tabla Inventario
        public void EliminarProducto(string nombre)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = AbrirConexion();
            comando.CommandText = "DELETE FROM Inventario WHERE NombreProducto = @nombre"; //Consulta SQL para eliminar un producto por su nombre

            comando.Parameters.AddWithValue("@nombre", nombre);

            comando.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}
