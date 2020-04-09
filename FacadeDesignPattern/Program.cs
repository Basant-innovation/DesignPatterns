using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaConverter mediaConvert = new MediaConverter();
            mediaConvert.encodeMedia("video");
            mediaConvert.encodeMedia("audio");
            mediaConvert.encodeMedia("image");

            mediaConvert.decodeMedia("video");
            mediaConvert.decodeMedia("audio");
            mediaConvert.decodeMedia("image");

            mediaConvert.convertMedia("video", "mp4");
            mediaConvert.convertMedia("audio", "mp3");
            mediaConvert.convertMedia("image", "jpg");

            Console.Read();
        }
    }
}
