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
        /* This class should accept a message and convert it to Morse Code.
         * complete the class below.
         */
        public MorseEncoder() 
        {
            /*Demonstrates how a single character can be translated to Morse Code
             * using the Dictionary (which is a Hash Table) below.
             * Note that this is NOT what should go into the constructor and is
             * just a demonstration.
             */
            char e = 'a';

            //Match the associated value with the "e" as the dictionary key.
            string morse_code = translation[e];
        }



        /* This is a dictionary that is used to store the translation table  
         * for converting your message to Morse Code
         */
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
            { ' ', "\\" },
        };
    }
}
