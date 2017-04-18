using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsLeague.Models
{
    [Table("DivisionTeam")]
    public class DivisionTeam
    {

        [Key]
        public int TeamId { get; set; }
        public Team Team { get; set; }

        public int DivisionId { get; set; }
        public Division Division { get; set; }
        
    }
}
