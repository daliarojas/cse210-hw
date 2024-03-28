using System;
using System.Collections.Generic;
using System.Linq;

namespace Scripture
{
    public class Scripture
    {
        private List<Word> words = new List<Word>();
        private ScriptureReference reference;

        public Scripture(ScriptureReference reference, string text)
        {
            this.reference = reference;
            string[] wordArray = text.Split(' ');
            foreach (string word in wordArray)
            {
                words.Add(new Word(word));
            }
        }

        public void Display()
        {
            Console.WriteLine(reference.Reference);
            foreach (Word word in words)
            {
                if (word.Hidden)
                {
                    Console.Write(" [Hidden] ");
                }
                else
                {
                    Console.Write(word.Text + " ");
                }
            }
            Console.WriteLine("\n");
        }

        public bool HideRandomWord()
        {
            Random rnd = new Random();
            List<Word> visibleWords = words.Where(w => !w.Hidden).ToList();
            if (visibleWords.Count == 0)
            {
                return false;
            }
            int index = rnd.Next(visibleWords.Count);
            visibleWords[index].Hidden = true;
            return true;
        }

        public bool AllWordsHidden()
        {
            return words.All(w => w.Hidden);
        }
    }
}