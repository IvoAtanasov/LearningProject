namespace Learning.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    [Table("Languages")]
    public class Language
    {
        [Key]
        public int Id { get; set; }

        public string LanguageName { get; set; }
    }
}
