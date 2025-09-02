using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalMedico.DAO.Entidade
{
    public class FichaConcessao
    {
        public string strNomeMedico { get; set; }
        public string conselhoMedico { get; set; }
        public string totalMedicosMV { get; set; }
        public string totalMedicosFichaConcessao { get; set; }
        public string strPrivilegiosClinicos { get; set; }
        public string strPrivilegiosPediatricos { get; set; }
        public string strPrivilegiosGinecologicos { get; set; }
        public string strPrivilegiosCirurgicos { get; set; }
        public string strProcedimentosEspeciais { get; set; }
        public string strEspecialidades { get; set; }
        public string strRadiologiaIntervencionistaAngiorradiologia { get; set; }
        public string strTMO { get; set; }
        public string strEndoscopiaColonoscopia { get; set; }
        public string strDor { get; set; }
        public string strHemodialise { get; set; }
        public string strGenetica { get; set; }
        public string strCardiologiaIntervencionista { get; set; }
        public string strProcedimentos { get; set; }
        public string strQuimioterapia { get; set; }
        public string strRadioterapia { get; set; }
        public string strAnestesia { get; set; }
        public string strMedicinaPaliativa { get; set; }
        public string strNeuroradiologia { get; set; }
        public string strCirurgiaVideo { get; set; }
        public string strLaudarExamesRadiologiaLaboratorioEndoscopia { get; set; }
        public string strLaserterapia { get; set; }
        public string strPassagemCateterVenosoCentral { get; set; }
        public string strIntubacaoOrotraqueal { get; set; }
        public string strToracocentese { get; set; }
        public string strParacentese { get; set; }
        public string strPericardiocentese { get; set; }
        public string strCirurgiaRobotica { get; set; }
        public string strDrenagemTorax { get; set; }
        public string strNutricaoParenteral { get; set; }
        public string strPassagemMarcapassoTransvenoso { get; set; }
        public string strPossuiCompetencia { get; set; }
        public string strNaoPossuiCompetencia { get; set; }

        public string strLaudarCardiologicos { get; set; }
        public string strLaudarEndoscopicos { get; set; }
        public string strLaudarRadiologicos { get; set; }
        public string strLaudarHematoOncologicos { get; set; }

        public static FichaConcessao CriaObjetoFicha(DataRow dr)
        {
            FichaConcessao fichaConcessao = new FichaConcessao();


            fichaConcessao.strPrivilegiosClinicos = dr["strPrivilegiosClinicos"].ToString();
            fichaConcessao.strPrivilegiosPediatricos = dr["strPrivilegiosPediatricos"].ToString();
            fichaConcessao.strPrivilegiosGinecologicos = dr["strPrivilegiosGinecologicos"].ToString();
            fichaConcessao.strPrivilegiosCirurgicos = dr["strPrivilegiosCirurgicos"].ToString();
            fichaConcessao.strProcedimentosEspeciais = dr["strProcedimentosEspeciais"].ToString();
            fichaConcessao.strRadiologiaIntervencionistaAngiorradiologia = dr["strRadiologiaIntervencionistaAngiorradiologia"].ToString();
            fichaConcessao.strTMO = dr["strTMO"].ToString();
            fichaConcessao.strEndoscopiaColonoscopia = dr["strEndoscopiaColonoscopia"].ToString();
            fichaConcessao.strDor = dr["strDor"].ToString();
            fichaConcessao.strHemodialise = dr["strHemodialise"].ToString();
            fichaConcessao.strGenetica = dr["strGenetica"].ToString();
            fichaConcessao.strCardiologiaIntervencionista = dr["strCardiologiaIntervencionista"].ToString();
            fichaConcessao.strProcedimentos = dr["strProcedimentos"].ToString();
            fichaConcessao.strQuimioterapia = dr["strQuimioterapia"].ToString();
            fichaConcessao.strRadioterapia = dr["strRadioterapia"].ToString();
            fichaConcessao.strAnestesia = dr["strAnestesia"].ToString();
            fichaConcessao.strMedicinaPaliativa = dr["strMedicinaPaliativa"].ToString();
            fichaConcessao.strNeuroradiologia = dr["strNeuroradiologia"].ToString();
            fichaConcessao.strCirurgiaVideo = dr["strCirurgiaVideo"].ToString();
            fichaConcessao.strLaserterapia = dr["strLaserterapia"].ToString();
            fichaConcessao.strPassagemCateterVenosoCentral = dr["strPassagemCateterVenosoCentral"].ToString();
            fichaConcessao.strIntubacaoOrotraqueal = dr["strIntubacaoOrotraqueal"].ToString();
            fichaConcessao.strToracocentese = dr["strToracocentese"].ToString();
            fichaConcessao.strParacentese = dr["strParacentese"].ToString();
            fichaConcessao.strPericardiocentese = dr["strPericardiocentese"].ToString();

            fichaConcessao.strCirurgiaRobotica = dr["strCirurgiaRobotica"].ToString();
            fichaConcessao.strDrenagemTorax = dr["strDrenagemTorax"].ToString();
            fichaConcessao.strNutricaoParenteral = dr["strNutricaoParenteral"].ToString();
            fichaConcessao.strPassagemMarcapassoTransvenoso = dr["strPassagemMarcapassoTransvenoso"].ToString();

            fichaConcessao.strLaudarCardiologicos = dr["strLaudarCardiologicos"].ToString();
            fichaConcessao.strLaudarEndoscopicos = dr["strLaudarEndoscopicos"].ToString();
            fichaConcessao.strLaudarRadiologicos = dr["strLaudarRadiologicos"].ToString();
            fichaConcessao.strLaudarHematoOncologicos = dr["strLaudarHematoOncologicos"].ToString();



            fichaConcessao.strEspecialidades = dr["strEspecialidades"].ToString();
          
            return fichaConcessao;
        }

        public static FichaConcessao CriaObjetoFichaComNome(DataRow dr)
        {
            FichaConcessao fichaConcessao = new FichaConcessao();


            fichaConcessao.strNomeMedico = dr["strNomeMedico"].ToString();
            fichaConcessao.strPrivilegiosClinicos = dr["PrivilegioClinico"].ToString();
            fichaConcessao.strPrivilegiosPediatricos = dr["PrivilegioPediatrico"].ToString();
            fichaConcessao.strPrivilegiosGinecologicos = dr["PrivilegioGinecologicos"].ToString();
            fichaConcessao.strPrivilegiosCirurgicos = dr["PrivilegioCirurgicos"].ToString();
            fichaConcessao.strProcedimentosEspeciais = dr["PrivilegioProcedimentosEspeciais"].ToString();
            fichaConcessao.strRadiologiaIntervencionistaAngiorradiologia = dr["RadiologiaIntervencionista"].ToString();
            fichaConcessao.strTMO = dr["TMO"].ToString();
            fichaConcessao.strEndoscopiaColonoscopia = dr["EndoscopiaColonoscopia"].ToString();
            fichaConcessao.strDor = dr["Dor"].ToString();
            fichaConcessao.strHemodialise = dr["Hemodialise"].ToString();
            fichaConcessao.strGenetica = dr["Genetica"].ToString();
            fichaConcessao.strCardiologiaIntervencionista = dr["CardiologiaIntervencionista"].ToString();
            fichaConcessao.strProcedimentos = dr["Procedimentos"].ToString();
            fichaConcessao.strQuimioterapia = dr["Quimioterapia"].ToString();
            fichaConcessao.strRadioterapia = dr["Radioterapia"].ToString();
            fichaConcessao.strAnestesia = dr["Anestesia"].ToString();
            fichaConcessao.strMedicinaPaliativa = dr["MedicinaPaliativa"].ToString();
            fichaConcessao.strNeuroradiologia = dr["NeuroRadiologia"].ToString();
            fichaConcessao.strCirurgiaVideo = dr["CirurgiaVideo"].ToString();
            fichaConcessao.strLaserterapia = dr["Laserterapia"].ToString();
            fichaConcessao.strPassagemCateterVenosoCentral = dr["PassagemCateter"].ToString();
            fichaConcessao.strIntubacaoOrotraqueal = dr["IntubacaoOrotraqueal"].ToString();
            fichaConcessao.strToracocentese = dr["Toracocentese"].ToString();
            fichaConcessao.strParacentese = dr["Paracentese"].ToString();
            fichaConcessao.strPericardiocentese = dr["Pericardiocentese"].ToString();

            fichaConcessao.strCirurgiaRobotica = dr["CirurgiaRobotica"].ToString();
            fichaConcessao.strDrenagemTorax = dr["DrenagemTorax"].ToString();
            fichaConcessao.strNutricaoParenteral = dr["NutricaoParenteral"].ToString();
            fichaConcessao.strPassagemMarcapassoTransvenoso = dr["PassagemMarcapassoTransvenoso"].ToString();

            fichaConcessao.strLaudarCardiologicos = dr["LaudarExamesCardiologicos"].ToString();
            fichaConcessao.strLaudarEndoscopicos = dr["LaudarExamesEndoscopicos"].ToString();
            fichaConcessao.strLaudarRadiologicos = dr["LaudarExamesRadiologicos"].ToString();
            fichaConcessao.strLaudarHematoOncologicos = dr["LaudarExamesHematoOncologicos"].ToString();

            return fichaConcessao;
        }

        public static FichaConcessao CriaObjetoFichaGeral(DataRow dr)
        {
            FichaConcessao fichaConcessao = new FichaConcessao();

            fichaConcessao.conselhoMedico = dr["codConselhoMedico"].ToString();
            fichaConcessao.strPrivilegiosClinicos = dr["PrivilegioClinico"].ToString();
            fichaConcessao.strPrivilegiosPediatricos = dr["PrivilegioPediatrico"].ToString();
            fichaConcessao.strPrivilegiosGinecologicos = dr["PrivilegioGinecologicos"].ToString();
            fichaConcessao.strPrivilegiosCirurgicos = dr["PrivilegioCirurgicos"].ToString();
            fichaConcessao.strProcedimentosEspeciais = dr["PrivilegioProcedimentosEspeciais"].ToString();
            fichaConcessao.strRadiologiaIntervencionistaAngiorradiologia = dr["RadiologiaIntervencionista"].ToString();
            fichaConcessao.strTMO = dr["TMO"].ToString();
            fichaConcessao.strEndoscopiaColonoscopia = dr["EndoscopiaColonoscopia"].ToString();
            fichaConcessao.strDor = dr["Dor"].ToString();
            fichaConcessao.strHemodialise = dr["Hemodialise"].ToString();
            fichaConcessao.strGenetica = dr["Genetica"].ToString();
            fichaConcessao.strCardiologiaIntervencionista = dr["CardiologiaIntervencionista"].ToString();
            fichaConcessao.strProcedimentos = dr["Procedimentos"].ToString();
            fichaConcessao.strQuimioterapia = dr["Quimioterapia"].ToString();
            fichaConcessao.strRadioterapia = dr["Radioterapia"].ToString();
            fichaConcessao.strAnestesia = dr["Anestesia"].ToString();
            fichaConcessao.strMedicinaPaliativa = dr["MedicinaPaliativa"].ToString();
            fichaConcessao.strNeuroradiologia = dr["NeuroRadiologia"].ToString();
            fichaConcessao.strCirurgiaVideo = dr["CirurgiaVideo"].ToString();
            fichaConcessao.strLaserterapia = dr["Laserterapia"].ToString();
            fichaConcessao.strPassagemCateterVenosoCentral = dr["PassagemCateter"].ToString();
            fichaConcessao.strIntubacaoOrotraqueal = dr["IntubacaoOrotraqueal"].ToString();
            fichaConcessao.strToracocentese = dr["Toracocentese"].ToString();
            fichaConcessao.strParacentese = dr["Paracentese"].ToString();
            fichaConcessao.strPericardiocentese = dr["Pericardiocentese"].ToString();

            fichaConcessao.strCirurgiaRobotica = dr["CirurgiaRobotica"].ToString();
            fichaConcessao.strDrenagemTorax = dr["DrenagemTorax"].ToString();
            fichaConcessao.strNutricaoParenteral = dr["NutricaoParenteral"].ToString();
            fichaConcessao.strPassagemMarcapassoTransvenoso = dr["PassagemMarcapassoTransvenoso"].ToString();

            fichaConcessao.strLaudarCardiologicos = dr["LaudarExamesCardiologicos"].ToString();
            fichaConcessao.strLaudarEndoscopicos = dr["LaudarExamesEndoscopicos"].ToString();
            fichaConcessao.strLaudarRadiologicos = dr["LaudarExamesRadiologicos"].ToString();
            fichaConcessao.strLaudarHematoOncologicos = dr["LaudarExamesHematoOncologicos"].ToString();

            return fichaConcessao;
        }

        public static FichaConcessao CriaObjetoFichaConcessaoTotal(DataRow dr)
        {
            FichaConcessao fichaConcessao = new FichaConcessao();

            fichaConcessao.totalMedicosFichaConcessao = dr["TotalMedicos"].ToString();
           
            return fichaConcessao;
        }

        public static FichaConcessao CriaObjetoFichaPorCompetencias(DataRow dr)
        {
            FichaConcessao fichaConcessao = new FichaConcessao();

            fichaConcessao.strNomeMedico = dr["strNomeMedico"].ToString();
            fichaConcessao.strPossuiCompetencia = dr["Competencias_Possui"].ToString();
            fichaConcessao.strNaoPossuiCompetencia = dr["Competencias_Nao_Possui"].ToString();

            return fichaConcessao;
        }
    }
}
