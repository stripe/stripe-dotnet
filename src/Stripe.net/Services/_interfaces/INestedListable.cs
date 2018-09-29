namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface INestedListable<T, O>
        where T : StripeEntity
        where O : ListOptions
    {
        StripeList<T> List(string parentId, O listOptions = null, RequestOptions requestOptions = null);

        Task<StripeList<T>> ListAsync(string parentId, O listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
