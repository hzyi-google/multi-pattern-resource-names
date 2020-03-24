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

namespace Google.Cloud.Logging.V2.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Logging.V2;
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
    public class GeneratedConfigServiceV2ClientTest
    {
        [Fact]
        public void GetBucket()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetBucketRequest request = new GetBucketRequest
            {
                LogBucketNameOneof = "name3373707",
            };
            LogBucket expectedResponse = new LogBucket
            {
                LogBucketNameOneof = "name2-1052831874",
                Description = "description-1724546052",
                RetentionDays = 1544391896,
            };
            mockGrpcClient.Setup(x => x.GetBucket(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogBucket response = client.GetBucket(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetBucketAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetBucketRequest request = new GetBucketRequest
            {
                LogBucketNameOneof = "name3373707",
            };
            LogBucket expectedResponse = new LogBucket
            {
                LogBucketNameOneof = "name2-1052831874",
                Description = "description-1724546052",
                RetentionDays = 1544391896,
            };
            mockGrpcClient.Setup(x => x.GetBucketAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogBucket>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogBucket response = await client.GetBucketAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateBucket()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateBucketRequest request = new UpdateBucketRequest
            {
                LogBucketNameOneof = "name3373707",
                Bucket = new LogBucket(),
                UpdateMask = new FieldMask(),
            };
            LogBucket expectedResponse = new LogBucket
            {
                LogBucketNameOneof = "name2-1052831874",
                Description = "description-1724546052",
                RetentionDays = 1544391896,
            };
            mockGrpcClient.Setup(x => x.UpdateBucket(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogBucket response = client.UpdateBucket(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateBucketAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateBucketRequest request = new UpdateBucketRequest
            {
                LogBucketNameOneof = "name3373707",
                Bucket = new LogBucket(),
                UpdateMask = new FieldMask(),
            };
            LogBucket expectedResponse = new LogBucket
            {
                LogBucketNameOneof = "name2-1052831874",
                Description = "description-1724546052",
                RetentionDays = 1544391896,
            };
            mockGrpcClient.Setup(x => x.UpdateBucketAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogBucket>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogBucket response = await client.UpdateBucketAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSink()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetSinkRequest expectedRequest = new GetSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "sinkName-1391757129",
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkNameOneof = "name3373707",
                DestinationAsResourceName = new BillingAccountName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                Description = "description-1724546052",
                Disabled = true,
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.GetSink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            string sinkName = "sinkName-1391757129";
            LogSink response = client.GetSink(sinkName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSinkAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetSinkRequest expectedRequest = new GetSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "sinkName-1391757129",
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkNameOneof = "name3373707",
                DestinationAsResourceName = new BillingAccountName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                Description = "description-1724546052",
                Disabled = true,
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.GetSinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogSink>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            string sinkName = "sinkName-1391757129";
            LogSink response = await client.GetSinkAsync(sinkName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSink2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "sinkName-1391757129",
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkNameOneof = "name3373707",
                DestinationAsResourceName = new BillingAccountName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                Description = "description-1724546052",
                Disabled = true,
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.GetSink(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.GetSink(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSinkAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "sinkName-1391757129",
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkNameOneof = "name3373707",
                DestinationAsResourceName = new BillingAccountName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                Description = "description-1724546052",
                Disabled = true,
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.GetSinkAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogSink>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = await client.GetSinkAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSink()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateSinkRequest expectedRequest = new CreateSinkRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkNameOneof = "name3373707",
                DestinationAsResourceName = new BillingAccountName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                Description = "description-1724546052",
                Disabled = true,
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.CreateSink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            LogSink sink = new LogSink();
            LogSink response = client.CreateSink(parent, sink);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSinkAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateSinkRequest expectedRequest = new CreateSinkRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkNameOneof = "name3373707",
                DestinationAsResourceName = new BillingAccountName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                Description = "description-1724546052",
                Disabled = true,
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogSink>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            LogSink sink = new LogSink();
            LogSink response = await client.CreateSinkAsync(parent, sink);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSink2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkNameOneof = "name3373707",
                DestinationAsResourceName = new BillingAccountName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                Description = "description-1724546052",
                Disabled = true,
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.CreateSink(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.CreateSink(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSinkAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkNameOneof = "name3373707",
                DestinationAsResourceName = new BillingAccountName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                Description = "description-1724546052",
                Disabled = true,
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.CreateSinkAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogSink>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = await client.CreateSinkAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSink()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateSinkRequest expectedRequest = new UpdateSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "sinkName-1391757129",
                Sink = new LogSink(),
                UpdateMask = new FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkNameOneof = "name3373707",
                DestinationAsResourceName = new BillingAccountName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                Description = "description-1724546052",
                Disabled = true,
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            string sinkName = "sinkName-1391757129";
            LogSink sink = new LogSink();
            FieldMask updateMask = new FieldMask();
            LogSink response = client.UpdateSink(sinkName, sink, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSinkAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateSinkRequest expectedRequest = new UpdateSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "sinkName-1391757129",
                Sink = new LogSink(),
                UpdateMask = new FieldMask(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkNameOneof = "name3373707",
                DestinationAsResourceName = new BillingAccountName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                Description = "description-1724546052",
                Disabled = true,
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogSink>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            string sinkName = "sinkName-1391757129";
            LogSink sink = new LogSink();
            FieldMask updateMask = new FieldMask();
            LogSink response = await client.UpdateSinkAsync(sinkName, sink, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSink2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateSinkRequest expectedRequest = new UpdateSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "sinkName-1391757129",
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkNameOneof = "name3373707",
                DestinationAsResourceName = new BillingAccountName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                Description = "description-1724546052",
                Disabled = true,
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            string sinkName = "sinkName-1391757129";
            LogSink sink = new LogSink();
            LogSink response = client.UpdateSink(sinkName, sink);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSinkAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateSinkRequest expectedRequest = new UpdateSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "sinkName-1391757129",
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkNameOneof = "name3373707",
                DestinationAsResourceName = new BillingAccountName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                Description = "description-1724546052",
                Disabled = true,
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogSink>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            string sinkName = "sinkName-1391757129";
            LogSink sink = new LogSink();
            LogSink response = await client.UpdateSinkAsync(sinkName, sink);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSink3()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "sinkName-1391757129",
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkNameOneof = "name3373707",
                DestinationAsResourceName = new BillingAccountName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                Description = "description-1724546052",
                Disabled = true,
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.UpdateSink(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = client.UpdateSink(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSinkAsync3()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "sinkName-1391757129",
                Sink = new LogSink(),
            };
            LogSink expectedResponse = new LogSink
            {
                LogSinkNameOneof = "name3373707",
                DestinationAsResourceName = new BillingAccountName("[BILLING_ACCOUNT]"),
                Filter = "filter-1274492040",
                Description = "description-1724546052",
                Disabled = true,
                WriterIdentity = "writerIdentity775638794",
                IncludeChildren = true,
            };
            mockGrpcClient.Setup(x => x.UpdateSinkAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogSink>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogSink response = await client.UpdateSinkAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSink()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteSinkRequest expectedRequest = new DeleteSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "sinkName-1391757129",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            string sinkName = "sinkName-1391757129";
            client.DeleteSink(sinkName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSinkAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteSinkRequest expectedRequest = new DeleteSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "sinkName-1391757129",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            string sinkName = "sinkName-1391757129";
            await client.DeleteSinkAsync(sinkName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSink2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "sinkName-1391757129",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSink(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteSink(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSinkAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsLogSinkNameOneof = "sinkName-1391757129",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSinkAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSinkAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetExclusion()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetExclusionRequest expectedRequest = new GetExclusionRequest
            {
                LogExclusionNameOneof = "name3373707",
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionNameOneof = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.GetExclusion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            LogExclusion response = client.GetExclusion(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetExclusionAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetExclusionRequest expectedRequest = new GetExclusionRequest
            {
                LogExclusionNameOneof = "name3373707",
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionNameOneof = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.GetExclusionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogExclusion>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            LogExclusion response = await client.GetExclusionAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetExclusion2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetExclusionRequest request = new GetExclusionRequest
            {
                LogExclusionNameOneof = "name3373707",
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionNameOneof = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.GetExclusion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.GetExclusion(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetExclusionAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetExclusionRequest request = new GetExclusionRequest
            {
                LogExclusionNameOneof = "name3373707",
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionNameOneof = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.GetExclusionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogExclusion>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = await client.GetExclusionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateExclusion()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateExclusionRequest expectedRequest = new CreateExclusionRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionNameOneof = "name3373707",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            LogExclusion exclusion = new LogExclusion();
            LogExclusion response = client.CreateExclusion(parent, exclusion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateExclusionAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateExclusionRequest expectedRequest = new CreateExclusionRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionNameOneof = "name3373707",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogExclusion>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            LogExclusion exclusion = new LogExclusion();
            LogExclusion response = await client.CreateExclusionAsync(parent, exclusion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateExclusion2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionNameOneof = "name3373707",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateExclusion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.CreateExclusion(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateExclusionAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionNameOneof = "name3373707",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.CreateExclusionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogExclusion>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = await client.CreateExclusionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateExclusion()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateExclusionRequest expectedRequest = new UpdateExclusionRequest
            {
                LogExclusionNameOneof = "name3373707",
                Exclusion = new LogExclusion(),
                UpdateMask = new FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionNameOneof = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.UpdateExclusion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            LogExclusion exclusion = new LogExclusion();
            FieldMask updateMask = new FieldMask();
            LogExclusion response = client.UpdateExclusion(name, exclusion, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateExclusionAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateExclusionRequest expectedRequest = new UpdateExclusionRequest
            {
                LogExclusionNameOneof = "name3373707",
                Exclusion = new LogExclusion(),
                UpdateMask = new FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionNameOneof = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.UpdateExclusionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogExclusion>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            LogExclusion exclusion = new LogExclusion();
            FieldMask updateMask = new FieldMask();
            LogExclusion response = await client.UpdateExclusionAsync(name, exclusion, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateExclusion2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                LogExclusionNameOneof = "name3373707",
                Exclusion = new LogExclusion(),
                UpdateMask = new FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionNameOneof = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.UpdateExclusion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = client.UpdateExclusion(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateExclusionAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                LogExclusionNameOneof = "name3373707",
                Exclusion = new LogExclusion(),
                UpdateMask = new FieldMask(),
            };
            LogExclusion expectedResponse = new LogExclusion
            {
                LogExclusionNameOneof = "name2-1052831874",
                Description = "description-1724546052",
                Filter = "filter-1274492040",
                Disabled = true,
            };
            mockGrpcClient.Setup(x => x.UpdateExclusionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LogExclusion>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            LogExclusion response = await client.UpdateExclusionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteExclusion()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteExclusionRequest expectedRequest = new DeleteExclusionRequest
            {
                LogExclusionNameOneof = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteExclusion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            client.DeleteExclusion(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteExclusionAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteExclusionRequest expectedRequest = new DeleteExclusionRequest
            {
                LogExclusionNameOneof = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteExclusionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            string name = "name3373707";
            await client.DeleteExclusionAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteExclusion2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                LogExclusionNameOneof = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteExclusion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            client.DeleteExclusion(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteExclusionAsync2()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                LogExclusionNameOneof = "name3373707",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteExclusionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            await client.DeleteExclusionAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetCmekSettings()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetCmekSettingsRequest request = new GetCmekSettingsRequest
            {
                CmekSettingsNameOneof = "name3373707",
            };
            CmekSettings expectedResponse = new CmekSettings
            {
                CmekSettingsNameOneof = "name2-1052831874",
                KmsKeyName = "kmsKeyName2094986649",
                ServiceAccountId = "serviceAccountId-111486921",
            };
            mockGrpcClient.Setup(x => x.GetCmekSettings(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            CmekSettings response = client.GetCmekSettings(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetCmekSettingsAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            GetCmekSettingsRequest request = new GetCmekSettingsRequest
            {
                CmekSettingsNameOneof = "name3373707",
            };
            CmekSettings expectedResponse = new CmekSettings
            {
                CmekSettingsNameOneof = "name2-1052831874",
                KmsKeyName = "kmsKeyName2094986649",
                ServiceAccountId = "serviceAccountId-111486921",
            };
            mockGrpcClient.Setup(x => x.GetCmekSettingsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CmekSettings>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            CmekSettings response = await client.GetCmekSettingsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateCmekSettings()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateCmekSettingsRequest request = new UpdateCmekSettingsRequest
            {
                Name = "name3373707",
                CmekSettings = new CmekSettings(),
            };
            CmekSettings expectedResponse = new CmekSettings
            {
                CmekSettingsNameOneof = "name2-1052831874",
                KmsKeyName = "kmsKeyName2094986649",
                ServiceAccountId = "serviceAccountId-111486921",
            };
            mockGrpcClient.Setup(x => x.UpdateCmekSettings(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            CmekSettings response = client.UpdateCmekSettings(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateCmekSettingsAsync()
        {
            Mock<ConfigServiceV2.ConfigServiceV2Client> mockGrpcClient = new Mock<ConfigServiceV2.ConfigServiceV2Client>(MockBehavior.Strict);
            UpdateCmekSettingsRequest request = new UpdateCmekSettingsRequest
            {
                Name = "name3373707",
                CmekSettings = new CmekSettings(),
            };
            CmekSettings expectedResponse = new CmekSettings
            {
                CmekSettingsNameOneof = "name2-1052831874",
                KmsKeyName = "kmsKeyName2094986649",
                ServiceAccountId = "serviceAccountId-111486921",
            };
            mockGrpcClient.Setup(x => x.UpdateCmekSettingsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CmekSettings>(Task.FromResult(expectedResponse), null, null, null, null));
            ConfigServiceV2Client client = new ConfigServiceV2ClientImpl(mockGrpcClient.Object, null);
            CmekSettings response = await client.UpdateCmekSettingsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
