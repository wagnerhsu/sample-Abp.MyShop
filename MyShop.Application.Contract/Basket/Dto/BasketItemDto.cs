﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Application.Contract.Basket.Dto
{
    public class BasketItemDto
    {
        public int Id { get; set; }

        public Guid BasketId { get; set; }

        public long ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public decimal Count { get; set; }

        public DateTime CreationTime { get; set; } = DateTime.Now;
    }
}
