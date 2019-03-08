using MusicService;
using MusicService.Models.Enums;
using NUnit.Framework;

namespace MusicServiceTests.Endpoints
{
    [TestFixture]
    public class NoteManipulationTest
    {
        private IMusicService _service;

        public NoteManipulationTest()
        {
            _service = new MusicService.Endpoints.MusicService();
        }

        [TestCase]
        public void NoteManipulation_GetInterval_MinorThird()
        {
            NoteSharp starting = NoteSharp.A, expected = NoteSharp.C;

            NoteSharp ending = _service.GetNextNoteByInterval(starting, Interval.Minor3);
            
            Assert.AreEqual(expected, ending);
        }
        
        [TestCase]
        public void NoteManipulation_GetInterval_PerfectFourth()
        {
            NoteSharp starting = NoteSharp.G, expected = NoteSharp.CSharp;

            NoteSharp ending = _service.GetNextNoteByInterval(starting, Interval.Perfect4);
            
            Assert.AreEqual(expected, ending);
        }
        
        [TestCase]
        public void NoteManipulation_GetInterval_DiminishedFifth()
        {
            NoteSharp starting = NoteSharp.DSharp, expected = NoteSharp.A;

            NoteSharp ending = _service.GetNextNoteByInterval(starting, Interval.Diminished5);
            
            Assert.AreEqual(expected, ending);
        }
        
        [TestCase]
        public void NoteManipulation_GetInterval_MinorSeventh()
        {
            NoteSharp starting = NoteSharp.ASharp, expected = NoteSharp.GSharp;

            NoteSharp ending = _service.GetNextNoteByInterval(starting, Interval.Minor7);
            
            Assert.AreEqual(expected, ending);
        }

        [TestCase]
        public void NoteManipulation_GetInterval_MinorSecond()
        {
            NoteSharp starting = NoteSharp.GSharp, expected = NoteSharp.A;

            NoteSharp ending = _service.GetNextNoteByInterval(starting, Interval.Minor2);
            
            Assert.AreEqual(expected, ending);
        }

        [TestCase]
        public void NoteManipulation_RelativeMinor_C()
        {
            NoteSharp starting = NoteSharp.C, expected = NoteSharp.A;

            NoteSharp ending = _service.FindRelativeMinor(starting);
            
            Assert.AreEqual(expected, ending);
        }
        
        [TestCase]
        public void NoteManipulation_RelativeMinor_D()
        {
            NoteSharp starting = NoteSharp.D, expected = NoteSharp.B;

            NoteSharp ending = _service.FindRelativeMinor(starting);
            
            Assert.AreEqual(expected, ending);
        }
        
        [TestCase]
        public void NoteManipulation_RelativeMinor_A()
        {
            NoteSharp starting = NoteSharp.A, expected = NoteSharp.FSharp;

            NoteSharp ending = _service.FindRelativeMinor(starting);
            
            Assert.AreEqual(expected, ending);
        }
        
        [TestCase]
        public void NoteManipulation_RelativeMajor_C()
        {
            NoteSharp starting = NoteSharp.C, expected = NoteSharp.DSharp;

            NoteSharp ending = _service.FindRelativeMajor(starting);
            
            Assert.AreEqual(expected, ending);
        }
        
        [TestCase]
        public void NoteManipulation_RelativeMajor_D()
        {
            NoteSharp starting = NoteSharp.D, expected = NoteSharp.F;

            NoteSharp ending = _service.FindRelativeMajor(starting);
            
            Assert.AreEqual(expected, ending);
        }
        
        [TestCase]
        public void NoteManipulation_RelativeMajor_A()
        {
            NoteSharp starting = NoteSharp.A, expected = NoteSharp.C;

            NoteSharp ending = _service.FindRelativeMajor(starting);
            
            Assert.AreEqual(expected, ending);
        }



    }
}