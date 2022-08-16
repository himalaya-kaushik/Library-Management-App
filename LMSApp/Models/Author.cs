
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LMSApp.Models
{
    public partial class Author
    {
        [Key] public int AuthorId { get; set; }
        public string AuthorName { get; set; }

    }
}

