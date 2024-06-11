using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tvmlesson8CF.Models
{
    public class TvmCategory
    {
        [Key]
        public int TvmCategoryId { get; set; }
        public string TvmCategoryName { get; set; }

        // Navigation property
        public virtual ICollection<Tvmbook> Tvmbooks { get; set; }
    }
}
