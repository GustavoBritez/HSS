using System.Security.Cryptography.X509Certificates;
using ORM;
namespace HSS
{
    public partial class Form1 : Form
    {
        ProductoORM producto = new ProductoORM();
        public Form1()
        {
            InitializeComponent();
            Grilla_Productos.DataSource = producto.Obtener();
        }


    }
}
