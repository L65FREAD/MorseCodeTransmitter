/*

Program Author: Aayush Gautam

Assignment: Morse Code Transmitter

Description:

Encodes the morse code passed from the frontend

*/
using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSC_317_Program_3_Idea_Morse_Code_Player
{
    internal class MorseEncoder
    {
        private string message;
        private string morse_code;

        public MorseEncoder()
        {
            message = "";
            morse_code = "";
        }

        public MorseEncoder(string message) : this()
        {
            Text = message;
        }

        public string Text
        {
            get { return message; }
            set
            {
                message = value.ToLower();
                Translate();
            }
        }

        public string Morse
        {
            get { return morse_code; }
        }

        private void Translate()
        {
            StringBuilder morseBuilder = new StringBuilder();
            foreach (char c in message)
            {
                if (translation.ContainsKey(c))
                {
                    morseBuilder.Append(translation[c] + " ");
                }
                else if (c == ' ')
                {
                    morseBuilder.Append(translation[c] + " ");
                }
                else
                {
                    morseBuilder.Append("? ");
                }
            }
            morse_code = morseBuilder.ToString().Trim();
        }

        private static Dictionary<char, string> translation = new Dictionary<char, string>()
        {
            { 'a', ".-" },
            { 'b', "-..." },
            { 'c', "-.-." },
            { 'd', "-.." },
            { 'e', "." },
            { 'f', "..-." },
            { 'g', "--." },
            { 'h', "...." },
            { 'i', ".." },
            { 'j', ".---" },
            { 'k', "-.-" },
            { 'l', ".-.." },
            { 'm', "--" },
            { 'n', "-." },
            { 'o', "---" },
            { 'p', ".--." },
            { 'q', "--.-" },
            { 'r', ".-." },
            { 's', "..." },
            { 't', "-" },
            { 'u', "..-" },
            { 'v', "...-" },
            { 'w', ".--" },
            { 'x', "-..-" },
            { 'y', "-.--" },
            { 'z', "--.." },
            { '0', "-----" },
            { '1', ".-----" },
            { '2', "..---" },
            { '3', "...--" },
            { '4', "....-" },
            { '5', "....." },
            { '6', "-...." },
            { '7', "--..." },
            { '8', "---.." },
            { '9', "----." },
            { ' ', "/" },
        };
    }
}
