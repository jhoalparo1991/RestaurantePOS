using CapaDatos;
using System.Data;

namespace CapaControlador
{
    public class CVendedores
    {

        public static void mostrar(DataTable dt,string buscar)
        {
            DVendedores.mostrar(dt, buscar);    
        }

        public static void llenarComboBox(DataTable dt)
        {
            SQL.llenarComboBox(dt,"roles");
        }

        public static bool eliminar(int code)
        {
           return SQL.deleteById("vendedores", "codigo", code);
        }
        public static bool guardar(int codigo, string nombres, string apellidos,
            string tipo_doc, string nro_doc, string direccion,string telefono,string celular,
            string email,string ciudad,string pais,string clave, byte[] imagen,bool activo,
            decimal salarioBase,decimal cosmision,int roleId,int opcion)
        {
            DVendedores vd= new DVendedores();
            vd.Codigo= codigo;
            vd.Nombres = nombres;
            vd.Apellidos= apellidos;
            vd.TipoDoc = tipo_doc;
            vd.NroDoc = nro_doc;
            vd.Direccion = direccion;
            vd.Telefono = telefono;
            vd.Celular = celular;
            vd.Ciudad = ciudad;
            vd.Pais = pais;
            vd.Clave = clave;
            vd.Foto = imagen;
            vd.Activo= activo;
            vd.SalarioBase = salarioBase;
            vd.Comision = cosmision;
            vd.RolId = roleId;
            vd.Email = email;
            return DVendedores.guardar(vd, opcion);
        }

        public static void iniciarSesion(DataTable dt, string clave)
        {
            DVendedores.iniciarSesion(dt, clave);
        }

        public static bool verificarEstado(int vendedorId)
        {
            return DVendedores.verificarEstado(vendedorId);
        }

        public static bool cambiarEstado(int vendedorId)
        {
            return DVendedores.cambiarEstado(vendedorId);
        }
        public static void obtenerDatosInicioSesion(DataTable dt)
        {
            DVendedores.obtenerDatosInicioSesion(dt);
        }
    }
}
