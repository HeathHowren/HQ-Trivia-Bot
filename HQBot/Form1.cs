using System;
using System.IO;
using System.Net;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using Tesseract; //NuGet package

namespace v3_OCR_HQ
{
    public partial class Form1 : Form
    {
        //Looking back on my code, declaring these in this scope is bad. I will work on fixing this.
        public string text;
        public string Question;
        public string Answer1;
        public string Answer2;
        public string Answer3;
        public string[] lines;
        public string[] ListAll;
        public string QuestionNew;
        public int q1;
        public int q2;
        public int q3;


        public Form1()
        {
            InitializeComponent();
        }

        public void Screenshot() //This takes a screenshot of the box that pops up
        {
            string DeleteDir = @"C:\Users\rainb\source\repos\V3 OCR HQ Trivia\v3 OCR HQ\bin\Debug\OCR.png"; //Change this path to match your PC
            File.Delete(DeleteDir);
            Point picpoint = answerBox1.PointToScreen(new Point(0, 0));
            var bmpScreenshot = new Bitmap(answerBox1.Size.Width,
                                           answerBox1.Size.Height,
                                           PixelFormat.Format32bppArgb);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(picpoint.X,
                                        picpoint.Y,
                                        0,
                                        0,
                                        answerBox1.Size,
                                        CopyPixelOperation.SourceCopy);
            bmpScreenshot.Save("OCR.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        public void Tesseract()
        {
            //The OCR/Screnshot mechanics were always fidgety, so there is a lot of room to improve here!
            const string tessDataDir = @"C:\Users\rainb\source\repos\V3 OCR HQ Trivia\v3 OCR HQ\tessdata"; //Change this path to match your PC
            const string imageDir = @"C:\Users\rainb\source\repos\v3 OCR HQ\V3 OCR HQ Trivia\bin\Debug\OCR.png"; //Change this path to match your PC
            using (var engine = new TesseractEngine(tessDataDir, "eng", EngineMode.Default))
            using (var image = Pix.LoadFromFile(imageDir))
            using (var page = engine.Process(image))
            {
                text = page.GetText();
            }
        }

        public void Seperate() //I added this as a way to seperate the image into a Question, and Answer 1-3. It was primitive at the time, but it worked.
        {
            lines = text.Split(new[] { "\n\n"  }, StringSplitOptions.None); //You might need to optimize this based on the image your scanning.

            Question = lines[0];
            Answer1 = lines[1];
            Answer2 = lines[2];
            Answer3 = lines[3];
        }

       public void HTMLparse() //This code googles the question using a custom search engine and Regex matches for the most occuring keywords (answers).
       {
            //string correctString = Question.Replace(" ", "+").Replace("\n", "-").Replace("'", "").Replace("?", "");  //I didn't use this in my code, but I'll leave it in case you want it.
            string link = "https://www.googleapis.com/customsearch/enter-your-own-api-here" + Question; //I use a custom google search engine api
            string pageContent = null;
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(link);
            HttpWebResponse myres = (HttpWebResponse)myReq.GetResponse();
            if (myres.StatusCode != HttpStatusCode.OK)
            {
                Debug.WriteLine("\r\nResponse Status Code is NOT and StatusDescription is: {0}",
                                     myres.StatusDescription);
            }
            else
            {
                richTextBox1.ResetText();
                using (StreamReader sr = new StreamReader(myres.GetResponseStream()))
                {
                    pageContent = sr.ReadToEnd();
                }
                int q1 = Regex.Matches(pageContent, Answer1).Count;
                int q2 = Regex.Matches(pageContent, Answer2).Count;
                int q3 = Regex.Matches(pageContent, Answer3).Count;
                richTextBox1.AppendText(Question + "\n" + Answer1 + ": " + q1 + "\n" + Answer2 + ": " + q2 + "\n" + Answer3 + ": " + q3 + "\n");

                if (q1 > q2 && q1 > q3)
                {
                    richTextBox1.AppendText("ANSWER:" + Answer1 + "\n");
                }
                else if (q2 > q1 && q2 > q3)
                {
                    richTextBox1.AppendText("ANSWER: " + Answer2 + "\n");
                }
                else
                {
                    richTextBox1.AppendText("ANSWER: " + Answer3 + "\n");
                }

            }
       }
        /*public void QuoraSearch() //I never went with this for the final, but this parses a website/search engine (this is an alternative to using googles API if you don't want to use their trial/pay)
        {
        //You may need to add some NuGet packages if you use this!
            string correctString = Question.Replace(" ", "+").Replace("\n", "-").Replace("'", "").Replace("?", "");
            string link = "https://duckduckgo.com/?q=" + correctString;
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            //Debug.WriteLine(link);
            HtmlAgilityPack.HtmlDocument doc = web.Load(link);
            var HeaderNames = doc.DocumentNode.SelectNodes("//div[@class='result__snippet']").ToList();
            foreach (var item in HeaderNames)
            {
                Debug.WriteLine(item.InnerText);
            }
            ListAll = HeaderNames.ConvertAll(x => x.ToString()).ToArray();
            Debug.WriteLine(ListAll);
        }*/

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Screenshot();
            Tesseract();
            Seperate();
            HTMLparse();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void questionBox_Click(object sender, EventArgs e)
        {

        }
    }
}
