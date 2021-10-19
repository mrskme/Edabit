using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edabit.VERI_HARD
{
    class MusicalInstrumentNoteRanges
    {
        //https://edabit.com/challenge/Z7bgqN8vK5gqrQpqL

        public static List<Instrument> Instruments = new List<Instrument>()
        {
            new Instrument("Piccolo", new Note('D',4), new Note('C',7)),
            new Instrument("Tuba", new Note('D',1), new Note('F',4)),
            new Instrument("Guitar", new Note('E',3), new Note('E',6)),
            new Instrument("Piano", new Note('A',0), new Note('C',8)),
            new Instrument("Violin", new Note('G',3), new Note('G',7)),
            new Instrument("Clarinet", new Note('E', 3), new Note('A',6))
        };
        public static bool InstrumentRange(string instrumentName, string note)
        {
            var choseninstrument = Instruments.First(i => i.Name == instrumentName);
            var chosenNote = new Note(note[0], Convert.ToInt32(note[1].ToString()));

            var isValidNote = choseninstrument.IsValidNote(chosenNote);

            return isValidNote;
        }
    }
}
