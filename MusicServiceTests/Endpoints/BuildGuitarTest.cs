
using MusicService;
using MusicService.Endpoints;
using MusicService.Models;
using MusicService.Models.Enums;
using NUnit.Framework;

namespace MusicServiceTests.Endpoints
{
    [TestFixture]
    public class BuildGuitarTest
    {
        private readonly IMusicService _service;

        
        public BuildGuitarTest()
        {
            _service = new MusicService.Endpoints.MusicService();
        }

        [TestCase]
        public void Tuning_Standard_Seven()
        {
            NoteSharp topString = NoteSharp.B;

            Guitar g = new Guitar(7, TuningStyle.Standard, topString, "standard7");

            g.Strings = _service.BuildStandardTuning(g.NumberOfStrings, topString);

            Assert.IsTrue(g.Strings.Length == g.NumberOfStrings, "Incorrect Number of Strings, Expected {0} got {1}", g.NumberOfStrings, g.Strings.Length);

            NoteSharp[] realNote = { NoteSharp.B, NoteSharp.E, NoteSharp.A, NoteSharp.D, NoteSharp.G, NoteSharp.B, NoteSharp.E };

            for (int i = 0; i < g.NumberOfStrings; i++)
            {
                Assert.AreEqual(realNote[i], g.Strings.Notes[i], "Incorrect Note on string {0}", (1 + i));
            }
        }

        [TestCase]
        public void Tuning_DropTuning_ASeven()
        {
            NoteSharp topString = NoteSharp.A;

            Guitar g = new Guitar(7, TuningStyle.Drop, topString, "dropA7");

            g.Strings = _service.BuildDropTuning(g.NumberOfStrings, topString);

            Assert.IsTrue(g.Strings.Length == g.NumberOfStrings, "Incorrect Number of Strings, Expected {0} got {1}", g.NumberOfStrings, g.Strings.Length);

            NoteSharp[] realNote = { NoteSharp.A, NoteSharp.E, NoteSharp.A, NoteSharp.D, NoteSharp.G, NoteSharp.B, NoteSharp.E };

            for (int i = 0; i < g.NumberOfStrings; i++)
            {
                Assert.AreEqual(realNote[i], g.Strings.Notes[i], "Incorrect Note on string {0}", i + 1);
            }
        }

        [TestCase]
        public void Tuning_DropTuning_CSix()
        {
            NoteSharp topString = NoteSharp.C;

            Guitar g = new Guitar(6, TuningStyle.Drop, topString, "dropC6");

            g.Strings = _service.BuildDropTuning(g.NumberOfStrings, topString);

            Assert.IsTrue(g.Strings.Length == g.NumberOfStrings, "Incorrect Number of Strings, Expected {0} got {1}", g.NumberOfStrings, g.Strings.Length);

            NoteSharp[] realNote = { NoteSharp.C, NoteSharp.G, NoteSharp.C, NoteSharp.F, NoteSharp.A, NoteSharp.D };

            for (int i = 0; i < g.NumberOfStrings; i++)
            {
                Assert.AreEqual(realNote[i], g.Strings.Notes[i], "Incorrect Note on string {0}", i + 1);
            }
        }

        [TestCase]
        public void Tuning_DropTuning_BSix()
        {
            NoteSharp topString = NoteSharp.B;

            Guitar g = new Guitar(6, TuningStyle.Drop, topString, "dropB6");

            g.Strings = _service.BuildDropTuning(g.NumberOfStrings, topString);

            Assert.IsTrue(g.Strings.Length == g.NumberOfStrings, "Incorrect Number of Strings, Expected {0} got {1}", g.NumberOfStrings, g.Strings.Length);

            NoteSharp[] realNote = { NoteSharp.B, NoteSharp.FSharp, NoteSharp.B, NoteSharp.E, NoteSharp.GSharp, NoteSharp.CSharp };

            for (int i = 0; i < g.NumberOfStrings; i++)
            {
                Assert.AreEqual(realNote[i], g.Strings.Notes[i], "Incorrect Note on string {0}", i + 1);
            }
        }

        [TestCase]
        public void BuildDropGSevenString()
        {
            NoteSharp topString = NoteSharp.G;

            Guitar g = new Guitar(7, TuningStyle.Drop, topString, "dropG7");

            g.Strings = _service.BuildDropTuning(g.NumberOfStrings, topString);

            Assert.IsTrue(g.Strings.Length == g.NumberOfStrings, "Incorrect Number of Strings, Expected {0} got {1}", g.NumberOfStrings, g.Strings.Length);

            NoteSharp[] realNote = { NoteSharp.G, NoteSharp.D, NoteSharp.G, NoteSharp.C, NoteSharp.F, NoteSharp.A, NoteSharp.D };

            for (int i = 0; i < g.NumberOfStrings; i++)
            {
                Assert.AreEqual(realNote[i], g.Strings.Notes[i], "Incorrect Note on string {0}", i + 1);
            }
        }
    }
}
