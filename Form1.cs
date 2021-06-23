using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace generar_en_core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //con esto obtengo l user name del usuario de la pc para poder crear la cadena de direccion de la ubicacion
            string nameuser = Environment.UserName;

            string direccion = @"C: \Users\"+nameuser+ @"\Desktop\nuevo2pdf.pdf";
            string sigue = @"C:\users\Oscar Carpio\Desktop\nuevo2pdf.pdf";
            string dir2 = direccion;

            FileStream fs = new FileStream(@"C:\nuevo2pdf.pdf", FileMode.Create);
            //FileStream fs = new FileStream(@"C:\Users\Oscar Carpio\Desktop\nuevo2pdf.pdf", FileMode.Create);

            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pdw = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            //definir titulo y autor 
            doc.AddAuthor("Tito");
            doc.AddTitle("se logro banda");
            iTextSharp.text.Font standarfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            
            //string nameuser = Environment.UserName;


            doc.Add(new Paragraph(dir2));
            doc.Add(Chunk.NEWLINE);

            doc.Close();
            pdw.Close();
        }
    }
}
