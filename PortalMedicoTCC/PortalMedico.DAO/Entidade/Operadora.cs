using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class Operadora
    {
        public string operadoraConvenio { get; set; }
        public string unidadeHMD { get; set; }
        public string unidadeUCG { get; set; }
        public string unidadeHSL { get; set; }
        public string unidadeURMD { get; set; }
        public string unidadeCIO { get; set; }
        public string codigoIdentificacao { get; set; }

        public static Operadora CriaObjetoOperadora(DataRow dr)
        {
            Operadora operadora = new Operadora();

            operadora.operadoraConvenio = dr["strOperadora"].ToString();
            operadora.unidadeHMD = dr["strUnidadeHMD"].ToString();
            operadora.unidadeUCG = dr["strUnidadeUCG"].ToString();
            operadora.unidadeHSL = dr["strUnidadeHSL"].ToString();
            operadora.unidadeURMD = dr["strUnidadeURMD"].ToString();
            operadora.unidadeCIO = dr["strUnidadeCIO"].ToString();
          
            return operadora;
        }

        public static Operadora CriaObjetoOperadoraConvenio(DataRow dr)
        {
            Operadora operadora = new Operadora();

            operadora.operadoraConvenio = dr["strOperadora"].ToString();
            operadora.codigoIdentificacao = dr["codigoIdentificacao"].ToString();

            return operadora;
        }
    }
}
