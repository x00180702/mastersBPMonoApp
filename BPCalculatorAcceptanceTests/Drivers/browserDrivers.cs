using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BPCalculatorAcceptanceTests.Drivers
{
    public class browserDrivers
   : IDisposable
    {
        private readonly Lazy<IWebDriver> _currentWebDriverLazy;
        private bool _isDisposed;

        public browserDrivers()
        {
            _currentWebDriverLazy = new Lazy<IWebDriver>(CreateWebDriver);
        }

        /// <summary>
        /// The Selenium IWebDriver instance
        /// </summary>
        public IWebDriver Current => _currentWebDriverLazy.Value;

        /// <summary>
        /// Creates the Selenium web driver (opens a browser)
        /// </summary>
        /// <returns></returns>
        private IWebDriver CreateWebDriver()
        {
            //We use the Chrome browser
            var chromeDriverService = ChromeDriverService.CreateDefaultService();

            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("download.default_directory", "YOUR_DownloadPath");
            chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
            chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
            chromeOptions.AddArguments("disable-infobars");
            chromeOptions.AddArguments("start-maximized"); // open Browser in maximized mode
            chromeOptions.AddArguments("disable-infobars"); // disabling infobars
            chromeOptions.AddArguments("--disable-extensions"); // disabling extensions
            chromeOptions.AddArguments("--disable-gpu"); // applicable to windows os only
            chromeOptions.AddArguments("--disable-dev-shm-usage"); // overcome limited resource problems
            chromeOptions.AddArguments("--no-sandbox"); // Bypass OS security model


            var chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions);

            return chromeDriver;
        }

        /// <summary>
        /// Disposes the Selenium web driver (closing the browser)
        /// </summary>
        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }

            if (_currentWebDriverLazy.IsValueCreated)
            {
                Current.Quit();
            }

            _isDisposed = true;
        }
    }
}
