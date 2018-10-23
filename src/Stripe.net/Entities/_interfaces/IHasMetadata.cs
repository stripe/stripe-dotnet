namespace Stripe
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface that identifies entities with a Metadata property of type <see cref="Dictionary{String, String}" />.
    /// </summary>
    public interface IHasMetadata
    {
        Dictionary<string, string> Metadata { get; set; }
    }
}
