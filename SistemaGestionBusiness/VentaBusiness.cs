using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBusiness
{
    public class VentaBusiness
    {
        public Venta GetVentaBussines(int Id)
        {
            return VentaDAO.GetVenta(Id);
        }

        public List<Venta> GetAllVentasBussines()
        {
            return VentaDAO.GetAllVentas();
        }

        public int AddVentaBussines(Venta venta)
        {
            return VentaDAO.AddVenta(venta);
        }

        public Venta UpdateVentaBussines(Venta venta)
        {
            return VentaDAO.UpdateVenta(venta);
        }

        public int DeleteVentaBussines(int Id)
        {
            return VentaDAO.DeleteVenta(Id);
        }
    }
}
