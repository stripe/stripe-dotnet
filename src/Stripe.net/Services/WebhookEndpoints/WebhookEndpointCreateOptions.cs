namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class WebhookEndpointCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Events sent to this endpoint will be generated with this Stripe Version instead of your
        /// account's default Stripe Version.
        /// One of: <c>2011-01-01</c>, <c>2011-06-21</c>, <c>2011-06-28</c>, <c>2011-08-01</c>,
        /// <c>2011-09-15</c>, <c>2011-11-17</c>, <c>2012-02-23</c>, <c>2012-03-25</c>,
        /// <c>2012-06-18</c>, <c>2012-06-28</c>, <c>2012-07-09</c>, <c>2012-09-24</c>,
        /// <c>2012-10-26</c>, <c>2012-11-07</c>, <c>2013-02-11</c>, <c>2013-02-13</c>,
        /// <c>2013-07-05</c>, <c>2013-08-12</c>, <c>2013-08-13</c>, <c>2013-10-29</c>,
        /// <c>2013-12-03</c>, <c>2014-01-31</c>, <c>2014-03-13</c>, <c>2014-03-28</c>,
        /// <c>2014-05-19</c>, <c>2014-06-13</c>, <c>2014-06-17</c>, <c>2014-07-22</c>,
        /// <c>2014-07-26</c>, <c>2014-08-04</c>, <c>2014-08-20</c>, <c>2014-09-08</c>,
        /// <c>2014-10-07</c>, <c>2014-11-05</c>, <c>2014-11-20</c>, <c>2014-12-08</c>,
        /// <c>2014-12-17</c>, <c>2014-12-22</c>, <c>2015-01-11</c>, <c>2015-01-26</c>,
        /// <c>2015-02-10</c>, <c>2015-02-16</c>, <c>2015-02-18</c>, <c>2015-03-24</c>,
        /// <c>2015-04-07</c>, <c>2015-06-15</c>, <c>2015-07-07</c>, <c>2015-07-13</c>,
        /// <c>2015-07-28</c>, <c>2015-08-07</c>, <c>2015-08-19</c>, <c>2015-09-03</c>,
        /// <c>2015-09-08</c>, <c>2015-09-23</c>, <c>2015-10-01</c>, <c>2015-10-12</c>,
        /// <c>2015-10-16</c>, <c>2016-02-03</c>, <c>2016-02-19</c>, <c>2016-02-22</c>,
        /// <c>2016-02-23</c>, <c>2016-02-29</c>, <c>2016-03-07</c>, <c>2016-06-15</c>,
        /// <c>2016-07-06</c>, <c>2016-10-19</c>, <c>2017-01-27</c>, <c>2017-02-14</c>,
        /// <c>2017-04-06</c>, <c>2017-05-25</c>, <c>2017-06-05</c>, <c>2017-08-15</c>,
        /// <c>2017-12-14</c>, <c>2018-01-23</c>, <c>2018-02-05</c>, <c>2018-02-06</c>,
        /// <c>2018-02-28</c>, <c>2018-05-21</c>, <c>2018-07-27</c>, <c>2018-08-23</c>,
        /// <c>2018-09-06</c>, <c>2018-09-24</c>, <c>2018-10-31</c>, <c>2018-11-08</c>,
        /// <c>2019-02-11</c>, <c>2019-02-19</c>, <c>2019-03-14</c>, <c>2019-05-16</c>,
        /// <c>2019-08-14</c>, <c>2019-09-09</c>, <c>2019-10-08</c>, <c>2019-10-17</c>,
        /// <c>2019-11-05</c>, <c>2019-12-03</c>, or <c>2020-03-02</c>.
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Whether this endpoint should receive events from connected accounts (<c>true</c>), or
        /// from your account (<c>false</c>). Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("connect")]
        public bool? Connect { get; set; }

        /// <summary>
        /// An optional description of what the webhook is used for.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The list of events to enable for this endpoint. You may specify <c>['*']</c> to enable
        /// all events, except those that require explicit selection.
        /// </summary>
        [JsonProperty("enabled_events")]
        public List<string> EnabledEvents { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The URL of the webhook endpoint.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
