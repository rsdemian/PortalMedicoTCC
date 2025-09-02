using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class Link
    {
        public string codLink { get; set; }
        public string strNomeLink { get; set; }
        public string strLink { get; set; }
        public static Link CriaObjeto(DataRow dr)
        {
            Link link = new Link();
            link.codLink = dr["codLink"].ToString();
            link.strNomeLink = dr["strNomeLink"].ToString();
            link.strLink = dr["strLink"].ToString();

            return link;
        }
    }
}
