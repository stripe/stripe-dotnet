namespace Stripe.Infrastructure
{
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Tracks which properties have been explicitly set by the caller.
    /// Used by emptyable fields so that setting a property to null is
    /// distinguishable from never setting it.
    /// </summary>
    internal class SetTracker
    {
        private HashSet<string> properties;

        /// <summary>
        /// Records that a property was explicitly set.
        /// </summary>
        /// <param name="propertyName">The name of the property (auto-populated by CallerMemberName).</param>
        public void Track([CallerMemberName] string propertyName = null)
        {
            this.properties ??= new HashSet<string>();
            this.properties.Add(propertyName);
        }

        /// <summary>
        /// Returns whether the given property was explicitly set.
        /// </summary>
        /// <param name="propertyName">The C# property name to check.</param>
        /// <returns>True if the property was explicitly set.</returns>
        public bool IsSet(string propertyName)
        {
            return this.properties != null && this.properties.Contains(propertyName);
        }
    }
}
