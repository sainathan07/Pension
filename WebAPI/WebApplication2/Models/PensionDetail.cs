﻿using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    public class PensionDetail
    {
        [Key]
        public long adhaarId { get; set; }
        public decimal BankCharge { get; set; }
        public decimal PensionAmount { get; set; }

    }
}