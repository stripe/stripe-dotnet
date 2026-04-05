namespace Stripe.V2
{
    /// <summary>
    /// Implemented by V2 entities that need a reference to the <see cref="ApiRequestor"/>
    /// after deserialization, e.g. so they can make follow-up API calls.
    /// </summary>
    internal interface IHasRequestor
    {
        ApiRequestor Requestor { get; set; }
    }
}
