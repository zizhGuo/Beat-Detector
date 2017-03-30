using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace APITest2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            var soundFile = "QHC.wav";
            var wfr = new WaveFileReader(soundFile);
            WaveChannel32 wc = new WaveChannel32(wfr);
            var audioOutput = new DirectSoundOut();

            wfr.Read(data, 0, 100);

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(data[i]);
            }

            audioOutput.Init(wc);
            audioOutput.Play();

            while (true) ;
        }
    }
}
