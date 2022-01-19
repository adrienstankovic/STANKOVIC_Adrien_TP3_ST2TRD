using System;
using System.Threading;
using System.Threading.Tasks;

namespace STANKOVIC_Adrien_TP3_ST2TRD
{
    public class Exercise2
    {
        private static Mutex mut = new Mutex();
        
        public static void Ex2WithTime()
        {
            var t1 = new Thread(o=> SkyTime(" ", 10, 50));
            var t2 = new Thread(o=>SkyTime("*", 11, 40));
            var t3 = new Thread(o=>SkyTime("°", 9, 20));
            
            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
        }
        
        private static void SkyTime(string sym, int time, int frequency)
        {
            var endTime = DateTime.Now.AddSeconds(time);
            
            while (DateTime.Now <= endTime)
            {
                mut.WaitOne();
                Console.Write(sym);
                mut.ReleaseMutex();
                Thread.Sleep(frequency);
            }
        }

        /*
         * Ex2WithNum is not the better solution to do the threads, the duration of the threads doesn't seem to be respected
         */
        public static void Ex2WithNum()
        {
            var t1 = new Thread(o=> SkyNum(" ", 10, 50));
            var t2 = new Thread(o=>SkyNum("*", 11, 40));
            var t3 = new Thread(o=>SkyNum("°", 9, 20));
            
            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
        }
        
        private static void SkyNum(string sym, float time, int frequency)
        {
            //freq is the frequency in seconds
            double frequencyInSec = (float)frequency/1000;
            double numOfPrint = time/frequencyInSec;
            int intNumOfPrint = (int)numOfPrint;
            
            for (int i = 0; i < intNumOfPrint; i++)
            {
                mut.WaitOne();
                Console.Write(sym);
                mut.ReleaseMutex();
                Thread.Sleep(frequency);
            }
        }
    }
}