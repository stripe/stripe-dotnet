namespace StripeTests
{
    using System;

    /// <summary>
    /// Represents errors that are related to tests themselves rather than the
    /// features under test.
    /// </summary>
    public class StripeTestException : Exception
    {
        public StripeTestException()
        {
        }

        public StripeTestException(string message)
            : base(message)
        {
        }
    }
}
