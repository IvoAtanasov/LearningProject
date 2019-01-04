namespace Learning.Infrastructure.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("Word")]
   public class Word
    {
        [Key]
        public long Id { get; set; }
        
        public string Text { get; set; }

        public string Translation { get; set; }
  
        public int LanguageID { get; set; }

        [ForeignKey(nameof(LanguageID))]
        public Language ForeignLanguage { get; set; }
    }
}
