using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoperasiFufufafa.Models
{
    public class Access
    {
        public int Id { get; set; }
        [Required] public int MemberId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public string? ProofPath { get; set; }
        public Member Member { get; set; } = null!;
        [Required] public string AccessList { get; set; }
        public DateTime updateOn { get; set; }
    }
}
