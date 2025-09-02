using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class Certificado
    {
        public int codConselhoMedico { get; set; }
        public string strCertificados{ get; set; }
        public string Base64String { get; set; }
        public string tipo { get; set; }
        public string ordem { get; set; }
    
        //public int strCertificadoACLSPath { get; set; }
        //public int strCertificadoCongressoPath { get; set; }
        //public int strCertificadoArtigoPath { get; set; }
        //public int strCertificadoCapituloPath { get; set; }
        //public int strCertificadoCursoPosPath { get; set; }
        //public int strCertificadoMestradoPath { get; set; }
        //public int strCertificadoDoutoradoPath { get; set; }
        //public int strCertificadoOutrosPath { get; set; }
    }
    
}
