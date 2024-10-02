namespace Stripe.Infrastructure
{
    /// <summary>
    /// This class is used by the library to set as JsonSerializer.Context.Context
    /// before `jsonSerializer.Deserialize` is called, to hold the ApiRequestor
    /// so that it can be set when deserializing objects that need a reference to it.
    /// </summary>
    internal class DeserializationContext
    {
        public ApiRequestor Requestor { get; set; }
    }
}
