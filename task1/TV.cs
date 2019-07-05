using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class TV : MultimediaDevice
    {
        private List<string> channelList;

        public string CurrentChannel { get; set; }

        public void SearchChannel()
        {
            this.channelList.Clear();
            this.channelList.Add("firstChannel");
            this.channelList.Add("secondChannel");
            this.channelList.Add("thirdChannel");
        }

        public void SwithChannel(int indexOfChannel)
        {
            this.CurrentChannel = this.channelList[indexOfChannel];
        }
    }
}
