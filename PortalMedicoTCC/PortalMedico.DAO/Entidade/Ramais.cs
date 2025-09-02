using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class Ramais
    {
        public string strNome { get; set; }
        public string ramalNumero { get; set; }
        public string strRamal { get; set; }
        public string strSigla { get; set; }
        public string strSetor { get; set; }


        public static Ramais CriaObjetoRamal(DataRow dr)
        {
            Ramais ramais = new Ramais();

            //ramais.strNome = dr["strNome"].ToString();
            ramais.ramalNumero = dr["intNumero"].ToString();
            //ramais.strRamal = dr["strRamal"].ToString();
            //ramais.strSigla = dr["strSigla"].ToString();
            ramais.strSetor = dr["strSetor"].ToString();

            return ramais;
        }
    }
}
