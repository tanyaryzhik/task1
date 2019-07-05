using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class MultimediaDevice : Device
    {
        public int VolumeLevel { get; set; }

        public void ChangeVolumeLevel(int level)
        {
            this.VolumeLevel = level;
        }

        public void Mute()
        {
            this.VolumeLevel = 0;
        }
    }
}
