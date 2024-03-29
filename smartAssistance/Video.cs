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
    public partial class Video : Form
    {
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer jarvis = new SpeechSynthesizer();
        SpeechRecognitionEngine startlistening = new SpeechRecognitionEngine();
        Random rnd = new Random();
        int RecTimeout = 0;
        bool status = true;
        bool start = true;
        public Video()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands.txt")))));
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecongnized);
            _recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer_SpeechRecongnized);
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            startlistening.SetInputToDefaultAudioDevice();
            startlistening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands.txt")))));
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
                    jarvis.SpeakAsync("I am Alexa, How may i help you.");


                }
               
                else if (speech == "what time is it")
                {
                    string cur = DateTime.Now.ToShortTimeString();
                    jarvis.SpeakAsync("Current Time is " + cur);
                }
               
                
                else if (speech == "play video")
                {
                    jarvis.SpeakAsync("Sure Sir!");
                    System.Diagnostics.Process.Start(@"G:\\Gate\NPTEL\AIKRR\week 7\1.mp4");



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

        }

        private void LstCommands_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            video1 v = new video1();
            v.Show();
        }

        private void Video_Load(object sender, EventArgs e)
        {

        }
    }
}
