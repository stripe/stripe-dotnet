namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface INestedSingletonUpdatable<TEntity, TOptions>
        where TEntity : IStripeEntity
        where TOptions : BaseOptions, new()
    {
        TEntity Update(string parentId, TOptions updateOptions, RequestOptions requestOptions = null);

        Task<TEntity> UpdateAsync(string parentId, TOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}
