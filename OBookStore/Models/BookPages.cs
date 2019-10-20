using System;
using System.Collections.Generic;

namespace OBookStore.Models
{
    public partial class BookPages
    {
        public int Id { get; set; }
        public int LearningType { get; set; }
        public int RefId { get; set; }
        public string ContentPath { get; set; }
        public string PageTags { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationSource { get; set; }
    }
}
