using MusicService;
using MusicService.Endpoints;
using MusicService.Models;
using MusicService.Models.Enums;
using NUnit.Framework;

namespace MusicServiceTests.Endpoints
{
    [TestFixture]
    public class ScaleTest
    {
        private IMusicService _service;

        public ScaleTest()
        {
            _service = new MusicService.Endpoints.MusicService();
        }

        [TestCase]
        public void Scale_MajorScale_C()
        {
            NoteSharp starting = NoteSharp.C;

            NoteSharp[] scale = { NoteSharp.C, NoteSharp.D, NoteSharp.E, NoteSharp.F, NoteSharp.G, NoteSharp.A, NoteSharp.B, NoteSharp.C},
                result = _service.BuildMajorScale(starting).ScaleNotes.Notes;
            
            Assert.AreEqual(scale.Length, result.Length, "Result scale is the wrong length.");

            for (var i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale[i], result[i], "Mismatch at index {0}", i);
            }
        }
        
        [TestCase]
        public void Scale_MajorScale_D()
        {
            NoteSharp starting = NoteSharp.D;

            NoteSharp[] scale = { NoteSharp.D, NoteSharp.E, NoteSharp.FSharp, NoteSharp.G, NoteSharp.A, NoteSharp.B, NoteSharp.CSharp, NoteSharp.D},
                result = _service.BuildMajorScale(starting).ScaleNotes.Notes;
            
            Assert.AreEqual(scale.Length, result.Length, "Result scale is the wrong length.");

            for (var i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale[i], result[i], "Mismatch at index {0}", i);
            }
        }
        
        [TestCase]
        public void Scale_MajorScale_G()
        {
            NoteSharp starting = NoteSharp.G;

            NoteSharp[] scale = { NoteSharp.G, NoteSharp.A, NoteSharp.B, NoteSharp.C, NoteSharp.D, NoteSharp.E, NoteSharp.FSharp, NoteSharp.G},
                result = _service.BuildMajorScale(starting).ScaleNotes.Notes;
            
            Assert.AreEqual(scale.Length, result.Length, "Result scale is the wrong length.");

            for (var i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale[i], result[i], "Mismatch at index {0}", i);
            }
        }
        
        [TestCase]
        public void Scale_MinorScale_A()
        {
            NoteSharp starting = NoteSharp.A;

            NoteSharp[] scale = { NoteSharp.A, NoteSharp.B, NoteSharp.C, NoteSharp.D, NoteSharp.E, NoteSharp.F, NoteSharp.G, NoteSharp.A},
                result = _service.BuildMinorScale(starting).ScaleNotes.Notes;
            
            Assert.AreEqual(scale.Length, result.Length, "Result scale is the wrong length.");

            for (var i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale[i], result[i], "Mismatch at index {0}", i);
            }
        }
        
        [TestCase]
        public void Scale_MinorScale_D()
        {
            NoteSharp starting = NoteSharp.D;

            NoteSharp[] scale = { NoteSharp.D, NoteSharp.E, NoteSharp.F, NoteSharp.G, NoteSharp.A, NoteSharp.ASharp, NoteSharp.C, NoteSharp.D},
                result = _service.BuildMinorScale(starting).ScaleNotes.Notes;
            
            Assert.AreEqual(scale.Length, result.Length, "Result scale is the wrong length.");

            for (var i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale[i], result[i], "Mismatch at index {0}", i);
            }
        }
        
        
        [TestCase]
        public void Scale_MinorScale_B()
        {
            NoteSharp starting = NoteSharp.B;

            NoteSharp[] scale = { NoteSharp.B, NoteSharp.CSharp, NoteSharp.D, NoteSharp.E, NoteSharp.FSharp, NoteSharp.G, NoteSharp.A, NoteSharp.B},
                result = _service.BuildMinorScale(starting).ScaleNotes.Notes;
            
            Assert.AreEqual(scale.Length, result.Length, "Result scale is the wrong length.");

            for (var i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale[i], result[i], "Mismatch at index {0}", i);
            }
        }
        
        [TestCase]
        public void Scale_Harmonic_C()
        {
            NoteSharp starting = NoteSharp.C;

            NoteSharp[] scale = { NoteSharp.C, NoteSharp.D, NoteSharp.DSharp, NoteSharp.F, NoteSharp.G, NoteSharp.GSharp, NoteSharp.B, NoteSharp.C},
                result = _service.BuildHarmonicScale(starting).ScaleNotes.Notes;
            
            Assert.AreEqual(scale.Length, result.Length, "Result scale is the wrong length.");

            for (var i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale[i], result[i], "Mismatch at index {0}", i);
            }
        }
        
        [TestCase]
        public void Scale_Harmonic_D()
        {
            NoteSharp starting = NoteSharp.D;

            NoteSharp[] scale = { NoteSharp.D, NoteSharp.E, NoteSharp.F, NoteSharp.G, NoteSharp.A, NoteSharp.ASharp, NoteSharp.CSharp, NoteSharp.D},
                result = _service.BuildHarmonicScale(starting).ScaleNotes.Notes;
            
            Assert.AreEqual(scale.Length, result.Length, "Result scale is the wrong length.");

            for (var i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale[i], result[i], "Mismatch at index {0}", i);
            }
        }
        
        [TestCase]
        public void Scale_Harmonic_A()
        {
            NoteSharp starting = NoteSharp.A;

            NoteSharp[] scale = { NoteSharp.A, NoteSharp.B, NoteSharp.C, NoteSharp.D, NoteSharp.E, NoteSharp.F, NoteSharp.GSharp, NoteSharp.A},
                result = _service.BuildHarmonicScale(starting).ScaleNotes.Notes;
            
            Assert.AreEqual(scale.Length, result.Length, "Result scale is the wrong length.");

            for (var i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale[i], result[i], "Mismatch at index {0}", i);
            }
        }

        [TestCase]
        public void Scale_ReverseScale_C()
        {
            NoteSequence scale = new NoteSequence(new [] { NoteSharp.C, NoteSharp.D, NoteSharp.E, NoteSharp.F, NoteSharp.G, NoteSharp.A, NoteSharp.B, NoteSharp.C}),
                result = _service.ReverseSequence(scale);
            
            Assert.AreEqual(scale.Length, result.Length);

            for (int i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale.Notes[i], result.Notes[(scale.Length - 1) - i], "Mismatch on index {0}", i);
            }
        }

        [TestCase]
        public void Scale_ReverseScale_AMinor()
        {
            NoteSequence scale = new NoteSequence(new NoteSharp[]{ NoteSharp.A, NoteSharp.B, NoteSharp.C, NoteSharp.D, NoteSharp.E, NoteSharp.F, NoteSharp.G, NoteSharp.A}),
                result = _service.ReverseSequence(scale);
            
            Assert.AreEqual(scale.Length, result.Length);

            for (int i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale.Notes[i], result.Notes[(scale.Length - 1) - i], "Mismatch on index {0}", i);
            }
        }

        [TestCase]
        public void Scale_ReverseScale_GSharp()
        {
            NoteSequence scale = new NoteSequence(new NoteSharp[] { NoteSharp.GSharp, NoteSharp.ASharp, NoteSharp.C, NoteSharp.CSharp, NoteSharp.DSharp, NoteSharp.F, NoteSharp.G, NoteSharp.GSharp}),
                result = _service.ReverseSequence(scale);
            
            Assert.AreEqual(scale.Length, result.Length);

            for (int i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale.Notes[i], result.Notes[(scale.Length - 1) - i], "Mismatch on index {0}", i);
            }
        }
        
        [TestCase]
        public void Scale_Melodic_C()
        {
            NoteSharp starting = NoteSharp.C;

            NoteSequence scale = new NoteSequence(new NoteSharp[] { NoteSharp.C, NoteSharp.D, NoteSharp.DSharp, NoteSharp.F, NoteSharp.G, NoteSharp.A, NoteSharp.B, NoteSharp.C, NoteSharp.ASharp, NoteSharp.GSharp, NoteSharp.G, NoteSharp.F, NoteSharp.DSharp, NoteSharp.D, NoteSharp.C}),
                result = new NoteSequence(_service.BuildMelodicScale(starting).ScaleNotes);
            
            Assert.AreEqual(scale.Length, result.Length, "Result scale is the wrong length.");

            for (var i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale.Notes[i], result.Notes[i], "Mismatch at index {0}", i);
            }
        }

        [TestCase]
        public void Scale_Melodic_A()
        {
            NoteSharp starting = NoteSharp.A;

            NoteSequence scale = new NoteSequence(new NoteSharp[] { NoteSharp.A, NoteSharp.B, NoteSharp.C, NoteSharp.D, NoteSharp.E, NoteSharp.FSharp, NoteSharp.GSharp, NoteSharp.A, NoteSharp.G, NoteSharp.F, NoteSharp.E, NoteSharp.D, NoteSharp.C, NoteSharp.B, NoteSharp.A}),
                result = new NoteSequence(_service.BuildMelodicScale(starting).ScaleNotes);
            
            Assert.AreEqual(scale.Length, result.Length, "Result scale is the wrong length.");

            for (var i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale.Notes[i], result.Notes[i], "Mismatch at index {0}", i);
            }
        }

        [TestCase]
        public void Scale_Melodic_F()
        {
            NoteSharp starting = NoteSharp.F;

            NoteSequence scale = new NoteSequence(new NoteSharp[] { NoteSharp.F, NoteSharp.G, NoteSharp.GSharp, NoteSharp.ASharp, NoteSharp.C, NoteSharp.D, NoteSharp.E, NoteSharp.F, NoteSharp.DSharp, NoteSharp.CSharp, NoteSharp.C, NoteSharp.ASharp, NoteSharp.GSharp, NoteSharp.G, NoteSharp.F}),
                result = new NoteSequence(_service.BuildMelodicScale(starting).ScaleNotes);
            
            Assert.AreEqual(scale.Length, result.Length, "Result scale is the wrong length.");

            for (var i = 0; i < scale.Length; i++)
            {
                Assert.AreEqual(scale.Notes[i], result.Notes[i], "Mismatch at index {0}", i);
            }
        }


    }
}