using CapaDatos;
using System.Data;

namespace CapaControlador
{
    public class CRoles
    {

        public static bool guardar(int codigo, string nombre, string descripcion, bool activo, int opcion)
        {
            DRoles roles = new DRoles();
            roles.Nombre = nombre;
            roles.Descripcion = descripcion;
            roles.Activo = activo;
            roles.Codigo = codigo;
            return DRoles.guardar(roles,opcion);
        }

        public static void mostrar(DataTable dt, bool status)
        {
            DRoles.mostrar(dt, status);
        }

        public static bool eliminar(int codigo)
        {
            return SQL.deleteById("roles", "codigo", codigo);
        }
    }
}
