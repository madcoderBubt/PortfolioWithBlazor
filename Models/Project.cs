namespace PortfolioDotNet.Models;

public class Project
{
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
    public string RepoLink { get; set; } = string.Empty;
    public string LiveLink { get; set; } = string.Empty;
    public List<string> Technologies { get; set; } = new();
    public string Team { get; set; } = string.Empty;
}
