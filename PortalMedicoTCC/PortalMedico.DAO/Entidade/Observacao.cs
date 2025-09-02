using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class Observacao
    {
        public string strNomeMedicoMensagem { get; set; }
        public string strNomeMedico { get; set; }
        public string ficha { get; set; }
        public string strObservacao { get; set; }
        public string createDate { get; set; }

        public static Observacao CriaObjetoObservacaoFicha(DataRow dr)
        {
            Observacao observacao = new Observacao();

            observacao.strNomeMedicoMensagem = dr["strNomeMedicoMensagem"].ToString();
            observacao.ficha = dr["ficha"].ToString();
            observacao.strObservacao = dr["strObservacao"].ToString();
            observacao.createDate = dr["createDate"].ToString();


            return observacao;
        }
        public static Observacao CriaObjetoObservacaoFichaTodosMedicos(DataRow dr)
        {
            Observacao observacao = new Observacao();

            observacao.strNomeMedicoMensagem = dr["strNomeMedicoMensagem"].ToString();
            observacao.ficha = dr["ficha"].ToString();
            observacao.strNomeMedico = dr["strNomeMedico"].ToString();
            observacao.strObservacao = dr["strObservacao"].ToString();
            observacao.createDate = dr["createDate"].ToString();


            return observacao;
        }

    }
}
