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
    public class DocumentoMedico
    {
        public string strNomeDocumento { get; set; }
        public string strPathDocumento { get; set; }


        public int codDocumentacao { get; set; }
        public int codigoConselhoMedico { get; set; }
        public int codigoPrestador { get; set; }
        public string strNomeMedico { get; set; }
        public string strEmail { get; set; }
        public string strDescricaoDocumento { get; set; }
        public string strFormularioRequerimento { get; set; }
        public string strAssinaturaTermoConcordancia { get; set; }
        public string strFoto { get; set; }
        public string strCurriculo { get; set; }
        public string strCarteiraCREMERS { get; set; }
        public string strDiploma { get; set; }
        public string strCartaRecomendacao { get; set; }
        public string strCartaRecomendacaoDois { get; set; }
        public string strCertificadoEspecialidade { get; set; }
        public string strCertificadoOrtopediaTraumato { get; set; }
        public string strCertificadoGinecologiaObstetricia { get; set; }
        public string strCertidaoRegularidadeCREMERS { get; set; }
        public string strCertidaoRQECREMERS { get; set; }
        public string strCertidaoEticaProCREMERS { get; set; }
        public string strCertidaoRegularidadeFinanceira { get; set; }
        public string strComprovanteVacina { get; set; }
        public string strFichaConcessao { get; set; }
        public string strCertificadoBLSACLS { get; set; }
        public string createDate { get; set; }
        public string dataCadastro { get; set; }// CREDENCIAMENTO
        public string dataRecadastro { get; set; }// CREDENCIAMENTO
        public string dataExpiraCadastro { get; set; }
        public int codStatusCadastro { get; set; }
        public string statusCadastro { get; set; }
        public string strVinculo { get; set; }
        public string strEspecialidade { get; set; }
        public string DataExpiracaoFichaConcessao { get; set; }

        public static DocumentoMedico CriaObjetoDocumentacaoCredenciamentoMedico(DataRow dr)
        {
            DocumentoMedico documentacaoCredenciamento = new DocumentoMedico();

            documentacaoCredenciamento.codigoConselhoMedico = Convert.ToInt32(dr["codConselhoMedico"].ToString());
            documentacaoCredenciamento.strNomeMedico = dr["strNomeMedico"].ToString();
            documentacaoCredenciamento.strEmail = dr["strEmail"].ToString();
            documentacaoCredenciamento.strFormularioRequerimento = dr["strFormularioRequerimento"].ToString();
            documentacaoCredenciamento.strAssinaturaTermoConcordancia = dr["strAssinaturaTermoConcordancia"].ToString();
            documentacaoCredenciamento.strFoto = dr["strFoto"].ToString();
            documentacaoCredenciamento.strCurriculo = dr["strCurriculo"].ToString();
            documentacaoCredenciamento.strCarteiraCREMERS = dr["strCarteiraCREMERS"].ToString();
            documentacaoCredenciamento.strDiploma = dr["strDiploma"].ToString();
            documentacaoCredenciamento.strCartaRecomendacao = dr["strCartaRecomendacaoUm"].ToString();
            documentacaoCredenciamento.strCartaRecomendacaoDois = dr["strCartaRecomendacaoDois"].ToString();
            documentacaoCredenciamento.strCertificadoEspecialidade = dr["strCertificadoEspecialidade"].ToString();
            documentacaoCredenciamento.strCertidaoRegularidadeCREMERS = dr["strCertidaoRegularidadeCREMERS"].ToString();
            documentacaoCredenciamento.strCertidaoRQECREMERS = dr["strCertidaoRQECREMERS"].ToString();
            documentacaoCredenciamento.strCertidaoEticaProCREMERS = dr["strCertidaoEticaProCREMERS"].ToString();
            documentacaoCredenciamento.strCertidaoRegularidadeFinanceira = dr["strCertidaoRegularidadeFinanceira"].ToString();
            documentacaoCredenciamento.strComprovanteVacina = dr["strComprovanteVacina"].ToString();
            documentacaoCredenciamento.strFichaConcessao = dr["strFichaConcessao"].ToString();
            documentacaoCredenciamento.strCertificadoBLSACLS = dr["strCertificadoBLSACLS"].ToString();
            //documentacaoCredenciamento.createDate = Convert.ToDateTime(dr["createDate"].ToString());
            documentacaoCredenciamento.dataCadastro = dr["dataCadastro"].ToString();
            documentacaoCredenciamento.dataExpiraCadastro = dr["dataExpiraCadastro"].ToString();
            //documentacaoCredenciamento.codStatusCadastro = Convert.ToInt32(dr["codStatusCadastro"].ToString());
            documentacaoCredenciamento.statusCadastro = dr["strStatusCadastro"].ToString();
            documentacaoCredenciamento.DataExpiracaoFichaConcessao = dr["dataExpiraFichaConcessao"].ToString();


            if (dr["strVinculo"].ToString() == "Ambos")
            {
                documentacaoCredenciamento.strVinculo = "CLT/Credenciado";
            }
            else
            {
                documentacaoCredenciamento.strVinculo = dr["strVinculo"].ToString();
            }

            documentacaoCredenciamento.strEspecialidade = dr["strEspecialidadeMedica"].ToString();

            return documentacaoCredenciamento;

        }

        public static DocumentoMedico CriaObjetoDocumentacaoCredenciamentoMedicoVisaoGestor(DataRow dr)
        {
            DocumentoMedico documentacaoCredenciamento = new DocumentoMedico();

            documentacaoCredenciamento.codigoConselhoMedico = Convert.ToInt32(dr["codConselhoMedico"].ToString());
            documentacaoCredenciamento.strNomeMedico = dr["strNomeMedico"].ToString();
            documentacaoCredenciamento.strEmail = dr["strEmail"].ToString();
            documentacaoCredenciamento.strFormularioRequerimento = dr["strFormularioRequerimento"].ToString();
            documentacaoCredenciamento.strAssinaturaTermoConcordancia = dr["strAssinaturaTermoConcordancia"].ToString();
            documentacaoCredenciamento.strFoto = dr["strFoto"].ToString();
            documentacaoCredenciamento.strCurriculo = dr["strCurriculo"].ToString();
            documentacaoCredenciamento.strCarteiraCREMERS = dr["strCarteiraCREMERS"].ToString();
            documentacaoCredenciamento.strDiploma = dr["strDiploma"].ToString();
            documentacaoCredenciamento.strCartaRecomendacao = dr["strCartaRecomendacaoUm"].ToString();
            documentacaoCredenciamento.strCartaRecomendacaoDois = dr["strCartaRecomendacaoDois"].ToString();
            documentacaoCredenciamento.strCertificadoEspecialidade = dr["strCertificadoEspecialidade"].ToString();
            documentacaoCredenciamento.strCertidaoRegularidadeCREMERS = dr["strCertidaoRegularidadeCREMERS"].ToString();
            documentacaoCredenciamento.strCertidaoRQECREMERS = dr["strCertidaoRQECREMERS"].ToString();
            documentacaoCredenciamento.strCertidaoEticaProCREMERS = dr["strCertidaoEticaProCREMERS"].ToString();
            documentacaoCredenciamento.strCertidaoRegularidadeFinanceira = dr["strCertidaoRegularidadeFinanceira"].ToString();
            documentacaoCredenciamento.strComprovanteVacina = dr["strComprovanteVacina"].ToString();
            documentacaoCredenciamento.strFichaConcessao = dr["strFichaConcessao"].ToString();
            documentacaoCredenciamento.strCertificadoBLSACLS = dr["strCertificadoBLSACLS"].ToString();
            //documentacaoCredenciamento.createDate = Convert.ToDateTime(dr["createDate"].ToString());
            documentacaoCredenciamento.dataCadastro = dr["dataCadastro"].ToString();
            documentacaoCredenciamento.dataExpiraCadastro = dr["dataExpiraCadastro"].ToString();
            //documentacaoCredenciamento.codStatusCadastro = Convert.ToInt32(dr["codStatusCadastro"].ToString());
            documentacaoCredenciamento.statusCadastro = dr["strStatusCadastro"].ToString();
            documentacaoCredenciamento.strDescricaoDocumento = dr["strDescricaoDocumento"].ToString();
            documentacaoCredenciamento.DataExpiracaoFichaConcessao = dr["dataExpiraFichaConcessao"].ToString();

            if (dr["strVinculo"].ToString() == "Ambos")
            {
                documentacaoCredenciamento.strVinculo = "CLT/Credenciado";
            }
            else
            {
                documentacaoCredenciamento.strVinculo = dr["strVinculo"].ToString();
            }

            documentacaoCredenciamento.strEspecialidade = dr["strEspecialidadeMedica"].ToString();

            return documentacaoCredenciamento;

        }

        public static DocumentoMedico CriaObjetoDocumentacaoCredenciamentoMedicoExterno(DataRow dr)
        {
            DocumentoMedico documentacaoCredenciamento = new DocumentoMedico();

            documentacaoCredenciamento.codigoConselhoMedico = Convert.ToInt32(dr["codConselhoMedico"].ToString());
            documentacaoCredenciamento.strNomeMedico = dr["strNomeMedico"].ToString();
            documentacaoCredenciamento.statusCadastro = dr["strStatusCadastro"].ToString();

            return documentacaoCredenciamento;

        }

        public static DocumentoMedico CriaObjetoMedicoRecadastro(DataRow dr)
        {
            DocumentoMedico documentacaoCredenciamento = new DocumentoMedico();

            documentacaoCredenciamento.codigoConselhoMedico = Convert.ToInt32(dr["codConselhoMedico"].ToString());
            documentacaoCredenciamento.codigoPrestador = Convert.ToInt32(dr["codPrestador"].ToString());
            documentacaoCredenciamento.strNomeMedico = dr["strNomeMedico"].ToString();
            documentacaoCredenciamento.statusCadastro = dr["strStatusCadastro"].ToString();

            return documentacaoCredenciamento;

        }

        public static DocumentoMedico CriaObjetoDocumentacaoRecadastroMedico(DataRow dr)
        {
            DocumentoMedico documentacaoCredenciamento = new DocumentoMedico();

            documentacaoCredenciamento.codigoConselhoMedico = Convert.ToInt32(dr["codConselhoMedico"].ToString());
            documentacaoCredenciamento.strFormularioRequerimento = dr["strFormularioRequerimento"].ToString();
            documentacaoCredenciamento.strAssinaturaTermoConcordancia = dr["strAssinaturaTermoConcordancia"].ToString();
            documentacaoCredenciamento.strFoto = dr["strFoto"].ToString();
            documentacaoCredenciamento.strCurriculo = dr["strCurriculo"].ToString();
            documentacaoCredenciamento.strCarteiraCREMERS = dr["strCarteiraCREMERS"].ToString();
            documentacaoCredenciamento.strDiploma = dr["strDiploma"].ToString();
            documentacaoCredenciamento.strCartaRecomendacao = dr["strCartaRecomendacao"].ToString();
            documentacaoCredenciamento.strCertificadoEspecialidade = dr["strCertificadoEspecialidade"].ToString();
            documentacaoCredenciamento.strCertidaoRegularidadeCREMERS = dr["strCertidaoRegularidadeCREMERS"].ToString();
            documentacaoCredenciamento.strCertidaoRQECREMERS = dr["strCertidaoRQECREMERS"].ToString();
            documentacaoCredenciamento.strCertidaoEticaProCREMERS = dr["strCertidaoEticaProCREMERS"].ToString();
            documentacaoCredenciamento.strCertidaoRegularidadeFinanceira = dr["strCertidaoRegularidadeFinanceira"].ToString();
            documentacaoCredenciamento.strComprovanteVacina = dr["strComprovanteVacina"].ToString();
            //documentacaoCredenciamento.createDate = Convert.ToDateTime(dr["createDate"].ToString());
            documentacaoCredenciamento.dataRecadastro = dr["dataReCadastro"].ToString();
            documentacaoCredenciamento.dataExpiraCadastro = dr["dataExpiraCadastro"].ToString();
            //documentacaoCredenciamento.codStatusCadastro = Convert.ToInt32(dr["codStatusCadastro"].ToString());
            documentacaoCredenciamento.statusCadastro = dr["strStatusCadastro"].ToString();


            return documentacaoCredenciamento;

        }
        public static DocumentoMedico CriaObjetoDocumentacaoMedica(DataRow dr)
        {
            DocumentoMedico item = new DocumentoMedico();

            item.strNomeDocumento = dr["strNomeDocumento"].ToString();
            item.strPathDocumento = dr["strPathDocumento"].ToString();

            return item;
        }

        public static DocumentoMedico CriaObjetoDataExpiracaoFichaConcessao(DataRow dr)
        {
            DocumentoMedico item = new DocumentoMedico();

            item.DataExpiracaoFichaConcessao = dr["dataExpiraFichaConcessao"].ToString();

            return item;
        }
    }
}
