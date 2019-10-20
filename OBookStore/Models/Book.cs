using System;
using System.Collections.Generic;

namespace OBookStore.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Object { get; set; }
        public string Caption { get; set; }
        public string Thumbnail { get; set; }
        public string Path { get; set; }
        public string Tags { get; set; }
        public string Categories { get; set; }
        public string CreationSource { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
