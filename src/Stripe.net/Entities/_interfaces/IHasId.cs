namespace Stripe
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface that identifies entities returned by Stripe that have an `id` attribute.
    /// </summary>
    public interface IHasId
    {
        string Id { get; set; }
    }
}
