using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class Games
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameId { get; set; }

        public ICollection<UserScoreData> ScoreData { get; set; } = new List<UserScoreData>();

        [Required]
        [StringLength(255)]
        public string? GameName { get; set; }

        [Required]
        [StringLength(255)]
        public string? GameGenre { get; set; }

        [Required]
        public int TotalTime { get; set; }
    }
}
