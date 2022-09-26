using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21MoodAnlayazer
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            if (message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }

        }
    }
}
