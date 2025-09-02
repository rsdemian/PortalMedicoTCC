using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class DadosAvaliacaoPDF
    {
        public string NomeMedicoPDF { get; set; }
        public string CodigoConselhoMedico { get; set; }
        public string EspecialidadeMedica { get; set; }
        public string NotaComportamento { get; set; }
        public string ObsComportamento { get; set; }
        public string NotaResultadoClinico { get; set; }
        public string ObsResultadoClinico { get; set; }
        public string DataAvaliacao { get; set; }
        public string ValidadeAvaliacao { get; set; }
        public string MedicoAvaliado { get; set; }
        public string MedicoAvaliador { get; set; }

    }
}
