using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class Card
    {
        public string card { get; set; }
        public string cardPath { get; set; }
        public string dataInicio { get; set; }
        public string dataFim { get; set; }

        public static Card CriaObjetoCard(DataRow dr)
        {
            Card card = new Card();
            card.card = dr["strCard"].ToString();
            card.cardPath = dr["strCardPath"].ToString();
            card.dataInicio = dr["dataInicio"].ToString();
            card.dataFim = dr["dataFim"].ToString();

            return card;
        }
    }
}
