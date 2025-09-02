using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class TermoConsentimento
    {
        public int codTermo { get; set; }
        public string strTermo { get; set; }
        public string strTermoPath { get; set; }
        public string snAtivo { get; set; }
        public DateTime createDate { get; set; }
        public string retorno { get; set; }

        public static TermoConsentimento CriaObjetoTermoConsentimento(DataRow dr)
        {
            TermoConsentimento termoConsentimento = new TermoConsentimento();

            termoConsentimento.codTermo = Convert.ToInt32(dr["codTermo"].ToString());
            termoConsentimento.strTermo = dr["strTermo"].ToString();
            termoConsentimento.strTermoPath = dr["strTermoPath"].ToString();
            termoConsentimento.snAtivo = dr["snAtivo"].ToString();
            termoConsentimento.createDate = Convert.ToDateTime(dr["createDate"].ToString());

            return termoConsentimento;

        }
    }
}
