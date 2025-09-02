using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class RetornoMensagem
    {
        public string retornoMensagemSucesso  { get; set; }
        public string retornoMensagemError  { get; set; }


        public static string Mensagem()
        {
            RetornoMensagem item = new RetornoMensagem();
            return item.retornoMensagemSucesso = "SUCESS";
            return item.retornoMensagemError = "ERROR";

          
        }
    }
}
