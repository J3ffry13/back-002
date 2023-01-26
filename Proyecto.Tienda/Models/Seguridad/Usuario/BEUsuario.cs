using System.Collections.Generic;

namespace Tienda.Domain.Seguridad
{
    public class BEUsuario
    {
        public int nro { get; set; }
        public int usuarioID { get; set; }
        public int usuarioIDReferencia { get; set; }
        public string usuarioCodigo { get; set; }
        public string usuarioNombre { get; set; }
        public string usuarioApellido { get; set; }
        public string usuarioApellidoPat { get; set; }
        public string usuarioApellidoMat { get; set; }
        public string usuarioNombreCompleto { get; set; }
        public int usuarioTipoID { get; set; }
        public string usuarioTipoNombre { get; set; }
        public string usuarioDNI { get; set; }
        public string usuarioPasssword { get; set; }
        public string usuarioDireccion { get; set; }
        public string usuarioCorreo { get; set; }
        //public List<BEEmpresa> usuarioEmpresas { get; set; }
        public bool usuarioStatus { get; set; }
        public string mensajeRpta { get; set; }
        public string usuarioPicture { get; set; }
        public int empresaID { get; set; }
        public int usuarioAdmin { get; set; }
        public string empresaNombre { get; set; }

        public bool usuarioWeb { get; set; }
        public int usuarioWebID { get; set; }
        public string usuarioWebLogin { get; set; }
        public string usuarioWebPassword { get; set; }
        public string usuarioWPass { get; set; }
        public int webEstadoID { get; set; }
        public bool usuarioWebStatus { get; set; }

        public bool usuarioMovil { get; set; }
        public int usuarioMovilID { get; set; }
        public string usuarioMovilLogin { get; set; }
        public string usuarioMovilPassword { get; set; }
        public string usuarioMPass { get; set; }
        public int movilEstadoID { get; set; }
        public bool usuarioMovilStatus { get; set; }

        public List<int> movilBacoID { get; set; }
        public string movilBacoCod { get; set; }
        public List<int> movilCalibreID { get; set; }
        public string movilCalibreCod { get; set; }
        public List<int> movilCAEID { get; set; }
        public string movilCAECod { get; set; }
        public List<int> movilAcopioComedorID { get; set; }
        public string movilAcopioComedorCod { get; set; }
        public string usuarioLogin { get; set; }
        public string usuarioEstado { get; set; }
        public string usuarioLegajo { get; set; }
    }
}
