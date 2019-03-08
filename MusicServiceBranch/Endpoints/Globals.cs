using System.ComponentModel;
using MusicService.Models;
using MusicService.Models.Enums;

namespace MusicService.Endpoints
{
    public partial class MusicService : IMusicService
    {
        private const int TotalNotes = 12;

        private const int NormalStep = 5;

        private const int ScaleLength = 8;

        public NoteSequence ReverseSequence(Scale scale)
        {
            NoteSequence seq = scale.ScaleNotes;

            NoteSharp[] reversed = new NoteSharp[seq.Length];
            for (int i = 0; i < seq.Length/2; i++)
            {
                int swapping = (seq.Length - 1) - i;
                
                reversed[i] = seq.Notes[swapping];

                reversed[swapping] = seq.Notes[i];
            }

            return new NoteSequence(reversed);
        }
    }
}
