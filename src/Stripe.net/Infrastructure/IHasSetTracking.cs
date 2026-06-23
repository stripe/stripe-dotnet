namespace Stripe.Infrastructure
{
    /// <summary>
    /// Implemented by options classes that support set-tracking for emptyable fields.
    /// Allows encoders to check whether a null property was explicitly set (clear the field)
    /// vs never set (omit from the request).
    /// </summary>
    internal interface IHasSetTracking
    {
        /// <summary>
        /// Returns whether the given property was explicitly set by the caller.
        /// </summary>
        /// <param name="propertyName">The C# property name to check.</param>
        /// <returns>True if the property was explicitly set.</returns>
        bool IsPropertySet(string propertyName);
    }
}
