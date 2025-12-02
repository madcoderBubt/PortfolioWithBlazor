namespace PortfolioDotNet.Services;

public class ThemeService
{
    private readonly ILogger<ThemeService> _logger;

    private bool _isDarkMode;
    public event Action? OnThemeChanged;

    public ThemeService(ILogger<ThemeService> logger)
    {
        _logger = logger;
        _isDarkMode = false; // default to light theme
    }

    public bool IsDarkMode => _isDarkMode;

    public string CurrentTheme => _isDarkMode ? "dark-theme" : "light-theme";

    public void SetDarkMode(bool isDark)
    {
        if (_isDarkMode == isDark)
            return;

        _isDarkMode = isDark;
        _logger.LogInformation("Theme set to: {Theme}", CurrentTheme);
        OnThemeChanged?.Invoke();
    }

    public void ToggleTheme()
    {
        _logger.LogInformation("Toggling theme...");
        SetDarkMode(!_isDarkMode);
    }

    public void SetTheme(string theme)
    {
        _logger.LogInformation("Setting theme to: {Theme}", theme);
        if (string.IsNullOrWhiteSpace(theme))
            return;

        SetDarkMode(theme.Trim() == "dark-theme");
    }
}
