using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class Medico
    {
        public string codMedico { get; set; }
        public string StrNome { get; set; }
        public string StrNomeCompleto { get; set; }
        public string CodPrestadorMV { get; set; }
        public string Foto { get; set; }
        public string Sexo { get; set; }
        public string OutrosPacientes { get; set; }
        public string token { get; set; }
        public string retorno { get; set; }
        public string CRM { get; set; }

        public string nomeArquivoSCRE { get; set; }
        public string dataInclusaoArquivoSCRE { get; set; }
        public string dataAlteracaoArquivoSCRE { get; set; }
        public string dataExpiraSCRE { get; set; }
        public string href { get; set; }


        public string pathCompleto { get; set; }

        public string statusMedico { get; set; }

        public string mensagem { get; set; }

        public string quantidadeAcessos { get; set; }

    }
}
