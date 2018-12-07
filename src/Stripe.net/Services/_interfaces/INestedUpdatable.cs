namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface INestedUpdatable<T, O>
        where T : IStripeEntity, IHasId
        where O : BaseOptions
    {
        T Update(string parentId, string id, O updateOptions, RequestOptions requestOptions = null);

        Task<T> UpdateAsync(string parentId, string id, O updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
