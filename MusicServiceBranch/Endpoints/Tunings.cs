using System.Collections.Generic;
using MusicService.Models;
using MusicService.Models.Enums;

namespace MusicService.Endpoints
{
    public partial class MusicService : IMusicService
    {
        public NoteSequence BuildStandardTuning(int strings, NoteSharp topNote)
        {
            var notes = new List<NoteSharp>();

            NoteSharp currentNote = topNote;

            notes.Add(currentNote);

            for (int i = 1; i < strings; i++)
            {
                int step = NormalStep;

                if (i == (strings - 2)) step -= 1;
                
                currentNote = GetNextNoteByInterval(currentNote, (Interval)step);

                notes.Add(currentNote);
            }

            return new NoteSequence(notes);
        }

        public NoteSequence BuildDropTuning(int strings, NoteSharp topNote)
        {
            var notes = new List<NoteSharp>();

            NoteSharp currentNote = topNote;

            notes.Add(currentNote);

            for (int i = 1; i < strings; i++)
            {
                int step = NormalStep;

                if (i == (strings - 2)) step -= 1;
                else if (i == 1) step += 2;
                
                currentNote = GetNextNoteByInterval(currentNote, (Interval)step);

                notes.Add(currentNote);
            }

            return new NoteSequence(notes);
        }
    }
}
