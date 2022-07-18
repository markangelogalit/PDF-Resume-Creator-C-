using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;


namespace PDF_Resume_Creator
{
    public partial class Form1 : Form
    {
        private readonly string _fileName = @"C:\Users\admin\source\repos\PDF Resume Creator\PDF Resume Creator\jsconfig1.json";
        public Form1()
        {
            InitializeComponent();
        }

        public class Resume
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string Surname { get; set; }
            public string Address { get; set; }
            public string ContactNumber { get; set; }
            public string Email { get; set; }
            public string FirstSkill { get; set; }
            public string SecondSkill { get; set; }
            public string ThirdSkill { get; set; }
            public string FourthSkill { get; set; }
            public string FifthSkill { get; set; }
            public string WorkExperience { get; set; }
            public string Tertiary { get; set; }
            public string UpperSecondary { get; set; }
            public string Secondary { get; set; }
            public string Primary { get; set; }


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string jsonFromFile;
            using (var reader = new StreamReader(_fileName))
            {
                jsonFromFile = reader.ReadToEnd();
            }
            var resumeFromJson = Newtonsoft.Json.JsonConvert.DeserializeObject<Resume>(jsonFromFile);

            string FirstName = resumeFromJson.FirstName;
            string MiddleName = resumeFromJson.MiddleName;
            string Surname = resumeFromJson.Surname;
            string Address = resumeFromJson.Address;
            string ContactNumber = resumeFromJson.ContactNumber;
            string Email = resumeFromJson.Email;

            string FirstSkill = resumeFromJson.FirstSkill;
            string SecondSkill = resumeFromJson.SecondSkill;
            string ThirdSkill = resumeFromJson.ThirdSkill;
            string FourthSkill = resumeFromJson.FourthSkill;
            string FifthSkill = resumeFromJson.FifthSkill;

            string WorkExperience = resumeFromJson.WorkExperience;

            string Tertiary = resumeFromJson.Tertiary;
            string UpperSecondary = resumeFromJson.UpperSecondary;
            string Secondary = resumeFromJson.Secondary;
            string Primary = resumeFromJson.Primary;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = @"C:\Users\admin\Documents\RESUME PDF";
                saveFileDialog.FileName = Surname + " " + FirstName + ".pdf";
                saveFileDialog.Filter = "PDF|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = Surname + "_" + "Resume";
                    PdfPage page = pdf.AddPage();


                    XGraphics graph = XGraphics.FromPdfPage(page);
                    XFont bigfont = new XFont("Arial", 20, XFontStyle.Bold);
                    XFont smallfont = new XFont("Arial", 16, XFontStyle.Regular);
                    XFont titlefont = new XFont("Arial", 37, XFontStyle.Bold);
                    XPen pen = new XPen(XColors.Aquamarine, 20);
                    XPen linerleft = new XPen(XColors.Black, 1); ;
                    XPen linerright = new XPen(XColors.Black, 1);


                    graph.DrawRoundedRectangle(XBrushes.Cornsilk, 0, 0, page.Width.Point, page.Height.Point, 30, 20);
                    graph.DrawRoundedRectangle(XBrushes.Aquamarine, 200, 50, page.Width.Point, page.Height.Point, 100, 100);
                    graph.DrawRectangle(pen, 0, 0, page.Width.Point, page.Height.Point);
                    graph.DrawString("COMPUTER ENGINEERING STUDENT", bigfont, XBrushes.Black, new XRect(0, 20, page.Width.Point - 20, page.Height.Point - 50), XStringFormats.TopRight);
                    int marginleft = 25;
                    int initialleft = 200;
                    string jpg = @"C:\Users\admin\Documents\MARK FOLDER FOR GRADE 12\Mark Angelo Galit.jpg";
                    XImage image = XImage.FromFile(jpg);
                    graph.DrawImage(image, marginleft, 50, 150, 150);


                    graph.DrawString("CONTACTS:", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 65, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(FirstName, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 110, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(MiddleName, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 110, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Surname, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 110, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Address, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 110, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(ContactNumber, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 110, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Email, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 110, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    int marginright = 220;
                    int initialright = 200;
                    int TopRight = 200;


                    graph.DrawString("SKILLS:", bigfont, XBrushes.Black, new XRect(marginright, initialright + 65, page.Width.Point, page.Height.Point), XStringFormats.TopRight);
                    graph.DrawString(FirstSkill, smallfont, XBrushes.Black, new XRect(marginright, initialright + 110, page.Width.Point, page.Height.Point), XStringFormats.TopRight);
                    graph.DrawString(SecondSkill, smallfont, XBrushes.Black, new XRect(marginright, initialright + 110, page.Width.Point, page.Height.Point), XStringFormats.TopRight);
                    graph.DrawString(ThirdSkill, smallfont, XBrushes.Black, new XRect(marginright, initialright + 110, page.Width.Point, page.Height.Point), XStringFormats.TopRight);
                    graph.DrawString(FourthSkill, smallfont, XBrushes.Black, new XRect(marginright, initialright + 110, page.Width.Point, page.Height.Point), XStringFormats.TopRight);
                    graph.DrawString(FifthSkill, smallfont, XBrushes.Black, new XRect(marginright, initialright + 110, page.Width.Point, page.Height.Point), XStringFormats.TopRight);

                    int BottomLeft = 200;
                    int BottomRight = 200;

                    graph.DrawString("EXPERIENCE:", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 65, page.Width.Point, page.Height.Point), XStringFormats.BottomLeft);
                    graph.DrawString(WorkExperience, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 110, page.Width.Point, page.Height.Point), XStringFormats.BottomLeft);

                    graph.DrawString("EDUCATION:", bigfont, XBrushes.Black, new XRect(marginright, initialright + 65, page.Width.Point, page.Height.Point), XStringFormats.BottomRight);
                    graph.DrawString(Tertiary, smallfont, XBrushes.Black, new XRect(marginright, initialright + 110, page.Width.Point, page.Height.Point), XStringFormats.BottomRight);
                    graph.DrawString(UpperSecondary, smallfont, XBrushes.Black, new XRect(marginright, initialright + 110, page.Width.Point, page.Height.Point), XStringFormats.BottomRight);
                    graph.DrawString(Secondary, smallfont, XBrushes.Black, new XRect(marginright, initialright + 110, page.Width.Point, page.Height.Point), XStringFormats.BottomRight);
                    graph.DrawString(Primary, smallfont, XBrushes.Black, new XRect(marginright, initialright + 110, page.Width.Point, page.Height.Point), XStringFormats.BottomRight);


                    pdf.Save(saveFileDialog.FileName);
                }
                MessageBox.Show("Thank you for using this program.");

            }
            Application.Restart();
            Environment.Exit(0);


        }
    }
}
