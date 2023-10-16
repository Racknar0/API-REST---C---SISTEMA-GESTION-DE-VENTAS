using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBusiness
{
    public class VentaBusiness
    {
        private static VentaBusiness _instance;
        private static readonly object _lock = new object();

        private VentaBusiness() { }

        public static VentaBusiness GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new VentaBusiness();
                }
            }
            return _instance;
        }

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
