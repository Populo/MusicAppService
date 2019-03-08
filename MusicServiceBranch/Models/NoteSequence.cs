using System.Collections.Generic;
using MusicService.Models.Enums;

namespace MusicService.Models
{
    public class NoteSequence
    {
        public NoteSharp[] Notes { get; set; }
        public int Length { get
            {
                return Notes.Length;
            } }

        public NoteSequence() { }

        public NoteSequence(NoteSharp[] notes)
        {
            Notes = notes;
        }

        public NoteSequence(List<NoteSharp> notes)
        {
            Notes = notes.ToArray();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(NoteSequence))
            {
                var seq = (NoteSequence)obj;
                bool eq = true;

                if (seq.Length == Length)
                {
                    int i = 0;

                    while (eq && i <= Length)
                    {
                        if (seq.Notes[i] != Notes[i])
                        {
                            eq = false;
                        }
                    }

                    return eq;
                }
            }

            return false;
        }

        public override string ToString()
        {
            if (Notes == null || Notes.Length == 0) return "None";

            string s = "";

            for (int i = Notes.Length + 1; i > 0; --i)
            {
                s += string.Format("{0}: {1}", i, Notes[i - 1]);
            }

            return s;
        }
    }
}