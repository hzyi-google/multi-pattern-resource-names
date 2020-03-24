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
    public class GeneratedConfigServiceV2ClientSnippets
    {
        /// <summary>Snippet for ListBucketsAsync</summary>
        public async Task ListBucketsAsync()
        {
            // Snippet: ListBucketsAsync(LocationName,string,int?,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBucketsResponse, LogBucket> response =
                configServiceV2Client.ListBucketsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogBucket item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBucketsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogBucket item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogBucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogBucket item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuckets</summary>
        public void ListBuckets()
        {
            // Snippet: ListBuckets(LocationName,string,int?,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBucketsResponse, LogBucket> response =
                configServiceV2Client.ListBuckets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogBucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBucketsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogBucket item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogBucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogBucket item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBucketsAsync</summary>
        public async Task ListBucketsAsync_RequestObject()
        {
            // Snippet: ListBucketsAsync(ListBucketsRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ListBucketsRequest request = new ListBucketsRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListBucketsResponse, LogBucket> response =
                configServiceV2Client.ListBucketsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogBucket item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBucketsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogBucket item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogBucket> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogBucket item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuckets</summary>
        public void ListBuckets_RequestObject()
        {
            // Snippet: ListBuckets(ListBucketsRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ListBucketsRequest request = new ListBucketsRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListBucketsResponse, LogBucket> response =
                configServiceV2Client.ListBuckets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogBucket item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBucketsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogBucket item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogBucket> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogBucket item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetBucketAsync</summary>
        public async Task GetBucketAsync_RequestObject()
        {
            // Snippet: GetBucketAsync(GetBucketRequest,CallSettings)
            // Additional: GetBucketAsync(GetBucketRequest,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            GetBucketRequest request = new GetBucketRequest
            {
                LogBucketNameOneof = "",
            };
            // Make the request
            LogBucket response = await configServiceV2Client.GetBucketAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBucket</summary>
        public void GetBucket_RequestObject()
        {
            // Snippet: GetBucket(GetBucketRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            GetBucketRequest request = new GetBucketRequest
            {
                LogBucketNameOneof = "",
            };
            // Make the request
            LogBucket response = configServiceV2Client.GetBucket(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBucketAsync</summary>
        public async Task UpdateBucketAsync_RequestObject()
        {
            // Snippet: UpdateBucketAsync(UpdateBucketRequest,CallSettings)
            // Additional: UpdateBucketAsync(UpdateBucketRequest,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            UpdateBucketRequest request = new UpdateBucketRequest
            {
                LogBucketNameOneof = "",
                Bucket = new LogBucket(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LogBucket response = await configServiceV2Client.UpdateBucketAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBucket</summary>
        public void UpdateBucket_RequestObject()
        {
            // Snippet: UpdateBucket(UpdateBucketRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            UpdateBucketRequest request = new UpdateBucketRequest
            {
                LogBucketNameOneof = "",
                Bucket = new LogBucket(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LogBucket response = configServiceV2Client.UpdateBucket(request);
            // End snippet
        }

        /// <summary>Snippet for ListSinksAsync</summary>
        public async Task ListSinksAsync()
        {
            // Snippet: ListSinksAsync(ProjectName,string,int?,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSinksResponse, LogSink> response =
                configServiceV2Client.ListSinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogSink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSinks</summary>
        public void ListSinks()
        {
            // Snippet: ListSinks(ProjectName,string,int?,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSinksResponse, LogSink> response =
                configServiceV2Client.ListSinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogSink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSinksAsync</summary>
        public async Task ListSinksAsync_RequestObject()
        {
            // Snippet: ListSinksAsync(ListSinksRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ListSinksRequest request = new ListSinksRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSinksResponse, LogSink> response =
                configServiceV2Client.ListSinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogSink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSinks</summary>
        public void ListSinks_RequestObject()
        {
            // Snippet: ListSinks(ListSinksRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ListSinksRequest request = new ListSinksRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListSinksResponse, LogSink> response =
                configServiceV2Client.ListSinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogSink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSinkAsync</summary>
        public async Task GetSinkAsync()
        {
            // Snippet: GetSinkAsync(LogSinkNameOneof,CallSettings)
            // Additional: GetSinkAsync(LogSinkNameOneof,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string sinkName = "";
            // Make the request
            LogSink response = await configServiceV2Client.GetSinkAsync(sinkName);
            // End snippet
        }

        /// <summary>Snippet for GetSink</summary>
        public void GetSink()
        {
            // Snippet: GetSink(LogSinkNameOneof,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string sinkName = "";
            // Make the request
            LogSink response = configServiceV2Client.GetSink(sinkName);
            // End snippet
        }

        /// <summary>Snippet for GetSinkAsync</summary>
        public async Task GetSinkAsync_RequestObject()
        {
            // Snippet: GetSinkAsync(GetSinkRequest,CallSettings)
            // Additional: GetSinkAsync(GetSinkRequest,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "",
            };
            // Make the request
            LogSink response = await configServiceV2Client.GetSinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSink</summary>
        public void GetSink_RequestObject()
        {
            // Snippet: GetSink(GetSinkRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "",
            };
            // Make the request
            LogSink response = configServiceV2Client.GetSink(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSinkAsync</summary>
        public async Task CreateSinkAsync()
        {
            // Snippet: CreateSinkAsync(ProjectName,LogSink,CallSettings)
            // Additional: CreateSinkAsync(ProjectName,LogSink,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = await configServiceV2Client.CreateSinkAsync(parent, sink);
            // End snippet
        }

        /// <summary>Snippet for CreateSink</summary>
        public void CreateSink()
        {
            // Snippet: CreateSink(ProjectName,LogSink,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = configServiceV2Client.CreateSink(parent, sink);
            // End snippet
        }

        /// <summary>Snippet for CreateSinkAsync</summary>
        public async Task CreateSinkAsync_RequestObject()
        {
            // Snippet: CreateSinkAsync(CreateSinkRequest,CallSettings)
            // Additional: CreateSinkAsync(CreateSinkRequest,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Sink = new LogSink(),
            };
            // Make the request
            LogSink response = await configServiceV2Client.CreateSinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSink</summary>
        public void CreateSink_RequestObject()
        {
            // Snippet: CreateSink(CreateSinkRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Sink = new LogSink(),
            };
            // Make the request
            LogSink response = configServiceV2Client.CreateSink(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSinkAsync</summary>
        public async Task UpdateSinkAsync1()
        {
            // Snippet: UpdateSinkAsync(LogSinkNameOneof,LogSink,FieldMask,CallSettings)
            // Additional: UpdateSinkAsync(LogSinkNameOneof,LogSink,FieldMask,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string sinkName = "";
            LogSink sink = new LogSink();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LogSink response = await configServiceV2Client.UpdateSinkAsync(sinkName, sink, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSink</summary>
        public void UpdateSink1()
        {
            // Snippet: UpdateSink(LogSinkNameOneof,LogSink,FieldMask,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string sinkName = "";
            LogSink sink = new LogSink();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LogSink response = configServiceV2Client.UpdateSink(sinkName, sink, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSinkAsync</summary>
        public async Task UpdateSinkAsync2()
        {
            // Snippet: UpdateSinkAsync(LogSinkNameOneof,LogSink,CallSettings)
            // Additional: UpdateSinkAsync(LogSinkNameOneof,LogSink,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string sinkName = "";
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = await configServiceV2Client.UpdateSinkAsync(sinkName, sink);
            // End snippet
        }

        /// <summary>Snippet for UpdateSink</summary>
        public void UpdateSink2()
        {
            // Snippet: UpdateSink(LogSinkNameOneof,LogSink,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string sinkName = "";
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = configServiceV2Client.UpdateSink(sinkName, sink);
            // End snippet
        }

        /// <summary>Snippet for UpdateSinkAsync</summary>
        public async Task UpdateSinkAsync_RequestObject()
        {
            // Snippet: UpdateSinkAsync(UpdateSinkRequest,CallSettings)
            // Additional: UpdateSinkAsync(UpdateSinkRequest,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "",
                Sink = new LogSink(),
            };
            // Make the request
            LogSink response = await configServiceV2Client.UpdateSinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSink</summary>
        public void UpdateSink_RequestObject()
        {
            // Snippet: UpdateSink(UpdateSinkRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "",
                Sink = new LogSink(),
            };
            // Make the request
            LogSink response = configServiceV2Client.UpdateSink(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSinkAsync</summary>
        public async Task DeleteSinkAsync()
        {
            // Snippet: DeleteSinkAsync(LogSinkNameOneof,CallSettings)
            // Additional: DeleteSinkAsync(LogSinkNameOneof,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string sinkName = "";
            // Make the request
            await configServiceV2Client.DeleteSinkAsync(sinkName);
            // End snippet
        }

        /// <summary>Snippet for DeleteSink</summary>
        public void DeleteSink()
        {
            // Snippet: DeleteSink(LogSinkNameOneof,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string sinkName = "";
            // Make the request
            configServiceV2Client.DeleteSink(sinkName);
            // End snippet
        }

        /// <summary>Snippet for DeleteSinkAsync</summary>
        public async Task DeleteSinkAsync_RequestObject()
        {
            // Snippet: DeleteSinkAsync(DeleteSinkRequest,CallSettings)
            // Additional: DeleteSinkAsync(DeleteSinkRequest,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "",
            };
            // Make the request
            await configServiceV2Client.DeleteSinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSink</summary>
        public void DeleteSink_RequestObject()
        {
            // Snippet: DeleteSink(DeleteSinkRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "",
            };
            // Make the request
            configServiceV2Client.DeleteSink(request);
            // End snippet
        }

        /// <summary>Snippet for ListExclusionsAsync</summary>
        public async Task ListExclusionsAsync()
        {
            // Snippet: ListExclusionsAsync(ProjectName,string,int?,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> response =
                configServiceV2Client.ListExclusionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogExclusion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExclusionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExclusions</summary>
        public void ListExclusions()
        {
            // Snippet: ListExclusions(ProjectName,string,int?,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListExclusionsResponse, LogExclusion> response =
                configServiceV2Client.ListExclusions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogExclusion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExclusionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExclusionsAsync</summary>
        public async Task ListExclusionsAsync_RequestObject()
        {
            // Snippet: ListExclusionsAsync(ListExclusionsRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ListExclusionsRequest request = new ListExclusionsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> response =
                configServiceV2Client.ListExclusionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogExclusion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExclusionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExclusions</summary>
        public void ListExclusions_RequestObject()
        {
            // Snippet: ListExclusions(ListExclusionsRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ListExclusionsRequest request = new ListExclusionsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListExclusionsResponse, LogExclusion> response =
                configServiceV2Client.ListExclusions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogExclusion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExclusionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetExclusionAsync</summary>
        public async Task GetExclusionAsync()
        {
            // Snippet: GetExclusionAsync(LogExclusionNameOneof,CallSettings)
            // Additional: GetExclusionAsync(LogExclusionNameOneof,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            LogExclusion response = await configServiceV2Client.GetExclusionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExclusion</summary>
        public void GetExclusion()
        {
            // Snippet: GetExclusion(LogExclusionNameOneof,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            LogExclusion response = configServiceV2Client.GetExclusion(name);
            // End snippet
        }

        /// <summary>Snippet for GetExclusionAsync</summary>
        public async Task GetExclusionAsync_RequestObject()
        {
            // Snippet: GetExclusionAsync(GetExclusionRequest,CallSettings)
            // Additional: GetExclusionAsync(GetExclusionRequest,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            GetExclusionRequest request = new GetExclusionRequest
            {
                LogExclusionNameOneof = "",
            };
            // Make the request
            LogExclusion response = await configServiceV2Client.GetExclusionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExclusion</summary>
        public void GetExclusion_RequestObject()
        {
            // Snippet: GetExclusion(GetExclusionRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            GetExclusionRequest request = new GetExclusionRequest
            {
                LogExclusionNameOneof = "",
            };
            // Make the request
            LogExclusion response = configServiceV2Client.GetExclusion(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusionAsync</summary>
        public async Task CreateExclusionAsync()
        {
            // Snippet: CreateExclusionAsync(ProjectName,LogExclusion,CallSettings)
            // Additional: CreateExclusionAsync(ProjectName,LogExclusion,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            LogExclusion exclusion = new LogExclusion();
            // Make the request
            LogExclusion response = await configServiceV2Client.CreateExclusionAsync(parent, exclusion);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusion</summary>
        public void CreateExclusion()
        {
            // Snippet: CreateExclusion(ProjectName,LogExclusion,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            LogExclusion exclusion = new LogExclusion();
            // Make the request
            LogExclusion response = configServiceV2Client.CreateExclusion(parent, exclusion);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusionAsync</summary>
        public async Task CreateExclusionAsync_RequestObject()
        {
            // Snippet: CreateExclusionAsync(CreateExclusionRequest,CallSettings)
            // Additional: CreateExclusionAsync(CreateExclusionRequest,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            // Make the request
            LogExclusion response = await configServiceV2Client.CreateExclusionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusion</summary>
        public void CreateExclusion_RequestObject()
        {
            // Snippet: CreateExclusion(CreateExclusionRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            // Make the request
            LogExclusion response = configServiceV2Client.CreateExclusion(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExclusionAsync</summary>
        public async Task UpdateExclusionAsync()
        {
            // Snippet: UpdateExclusionAsync(LogExclusionNameOneof,LogExclusion,FieldMask,CallSettings)
            // Additional: UpdateExclusionAsync(LogExclusionNameOneof,LogExclusion,FieldMask,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            LogExclusion exclusion = new LogExclusion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LogExclusion response = await configServiceV2Client.UpdateExclusionAsync(name, exclusion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateExclusion</summary>
        public void UpdateExclusion()
        {
            // Snippet: UpdateExclusion(LogExclusionNameOneof,LogExclusion,FieldMask,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string name = "";
            LogExclusion exclusion = new LogExclusion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LogExclusion response = configServiceV2Client.UpdateExclusion(name, exclusion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateExclusionAsync</summary>
        public async Task UpdateExclusionAsync_RequestObject()
        {
            // Snippet: UpdateExclusionAsync(UpdateExclusionRequest,CallSettings)
            // Additional: UpdateExclusionAsync(UpdateExclusionRequest,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                LogExclusionNameOneof = "",
                Exclusion = new LogExclusion(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LogExclusion response = await configServiceV2Client.UpdateExclusionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExclusion</summary>
        public void UpdateExclusion_RequestObject()
        {
            // Snippet: UpdateExclusion(UpdateExclusionRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                LogExclusionNameOneof = "",
                Exclusion = new LogExclusion(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LogExclusion response = configServiceV2Client.UpdateExclusion(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteExclusionAsync</summary>
        public async Task DeleteExclusionAsync()
        {
            // Snippet: DeleteExclusionAsync(LogExclusionNameOneof,CallSettings)
            // Additional: DeleteExclusionAsync(LogExclusionNameOneof,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            await configServiceV2Client.DeleteExclusionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExclusion</summary>
        public void DeleteExclusion()
        {
            // Snippet: DeleteExclusion(LogExclusionNameOneof,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            configServiceV2Client.DeleteExclusion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExclusionAsync</summary>
        public async Task DeleteExclusionAsync_RequestObject()
        {
            // Snippet: DeleteExclusionAsync(DeleteExclusionRequest,CallSettings)
            // Additional: DeleteExclusionAsync(DeleteExclusionRequest,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                LogExclusionNameOneof = "",
            };
            // Make the request
            await configServiceV2Client.DeleteExclusionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteExclusion</summary>
        public void DeleteExclusion_RequestObject()
        {
            // Snippet: DeleteExclusion(DeleteExclusionRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                LogExclusionNameOneof = "",
            };
            // Make the request
            configServiceV2Client.DeleteExclusion(request);
            // End snippet
        }

        /// <summary>Snippet for GetCmekSettingsAsync</summary>
        public async Task GetCmekSettingsAsync_RequestObject()
        {
            // Snippet: GetCmekSettingsAsync(GetCmekSettingsRequest,CallSettings)
            // Additional: GetCmekSettingsAsync(GetCmekSettingsRequest,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            GetCmekSettingsRequest request = new GetCmekSettingsRequest
            {
                CmekSettingsNameOneof = "",
            };
            // Make the request
            CmekSettings response = await configServiceV2Client.GetCmekSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCmekSettings</summary>
        public void GetCmekSettings_RequestObject()
        {
            // Snippet: GetCmekSettings(GetCmekSettingsRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            GetCmekSettingsRequest request = new GetCmekSettingsRequest
            {
                CmekSettingsNameOneof = "",
            };
            // Make the request
            CmekSettings response = configServiceV2Client.GetCmekSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCmekSettingsAsync</summary>
        public async Task UpdateCmekSettingsAsync_RequestObject()
        {
            // Snippet: UpdateCmekSettingsAsync(UpdateCmekSettingsRequest,CallSettings)
            // Additional: UpdateCmekSettingsAsync(UpdateCmekSettingsRequest,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            UpdateCmekSettingsRequest request = new UpdateCmekSettingsRequest
            {
                Name = "",
                CmekSettings = new CmekSettings(),
            };
            // Make the request
            CmekSettings response = await configServiceV2Client.UpdateCmekSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCmekSettings</summary>
        public void UpdateCmekSettings_RequestObject()
        {
            // Snippet: UpdateCmekSettings(UpdateCmekSettingsRequest,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            UpdateCmekSettingsRequest request = new UpdateCmekSettingsRequest
            {
                Name = "",
                CmekSettings = new CmekSettings(),
            };
            // Make the request
            CmekSettings response = configServiceV2Client.UpdateCmekSettings(request);
            // End snippet
        }

    }
}
