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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.BigQuery.DataTransfer.V1
{
    /// <summary>
    /// Settings for a <see cref="DataTransferServiceClient"/>.
    /// </summary>
    public sealed partial class DataTransferServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="DataTransferServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="DataTransferServiceSettings"/>.
        /// </returns>
        public static DataTransferServiceSettings GetDefault() => new DataTransferServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DataTransferServiceSettings"/> object with default settings.
        /// </summary>
        public DataTransferServiceSettings() { }

        private DataTransferServiceSettings(DataTransferServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDataSourceSettings = existing.GetDataSourceSettings;
            ListDataSourcesSettings = existing.ListDataSourcesSettings;
            CreateTransferConfigSettings = existing.CreateTransferConfigSettings;
            UpdateTransferConfigSettings = existing.UpdateTransferConfigSettings;
            DeleteTransferConfigSettings = existing.DeleteTransferConfigSettings;
            GetTransferConfigSettings = existing.GetTransferConfigSettings;
            ListTransferConfigsSettings = existing.ListTransferConfigsSettings;
            ScheduleTransferRunsSettings = existing.ScheduleTransferRunsSettings;
            StartManualTransferRunsSettings = existing.StartManualTransferRunsSettings;
            GetTransferRunSettings = existing.GetTransferRunSettings;
            DeleteTransferRunSettings = existing.DeleteTransferRunSettings;
            ListTransferRunsSettings = existing.ListTransferRunsSettings;
            ListTransferLogsSettings = existing.ListTransferLogsSettings;
            CheckValidCredsSettings = existing.CheckValidCredsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataTransferServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="DataTransferServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="DataTransferServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="DataTransferServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="DataTransferServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="DataTransferServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="DataTransferServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="DataTransferServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="DataTransferServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.GetDataSource</c> and <c>DataTransferServiceClient.GetDataSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.GetDataSource</c> and
        /// <c>DataTransferServiceClient.GetDataSourceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetDataSourceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListDataSources</c> and <c>DataTransferServiceClient.ListDataSourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.ListDataSources</c> and
        /// <c>DataTransferServiceClient.ListDataSourcesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListDataSourcesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.CreateTransferConfig</c> and <c>DataTransferServiceClient.CreateTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.CreateTransferConfig</c> and
        /// <c>DataTransferServiceClient.CreateTransferConfigAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateTransferConfigSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.UpdateTransferConfig</c> and <c>DataTransferServiceClient.UpdateTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.UpdateTransferConfig</c> and
        /// <c>DataTransferServiceClient.UpdateTransferConfigAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTransferConfigSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.DeleteTransferConfig</c> and <c>DataTransferServiceClient.DeleteTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.DeleteTransferConfig</c> and
        /// <c>DataTransferServiceClient.DeleteTransferConfigAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTransferConfigSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.GetTransferConfig</c> and <c>DataTransferServiceClient.GetTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.GetTransferConfig</c> and
        /// <c>DataTransferServiceClient.GetTransferConfigAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetTransferConfigSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListTransferConfigs</c> and <c>DataTransferServiceClient.ListTransferConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.ListTransferConfigs</c> and
        /// <c>DataTransferServiceClient.ListTransferConfigsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListTransferConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ScheduleTransferRuns</c> and <c>DataTransferServiceClient.ScheduleTransferRunsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.ScheduleTransferRuns</c> and
        /// <c>DataTransferServiceClient.ScheduleTransferRunsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ScheduleTransferRunsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.StartManualTransferRuns</c> and <c>DataTransferServiceClient.StartManualTransferRunsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.StartManualTransferRuns</c> and
        /// <c>DataTransferServiceClient.StartManualTransferRunsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings StartManualTransferRunsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.GetTransferRun</c> and <c>DataTransferServiceClient.GetTransferRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.GetTransferRun</c> and
        /// <c>DataTransferServiceClient.GetTransferRunAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetTransferRunSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.DeleteTransferRun</c> and <c>DataTransferServiceClient.DeleteTransferRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.DeleteTransferRun</c> and
        /// <c>DataTransferServiceClient.DeleteTransferRunAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTransferRunSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListTransferRuns</c> and <c>DataTransferServiceClient.ListTransferRunsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.ListTransferRuns</c> and
        /// <c>DataTransferServiceClient.ListTransferRunsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListTransferRunsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListTransferLogs</c> and <c>DataTransferServiceClient.ListTransferLogsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.ListTransferLogs</c> and
        /// <c>DataTransferServiceClient.ListTransferLogsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListTransferLogsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.CheckValidCreds</c> and <c>DataTransferServiceClient.CheckValidCredsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataTransferServiceClient.CheckValidCreds</c> and
        /// <c>DataTransferServiceClient.CheckValidCredsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CheckValidCredsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="DataTransferServiceSettings"/> object.</returns>
        public DataTransferServiceSettings Clone() => new DataTransferServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataTransferServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DataTransferServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataTransferServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public DataTransferServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override DataTransferServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataTransferServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<DataTransferServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataTransferServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => DataTransferServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DataTransferServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataTransferServiceClient.ChannelPool;
    }

    /// <summary>
    /// DataTransferService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class DataTransferServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataTransferService service, which is a host of "bigquerydatatransfer.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("bigquerydatatransfer.googleapis.com", 443);

        /// <summary>
        /// The default DataTransferService scopes.
        /// </summary>
        /// <remarks>
        /// The default DataTransferService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="DataTransferServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.BigQuery.DataTransfer.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// DataTransferServiceClient client = await DataTransferServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.BigQuery.DataTransfer.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     DataTransferServiceClient.DefaultEndpoint.Host, DataTransferServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// DataTransferServiceClient client = DataTransferServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DataTransferServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="DataTransferServiceClient"/>.</returns>
        public static async stt::Task<DataTransferServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, DataTransferServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="DataTransferServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.BigQuery.DataTransfer.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// DataTransferServiceClient client = DataTransferServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.BigQuery.DataTransfer.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     DataTransferServiceClient.DefaultEndpoint.Host, DataTransferServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// DataTransferServiceClient client = DataTransferServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DataTransferServiceSettings"/>.</param>
        /// <returns>The created <see cref="DataTransferServiceClient"/>.</returns>
        public static DataTransferServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, DataTransferServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="DataTransferServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DataTransferServiceSettings"/>.</param>
        /// <returns>The created <see cref="DataTransferServiceClient"/>.</returns>
        public static DataTransferServiceClient Create(grpccore::Channel channel, DataTransferServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="DataTransferServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DataTransferServiceSettings"/>.</param>
        /// <returns>The created <see cref="DataTransferServiceClient"/>.</returns>
        public static DataTransferServiceClient Create(grpccore::CallInvoker callInvoker, DataTransferServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataTransferService.DataTransferServiceClient grpcClient = new DataTransferService.DataTransferServiceClient(callInvoker);
            return new DataTransferServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, DataTransferServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, DataTransferServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, DataTransferServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, DataTransferServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC DataTransferService client.
        /// </summary>
        public virtual DataTransferService.DataTransferServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Retrieves a supported data source and returns its settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(
            GetDataSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves a supported data source and returns its settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(
            GetDataSourceRequest request,
            st::CancellationToken cancellationToken) => GetDataSourceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a supported data source and returns its settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DataSource GetDataSource(
            GetDataSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists supported data sources and returns their settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListDataSourcesResponse> ListDataSourcesAsync(
            ListDataSourcesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists supported data sources and returns their settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListDataSourcesResponse> ListDataSourcesAsync(
            ListDataSourcesRequest request,
            st::CancellationToken cancellationToken) => ListDataSourcesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists supported data sources and returns their settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListDataSourcesResponse ListDataSources(
            ListDataSourcesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<TransferConfig> CreateTransferConfigAsync(
            CreateTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<TransferConfig> CreateTransferConfigAsync(
            CreateTransferConfigRequest request,
            st::CancellationToken cancellationToken) => CreateTransferConfigAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual TransferConfig CreateTransferConfig(
            CreateTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<TransferConfig> UpdateTransferConfigAsync(
            UpdateTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<TransferConfig> UpdateTransferConfigAsync(
            UpdateTransferConfigRequest request,
            st::CancellationToken cancellationToken) => UpdateTransferConfigAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual TransferConfig UpdateTransferConfig(
            UpdateTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a data transfer configuration,
        /// including any associated transfer runs and logs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTransferConfigAsync(
            DeleteTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a data transfer configuration,
        /// including any associated transfer runs and logs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTransferConfigAsync(
            DeleteTransferConfigRequest request,
            st::CancellationToken cancellationToken) => DeleteTransferConfigAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data transfer configuration,
        /// including any associated transfer runs and logs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteTransferConfig(
            DeleteTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<TransferConfig> GetTransferConfigAsync(
            GetTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<TransferConfig> GetTransferConfigAsync(
            GetTransferConfigRequest request,
            st::CancellationToken cancellationToken) => GetTransferConfigAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual TransferConfig GetTransferConfig(
            GetTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns information about all data transfers in the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListTransferConfigsResponse> ListTransferConfigsAsync(
            ListTransferConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns information about all data transfers in the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListTransferConfigsResponse> ListTransferConfigsAsync(
            ListTransferConfigsRequest request,
            st::CancellationToken cancellationToken) => ListTransferConfigsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about all data transfers in the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListTransferConfigsResponse ListTransferConfigs(
            ListTransferConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ScheduleTransferRunsResponse> ScheduleTransferRunsAsync(
            ScheduleTransferRunsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ScheduleTransferRunsResponse> ScheduleTransferRunsAsync(
            ScheduleTransferRunsRequest request,
            st::CancellationToken cancellationToken) => ScheduleTransferRunsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ScheduleTransferRunsResponse ScheduleTransferRuns(
            ScheduleTransferRunsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Start manual transfer runs to be executed now with schedule_time equal to
        /// current time. The transfer runs can be created for a time range where the
        /// run_time is between start_time (inclusive) and end_time (exclusive), or for
        /// a specific run_time.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<StartManualTransferRunsResponse> StartManualTransferRunsAsync(
            StartManualTransferRunsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Start manual transfer runs to be executed now with schedule_time equal to
        /// current time. The transfer runs can be created for a time range where the
        /// run_time is between start_time (inclusive) and end_time (exclusive), or for
        /// a specific run_time.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<StartManualTransferRunsResponse> StartManualTransferRunsAsync(
            StartManualTransferRunsRequest request,
            st::CancellationToken cancellationToken) => StartManualTransferRunsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Start manual transfer runs to be executed now with schedule_time equal to
        /// current time. The transfer runs can be created for a time range where the
        /// run_time is between start_time (inclusive) and end_time (exclusive), or for
        /// a specific run_time.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual StartManualTransferRunsResponse StartManualTransferRuns(
            StartManualTransferRunsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<TransferRun> GetTransferRunAsync(
            GetTransferRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<TransferRun> GetTransferRunAsync(
            GetTransferRunRequest request,
            st::CancellationToken cancellationToken) => GetTransferRunAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual TransferRun GetTransferRun(
            GetTransferRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTransferRunAsync(
            DeleteTransferRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTransferRunAsync(
            DeleteTransferRunRequest request,
            st::CancellationToken cancellationToken) => DeleteTransferRunAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteTransferRun(
            DeleteTransferRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns information about running and completed jobs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListTransferRunsResponse> ListTransferRunsAsync(
            ListTransferRunsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns information about running and completed jobs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListTransferRunsResponse> ListTransferRunsAsync(
            ListTransferRunsRequest request,
            st::CancellationToken cancellationToken) => ListTransferRunsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about running and completed jobs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListTransferRunsResponse ListTransferRuns(
            ListTransferRunsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns user facing log messages for the data transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListTransferLogsResponse> ListTransferLogsAsync(
            ListTransferLogsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns user facing log messages for the data transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListTransferLogsResponse> ListTransferLogsAsync(
            ListTransferLogsRequest request,
            st::CancellationToken cancellationToken) => ListTransferLogsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns user facing log messages for the data transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListTransferLogsResponse ListTransferLogs(
            ListTransferLogsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// Some data sources doesn't support service account, so we need to talk to
        /// them on behalf of the end user. This API just checks whether we have OAuth
        /// token for the particular user, which is a pre-requisite before user can
        /// create a transfer config.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CheckValidCredsResponse> CheckValidCredsAsync(
            CheckValidCredsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// Some data sources doesn't support service account, so we need to talk to
        /// them on behalf of the end user. This API just checks whether we have OAuth
        /// token for the particular user, which is a pre-requisite before user can
        /// create a transfer config.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CheckValidCredsResponse> CheckValidCredsAsync(
            CheckValidCredsRequest request,
            st::CancellationToken cancellationToken) => CheckValidCredsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// Some data sources doesn't support service account, so we need to talk to
        /// them on behalf of the end user. This API just checks whether we have OAuth
        /// token for the particular user, which is a pre-requisite before user can
        /// create a transfer config.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CheckValidCredsResponse CheckValidCreds(
            CheckValidCredsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// DataTransferService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class DataTransferServiceClientImpl : DataTransferServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDataSourceRequest, DataSource> _callGetDataSource;
        private readonly gaxgrpc::ApiCall<ListDataSourcesRequest, ListDataSourcesResponse> _callListDataSources;
        private readonly gaxgrpc::ApiCall<CreateTransferConfigRequest, TransferConfig> _callCreateTransferConfig;
        private readonly gaxgrpc::ApiCall<UpdateTransferConfigRequest, TransferConfig> _callUpdateTransferConfig;
        private readonly gaxgrpc::ApiCall<DeleteTransferConfigRequest, pbwkt::Empty> _callDeleteTransferConfig;
        private readonly gaxgrpc::ApiCall<GetTransferConfigRequest, TransferConfig> _callGetTransferConfig;
        private readonly gaxgrpc::ApiCall<ListTransferConfigsRequest, ListTransferConfigsResponse> _callListTransferConfigs;
        private readonly gaxgrpc::ApiCall<ScheduleTransferRunsRequest, ScheduleTransferRunsResponse> _callScheduleTransferRuns;
        private readonly gaxgrpc::ApiCall<StartManualTransferRunsRequest, StartManualTransferRunsResponse> _callStartManualTransferRuns;
        private readonly gaxgrpc::ApiCall<GetTransferRunRequest, TransferRun> _callGetTransferRun;
        private readonly gaxgrpc::ApiCall<DeleteTransferRunRequest, pbwkt::Empty> _callDeleteTransferRun;
        private readonly gaxgrpc::ApiCall<ListTransferRunsRequest, ListTransferRunsResponse> _callListTransferRuns;
        private readonly gaxgrpc::ApiCall<ListTransferLogsRequest, ListTransferLogsResponse> _callListTransferLogs;
        private readonly gaxgrpc::ApiCall<CheckValidCredsRequest, CheckValidCredsResponse> _callCheckValidCreds;

        /// <summary>
        /// Constructs a client wrapper for the DataTransferService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataTransferServiceSettings"/> used within this client </param>
        public DataTransferServiceClientImpl(DataTransferService.DataTransferServiceClient grpcClient, DataTransferServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DataTransferServiceSettings effectiveSettings = settings ?? DataTransferServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetDataSource = clientHelper.BuildApiCall<GetDataSourceRequest, DataSource>(
                GrpcClient.GetDataSourceAsync, GrpcClient.GetDataSource, effectiveSettings.GetDataSourceSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListDataSources = clientHelper.BuildApiCall<ListDataSourcesRequest, ListDataSourcesResponse>(
                GrpcClient.ListDataSourcesAsync, GrpcClient.ListDataSources, effectiveSettings.ListDataSourcesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callCreateTransferConfig = clientHelper.BuildApiCall<CreateTransferConfigRequest, TransferConfig>(
                GrpcClient.CreateTransferConfigAsync, GrpcClient.CreateTransferConfig, effectiveSettings.CreateTransferConfigSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateTransferConfig = clientHelper.BuildApiCall<UpdateTransferConfigRequest, TransferConfig>(
                GrpcClient.UpdateTransferConfigAsync, GrpcClient.UpdateTransferConfig, effectiveSettings.UpdateTransferConfigSettings)
                .WithGoogleRequestParam("transfer_config.name", request => request.TransferConfig?.Name);
            _callDeleteTransferConfig = clientHelper.BuildApiCall<DeleteTransferConfigRequest, pbwkt::Empty>(
                GrpcClient.DeleteTransferConfigAsync, GrpcClient.DeleteTransferConfig, effectiveSettings.DeleteTransferConfigSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetTransferConfig = clientHelper.BuildApiCall<GetTransferConfigRequest, TransferConfig>(
                GrpcClient.GetTransferConfigAsync, GrpcClient.GetTransferConfig, effectiveSettings.GetTransferConfigSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListTransferConfigs = clientHelper.BuildApiCall<ListTransferConfigsRequest, ListTransferConfigsResponse>(
                GrpcClient.ListTransferConfigsAsync, GrpcClient.ListTransferConfigs, effectiveSettings.ListTransferConfigsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callScheduleTransferRuns = clientHelper.BuildApiCall<ScheduleTransferRunsRequest, ScheduleTransferRunsResponse>(
                GrpcClient.ScheduleTransferRunsAsync, GrpcClient.ScheduleTransferRuns, effectiveSettings.ScheduleTransferRunsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callStartManualTransferRuns = clientHelper.BuildApiCall<StartManualTransferRunsRequest, StartManualTransferRunsResponse>(
                GrpcClient.StartManualTransferRunsAsync, GrpcClient.StartManualTransferRuns, effectiveSettings.StartManualTransferRunsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetTransferRun = clientHelper.BuildApiCall<GetTransferRunRequest, TransferRun>(
                GrpcClient.GetTransferRunAsync, GrpcClient.GetTransferRun, effectiveSettings.GetTransferRunSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callDeleteTransferRun = clientHelper.BuildApiCall<DeleteTransferRunRequest, pbwkt::Empty>(
                GrpcClient.DeleteTransferRunAsync, GrpcClient.DeleteTransferRun, effectiveSettings.DeleteTransferRunSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListTransferRuns = clientHelper.BuildApiCall<ListTransferRunsRequest, ListTransferRunsResponse>(
                GrpcClient.ListTransferRunsAsync, GrpcClient.ListTransferRuns, effectiveSettings.ListTransferRunsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callListTransferLogs = clientHelper.BuildApiCall<ListTransferLogsRequest, ListTransferLogsResponse>(
                GrpcClient.ListTransferLogsAsync, GrpcClient.ListTransferLogs, effectiveSettings.ListTransferLogsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callCheckValidCreds = clientHelper.BuildApiCall<CheckValidCredsRequest, CheckValidCredsResponse>(
                GrpcClient.CheckValidCredsAsync, GrpcClient.CheckValidCreds, effectiveSettings.CheckValidCredsSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataSource);
            Modify_GetDataSourceApiCall(ref _callGetDataSource);
            Modify_ApiCall(ref _callListDataSources);
            Modify_ListDataSourcesApiCall(ref _callListDataSources);
            Modify_ApiCall(ref _callCreateTransferConfig);
            Modify_CreateTransferConfigApiCall(ref _callCreateTransferConfig);
            Modify_ApiCall(ref _callUpdateTransferConfig);
            Modify_UpdateTransferConfigApiCall(ref _callUpdateTransferConfig);
            Modify_ApiCall(ref _callDeleteTransferConfig);
            Modify_DeleteTransferConfigApiCall(ref _callDeleteTransferConfig);
            Modify_ApiCall(ref _callGetTransferConfig);
            Modify_GetTransferConfigApiCall(ref _callGetTransferConfig);
            Modify_ApiCall(ref _callListTransferConfigs);
            Modify_ListTransferConfigsApiCall(ref _callListTransferConfigs);
            Modify_ApiCall(ref _callScheduleTransferRuns);
            Modify_ScheduleTransferRunsApiCall(ref _callScheduleTransferRuns);
            Modify_ApiCall(ref _callStartManualTransferRuns);
            Modify_StartManualTransferRunsApiCall(ref _callStartManualTransferRuns);
            Modify_ApiCall(ref _callGetTransferRun);
            Modify_GetTransferRunApiCall(ref _callGetTransferRun);
            Modify_ApiCall(ref _callDeleteTransferRun);
            Modify_DeleteTransferRunApiCall(ref _callDeleteTransferRun);
            Modify_ApiCall(ref _callListTransferRuns);
            Modify_ListTransferRunsApiCall(ref _callListTransferRuns);
            Modify_ApiCall(ref _callListTransferLogs);
            Modify_ListTransferLogsApiCall(ref _callListTransferLogs);
            Modify_ApiCall(ref _callCheckValidCreds);
            Modify_CheckValidCredsApiCall(ref _callCheckValidCreds);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_GetDataSourceApiCall(ref gaxgrpc::ApiCall<GetDataSourceRequest, DataSource> call);
        partial void Modify_ListDataSourcesApiCall(ref gaxgrpc::ApiCall<ListDataSourcesRequest, ListDataSourcesResponse> call);
        partial void Modify_CreateTransferConfigApiCall(ref gaxgrpc::ApiCall<CreateTransferConfigRequest, TransferConfig> call);
        partial void Modify_UpdateTransferConfigApiCall(ref gaxgrpc::ApiCall<UpdateTransferConfigRequest, TransferConfig> call);
        partial void Modify_DeleteTransferConfigApiCall(ref gaxgrpc::ApiCall<DeleteTransferConfigRequest, pbwkt::Empty> call);
        partial void Modify_GetTransferConfigApiCall(ref gaxgrpc::ApiCall<GetTransferConfigRequest, TransferConfig> call);
        partial void Modify_ListTransferConfigsApiCall(ref gaxgrpc::ApiCall<ListTransferConfigsRequest, ListTransferConfigsResponse> call);
        partial void Modify_ScheduleTransferRunsApiCall(ref gaxgrpc::ApiCall<ScheduleTransferRunsRequest, ScheduleTransferRunsResponse> call);
        partial void Modify_StartManualTransferRunsApiCall(ref gaxgrpc::ApiCall<StartManualTransferRunsRequest, StartManualTransferRunsResponse> call);
        partial void Modify_GetTransferRunApiCall(ref gaxgrpc::ApiCall<GetTransferRunRequest, TransferRun> call);
        partial void Modify_DeleteTransferRunApiCall(ref gaxgrpc::ApiCall<DeleteTransferRunRequest, pbwkt::Empty> call);
        partial void Modify_ListTransferRunsApiCall(ref gaxgrpc::ApiCall<ListTransferRunsRequest, ListTransferRunsResponse> call);
        partial void Modify_ListTransferLogsApiCall(ref gaxgrpc::ApiCall<ListTransferLogsRequest, ListTransferLogsResponse> call);
        partial void Modify_CheckValidCredsApiCall(ref gaxgrpc::ApiCall<CheckValidCredsRequest, CheckValidCredsResponse> call);
        partial void OnConstruction(DataTransferService.DataTransferServiceClient grpcClient, DataTransferServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC DataTransferService client.
        /// </summary>
        public override DataTransferService.DataTransferServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetDataSourceRequest(ref GetDataSourceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListDataSourcesRequest(ref ListDataSourcesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateTransferConfigRequest(ref CreateTransferConfigRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateTransferConfigRequest(ref UpdateTransferConfigRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteTransferConfigRequest(ref DeleteTransferConfigRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetTransferConfigRequest(ref GetTransferConfigRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListTransferConfigsRequest(ref ListTransferConfigsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ScheduleTransferRunsRequest(ref ScheduleTransferRunsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_StartManualTransferRunsRequest(ref StartManualTransferRunsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetTransferRunRequest(ref GetTransferRunRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteTransferRunRequest(ref DeleteTransferRunRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListTransferRunsRequest(ref ListTransferRunsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListTransferLogsRequest(ref ListTransferLogsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CheckValidCredsRequest(ref CheckValidCredsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a supported data source and returns its settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<DataSource> GetDataSourceAsync(
            GetDataSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataSourceRequest(ref request, ref callSettings);
            return _callGetDataSource.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a supported data source and returns its settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override DataSource GetDataSource(
            GetDataSourceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataSourceRequest(ref request, ref callSettings);
            return _callGetDataSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists supported data sources and returns their settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ListDataSourcesResponse> ListDataSourcesAsync(
            ListDataSourcesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataSourcesRequest(ref request, ref callSettings);
            return _callListDataSources.Async(request, callSettings);
        }

        /// <summary>
        /// Lists supported data sources and returns their settings,
        /// which can be used for UI rendering.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ListDataSourcesResponse ListDataSources(
            ListDataSourcesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataSourcesRequest(ref request, ref callSettings);
            return _callListDataSources.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<TransferConfig> CreateTransferConfigAsync(
            CreateTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTransferConfigRequest(ref request, ref callSettings);
            return _callCreateTransferConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new data transfer configuration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override TransferConfig CreateTransferConfig(
            CreateTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTransferConfigRequest(ref request, ref callSettings);
            return _callCreateTransferConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<TransferConfig> UpdateTransferConfigAsync(
            UpdateTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTransferConfigRequest(ref request, ref callSettings);
            return _callUpdateTransferConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a data transfer configuration.
        /// All fields must be set, even if they are not updated.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override TransferConfig UpdateTransferConfig(
            UpdateTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTransferConfigRequest(ref request, ref callSettings);
            return _callUpdateTransferConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a data transfer configuration,
        /// including any associated transfer runs and logs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteTransferConfigAsync(
            DeleteTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTransferConfigRequest(ref request, ref callSettings);
            return _callDeleteTransferConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a data transfer configuration,
        /// including any associated transfer runs and logs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteTransferConfig(
            DeleteTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTransferConfigRequest(ref request, ref callSettings);
            _callDeleteTransferConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<TransferConfig> GetTransferConfigAsync(
            GetTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTransferConfigRequest(ref request, ref callSettings);
            return _callGetTransferConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Returns information about a data transfer config.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override TransferConfig GetTransferConfig(
            GetTransferConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTransferConfigRequest(ref request, ref callSettings);
            return _callGetTransferConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about all data transfers in the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ListTransferConfigsResponse> ListTransferConfigsAsync(
            ListTransferConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferConfigsRequest(ref request, ref callSettings);
            return _callListTransferConfigs.Async(request, callSettings);
        }

        /// <summary>
        /// Returns information about all data transfers in the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ListTransferConfigsResponse ListTransferConfigs(
            ListTransferConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferConfigsRequest(ref request, ref callSettings);
            return _callListTransferConfigs.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ScheduleTransferRunsResponse> ScheduleTransferRunsAsync(
            ScheduleTransferRunsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ScheduleTransferRunsRequest(ref request, ref callSettings);
            return _callScheduleTransferRuns.Async(request, callSettings);
        }

        /// <summary>
        /// Creates transfer runs for a time range [start_time, end_time].
        /// For each date - or whatever granularity the data source supports - in the
        /// range, one transfer run is created.
        /// Note that runs are created per UTC time in the time range.
        /// DEPRECATED: use StartManualTransferRuns instead.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ScheduleTransferRunsResponse ScheduleTransferRuns(
            ScheduleTransferRunsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ScheduleTransferRunsRequest(ref request, ref callSettings);
            return _callScheduleTransferRuns.Sync(request, callSettings);
        }

        /// <summary>
        /// Start manual transfer runs to be executed now with schedule_time equal to
        /// current time. The transfer runs can be created for a time range where the
        /// run_time is between start_time (inclusive) and end_time (exclusive), or for
        /// a specific run_time.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<StartManualTransferRunsResponse> StartManualTransferRunsAsync(
            StartManualTransferRunsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartManualTransferRunsRequest(ref request, ref callSettings);
            return _callStartManualTransferRuns.Async(request, callSettings);
        }

        /// <summary>
        /// Start manual transfer runs to be executed now with schedule_time equal to
        /// current time. The transfer runs can be created for a time range where the
        /// run_time is between start_time (inclusive) and end_time (exclusive), or for
        /// a specific run_time.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override StartManualTransferRunsResponse StartManualTransferRuns(
            StartManualTransferRunsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartManualTransferRunsRequest(ref request, ref callSettings);
            return _callStartManualTransferRuns.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<TransferRun> GetTransferRunAsync(
            GetTransferRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTransferRunRequest(ref request, ref callSettings);
            return _callGetTransferRun.Async(request, callSettings);
        }

        /// <summary>
        /// Returns information about the particular transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override TransferRun GetTransferRun(
            GetTransferRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTransferRunRequest(ref request, ref callSettings);
            return _callGetTransferRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteTransferRunAsync(
            DeleteTransferRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTransferRunRequest(ref request, ref callSettings);
            return _callDeleteTransferRun.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteTransferRun(
            DeleteTransferRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTransferRunRequest(ref request, ref callSettings);
            _callDeleteTransferRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about running and completed jobs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ListTransferRunsResponse> ListTransferRunsAsync(
            ListTransferRunsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferRunsRequest(ref request, ref callSettings);
            return _callListTransferRuns.Async(request, callSettings);
        }

        /// <summary>
        /// Returns information about running and completed jobs.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ListTransferRunsResponse ListTransferRuns(
            ListTransferRunsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferRunsRequest(ref request, ref callSettings);
            return _callListTransferRuns.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns user facing log messages for the data transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ListTransferLogsResponse> ListTransferLogsAsync(
            ListTransferLogsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferLogsRequest(ref request, ref callSettings);
            return _callListTransferLogs.Async(request, callSettings);
        }

        /// <summary>
        /// Returns user facing log messages for the data transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ListTransferLogsResponse ListTransferLogs(
            ListTransferLogsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferLogsRequest(ref request, ref callSettings);
            return _callListTransferLogs.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// Some data sources doesn't support service account, so we need to talk to
        /// them on behalf of the end user. This API just checks whether we have OAuth
        /// token for the particular user, which is a pre-requisite before user can
        /// create a transfer config.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<CheckValidCredsResponse> CheckValidCredsAsync(
            CheckValidCredsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckValidCredsRequest(ref request, ref callSettings);
            return _callCheckValidCreds.Async(request, callSettings);
        }

        /// <summary>
        /// Returns true if valid credentials exist for the given data source and
        /// requesting user.
        /// Some data sources doesn't support service account, so we need to talk to
        /// them on behalf of the end user. This API just checks whether we have OAuth
        /// token for the particular user, which is a pre-requisite before user can
        /// create a transfer config.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override CheckValidCredsResponse CheckValidCreds(
            CheckValidCredsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckValidCredsRequest(ref request, ref callSettings);
            return _callCheckValidCreds.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
