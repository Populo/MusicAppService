using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using MusicService.Models;
using MusicService.Models.Enums;

namespace MusicService.Endpoints
{
    public partial class MusicService : IMusicService
    {
        public NoteSequence BuildScaleWithTwoHalfSteps(NoteSharp firstNote, int one, int two)
        {
            var scale = new List<NoteSharp>();

            scale.Add(firstNote);

            NoteSharp currentNote = firstNote;
            for (var i = 1; i < ScaleLength; i++)
            {
                int step = 2;
                if (i == one || i == two)
                {
                    step = 1;
                }

                currentNote = GetNextNoteByInterval(currentNote, (Interval) step);
                scale.Add(currentNote);
            }

            return new NoteSequence(scale);
        }

        public Scale BuildMajorScale(NoteSharp firstNote)
        {
            return new Scale(firstNote, ScaleStyle.Major, BuildScaleWithTwoHalfSteps(firstNote, 3, 7));
        }

        public Scale BuildMinorScale(NoteSharp firstNote)
        {
            return new Scale(firstNote, ScaleStyle.Minor, BuildScaleWithTwoHalfSteps(firstNote, 2, 5));
        }

        public Scale BuildHarmonicScale(NoteSharp firstNote)
        {
            var scale = BuildMinorScale(firstNote);

            scale.ScaleNotes.Notes[6] = GetNextNoteByInterval(scale.ScaleNotes.Notes[6], Interval.Minor2);

            return scale;
        }

        public Scale BuildMelodicScale(NoteSharp firstNote)
        {
            Scale scaleObject = new Scale(firstNote, ScaleStyle.Melodic, null);
            var scale = BuildMinorScale(firstNote);
            var secondHalf = ReverseSequence(BuildMinorScale(firstNote));
            var fullScale = new NoteSharp[(ScaleLength * 2) - 1];
            
            scale.ScaleNotes.Notes[5] = GetNextNoteByInterval(scale.ScaleNotes.Notes[5], Interval.Minor2);
            scale.ScaleNotes.Notes[6] = GetNextNoteByInterval(scale.ScaleNotes.Notes[6], Interval.Minor2);

            for (int i = 0; i < ScaleLength; i++)
            {
                fullScale[i] = scale.ScaleNotes.Notes[i];
            }

            for (int i = 0; i < ScaleLength - 1; i++)
            {
                fullScale[ScaleLength  + i] = secondHalf.Notes[1 + (i % ScaleLength)];
            }

            scaleObject.ScaleNotes = new NoteSequence(fullScale);
            return scaleObject;
        }

    }
}