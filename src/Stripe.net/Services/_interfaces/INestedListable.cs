namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface INestedListable<TEntity, TOptions>
        where TEntity : IStripeEntity, IHasId
        where TOptions : ListOptions, new()
    {
        StripeList<TEntity> List(string parentId, TOptions listOptions = null, RequestOptions requestOptions = null);

        Task<StripeList<TEntity>> ListAsync(string parentId, TOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);

        IEnumerable<TEntity> ListAutoPaging(string parentId, TOptions listOptions = null, RequestOptions requestOptions = null);

        IAsyncEnumerable<TEntity> ListAutoPagingAsync(string parentId, TOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}
