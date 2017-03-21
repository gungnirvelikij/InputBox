using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputBox
{
    class Inputbox
    {
        private string input;
        private string text;
        private string title;

        public Inputbox()
        {
            
        }

        public Inputbox(string title, string text)
        {
            setText(text);
            setTitle(title);
        }

        public bool displayInputbox()
        {
            
        }

        public string getInput()
        {
            if (input != "" || input == null)
            {
                return input;
            }
            return "no input was given";
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setText(string text)
        {
            this.text = text;
        }

        public string getTitle()
        {
            return title;
        }

        public string getText()
        {
            return text;
        }
    }
}
