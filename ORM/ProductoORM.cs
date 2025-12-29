using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System.Data;
using BE;


namespace ORM
{
    public class ProductoORM
    {
        private Access acceso = new Access();
        private string agregar = "AGREGAR_PRODUCTO";
        private string eliminar = "ELIMINAR_PRODUCTO";
        private string modificar = "MODIICAR_PRODUCTO";

        public List<ProductoBE> Obtener()
        {
            List<ProductoBE> listaProductos = new List<ProductoBE>();

            DataTable table = acceso.Leer("OBTENER_PRODUCTOS");

            ProductoBE Producto = new ProductoBE
            {
                Marca = table.Columns["MARCA"].ToString(),
                Nombre = table.Columns["NOMBRE"].ToString(),
                Peso = Convert.ToInt32(table.Columns["PESO"]),
                Precio = Convert.ToInt32(table.Columns["PRECIO"]),
                Stock_disponible = Convert.ToInt32(table.Columns["STOCK_DISPONIBLE"]),
                Ultima_actualizacion = Convert.ToDateTime(table.Columns["ULTIMA_ACTUALIZACION"])
            };
                
            listaProductos.Add(Producto);

            return listaProductos;
        }

        public void Agregar(ProductoBE newP)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("MARCA",SqlDbType.VarChar) { Value = newP.Marca },
                new SqlParameter("NOMBRE",SqlDbType.VarChar) { Value = newP.Nombre },
                new SqlParameter("PESO",SqlDbType.Decimal) { Value = newP.Peso },
                new SqlParameter("PRECIO",SqlDbType.Decimal) { Value = newP.Precio },
                new SqlParameter("STOCK_DISPONIBLE",SqlDbType.Int) { Value = newP.Stock_disponible },
                new SqlParameter("ULTIMA_ACTUALIZACION",SqlDbType.DateTime ) { Value = newP.Ultima_actualizacion}
            };

            acceso.Escribir(agregar, sp);
        }
        
        public void Eliminar( int id_proucto )
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("ID_PRODUCTO",SqlDbType.VarChar) { Value = id_proucto },
            };

            acceso.Escribir(eliminar,sp);

        }

        public void Modificar( int id_proucto , ProductoBE newP )
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("ID_PRODUCTO",SqlDbType.VarChar) { Value = id_proucto },
                new SqlParameter("MARCA",SqlDbType.VarChar) { Value = newP.Marca },
                new SqlParameter("NOMBRE",SqlDbType.VarChar) { Value = newP.Nombre },
                new SqlParameter("PESO",SqlDbType.Decimal) { Value = newP.Peso },
                new SqlParameter("PRECIO",SqlDbType.Decimal) { Value = newP.Precio },
                new SqlParameter("STOCK_DISPONIBLE",SqlDbType.Int) { Value = newP.Stock_disponible },
                new SqlParameter("ULTIMA_ACTUALIZACION",SqlDbType.DateTime ) { Value = newP.Ultima_actualizacion}
            };
            acceso.Escribir(modificar,sp);
        }
    }
}
