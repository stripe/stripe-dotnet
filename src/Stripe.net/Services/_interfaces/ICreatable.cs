namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface ICreatable<TEntity, TOptions>
        where TEntity : IStripeEntity
        where TOptions : BaseOptions, new()
    {
        TEntity Create(TOptions createOptions, RequestOptions requestOptions = null);

        Task<TEntity> CreateAsync(TOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}
