// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Logging.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Logging.V2;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedMetricsServiceV2ClientSnippets
    {
        /// <summary>Snippet for ListLogMetricsAsync</summary>
        public async Task ListLogMetricsAsync()
        {
            // Snippet: ListLogMetricsAsync(ProjectName,string,int?,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> response =
                metricsServiceV2Client.ListLogMetricsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogMetric item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogMetricsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogMetric item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogMetric> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogMetric item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogMetrics</summary>
        public void ListLogMetrics()
        {
            // Snippet: ListLogMetrics(ProjectName,string,int?,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListLogMetricsResponse, LogMetric> response =
                metricsServiceV2Client.ListLogMetrics(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogMetric item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogMetricsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogMetric item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogMetric> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogMetric item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogMetricsAsync</summary>
        public async Task ListLogMetricsAsync_RequestObject()
        {
            // Snippet: ListLogMetricsAsync(ListLogMetricsRequest,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ListLogMetricsRequest request = new ListLogMetricsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> response =
                metricsServiceV2Client.ListLogMetricsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogMetric item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogMetricsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogMetric item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogMetric> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogMetric item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogMetrics</summary>
        public void ListLogMetrics_RequestObject()
        {
            // Snippet: ListLogMetrics(ListLogMetricsRequest,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            ListLogMetricsRequest request = new ListLogMetricsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListLogMetricsResponse, LogMetric> response =
                metricsServiceV2Client.ListLogMetrics(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogMetric item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogMetricsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogMetric item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogMetric> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogMetric item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetLogMetricAsync</summary>
        public async Task GetLogMetricAsync()
        {
            // Snippet: GetLogMetricAsync(MetricName,CallSettings)
            // Additional: GetLogMetricAsync(MetricName,CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            MetricName metricName = new MetricName("[PROJECT]", "[METRIC]");
            // Make the request
            LogMetric response = await metricsServiceV2Client.GetLogMetricAsync(metricName);
            // End snippet
        }

        /// <summary>Snippet for GetLogMetric</summary>
        public void GetLogMetric()
        {
            // Snippet: GetLogMetric(MetricName,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            MetricName metricName = new MetricName("[PROJECT]", "[METRIC]");
            // Make the request
            LogMetric response = metricsServiceV2Client.GetLogMetric(metricName);
            // End snippet
        }

        /// <summary>Snippet for GetLogMetricAsync</summary>
        public async Task GetLogMetricAsync_RequestObject()
        {
            // Snippet: GetLogMetricAsync(GetLogMetricRequest,CallSettings)
            // Additional: GetLogMetricAsync(GetLogMetricRequest,CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            GetLogMetricRequest request = new GetLogMetricRequest
            {
                MetricNameAsMetricName = new MetricName("[PROJECT]", "[METRIC]"),
            };
            // Make the request
            LogMetric response = await metricsServiceV2Client.GetLogMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLogMetric</summary>
        public void GetLogMetric_RequestObject()
        {
            // Snippet: GetLogMetric(GetLogMetricRequest,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            GetLogMetricRequest request = new GetLogMetricRequest
            {
                MetricNameAsMetricName = new MetricName("[PROJECT]", "[METRIC]"),
            };
            // Make the request
            LogMetric response = metricsServiceV2Client.GetLogMetric(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLogMetricAsync</summary>
        public async Task CreateLogMetricAsync()
        {
            // Snippet: CreateLogMetricAsync(MetricName,LogMetric,CallSettings)
            // Additional: CreateLogMetricAsync(MetricName,LogMetric,CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            MetricName parent = new MetricName("[PROJECT]", "[METRIC]");
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = await metricsServiceV2Client.CreateLogMetricAsync(parent, metric);
            // End snippet
        }

        /// <summary>Snippet for CreateLogMetric</summary>
        public void CreateLogMetric()
        {
            // Snippet: CreateLogMetric(MetricName,LogMetric,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            MetricName parent = new MetricName("[PROJECT]", "[METRIC]");
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = metricsServiceV2Client.CreateLogMetric(parent, metric);
            // End snippet
        }

        /// <summary>Snippet for CreateLogMetricAsync</summary>
        public async Task CreateLogMetricAsync_RequestObject()
        {
            // Snippet: CreateLogMetricAsync(CreateLogMetricRequest,CallSettings)
            // Additional: CreateLogMetricAsync(CreateLogMetricRequest,CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            CreateLogMetricRequest request = new CreateLogMetricRequest
            {
                ParentAsMetricName = new MetricName("[PROJECT]", "[METRIC]"),
                Metric = new LogMetric(),
            };
            // Make the request
            LogMetric response = await metricsServiceV2Client.CreateLogMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLogMetric</summary>
        public void CreateLogMetric_RequestObject()
        {
            // Snippet: CreateLogMetric(CreateLogMetricRequest,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            CreateLogMetricRequest request = new CreateLogMetricRequest
            {
                ParentAsMetricName = new MetricName("[PROJECT]", "[METRIC]"),
                Metric = new LogMetric(),
            };
            // Make the request
            LogMetric response = metricsServiceV2Client.CreateLogMetric(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLogMetricAsync</summary>
        public async Task UpdateLogMetricAsync()
        {
            // Snippet: UpdateLogMetricAsync(MetricName,LogMetric,CallSettings)
            // Additional: UpdateLogMetricAsync(MetricName,LogMetric,CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            MetricName metricName = new MetricName("[PROJECT]", "[METRIC]");
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = await metricsServiceV2Client.UpdateLogMetricAsync(metricName, metric);
            // End snippet
        }

        /// <summary>Snippet for UpdateLogMetric</summary>
        public void UpdateLogMetric()
        {
            // Snippet: UpdateLogMetric(MetricName,LogMetric,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            MetricName metricName = new MetricName("[PROJECT]", "[METRIC]");
            LogMetric metric = new LogMetric();
            // Make the request
            LogMetric response = metricsServiceV2Client.UpdateLogMetric(metricName, metric);
            // End snippet
        }

        /// <summary>Snippet for UpdateLogMetricAsync</summary>
        public async Task UpdateLogMetricAsync_RequestObject()
        {
            // Snippet: UpdateLogMetricAsync(UpdateLogMetricRequest,CallSettings)
            // Additional: UpdateLogMetricAsync(UpdateLogMetricRequest,CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            UpdateLogMetricRequest request = new UpdateLogMetricRequest
            {
                MetricNameAsMetricName = new MetricName("[PROJECT]", "[METRIC]"),
                Metric = new LogMetric(),
            };
            // Make the request
            LogMetric response = await metricsServiceV2Client.UpdateLogMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLogMetric</summary>
        public void UpdateLogMetric_RequestObject()
        {
            // Snippet: UpdateLogMetric(UpdateLogMetricRequest,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            UpdateLogMetricRequest request = new UpdateLogMetricRequest
            {
                MetricNameAsMetricName = new MetricName("[PROJECT]", "[METRIC]"),
                Metric = new LogMetric(),
            };
            // Make the request
            LogMetric response = metricsServiceV2Client.UpdateLogMetric(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogMetricAsync</summary>
        public async Task DeleteLogMetricAsync()
        {
            // Snippet: DeleteLogMetricAsync(MetricName,CallSettings)
            // Additional: DeleteLogMetricAsync(MetricName,CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            MetricName metricName = new MetricName("[PROJECT]", "[METRIC]");
            // Make the request
            await metricsServiceV2Client.DeleteLogMetricAsync(metricName);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogMetric</summary>
        public void DeleteLogMetric()
        {
            // Snippet: DeleteLogMetric(MetricName,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            MetricName metricName = new MetricName("[PROJECT]", "[METRIC]");
            // Make the request
            metricsServiceV2Client.DeleteLogMetric(metricName);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogMetricAsync</summary>
        public async Task DeleteLogMetricAsync_RequestObject()
        {
            // Snippet: DeleteLogMetricAsync(DeleteLogMetricRequest,CallSettings)
            // Additional: DeleteLogMetricAsync(DeleteLogMetricRequest,CancellationToken)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = await MetricsServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            DeleteLogMetricRequest request = new DeleteLogMetricRequest
            {
                MetricNameAsMetricName = new MetricName("[PROJECT]", "[METRIC]"),
            };
            // Make the request
            await metricsServiceV2Client.DeleteLogMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogMetric</summary>
        public void DeleteLogMetric_RequestObject()
        {
            // Snippet: DeleteLogMetric(DeleteLogMetricRequest,CallSettings)
            // Create client
            MetricsServiceV2Client metricsServiceV2Client = MetricsServiceV2Client.Create();
            // Initialize request argument(s)
            DeleteLogMetricRequest request = new DeleteLogMetricRequest
            {
                MetricNameAsMetricName = new MetricName("[PROJECT]", "[METRIC]"),
            };
            // Make the request
            metricsServiceV2Client.DeleteLogMetric(request);
            // End snippet
        }

    }
}
