namespace Stripe
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface that identifies entities returned by Stripe that have an `object` attribute.
    /// </summary>
    public interface IHasObject
    {
        string Object { get; set; }
    }
}
