using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class Protocolo
    {
        public int codProtocolo { get; set; }
        public string strProtocolo { get; set; }
        public string strProtocoloPath { get; set; }
        public string snAtivo { get; set; }
        public DateTime createDate { get; set; }

        public static Protocolo CriaObjetoProtocolo(DataRow dr)
        {
            Protocolo protocolo = new Protocolo();

            protocolo.codProtocolo = Convert.ToInt32(dr["codProtocolo"].ToString());
            protocolo.strProtocolo = dr["strProtocolo"].ToString();
            protocolo.strProtocoloPath = dr["strProtocoloPath"].ToString();
            protocolo.snAtivo = dr["snAtivo"].ToString();
            protocolo.createDate = Convert.ToDateTime(dr["createDate"].ToString());

            return protocolo;

        }
    }
}
