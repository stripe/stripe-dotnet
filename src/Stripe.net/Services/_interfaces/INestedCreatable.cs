namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface INestedCreatable<TEntity, TOptions>
        where TEntity : IStripeEntity
        where TOptions : BaseOptions, new()
    {
        TEntity Create(string parentId, TOptions createOptions, RequestOptions requestOptions = null);

        Task<TEntity> CreateAsync(string parentId, TOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}
