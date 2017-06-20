using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeProductService : StripeBasicService<StripeProduct>
    {
        public StripeProductService(string apiKey = null) : base(apiKey) { }



        // Sync
        public virtual StripeProduct Create(StripeProductCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/products", requestOptions, options);
        }

        public virtual StripeProduct Get(string productId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/products/{productId}", requestOptions);
        }

        public virtual StripeProduct Update(string productId, StripeProductUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/products/{productId}", requestOptions, options);
        }

        public virtual IEnumerable<StripeProduct> List(StripeProductListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.BaseUrl}/products", requestOptions, listOptions);
        }

        public virtual StripeDeleted Delete(string productId, StripeRequestOptions requestOptions = null)
        {
            return DeleteEntity($"{Urls.BaseUrl}/products/{productId}", requestOptions);
        }



        // Async
        public virtual Task<StripeProduct> CreateAsync(StripeProductCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/products", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeProduct> GetAsync(string productId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/products/{productId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeProduct> UpdateAsync(string productId, StripeProductUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/products/{productId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<IEnumerable<StripeProduct>> ListAsync(StripeProductListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/products", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<StripeDeleted> DeleteAsync(string productId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteEntityAsync($"{Urls.BaseUrl}/products/{productId}", requestOptions, cancellationToken);
        }
    }
}
