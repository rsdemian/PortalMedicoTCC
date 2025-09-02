using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class PDF
    {
        public string strPDF { get; set; }
        public string strPathPDF { get; set; }

        public static PDF CriaObjetoPDF(DataRow dr)
        {
            PDF pdf = new PDF();

            pdf.strPDF = dr["strPDF"].ToString();
            pdf.strPathPDF = dr["strPathPDF"].ToString();

            return pdf;
        }
    }
}
