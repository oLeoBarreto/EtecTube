using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtecTube.Models
{
    [Table("Video")]
    public class Video
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public Guid ChannelId { get; set; }
        public Channel Channel { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [StringLength(8000)]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Data de Publicação")]
        public DateTime PublishedDate { get; set; }

        [StringLength(200)]
        [Display(Name = "Foto de Apresentação")]
        public string Thumbnail { get; set; }

        [Display(Name = "Gostei")]
        public uint Likes { get; set; }

        [Display(Name = "Não Gostei")]
        public uint Dislikes { get; set; }

        [Display(Name = "Visualizações")]
        public uint Visualizations { get; set; }

        [NotMapped]
        public string PassedTime {
             get { return PassedTimeCalculated(); }
        }

        // Método Construtor
        public Video()
        {
            PublishedDate = DateTime.Now;
            Likes = 0;
            Dislikes = 0;
            Visualizations = 0;
        }

        private string PassedTimeCalculated(){
            TimeSpan diff = DateTime.Now.Subtract(PublishedDate);
            if (diff.Days >= 365)
                return $"há { diff.Days / 365 } "
                    + ((diff.Days / 365) > 1 ? "anos" : "ano");
            else if (diff.Days >= 30)
                return $"há { diff.Days / 30 } "
                    + ((diff.Days / 365) > 1 ? "meses" : "mês");
            else
                return $"há { diff.Days } "
                    + (diff.Days > 1 ? "dias" : "dia");
        }


    }
}