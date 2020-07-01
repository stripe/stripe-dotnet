namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IListable<TEntity, TOptions>
        where TEntity : IStripeEntity, IHasId
        where TOptions : ListOptions, new()
    {
        StripeList<TEntity> List(TOptions listOptions = null, RequestOptions requestOptions = null);

        Task<StripeList<TEntity>> ListAsync(TOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);

        IEnumerable<TEntity> ListAutoPaging(TOptions listOptions = null, RequestOptions requestOptions = null);

        IAsyncEnumerable<TEntity> ListAutoPagingAsync(TOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}
