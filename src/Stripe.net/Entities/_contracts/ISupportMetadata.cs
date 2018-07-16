namespace Stripe
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface that identifies entities with a Metadata property of type <see cref="Dictionary{string,string}" />.
    /// </summary>
    public interface ISupportMetadata
    {
        Dictionary<string, string> Metadata { get; set; }
    }
}
