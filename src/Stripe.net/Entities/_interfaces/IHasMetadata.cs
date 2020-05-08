namespace Stripe
{
    using System.Collections.Generic;

    public interface IHasMetadata
    {
        Dictionary<string, string> Metadata { get; set; }
    }
}
