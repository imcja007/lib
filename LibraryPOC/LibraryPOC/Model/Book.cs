using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryPOC.Model
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Publisher { get; set; }
        public string DateOfIssue { get; set; }
        public float Price { get; set; }
        public int AuthorID { get; set; }

/*        [ForeignKey("AuthorID")]
        public Author Author { get; set; }
*/
    }
}
