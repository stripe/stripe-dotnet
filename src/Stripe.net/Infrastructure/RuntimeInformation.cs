namespace Stripe.Infrastructure
{
#if NET45
    using System;
    using System.Reflection;
    using Microsoft.Win32;
#endif

    internal static class RuntimeInformation
    {
        public static string GetLanguageVersion()
        {
#if NET45
            return ".NET Framework 4.5+";
#else
            return System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
#endif
        }

        public static string GetOSVersion()
        {
#if NET45
            return Environment.OSVersion.ToString();
#else
            return System.Runtime.InteropServices.RuntimeInformation.OSDescription;
#endif
        }

#if NET45
        public static string GetMonoVersion()
        {
            Type monoRuntimeType = typeof(object).Assembly.GetType("Mono.Runtime");

            if (monoRuntimeType != null)
            {
                MethodInfo getDisplayNameMethod = monoRuntimeType.GetMethod(
                    "GetDisplayName",
                    BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.ExactBinding,
                    null,
                    Type.EmptyTypes,
                    null);

                if (getDisplayNameMethod != null)
                {
                    return (string)getDisplayNameMethod.Invoke(null, null);
                }
            }

            return null;
        }
#endif
    }
}
