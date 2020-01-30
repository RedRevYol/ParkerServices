using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ParkersServices
{
    public class CommentModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(256)]
        public string OrganizationName { get; set; }

        [Required]
        [MaxLength(256)]
        public string User { get; set; }

        [Required]
        [MaxLength(2048)]
        public string Post { get; set; }
    }
}
