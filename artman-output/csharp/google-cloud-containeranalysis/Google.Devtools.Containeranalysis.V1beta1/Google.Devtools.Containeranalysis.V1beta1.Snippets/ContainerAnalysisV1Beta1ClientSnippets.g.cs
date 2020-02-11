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

namespace Google.Devtools.Containeranalysis.V1beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Iam.V1;
    using Google.Devtools.Containeranalysis.V1Beta1;
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
    public class GeneratedContainerAnalysisV1Beta1ClientSnippets
    {
        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(IamResourceNameOneof,Policy,CallSettings)
            // Additional: SetIamPolicyAsync(IamResourceNameOneof,Policy,CancellationToken)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = await ContainerAnalysisV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            Policy policy = new Policy();
            // Make the request
            Policy response = await containerAnalysisV1Beta1Client.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(IamResourceNameOneof,Policy,CallSettings)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = ContainerAnalysisV1Beta1Client.Create();
            // Initialize request argument(s)
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            Policy policy = new Policy();
            // Make the request
            Policy response = containerAnalysisV1Beta1Client.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest,CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest,CancellationToken)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = await ContainerAnalysisV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await containerAnalysisV1Beta1Client.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest,CallSettings)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = ContainerAnalysisV1Beta1Client.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = containerAnalysisV1Beta1Client.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(IamResourceNameOneof,CallSettings)
            // Additional: GetIamPolicyAsync(IamResourceNameOneof,CancellationToken)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = await ContainerAnalysisV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            // Make the request
            Policy response = await containerAnalysisV1Beta1Client.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(IamResourceNameOneof,CallSettings)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = ContainerAnalysisV1Beta1Client.Create();
            // Initialize request argument(s)
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            // Make the request
            Policy response = containerAnalysisV1Beta1Client.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest,CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest,CancellationToken)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = await ContainerAnalysisV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
            };
            // Make the request
            Policy response = await containerAnalysisV1Beta1Client.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest,CallSettings)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = ContainerAnalysisV1Beta1Client.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
            };
            // Make the request
            Policy response = containerAnalysisV1Beta1Client.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(IamResourceNameOneof,IEnumerable<string>,CallSettings)
            // Additional: TestIamPermissionsAsync(IamResourceNameOneof,IEnumerable<string>,CancellationToken)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = await ContainerAnalysisV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = await containerAnalysisV1Beta1Client.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(IamResourceNameOneof,IEnumerable<string>,CallSettings)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = ContainerAnalysisV1Beta1Client.Create();
            // Initialize request argument(s)
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = containerAnalysisV1Beta1Client.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest,CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest,CancellationToken)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = await ContainerAnalysisV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = await containerAnalysisV1Beta1Client.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest,CallSettings)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = ContainerAnalysisV1Beta1Client.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = containerAnalysisV1Beta1Client.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for GetScanConfigAsync</summary>
        public async Task GetScanConfigAsync()
        {
            // Snippet: GetScanConfigAsync(ScanConfigName,CallSettings)
            // Additional: GetScanConfigAsync(ScanConfigName,CancellationToken)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = await ContainerAnalysisV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ScanConfigName name = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]");
            // Make the request
            ScanConfig response = await containerAnalysisV1Beta1Client.GetScanConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetScanConfig</summary>
        public void GetScanConfig()
        {
            // Snippet: GetScanConfig(ScanConfigName,CallSettings)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = ContainerAnalysisV1Beta1Client.Create();
            // Initialize request argument(s)
            ScanConfigName name = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]");
            // Make the request
            ScanConfig response = containerAnalysisV1Beta1Client.GetScanConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetScanConfigAsync</summary>
        public async Task GetScanConfigAsync_RequestObject()
        {
            // Snippet: GetScanConfigAsync(GetScanConfigRequest,CallSettings)
            // Additional: GetScanConfigAsync(GetScanConfigRequest,CancellationToken)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = await ContainerAnalysisV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            GetScanConfigRequest request = new GetScanConfigRequest
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
            };
            // Make the request
            ScanConfig response = await containerAnalysisV1Beta1Client.GetScanConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetScanConfig</summary>
        public void GetScanConfig_RequestObject()
        {
            // Snippet: GetScanConfig(GetScanConfigRequest,CallSettings)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = ContainerAnalysisV1Beta1Client.Create();
            // Initialize request argument(s)
            GetScanConfigRequest request = new GetScanConfigRequest
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
            };
            // Make the request
            ScanConfig response = containerAnalysisV1Beta1Client.GetScanConfig(request);
            // End snippet
        }

        /// <summary>Snippet for ListScanConfigsAsync</summary>
        public async Task ListScanConfigsAsync()
        {
            // Snippet: ListScanConfigsAsync(ProjectName,string,string,int?,CallSettings)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = await ContainerAnalysisV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListScanConfigsResponse, ScanConfig> response =
                containerAnalysisV1Beta1Client.ListScanConfigsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ScanConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListScanConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanConfig item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanConfig item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanConfigs</summary>
        public void ListScanConfigs()
        {
            // Snippet: ListScanConfigs(ProjectName,string,string,int?,CallSettings)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = ContainerAnalysisV1Beta1Client.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListScanConfigsResponse, ScanConfig> response =
                containerAnalysisV1Beta1Client.ListScanConfigs(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScanConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScanConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanConfig item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanConfig item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanConfigsAsync</summary>
        public async Task ListScanConfigsAsync_RequestObject()
        {
            // Snippet: ListScanConfigsAsync(ListScanConfigsRequest,CallSettings)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = await ContainerAnalysisV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ListScanConfigsRequest request = new ListScanConfigsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListScanConfigsResponse, ScanConfig> response =
                containerAnalysisV1Beta1Client.ListScanConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ScanConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListScanConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanConfig item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanConfig item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScanConfigs</summary>
        public void ListScanConfigs_RequestObject()
        {
            // Snippet: ListScanConfigs(ListScanConfigsRequest,CallSettings)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = ContainerAnalysisV1Beta1Client.Create();
            // Initialize request argument(s)
            ListScanConfigsRequest request = new ListScanConfigsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListScanConfigsResponse, ScanConfig> response =
                containerAnalysisV1Beta1Client.ListScanConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ScanConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScanConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ScanConfig item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ScanConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ScanConfig item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateScanConfigAsync</summary>
        public async Task UpdateScanConfigAsync()
        {
            // Snippet: UpdateScanConfigAsync(ScanConfigName,ScanConfig,CallSettings)
            // Additional: UpdateScanConfigAsync(ScanConfigName,ScanConfig,CancellationToken)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = await ContainerAnalysisV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ScanConfigName name = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]");
            ScanConfig scanConfig = new ScanConfig();
            // Make the request
            ScanConfig response = await containerAnalysisV1Beta1Client.UpdateScanConfigAsync(name, scanConfig);
            // End snippet
        }

        /// <summary>Snippet for UpdateScanConfig</summary>
        public void UpdateScanConfig()
        {
            // Snippet: UpdateScanConfig(ScanConfigName,ScanConfig,CallSettings)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = ContainerAnalysisV1Beta1Client.Create();
            // Initialize request argument(s)
            ScanConfigName name = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]");
            ScanConfig scanConfig = new ScanConfig();
            // Make the request
            ScanConfig response = containerAnalysisV1Beta1Client.UpdateScanConfig(name, scanConfig);
            // End snippet
        }

        /// <summary>Snippet for UpdateScanConfigAsync</summary>
        public async Task UpdateScanConfigAsync_RequestObject()
        {
            // Snippet: UpdateScanConfigAsync(UpdateScanConfigRequest,CallSettings)
            // Additional: UpdateScanConfigAsync(UpdateScanConfigRequest,CancellationToken)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = await ContainerAnalysisV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            UpdateScanConfigRequest request = new UpdateScanConfigRequest
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
                ScanConfig = new ScanConfig(),
            };
            // Make the request
            ScanConfig response = await containerAnalysisV1Beta1Client.UpdateScanConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateScanConfig</summary>
        public void UpdateScanConfig_RequestObject()
        {
            // Snippet: UpdateScanConfig(UpdateScanConfigRequest,CallSettings)
            // Create client
            ContainerAnalysisV1Beta1Client containerAnalysisV1Beta1Client = ContainerAnalysisV1Beta1Client.Create();
            // Initialize request argument(s)
            UpdateScanConfigRequest request = new UpdateScanConfigRequest
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
                ScanConfig = new ScanConfig(),
            };
            // Make the request
            ScanConfig response = containerAnalysisV1Beta1Client.UpdateScanConfig(request);
            // End snippet
        }

    }
}
