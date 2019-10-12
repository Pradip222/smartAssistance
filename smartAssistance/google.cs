using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;

namespace smartAssistance
{
    public partial class google: Form
    {
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer jarvis = new SpeechSynthesizer();
        SpeechRecognitionEngine startlistening = new SpeechRecognitionEngine();
        Random rnd = new Random();
        int RecTimeout = 0;
        bool status = true;
        bool start = true;
        public google()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"google.txt")))));
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecongnized);
            _recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer_SpeechRecongnized);
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            startlistening.SetInputToDefaultAudioDevice();
            startlistening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"google.txt")))));
            startlistening.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(startlistening_SpeechReconginzed);

        }
        private void recognizer_SpeechRecongnized1(object sender, SpeechDetectedEventArgs e)
        {
            RecTimeout = 0;
        }
        private void Default_SpeechRecongnized1(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
           label1.Text = speech;
            string[] comm = File.ReadAllLines(@"google.txt");
            bool result = false;
            foreach (string c in comm)
            {
                if (c == speech)
                    result = true;
            }
            if (!result)
            {
                jarvis.SpeakAsync("Tell me question sir");
                string newquestion = e.Result.Text;
                jarvis.SpeakAsync(e.Result.Text);
            }
        }
        private void Default_SpeechRecongnized(object sender, SpeechRecognizedEventArgs e)
        {
            int ranNum;
            string speech = e.Result.Text;

            
            if (!start)
                _recognizer.RecognizeAsync(RecognizeMode.Multiple);

            if (status)
            {
                label1.Text = speech;
                
                if (speech == "hello")
                {
                    int hour = DateTime.Now.Hour;
                    if (hour > 0 && hour < 12)
                    {
                        jarvis.SpeakAsync("Good Morning");
                    }
                    else if (hour >= 12 && hour < 16)
                        jarvis.SpeakAsync("Good Afternoon");
                    else
                        jarvis.SpeakAsync("Good Evening");
                    jarvis.SpeakAsync("I am Alexa, Welcome to Google Assistance, How may i help you.");


                }
                else if (speech == "how are you")
                {
                    jarvis.SpeakAsync("I am good, Hoping that you are also good.");
                }
                else if (speech == "what time is it")
                {
                    string cur = DateTime.Now.ToShortTimeString();
                    jarvis.SpeakAsync("Current Time is " + cur);
                }
                else if (speech == "Stop talking")
                {
                    jarvis.SpeakAsyncCancelAll();
                    jarvis.SpeakAsync("Yes Sir, I am here");
                    ranNum = rnd.Next(1);
                    if (ranNum == 1)
                        jarvis.SpeakAsync("Yes Sir, I am here");
                    else if (ranNum == 2)
                    {
                        jarvis.SpeakAsync("I am Sorry, I will be quit");
                    }
                }
                
                else if (speech == "Show commands")
                {
                    
                    string[] commands = File.ReadAllLines(@"google.txt");
                    lstCommands.Items.Clear();
                    lstCommands.SelectionMode = SelectionMode.None;
                    lstCommands.Visible = true;
                    foreach (string command in commands)
                        lstCommands.Items.Add(command);
                }
                else if (speech == "Hide commands")
                {
                    lstCommands.Items.Clear();
                    lstCommands.Visible = false;
                }
                else if (speech == "search")
                {
                    jarvis.SpeakAsync("Yes Sir");

                    System.Diagnostics.Process.Start(@"https://www.google.com/search?source=hp&ei=h4WhXZrfApq5rQHB-aeYCQ&q=pradip&oq=pradip&gs_l=psy-ab.3..0l6j0i10j0l2j0i10.3557.5127..5409...0.0..0.331.1692.0j1j4j2......0....1..gws-wiz.....0..0i131..10001%3A0%2C154.YIhEa0rCXPE&ved=0ahUKEwjavt_9nZblAhWaXCsKHcH8CZMQ4dUDCAU&uact=5");







                }
                else if (speech == "bye")
                {
                    jarvis.SpeakAsync("Bye Sir, Exiting");
                    status = false;
                    this.Hide();

                }
               
                /*else if (speech == "learn")
                {
                    jarvis.SpeakAsync("Yes sir, I am excited to learn new thing. Tell me something.");
                    //SpeechRecognitionEngine _recognizer1 = new SpeechRecognitionEngine();
                    //_recognizer1.SetInputToDefaultAudioDevice();
                    ////_recognizer1.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands.txt")))));
                    //Grammar dictionarygrammer = new DictationGrammar();
                    //_recognizer1.LoadGrammar(dictionarygrammer);
                    //_recognizer1.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecongnized1);
                    //_recognizer1.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer_SpeechRecongnized1);
                    //_recognizer1.RecognizeAsync(RecognizeMode.Multiple);
                }*/
                else
                {
                    jarvis.SpeakAsync("Sorry sir, I can't get you.");
                }

            }

        }
        private void recognizer_SpeechRecongnized(object sender, SpeechDetectedEventArgs e)
        {
            RecTimeout = 0;
        }
        private void startlistening_SpeechReconginzed(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
            if (speech == "Wake Up")
            {
                startlistening.RecognizeAsyncCancel();
                jarvis.SpeakAsync("Yes, I am here.");
            }
        }

        private void TmrSpeaking_Tick(object sender, EventArgs e)
        {
            if (RecTimeout == 10)
            {
                _recognizer.RecognizeAsyncCancel();
            }
            else if (RecTimeout == 11)
            {
                TmrSpeaking.Stop();
                _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private void LstCommands_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
