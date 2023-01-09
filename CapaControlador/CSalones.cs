using CapaDatos;
using System.Data;

namespace CapaControlador
{
    public class CSalones
    {
        public static void mostrarSalones(DataTable dt, bool activo)
        {
            DSalones.mostrar(dt, activo);
        }

        public static bool eliminarSalon(int salonId)
        {
            return SQL.deleteById("Salones", "codigo", salonId);
        }
        public static bool guardar(int codigo,string descripcion,decimal impuesto,
            bool activo, int opcion)
        {
            DSalones salon = new DSalones();
            salon.Descripcion = descripcion;
            salon.Impuesto = impuesto;
            salon.Activo = activo;
            salon.Codigo = codigo;
            return DSalones.guardar(salon, opcion);
        }
    }
}
