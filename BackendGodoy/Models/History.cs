﻿namespace BackendGodoy.Models
{
    public class History
    {
        public Guid Id { get; set; }
        public DateTime date { get; set; }
        public string cat_fact { get; set; }
        public string words { get; set; }
        public string gif_url { get; set; }
    }
}
