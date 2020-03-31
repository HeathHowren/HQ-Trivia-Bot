#  HQ Trivia Bot using OCR and Web Scraper 

## Introduction

I started coding this project around the start of 2019. This was when HQ trivia, a daily trivia games where players compete to win prizes, was in the height of its popularity. I started to research ways to gain an advantage in the game and developed the idea of using optical character recognition to get the question on screen and web search the answer for me!

## Code Samples

I implemented [Tesseract OCR](https://github.com/tesseract-ocr/tesseract) an open source optical character recognition engine into my project.
```cpp
        public void Tesseract()
        {
            const string tessDataDir = @"C:\path\tessdata"; //Change this path to match your PC
            const string imageDir = @"C:\path\OCR.png"; //Change this path to match your PC
            using (var engine = new TesseractEngine(tessDataDir, "eng", EngineMode.Default))
            using (var image = Pix.LoadFromFile(imageDir))
            using (var page = engine.Process(image))
            {
                text = page.GetText();
            }
        }
 ```
The application then parses the question and three answer choices into separate variables.
```cpp
        public void Seperate()
        {
            lines = text.Split(new[] { "\n\n" }, StringSplitOptions.None);
            Question = lines[0];
            Answer1 = lines[1];
            Answer2 = lines[2];
            Answer3 = lines[3];
        }
```
The question is then searched using [Googles custom search engine API](https://cse.google.com/cse/).
```cpp
    string link = "https://www.googleapis.com/customsearch/enter-your-own-api-here" + Question;
    string pageContent = null;
    HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(link);
    HttpWebResponse myres = (HttpWebResponse)myReq.GetResponse();
```
In the final step the search result contents are scraped and a regex match is run to find the most common answer.
```cpp
    int q1 = Regex.Matches(pageContent, Answer1).Count;
    int q2 = Regex.Matches(pageContent, Answer2).Count;
    int q3 = Regex.Matches(pageContent, Answer3).Count;
```

## Installation

During the testing phase I used an iPhone, but this is possible (and probably simpler)  to do with an Android device.
* Use an AirPlay application to mirror your phone to the PC
* Hover the application over the screen and click "Scan for answer"
* The results will then be outputted in the textbox!
