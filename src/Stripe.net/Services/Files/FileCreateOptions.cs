namespace Stripe
{
    using System.IO;
    using Newtonsoft.Json;

    public class FileCreateOptions : BaseOptions
    {
        [JsonProperty("file")]
        public Stream File { get; set; }

        [JsonProperty("file_link_data")]
        public FileFileLinkDataOptions FileLinkData { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }
    }
}
