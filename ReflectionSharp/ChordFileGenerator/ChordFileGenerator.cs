using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace ChordFileGenerator
{

    public class ChordFileGenerator
    {
        public string SongName { get; set; }
        public string Artist { get; set; }
        public FileType FileType { get; set; }

        private List<string> lines;

        public ChordFileGenerator()
        {
            lines = new List<string>();
        }

        public void LineAdd(string chords, string lyrics)
        {
            LineAdd(chords);
            LineAdd(lyrics);
        }

        public void LineAdd(string lyrics)
        {
            lines.Add(lyrics);

        }

        public void FileSaving(string Name)
        {
            string value = GenerateFileContents();
            File.WriteAllText(Name, value);
        }

        private string GenerateFileContents()
        {
            StringBuilder value = new StringBuilder();
            value.AppendLine("SongName: " + SongName);
            value.AppendLine("Artist: " + Artist);

            switch (FileType)
            {
                case FileType.Chords:
                    value.AppendLine("Type: Chords");
                    break;

                case FileType.Tab:
                    value.AppendLine("Type: Tab");
                    break;

                default:
                    value.AppendLine("Type: Lyrics");
                    break;
            }

            foreach (string l in lines)
            {
                value.AppendLine(l);
            }
            return value.ToString();
        }
    }

    public enum FileType
    {
        Chords,Tab, Lyrics
    }
  
}
