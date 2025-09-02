using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class MedicoJubilado
    {
        public string nomeMedico { get; set; }
        public string conselho { get; set; }
        public string especialidade { get; set; }
        public string contatoComercial { get; set; }
        public string contatoPessoal { get; set; }
        public string email { get; set; }
        public string dataCadastro { get; set; }

        public static MedicoJubilado CriaObjetoNomeMedicoJubiladoMV(DataRow dr)
        {
            MedicoJubilado medicoJubilado = new MedicoJubilado();

            medicoJubilado.nomeMedico = dr["Nome_Medico"].ToString();
            medicoJubilado.conselho = dr["CRM"].ToString();
            medicoJubilado.especialidade = dr["Especialidade"].ToString();
            medicoJubilado.contatoComercial = dr["Comercial_Contato"].ToString();
            medicoJubilado.contatoPessoal = dr["nr_fone_contato"].ToString();
            medicoJubilado.email = dr["Email"].ToString();
            medicoJubilado.dataCadastro = dr["Cadastro"].ToString();
           

            return medicoJubilado;
        }
    }
}
