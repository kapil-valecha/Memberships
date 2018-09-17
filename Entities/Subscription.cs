using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Memberships.Entities;

namespace Memberships.Entities
{
    [Table ("Subscription")]
    public class Subscription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]
        public string Title { get; set; }
        [MaxLength(2048)]
        [DisplayName("Description")]
        public string Discription { get; set; }
        [MaxLength(20)]
        [DisplayName("Registration Code")]
        public string RegistrationCode { get; set; }
    }
}