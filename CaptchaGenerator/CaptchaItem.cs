using CaptchaGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptchaGenerator
{
    class CaptchaItem
    {
        public Image Original { get; set; }
        public Image Processed { get; set; }
        public Image Symb1 { get; set; }
        public Image Symb2 { get; set; }
        public Image Symb3 { get; set; }
        public Image Symb4 { get; set; }
        public Image Symb5 { get; set; }
        public string Guess { get; set; }
        public string Answer { get; set; }
        public Image Status { get; set; }

        public CaptchaItem(Image original, Image processed, string guess, string answer,
            Image[] segments)
        {
            Original = original;
            Processed = processed;
            Guess = guess;
            Answer = answer;            
            Status = (Guess == Answer) ? Resources.accept : Resources.cancel;
            Symb1 = segments[0] ?? Resources.error;
            Symb2 = segments[1] ?? Resources.error;
            Symb3 = segments[2] ?? Resources.error;
            Symb4 = segments[3] ?? Resources.error;
            Symb5 = segments[4] ?? Resources.error;
        }
    }
}
