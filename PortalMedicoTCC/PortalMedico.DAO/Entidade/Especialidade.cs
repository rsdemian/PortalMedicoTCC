using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class Especialidade
    {
        public string codigoEspecialidade { get; set; }
        public string especialidade { get; set; }
      

        public static Especialidade CriaObjetoEspecialidade(DataRow dr)
        {
            Especialidade especialidade = new Especialidade();
            especialidade.codigoEspecialidade = dr["cd_especialid"].ToString();
            especialidade.especialidade = dr["ds_especialid"].ToString();
            
            return especialidade;
        }

    }
}
