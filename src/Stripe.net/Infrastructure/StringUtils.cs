namespace Stripe.Infrastructure
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;

    internal static class StringUtils
    {
        private static Regex whitespaceRegex = new Regex(@"\s", RegexOptions.CultureInvariant);

        /// <summary>Converts the string to snake case.</summary>
        /// <param name="str">The string to convert.</param>
        /// <returns>A string with the contents of the input string converted to snake_case.</returns>
        public static string ToSnakeCase(string str)
        {
            var tmp = Regex.Replace(str, "(.)([A-Z][a-z]+)", "$1_$2");
            return Regex.Replace(tmp, "([a-z0-9])([A-Z])", "$1_$2").ToLower();
        }

        /// <summary>
        /// Determines whether the two specified <see cref="string"/> objects have the same value.
        /// The comparison is done in constant time to prevent timing attacks.
        /// </summary>
        /// <param name="a">The first string to compare.</param>
        /// <param name="b">The second string to compare.</param>
        /// <returns>
        /// <c>true</c> if the value of the <c>a</c> parameter is equal to the value of the <c>b</c>
        /// parameter; otherwise, <c>false</c>.
        /// </returns>
        [MethodImpl(MethodImplOptions.NoOptimization)]
        public static bool SecureEquals(string a, string b)
        {
            if (a == null)
            {
                throw new ArgumentNullException(nameof(a));
            }

            if (b == null)
            {
                throw new ArgumentNullException(nameof(b));
            }

            if (a.Length != b.Length)
            {
                return false;
            }

            var result = 0;

            for (var i = 0; i < a.Length; i++)
            {
                result |= a[i] ^ b[i];
            }

            return result == 0;
        }

        /// <summary>Checks whether a string contains any whitespace characters or not.</summary>
        /// <param name="str">The string to check.</param>
        /// <returns>
        /// <c>true</c> if the string contains any whitespace characters; otherwise, <c>false</c>.
        /// </returns>
        /// <exception name="ArgumentNullException">Thrown if <c>str</c> is <c>null</c>.</exception>
        public static bool ContainsWhitespace(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return whitespaceRegex.IsMatch(str);
        }
    }
}
