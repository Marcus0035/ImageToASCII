using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ImageToASCII_Projekt
{
    internal class Funkce
    {

        public static int getBrightness(Color color)
        {
            return (int)Math.Floor((0.2126 * color.R + 0.7152 * color.G + 0.0722 * color.B));       //(na co to potrebuji zaokrouhlit)
        }

        public static string getLetter(int brightness)              //podle jasu priradi char
        {
            if (brightness <= 0)
            {
                return "#";
            }
            else if (brightness > 0 && brightness <= 25)
            {
                return "X";
            }
            else if (brightness > 25 && brightness <= 50)
            {
                return "%";
            }
            else if (brightness > 50 && brightness <= 75)
            {
                return "&";
            }
            else if (brightness > 75 && brightness <= 125)
            {
                return "*";
            }
            else if (brightness > 125 && brightness <= 175)
            {
                return "+";
            }
            else if (brightness > 175 && brightness <= 200)
            {
                return "/";
            }
            else if (brightness > 200 && brightness <= 220)
            {
                return "(";
            }
            else if (brightness > 220 && brightness <= 245)
            {
                return "'";
            }
            else if (brightness >= 245)
            {
                return " ";
            }

            else
            {
                return "TADYYYYYYYYYYYYYYYYYY je brightnes " + brightness.ToString();           //teoreticky by se to sem nemelo ani dostat, slouzilo primarne pri psani
                                                                                                //abych nasel, kde je chyba
            }
        }


        public static string Program(string path, int scaling)
        {
            string imageFromText = "";

            //Image image = Image.FromFile(path);
            Bitmap bitmap = new Bitmap(path);

            int width = bitmap.Width;
            int height = bitmap.Height;

            Color pixel;            //deklarovani predem pro prehlednost
            int brightness;
            string character;

            for (int i = 0; i < height; i += scaling)               //projede celou fotku (2D) a priradi k pixelu jeho jas -> char
            {
                for (int j = 0; j < width; j += scaling)
                {
                    pixel = bitmap.GetPixel(j, i);

                    brightness = Funkce.getBrightness(pixel);
                    character = Funkce.getLetter(brightness);

                    imageFromText += character + " ";
                }
                imageFromText += Environment.NewLine;
            }

            return imageFromText;
        }
    }
}

