using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace T4
{
    /// <summary>
    /// Index 的摘要说明
    /// </summary>
    public class Index : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string DocxFilePath = context.Server.MapPath("/file/4.docx");
            byte[] byteArray = System.IO.File.ReadAllBytes(DocxFilePath);
            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {
                memoryStream.Write(byteArray, 0, byteArray.Length);
                using (DocumentFormat.OpenXml.Packaging.WordprocessingDocument doc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(memoryStream, true))
                {
                    OpenXmlPowerTools.HtmlConverterSettings settings = new OpenXmlPowerTools.HtmlConverterSettings() {
                        PageTitle = "My Page Title"
                    };
                    System.Xml.Linq.XElement html = OpenXmlPowerTools.HtmlConverter.ConvertToHtml(doc, settings);
                    context.Response.Write(html.ToStringNewLineOnAttributes());
                    //System.IO.File.WriteAllText(HTMLFilePath, html.ToStringNewLineOnAttributes());
                }
            }
        }

        private XElement Handler(ImageInfo arg)
        {

            throw new NotImplementedException();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}