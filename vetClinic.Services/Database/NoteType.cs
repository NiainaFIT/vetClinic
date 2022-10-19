using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class NoteType
    {
        public NoteType()
        {
            Notes = new HashSet<Note>();
        }

        public int NoteTypeId { get; set; }
        public string NoteName { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}
