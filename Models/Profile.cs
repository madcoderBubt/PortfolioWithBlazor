namespace PortfolioDotNet.Models;

public class Profile
{
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Email2 { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Phone2 { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string CvLink { get; set; } = string.Empty;
    public SocialLinks Social { get; set; } = new();
}

public class SocialLinks
{
    public string Facebook { get; set; } = string.Empty;
    public string Twitter { get; set; } = string.Empty;
    public string LinkedIn { get; set; } = string.Empty;
    public string GitHub { get; set; } = string.Empty;
    public string Skype { get; set; } = string.Empty;
    public string HackerRank { get; set; } = string.Empty;
    public string LeetCode { get; set; } = string.Empty;
    public string Portfolio { get; set; } = string.Empty;
}
