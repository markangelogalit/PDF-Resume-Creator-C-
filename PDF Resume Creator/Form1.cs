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

        private void button1_Click(object sender, EventArgs e)
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

            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) ;


        }




















        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lbl7_Click(object sender, EventArgs e)
        {

        }

        private void lbl14_Click(object sender, EventArgs e)
        {

        }

        private void lbl15_Click(object sender, EventArgs e)
        {

        }
    }
}
