﻿namespace PowerAutomation.Models
{
    public interface IProcedure
    {
        public string Description { get; set; }
        public string Key { get; set; }
        public string Title { get; set; }
    }
}