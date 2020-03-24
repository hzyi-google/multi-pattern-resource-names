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

namespace Google.Cloud.PubSub.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Iam.V1;
    using apis = Google.Cloud.PubSub.V1;
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
    public class GeneratedPublisherServiceApiClientSnippets
    {
        /// <summary>Snippet for CreateTopicAsync</summary>
        public async Task CreateTopicAsync()
        {
            // Snippet: CreateTopicAsync(TopicNameOneof,CallSettings)
            // Additional: CreateTopicAsync(TopicNameOneof,CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TopicNameOneof name = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]"));
            // Make the request
            Topic response = await publisherServiceApiClient.CreateTopicAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTopic</summary>
        public void CreateTopic()
        {
            // Snippet: CreateTopic(TopicNameOneof,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            TopicNameOneof name = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]"));
            // Make the request
            Topic response = publisherServiceApiClient.CreateTopic(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTopicAsync</summary>
        public async Task CreateTopicAsync_RequestObject()
        {
            // Snippet: CreateTopicAsync(Topic,CallSettings)
            // Additional: CreateTopicAsync(Topic,CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            Topic request = new Topic
            {
                TopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
            };
            // Make the request
            Topic response = await publisherServiceApiClient.CreateTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTopic</summary>
        public void CreateTopic_RequestObject()
        {
            // Snippet: CreateTopic(Topic,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            Topic request = new Topic
            {
                TopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
            };
            // Make the request
            Topic response = publisherServiceApiClient.CreateTopic(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTopicAsync</summary>
        public async Task UpdateTopicAsync_RequestObject()
        {
            // Snippet: UpdateTopicAsync(UpdateTopicRequest,CallSettings)
            // Additional: UpdateTopicAsync(UpdateTopicRequest,CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Topic response = await publisherServiceApiClient.UpdateTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTopic</summary>
        public void UpdateTopic_RequestObject()
        {
            // Snippet: UpdateTopic(UpdateTopicRequest,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Topic response = publisherServiceApiClient.UpdateTopic(request);
            // End snippet
        }

        /// <summary>Snippet for PublishAsync</summary>
        public async Task PublishAsync()
        {
            // Snippet: PublishAsync(TopicNameOneof,IEnumerable<PubsubMessage>,CallSettings)
            // Additional: PublishAsync(TopicNameOneof,IEnumerable<PubsubMessage>,CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TopicNameOneof topic = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]"));
            IEnumerable<PubsubMessage> messages = new[]
            {
                new PubsubMessage
                {
                    Data = ByteString.Empty,
                },
            };
            // Make the request
            PublishResponse response = await publisherServiceApiClient.PublishAsync(topic, messages);
            // End snippet
        }

        /// <summary>Snippet for Publish</summary>
        public void Publish()
        {
            // Snippet: Publish(TopicNameOneof,IEnumerable<PubsubMessage>,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            TopicNameOneof topic = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]"));
            IEnumerable<PubsubMessage> messages = new[]
            {
                new PubsubMessage
                {
                    Data = ByteString.Empty,
                },
            };
            // Make the request
            PublishResponse response = publisherServiceApiClient.Publish(topic, messages);
            // End snippet
        }

        /// <summary>Snippet for PublishAsync</summary>
        public async Task PublishAsync_RequestObject()
        {
            // Snippet: PublishAsync(PublishRequest,CallSettings)
            // Additional: PublishAsync(PublishRequest,CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                Messages =
                {
                    new PubsubMessage
                    {
                        Data = ByteString.Empty,
                    },
                },
            };
            // Make the request
            PublishResponse response = await publisherServiceApiClient.PublishAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Publish</summary>
        public void Publish_RequestObject()
        {
            // Snippet: Publish(PublishRequest,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            PublishRequest request = new PublishRequest
            {
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
                Messages =
                {
                    new PubsubMessage
                    {
                        Data = ByteString.Empty,
                    },
                },
            };
            // Make the request
            PublishResponse response = publisherServiceApiClient.Publish(request);
            // End snippet
        }

        /// <summary>Snippet for GetTopicAsync</summary>
        public async Task GetTopicAsync()
        {
            // Snippet: GetTopicAsync(TopicNameOneof,CallSettings)
            // Additional: GetTopicAsync(TopicNameOneof,CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TopicNameOneof topic = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]"));
            // Make the request
            Topic response = await publisherServiceApiClient.GetTopicAsync(topic);
            // End snippet
        }

        /// <summary>Snippet for GetTopic</summary>
        public void GetTopic()
        {
            // Snippet: GetTopic(TopicNameOneof,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            TopicNameOneof topic = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]"));
            // Make the request
            Topic response = publisherServiceApiClient.GetTopic(topic);
            // End snippet
        }

        /// <summary>Snippet for GetTopicAsync</summary>
        public async Task GetTopicAsync_RequestObject()
        {
            // Snippet: GetTopicAsync(GetTopicRequest,CallSettings)
            // Additional: GetTopicAsync(GetTopicRequest,CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            GetTopicRequest request = new GetTopicRequest
            {
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
            };
            // Make the request
            Topic response = await publisherServiceApiClient.GetTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTopic</summary>
        public void GetTopic_RequestObject()
        {
            // Snippet: GetTopic(GetTopicRequest,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            GetTopicRequest request = new GetTopicRequest
            {
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
            };
            // Make the request
            Topic response = publisherServiceApiClient.GetTopic(request);
            // End snippet
        }

        /// <summary>Snippet for ListTopicsAsync</summary>
        public async Task ListTopicsAsync()
        {
            // Snippet: ListTopicsAsync(ProjectName,string,int?,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName project = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListTopicsResponse, Topic> response =
                publisherServiceApiClient.ListTopicsAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Topic item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopics</summary>
        public void ListTopics()
        {
            // Snippet: ListTopics(ProjectName,string,int?,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            ProjectName project = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListTopicsResponse, Topic> response =
                publisherServiceApiClient.ListTopics(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Topic item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicsAsync</summary>
        public async Task ListTopicsAsync_RequestObject()
        {
            // Snippet: ListTopicsAsync(ListTopicsRequest,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ListTopicsRequest request = new ListTopicsRequest
            {
                ProjectAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTopicsResponse, Topic> response =
                publisherServiceApiClient.ListTopicsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Topic item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopics</summary>
        public void ListTopics_RequestObject()
        {
            // Snippet: ListTopics(ListTopicsRequest,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            ListTopicsRequest request = new ListTopicsRequest
            {
                ProjectAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListTopicsResponse, Topic> response =
                publisherServiceApiClient.ListTopics(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Topic item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptionsAsync</summary>
        public async Task ListTopicSubscriptionsAsync()
        {
            // Snippet: ListTopicSubscriptionsAsync(TopicNameOneof,string,int?,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TopicNameOneof topic = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]"));
            // Make the request
            PagedAsyncEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> response =
                publisherServiceApiClient.ListTopicSubscriptionsAsync(topic);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SubscriptionName item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SubscriptionName item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SubscriptionName> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SubscriptionName item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptions</summary>
        public void ListTopicSubscriptions()
        {
            // Snippet: ListTopicSubscriptions(TopicNameOneof,string,int?,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            TopicNameOneof topic = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]"));
            // Make the request
            PagedEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> response =
                publisherServiceApiClient.ListTopicSubscriptions(topic);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SubscriptionName item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SubscriptionName item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SubscriptionName> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SubscriptionName item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptionsAsync</summary>
        public async Task ListTopicSubscriptionsAsync_RequestObject()
        {
            // Snippet: ListTopicSubscriptionsAsync(ListTopicSubscriptionsRequest,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
            };
            // Make the request
            PagedAsyncEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> response =
                publisherServiceApiClient.ListTopicSubscriptionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SubscriptionName item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SubscriptionName item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SubscriptionName> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SubscriptionName item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptions</summary>
        public void ListTopicSubscriptions_RequestObject()
        {
            // Snippet: ListTopicSubscriptions(ListTopicSubscriptionsRequest,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
            };
            // Make the request
            PagedEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> response =
                publisherServiceApiClient.ListTopicSubscriptions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SubscriptionName item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SubscriptionName item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SubscriptionName> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SubscriptionName item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteTopicAsync</summary>
        public async Task DeleteTopicAsync()
        {
            // Snippet: DeleteTopicAsync(TopicNameOneof,CallSettings)
            // Additional: DeleteTopicAsync(TopicNameOneof,CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TopicNameOneof topic = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]"));
            // Make the request
            await publisherServiceApiClient.DeleteTopicAsync(topic);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopic</summary>
        public void DeleteTopic()
        {
            // Snippet: DeleteTopic(TopicNameOneof,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            TopicNameOneof topic = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]"));
            // Make the request
            publisherServiceApiClient.DeleteTopic(topic);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopicAsync</summary>
        public async Task DeleteTopicAsync_RequestObject()
        {
            // Snippet: DeleteTopicAsync(DeleteTopicRequest,CallSettings)
            // Additional: DeleteTopicAsync(DeleteTopicRequest,CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
            };
            // Make the request
            await publisherServiceApiClient.DeleteTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopic</summary>
        public void DeleteTopic_RequestObject()
        {
            // Snippet: DeleteTopic(DeleteTopicRequest,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicAsTopicNameOneof = TopicNameOneof.From(new TopicName("[PROJECT]", "[TOPIC]")),
            };
            // Make the request
            publisherServiceApiClient.DeleteTopic(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest,CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest,CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new ProjectName("[PROJECT]"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await publisherServiceApiClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new ProjectName("[PROJECT]"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = publisherServiceApiClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest,CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest,CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            Policy response = await publisherServiceApiClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            Policy response = publisherServiceApiClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest,CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest,CancellationToken)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = await PublisherServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new ProjectName("[PROJECT]"),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = await publisherServiceApiClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest,CallSettings)
            // Create client
            PublisherServiceApiClient publisherServiceApiClient = PublisherServiceApiClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new ProjectName("[PROJECT]"),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = publisherServiceApiClient.TestIamPermissions(request);
            // End snippet
        }

    }
}
