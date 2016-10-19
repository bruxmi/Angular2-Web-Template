using Core.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Application
{
    [Table("ApplicationSetting")]
    public class ApplicationSetting : IEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Index(IsUnique = true)]
        public string Key { get; set; }

        public string Value { get; set; }
    }
}
