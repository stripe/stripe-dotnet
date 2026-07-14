namespace StripeTests
{
    using System;
    using System.IO;
    using Stripe.Infrastructure;
    using Xunit;

    public class TelemetryIdTest : BaseStripeTest
    {
        [Fact]
        public void GetReturns32CharHexString()
        {
            var tmpDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            try
            {
                TelemetryId.Reset();
                TelemetryId.ConfigDirOverride = tmpDir;

                var id = TelemetryId.Get();

                Assert.NotNull(id);
                Assert.Matches("^[0-9a-f]{32}$", id);
            }
            finally
            {
                TelemetryId.Reset();
                if (Directory.Exists(tmpDir))
                {
                    Directory.Delete(tmpDir, recursive: true);
                }
            }
        }

        [Fact]
        public void GetIsDeterministic()
        {
            var tmpDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            try
            {
                TelemetryId.Reset();
                TelemetryId.ConfigDirOverride = tmpDir;

                var id1 = TelemetryId.Get();
                var id2 = TelemetryId.Get();

                Assert.Equal(id1, id2);
            }
            finally
            {
                TelemetryId.Reset();
                if (Directory.Exists(tmpDir))
                {
                    Directory.Delete(tmpDir, recursive: true);
                }
            }
        }

        [Fact]
        public void GetReadsExistingIdFromFile()
        {
            var tmpDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            try
            {
                Directory.CreateDirectory(tmpDir);
                var filePath = Path.Combine(tmpDir, "telemetry_id");
                var existingId = "aabbccddeeff00112233445566778899";
                File.WriteAllText(filePath, existingId);

                TelemetryId.Reset();
                TelemetryId.ConfigDirOverride = tmpDir;

                var id = TelemetryId.Get();
                Assert.Equal(existingId, id);
            }
            finally
            {
                TelemetryId.Reset();
                if (Directory.Exists(tmpDir))
                {
                    Directory.Delete(tmpDir, recursive: true);
                }
            }
        }

        [Fact]
        public void GetGeneratesAndPersistsNewIdWhenFileAbsent()
        {
            var tmpDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            try
            {
                TelemetryId.Reset();
                TelemetryId.ConfigDirOverride = tmpDir;

                var id = TelemetryId.Get();

                Assert.NotNull(id);
                Assert.Matches("^[0-9a-f]{32}$", id);

                // The ID should have been written to disk
                var filePath = Path.Combine(tmpDir, "telemetry_id");
                Assert.True(File.Exists(filePath));
                Assert.Equal(id, File.ReadAllText(filePath).Trim());
            }
            finally
            {
                TelemetryId.Reset();
                if (Directory.Exists(tmpDir))
                {
                    Directory.Delete(tmpDir, recursive: true);
                }
            }
        }

        [Fact]
        public void GetConfigDir_UnixUsesXdgConfigHomeWhenSet()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                return;
            }

            var savedXdg = Environment.GetEnvironmentVariable("XDG_CONFIG_HOME");
            try
            {
                Environment.SetEnvironmentVariable("XDG_CONFIG_HOME", "/custom/config");
                var dir = TelemetryId.GetConfigDir();
                Assert.Equal("/custom/config/stripe", dir);
            }
            finally
            {
                Environment.SetEnvironmentVariable("XDG_CONFIG_HOME", savedXdg);
            }
        }

        [Fact]
        public void GetConfigDir_UnixFallsBackToHomeConfig()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                return;
            }

            var savedXdg = Environment.GetEnvironmentVariable("XDG_CONFIG_HOME");
            try
            {
                Environment.SetEnvironmentVariable("XDG_CONFIG_HOME", null);
                var dir = TelemetryId.GetConfigDir();
                var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                Assert.Equal(Path.Combine(home, ".config", "stripe"), dir);
            }
            finally
            {
                Environment.SetEnvironmentVariable("XDG_CONFIG_HOME", savedXdg);
            }
        }
    }
}
