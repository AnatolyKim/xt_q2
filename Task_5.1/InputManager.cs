using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winforms = System.Windows.Forms;
using System.Globalization;

namespace Task_5._1
{
    public class InputManager
    {
        public string SelectedPath { get; set; }
        private string message= "dd.MM.yyyy HH:mm";
        public string Message { get; set; }
        public DateTime InputTime { get; set; }

        public string UserInput { get; set; }

        public DateTime SetTime(string userInput)
        {
             return InputTime=DateTime.ParseExact(UserInput, "dd.MM.yyyy HH:mm",
                                CultureInfo.InvariantCulture);
        }
        public string ShowStatus()
        {
            return message;
        }
    }
}
