using System;

namespace Seguridad.Domain
{
    public class Usuario
    {
        public int nUsuId { get; set; }
        public string cUsuLogin { get; set; }
        public string cUsuNombres { get; set; }
        public string cUsuApePat { get; set; }
        public string cUsuApeMat { get; set; }
        public string cUsuCorreo { get; set; }
        public string cUsuPrgSecreta { get; set; }
        public string cUsuRptSecreta { get; set; }
        public bool cEliminado { get; set; }
        public string cImgUsuario { get; set; }
    }
}
