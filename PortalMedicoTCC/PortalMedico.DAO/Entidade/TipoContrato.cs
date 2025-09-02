using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class TipoContrato
    {
        public int codigoTipoContrato { get; set; }
        public string tipoContrato { get; set; }
        public string snAtivo { get; set; }
        public DateTime createDate { get; set; }

        public static TipoContrato CriaObjetoTipoContrato(DataRow dr)
        {
            TipoContrato item = new TipoContrato();
            item.codigoTipoContrato = Convert.ToInt32(dr["codigoTipoContrato"].ToString());
            item.tipoContrato = dr["strTipoContrato"].ToString();
            item.snAtivo = dr["snAtivo"].ToString();
         
            return item;
        }
    }
}
