using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class Feed
    {
        public string codigoFeedNoticias { get; set; }
        public string strTituloNoticias { get; set; }
        public string strTexto { get; set; }
        public string strImagemPath { get; set; }
        public string dataCriacaoNoticia { get; set; }
        public string createDate { get; set; }
        public string pathImagemFinal { get; set; }
        public string nomePublicador { get; set; }
        public string snEvento { get; set; }
        public string snAtivo { get; set; }
        public string NomeMedicoConfirmaEvento { get; set; }
        public string cpfMedico { get; set; }
        public string codigoConselhoMedico { get; set; }
        public string dataConfirmacaoEvento { get; set; }

        


        public static Feed CriaObjetoFeed(DataRow dr)
        {
            Feed feed = new Feed();
            feed.codigoFeedNoticias = dr["codigoFeedNoticias"].ToString();
            feed.strTituloNoticias = dr["strTituloNoticias"].ToString();
            feed.strTexto = dr["strTexto"].ToString();
            feed.strImagemPath = dr["strImagemPath"].ToString();
            feed.dataCriacaoNoticia = dr["dataCriacaoNoticias"].ToString();
            feed.createDate = dr["createDate"].ToString();
            feed.nomePublicador = dr["nomePublicador"].ToString();
            feed.snEvento = dr["snEvento"].ToString();
            feed.snAtivo = dr["snAtivo"].ToString();
    
            return feed;
        }

        public static Feed CriaObjetoFeedFuncionario(DataRow dr)
        {
            Feed feed = new Feed();
            feed.codigoFeedNoticias = dr["codigoFeedNoticias"].ToString();
            feed.strTituloNoticias = dr["Titulo_Evento"].ToString();
            feed.strTexto = dr["strTexto"].ToString();
            feed.strImagemPath = dr["strImagemPath"].ToString();
            feed.nomePublicador = dr["Autor_Publicacao"].ToString();
            feed.dataCriacaoNoticia = dr["dataCriacaoNoticias"].ToString();
            feed.snEvento = dr["Tipo_Publicacao"].ToString();

            return feed;
        }

        public static Feed CriaObjetoFeedMedicoConfirmacaoEvento(DataRow dr)
        {
            Feed feed = new Feed();
            feed.codigoFeedNoticias = dr["codigoFeedNoticias"].ToString();
            feed.strTituloNoticias = dr["Titulo_Evento"].ToString();
            feed.strTexto = dr["strTexto"].ToString();
            feed.NomeMedicoConfirmaEvento = dr["Medico_Confirma"].ToString();
            feed.cpfMedico = dr["cpfMedicoEvento"].ToString();
            feed.codigoConselhoMedico = dr["codigoConselhoMedicoEvento"].ToString();
            feed.dataCriacaoNoticia = dr["dataCriacaoNoticias"].ToString();
            feed.dataConfirmacaoEvento = dr["dataconfirmacaoevento"].ToString();
            feed.snEvento = dr["snEvento"].ToString();

            return feed;
        }

    }
}
