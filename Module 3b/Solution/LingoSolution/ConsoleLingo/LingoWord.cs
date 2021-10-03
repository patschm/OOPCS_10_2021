using System;

namespace ConsoleLingo
{
    public class LingoWord
    {
        // TODO 4a: Make this field private
        private readonly LingoCharacter[] internalWord;

        // TODO 4b: Define a readonly Count property which returns
        // the length of internalWord array.
        public int Count
        {
            get
            {
                return internalWord.Length;
            }
        }

        public LingoCharacter this[int idx]
        {
            get
            {
                return internalWord[idx];
            }
            set
            {
                if (idx >= 0 && idx < internalWord.Length)
                {
                    internalWord[idx] = value;
                }
            }
        }

        public void Show()
        {
            for(int i = 0; i < internalWord.Length; i++)
            {
                this.internalWord[i].Draw();
            }
            Console.WriteLine();
        }
        public bool AreEqual(LingoWord guess)
        {
            for(int i = 0; i < internalWord.Length; i++ )
            {
                if (guess[i].Character != this[i].Character)
                {                  
                    return false;
                }
            }          
            return true;
        }
        public LingoWord(string word)
        {
            this.internalWord = new LingoCharacter[word.Length];
            for(int i = 0; i < word.Length;i++)
            {
                this.internalWord[i] = new LingoCharacter(word[i], i);
            }
        }
    }
}
