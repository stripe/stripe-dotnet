namespace Stripe
{
    using System;

    /// <summary>
    /// Beta specific configuration for Stripe.net settings.
    /// </summary>
    public static partial class StripeConfiguration
    {
        /* Beta specific configuration */

        /// <summary>Add beta version to ApiVersion. If the betaName already exists, the higher betaVersion will take precedent.</summary>
        /// <param name="betaName">Name of beta.</param>
        /// <param name="betaVersion">Desired beta version in the format "v" + a number (e.g. "v3").</param>
        public static void AddBetaVersion(string betaName, string betaVersion)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(betaVersion, @"^v\d+$"))
            {
                throw new Exception($"Invalid beta version format: {betaVersion}. Expected format is 'v' followed by a number (e.g., 'v3').");
            }

            var existingBeta = $"; {betaName}=";
            if (ApiVersion.Contains(existingBeta))
            {
                var startIndex = ApiVersion.IndexOf(existingBeta) + existingBeta.Length;
                var endIndex = ApiVersion.IndexOf(';', startIndex);
                endIndex = endIndex == -1 ? ApiVersion.Length : endIndex;

                var currentVersion = ApiVersion.Substring(startIndex, endIndex - startIndex);
                var currentVersionNumber = int.Parse(currentVersion.Substring(1));
                var newVersionNumber = int.Parse(betaVersion.Substring(1));

                if (newVersionNumber > currentVersionNumber)
                {
                    ApiVersion = ApiVersion.Replace($"{existingBeta}{currentVersion}", $"{existingBeta}{betaVersion}");
                }
            }
            else
            {
                ApiVersion = $"{ApiVersion}; {betaName}={betaVersion}";
            }
        }

        internal static void ClearBetaVersion()
        {
            ApiVersion = Stripe.ApiVersion.Current;
        }
    }
}
