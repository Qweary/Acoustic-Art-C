using System;
using System.Threading;
using NAudio.Midi;

namespace AudioPrototype
{
    class AudioPrototype
    {
        public static void Main()
        {
            //prototype of playing a scale
            MidiOut midiOut = new MidiOut(0);

            //c
            midiOut.Send(MidiMessage.StartNote(60, 127, 0).RawData);
            Thread.Sleep(1000);
            midiOut.Send(MidiMessage.StopNote(60, 0, 0).RawData);
            Thread.Sleep(100);

            //d
            midiOut.Send(MidiMessage.StartNote(62, 127, 0).RawData);
            Thread.Sleep(1000);
            midiOut.Send(MidiMessage.StopNote(62, 0, 0).RawData);
            Thread.Sleep(100);

            //e 
            midiOut.Send(MidiMessage.StartNote(64, 127, 0).RawData);
            Thread.Sleep(1000);
            midiOut.Send(MidiMessage.StopNote(64, 0, 0).RawData);
            Thread.Sleep(100);

            //f
            midiOut.Send(MidiMessage.StartNote(65, 127, 0).RawData);
            Thread.Sleep(1000);
            midiOut.Send(MidiMessage.StopNote(65, 0, 0).RawData);
            Thread.Sleep(100);

            //g
            midiOut.Send(MidiMessage.StartNote(67, 127, 0).RawData);
            Thread.Sleep(1000);
            midiOut.Send(MidiMessage.StopNote(67, 0, 0).RawData);
            Thread.Sleep(100);

            //a
            midiOut.Send(MidiMessage.StartNote(69, 127, 0).RawData);
            Thread.Sleep(1000);
            midiOut.Send(MidiMessage.StopNote(69, 0, 0).RawData);
            Thread.Sleep(100);

            //b
            midiOut.Send(MidiMessage.StartNote(71, 127, 0).RawData);
            Thread.Sleep(1000);
            midiOut.Send(MidiMessage.StopNote(71, 0, 0).RawData);
            Thread.Sleep(100);

            //c
            midiOut.Send(MidiMessage.StartNote(72, 127, 0).RawData);
            Thread.Sleep(1000);
            midiOut.Send(MidiMessage.StopNote(72, 0, 0).RawData);
            Thread.Sleep(100);

            midiOut.Close();
            midiOut.Dispose();
        }
    }
}
