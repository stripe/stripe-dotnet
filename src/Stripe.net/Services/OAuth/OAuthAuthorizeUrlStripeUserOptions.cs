namespace Stripe
{
    using Newtonsoft.Json;

    public class OAuthAuthorizeUrlStripeUserOptions : INestedOptions
    {
        /// <summary>
        /// <para>The Kana variation of the address block.</para>
        /// <para>
        /// This parameter is only relevant for Japan. You must prefill <see cref="Country"/> with
        /// <c>JP</c> and <see cref="Zip"/> with a valid Japanese postal code to use this parameter.
        /// </para>
        /// </summary>
        [JsonProperty("block_kana")]
        public string BlockKana { get; set; }

        /// <summary>
        /// <para>The Kanji variation of the address block.</para>
        /// <para>
        /// This parameter is only relevant for Japan. You must prefill <see cref="Country"/> with
        /// <c>JP</c> and <see cref="Zip"/> with a valid Japanese postal code to use this parameter.
        /// </para>
        /// </summary>
        [JsonProperty("block_kanji")]
        public string BlockKanji { get; set; }

        /// <summary>
        /// <para>The Kana variation of the address building.</para>
        /// <para>
        /// This parameter is only relevant for Japan. You must prefill <see cref="Country"/> with
        /// <c>JP</c> and <see cref="Zip"/> with a valid Japanese postal code to use this parameter.
        /// </para>
        /// </summary>
        [JsonProperty("building_kana")]
        public string BuildingKana { get; set; }

        /// <summary>
        /// <para>The Kanji variation of the address building.</para>
        /// <para>
        /// This parameter is only relevant for Japan. You must prefill <see cref="Country"/> with
        /// <c>JP</c> and <see cref="Zip"/> with a valid Japanese postal code to use this parameter.
        /// </para>
        /// </summary>
        [JsonProperty("building_kanji")]
        public string BuildingKanji { get; set; }

        /// <summary>The legal name of the business, also used for the statement descriptor.</summary>
        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// <para>The type of the business.</para>
        /// <para>
        /// Must be one of <c>sole_prop</c>, <c>corporation</c>, <c>non_profit</c>,
        /// <c>partnership</c>, or <c>llc</c>.
        /// </para>
        /// </summary>
        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>Address city of the business.</para>
        /// <para>
        /// We highly recommend that you also prefill <see cref="Country"/> with the corresponding
        /// country.
        /// </para>
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// <para>Two-letter country code (e.g., <c>US</c> or <c>CA</c>).</para>
        /// <para>Must be a country that Stripe currently supports.</para>
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// <para>
        /// Three-letter <see href="https://en.wikipedia.org/wiki/ISO_4217">ISO code</see>
        /// representing currency, in lowercase (e.g., <c>usd</c> or <c>cad</c>).
        /// </para>
        /// <para>Must be a valid country and currency combination that Stripe supports.</para>
        /// <para>Must prefill <see cref="Country"/> with the corresponding country.</para>
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// <para>
        /// Day (<c>1-31</c>) for the birth date of the person who will be filling out a Stripe
        /// application.
        /// </para>
        /// <para>
        /// If filling this property, you must also fill <see cref="DobMonth"/> and
        /// <see cref="DobYear"/>.
        /// </para>
        /// </summary>
        [JsonProperty("dob_day")]
        public long? DobDay { get; set; }

        /// <summary>
        /// <para>
        /// Month (<c>1-12</c>) for the birth date of the person who will be filling out a Stripe
        /// application.
        /// </para>
        /// <para>
        /// If filling this property, you must also fill <see cref="DobDay"/> and
        /// <see cref="DobYear"/>.
        /// </para>
        /// </summary>
        [JsonProperty("dob_month")]
        public long? DobMonth { get; set; }

        /// <summary>
        /// <para>
        /// Year (<c>YYYY</c>, greather than 1900) for the birth date of the person who will be
        /// filling out a Stripe application.
        /// </para>
        /// <para>
        /// If filling this property, you must also fill <see cref="DobDay"/> and
        /// <see cref="DobMonth"/>.
        /// </para>
        /// </summary>
        [JsonProperty("dob_year")]
        public long? DobYear { get; set; }

        /// <summary>The user's email address. Must be a valid email format.</summary>
        /// <remarks>Recommended.</remarks>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>First name of the person who will be filling out a Stripe application.</summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// <para>
        /// The Kana variation of the first name of the person who will be filling out a Stripe
        /// application.
        /// </para>
        /// <para>
        /// Must prefill <see cref="Country"/> with <c>JP</c>, as this parameter is only relevant
        /// for Japan.
        /// </para>
        /// </summary>
        [JsonProperty("first_name_kana")]
        public string FirstNameKana { get; set; }

        /// <summary>
        /// <para>
        /// The Kanji variation of the first name of the person who will be filling out a Stripe
        /// application.
        /// </para>
        /// <para>
        /// Must prefill <see cref="Country"/> with <c>JP</c>, as this parameter is only relevant
        /// for Japan.
        /// </para>
        /// </summary>
        [JsonProperty("first_name_kanji")]
        public string FirstNameKanji { get; set; }

        /// <summary>
        /// <para>
        /// The gender of the person who will be filling out a Stripe application. (International
        /// regulations require either <c>male</c> or <c>female</c>.)
        /// </para>
        /// <para>
        /// Must prefill <see cref="Country"/> with <c>JP</c>, as this parameter is only relevant
        /// for Japan.
        /// </para>
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>Last name of the person who will be filling out a Stripe application.</summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// <para>
        /// The Kana variation of the last name of the person who will be filling out a Stripe
        /// application.
        /// </para>
        /// <para>
        /// Must prefill <see cref="Country"/> with <c>JP</c>, as this parameter is only relevant
        /// for Japan.
        /// </para>
        /// </summary>
        [JsonProperty("last_name_kana")]
        public string LastNameKana { get; set; }

        /// <summary>
        /// <para>
        /// The Kanji variation of the last name of the person who will be filling out a Stripe
        /// application.
        /// </para>
        /// <para>
        /// Must prefill <see cref="Country"/> with <c>JP</c>, as this parameter is only relevant
        /// for Japan.
        /// </para>
        /// </summary>
        [JsonProperty("last_name_kanji")]
        public string LastNameKanji { get; set; }

        /// <summary>
        /// <para>The business phone number. Must be 10 digits only.</para>
        /// <para>Must also prefill <see cref="Country"/> with the corresponding country.</para>
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary><c>true</c> if the user sells a physical product, <c>false</c> otherwise.</summary>
        [JsonProperty("physical_product")]
        public bool? PhysicalProduct { get; set; }

        /// <summary>A description of what the business is accepting payments for.</summary>
        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// <para>
        /// Address state of the business. Must be the two-letter state or province code (e.g.,
        /// <c>NY</c> for a U.S. business or <c>AB</c> for a Canadian one).
        /// </para>
        /// <para>
        /// Must also prefill <see cref="Country"/> with the corresponding country.
        /// </para>
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>Street address of the business.</summary>
        [JsonProperty("street_address")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// <para>
        /// The URL for the user's business. This may be the user's website, a profile page within
        /// your application, or another publicly available profile for the business, such as a
        /// LinkedIn or Facebook profile.
        /// </para>
        /// <para>
        /// Must be URL-encoded and include a scheme (<c>http</c> or <c>https</c>).
        /// </para>
        /// <para>
        /// If you will be prefilling this field, we highly recommend that the linked page contain
        /// a description of the user's products or services and their contact information. If we
        /// don't have enough information, we'll have to reach out to the user directly before
        /// initiating payouts.
        /// </para>
        /// </summary>
        /// <remarks>Recommended.</remarks>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// <para>Address postal code of the business.</para>
        /// <para>
        /// We highly recommend that you also prefill <see cref="Country"/> with the corresponding
        /// country.
        /// </para>
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }
    }
}
