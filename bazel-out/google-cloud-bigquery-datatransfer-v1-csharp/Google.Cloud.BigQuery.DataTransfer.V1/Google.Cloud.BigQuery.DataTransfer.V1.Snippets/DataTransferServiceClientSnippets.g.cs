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

namespace Google.Cloud.BigQuery.DataTransfer.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.BigQuery.DataTransfer.V1;
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
    public class GeneratedDataTransferServiceClientSnippets
    {
        /// <summary>Snippet for GetDataSourceAsync</summary>
        public async Task GetDataSourceAsync_RequestObject()
        {
            // Snippet: GetDataSourceAsync(GetDataSourceRequest,CallSettings)
            // Additional: GetDataSourceAsync(GetDataSourceRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataSourceRequest request = new GetDataSourceRequest();
            // Make the request
            DataSource response = await dataTransferServiceClient.GetDataSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataSource</summary>
        public void GetDataSource_RequestObject()
        {
            // Snippet: GetDataSource(GetDataSourceRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            GetDataSourceRequest request = new GetDataSourceRequest();
            // Make the request
            DataSource response = dataTransferServiceClient.GetDataSource(request);
            // End snippet
        }

        /// <summary>Snippet for ListDataSourcesAsync</summary>
        public async Task ListDataSourcesAsync_RequestObject()
        {
            // Snippet: ListDataSourcesAsync(ListDataSourcesRequest,CallSettings)
            // Additional: ListDataSourcesAsync(ListDataSourcesRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataSourcesRequest request = new ListDataSourcesRequest();
            // Make the request
            ListDataSourcesResponse response = await dataTransferServiceClient.ListDataSourcesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListDataSources</summary>
        public void ListDataSources_RequestObject()
        {
            // Snippet: ListDataSources(ListDataSourcesRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListDataSourcesRequest request = new ListDataSourcesRequest();
            // Make the request
            ListDataSourcesResponse response = dataTransferServiceClient.ListDataSources(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTransferConfigAsync</summary>
        public async Task CreateTransferConfigAsync_RequestObject()
        {
            // Snippet: CreateTransferConfigAsync(CreateTransferConfigRequest,CallSettings)
            // Additional: CreateTransferConfigAsync(CreateTransferConfigRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTransferConfigRequest request = new CreateTransferConfigRequest();
            // Make the request
            TransferConfig response = await dataTransferServiceClient.CreateTransferConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTransferConfig</summary>
        public void CreateTransferConfig_RequestObject()
        {
            // Snippet: CreateTransferConfig(CreateTransferConfigRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            CreateTransferConfigRequest request = new CreateTransferConfigRequest();
            // Make the request
            TransferConfig response = dataTransferServiceClient.CreateTransferConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransferConfigAsync</summary>
        public async Task UpdateTransferConfigAsync_RequestObject()
        {
            // Snippet: UpdateTransferConfigAsync(UpdateTransferConfigRequest,CallSettings)
            // Additional: UpdateTransferConfigAsync(UpdateTransferConfigRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTransferConfigRequest request = new UpdateTransferConfigRequest();
            // Make the request
            TransferConfig response = await dataTransferServiceClient.UpdateTransferConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransferConfig</summary>
        public void UpdateTransferConfig_RequestObject()
        {
            // Snippet: UpdateTransferConfig(UpdateTransferConfigRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            UpdateTransferConfigRequest request = new UpdateTransferConfigRequest();
            // Make the request
            TransferConfig response = dataTransferServiceClient.UpdateTransferConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferConfigAsync</summary>
        public async Task DeleteTransferConfigAsync_RequestObject()
        {
            // Snippet: DeleteTransferConfigAsync(DeleteTransferConfigRequest,CallSettings)
            // Additional: DeleteTransferConfigAsync(DeleteTransferConfigRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest();
            // Make the request
            await dataTransferServiceClient.DeleteTransferConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferConfig</summary>
        public void DeleteTransferConfig_RequestObject()
        {
            // Snippet: DeleteTransferConfig(DeleteTransferConfigRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            DeleteTransferConfigRequest request = new DeleteTransferConfigRequest();
            // Make the request
            dataTransferServiceClient.DeleteTransferConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferConfigAsync</summary>
        public async Task GetTransferConfigAsync_RequestObject()
        {
            // Snippet: GetTransferConfigAsync(GetTransferConfigRequest,CallSettings)
            // Additional: GetTransferConfigAsync(GetTransferConfigRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTransferConfigRequest request = new GetTransferConfigRequest();
            // Make the request
            TransferConfig response = await dataTransferServiceClient.GetTransferConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferConfig</summary>
        public void GetTransferConfig_RequestObject()
        {
            // Snippet: GetTransferConfig(GetTransferConfigRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            GetTransferConfigRequest request = new GetTransferConfigRequest();
            // Make the request
            TransferConfig response = dataTransferServiceClient.GetTransferConfig(request);
            // End snippet
        }

        /// <summary>Snippet for ListTransferConfigsAsync</summary>
        public async Task ListTransferConfigsAsync_RequestObject()
        {
            // Snippet: ListTransferConfigsAsync(ListTransferConfigsRequest,CallSettings)
            // Additional: ListTransferConfigsAsync(ListTransferConfigsRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTransferConfigsRequest request = new ListTransferConfigsRequest();
            // Make the request
            ListTransferConfigsResponse response = await dataTransferServiceClient.ListTransferConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListTransferConfigs</summary>
        public void ListTransferConfigs_RequestObject()
        {
            // Snippet: ListTransferConfigs(ListTransferConfigsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListTransferConfigsRequest request = new ListTransferConfigsRequest();
            // Make the request
            ListTransferConfigsResponse response = dataTransferServiceClient.ListTransferConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for ScheduleTransferRunsAsync</summary>
        public async Task ScheduleTransferRunsAsync_RequestObject()
        {
            // Snippet: ScheduleTransferRunsAsync(ScheduleTransferRunsRequest,CallSettings)
            // Additional: ScheduleTransferRunsAsync(ScheduleTransferRunsRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest();
            // Make the request
            ScheduleTransferRunsResponse response = await dataTransferServiceClient.ScheduleTransferRunsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ScheduleTransferRuns</summary>
        public void ScheduleTransferRuns_RequestObject()
        {
            // Snippet: ScheduleTransferRuns(ScheduleTransferRunsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ScheduleTransferRunsRequest request = new ScheduleTransferRunsRequest();
            // Make the request
            ScheduleTransferRunsResponse response = dataTransferServiceClient.ScheduleTransferRuns(request);
            // End snippet
        }

        /// <summary>Snippet for StartManualTransferRunsAsync</summary>
        public async Task StartManualTransferRunsAsync_RequestObject()
        {
            // Snippet: StartManualTransferRunsAsync(StartManualTransferRunsRequest,CallSettings)
            // Additional: StartManualTransferRunsAsync(StartManualTransferRunsRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartManualTransferRunsRequest request = new StartManualTransferRunsRequest();
            // Make the request
            StartManualTransferRunsResponse response = await dataTransferServiceClient.StartManualTransferRunsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartManualTransferRuns</summary>
        public void StartManualTransferRuns_RequestObject()
        {
            // Snippet: StartManualTransferRuns(StartManualTransferRunsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            StartManualTransferRunsRequest request = new StartManualTransferRunsRequest();
            // Make the request
            StartManualTransferRunsResponse response = dataTransferServiceClient.StartManualTransferRuns(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferRunAsync</summary>
        public async Task GetTransferRunAsync_RequestObject()
        {
            // Snippet: GetTransferRunAsync(GetTransferRunRequest,CallSettings)
            // Additional: GetTransferRunAsync(GetTransferRunRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTransferRunRequest request = new GetTransferRunRequest();
            // Make the request
            TransferRun response = await dataTransferServiceClient.GetTransferRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferRun</summary>
        public void GetTransferRun_RequestObject()
        {
            // Snippet: GetTransferRun(GetTransferRunRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            GetTransferRunRequest request = new GetTransferRunRequest();
            // Make the request
            TransferRun response = dataTransferServiceClient.GetTransferRun(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferRunAsync</summary>
        public async Task DeleteTransferRunAsync_RequestObject()
        {
            // Snippet: DeleteTransferRunAsync(DeleteTransferRunRequest,CallSettings)
            // Additional: DeleteTransferRunAsync(DeleteTransferRunRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTransferRunRequest request = new DeleteTransferRunRequest();
            // Make the request
            await dataTransferServiceClient.DeleteTransferRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferRun</summary>
        public void DeleteTransferRun_RequestObject()
        {
            // Snippet: DeleteTransferRun(DeleteTransferRunRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            DeleteTransferRunRequest request = new DeleteTransferRunRequest();
            // Make the request
            dataTransferServiceClient.DeleteTransferRun(request);
            // End snippet
        }

        /// <summary>Snippet for ListTransferRunsAsync</summary>
        public async Task ListTransferRunsAsync_RequestObject()
        {
            // Snippet: ListTransferRunsAsync(ListTransferRunsRequest,CallSettings)
            // Additional: ListTransferRunsAsync(ListTransferRunsRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTransferRunsRequest request = new ListTransferRunsRequest();
            // Make the request
            ListTransferRunsResponse response = await dataTransferServiceClient.ListTransferRunsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListTransferRuns</summary>
        public void ListTransferRuns_RequestObject()
        {
            // Snippet: ListTransferRuns(ListTransferRunsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListTransferRunsRequest request = new ListTransferRunsRequest();
            // Make the request
            ListTransferRunsResponse response = dataTransferServiceClient.ListTransferRuns(request);
            // End snippet
        }

        /// <summary>Snippet for ListTransferLogsAsync</summary>
        public async Task ListTransferLogsAsync_RequestObject()
        {
            // Snippet: ListTransferLogsAsync(ListTransferLogsRequest,CallSettings)
            // Additional: ListTransferLogsAsync(ListTransferLogsRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTransferLogsRequest request = new ListTransferLogsRequest();
            // Make the request
            ListTransferLogsResponse response = await dataTransferServiceClient.ListTransferLogsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListTransferLogs</summary>
        public void ListTransferLogs_RequestObject()
        {
            // Snippet: ListTransferLogs(ListTransferLogsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListTransferLogsRequest request = new ListTransferLogsRequest();
            // Make the request
            ListTransferLogsResponse response = dataTransferServiceClient.ListTransferLogs(request);
            // End snippet
        }

        /// <summary>Snippet for CheckValidCredsAsync</summary>
        public async Task CheckValidCredsAsync_RequestObject()
        {
            // Snippet: CheckValidCredsAsync(CheckValidCredsRequest,CallSettings)
            // Additional: CheckValidCredsAsync(CheckValidCredsRequest,CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            CheckValidCredsRequest request = new CheckValidCredsRequest();
            // Make the request
            CheckValidCredsResponse response = await dataTransferServiceClient.CheckValidCredsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CheckValidCreds</summary>
        public void CheckValidCreds_RequestObject()
        {
            // Snippet: CheckValidCreds(CheckValidCredsRequest,CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            CheckValidCredsRequest request = new CheckValidCredsRequest();
            // Make the request
            CheckValidCredsResponse response = dataTransferServiceClient.CheckValidCreds(request);
            // End snippet
        }

    }
}
