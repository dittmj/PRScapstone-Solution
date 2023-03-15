using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRScapstone.Models
{
    public class Request
    {
        public int Id { get; set; }
        [StringLength(80)]
        public string Description { get; set; } = string.Empty;
        [StringLength(80)]
        public string Justification { get; set; } = string.Empty;
        [StringLength(80)]
        public string RejectionReason { get; set; }
        [StringLength(20)]
        public string DeliveryMode { get; set; } = string.Empty;
        [StringLength(10)]
        public string Status { get; set; } = string.Empty;
        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; }
        public int UserId { get; set; }
        public virtual ICollection<User>? Users { get; set; }
    }
}
