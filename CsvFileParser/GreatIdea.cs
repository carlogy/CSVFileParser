using System;
using CsvHelper.Configuration.Attributes;

namespace CsvFileParser
{
    public class GreatIdea
    {
        [Name("id")]
        public int ID { get; set; }
        [Name("title")]
        public string? Title { get; set; }
        [Name("description")]
        public string? Description { get; set; }
        [Name("resolution")]
        public string? Resolution { get; set; }
        [Name("status")]
        public string? Status { get; set; }
        [Name("created_by_user_id")]
        public int CreatedByUserID { get; set; }
        [Name("total_upvote_count")]
        public int TotalUpVotes { get; set; }
        [Name("product_areas")]
        public string? ProductArea { get; set; }
        [Name("tags")]
        public string? Tags { get; set; }
    }
}

