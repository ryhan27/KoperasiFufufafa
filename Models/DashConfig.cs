using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Raka Er

namespace KoperasiFufufafa.Models
{
    public class DashConfig 
    {
        public int Id { get; set; }

        [MaxLength(4000)]public string Terminologi1 { get; set; }
        [MaxLength(4000)]public string Terminologi2 { get; set; }
        [MaxLength(4000)]public string Terminologi3 { get; set; }

    }
}
