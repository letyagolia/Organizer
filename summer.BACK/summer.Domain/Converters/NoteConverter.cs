using summer.Domain.Dto;
using summer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace summer.Domain.Converters
{
    public static class NoteConverter
    {
        public static Note Convert(NoteDto note)
        {
            return new Note
            {
                Id = note.Id,
                Name = note.Name,
                Text = note.Text,
                DateFrom = note.DateFrom,
                DateTo = note.DateTo,
                Importance = note.Importance,
                FolderId = note.FolderId,
                Done = note.Done
            };
        }

        public static NoteDto Convert(Note note)
        {
            return new NoteDto
            {
                Id = note.Id,
                Name = note.Name,
                Text = note.Text,
                DateFrom = note.DateFrom,
                DateTo = note.DateTo,
                Importance = note.Importance,
                FolderId = note.FolderId,
                Done = note.Done
            };
        }

        public static List<Note> Convert(List<NoteDto> notes)
        {
            return notes.Select(a => Convert(a)).ToList();
        }
        public static List<NoteDto> Convert(List<Note> notes)
        {
            return notes.Select(a => Convert(a)).ToList();
        }
    }
}
