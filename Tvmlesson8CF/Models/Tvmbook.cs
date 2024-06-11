using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tvmlesson8CF.Models
{
    public class Tvmbook
    {
        [Key]
        public int TvmBookId { get; set; }
        public string TvmTitle { get; set; }
        public string TvmAuthor { get; set; }
        public int TvmYear { get; set; }
        public string TvmPublisher { get; set; }
        public int MyProperty { get; set; }
        public string TvmPicture { get; set; }
        public int TvmCategoryId { get; set; }
        // Thuộc tính quan hệ
        public virtual TvmCategory TvmCategory { get; set; }
    }
}
