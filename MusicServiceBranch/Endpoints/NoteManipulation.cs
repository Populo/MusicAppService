using System.Runtime.CompilerServices;
using MusicService.Models;
using MusicService.Models.Enums;

namespace MusicService.Endpoints
{
    public partial class MusicService : IMusicService
    {
        public NoteSharp FindRelativeMinor(NoteSharp major)
        {
            return GetNextNoteByInterval(major, Interval.Major6);
        }

        public NoteSharp FindRelativeMajor(NoteSharp minor)
        {
            return GetNextNoteByInterval(minor, Interval.Minor3);
        }

        public NoteSharp GetNextNoteByInterval(NoteSharp note, Interval interval)
        {
            if ((int) note + (int) interval == TotalNotes)
            {
                return (NoteSharp) TotalNotes;
            }

            var ending = ((int)note + (int)interval) % TotalNotes;

            return (NoteSharp) ending;
        }
    }
}