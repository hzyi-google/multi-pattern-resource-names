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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using iam = Google.Cloud.Iam.V1;
using gdcv = Google.Devtools.Containeranalysis.V1Beta1;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Devtools.Containeranalysis.V1beta1
{
    /// <summary>
    /// Settings for a <see cref="ContainerAnalysisV1Beta1Client"/>.
    /// </summary>
    public sealed partial class ContainerAnalysisV1Beta1Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ContainerAnalysisV1Beta1Settings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ContainerAnalysisV1Beta1Settings"/>.
        /// </returns>
        public static ContainerAnalysisV1Beta1Settings GetDefault() => new ContainerAnalysisV1Beta1Settings();

        /// <summary>
        /// Constructs a new <see cref="ContainerAnalysisV1Beta1Settings"/> object with default settings.
        /// </summary>
        public ContainerAnalysisV1Beta1Settings() { }

        private ContainerAnalysisV1Beta1Settings(ContainerAnalysisV1Beta1Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            GetScanConfigSettings = existing.GetScanConfigSettings;
            ListScanConfigsSettings = existing.ListScanConfigsSettings;
            UpdateScanConfigSettings = existing.UpdateScanConfigSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ContainerAnalysisV1Beta1Settings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ContainerAnalysisV1Beta1Client"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ContainerAnalysisV1Beta1Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ContainerAnalysisV1Beta1Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ContainerAnalysisV1Beta1Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ContainerAnalysisV1Beta1Client"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ContainerAnalysisV1Beta1Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ContainerAnalysisV1Beta1Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ContainerAnalysisV1Beta1Client"/> RPC methods is defined as:
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
        /// <c>ContainerAnalysisV1Beta1Client.SetIamPolicy</c> and <c>ContainerAnalysisV1Beta1Client.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisV1Beta1Client.SetIamPolicy</c> and
        /// <c>ContainerAnalysisV1Beta1Client.SetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisV1Beta1Client.GetIamPolicy</c> and <c>ContainerAnalysisV1Beta1Client.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisV1Beta1Client.GetIamPolicy</c> and
        /// <c>ContainerAnalysisV1Beta1Client.GetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisV1Beta1Client.TestIamPermissions</c> and <c>ContainerAnalysisV1Beta1Client.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisV1Beta1Client.TestIamPermissions</c> and
        /// <c>ContainerAnalysisV1Beta1Client.TestIamPermissionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisV1Beta1Client.GetScanConfig</c> and <c>ContainerAnalysisV1Beta1Client.GetScanConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisV1Beta1Client.GetScanConfig</c> and
        /// <c>ContainerAnalysisV1Beta1Client.GetScanConfigAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetScanConfigSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisV1Beta1Client.ListScanConfigs</c> and <c>ContainerAnalysisV1Beta1Client.ListScanConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisV1Beta1Client.ListScanConfigs</c> and
        /// <c>ContainerAnalysisV1Beta1Client.ListScanConfigsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListScanConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisV1Beta1Client.UpdateScanConfig</c> and <c>ContainerAnalysisV1Beta1Client.UpdateScanConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContainerAnalysisV1Beta1Client.UpdateScanConfig</c> and
        /// <c>ContainerAnalysisV1Beta1Client.UpdateScanConfigAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateScanConfigSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ContainerAnalysisV1Beta1Settings"/> object.</returns>
        public ContainerAnalysisV1Beta1Settings Clone() => new ContainerAnalysisV1Beta1Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ContainerAnalysisV1Beta1Client"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ContainerAnalysisV1Beta1ClientBuilder : gaxgrpc::ClientBuilderBase<ContainerAnalysisV1Beta1Client>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public ContainerAnalysisV1Beta1Settings Settings { get; set; }

        /// <inheritdoc/>
        public override ContainerAnalysisV1Beta1Client Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ContainerAnalysisV1Beta1Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<ContainerAnalysisV1Beta1Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ContainerAnalysisV1Beta1Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => ContainerAnalysisV1Beta1Client.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ContainerAnalysisV1Beta1Client.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => ContainerAnalysisV1Beta1Client.ChannelPool;
    }

    /// <summary>
    /// ContainerAnalysisV1Beta1 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ContainerAnalysisV1Beta1Client
    {
        /// <summary>
        /// The default endpoint for the ContainerAnalysisV1Beta1 service, which is a host of "containeranalysis.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("containeranalysis.googleapis.com", 443);

        /// <summary>
        /// The default ContainerAnalysisV1Beta1 scopes.
        /// </summary>
        /// <remarks>
        /// The default ContainerAnalysisV1Beta1 scopes are:
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
        /// Asynchronously creates a <see cref="ContainerAnalysisV1Beta1Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Devtools.Containeranalysis.V1beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ContainerAnalysisV1Beta1Client client = await ContainerAnalysisV1Beta1Client.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Devtools.Containeranalysis.V1beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ContainerAnalysisV1Beta1Client.DefaultEndpoint.Host, ContainerAnalysisV1Beta1Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ContainerAnalysisV1Beta1Client client = ContainerAnalysisV1Beta1Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ContainerAnalysisV1Beta1Settings"/>.</param>
        /// <returns>The task representing the created <see cref="ContainerAnalysisV1Beta1Client"/>.</returns>
        public static async stt::Task<ContainerAnalysisV1Beta1Client> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ContainerAnalysisV1Beta1Settings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ContainerAnalysisV1Beta1Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Devtools.Containeranalysis.V1beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ContainerAnalysisV1Beta1Client client = ContainerAnalysisV1Beta1Client.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Devtools.Containeranalysis.V1beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ContainerAnalysisV1Beta1Client.DefaultEndpoint.Host, ContainerAnalysisV1Beta1Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ContainerAnalysisV1Beta1Client client = ContainerAnalysisV1Beta1Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ContainerAnalysisV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="ContainerAnalysisV1Beta1Client"/>.</returns>
        public static ContainerAnalysisV1Beta1Client Create(gaxgrpc::ServiceEndpoint endpoint = null, ContainerAnalysisV1Beta1Settings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ContainerAnalysisV1Beta1Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ContainerAnalysisV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="ContainerAnalysisV1Beta1Client"/>.</returns>
        public static ContainerAnalysisV1Beta1Client Create(grpccore::Channel channel, ContainerAnalysisV1Beta1Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ContainerAnalysisV1Beta1Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ContainerAnalysisV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="ContainerAnalysisV1Beta1Client"/>.</returns>
        public static ContainerAnalysisV1Beta1Client Create(grpccore::CallInvoker callInvoker, ContainerAnalysisV1Beta1Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client grpcClient = new ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client(callInvoker);
            return new ContainerAnalysisV1Beta1ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ContainerAnalysisV1Beta1Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ContainerAnalysisV1Beta1Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ContainerAnalysisV1Beta1Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ContainerAnalysisV1Beta1Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ContainerAnalysisV1Beta1 client.
        /// </summary>
        public virtual ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            IamResourceNameOneof resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicyAsync(
                new iam::SetIamPolicyRequest
                {
                    ResourceAsIamResourceNameOneof = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            IamResourceNameOneof resource,
            iam::Policy policy,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy SetIamPolicy(
            IamResourceNameOneof resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicy(
                new iam::SetIamPolicyRequest
                {
                    ResourceAsIamResourceNameOneof = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            string resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicyAsync(
                new iam::SetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            string resource,
            iam::Policy policy,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy SetIamPolicy(
            string resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicy(
                new iam::SetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public virtual iam::Policy SetIamPolicy(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            IamResourceNameOneof resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicyAsync(
                new iam::GetIamPolicyRequest
                {
                    ResourceAsIamResourceNameOneof = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            IamResourceNameOneof resource,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy GetIamPolicy(
            IamResourceNameOneof resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicy(
                new iam::GetIamPolicyRequest
                {
                    ResourceAsIamResourceNameOneof = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            string resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicyAsync(
                new iam::GetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            string resource,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy GetIamPolicy(
            string resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicy(
                new iam::GetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public virtual iam::Policy GetIamPolicy(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            IamResourceNameOneof resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissionsAsync(
                new iam::TestIamPermissionsRequest
                {
                    ResourceAsIamResourceNameOneof = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            IamResourceNameOneof resource,
            scg::IEnumerable<string> permissions,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            IamResourceNameOneof resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissions(
                new iam::TestIamPermissionsRequest
                {
                    ResourceAsIamResourceNameOneof = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissionsAsync(
                new iam::TestIamPermissionsRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            scg::IEnumerable<string> permissions,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            string resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissions(
                new iam::TestIamPermissionsRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the specified scan configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the scan configuration in the form of
        /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gdcv::ScanConfig> GetScanConfigAsync(
            ScanConfigName name,
            gaxgrpc::CallSettings callSettings = null) => GetScanConfigAsync(
                new gdcv::GetScanConfigRequest
                {
                    ScanConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified scan configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the scan configuration in the form of
        /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gdcv::ScanConfig> GetScanConfigAsync(
            ScanConfigName name,
            st::CancellationToken cancellationToken) => GetScanConfigAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified scan configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the scan configuration in the form of
        /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gdcv::ScanConfig GetScanConfig(
            ScanConfigName name,
            gaxgrpc::CallSettings callSettings = null) => GetScanConfig(
                new gdcv::GetScanConfigRequest
                {
                    ScanConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified scan configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the scan configuration in the form of
        /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gdcv::ScanConfig> GetScanConfigAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetScanConfigAsync(
                new gdcv::GetScanConfigRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified scan configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the scan configuration in the form of
        /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gdcv::ScanConfig> GetScanConfigAsync(
            string name,
            st::CancellationToken cancellationToken) => GetScanConfigAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified scan configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the scan configuration in the form of
        /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gdcv::ScanConfig GetScanConfig(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetScanConfig(
                new gdcv::GetScanConfigRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified scan configuration.
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
        public virtual stt::Task<gdcv::ScanConfig> GetScanConfigAsync(
            gdcv::GetScanConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the specified scan configuration.
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
        public virtual stt::Task<gdcv::ScanConfig> GetScanConfigAsync(
            gdcv::GetScanConfigRequest request,
            st::CancellationToken cancellationToken) => GetScanConfigAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified scan configuration.
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
        public virtual gdcv::ScanConfig GetScanConfig(
            gdcv::GetScanConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists scan configurations for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list scan configurations for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// Required. The filter expression.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gdcv::ScanConfig"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gdcv::ListScanConfigsResponse, gdcv::ScanConfig> ListScanConfigsAsync(
            ProjectName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListScanConfigsAsync(
                new gdcv::ListScanConfigsRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists scan configurations for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list scan configurations for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// Required. The filter expression.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gdcv::ScanConfig"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gdcv::ListScanConfigsResponse, gdcv::ScanConfig> ListScanConfigs(
            ProjectName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListScanConfigs(
                new gdcv::ListScanConfigsRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists scan configurations for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list scan configurations for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// Required. The filter expression.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gdcv::ScanConfig"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gdcv::ListScanConfigsResponse, gdcv::ScanConfig> ListScanConfigsAsync(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListScanConfigsAsync(
                new gdcv::ListScanConfigsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists scan configurations for the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list scan configurations for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// Required. The filter expression.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gdcv::ScanConfig"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gdcv::ListScanConfigsResponse, gdcv::ScanConfig> ListScanConfigs(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListScanConfigs(
                new gdcv::ListScanConfigsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists scan configurations for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gdcv::ScanConfig"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gdcv::ListScanConfigsResponse, gdcv::ScanConfig> ListScanConfigsAsync(
            gdcv::ListScanConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists scan configurations for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gdcv::ScanConfig"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gdcv::ListScanConfigsResponse, gdcv::ScanConfig> ListScanConfigs(
            gdcv::ListScanConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified scan configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the scan configuration in the form of
        /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        /// </param>
        /// <param name="scanConfig">
        /// Required. The updated scan configuration.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gdcv::ScanConfig> UpdateScanConfigAsync(
            ScanConfigName name,
            gdcv::ScanConfig scanConfig,
            gaxgrpc::CallSettings callSettings = null) => UpdateScanConfigAsync(
                new gdcv::UpdateScanConfigRequest
                {
                    ScanConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ScanConfig = gax::GaxPreconditions.CheckNotNull(scanConfig, nameof(scanConfig)),
                },
                callSettings);

        /// <summary>
        /// Updates the specified scan configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the scan configuration in the form of
        /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        /// </param>
        /// <param name="scanConfig">
        /// Required. The updated scan configuration.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gdcv::ScanConfig> UpdateScanConfigAsync(
            ScanConfigName name,
            gdcv::ScanConfig scanConfig,
            st::CancellationToken cancellationToken) => UpdateScanConfigAsync(
                name,
                scanConfig,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified scan configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the scan configuration in the form of
        /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        /// </param>
        /// <param name="scanConfig">
        /// Required. The updated scan configuration.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gdcv::ScanConfig UpdateScanConfig(
            ScanConfigName name,
            gdcv::ScanConfig scanConfig,
            gaxgrpc::CallSettings callSettings = null) => UpdateScanConfig(
                new gdcv::UpdateScanConfigRequest
                {
                    ScanConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ScanConfig = gax::GaxPreconditions.CheckNotNull(scanConfig, nameof(scanConfig)),
                },
                callSettings);

        /// <summary>
        /// Updates the specified scan configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the scan configuration in the form of
        /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        /// </param>
        /// <param name="scanConfig">
        /// Required. The updated scan configuration.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gdcv::ScanConfig> UpdateScanConfigAsync(
            string name,
            gdcv::ScanConfig scanConfig,
            gaxgrpc::CallSettings callSettings = null) => UpdateScanConfigAsync(
                new gdcv::UpdateScanConfigRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    ScanConfig = gax::GaxPreconditions.CheckNotNull(scanConfig, nameof(scanConfig)),
                },
                callSettings);

        /// <summary>
        /// Updates the specified scan configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the scan configuration in the form of
        /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        /// </param>
        /// <param name="scanConfig">
        /// Required. The updated scan configuration.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gdcv::ScanConfig> UpdateScanConfigAsync(
            string name,
            gdcv::ScanConfig scanConfig,
            st::CancellationToken cancellationToken) => UpdateScanConfigAsync(
                name,
                scanConfig,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified scan configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the scan configuration in the form of
        /// `projects/[PROJECT_ID]/scanConfigs/[SCAN_CONFIG_ID]`.
        /// </param>
        /// <param name="scanConfig">
        /// Required. The updated scan configuration.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gdcv::ScanConfig UpdateScanConfig(
            string name,
            gdcv::ScanConfig scanConfig,
            gaxgrpc::CallSettings callSettings = null) => UpdateScanConfig(
                new gdcv::UpdateScanConfigRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    ScanConfig = gax::GaxPreconditions.CheckNotNull(scanConfig, nameof(scanConfig)),
                },
                callSettings);

        /// <summary>
        /// Updates the specified scan configuration.
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
        public virtual stt::Task<gdcv::ScanConfig> UpdateScanConfigAsync(
            gdcv::UpdateScanConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified scan configuration.
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
        public virtual stt::Task<gdcv::ScanConfig> UpdateScanConfigAsync(
            gdcv::UpdateScanConfigRequest request,
            st::CancellationToken cancellationToken) => UpdateScanConfigAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified scan configuration.
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
        public virtual gdcv::ScanConfig UpdateScanConfig(
            gdcv::UpdateScanConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ContainerAnalysisV1Beta1 client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ContainerAnalysisV1Beta1ClientImpl : ContainerAnalysisV1Beta1Client
    {
        private readonly gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> _callSetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> _callGetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> _callTestIamPermissions;
        private readonly gaxgrpc::ApiCall<gdcv::GetScanConfigRequest, gdcv::ScanConfig> _callGetScanConfig;
        private readonly gaxgrpc::ApiCall<gdcv::ListScanConfigsRequest, gdcv::ListScanConfigsResponse> _callListScanConfigs;
        private readonly gaxgrpc::ApiCall<gdcv::UpdateScanConfigRequest, gdcv::ScanConfig> _callUpdateScanConfig;

        /// <summary>
        /// Constructs a client wrapper for the ContainerAnalysisV1Beta1 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ContainerAnalysisV1Beta1Settings"/> used within this client </param>
        public ContainerAnalysisV1Beta1ClientImpl(ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client grpcClient, ContainerAnalysisV1Beta1Settings settings)
        {
            GrpcClient = grpcClient;
            ContainerAnalysisV1Beta1Settings effectiveSettings = settings ?? ContainerAnalysisV1Beta1Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callSetIamPolicy = clientHelper.BuildApiCall<iam::SetIamPolicyRequest, iam::Policy>(
                GrpcClient.SetIamPolicyAsync, GrpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            _callGetIamPolicy = clientHelper.BuildApiCall<iam::GetIamPolicyRequest, iam::Policy>(
                GrpcClient.GetIamPolicyAsync, GrpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            _callTestIamPermissions = clientHelper.BuildApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse>(
                GrpcClient.TestIamPermissionsAsync, GrpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            _callGetScanConfig = clientHelper.BuildApiCall<gdcv::GetScanConfigRequest, gdcv::ScanConfig>(
                GrpcClient.GetScanConfigAsync, GrpcClient.GetScanConfig, effectiveSettings.GetScanConfigSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListScanConfigs = clientHelper.BuildApiCall<gdcv::ListScanConfigsRequest, gdcv::ListScanConfigsResponse>(
                GrpcClient.ListScanConfigsAsync, GrpcClient.ListScanConfigs, effectiveSettings.ListScanConfigsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateScanConfig = clientHelper.BuildApiCall<gdcv::UpdateScanConfigRequest, gdcv::ScanConfig>(
                GrpcClient.UpdateScanConfigAsync, GrpcClient.UpdateScanConfig, effectiveSettings.UpdateScanConfigSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            Modify_ApiCall(ref _callGetScanConfig);
            Modify_GetScanConfigApiCall(ref _callGetScanConfig);
            Modify_ApiCall(ref _callListScanConfigs);
            Modify_ListScanConfigsApiCall(ref _callListScanConfigs);
            Modify_ApiCall(ref _callUpdateScanConfig);
            Modify_UpdateScanConfigApiCall(ref _callUpdateScanConfig);
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
        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> call);
        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> call);
        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> call);
        partial void Modify_GetScanConfigApiCall(ref gaxgrpc::ApiCall<gdcv::GetScanConfigRequest, gdcv::ScanConfig> call);
        partial void Modify_ListScanConfigsApiCall(ref gaxgrpc::ApiCall<gdcv::ListScanConfigsRequest, gdcv::ListScanConfigsResponse> call);
        partial void Modify_UpdateScanConfigApiCall(ref gaxgrpc::ApiCall<gdcv::UpdateScanConfigRequest, gdcv::ScanConfig> call);
        partial void OnConstruction(ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client grpcClient, ContainerAnalysisV1Beta1Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ContainerAnalysisV1Beta1 client.
        /// </summary>
        public override ContainerAnalysisV1Beta1.ContainerAnalysisV1Beta1Client GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_SetIamPolicyRequest(ref iam::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref iam::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref iam::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetScanConfigRequest(ref gdcv::GetScanConfigRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListScanConfigsRequest(ref gdcv::ListScanConfigsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateScanConfigRequest(ref gdcv::UpdateScanConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public override stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public override iam::Policy SetIamPolicy(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public override stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public override iam::Policy GetIamPolicy(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public override stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        ///
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
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
        public override iam::TestIamPermissionsResponse TestIamPermissions(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified scan configuration.
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
        public override stt::Task<gdcv::ScanConfig> GetScanConfigAsync(
            gdcv::GetScanConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScanConfigRequest(ref request, ref callSettings);
            return _callGetScanConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the specified scan configuration.
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
        public override gdcv::ScanConfig GetScanConfig(
            gdcv::GetScanConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScanConfigRequest(ref request, ref callSettings);
            return _callGetScanConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists scan configurations for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gdcv::ScanConfig"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<gdcv::ListScanConfigsResponse, gdcv::ScanConfig> ListScanConfigsAsync(
            gdcv::ListScanConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScanConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<gdcv::ListScanConfigsRequest, gdcv::ListScanConfigsResponse, gdcv::ScanConfig>(_callListScanConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists scan configurations for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gdcv::ScanConfig"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<gdcv::ListScanConfigsResponse, gdcv::ScanConfig> ListScanConfigs(
            gdcv::ListScanConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScanConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<gdcv::ListScanConfigsRequest, gdcv::ListScanConfigsResponse, gdcv::ScanConfig>(_callListScanConfigs, request, callSettings);
        }

        /// <summary>
        /// Updates the specified scan configuration.
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
        public override stt::Task<gdcv::ScanConfig> UpdateScanConfigAsync(
            gdcv::UpdateScanConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScanConfigRequest(ref request, ref callSettings);
            return _callUpdateScanConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified scan configuration.
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
        public override gdcv::ScanConfig UpdateScanConfig(
            gdcv::UpdateScanConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScanConfigRequest(ref request, ref callSettings);
            return _callUpdateScanConfig.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class gdcv::ListScanConfigsRequest : gaxgrpc::IPageRequest { }
    public partial class gdcv::ListScanConfigsResponse : gaxgrpc::IPageResponse<gdcv::ScanConfig>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<gdcv::ScanConfig> GetEnumerator() => ScanConfigs.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
