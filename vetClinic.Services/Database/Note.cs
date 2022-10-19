using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class Note
    {
        public int NoteId { get; set; }
        public string? NoteText { get; set; }
        public int NoteTypeId { get; set; }
        public int AnimalTreatementId { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual AnimalTreatement AnimalTreatement { get; set; } = null!;
        public virtual NoteType NoteType { get; set; } = null!;
    }
}
