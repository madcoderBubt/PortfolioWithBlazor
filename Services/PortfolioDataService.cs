using PortfolioDotNet.Models;
using System.Text.Json;

namespace PortfolioDotNet.Services;

public class PortfolioDataService
{
    private PortfolioData? _portfolioData;

    public PortfolioDataService()
    {
        LoadData();
    }

    private void LoadData()
    {
        // Sample data based on the provided JSON
        _portfolioData = new PortfolioData
        {
            Profile = new Profile
            {
                Name = "Sudhananda Biswas",
                Title = "Software Engineer (.NET & Angular)",
                Subtitle = "Mad Coder",
                Location = "Mirpur 2, Dhaka, Bangladesh",
                Email = "shbsovon@outlook.com",
                Email2 = "sudhanandabiswas@yahoo.com",
                Phone = "+8801720000830",
                Phone2 = "+8801632740075",
                Image = "assets/profile.jpg",
                CvLink = "https://1drv.ms/w/s!An0J0ief7HeKivwxVWB6Ounl_Ug93A?e=A3nSr6",
                Social = new SocialLinks
                {
                    Facebook = "https://www.facebook.com/madcoderBUBT/",
                    Twitter = "https://twitter.com/shbsovon",
                    LinkedIn = "https://linkedin.com/in/MadCoderbubt",
                    GitHub = "https://github.com/MadCoderBubt",
                    Skype = "shbsovon",
                    HackerRank = "https://hackerrank.com/madcoder_Bubt",
                    LeetCode = "https://leetcode.com/madcoderBubt/",
                    Portfolio = "https://madcoderbubt.github.io/MadCoderPersonal"
                }
            },
            Objective = "Highly skilled software engineer with over 4 years of experience in developing and delivering robust software solutions using .NET and Angular as well as designing and optimizing database schemas with proficiency. Skilled in analyzing complex problems and delivering efficient solutions with a proven record of collaborating with cross-functional teams that meet business requirements.",
            About = new About
            {
                Bio = "Highly skilled software engineer with over 4 years of experience in developing and delivering robust software solutions using .NET and Angular as well as designing and optimizing database schemas with proficiency. Skilled in analyzing complex problems and delivering efficient solutions with a proven record of collaborating with cross-functional teams that meet business requirements."
            },
            Skills = new List<Skill>
            {
                new() { Name = "Visual C#", Category = "Languages", Link = "https://docs.microsoft.com/en-us/dotnet/csharp/" },
                new() { Name = "JavaScript/TypeScript", Category = "Languages", Link = "https://www.typescriptlang.org/docs/" },
                new() { Name = "MS SQL Server", Category = "Database", Link = "https://docs.microsoft.com/en-us/sql/sql-server/" },
                new() { Name = ".NET Core", Category = "Frameworks", Link = "https://docs.microsoft.com/en-us/dotnet/core/" },
                new() { Name = "ASP.NET MVC", Category = "Frameworks", Link = "https://dotnet.microsoft.com/apps/aspnet/mvc" },
                new() { Name = "Entity Framework", Category = "Frameworks", Link = "https://docs.microsoft.com/en-us/ef/" },
                new() { Name = "RESTful Web API", Category = "Frameworks", Link = "https://dotnet.microsoft.com/apps/aspnet/apis" },
                new() { Name = "Angular 6+", Category = "Frameworks", Link = "https://angular.io/docs" },
                new() { Name = "Git (GitHub)", Category = "Tools", Link = "https://git-scm.com/doc" },
                new() { Name = "xUnit Testing", Category = "Tools", Link = "https://xunit.net/" },
                new() { Name = "Docker", Category = "Tools", Link = "https://docs.docker.com/" },
                new() { Name = "Microservice", Category = "Architecture", Link = "https://microservices.io/" }
            },
            Abilities = new List<string>
            {
                "Problem Solving",
                "OOP Concept",
                "Debugging/Testing",
                "Fast Learner",
                "Self-Motivated"
            },
            Languages = new List<Language>
            {
                new() { Name = "Bangla", Level = "Native" },
                new() { Name = "English", Level = "Professional" }
            },
            Experience = new List<Experience>
            {
                new()
                {
                    Date = "Oct 2024 - Present",
                    Role = "Web Developer",
                    Company = "COBAIT BD Ltd.",
                    Location = "Dhaka, BD",
                    Description = "Develop, test, & implement new features for the web-platform on client needs.",
                    Skills = "Angular 13+ · Kendo UI · ASP.NET Core · SignalR"
                },
                new()
                {
                    Date = "Dec 2023 - July 2024",
                    Role = "Software Engineer",
                    Company = "Living-Hub Technologies",
                    Location = "Dhaka, BD",
                    Description = "Develop, test, & implement new features for the web-platform on client needs.",
                    Skills = "ASP.NET core Web API · Docker · Angular 8+ · EF · CQRS · Mediator · PostgreSQL"
                },
                new()
                {
                    Date = "Sept 2021 - Dec 2023",
                    Role = "Software Engineer (.NET)",
                    Company = "Global Software Architects",
                    Location = "Dhaka, BD",
                    Description = "Developed and maintained software applications using .NET Framework and Angular 8+, resulting in efficient data management and enhanced user experience. Mentoring junior developers to drive their professional development and continuous improvement.",
                    Skills = "ASP.NET Web API · T-SQL Stored Procedures · Angular 8+ · C# · Git · Kendo UI · JavaScript"
                },
                new()
                {
                    Date = "Nov 2020 - July 2021",
                    Role = ".Net Developer",
                    Company = "Standard Technology Dev. Ltd.",
                    Location = "Dhaka, BD",
                    Description = "Worked on pre-existing WinForms POS system and implemented new features on clients' requirement.",
                    Skills = "C#, MS SQL, RDLC, ADO.NET"
                }
            },
            Education = new List<Education>
            {
                new()
                {
                    Degree = "BSc Eng. in CSE",
                    Institution = "Bangladesh University of Business & Technology",
                    Location = "Dhaka",
                    Year = "2017 - 2021"
                },
                new()
                {
                    Degree = "Diploma Eng. in Computer Technology",
                    Institution = "Jashore Polytechnic Institute",
                    Location = "Jashore",
                    Year = "2012 - 2016"
                }
            },
            Projects = new List<Project>
            {
                new()
                {
                    Title = "Microservice Learning Project",
                    Category = "Web",
                    Status = "Continuous",
                    Description = "Building eCommerce Microservice Module as learning process",
                    Image = "assets/project1.jpg",
                    Link = "#",
                    RepoLink = "https://github.com/madcoderBubt",
                    LiveLink = "",
                    Technologies = new List<string> { "ASP.NET Core Web-API", "Docker", "MongoDB", "PostgreSQL", "MS SQL", "gRPC-Service" },
                    Team = "Self"
                },
                new()
                {
                    Title = "BookStore",
                    Category = "Web",
                    Status = "Complete",
                    Description = "ASP Core MVC project for managing bookstore operations",
                    Image = "assets/project2.jpg",
                    Link = "#",
                    RepoLink = "https://github.com/madcoderBubt/BookStore",
                    LiveLink = "",
                    Technologies = new List<string> { "ASP.NET Core MVC", "Entity Framework", "SQL Server" },
                    Team = "Team of 4"
                },
                new()
                {
                    Title = "BTRS - Bus Ticket Reservation System",
                    Category = "Desktop",
                    Status = "Complete",
                    Description = "WinForms application for bus ticket reservation and management",
                    Image = "assets/project3.jpg",
                    Link = "#",
                    RepoLink = "https://github.com/madcoderBubt/BTRS_SDProject",
                    LiveLink = "",
                    Technologies = new List<string> { "WinForms", "C#", "SQL Server", "ADO.NET" },
                    Team = "Group of 4"
                },
                new()
                {
                    Title = "Portfolio Site",
                    Category = "Web",
                    Status = "Complete",
                    Description = "Personal portfolio website to showcase skills and projects",
                    Image = "assets/project4.jpg",
                    Link = "#",
                    RepoLink = "https://github.com/MadCoderBubt/MadCoderPersonal",
                    LiveLink = "https://madcoderbubt.github.io/MadCoderPersonal/",
                    Technologies = new List<string> { "HTML", "CSS", "JavaScript" },
                    Team = "Self"
                }
            },
            ExtraActivities = new List<string>
            {
                "Attended in BUBT Intra-University Programming Contest (BIUPC)",
                "Lead Software Development Group Projects at study"
            }
        };
    }

    public Task<PortfolioData> GetPortfolioDataAsync()
    {
        return Task.FromResult(_portfolioData ?? new PortfolioData());
    }

    public Task<Profile> GetProfileAsync()
    {
        return Task.FromResult(_portfolioData?.Profile ?? new Profile());
    }

    public Task<List<Skill>> GetSkillsAsync()
    {
        return Task.FromResult(_portfolioData?.Skills ?? new List<Skill>());
    }

    public Task<List<Experience>> GetExperienceAsync()
    {
        return Task.FromResult(_portfolioData?.Experience ?? new List<Experience>());
    }

    public Task<List<Education>> GetEducationAsync()
    {
        return Task.FromResult(_portfolioData?.Education ?? new List<Education>());
    }

    public Task<List<Project>> GetProjectsAsync()
    {
        return Task.FromResult(_portfolioData?.Projects ?? new List<Project>());
    }

    public Task<List<Project>> GetProjectsByCategoryAsync(string category)
    {
        var projects = _portfolioData?.Projects
            .Where(p => category == "All" || p.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
            .ToList() ?? new List<Project>();
        
        return Task.FromResult(projects);
    }
}
