// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationTokenDetailsNetworkDataDevice : StripeEntity<AuthorizationTokenDetailsNetworkDataDevice>
    {
        /// <summary>
        /// The IP address of the device at provisioning time.
        /// </summary>
        [JsonProperty("ip_address")]
        [STJS.JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The ISO 639-1 language code of the device associated with the tokenization request.
        /// One of: <c>aa</c>, <c>ab</c>, <c>ae</c>, <c>af</c>, <c>ak</c>, <c>am</c>, <c>an</c>,
        /// <c>ar</c>, <c>as</c>, <c>av</c>, <c>ay</c>, <c>az</c>, <c>ba</c>, <c>be</c>, <c>bg</c>,
        /// <c>bi</c>, <c>bm</c>, <c>bn</c>, <c>bo</c>, <c>br</c>, <c>bs</c>, <c>ca</c>, <c>ce</c>,
        /// <c>ch</c>, <c>co</c>, <c>cr</c>, <c>cs</c>, <c>cu</c>, <c>cv</c>, <c>cy</c>, <c>da</c>,
        /// <c>de</c>, <c>dv</c>, <c>dz</c>, <c>ee</c>, <c>el</c>, <c>en</c>, <c>eo</c>, <c>es</c>,
        /// <c>et</c>, <c>eu</c>, <c>fa</c>, <c>ff</c>, <c>fi</c>, <c>fj</c>, <c>fo</c>, <c>fr</c>,
        /// <c>fy</c>, <c>ga</c>, <c>gd</c>, <c>gl</c>, <c>gn</c>, <c>gu</c>, <c>gv</c>, <c>ha</c>,
        /// <c>he</c>, <c>hi</c>, <c>ho</c>, <c>hr</c>, <c>ht</c>, <c>hu</c>, <c>hy</c>, <c>hz</c>,
        /// <c>ia</c>, <c>id</c>, <c>ie</c>, <c>ig</c>, <c>ii</c>, <c>ik</c>, <c>io</c>, <c>is</c>,
        /// <c>it</c>, <c>iu</c>, <c>ja</c>, <c>jv</c>, <c>ka</c>, <c>kg</c>, <c>ki</c>, <c>kj</c>,
        /// <c>kk</c>, <c>kl</c>, <c>km</c>, <c>kn</c>, <c>ko</c>, <c>kr</c>, <c>ks</c>, <c>ku</c>,
        /// <c>kv</c>, <c>kw</c>, <c>ky</c>, <c>la</c>, <c>lb</c>, <c>lg</c>, <c>li</c>, <c>ln</c>,
        /// <c>lo</c>, <c>lt</c>, <c>lu</c>, <c>lv</c>, <c>mg</c>, <c>mh</c>, <c>mi</c>, <c>mk</c>,
        /// <c>ml</c>, <c>mn</c>, <c>mr</c>, <c>ms</c>, <c>mt</c>, <c>my</c>, <c>na</c>, <c>nb</c>,
        /// <c>nd</c>, <c>ne</c>, <c>ng</c>, <c>nl</c>, <c>nn</c>, <c>no</c>, <c>nr</c>, <c>nv</c>,
        /// <c>ny</c>, <c>oc</c>, <c>oj</c>, <c>om</c>, <c>or</c>, <c>os</c>, <c>pa</c>, <c>pi</c>,
        /// <c>pl</c>, <c>ps</c>, <c>pt</c>, <c>qu</c>, <c>rm</c>, <c>rn</c>, <c>ro</c>, <c>ru</c>,
        /// <c>rw</c>, <c>sa</c>, <c>sc</c>, <c>sd</c>, <c>se</c>, <c>sg</c>, <c>si</c>, <c>sk</c>,
        /// <c>sl</c>, <c>sm</c>, <c>sn</c>, <c>so</c>, <c>sq</c>, <c>sr</c>, <c>ss</c>, <c>st</c>,
        /// <c>su</c>, <c>sv</c>, <c>sw</c>, <c>ta</c>, <c>te</c>, <c>tg</c>, <c>th</c>, <c>ti</c>,
        /// <c>tk</c>, <c>tl</c>, <c>tn</c>, <c>to</c>, <c>tr</c>, <c>ts</c>, <c>tt</c>, <c>tw</c>,
        /// <c>ty</c>, <c>ug</c>, <c>uk</c>, <c>ur</c>, <c>uz</c>, <c>ve</c>, <c>vi</c>, <c>vo</c>,
        /// <c>wa</c>, <c>wo</c>, <c>xh</c>, <c>yi</c>, <c>yo</c>, <c>za</c>, <c>zh</c>, or
        /// <c>zu</c>.
        /// </summary>
        [JsonProperty("language")]
        [STJS.JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// The phone number of the device used for tokenization.
        /// </summary>
        [JsonProperty("phone_number")]
        [STJS.JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
