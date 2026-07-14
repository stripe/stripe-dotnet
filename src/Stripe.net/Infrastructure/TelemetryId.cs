namespace Stripe.Infrastructure
{
    using System;
    using System.IO;
    using System.Security.Cryptography;

    internal static class TelemetryId
    {
        private static readonly object LockObj = new object();

        private static string cachedId;
        private static bool loaded;

        // For testing: overrides GetConfigDir() when set.
        internal static string ConfigDirOverride { get; set; }

        public static string Get()
        {
            if (loaded)
            {
                return cachedId;
            }

            lock (LockObj)
            {
                if (loaded)
                {
                    return cachedId;
                }

                cachedId = Resolve();
                loaded = true;
            }

            return cachedId;
        }

        internal static string GetConfigDir()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                var appData = Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData);
                if (string.IsNullOrEmpty(appData))
                {
                    return null;
                }

                return Path.Combine(appData, "Stripe");
            }

            var xdg = Environment.GetEnvironmentVariable("XDG_CONFIG_HOME");
            if (!string.IsNullOrEmpty(xdg))
            {
                return Path.Combine(xdg, "stripe");
            }

            var home = Environment.GetFolderPath(
                Environment.SpecialFolder.UserProfile);
            if (string.IsNullOrEmpty(home))
            {
                return null;
            }

            return Path.Combine(home, ".config", "stripe");
        }

        private static string Resolve()
        {
            var configDir = ConfigDirOverride ?? GetConfigDir();
            if (configDir == null)
            {
                return null;
            }

            var filePath = Path.Combine(configDir, "telemetry_id");

            try
            {
                if (File.Exists(filePath))
                {
                    var content = File.ReadAllText(filePath).Trim();
                    if (!string.IsNullOrEmpty(content))
                    {
                        return content;
                    }
                }
            }
            catch
            {
                return null;
            }

            var newId = GenerateId();
            try
            {
                Directory.CreateDirectory(configDir);
                File.WriteAllText(filePath, newId);
            }
            catch
            {
                return null;
            }

            return newId;
        }

        private static string GenerateId()
        {
            var bytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }

            return BitConverter.ToString(bytes)
                .Replace("-", string.Empty)
                .ToLowerInvariant();
        }

        // For testing
        internal static void Reset()
        {
            lock (LockObj)
            {
                cachedId = null;
                loaded = false;
                ConfigDirOverride = null;
            }
        }
    }
}
