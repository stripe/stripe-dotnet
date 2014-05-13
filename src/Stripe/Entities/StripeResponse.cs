namespace Stripe
{
    public class StripeResponse<T>
    {
        public T Content { get; set; }
        public StripeError Error { get; set; }
        
        public StripeResponse() { }

        public StripeResponse(T content, StripeError error)
        {
            Content = content;
            Error = error;
        }

        public StripeResponse(string json, StripeError error)
        {
            Content = Mapper<T>.MapFromJson(json);
            Error = error;
        }
    }
}