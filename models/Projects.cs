namespace Projects.models
{
    public class Project
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public required List<string> Technologies { get; set; } = new();
        public required List<string> Responsibilities {  get; set; } = new();
        public string? Image { get; set; }
        public string? Href { get; set; }
    }
}
