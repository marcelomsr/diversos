using System;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace ConsoleApplication1
{
    class Program
    {
        private static SpeechSynthesizer Speaker { get; set; }

        static void Main(string[] args)
        {
            // Reconhecimento de voz em inglês.
            // Create an in-process speech recognizer for the en-US locale.
            using (
            SpeechRecognitionEngine recognizer =
              new SpeechRecognitionEngine(
                new System.Globalization.CultureInfo("en-US")))
            {

                // Create and load a dictation grammar.
                recognizer.LoadGrammar(new DictationGrammar());

                // Add a handler for the speech recognized event.
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

                // Configure input to the speech recognizer.
                recognizer.SetInputToDefaultAudioDevice();

                // Start asynchronous, continuous speech recognition.
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                // Keep the console window open.
                while (true)
                {
                    Console.ReadLine();
                }
            }
            

            /*// Reconhecimento de voz português usando gramática
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine();

            Choices colors = new Choices();
            //colors.Add(new string[] { "Vermêlho", "Verde", "Azul", "Amarelo", "Sim", "Não", "Ela", "Êle", "Ocupado", "Não está", "ok jarvis" });
            colors.Add(new string[] { "ok jarvis", "diga-me as horas", "pesquisar na internet" });

            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(colors);

            // Create the Grammar instance.
            Grammar g = new Grammar(gb);

            sre.LoadGrammar(g);

            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

            // Configure input to the speech recognizer.
            sre.SetInputToDefaultAudioDevice();

            // Start asynchronous, continuous speech recognition.
            sre.RecognizeAsync(RecognizeMode.Multiple);

            // Keep the console window open.
            while (true)
            {
                Console.ReadLine();
            }
            */
        }

        private static void falar()
        {
            // TTS
            Speaker = new SpeechSynthesizer();

            Speaker.SelectVoice("Microsoft Zira Desktop");
            Speaker.Speak("Speaking in english");

            Speaker.SelectVoice("Microsoft David Desktop");
            Speaker.Speak("Speaking in english");

            Speaker.SelectVoice("Microsoft Helena Desktop");
            Speaker.Speak("Hablando en español");

            Speaker.SelectVoice("Microsoft Maria Desktop");
            Speaker.Speak("Falando em Português");

            string horas = DateTime.Now.ToShortTimeString();

            Speaker.SelectVoice("Microsoft Maria Desktop");
            Speaker.Speak(horas);

            while (true) ;
        }

        private static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine("Speech recognized: " + e.Result.Text + " - " + e.Result.Confidence);
        }
    }
}
