using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class CategoriaProfissao
    {
        public int codigoTipoContrato  { get; set; }
        public string nomeTipoContrato  { get; set; }
        public string snAtivo  { get; set; }
        public DateTime createDate  { get; set; }

        public static CategoriaProfissao CriaObjetoCategoriaProfissao(DataRow dr)
        {
            CategoriaProfissao item = new CategoriaProfissao();
            item.codigoTipoContrato = Convert.ToInt32(dr["codigoTipoContrato"].ToString());
            item.nomeTipoContrato = dr["strCategoriaProfissao"].ToString();
            item.snAtivo = dr["snAtivo"].ToString();
          
            return item;
        }
    }
}
