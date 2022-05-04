﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NewProj.Classes
{
    [Table("User")]
    public partial class User
    {
        [Key]
        public string ID { get; set; }
        [Required]
        [StringLength(450)]
        public string AccountId { get; set; }

        [ForeignKey(nameof(AccountId))]
        [InverseProperty(nameof(AspNetUser.Users))]
        public virtual AspNetUser Account { get; set; }
    }
}