namespace Edabit.VERI_HARD
{
    class Instrument
    {
        public string Name;
        public Note LowestNote;
        public Note HighestNote;
        

        public Instrument(string name, Note lowestNote, Note highestNote)
        {
            Name = name;
            LowestNote = lowestNote;
            HighestNote = highestNote;
            
        }
        public bool IsValidNote(Note note)
        {
            var isValidOctav = note.Octav >= LowestNote.Octav && note.Octav <= HighestNote.Octav;
            bool isValidNote = note.Character >= LowestNote.Character && note.Character <= HighestNote.Character;

            return isValidOctav && isValidNote;
        }
    }
}