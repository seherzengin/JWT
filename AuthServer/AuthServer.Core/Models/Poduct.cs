﻿namespace AuthServer.Core.Models
{
    public class Poduct
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string UserId { get; set; }

    }
}
