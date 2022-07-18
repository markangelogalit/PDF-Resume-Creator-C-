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



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
