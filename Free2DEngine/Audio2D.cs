using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio;
using NAudio.Wave;
using System.Threading;
public class Audio2D
{
    public static void QuickPlay(string dir)
    {
        Thread audio = new Thread(SimpleAudioThread);
        audio.Start((object)dir);
    }

    static void SimpleAudioThread(object dir)
    {
        using (var audioFile = new AudioFileReader((string)dir))
        {
            using (var output = new WaveOutEvent())
            {
                output.Init(audioFile);
                output.Play();
                while (output.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
