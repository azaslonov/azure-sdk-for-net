// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The SubscriptionResourceGetMonitorMetricsWithPostOptions. </summary>
    public partial class SubscriptionResourceGetMonitorMetricsWithPostOptions
    {
        /// <summary> Initializes a new instance of <see cref="SubscriptionResourceGetMonitorMetricsWithPostOptions"/>. </summary>
        /// <param name="region"> The region where the metrics you want reside. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="region"/> is null. </exception>
        public SubscriptionResourceGetMonitorMetricsWithPostOptions(string region)
        {
            Argument.AssertNotNull(region, nameof(region));

            Region = region;
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionResourceGetMonitorMetricsWithPostOptions"/> for deserialization. </summary>
        internal SubscriptionResourceGetMonitorMetricsWithPostOptions()
        {
        }

        /// <summary> The region where the metrics you want reside. </summary>
        public string Region { get; }
        /// <summary> Parameters serialized in the body. </summary>
        public SubscriptionResourceGetMonitorMetricsWithPostContent Content { get; set; }
        /// <summary> The timespan of the query. It is a string with the following format 'startDateTime_ISO/endDateTime_ISO'. </summary>
        public string Timespan { get; set; }
        /// <summary> The interval (i.e. timegrain) of the query. </summary>
        public TimeSpan? Interval { get; set; }
        /// <summary> The names of the metrics (comma separated) to retrieve. </summary>
        public string Metricnames { get; set; }
        /// <summary> The list of aggregation types (comma separated) to retrieve. </summary>
        public string Aggregation { get; set; }
        /// <summary>
        /// The maximum number of records to retrieve.
        /// Valid only if $filter is specified.
        /// Defaults to 10.
        /// </summary>
        public int? Top { get; set; }
        /// <summary>
        /// The aggregation to use for sorting results and the direction of the sort.
        /// Only one order can be specified.
        /// Examples: sum asc.
        /// </summary>
        public string Orderby { get; set; }
        /// <summary> The **$filter** is used to reduce the set of metric data returned.&lt;br&gt;Example:&lt;br&gt;Metric contains metadata A, B and C.&lt;br&gt;- Return all time series of C where A = a1 and B = b1 or b2&lt;br&gt;**$filter=A eq ‘a1’ and B eq ‘b1’ or B eq ‘b2’ and C eq ‘*’**&lt;br&gt;- Invalid variant:&lt;br&gt;**$filter=A eq ‘a1’ and B eq ‘b1’ and C eq ‘*’ or B = ‘b2’**&lt;br&gt;This is invalid because the logical or operator cannot separate two different metadata names.&lt;br&gt;- Return all time series where A = a1, B = b1 and C = c1:&lt;br&gt;**$filter=A eq ‘a1’ and B eq ‘b1’ and C eq ‘c1’**&lt;br&gt;- Return all time series where A = a1&lt;br&gt;**$filter=A eq ‘a1’ and B eq ‘*’ and C eq ‘*’**. </summary>
        public string Filter { get; set; }
        /// <summary> Reduces the set of data collected. The syntax allowed depends on the operation. See the operation's description for details. </summary>
        public MonitorMetricResultType? ResultType { get; set; }
        /// <summary> Metric namespace where the metrics you want reside. </summary>
        public string Metricnamespace { get; set; }
        /// <summary> When set to true, if the timespan passed in is not supported by this metric, the API will return the result using the closest supported timespan. When set to false, an error is returned for invalid timespan parameters. Defaults to false. </summary>
        public bool? AutoAdjustTimegrain { get; set; }
        /// <summary> When set to false, invalid filter parameter values will be ignored. When set to true, an error is returned for invalid filter parameters. Defaults to true. </summary>
        public bool? ValidateDimensions { get; set; }
    }
}
