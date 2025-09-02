using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class Log
    {
        public string nomeMedicoExterno { get; set; }
        public string descricaoLog { get; set; }
        public string descricaoMetodo { get; set; }
        public string createDate { get; set; }


        public static Log CriaObjetoLogErro(DataRow dr)
        {
            Log log = new Log();
            log.nomeMedicoExterno = dr["nomeMedico"].ToString();
            log.descricaoLog = dr["strLog"].ToString().Substring(0,30);
            log.descricaoMetodo = dr["strMetodo"].ToString();
            log.createDate = dr["createDate"].ToString();

            return log;
        }
    }
}
