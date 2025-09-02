using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class Credenciamento
    {
        public string strNomeMedico { get; set; }
        public string strEspecialidadeMedica { get; set; }
        public string statusAprovacaoAreaMedica { get; set; }
        public string mensagem { get; set; }
        public string statusMedico { get; set; }
        public string tipoMedico { get; set; }
        public string dataCadastro { get; set; }

        public string qtdPendentesAprovacaoAreaMedica { get; set; }
        public string qtdAprovadosAreaMedica { get; set; }
        public string qtdAprovadosMedicoAprovador { get; set; }
        public string qtdReprovados { get; set; }
     
        public static Credenciamento CriaObjetoCredenciamento(DataRow dr)
        {
            Credenciamento credenciamento = new Credenciamento();

            credenciamento.strNomeMedico = dr["strNomeMedico"].ToString();
            credenciamento.strEspecialidadeMedica = dr["strEspecialidadeMedica"].ToString();
            credenciamento.statusAprovacaoAreaMedica = dr["status_aprovacao_area_medica"].ToString();
            credenciamento.mensagem = dr["mensagem"].ToString();
            credenciamento.statusMedico = dr["status_medico"].ToString();
            credenciamento.tipoMedico = dr["tipoMedicoAprovador"].ToString();


            return credenciamento;

        }

        public static Credenciamento CriaObjetoCredenciamentoModal(DataRow dr)
        {
            Credenciamento credenciamento = new Credenciamento();

            credenciamento.strNomeMedico = dr["strNomeMedico"].ToString();
            credenciamento.strEspecialidadeMedica = dr["strEspecialidadeMedica"].ToString();
            credenciamento.statusAprovacaoAreaMedica = dr["status_aprovacao_area_medica"].ToString();
            credenciamento.mensagem = dr["mensagem"].ToString();
            credenciamento.statusMedico = dr["status_medico"].ToString();
            credenciamento.tipoMedico = dr["tipoMedicoAprovador"].ToString();
            credenciamento.dataCadastro = dr["dataCadastro"].ToString();


            return credenciamento;

        }

        public static Credenciamento CriaObjetoCredenciamentoPizza(DataRow dr)
        {
            Credenciamento credenciamento = new Credenciamento();

            credenciamento.qtdPendentesAprovacaoAreaMedica = dr["quantidade_pendentes_aprovacao_area_medica"].ToString();
            credenciamento.qtdAprovadosAreaMedica = dr["quantidade_aprovados_area_medica"].ToString();
            credenciamento.qtdAprovadosMedicoAprovador = dr["quantidade_aprovados_por_medico_aprovador"].ToString();
            credenciamento.qtdReprovados = dr["quantidade_reprovados"].ToString();
       


            return credenciamento;

        }
    }
}
