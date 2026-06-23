namespace Stripe
{
    using System;

    /// <summary>
    /// Used to indicate that a particular class or property that has Json.NET attributes does
    /// not need System.Text.Json properties.  The reason will give more context as to why.
    /// </summary>
    /// <remarks>
    /// This is only used for an internal wholesome test.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    internal class NoSystemTextJsonAttributesNeededAttribute : Attribute
    {
        public NoSystemTextJsonAttributesNeededAttribute(string reason)
        {
            this.Reason = reason;
        }

        public string Reason { get; }
    }
}
