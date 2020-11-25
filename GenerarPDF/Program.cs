using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GenerarPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            var documento1 = new Document();

            string path = "PDFs";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            PdfWriter.GetInstance(documento1, new FileStream(path + "/DocumentoPrueba123.pdf", FileMode.Create));

            documento1.Open();
            documento1.Add(new Paragraph("Este es mi pdf de arquitectura"));
            documento1.Close();

            Console.ReadLine();
           
        }
    }
}
