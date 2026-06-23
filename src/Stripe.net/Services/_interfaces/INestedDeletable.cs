namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface INestedDeletable<TEntity, TOptions>
        where TEntity : IStripeEntity, IHasId
        where TOptions : BaseOptions, new()
    {
        TEntity Delete(string parentId, string id, TOptions options = null, RequestOptions requestOptions = null);

        Task<TEntity> DeleteAsync(string parentId, string id, TOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}
