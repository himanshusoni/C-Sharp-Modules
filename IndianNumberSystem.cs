/*
 ********************** CONVERT NUMBERS TO WORDS W.R.T. INDIAN CURRENCY VERBAL FORMS (Version 0)**********************
 *************************************** Author- UJay(jadhav.utkarsh@gmail.com) Date-23 January 2014 *********************
 *********************************************************************************************************************
 *HOW TO ADD-
 *
 * Solution Explorer>Right Click>Add> Add Existing Item...>
 * 
 * 
 *EXAMPLE-
 *
 * 1) Create object of IndianNumberSystem.
 *      IndianNumberSystem nu = new IndianNumberSystem();
 *      
 * 2) Methods-
 *      I)    for string without formatting [only one parameter int]
 *            string str=nu.convertNumToWord(69); output- Sixty-nine
 *            
 *      II)   for string with prefix rupees[Two parameters int,string]
 *            string str=nu.convertNumToWord(169,"r"); output- rupees one hundred and sixty-nine
 *            
 *      III)  for titled string i.e. each starting letter in uppercase[Two parameters int,string]
 *            string str=nu.convertNumToWord(1169,"t") output - One Thousand One Hundred And Sixty-nine
 *            
 *      IV)   for slash dash symbol "/-" at the end use "s" in 2nd parameter[Two parameters int,string]
 *            string str=nu.convertNumToWord(1169,"st") output - One Thousand One Hundred And Sixty-nine/-
 *            
 *      V)    for suffix "only" after word use "o" in second parameter[Two parameters int,string]
 *            string str=nu.convertNumToWord(1169,"ost") output - One Thousand One Hundred And Sixty-nine Only/-
 *      
 *      VI)   using all i.e. "rost"
 *            string str=nu.convertNumToWord(1169,"rost") output - Rupees One Thousand One Hundred And Sixty-nine Only/-
 *      
 *****************************************************************************************************************
 *
 *****************************************************************************************************************
 *****************In case of bugs, and suggestions, shoot an email on jadhav.utkarsh@gmail.com********************
 *
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
namespace IndianNumberSystem
{
    class IndianNumberSystem
    {
        
        private uint crore= 10000000;
        private uint lakh = 100000;
        private uint thou = 1000;
        private uint hun = 100;

        //PUBLIC "convertNumToWord" Methods
        public string convertNumToWord(uint number,string para)
        {

            String word = convertToName(number);

            if (para.Contains("r"))
                 word = "rupees " + word;
            if (para.Contains("o"))
                word +=" only";
            if (para.Contains("s"))
                word +="/-";
            if (para.Contains("t"))
            {
                string temp_word = make_it_titled(word);
                word = temp_word;
            }
                    
            return word;
        }

        
        //FOR NUMBERS WITHOUT ANY ADDITIONAL FORMATTING
        public string convertNumToWord(uint num)
        {
            string temp_word=convertToName(num);
            string word = make_it_titled(temp_word);
            return word;

        }


        //PRIVATE METHODS
        
        //CONVERT NUMBERS TO NAME
        private string convertToName(uint number)
        {

            string word = "";
            
            if (number == 0)
            {
                word = "zero";
                return word;
            }

            if ((number / crore) > 0)
            {
               
                if ((number / crore)> 1)
                    word += convertToName(number / crore) + " crores ";
                else
                    word += convertToName(number / crore) + " crore ";
                number %= crore;
            }
            if ((number / lakh) > 0)
            {
                word += convertToName(number / lakh) + " lakh";
                if ((number / lakh) > 1)
                    word += "s ";
                number %= lakh;
            }
            if ((number / thou) > 0)
            {
                word += convertToName(number / thou) + " thousand ";
                number %= thou;
            }

            if ((number / hun) > 0)
            {
                word += convertToName(number / hun) + " hundred ";
                number %= hun;
            }

            if (number > 0)
            {
                if (number < 1000)
                {
                    if (word != "")
                        word += "and ";
                }
                var unitPos = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tenPos = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    word += unitPos[number];
                else
                {
                    word += tenPos[number / 10];
                    if ((number % 10) > 0)
                        word +="-" + unitPos[number % 10];
                }
            }

            return word;
        }

        //MAKE THE STRING TITLED i.e. MAKE EVERY FIRST ALPHABET IN UPPERCASE
        private String make_it_titled(String word)
        {
            char[] words = new char[5000];
            for (int i = 0; i < word.Length; i++)
            {
                if(i!=0)
                {

                if (word[i - 1] == ' ' & word[i]!='/')
                    words[i] = Convert.ToChar((int)word[i] - 32);
                else
                    words[i] = word[i];
                }
                else
                    words[i] = Convert.ToChar((int)word[i] - 32);

            }

            string temp_word = " ";
            for (int i = 0; i < words.Length; i++)
            {
                temp_word += words[i];
            }
            return temp_word;
        }

        //End of Class.
    }
}
