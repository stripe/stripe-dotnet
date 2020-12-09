namespace Stripe.Infrastructure
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Versioning;
    using static System.Runtime.InteropServices.RuntimeInformation;

    /// <summary>
    /// This class is used to gather information about the runtime environment. This is actually a
    /// non-trivial task. The code below is largely borrowed from the
    /// <a href="https://github.com/dotnet/BenchmarkDotNet">BenchmarkDotNet</a> project.
    /// </summary>
    internal static class RuntimeInformation
    {
        internal const string Unknown = "?";

        internal static bool IsMono { get; } = Type.GetType("Mono.Runtime") != null;

        internal static bool IsFullFramework => FrameworkDescription.StartsWith(".NET Framework", StringComparison.OrdinalIgnoreCase);

        internal static bool IsNetCore
            => ((Environment.Version.Major >= 5) || FrameworkDescription.StartsWith(".NET Core", StringComparison.OrdinalIgnoreCase))
                && !string.IsNullOrEmpty(typeof(object).Assembly.Location);

        /// <summary>
        /// "The north star for CoreRT is to be a flavor of .NET Core" -> CoreRT reports .NET Core everywhere.
        /// </summary>
        internal static bool IsCoreRT
            => ((Environment.Version.Major >= 5) || FrameworkDescription.StartsWith(".NET Core", StringComparison.OrdinalIgnoreCase))
               && string.IsNullOrEmpty(typeof(object).Assembly.Location); // but it's merged to a single .exe and .Location returns null here ;)

        internal static bool IsRunningInContainer => string.Equals(Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER"), "true");

        /// <summary>Returns a string that describes the operating system on which the app is running.</summary>
        /// <returns>A string that describes the operating system on which the app is running.</returns>
        public static string GetOSVersion()
        {
            return OSDescription;
        }

        /// <summary>Returns a string that indicates the name of the .NET installation on which an app is running.</summary>
        /// <returns>A string that indicates the name of the .NET installation on which an app is running.</returns>
        public static string GetRuntimeVersion()
        {
            if (IsMono)
            {
                return GetMonoVersion();
            }
            else if (IsFullFramework)
            {
                return GetFullFrameworkVersion();
            }
            else if (IsNetCore)
            {
                return GetNetCoreVersion();
            }
            else if (IsCoreRT)
            {
                return FrameworkDescription.Replace("Core ", "CoreRT ");
            }

            return Unknown;
        }

        /// <summary>Returns a string with the Newtonsoft.Json assembly version number.</summary>
        /// <returns>A string with the Newtonsoft.Json assembly version number.</returns>
        public static string GetNewtonsoftJsonVersion()
        {
            var assembly = Assembly.GetAssembly(typeof(Newtonsoft.Json.JsonConvert));
            var fileVersion = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fileVersion.FileVersion;
        }

        internal static string GetMonoVersion()
        {
            var monoRuntimeType = Type.GetType("Mono.Runtime");
            var monoDisplayName = monoRuntimeType?.GetMethod("GetDisplayName", BindingFlags.NonPublic | BindingFlags.Static);
            if (monoDisplayName != null)
            {
                string version = monoDisplayName.Invoke(null, null)?.ToString();
                if (version != null)
                {
                    int bracket1 = version.IndexOf('('), bracket2 = version.IndexOf(')');
                    if (bracket1 != -1 && bracket2 != -1)
                    {
                        string comment = version.Substring(bracket1 + 1, bracket2 - bracket1 - 1);
                        var commentParts = comment.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (commentParts.Length > 2)
                        {
                            version = version.Substring(0, bracket1) + "(" + commentParts[0] + " " + commentParts[1] + ")";
                        }
                    }
                }

                return "Mono " + version;
            }

            return Unknown;
        }

        internal static string GetFullFrameworkVersion()
        {
            var fullName = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription; // sth like .NET Framework 4.7.3324.0
            var servicingVersion = new string(fullName.SkipWhile(c => !char.IsDigit(c)).ToArray());
            var releaseVersion = MapToReleaseVersion(servicingVersion);

            return $".NET Framework {releaseVersion}";
        }

        internal static string MapToReleaseVersion(string servicingVersion)
        {
            // the following code assumes that .NET 4.6.1 is the oldest supported version
            if (string.Compare(servicingVersion, "4.6.2") < 0)
            {
                return "4.6.1";
            }

            if (string.Compare(servicingVersion, "4.7") < 0)
            {
                return "4.6.2";
            }

            if (string.Compare(servicingVersion, "4.7.1") < 0)
            {
                return "4.7";
            }

            if (string.Compare(servicingVersion, "4.7.2") < 0)
            {
                return "4.7.1";
            }

            if (string.Compare(servicingVersion, "4.8") < 0)
            {
                return "4.7.2";
            }

            return "4.8"; // most probably the last major release of Full .NET Framework
        }

        internal static string GetNetCoreVersion()
        {
            if (TryGetCoreRuntimeVersion(out var version) && version >= new Version(5, 0))
            {
                return $".NET {version}";
            }
            else
            {
                string runtimeVersion = version != default ? version.ToString() : "?";

                return $".NET Core {runtimeVersion}";
            }
        }

        internal static bool TryGetCoreRuntimeVersion(out Version version)
        {
            // we can't just use System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription
            // because it can be null and it reports versions like 4.6.* for .NET Core 2.*

            // for .NET 5+ we can use Environment.Version
            if (Environment.Version.Major >= 5)
            {
                version = Environment.Version;
                return true;
            }

            string runtimeDirectory = System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory();
            if (TryGetVersionFromRuntimeDirectory(runtimeDirectory, out version))
            {
                return true;
            }

            // systemPrivateCoreLib.Product*Part properties return 0 so we have to implement some ugly parsing...
            var systemPrivateCoreLib = FileVersionInfo.GetVersionInfo(typeof(object).Assembly.Location);
            if (TryGetVersionFromProductInfo(systemPrivateCoreLib.ProductVersion, systemPrivateCoreLib.ProductName, out version))
            {
                return true;
            }

            string frameworkName = Assembly.GetEntryAssembly()?.GetCustomAttribute<TargetFrameworkAttribute>()?.FrameworkName;
            if (TryGetVersionFromFrameworkName(frameworkName, out version))
            {
                return true;
            }

            if (IsRunningInContainer)
            {
                return Version.TryParse(Environment.GetEnvironmentVariable("DOTNET_VERSION"), out version)
                    || Version.TryParse(Environment.GetEnvironmentVariable("ASPNETCORE_VERSION"), out version);
            }

            version = null;
            return false;
        }

        // sample input:
        // for dotnet run: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.12\
        // for dotnet publish: C:\Users\adsitnik\source\repos\ConsoleApp25\ConsoleApp25\bin\Release\netcoreapp2.0\win-x64\publish\
        internal static bool TryGetVersionFromRuntimeDirectory(string runtimeDirectory, out Version version)
        {
            if (!string.IsNullOrEmpty(runtimeDirectory) && Version.TryParse(GetParsableVersionPart(new DirectoryInfo(runtimeDirectory).Name), out version))
            {
                return true;
            }

            version = null;
            return false;
        }

        // sample input:
        // 2.0: 4.6.26614.01 @BuiltBy: dlab14-DDVSOWINAGE018 @Commit: a536e7eec55c538c94639cefe295aa672996bf9b, Microsoft .NET Framework
        // 2.1: 4.6.27817.01 @BuiltBy: dlab14-DDVSOWINAGE101 @Branch: release/2.1 @SrcCode: https://github.com/dotnet/coreclr/tree/6f78fbb3f964b4f407a2efb713a186384a167e5c, Microsoft .NET Framework
        // 2.2: 4.6.27817.03 @BuiltBy: dlab14-DDVSOWINAGE101 @Branch: release/2.2 @SrcCode: https://github.com/dotnet/coreclr/tree/ce1d090d33b400a25620c0145046471495067cc7, Microsoft .NET Framework
        // 3.0: 3.0.0-preview8.19379.2+ac25be694a5385a6a1496db40de932df0689b742, Microsoft .NET Core
        // 5.0: 5.0.0-alpha1.19413.7+0ecefa44c9d66adb8a997d5778dc6c246ad393a7, Microsoft .NET Core
        internal static bool TryGetVersionFromProductInfo(string productVersion, string productName, out Version version)
        {
            if (!string.IsNullOrEmpty(productVersion) && !string.IsNullOrEmpty(productName))
            {
                if (productName.IndexOf(".NET Core", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    string parsableVersion = GetParsableVersionPart(productVersion);
                    if (Version.TryParse(productVersion, out version) || Version.TryParse(parsableVersion, out version))
                    {
                        return true;
                    }
                }

                // yes, .NET Core 2.X has a product name == .NET Framework...
                if (productName.IndexOf(".NET Framework", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    const string releaseVersionPrefix = "release/";
                    int releaseVersionIndex = productVersion.IndexOf(releaseVersionPrefix);
                    if (releaseVersionIndex > 0)
                    {
                        string releaseVersion = GetParsableVersionPart(productVersion.Substring(releaseVersionIndex + releaseVersionPrefix.Length));

                        return Version.TryParse(releaseVersion, out version);
                    }
                }
            }

            version = null;
            return false;
        }

        // sample input:
        // .NETCoreApp,Version=v2.0
        // .NETCoreApp,Version=v2.1
        internal static bool TryGetVersionFromFrameworkName(string frameworkName, out Version version)
        {
            const string versionPrefix = ".NETCoreApp,Version=v";
            if (!string.IsNullOrEmpty(frameworkName) && frameworkName.StartsWith(versionPrefix))
            {
                string frameworkVersion = GetParsableVersionPart(frameworkName.Substring(versionPrefix.Length));

                return Version.TryParse(frameworkVersion, out version);
            }

            version = null;
            return false;
        }

        // Version.TryParse does not handle thing like 3.0.0-WORD
        private static string GetParsableVersionPart(string fullVersionName) => new string(fullVersionName.TakeWhile(c => char.IsDigit(c) || c == '.').ToArray());
    }
}
