using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoCT_e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            jsonTransmitir();
            //jsonRetornoStatus();
        }
        public void jsonTransmitir()
        {
            string API_POST = "http://ctehml.ns.eti.br/cte/issue";

            // Create HTTP POST request
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(API_POST);
            httpWebRequest.ContentType = "text/plain";
            //httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            httpWebRequest.Accept = "text/plain";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("X-AUTH-TOKEN", "bnNDYWRvcmVUZWNub2xvZ2lhdG9rZW4=");

            string output = "";

            // Connecting to the server. Sending request and receiving response
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(File.ReadAllText(@"C:\Users\WCadore\Desktop\ctee.txt"));
                //streamWriter.Write(conteudoJson);
                streamWriter.Flush();
                streamWriter.Close();

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    output = streamReader.ReadToEnd();
                }
            }

            Console.WriteLine(output);
        }

        public void jsonRetornoStatus()
        {
            string API_POST_STATUS = "http://ctehml.ns.eti.br/cte/issueStatus";

            // Create HTTP POST request
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(API_POST_STATUS);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("X-AUTH-TOKEN", "bnNDYWRvcmVUZWNub2xvZ2lhdG9rZW4=");

            string output = "";

            // Connecting to the server. Sending request and receiving response
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write("{\"chCTe\":\"43160812665225000146570000000012021000012024\", \"nRec\":\"431000010675210\", \"tpAmb\": \"2\"}");
                streamWriter.Flush();
                streamWriter.Close();

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    output = streamReader.ReadToEnd();
                }
            }
            Console.WriteLine(output);
        }
    }
}
