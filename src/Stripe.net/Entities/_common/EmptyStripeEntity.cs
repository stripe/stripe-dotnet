namespace Stripe
{
    /// <summary>
    /// An empty entity for API methods with a void return type
    /// We need a class to to deserialize into, but we can't instantiate the abstract StripeEntity
    /// directly. This class shouldn't do anything. But, it _does_ need to be`public` so it can be
    /// returned to callers in `Task`s.
    /// </summary>
    public class EmptyStripeEntity : StripeEntity<EmptyStripeEntity>
    {
    }
}
