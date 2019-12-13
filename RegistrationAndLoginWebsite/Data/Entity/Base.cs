using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAndLoginWebsite.Data
{
    public class Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public int IsDeleted { get; set; }

        public int IsBlocked { get; set; }

    }
}
