using System;
using System.Collections.Generic;
using System.Text;
using MusicService.Models.Enums;

namespace MusicService.Models
{
    public class Scale
    {
        public NoteSharp FirstNote { get; set; }
        public ScaleStyle ScaleStyle { get; set; }
        public NoteSequence ScaleNotes { get; set; }

        public Scale(NoteSharp firstNote, ScaleStyle scaleStyle, NoteSequence scaleNotes)
        {
            FirstNote = firstNote;
            ScaleStyle = scaleStyle;
            ScaleNotes = scaleNotes;
        }


    }
}
