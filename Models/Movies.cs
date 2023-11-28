namespace API.Models
{
    public class Movies
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public string? Director { get; set; }
        public string? Language { get; set; }
        public string? Rating { get; set; }
        public string? ReleaseDate { get; set; }
        public string? RunTime { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
