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
            //con esto obtengo el user name del usuario de la pc para poder crear la cadena de direccion de la ubicacion
            string nameuser = Environment.UserName;
            //sacando un dato especifico del usuario se puede crear el nombre del pdf asi:
            string nombredoc = "pdfXD.pdf";
       
            //si decimos que el instalador lo pongan en el escritorio, con esto el pdf se crea en el escritorio, asi :
            string direccion = @"..\..\..\..\..\" + nombredoc;
            // hacer caso omisp de estp string sigue = @"C:\users\Oscar Carpio\Desktop\nuevo2pdf.pdf";
            string dir2 = direccion;

            //direccion donde se crea el pdf de manera dinamica: 
            FileStream fs = new FileStream(dir2, FileMode.Create);
            //FileStream fs = new FileStream(@"C:\Users\Oscar Carpio\Desktop\nuevo2pdf.pdf", FileMode.Create);


            //configuracion de la fuente del tamano de pagina y margenes del pdf: 
            Document doc = new Document(PageSize.A7.Rotate(), 5, 5, 7, 7);
            // instancia q tiene como parametro el boosquejo del doc y la ubicacion donde generara:
            PdfWriter pdw = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            //definir titulo y autor 
            doc.AddAuthor("Tito");
            doc.AddTitle("se logro banda");
            iTextSharp.text.Font standarfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //configuro los tipos de fuente que tenfra el pdf
            iTextSharp.text.Font timesRoman1 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font timesRoman2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 5, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            iTextSharp.text.Font timesRoman3 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font normal = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.UNDEFINED, 5, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // obtengo la imagen de los recursos del proyecto
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(generar_en_core.Properties.Resources.HAPA_logo_transparente, System.Drawing.Imaging.ImageFormat.Png);
            logo.ScalePercent(10);
            
            //creo la tabla que agregare al documento pdf
            var table = new PdfPTable(new float[] { 15f, 30f, 15f, 40f }) { WidthPercentage = 100 };

            //creo las celdas
            var c1 = new PdfPCell(new Phrase("-----------", timesRoman1)); // se coloco para darle formato
            var c2 = new PdfPCell(new Phrase("------------------------", timesRoman1));
            var c3 = new PdfPCell(new Phrase("-----------", timesRoman1)); // se coloco para darle formato
            var c4 = new PdfPCell(logo) { Rowspan = 3};

            //////quito los bordes de las celdas.
            c1.Border = 0;
            c2.Border = 0;
            c3.Border = 0;
            c4.Border = 0;

            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);
            table.AddCell(c4);

            

            c1.Phrase = new Phrase(new Phrase("", timesRoman1));
            c2.Phrase = new Phrase(new Phrase("HAPA COVID-19", timesRoman1));
            c3.Phrase = new Phrase(new Phrase("", normal));
        
            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);

            c1.Phrase = new Phrase(new Phrase("", timesRoman1));
            c2.Phrase = new Phrase(new Phrase("Healt Aid Program Against Covid-19", timesRoman2));
            c3.Phrase = new Phrase(new Phrase("", normal));

            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);

            c1 = new PdfPCell(new Phrase("-----------", timesRoman1)); // se coloco para darle formato
            c2 = new PdfPCell(new Phrase("------------------------", timesRoman1));
            c3 = new PdfPCell(new Phrase("-----------", timesRoman1)); // se coloco para darle formato
            c4 = new PdfPCell(new Phrase("-----------------------", timesRoman1)); // se coloco para darle formato

            //////quito los bordes de las celdas.
            c1.Border = 0;
            c2.Border = 0;
            c3.Border = 0;
            c4.Border = 0;

            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);
            table.AddCell(c4);

            c1 = new PdfPCell(new Phrase("Fecha:", timesRoman3)); // se coloco para darle formato
            c2 = new PdfPCell(new Phrase("", timesRoman1));
            c3 = new PdfPCell(new Phrase("", timesRoman1)); // se coloco para darle formato
            c4 = new PdfPCell(new Phrase("", timesRoman1)); // se coloco para darle formato

            //////quito los bordes de las celdas.
            c1.Border = 0;
            c2.Border = 0;
            c3.Border = 0;
            c4.Border = 0;

            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);
            table.AddCell(c4);


            c1 = new PdfPCell(new Phrase("Hora:", timesRoman3)); // se coloco para darle formato
            c2 = new PdfPCell(new Phrase("", timesRoman1));
            c3 = new PdfPCell(new Phrase("", timesRoman1)); // se coloco para darle formato
            c4 = new PdfPCell(new Phrase("", timesRoman1)); // se coloco para darle formato

            //////quito los bordes de las celdas.
            c1.Border = 0;
            c2.Border = 0;
            c3.Border = 0;
            c4.Border = 0;

            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);
            table.AddCell(c4);


            c1 = new PdfPCell(new Phrase("Lugar:", timesRoman3)); // se coloco para darle formato
            c2 = new PdfPCell(new Phrase("", timesRoman1));
            c3 = new PdfPCell(new Phrase("", timesRoman1)); // se coloco para darle formato
            c4 = new PdfPCell(new Phrase("", timesRoman1)); // se coloco para darle formato

            //////quito los bordes de las celdas.
            c1.Border = 0;
            c2.Border = 0;
            c3.Border = 0;
            c4.Border = 0;

            //////agrego las celdas a mi tabla
            table.AddCell(c1);
            table.AddCell(c2);
            table.AddCell(c3);
            table.AddCell(c4);


            doc.Add(table);
            doc.Close();
            pdw.Close();

            //NOTA: solo apreta una vez el bton que se me olvido poner el message box que confiema la creacion del pdf XD
        }
    }
}
