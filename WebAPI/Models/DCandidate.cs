using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace WebAPI.Models
{
    public class DCandidate
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName="nvarchar(100)")]
        public string name { get; set; }
        [Column(TypeName = "nvarchar(16)")]
        public string mobile { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string email { get; set; }
        public int age { get; set; }
        [Column(TypeName = "nvarchar(3)")]
        public string bloodGroup { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string addreas { get; set; }
    }
}
