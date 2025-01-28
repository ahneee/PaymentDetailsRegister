﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentAPI.Models
{
    public class PaymentDetailModels
    {
        [Key]
        public int PaymentDetailId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string cardOwnerName { get; set; } = "";
        [Column(TypeName = "nvarchar(16)")]
        public string cardNumber { get; set; } = "";
        [Column(TypeName = "nvarchar(5)")]
        public string expirationDate { get; set; } = "";
        [Column(TypeName = "nvarchar(3)")]
        public string securityCode { get; set; } = "";
    }
}
