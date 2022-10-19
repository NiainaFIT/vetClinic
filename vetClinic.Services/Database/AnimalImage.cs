using System;
using System.Collections.Generic;

namespace vetClinic.Services.Database
{
    public partial class AnimalImage
    {
        public int AnimalImageId { get; set; }
        public string AnimalImageUrl { get; set; } = null!;
        public int AnimalId { get; set; }
        public string? Caption { get; set; }
        public bool IsMain { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int? ModifiedByUserId { get; set; }

        public virtual Animal Animal { get; set; } = null!;
    }
}
