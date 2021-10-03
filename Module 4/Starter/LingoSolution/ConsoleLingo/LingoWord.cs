using System;

namespace ConsoleLingo
{
    public class LingoWord
    {
        public readonly LingoCharacter[] internalWord;

        /// <summary>
        /// Indexer to make LingoWord behave like an array
        /// </summary>
        /// <param name="idx">index of collection</param>
        /// <returns>LingoCharacter</returns>
        public LingoCharacter this[int idx]
        {
            get
            {
                if (idx >= 0 && idx < internalWord.Length)
                {
                    return internalWord[idx];
                }
                return null;
            }
            set
            {
                if (idx >= 0 && idx < internalWord.Length)
                {
                    internalWord[idx] = value;
                }
            }
        }
        public int Count
        {
            get
            {
                return internalWord.Length;
            }
        }

        public void Show()
        {
            for (int i = 0; i < internalWord.Length; i++)
            {
                this.internalWord[i].Draw();
            }
            Console.WriteLine();
        }

        // TODO 3: Since the AreEqual technically doesn't belong to a specific
        // LingoWord (just like the + sign doesn't belong to any number) remodel
        // this method to a static one.
        public bool AreEqual(LingoWord guess)
        {
            for (int i = 0; i < Count; i++)
            {
                if (guess.internalWord[i].Character != this.internalWord[i].Character)
                {
                    return false;
                }
            }
            return true;
        }

        public LingoWord(string word)
        {
            this.internalWord = new LingoCharacter[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                LingoCharacter ch = new LingoCharacter(word[i], i);
                this.internalWord[i] = ch;
            }
        }
    }
}
