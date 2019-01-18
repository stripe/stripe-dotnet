namespace Stripe.Infrastructure
{
    using System.Text.RegularExpressions;

    internal class StringUtils
    {
        /// <summary>Converts the string to snake case.</summary>
        /// <param name="str">The string to convert.</param>
        /// <returns>A string with the contents of the input string converted to snake_case.</returns>
        public static string ToSnakeCase(string str)
        {
            var tmp = Regex.Replace(str, "(.)([A-Z][a-z]+)", "$1_$2");
            return Regex.Replace(tmp, "([a-z0-9])([A-Z])", "$1_$2").ToLower();
        }
    }
}
