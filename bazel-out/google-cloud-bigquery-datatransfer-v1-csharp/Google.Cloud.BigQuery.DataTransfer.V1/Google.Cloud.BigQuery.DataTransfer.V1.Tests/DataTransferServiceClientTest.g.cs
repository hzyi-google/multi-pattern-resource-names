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

namespace Google.Cloud.BigQuery.DataTransfer.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.BigQuery.DataTransfer.V1;
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
    public class GeneratedDataTransferServiceClientTest
    {
        [Fact]
        public void GetDataSource()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetDataSourceRequest request = new GetDataSourceRequest();
            DataSource expectedResponse = new DataSource
            {
                Name = "name3373707",
                DataSourceId = "dataSourceId-1015796374",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ClientId = "clientId-1904089585",
                SupportsMultipleTransfers = true,
                UpdateDeadlineSeconds = 991471694,
                DefaultSchedule = "defaultSchedule-800168235",
                SupportsCustomSchedule = true,
                HelpUrl = "helpUrl-789431439",
                DefaultDataRefreshWindowDays = 1804935157,
                ManualRunsDisabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDataSource(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSource response = client.GetDataSource(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetDataSourceAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetDataSourceRequest request = new GetDataSourceRequest();
            DataSource expectedResponse = new DataSource
            {
                Name = "name3373707",
                DataSourceId = "dataSourceId-1015796374",
                DisplayName = "displayName1615086568",
                Description = "description-1724546052",
                ClientId = "clientId-1904089585",
                SupportsMultipleTransfers = true,
                UpdateDeadlineSeconds = 991471694,
                DefaultSchedule = "defaultSchedule-800168235",
                SupportsCustomSchedule = true,
                HelpUrl = "helpUrl-789431439",
                DefaultDataRefreshWindowDays = 1804935157,
                ManualRunsDisabled = true,
            };
            mockGrpcClient.Setup(x => x.GetDataSourceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DataSource>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            DataSource response = await client.GetDataSourceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListDataSources()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            ListDataSourcesRequest request = new ListDataSourcesRequest();
            ListDataSourcesResponse expectedResponse = new ListDataSourcesResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListDataSources(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ListDataSourcesResponse response = client.ListDataSources(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListDataSourcesAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            ListDataSourcesRequest request = new ListDataSourcesRequest();
            ListDataSourcesResponse expectedResponse = new ListDataSourcesResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListDataSourcesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListDataSourcesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ListDataSourcesResponse response = await client.ListDataSourcesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTransferConfig()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            CreateTransferConfigRequest request = new CreateTransferConfigRequest();
            TransferConfig expectedResponse = new TransferConfig
            {
                Name = "name3373707",
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.CreateTransferConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.CreateTransferConfig(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTransferConfigAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            CreateTransferConfigRequest request = new CreateTransferConfigRequest();
            TransferConfig expectedResponse = new TransferConfig
            {
                Name = "name3373707",
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.CreateTransferConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TransferConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = await client.CreateTransferConfigAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateTransferConfig()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            UpdateTransferConfigRequest request = new UpdateTransferConfigRequest();
            TransferConfig expectedResponse = new TransferConfig
            {
                Name = "name3373707",
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.UpdateTransferConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.UpdateTransferConfig(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateTransferConfigAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            UpdateTransferConfigRequest request = new UpdateTransferConfigRequest();
            TransferConfig expectedResponse = new TransferConfig
            {
                Name = "name3373707",
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.UpdateTransferConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TransferConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = await client.UpdateTransferConfigAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTransferConfig()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest();
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTransferConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTransferConfig(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTransferConfigAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest();
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTransferConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTransferConfigAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTransferConfig()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetTransferConfigRequest request = new GetTransferConfigRequest();
            TransferConfig expectedResponse = new TransferConfig
            {
                Name = "name3373707",
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.GetTransferConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = client.GetTransferConfig(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTransferConfigAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetTransferConfigRequest request = new GetTransferConfigRequest();
            TransferConfig expectedResponse = new TransferConfig
            {
                Name = "name3373707",
                DestinationDatasetId = "destinationDatasetId1541564179",
                DisplayName = "displayName1615086568",
                DataSourceId = "dataSourceId-1015796374",
                Schedule = "schedule-697920873",
                DataRefreshWindowDays = 327632845,
                Disabled = true,
                UserId = 147132913L,
                DatasetRegion = "datasetRegion959248539",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.GetTransferConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TransferConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferConfig response = await client.GetTransferConfigAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListTransferConfigs()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            ListTransferConfigsRequest request = new ListTransferConfigsRequest();
            ListTransferConfigsResponse expectedResponse = new ListTransferConfigsResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListTransferConfigs(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ListTransferConfigsResponse response = client.ListTransferConfigs(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListTransferConfigsAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            ListTransferConfigsRequest request = new ListTransferConfigsRequest();
            ListTransferConfigsResponse expectedResponse = new ListTransferConfigsResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListTransferConfigsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListTransferConfigsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ListTransferConfigsResponse response = await client.ListTransferConfigsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ScheduleTransferRuns()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest();
            ScheduleTransferRunsResponse expectedResponse = new ScheduleTransferRunsResponse();
            mockGrpcClient.Setup(x => x.ScheduleTransferRuns(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ScheduleTransferRunsResponse response = client.ScheduleTransferRuns(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ScheduleTransferRunsAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest();
            ScheduleTransferRunsResponse expectedResponse = new ScheduleTransferRunsResponse();
            mockGrpcClient.Setup(x => x.ScheduleTransferRunsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ScheduleTransferRunsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ScheduleTransferRunsResponse response = await client.ScheduleTransferRunsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void StartManualTransferRuns()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            StartManualTransferRunsRequest request = new StartManualTransferRunsRequest();
            StartManualTransferRunsResponse expectedResponse = new StartManualTransferRunsResponse();
            mockGrpcClient.Setup(x => x.StartManualTransferRuns(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            StartManualTransferRunsResponse response = client.StartManualTransferRuns(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task StartManualTransferRunsAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            StartManualTransferRunsRequest request = new StartManualTransferRunsRequest();
            StartManualTransferRunsResponse expectedResponse = new StartManualTransferRunsResponse();
            mockGrpcClient.Setup(x => x.StartManualTransferRunsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<StartManualTransferRunsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            StartManualTransferRunsResponse response = await client.StartManualTransferRunsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTransferRun()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetTransferRunRequest request = new GetTransferRunRequest();
            TransferRun expectedResponse = new TransferRun
            {
                Name = "name3373707",
                DestinationDatasetId = "destinationDatasetId1541564179",
                DataSourceId = "dataSourceId-1015796374",
                UserId = 147132913L,
                Schedule = "schedule-697920873",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.GetTransferRun(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferRun response = client.GetTransferRun(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTransferRunAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            GetTransferRunRequest request = new GetTransferRunRequest();
            TransferRun expectedResponse = new TransferRun
            {
                Name = "name3373707",
                DestinationDatasetId = "destinationDatasetId1541564179",
                DataSourceId = "dataSourceId-1015796374",
                UserId = 147132913L,
                Schedule = "schedule-697920873",
                NotificationPubsubTopic = "notificationPubsubTopic1794281191",
            };
            mockGrpcClient.Setup(x => x.GetTransferRunAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TransferRun>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            TransferRun response = await client.GetTransferRunAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTransferRun()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            DeleteTransferRunRequest request = new DeleteTransferRunRequest();
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTransferRun(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTransferRun(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTransferRunAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            DeleteTransferRunRequest request = new DeleteTransferRunRequest();
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTransferRunAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTransferRunAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListTransferRuns()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            ListTransferRunsRequest request = new ListTransferRunsRequest();
            ListTransferRunsResponse expectedResponse = new ListTransferRunsResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListTransferRuns(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ListTransferRunsResponse response = client.ListTransferRuns(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListTransferRunsAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            ListTransferRunsRequest request = new ListTransferRunsRequest();
            ListTransferRunsResponse expectedResponse = new ListTransferRunsResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListTransferRunsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListTransferRunsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ListTransferRunsResponse response = await client.ListTransferRunsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListTransferLogs()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            ListTransferLogsRequest request = new ListTransferLogsRequest();
            ListTransferLogsResponse expectedResponse = new ListTransferLogsResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListTransferLogs(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ListTransferLogsResponse response = client.ListTransferLogs(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListTransferLogsAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            ListTransferLogsRequest request = new ListTransferLogsRequest();
            ListTransferLogsResponse expectedResponse = new ListTransferLogsResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListTransferLogsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListTransferLogsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            ListTransferLogsResponse response = await client.ListTransferLogsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CheckValidCreds()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            CheckValidCredsRequest request = new CheckValidCredsRequest();
            CheckValidCredsResponse expectedResponse = new CheckValidCredsResponse
            {
                HasValidCreds = false,
            };
            mockGrpcClient.Setup(x => x.CheckValidCreds(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            CheckValidCredsResponse response = client.CheckValidCreds(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CheckValidCredsAsync()
        {
            Mock<DataTransferService.DataTransferServiceClient> mockGrpcClient = new Mock<DataTransferService.DataTransferServiceClient>(MockBehavior.Strict);
            CheckValidCredsRequest request = new CheckValidCredsRequest();
            CheckValidCredsResponse expectedResponse = new CheckValidCredsResponse
            {
                HasValidCreds = false,
            };
            mockGrpcClient.Setup(x => x.CheckValidCredsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CheckValidCredsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DataTransferServiceClient client = new DataTransferServiceClientImpl(mockGrpcClient.Object, null);
            CheckValidCredsResponse response = await client.CheckValidCredsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
