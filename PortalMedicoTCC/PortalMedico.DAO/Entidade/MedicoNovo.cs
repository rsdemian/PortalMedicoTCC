using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class MedicoNovo
    {
        public int codigoMedicoCPESPSFI { get; set; }
        public string nomeMedico { get; set; }
        public int CRM { get; set; }
        public int codigoPrestadorMV  { get; set; }
        public string CPF  { get; set; }
        public int RG  { get; set; }
        public string sexo  { get; set; }
        public string pais  { get; set; }
        public int codigoEspecialidade  { get; set; }
        public int codigoStatus { get; set; }
        public int codigoCategoriaProfissao { get; set; }
        public int codigoTipoContrato { get; set; }
        public int codigoEndereco { get; set; }
        public int telefoneCelular { get; set; }
        public int telefoneConsultorio { get; set; }
        public string email { get; set; }
        public string ArquivoFoto { get; set; }
        public DateTime dataNascimento { get; set; }
        public DateTime dataInclusao { get; set; }
        public DateTime dataAlteracao { get; set; }
        public string snAtivo { get; set; }

        public static MedicoNovo CriaObjetoMedicoNovo(DataRow dr)
        {
            MedicoNovo item = new MedicoNovo();
            item.codigoMedicoCPESPSFI = Convert.ToInt32(dr["codigoMedicoCPESPSFI"].ToString());
            item.nomeMedico = dr["strNome"].ToString();
            item.CRM = Convert.ToInt32(dr["strCRM"].ToString());
            item.codigoPrestadorMV = Convert.ToInt32(dr["codPrestadorMV"].ToString());
            item.CPF = dr["strCPF"].ToString();
            item.RG = Convert.ToInt32(dr["strRG"].ToString());
            item.sexo = dr["strSexo"].ToString();   
            item.pais = dr["strPais"].ToString();   
            item.codigoEspecialidade = Convert.ToInt32(dr["codigoEspecialidade"].ToString());
            item.codigoStatus = Convert.ToInt32(dr["codigoStatus"].ToString());
            item.codigoCategoriaProfissao = Convert.ToInt32(dr["codigoCategoriaProfissao"].ToString());
            item.codigoTipoContrato = Convert.ToInt32(dr["codigoTipoContrato"].ToString());
            item.codigoEndereco = Convert.ToInt32(dr["codigoEndereco"].ToString());
            item.telefoneCelular = Convert.ToInt32(dr["strTelefoneCelular"].ToString());
            item.telefoneConsultorio = Convert.ToInt32(dr["strTelefoneConsultorio"].ToString());
            item.email = dr["strEmail"].ToString();
            item.ArquivoFoto = dr["strArquivoFoto"].ToString();
            item.dataNascimento = Convert.ToDateTime(dr["dataNascimento"].ToString());
            item.dataInclusao = Convert.ToDateTime(dr["dataInclusao"].ToString());
            item.dataAlteracao = Convert.ToDateTime(dr["dataAlteracao"].ToString());
            item.snAtivo = dr["snAtivo"].ToString();
           
            return item;
        }

     
        ///===================== INFORMAÇÕES DE ESPECIALIDADE, STATUS , ENDERECO E TELEFONE
    }
}
