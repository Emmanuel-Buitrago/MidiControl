﻿using NAudio.Midi;
using System.Collections.Generic;

namespace MidiControl
{
    public class MIDIFeedback
    {
        public static readonly IEnumerable<string> FeedBackDevices = new List<string> { "APC MINI", "APC MINI MK2", "Akai APC40", "Launchpad Mini", "Launchpad MK2", "Launchpad", "MIDIOUT2 (Launchkey Mini)"};

        private enum Devices
        {
            NONE,
            APC_MINI,
            APC_MINI_MK2,
            Launchpad_Mini,
            APC40,
            Launchpad_MK2,
            Launchpad,
            Launchkey_Mini
        }

        private readonly Devices deviceType = Devices.NONE;
        private readonly int channel = 0;
        private readonly int note = 0;
        public bool state = false;
        private readonly MidiOutCustom MidiOutdeviceFeedback;
        public MIDIFeedback(KeyBindEntry keybind)
        {
            channel = keybind.Channel;
            note = keybind.NoteNumber;
            foreach (var entry in MIDIListener.GetInstance().midiOutInterface)
            {
                if (MidiOut.DeviceInfo(entry.Value.device).ProductName == "APC MINI" && keybind.Mididevice == "APC MINI")
                {
                    MidiOutdeviceFeedback = entry.Value;
                    deviceType = Devices.APC_MINI;
                }
                else if (MidiOut.DeviceInfo(entry.Value.device).ProductName == "APC MINI MK2" && keybind.Mididevice == "APC MINI MK2")
                {
                    MidiOutdeviceFeedback = entry.Value;
                    deviceType = Devices.APC_MINI_MK2;
                }
                else if (MidiOut.DeviceInfo(entry.Value.device).ProductName == "Akai APC40" && keybind.Mididevice == "Akai APC40")
                {
                    MidiOutdeviceFeedback = entry.Value;
                    deviceType = Devices.APC40;
                }
                else if (MidiOut.DeviceInfo(entry.Value.device).ProductName == "Launchpad Mini" && keybind.Mididevice == "Launchpad Mini")
                {
                    MidiOutdeviceFeedback = entry.Value;
                    deviceType = Devices.Launchpad_Mini;
                }
                else if (MidiOut.DeviceInfo(entry.Value.device).ProductName == "Launchpad MK2" && keybind.Mididevice == "Launchpad MK2")
                {
                    MidiOutdeviceFeedback = entry.Value;
                    deviceType = Devices.Launchpad_MK2;
                }
                else if (MidiOut.DeviceInfo(entry.Value.device).ProductName == "Launchpad" && keybind.Mididevice == "Launchpad")
                {
                    MidiOutdeviceFeedback = entry.Value;
                    deviceType = Devices.Launchpad;
                }
                else if (MidiOut.DeviceInfo(entry.Value.device).ProductName == "MIDIOUT2 (Launchkey Mini)" && keybind.Mididevice == "MIDIIN2 (Launchkey Mini)")
                {
                    MidiOutdeviceFeedback = entry.Value;
                    deviceType = Devices.Launchkey_Mini;
                }
            }
        }
        public void SendOn()
        {
            state = true;
            MidiEvent me;
            switch (deviceType)
            {
                case Devices.APC_MINI:
                case Devices.APC_MINI_MK2:
                    me = new NoteOnEvent(0, channel, note, 21, 0);
                    break;
                case Devices.APC40:
                    me = new NoteOnEvent(0, channel, note, 01, 0);
                    break;
                case Devices.Launchpad_Mini:
                case Devices.Launchpad:
                    me = new NoteOnEvent(0, channel, note, 60, 0);
                    break;
                case Devices.Launchpad_MK2:
                    me = new NoteOnEvent(0, 1, note, 72, 0);
                    break;
                case Devices.Launchkey_Mini:
                    me = new NoteOnEvent(0, 1, note, 127, 0);
                    break;
                default:
                    return;
            }
            Send(me);
        }

        public void SendOff()
        {
            state = false;
            MidiEvent me;
            switch(deviceType)
            {
                case Devices.APC_MINI:
                case Devices.APC_MINI_MK2:
                    me = new NoteOnEvent(0, channel, note, 09, 0);
                    break;
                case Devices.APC40:
                    me = new NoteOnEvent(0, channel, note, 00, 0);
                    break;
                case Devices.Launchpad_Mini:
                case Devices.Launchpad:
                    me = new NoteOnEvent(0, channel, note, 12, 0);
                    break;
                case Devices.Launchpad_MK2:
                    me = new NoteOnEvent(0, 1, note, 0, 0);
                    break;
                case Devices.Launchkey_Mini:
                    me = new NoteOnEvent(0, 1, note, 0, 0);
                    break;
                default:
                    return;
            }
            Send(me);
        }
        public void SendIn()
        {
            state = true;
            MidiEvent me;
            switch (deviceType)
            {
                case Devices.APC_MINI:
                case Devices.APC_MINI_MK2:
                    me = new NoteOnEvent(0, channel, note, 13, 0);
                    break;
                case Devices.APC40:
                    me = new NoteOnEvent(0, channel, note, 02, 0);
                    break;
                case Devices.Launchpad_Mini:
                case Devices.Launchpad:
                    me = new NoteOnEvent(0, channel, note, 56, 0);
                    break;
                case Devices.Launchpad_MK2:
                    this.SendOn();
                    me = new NoteOnEvent(0, 2, note, 0, 0);
                    break;
                case Devices.Launchkey_Mini:
                    this.SendOn();
                    me = new NoteOnEvent(0, 1, note, 127, 0);
                    break;
                default:
                    return;
            }
            Send(me);
        }

        private void Send(MidiEvent me)
        {
            MidiOutdeviceFeedback.Send(me.GetAsShortMessage());
        }
    }
}
