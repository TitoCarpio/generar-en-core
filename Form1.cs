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
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            // instancia q tiene como parametro el boosquejo del doc y la ubicacion donde generara:
            PdfWriter pdw = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            //definir titulo y autor 
            doc.AddAuthor("Tito");
            doc.AddTitle("se logro banda");
            iTextSharp.text.Font standarfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            
            

            // con esto mando a escribir lo que quiero al pdf, en este caso un variable de tipo string:
            doc.Add(new Paragraph(dir2));
            //esto lo unico que hace es un salto de linea 
            doc.Add(Chunk.NEWLINE);

            doc.Close();
            pdw.Close();

            //NOTA: solo apreta una vez el bton que se me olvido poner el message box que confiema la creacion del pdf XD
        }
    }
}
