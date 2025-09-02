using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class AvaliacaoPerformance
    {
        public string codigoConselhoMedico { get; set; }
        public string codigoConselhoMedicoAvaliador { get; set; }
        public string strNomeMedicoAvaliador { get; set; }
        public string notaComportamento { get; set; }
        public string notaResultadoClinico { get; set; }
        public string observacaoComportamento { get; set; }
        public string observacaoResultadoClinico { get; set; }
        public string totalMedicosMV { get; set; }
        public string nomeMedicoAvaliado { get; set; }
        public string dataExpiraAvaliacao { get; set; }
        public string dataAvaliacao { get; set; }
        public string medicoAvaliado { get; set; }
        public string SnAprovou { get; set; }
        public string dataAprovacaoAvaliacao { get; set; }


        public string total { get; set; }
        public string avaliados { get; set; }


        public static AvaliacaoPerformance CriaObjetoAvaliacao(DataRow dr)
        {
            AvaliacaoPerformance avaliacaoPerformance = new AvaliacaoPerformance();

            avaliacaoPerformance.codigoConselhoMedico = dr["codigoConselhoMedico"].ToString();
            avaliacaoPerformance.codigoConselhoMedicoAvaliador = dr["codigoConselhoMedicoAvaliador"].ToString();
            avaliacaoPerformance.strNomeMedicoAvaliador = dr["strNomeMedicoAvaliador"].ToString();
            avaliacaoPerformance.notaComportamento = dr["notaComportamento"].ToString();
            avaliacaoPerformance.notaResultadoClinico = dr["notaResultadoClinico"].ToString();
            avaliacaoPerformance.observacaoComportamento = dr["observacaoComportamento"].ToString();
            avaliacaoPerformance.observacaoResultadoClinico = dr["observacaoResultadoClinico"].ToString();
            avaliacaoPerformance.dataAvaliacao = dr["dataAvaliacao"].ToString();
            avaliacaoPerformance.dataExpiraAvaliacao = dr["dataExpiraAvaliacao"].ToString();
            avaliacaoPerformance.medicoAvaliado = dr["medicoAvaliado"].ToString();
            

            return avaliacaoPerformance;
        }

        public static AvaliacaoPerformance CriaObjetoAvaliacaoGeral(DataRow dr)
        {
            AvaliacaoPerformance avaliacaoPerformance = new AvaliacaoPerformance();

            avaliacaoPerformance.total = dr["total"].ToString();
            avaliacaoPerformance.avaliados = dr["avaliados"].ToString();

            return avaliacaoPerformance;
        }

        public static AvaliacaoPerformance CriaObjetoAvaliacaoTodosMedicos(DataRow dr)
        {
            AvaliacaoPerformance avaliacaoPerformance = new AvaliacaoPerformance();

            avaliacaoPerformance.nomeMedicoAvaliado = dr["strNomeMedicoAvaliado"].ToString();
            avaliacaoPerformance.codigoConselhoMedico = dr["codigoConselhoMedico"].ToString();
            avaliacaoPerformance.strNomeMedicoAvaliador = dr["strNomeMedicoAvaliador"].ToString();
            avaliacaoPerformance.notaComportamento = dr["notaComportamento"].ToString();
            avaliacaoPerformance.notaResultadoClinico = dr["notaResultadoClinico"].ToString();
            avaliacaoPerformance.observacaoComportamento = dr["observacaoComportamento"].ToString();
            avaliacaoPerformance.observacaoResultadoClinico = dr["observacaoResultadoClinico"].ToString();
            avaliacaoPerformance.dataExpiraAvaliacao = dr["dataExpiraAvaliacao"].ToString();
            avaliacaoPerformance.dataAvaliacao = dr["dataAvaliacao"].ToString();
            avaliacaoPerformance.SnAprovou = dr["snAprovar"].ToString();
            avaliacaoPerformance.dataAprovacaoAvaliacao = dr["dataAprovacaoAvaliacao"].ToString();


            return avaliacaoPerformance;
        }
    }
}
