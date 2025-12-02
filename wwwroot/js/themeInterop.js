window.themeInterop = {
    setBodyTheme: function (className) {
        if (!className) return;
        try {
            document.body.classList.remove('dark-theme', 'light-theme');
            document.body.classList.add(className);
        } catch (e) {
            // ignore in non-browser environments
        }
    },

    getStoredTheme: function () {
        try {
            return localStorage.getItem('site-theme');
        } catch (e) {
            return null;
        }
    },

    setStoredTheme: function (className) {
        try {
            if (className)
                localStorage.setItem('site-theme', className);
            else
                localStorage.removeItem('site-theme');
        } catch (e) {
            // ignore
        }
    }
};
