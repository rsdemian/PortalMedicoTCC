using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Web;

namespace PortalMedico.DAO.Entidade
{
    public class Metodo
    {
        public string CriaArquivo(string base64String, string fileName, string conselho, int contador)
        {
            byte[] fileBytes = Convert.FromBase64String(base64String);
            string filePathFull = ConfigurationManager.AppSettings["FilePathDocumentacaoRecadastro"].ToString() + fileName.ToString();
            string filePath = ConfigurationManager.AppSettings["FilePathDocumentacaoRecadastro"].ToString();



            if (!Directory.Exists(filePath + "\\" + conselho.ToString()))
            {
                Directory.CreateDirectory(filePath + "\\" + conselho.ToString());

                File.WriteAllBytes(filePath + "\\" + conselho.ToString() + "\\" + fileName.ToString(), fileBytes);

                return "SUCESS";
            }
            else
            {
                if (File.Exists(filePath + "\\" + conselho.ToString() + "\\" + fileName.ToString()))
                {
                    File.WriteAllBytes(filePath + "\\" + conselho.ToString() + "\\" + "v" + contador + "_" + fileName.ToString(), fileBytes);
                    return "SUCESS";
                }
                else
                {
                    File.WriteAllBytes(filePath + "\\" + conselho.ToString() + "\\" + fileName.ToString(), fileBytes);
                    return "SUCESS";
                }

            }
        }
        public string CriaArquivo(string base64String, string fileName, string conselho, int contador, string tipoTela)
        {
            if (tipoTela == "CREDENCIAMENTO")
            {
                byte[] fileBytes = Convert.FromBase64String(base64String);
                string filePathFull = ConfigurationManager.AppSettings["FilePathDocumentacao"].ToString() + fileName.ToString();
                string filePath = ConfigurationManager.AppSettings["FilePathDocumentacao"].ToString();



                if (!Directory.Exists(filePath + "\\" + conselho.ToString()))
                {
                    Directory.CreateDirectory(filePath + "\\" + conselho.ToString());

                    File.WriteAllBytes(filePath + "\\" + conselho.ToString() + "\\" + fileName.ToString(), fileBytes);

                    return "SUCESS";
                }
                else
                {
                    if (File.Exists(filePath + "\\" + conselho.ToString() + "\\" + fileName.ToString()))
                    {
                        File.WriteAllBytes(filePath + "\\" + conselho.ToString() + "\\" + "v" + contador + "_" + fileName.ToString(), fileBytes);
                        return "SUCESS";
                    }
                    else
                    {
                        File.WriteAllBytes(filePath + "\\" + conselho.ToString() + "\\" + fileName.ToString(), fileBytes);
                        return "SUCESS";
                    }

                }
            }
            else if (tipoTela == "TERMO")
            {
                byte[] fileBytes = Convert.FromBase64String(base64String);
                string filePathFull = ConfigurationManager.AppSettings["FilePathTermo"].ToString() + fileName.ToString();
                string filePath = ConfigurationManager.AppSettings["FilePathTermo"].ToString();


                if (File.Exists(filePath + fileName.ToString()) == false)
                {
                    File.WriteAllBytes(filePath + fileName.ToString(), fileBytes);
                    return "SUCESS";
                }
                else
                {
                    return "WARNING";
                }
            }
            else
            {
                return "NOT FOUND";
            }
           
        }


        public string AtualizaArquivoRecadastro(string base64String, string fileNameAntigo, string fileNameNovo, string conselho)
        {
            byte[] fileBytes = Convert.FromBase64String(base64String);
            string filePathFull = ConfigurationManager.AppSettings["FilePathDocumentacaoRecadastro"].ToString() + fileNameAntigo.ToString();
            string filePath = ConfigurationManager.AppSettings["FilePathDocumentacaoRecadastro"].ToString();


            if (File.Exists(filePath + "\\" + conselho.ToString() + "\\" + fileNameAntigo.ToString()))
            {
                File.Delete(filePath + "\\" + conselho.ToString() + "\\" + fileNameAntigo.ToString());
                File.WriteAllBytes(filePath + "\\" + conselho.ToString() + "\\" + fileNameNovo.ToString(), fileBytes);

                return "SUCESS";
            }
            else
            {
                return "WARNING";
            }
        }

