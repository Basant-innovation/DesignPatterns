using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    //Facade class
    class MediaConverter
    {
        private IConverter _VideoConverter;
        private IConverter _AudioConverter;
        private IConverter _ImageConverter;

        public MediaConverter()
        {
            _VideoConverter = new Video();
            _AudioConverter = new Audio();
            _ImageConverter = new Image();
        }

        public void encodeMedia(String type)
        {
            switch (type)
            {
                case "video":
                    _VideoConverter.encode();
                    break;
                case "audio":
                    _AudioConverter.encode();
                    break;
                case "image":
                    _ImageConverter.encode();
                    break;
                default:
                    Console.Write("invalid option");
                    break;
            }
        }

        public void decodeMedia(String type)
        {
            switch (type)
            {
                case "video":
                    _VideoConverter.decode();
                    break;
                case "audio":
                    _AudioConverter.decode();
                    break;
                case "image":
                    _ImageConverter.decode();
                    break;
                default:
                    Console.Write("invalid option");
                    break;
            }
        }


        public void convertMedia(String type, string toFormat)
        {
            switch (type)
            {
                case "video":
                    _VideoConverter.convert(toFormat);
                    break;
                case "audio":
                    _AudioConverter.convert(toFormat);
                    break;
                case "image":
                    _ImageConverter.convert(toFormat);
                    break;
                default:
                    Console.Write("invalid option");
                    break;
            }
        }

    }
}
