using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Models
{
    public partial class Word : IWords
    {
        public string _word { get; private set; }
        private static List<Word> _listOfWords = new List<Word>();

        private Word(string pWord)
        {
            _word = pWord;
            _listOfWords.Add(this);
        }
        public static Word AddWord(string pWord)
        {
            if (String.IsNullOrEmpty(pWord.Trim()))
                throw new Exception("Word cannot be empty or whitespaced.");

            Word _word = new Word(pWord);

            return _word;
        }
        public static IEnumerable<Word> GetWord(char pKey)
        {
            if (Char.IsWhiteSpace(pKey))
                throw new Exception("Key cannot be empty or whitespace");

            IEnumerable<Word> _wordsToReturn = (from words in _listOfWords where words._word.Substring(0, 1) == pKey.ToString() select words).Take(2);
            return _wordsToReturn;
        }

    }
}
