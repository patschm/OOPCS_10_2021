using System;
using System.Collections;

namespace LingoGame
{
    public class LingoWord : IEnumerable
    {
        private readonly LingoCharacter[] internalWord;

        public int Count 
        { 
            get
            {
                return internalWord.Length;
            }
        }
        public LingoCharacter this[int i]
        {
            get
            {
                if (i >= 0 && i < internalWord.Length)
                {
                    return internalWord[i];
                }
                return null;
            }
            set
            {
                if (i >= 0 && i < internalWord.Length)
                {
                    internalWord[i] = value;
                }
            }
        }
        public void Show(IDevice device)
        {
            for(int i = 0; i < internalWord.Length; i++)
            {
                this.internalWord[i].Draw(device);
            }
            Console.WriteLine();
        }
        public static LingoWord Examine(LingoWord targetWord, LingoWord guess)
        {
            CharCounter counter = new CharCounter(targetWord);
            LingoWord resulting = new LingoWord(guess.ToString());
            for (int i = 0; i < guess.Count; i++)
            {
                LingoCharacter guessChar = guess[i];
                foreach (LingoCharacter targetChar in targetWord)
                {
                    if (LingoCharacter.ExactlyEqual(targetChar, guessChar))
                    {
                        counter.DecrementCharacterCount(targetChar);
                        resulting[i] = LingoCharacter.Create<ExactCharacter>(guessChar.Character, guessChar.Position);
                    }
                }
            }
            for (int i = 0; i < guess.Count; i++)
            {
                LingoCharacter guessChar = guess[i];
                foreach (LingoCharacter thisChar in targetWord)
                {
                    if (!guessChar.IsExact() &&
                        counter.IsCharacterInWord(guessChar) &&
                        LingoCharacter.PartialEqual(thisChar, guessChar))
                    {
                        counter.DecrementCharacterCount(thisChar);
                        resulting[i] = LingoCharacter.Create<PartialCharacter>(guessChar.Character, guessChar.Position);
                    }
                }
            }
            return resulting;
        }
        public IEnumerator GetEnumerator()
        {
            return internalWord.GetEnumerator();
        }
        public override string ToString()
        {
            char[] chars = new char[internalWord.Length];
            for (int i = 0; i < internalWord.Length; i++)
            {
                chars[i] = internalWord[i].Character;
            }
            return new string(chars);
        }
        public LingoWord(string word)
        {
            this.internalWord = new LingoCharacter[word.Length];
            for(int i = 0; i < word.Length;i++)
            {
                LingoCharacter ch = LingoCharacter.Create<LingoCharacter>(word[i], i);
                this.internalWord[i] = ch;
            }
        }
    }
}
