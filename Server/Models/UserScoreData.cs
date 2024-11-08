using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class UserScoreData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScoreId { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User? User { get; set; }

        [Required]
        [ForeignKey(nameof(Games))]
        public int GameId { get; set; }
        public Games? Games { get; set; }

        [StringLength(255)]
        public string? GameStatus { get; set; }
        public float? TimePlayed { get; set; }
        public float? GameplayScore { get; set; }
        public float? StoryScore { get; set; }
        public float? GraphicScore { get; set; }
        public float? AudioScore { get; set; }
        public float? QualityScore { get; set; }
        public float? SumScore { get; set; }
    }
}
