using LingoGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLingo.Models
{
    public class LingoModel
    {
        public List<LingoWord> Guesses { get; set; }
        public int Attempt { get; set; }
        public string YourIQ { get; set; }
        public bool Finished { get; set; }

        public LingoWord WordToBeGuessed { get; set; }
    }
}