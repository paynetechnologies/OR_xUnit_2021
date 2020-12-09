using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Core.Driver
{
    public static class DisposeDriverService
    {
        private static readonly List<string> _processesToCheck =
            new List<string>
            {
                "opera",
                "chromedriver",
                "chrome",
                "firefoxdriver",
                "ie",
                "gecko",
                "phantomjs",
                "edge",
                "microsoftwebdriver",
                "webdriver"
            };

        public static DateTime? TestRunStartTime { get; set; }

        public static void FinishHim(IWebDriver driver)
        {
            driver?.Dispose();
            List<Process> processes = Process.GetProcesses().ToList();

            var subsetOfProcesses = processes.Where(x => _processesToCheck.Exists(y => y.ToLower() == x.ProcessName.ToLower()));

            foreach (var process in subsetOfProcesses)
            {
                try
                {
                    Debug.WriteLine(process.ProcessName);
                    if (_processesToCheck.Any(s => s.Equals(process.ProcessName, StringComparison.OrdinalIgnoreCase)))
                    {
                        if (process.StartTime != null && process.StartTime > TestRunStartTime)
                        {
                            Debug.WriteLine($"Killing Process : {process.ProcessName.ToLower()}");
                            process.Kill();
                        }
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
            }
        }
    }
}
