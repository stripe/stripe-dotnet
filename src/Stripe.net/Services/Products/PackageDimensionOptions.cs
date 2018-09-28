namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class PackageDimensionOptions : INestedOptions
    {
        [FormProperty("height")]
        public decimal? Height { get; set; }

        [FormProperty("length")]
        public decimal? Length { get; set; }

        [FormProperty("weight")]
        public decimal? Weight { get; set; }

        [FormProperty("width")]
        public decimal? Width { get; set; }
    }
}