        public string CriaArquivoEventoNoticias(string base64String, string fileName)
        {
            byte[] fileBytes = Convert.FromBase64String(base64String);
            string filePathFull = ConfigurationManager.AppSettings["NoticiasFeed"].ToString() + fileName.ToString();
            string filePath = ConfigurationManager.AppSettings["NoticiasFeed"].ToString();



            if (!Directory.Exists(filePath))
            {
                File.WriteAllBytes(filePath + fileName.ToString(), fileBytes);

                return "SUCESS";
            }
            else
            {
                if (File.Exists(filePath + fileName.ToString()))
                {
                    File.WriteAllBytes(filePath + fileName.ToString(), fileBytes);
                    return "SUCESS";
                }
                else
                {
                    File.WriteAllBytes(filePath + fileName.ToString(), fileBytes);
                    return "SUCESS";
                }

            }
        }
        public string CriaArquivoCards(string base64String, string fileName, int contador)
        {
            byte[] fileBytes = Convert.FromBase64String(base64String);
            string filePathFull = ConfigurationManager.AppSettings["Cards"].ToString() + fileName.ToString();
            string filePath = ConfigurationManager.AppSettings["Cards"].ToString();



            if (!Directory.Exists(filePath))
            {
                //Directory.CreateDirectory(filePath + "\\" + conselho.ToString());

                File.WriteAllBytes(filePath + fileName.ToString(), fileBytes);

                return "SUCESS";
            }
            else
            {
                if (File.Exists(filePath + fileName.ToString()))
                {
                    File.WriteAllBytes(filePath + "v" + contador + "_" + fileName.ToString(), fileBytes);
                    return "SUCESS";
                }
                else
                {
                    File.WriteAllBytes(filePath + fileName.ToString(), fileBytes);
                    return "SUCESS";
                }

            }
        }
        public string ValidaArquivos(string base64String, string fileName, string conselho)
        {
            byte[] fileBytes = Convert.FromBase64String(base64String);
            string filePathFull = ConfigurationManager.AppSettings["FilePathDocumentacao"].ToString() + fileName.ToString();
            string filePath = ConfigurationManager.AppSettings["FilePathDocumentacao"].ToString();

            if (!File.Exists(filePath + "\\" + conselho.ToString()))
            {

                return "SUCESS";
            }
            else
            {
                return "ERROR";
            }
        }

        public string ExcluiCard(string fileName)
        {
            try
            {
                string filePathFull = ConfigurationManager.AppSettings["Cards"].ToString() + fileName.ToString();
                string filePathFullPastaCardsImg = ConfigurationManager.AppSettings["PastaCardsImage"].ToString() + fileName.ToString();
                if (File.Exists(filePathFull))
                {
                    File.Delete(filePathFull);
                    return "SUCESS";
                }
                else
                {
                    return "ERROR";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string CriaArquivoCertificado(string base64String, string fileName, string conselho, int contador)
        {
            byte[] fileBytes = Convert.FromBase64String(base64String);
            string filePath = ConfigurationManager.AppSettings["Certificados"].ToString();



            if (!Directory.Exists(filePath + "\\" + conselho.ToString()))
            {
                Directory.CreateDirectory(filePath + "\\" + conselho.ToString());

                File.WriteAllBytes(filePath + "\\" + conselho.ToString() + "\\" + fileName.ToString(), fileBytes);

                return "SUCESS";
            }
            else
            {
                File.WriteAllBytes(filePath + "\\" + conselho.ToString() + "\\" + fileName.ToString(), fileBytes);
                return "SUCESS";

            }
        }
    }

}
