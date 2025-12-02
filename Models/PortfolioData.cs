namespace PortfolioDotNet.Models;

public class PortfolioData
{
    public Profile Profile { get; set; } = new();
    public string Objective { get; set; } = string.Empty;
    public About About { get; set; } = new();
    public List<Skill> Skills { get; set; } = new();
    public List<string> Abilities { get; set; } = new();
    public List<Language> Languages { get; set; } = new();
    public List<Experience> Experience { get; set; } = new();
    public List<Education> Education { get; set; } = new();
    public List<Project> Projects { get; set; } = new();
    public List<string> ExtraActivities { get; set; } = new();
}

public class About
{
    public string Bio { get; set; } = string.Empty;
}

public class Language
{
    public string Name { get; set; } = string.Empty;
    public string Level { get; set; } = string.Empty;
}
