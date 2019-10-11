using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Globalization;

namespace smartAssistance
{
    public partial class Audio : UserControl
    {
        private SpeechRecognitionEngine recognitionEngine;
        public Audio()
        {
            InitializeComponent();
            lbinstruction.Text = "Ready";
            recognitionEngine = new SpeechRecognitionEngine();
            recognitionEngine.LoadGrammar(new DictationGrammar());
            recognitionEngine.SetInputToDefaultAudioDevice();
            label2.Text = "";
            //end

            //

            recognitionEngine.SpeechRecognized += (s, args) =>
            {
                SpeechSynthesizer speaker = new SpeechSynthesizer();
                speaker.Speak(args.Result.Text);
                label2.Text = args.Result.Text;
                if (label2.Text.Equals("start"))
                {
                    speaker.Speak("hii pradip , How may i help you");
                }
               /* foreach (RecognizedWordUnit word in args.Result.Words)
                {
                    label2.Text = "";
                    label2.Text = args.Result.Words.ToString();
                    if (word.Confidence > 0.0f)

                        label2.Text += word.Text;
                    label2.Text += Environment.NewLine;
                    //recognitionEngine.RecognizeAsync(RecognizeMode.Single);
                   
                   
                    switch (word.Text)
                    {
                        case "test":
                            stop();
                            SpeechSynthesizer spaker = new SpeechSynthesizer();
                            spaker.Speak("Helloo how r u");
                            break;
                        case "institute":
                            stop();
                            //  pictureBox1.Show();
                            //    pictureBox1.Image = Image.FromFile("C:/Users/Shannen/Desktop/anigif.gif");
                            button1.Show();
                            break;

                        case "communicate":
                            stop();
                            //    pictureBox1.Show();
                            //    pictureBox1.Image = Image.FromFile("C:/Users/Shannen/Desktop/3D Files/communicate.gif");
                            button1.Show();
                            break;

                        default:
                            stop();
                          //  DialogResult result = MessageBox.Show("NO match found. Try Again", "confirm", MessageBoxButtons.OKCancel);
                        //    stop();
                        //    if (result == DialogResult.OK)
                        //    {
                        //        start();
                        //    }
                        //    else if (result == DialogResult.Cancel)
                        //    {
                        //        stop();
                        //    }
                            break;

                    }
                  //  speaker.Speak(args.Result.Words.ToString());
                }
                */
            };

            recognitionEngine.LoadGrammar(new DictationGrammar());
        }
        public void stop()
        {
            recognitionEngine.RecognizeAsyncStop();
            //recognitionEngine.RecognizeAsyncCancel();
        }
        public void start()
        {
            SpeechSynthesizer speaker = new SpeechSynthesizer();
            speaker.Speak("hey, i am listening..");
           
                recognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
           
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (button1.Text == "Start")
            {
               // recognitionEngine.RecognizeAsync(RecognizeMode.Multiple);//start
                start();
                button1.Text = "STOP";
            }
            else if (button1.Text == "STOP")
            {
                button1.Text = "Start";
                recognitionEngine.RecognizeAsyncStop();
                //Close();
                stop();
            }
        }

        void _recognizer_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
           
        }
        void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            
        }

        private void Lbinstruction_Click(object sender, EventArgs e)
        {

        }
    }
}
