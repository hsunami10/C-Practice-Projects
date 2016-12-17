using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Threading;
// Add the reference - System.speech
using System.Speech.Synthesis;

/// <summary>
/// Created by: Michael Hsu
/// This program reads the performance of the CPU and memory, and gives warning via text to voice
/// </summary>
namespace Jarvis
{
    class Program
    {
        private static SpeechSynthesizer synth = new SpeechSynthesizer();

        static void Main(string[] args)
        {
            List<string> cpuMaxedOutMessages = new List<string>();
            cpuMaxedOutMessages.Add("WARNING: Your CPU is overloading!");
            cpuMaxedOutMessages.Add("Your CPU is about to burn out!");
            cpuMaxedOutMessages.Add("Stop pushing your computer so hard!");
            cpuMaxedOutMessages.Add("ALERT: Your CPU is burning up");
            cpuMaxedOutMessages.Add("WARNING: CPU over 90%");

            Random rand = new Random();

            // Greet the user with default voice
            synth.Speak("Welcome to Jarvis version one point oh!");

            // Check Perfomance Monitor Application for these values -> (object, counter, instance)
            #region Performance Counters
            // CPU load
            PerformanceCounter perfCpuCount = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            perfCpuCount.NextValue();

            // Available memory
            PerformanceCounter perfMemCount = new PerformanceCounter("Memory", "Available MBytes");
            perfMemCount.NextValue();

            // Gives the time the system has been online since it was last powered on (in seconds)
            PerformanceCounter perfUpTimeCount = new PerformanceCounter("System", "System Up Time");
            perfUpTimeCount.NextValue();
            #endregion

            TimeSpan uptimeSpan = TimeSpan.FromSeconds(perfUpTimeCount.NextValue());
            string systemUpTimeMessage = string.Format("The current system uptime is {0} days {1} hours {2} minutes {3} seconds",
                (int)uptimeSpan.TotalDays, (int)uptimeSpan.Hours, (int)uptimeSpan.Minutes, (int)uptimeSpan.Seconds);
            Speak(systemUpTimeMessage, VoiceGender.Male);

            int speechSpeed = 1;
            bool chromeOpen = false;

            while (true)
            {

                int currentCpuPercentage = (int) perfCpuCount.NextValue();
                int currentAvailableMemory = (int) perfMemCount.NextValue();

                // Print the CPU load in percentage and available memory in MB every second
                Console.WriteLine("CPU Load        : {0}%", currentCpuPercentage);
                Console.WriteLine("Available Memory: {0}MB", currentAvailableMemory);

                if(currentCpuPercentage > 80)
                {
                    if(currentCpuPercentage >= 90)
                    {
                        if(speechSpeed < 5)
                        {
                            speechSpeed++;
                        }
                        if(chromeOpen == false)
                        {
                            OpenWebsite("https://www.youtube.com/watch?v=PowGPSdAxTI");
                            chromeOpen = true;
                        }
                        string cpuLoadVocalMessage = cpuMaxedOutMessages[rand.Next(5)];
                        Speak(cpuLoadVocalMessage, VoiceGender.Female, speechSpeed);
                    }
                    else
                    {
                        string cpuLoadVocalMessage = String.Format("The current CPU load is {0} percent", currentCpuPercentage);
                        Speak(cpuLoadVocalMessage, VoiceGender.Male);
                    }
                }
                if(currentAvailableMemory < 1024)
                {
                    string memAvailableVocalMessage = String.Format("You currently have {0} megabytes of memory available", currentAvailableMemory);
                    Speak(memAvailableVocalMessage, VoiceGender.Male);
                }

                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Speaks with a selected voice
        /// </summary>
        /// <param name="message"></param>
        /// <param name="voiceGender"></param>
        public static void Speak(string message, VoiceGender voiceGender)
        {
            synth.SelectVoiceByHints(voiceGender);
            synth.Speak(message);
        }

        /// <summary>
        /// Speaks with a selected voice at a selected speed - function overloading
        /// </summary>
        /// <param name="message"></param>
        /// <param name="voiceGender"></param>
        /// <param name="rate"></param>
        public static void Speak(string message, VoiceGender voiceGender, int rate)
        {
            synth.Rate = rate;
            Speak(message, voiceGender);
        }

        // Open a website with a specified URL
        public static void OpenWebsite(string URL)
        {
            Process p1 = new Process();
            p1.StartInfo.FileName = "chrome.exe";
            p1.StartInfo.Arguments = URL;
            p1.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            p1.Start();
        }
    }
}
