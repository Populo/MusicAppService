using System;
using System.Collections.Generic;
using System.Text;
using MusicService.Models.Enums;

namespace MusicService.Models
{
    public class Guitar
    {
        public string GuitarName { get; set; }
        public int NumberOfStrings { get; }
        public TuningStyle TuningStyle { get; }
        public NoteSequence Strings { get; set; }


        public Guitar(int strings, TuningStyle tuningStyle, NoteSharp topNote, string name)
        {
            NumberOfStrings = strings;
            TuningStyle = tuningStyle;
            GuitarName = name;
        }
    }
}
