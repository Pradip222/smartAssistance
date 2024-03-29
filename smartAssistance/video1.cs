﻿using System;
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
    public partial class video1 : Form
    {
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer jarvis = new SpeechSynthesizer();
        SpeechRecognitionEngine startlistening = new SpeechRecognitionEngine();
        Random rnd = new Random();
        int RecTimeout = 0;
        bool status = true;
        bool start = true;
        public video1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands1.txt")))));
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecongnized);
            _recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer_SpeechRecongnized);
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            startlistening.SetInputToDefaultAudioDevice();
            startlistening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands1.txt")))));
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
            string[] comm = File.ReadAllLines(@"DefaultCommands1.txt");
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
                    else if (hour > 12 && hour < 16)
                        jarvis.SpeakAsync("Good Afternoon");
                    else
                        jarvis.SpeakAsync("Good Evening");
                    jarvis.SpeakAsync("I am Alexa, Welcome to Video Assistance, How may i help you.");


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

                    string[] commands = File.ReadAllLines(@"DefaultCommands1.txt");
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
                else if (speech == "go to audio")
                {
                    jarvis.SpeakAsync("Yes Sir");
                    
                    Video v = new Video();
                    v.Hide();
                    this.Hide();
                    audio1 ad = new audio1();
                    ad.ShowDialog();
                   



                 
                    status = false;
                    this.Hide();
                }
                else if (speech == "bye")
                {
                    jarvis.SpeakAsync("Bye Sir, Exiting");
                    status = false;
                    this.Hide();

                }
                else if (speech == "play video")
                {
                    jarvis.SpeakAsync("Sure Sir!");
                    System.Diagnostics.Process.Start(@"G:\Gate\NPTEL\AIKRR\week 7\1.mp4");
                
                    

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
