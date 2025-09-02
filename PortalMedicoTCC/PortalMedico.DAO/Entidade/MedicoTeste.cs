using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class MedicoTeste
    {
        public string tipoSituacao { get; set; }
        public int codigoTipoPrestador { get; set; }
        public string descricaoPrestador { get; set; }
        public string sexo { get; set; }
        public int codigoPrestadorMV { get; set; }
        public string nomeMedicoMV { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string email { get; set; }
        public string dataNascimento { get; set; }
        public string codigoCidade { get; set; }
        public string nomeCidade { get; set; }
        public string numeroEndereco { get; set; }
        public string nomeEndereco { get; set; }
        public string nomeEnderecoComercial { get; set; }
        public string complemento { get; set; }
        public string complementoComercial { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
        public string bairroComercial { get; set; }
        public string cepComercial { get; set; }
        public string numeroEnderecoComercial { get; set; }
        public string codigoConselhoMedico { get; set; } //CRM,CRO,CREFITO ETC
        public string numeroTelefone { get; set; }
        public string numeroTelefoneComercial { get; set; }
        public string dataCadastro { get; set; }
        public string snEspecialidadePrincipal { get; set; }
        public string codigoEspecialidade { get; set; }
        public string especialidade { get; set; }
        public string descricaoConselho { get; set; } // EX: CRMRS99999 "CRMRS + código do Conselho"
        public static MedicoTeste CriaObjetoMedicoTeste(DataRow dr)
        {

            MedicoTeste medicoTeste = new MedicoTeste();

            medicoTeste.tipoSituacao = dr["TP_SITUACAO"].ToString();
            medicoTeste.codigoTipoPrestador = Convert.ToInt32(dr["CD_TIP_PRESTA"].ToString());
            medicoTeste.descricaoPrestador = dr["NM_TIP_PRESTA"].ToString();
            medicoTeste.sexo = dr["TP_SEXO"].ToString();
            medicoTeste.codigoPrestadorMV = Convert.ToInt32(dr["CD_PRESTADOR"].ToString());
            medicoTeste.nomeMedicoMV = dr["NM_PRESTADOR"].ToString();
            medicoTeste.cpf = "SEM DADOS";
            medicoTeste.rg = "SEM DADOS";
            medicoTeste.email = "SEM DADOS";
            medicoTeste.dataNascimento = "SEM DADOS";
            medicoTeste.codigoCidade = "SEM DADOS";
            medicoTeste.nomeCidade = "SEM DADOS";
            medicoTeste.nomeEndereco = "SEM DADOS";
            medicoTeste.nomeEnderecoComercial = "SEM DADOS";
            medicoTeste.numeroEndereco = "SEM DADOS";
            medicoTeste.complemento = "SEM DADOS";
            medicoTeste.complementoComercial = "SEM DADOS";
            medicoTeste.cep = "SEM DADOS";
            medicoTeste.bairro = "SEM DADOS";
            medicoTeste.bairroComercial = "SEM DADOS";
            medicoTeste.cepComercial = "SEM DADOS";
            medicoTeste.numeroEnderecoComercial = "SEM DADOS";
            medicoTeste.codigoConselhoMedico = dr["DS_CODIGO_CONSELHO"].ToString();
            medicoTeste.numeroTelefone = "SEM DADOS";
            medicoTeste.numeroTelefoneComercial = "SEM DADOS";
            medicoTeste.dataCadastro = "SEM DADOS";
            medicoTeste.snEspecialidadePrincipal = "SEM DADOS";
            medicoTeste.codigoEspecialidade = "SEM DADOS";
            medicoTeste.especialidade = "SEM DADOS";
            medicoTeste.descricaoConselho = "SEM DADOS";

            return medicoTeste;
        }
    }
}
