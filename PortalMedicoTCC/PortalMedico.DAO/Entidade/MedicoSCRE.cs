using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class MedicoSCRE
    {
        public string statusMedico { get; set; }
        public string strNomeMedico { get; set; }
        public string CRMRS { get; set; }
        public string dataInclusaoCadastro { get; set; }
        public string dataAlteracaoCadastro { get; set; }
        public string dataConclusaoAprovacao { get; set; }
        public string dataExpiracao { get; set; }
        public string dataHoraExpiracao { get; set; }
        public string tipoStatusMedico { get; set; }
        public string profissao { get; set; }
        public string mensagem { get; set; }

        
        public static MedicoSCRE CriaObjetoMedicoSCRE(DataRow dr)
        {
            MedicoSCRE medicoSCRE = new MedicoSCRE();

            medicoSCRE.statusMedico = "SEM DADOS";
            medicoSCRE.strNomeMedico = "SEM DADOS";
            medicoSCRE.CRMRS = "1";
            medicoSCRE.dataInclusaoCadastro = "SEM DADOS";
            medicoSCRE.dataAlteracaoCadastro = "SEM DADOS";
            medicoSCRE.dataConclusaoAprovacao = "SEM DADOS";
            medicoSCRE.dataInclusaoCadastro = "SEM DADOS";
            medicoSCRE.dataExpiracao = "SEM DADOS";
            medicoSCRE.dataExpiracao = "SEM DADOS";
            medicoSCRE.dataHoraExpiracao = "SEM DADOS";
            medicoSCRE.tipoStatusMedico = "SEM DADOS";
            medicoSCRE.profissao = "SEM DADOS";

            return medicoSCRE;
        }
    }
}
