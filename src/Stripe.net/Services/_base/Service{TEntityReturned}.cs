namespace Stripe
{
    /// <summary>Abstract base class for all services.</summary>
    /// <typeparam name="TEntityReturned">
    /// The type of <see cref="IStripeEntity"/> that this service returns.
    /// </typeparam>
    public abstract class Service<TEntityReturned> : Service
        where TEntityReturned : IStripeEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Service{T}"/> class.
        /// </summary>
        protected Service()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Service{T}"/> class with a
        /// custom <see cref="IStripeClient"/>.
        /// </summary>
        /// <param name="client">The client used by the service to send requests.</param>
        protected Service(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Service{T}"/> class with a
        /// custom <see cref="ApiRequestor"/>.
        /// </summary>
        /// <param name="requestor">The reuestor used by the service to send requests.</param>
        internal Service(ApiRequestor requestor)
            : base(requestor)
        {
        }
    }
}
