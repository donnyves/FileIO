using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {       
        public static void readTextFile(string path)
        {          
            ArrayList words = new ArrayList();
            try
            {
                string[] lines = File.ReadAllLines(path);
                Console.WriteLine($"{lines.Length} lines read");

                int blanklines = 0;
                foreach (var line in lines)
                {
                    if (line.Length < 1)                    
                        blanklines++;

                    foreach (var word in line.Split(' '))//Split() splits a string into substrings, that are based on characters in an array.
                    {
                        if (word.Trim(' ').Length > 0)
                            words.Add(word);
                    }
                }

                List<string> distinctWords = new List<string>();
                foreach (string word in words)
                {
                    //!distinct will "skip" all the (word)s, Contained() in the words ArrayList.
                    if (!distinctWords.Contains(word))//Distict words means that words do not repeat.
                    {
                        distinctWords.Add(word);
                    }
                }
                Console.WriteLine($"{blanklines} empty lines");
                Console.WriteLine($"{words.Count} words in the file.");              
                Console.WriteLine($"{distinctWords.Count} distinct words in the file.");
            }
            catch (FileNotFoundException)
            {

                Console.WriteLine("Can't find file for reading: ",path);
            }
        }





        static void Main(string[] args)
        {
            //ExceptionTest();
            string location = "C:\\Users\\donny\\OneDrive\\Desktop\\NOTES\\data.txt";// you have to add an extra backslash(\) in order to read the \.
            readTextFile(location);
            Console.ReadLine();
        }
    }
}

//ArrayList has the Add() function.
//ArrayList words = new ArrayList();// You have to use using System.Collections
//            try
//            {
//                string[] lines = File.ReadAllLines(path);
//Console.WriteLine($"{lines.Length} lines read");

//                int blanklines = 0;
//                foreach (var line in lines)//Compiled first. This will count the lines in the text document.
//                {
//                    if (line.Length< 1)//Checks the interger of the characters in the line, if it's less then 1 it counts a 
//                        //a blank line.  if(line == " ") would also work.
//                        blanklines++;//Counts the blank lines
//                    foreach (var word in line.Split(' '))Compiled second. //Nested foreach. The Split(' ') seperates the words
//                    {
//                        if (word.Trim(' ').Length > 0)//Trim(' ') means it is trimming the spaces greater than 0.
//                            words.Add(word);//Add() adds an object to the end of the ArrayList.
//                    }
//                }
//Console.WriteLine($"{blanklines} empty lines");
//Console.WriteLine($"{words.Count} words in the file."); the Count() method will count all the words in the file.

//                List<string> distinctWords = new List<string>();
//                foreach (string word in words)
//                {
//                    if (!distinctWords.Contains(word))//Distict words means that words do not repeat.
//                    {
//                        distinctWords.Add(word);
//                    }
//                }
//                Console.WriteLine($"{distinctWords.Count} distinct words in the file.");
