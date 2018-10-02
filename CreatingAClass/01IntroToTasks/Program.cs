using System;
using System.Threading.Tasks;

namespace IntroToTasks
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Task.Factory.StartNew(() => Speak("Ekse mei outtie")).Wait();

            Console.ReadKey();
        }

        private static void Speak(string words)
        {
            Console.WriteLine(words);
        }
    }
}
