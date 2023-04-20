﻿using System.ComponentModel.DataAnnotations;

namespace PlayCapsViewer.Models
{
    public class PlayCapModel
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime EndDate { get; set; }
    }
}
