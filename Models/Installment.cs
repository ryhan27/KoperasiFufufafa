using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoperasiFufufafa.Models
{
    internal class Installment
    {
        public int Id { get; set; }
        public int LoanId { get; set; }
        public Loan Loan { get; set; } = null!;
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public string? proofPath { get; set; }
    }
}
