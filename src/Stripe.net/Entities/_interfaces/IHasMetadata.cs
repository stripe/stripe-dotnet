namespace Stripe
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface that identifies entities with a Metadata property of type
    /// <see cref="Dictionary{String, String}" />.
    /// </summary>
    public interface IHasMetadata
    {
        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        Dictionary<string, string> Metadata { get; set; }
    }
}
