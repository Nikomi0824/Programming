using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Song
    {
        private string _executor;
        private string _songTitle;
        private int _songTimeInMinutes;

        public string Executor
        {
            get { return _executor; }
            set{ _executor = value; }
        }
        public int SongTimeInMinutes
        {
            get { return _songTimeInMinutes; }
            set { _songTimeInMinutes = value *60;}
        }
        public string SongTitle
        {
            get { return _songTitle; }
            set { _songTitle = value; }
        }
        public Song(string executor, string songTitle, int songTimeInMinutes)
        {
            Executor= executor;
            SongTitle= songTitle;
            SongTimeInMinutes = songTimeInMinutes;
        
        }
        public Song() { }
    }
}
