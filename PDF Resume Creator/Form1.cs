using Newtonsoft.Json;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace PDF_Resume_Creator
{
    public partial class Form1 : Form
    {
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

            public string 1stSkill { get; set; }

            public string 2ndSkill { get; set; }

            public string 3rdSkill { get; set; }

            public string 4thSkill { get; set; }

            public string 5thSkill { get; set; }
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
          var resumeFromJson = JsonConvert.DeserializeObject<Resume>(jsonFromFile);

          string FirstName = resumeFromJson.FirstName;
          string MiddleName = resumeFromJson.MiddleName;
          string Surname = resumeFromJson.Surname;
          string Address = resumeFromJson.Address;
          string ContactNumber = resumeFromJson.ContactNumber;
          string Email = resumeFromJson.Email;
          string 1stSkill = resumeFromJson.1stSkill;
          string 2ndSkill = resumeFromJson.2ndSkill;
          string 3rdSkill = resumeFromJson.3rdSkill;
          string 4thSkill = resumeFromJson.4thSkill;
          string 5thSkill = resumeFromJson.5thSkill;
          string WorkExperience = resumeFromJson.WorkExperience;
          string Tertiary = resumeFromJson.Tertiary;
          string UpperSecondary = resumeFromJson.UpperSecondary;
          string Secondary = resumeFromJson.Secondary;
          string Primary = resumeFromJson.Primary;
}
    }
}



