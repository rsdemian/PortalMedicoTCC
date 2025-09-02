using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class Pontuacao
    {
        public string strNomeMedico { get; set; }
        public string certificados { get; set; }
        public string pontuacao { get; set; }

        public static Pontuacao CriaObjetoPontuacao(DataRow dr)
        {
            Pontuacao pontuacao = new Pontuacao();

            pontuacao.strNomeMedico = dr["strNomeMedico"].ToString();
            pontuacao.certificados = dr["certificados"].ToString();
            pontuacao.pontuacao = dr["pontuacao"].ToString();

            return pontuacao;
        }
    }
}
