using System.ComponentModel.DataAnnotations;
using Project.Domain.Configurations.Entity;

namespace Project.Domain.Entities.Sample
{
    public class Sample : Entity
    {
        [Key]
        public int Id { get; set; }
        public string? SampleText { get; set; }
    }
}
