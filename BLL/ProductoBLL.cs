using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using ORM;
namespace BLL
{
    public class ProductoBLL
    {
        ProductoORM producto = new ProductoORM();

        public List<ProductoBE> Obtener()
        {
            return producto.Obtener();
        }

        public void Eliminar(int id_producto)
        {
            producto.Eliminar(id_producto);
        }
        public void Modificar( int id_producto , ProductoBE newP )
        {
            producto.Modificar(id_producto,newP);
        }
        public void Agregar( ProductoBE newP )
        {
            try
            {
                if (newP != null)
                {
                    producto.Agregar(newP);
                }
            }
            catch
            {
                return;
            }
        }
    }
}
