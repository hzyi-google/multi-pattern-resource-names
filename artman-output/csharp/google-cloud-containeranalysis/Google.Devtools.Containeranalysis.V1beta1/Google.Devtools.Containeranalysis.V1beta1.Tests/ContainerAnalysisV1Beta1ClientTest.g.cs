// Copyright 2019 Google LLC
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

namespace Google.Devtools.Containeranalysis.V1beta1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Iam.V1;
    using Google.Devtools.Containeranalysis.V1Beta1;
    using apis = Google.Devtools.Containeranalysis.V1beta1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedContainerAnalysisV1Beta1ClientTest
    {
        [Fact]
        public void SetIamPolicy()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            Policy policy = new Policy();
            Policy response = client.SetIamPolicy(resource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            Policy policy = new Policy();
            Policy response = await client.SetIamPolicyAsync(resource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicy2()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync2()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.SetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            Policy response = client.GetIamPolicy(resource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            Policy response = await client.GetIamPolicyAsync(resource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy2()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync2()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("21"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.GetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = client.TestIamPermissions(resource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            IamResourceNameOneof resource = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]"));
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(resource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions2()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = client.TestIamPermissions(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync2()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsIamResourceNameOneof = IamResourceNameOneof.From(new NoteName("[PROJECT]", "[NOTE]")),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetScanConfig()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            GetScanConfigRequest expectedRequest = new GetScanConfigRequest
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
            };
            ScanConfig expectedResponse = new ScanConfig
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
                Description = "description-1724546052",
                Enabled = false,
            };
            mockGrpcClient.Setup(x => x.GetScanConfig(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ScanConfigName name = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]");
            ScanConfig response = client.GetScanConfig(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetScanConfigAsync()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            GetScanConfigRequest expectedRequest = new GetScanConfigRequest
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
            };
            ScanConfig expectedResponse = new ScanConfig
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
                Description = "description-1724546052",
                Enabled = false,
            };
            mockGrpcClient.Setup(x => x.GetScanConfigAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ScanConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ScanConfigName name = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]");
            ScanConfig response = await client.GetScanConfigAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetScanConfig2()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            GetScanConfigRequest request = new GetScanConfigRequest
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
            };
            ScanConfig expectedResponse = new ScanConfig
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
                Description = "description-1724546052",
                Enabled = false,
            };
            mockGrpcClient.Setup(x => x.GetScanConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ScanConfig response = client.GetScanConfig(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetScanConfigAsync2()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            GetScanConfigRequest request = new GetScanConfigRequest
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
            };
            ScanConfig expectedResponse = new ScanConfig
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
                Description = "description-1724546052",
                Enabled = false,
            };
            mockGrpcClient.Setup(x => x.GetScanConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ScanConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ScanConfig response = await client.GetScanConfigAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateScanConfig()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            UpdateScanConfigRequest expectedRequest = new UpdateScanConfigRequest
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
                ScanConfig = new ScanConfig(),
            };
            ScanConfig expectedResponse = new ScanConfig
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
                Description = "description-1724546052",
                Enabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateScanConfig(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ScanConfigName name = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]");
            ScanConfig scanConfig = new ScanConfig();
            ScanConfig response = client.UpdateScanConfig(name, scanConfig);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateScanConfigAsync()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            UpdateScanConfigRequest expectedRequest = new UpdateScanConfigRequest
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
                ScanConfig = new ScanConfig(),
            };
            ScanConfig expectedResponse = new ScanConfig
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
                Description = "description-1724546052",
                Enabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateScanConfigAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ScanConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ScanConfigName name = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]");
            ScanConfig scanConfig = new ScanConfig();
            ScanConfig response = await client.UpdateScanConfigAsync(name, scanConfig);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateScanConfig2()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            UpdateScanConfigRequest request = new UpdateScanConfigRequest
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
                ScanConfig = new ScanConfig(),
            };
            ScanConfig expectedResponse = new ScanConfig
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
                Description = "description-1724546052",
                Enabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateScanConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ScanConfig response = client.UpdateScanConfig(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateScanConfigAsync2()
        {
            Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client> mockGrpcClient = new Mock<ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client>(MockBehavior.Strict);
            UpdateScanConfigRequest request = new UpdateScanConfigRequest
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
                ScanConfig = new ScanConfig(),
            };
            ScanConfig expectedResponse = new ScanConfig
            {
                ScanConfigName = new ScanConfigName("[PROJECT]", "[SCAN_CONFIG]"),
                Description = "description-1724546052",
                Enabled = false,
            };
            mockGrpcClient.Setup(x => x.UpdateScanConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ScanConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            ContainerAnalysisV1Beta1Client client = new ContainerAnalysisV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ScanConfig response = await client.UpdateScanConfigAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
