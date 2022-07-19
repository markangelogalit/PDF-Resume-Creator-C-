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
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;


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
            var resumeFromJson = JsonConvert.DeserializeObject<Resume>(jsonFromFile);

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

                    XFont bigfont = new XFont("Arial", 18, XFontStyle.Bold);
                    XFont smallfont = new XFont("Arial", 14, XFontStyle.Regular);
                    XFont titlefont = new XFont("Arial", 35, XFontStyle.Bold);

                    XPen pen = new XPen(XColors.Aquamarine, 20);
                    XPen linerleft = new XPen(XColors.Black, 1); ;
                    XPen linerright = new XPen(XColors.Black, 1);


                    graph.DrawRoundedRectangle(XBrushes.Cornsilk, 0, 0, page.Width.Point, page.Height.Point, 30, 20);
                    graph.DrawRoundedRectangle(XBrushes.Aquamarine, 200, 50, page.Width.Point, page.Height.Point, 100, 100);
                    graph.DrawRectangle(pen, 0, 0, page.Width.Point, page.Height.Point);

                    graph.DrawString("COMPUTER ENGINEERING STUDENT", bigfont, XBrushes.Black, new XRect(0, 20, page.Width.Point - 20, page.Height.Point - 50), XStringFormats.TopRight);

                    int marginleft = 25;
                    int initialleft = 200;
                    int marginright = 25;

                    string png = @"C:\Users\admin\Documents\MARK FOLDER FOR GRADE 12\Mark Angelo Galit.png\PLAIN OFFICIAL.jpg.png";
                    XImage image = XImage.FromFile(png);
                    graph.DrawImage(image, marginright, 50, 150, 150);


                    graph.DrawString("CONTACTS:", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(FirstName, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(MiddleName, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 110, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(Surname, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 130, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(Address, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 150, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(ContactNumber, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 170, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(Email, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 190, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);





                    graph.DrawString("SKILLS:", bigfont, XBrushes.Black, new XRect(marginleft, initialleft + 220, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(FirstSkill, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 240, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(SecondSkill, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 260, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(ThirdSkill, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 280, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(FourthSkill, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 300, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(FifthSkill, smallfont, XBrushes.Black, new XRect(marginleft, initialleft + 320, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    int marginmiddle = 220;
                    int initialmiddle = 200;

                    graph.DrawString("EXPERIENCE:", bigfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 150, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(WorkExperience, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 170, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(linerright, marginmiddle, initialmiddle - 10, 350, 1);

                    graph.DrawString("EDUCATION:", bigfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Tertiary, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(UpperSecondary, smallfont, XBrushes.Black, new XRect(marginmiddle + 25, initialmiddle + 50, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Secondary, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 70, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Primary, smallfont, XBrushes.Black, new XRect(marginmiddle + 25, initialmiddle + 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);


                    pdf.Save(saveFileDialog.FileName);
                }
                MessageBox.Show("Thank you for taking the time to use this program.");

            }
            Application.Restart();
            Environment.Exit(0);


        }
    }
}
