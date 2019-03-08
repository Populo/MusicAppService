using MusicService.Models;
using MusicService.Models.Enums;

namespace MusicService
{
    public interface IMusicService
    {
        NoteSequence BuildStandardTuning(int strings, NoteSharp lowNote);

        NoteSequence BuildDropTuning(int strings, NoteSharp lowNote);

        NoteSequence BuildScaleWithTwoHalfSteps(NoteSharp firstNote, int one, int two);

        NoteSequence ReverseSequence(Scale scale);
        
        Scale BuildMajorScale(NoteSharp firstNote);

        Scale BuildMinorScale(NoteSharp firstNote);

        Scale BuildHarmonicScale(NoteSharp firstNote);

        Scale BuildMelodicScale(NoteSharp firstNote);

        NoteSharp FindRelativeMinor(NoteSharp major);

        NoteSharp FindRelativeMajor(NoteSharp minor);

        NoteSharp GetNextNoteByInterval(NoteSharp note, Interval interval);
    }
}
