using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class SmartSpeaker : MultimediaDevice
    {
        public enum Source
        {
            USB = 0,
            Bluetooth = 1,
            HDMI = 2
        }

        public Source SpeakerSource { get; set; }

        public void ChangeSoure()
        {
            this.SpeakerSource++;
        }
    }
}
