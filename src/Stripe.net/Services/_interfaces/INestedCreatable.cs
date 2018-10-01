namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface INestedCreatable<T, O>
        where T : IStripeEntity
        where O : BaseOptions
    {
        T Create(string parentId, O createOptions, RequestOptions requestOptions = null);

        Task<T> CreateAsync(string parentId, O createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
