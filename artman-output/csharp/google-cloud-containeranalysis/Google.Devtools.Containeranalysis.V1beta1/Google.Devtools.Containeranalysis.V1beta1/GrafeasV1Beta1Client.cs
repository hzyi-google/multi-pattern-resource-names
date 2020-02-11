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
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using gv = Grafeas.V1Beta1;
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
    /// Settings for a <see cref="GrafeasV1Beta1Client"/>.
    /// </summary>
    public sealed partial class GrafeasV1Beta1Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="GrafeasV1Beta1Settings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="GrafeasV1Beta1Settings"/>.
        /// </returns>
        public static GrafeasV1Beta1Settings GetDefault() => new GrafeasV1Beta1Settings();

        /// <summary>
        /// Constructs a new <see cref="GrafeasV1Beta1Settings"/> object with default settings.
        /// </summary>
        public GrafeasV1Beta1Settings() { }

        private GrafeasV1Beta1Settings(GrafeasV1Beta1Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetOccurrenceSettings = existing.GetOccurrenceSettings;
            ListOccurrencesSettings = existing.ListOccurrencesSettings;
            DeleteOccurrenceSettings = existing.DeleteOccurrenceSettings;
            CreateOccurrenceSettings = existing.CreateOccurrenceSettings;
            BatchCreateOccurrencesSettings = existing.BatchCreateOccurrencesSettings;
            UpdateOccurrenceSettings = existing.UpdateOccurrenceSettings;
            GetOccurrenceNoteSettings = existing.GetOccurrenceNoteSettings;
            GetNoteSettings = existing.GetNoteSettings;
            ListNotesSettings = existing.ListNotesSettings;
            DeleteNoteSettings = existing.DeleteNoteSettings;
            CreateNoteSettings = existing.CreateNoteSettings;
            BatchCreateNotesSettings = existing.BatchCreateNotesSettings;
            UpdateNoteSettings = existing.UpdateNoteSettings;
            ListNoteOccurrencesSettings = existing.ListNoteOccurrencesSettings;
            GetVulnerabilityOccurrencesSummarySettings = existing.GetVulnerabilityOccurrencesSummarySettings;
            OnCopy(existing);
        }

        partial void OnCopy(GrafeasV1Beta1Settings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="GrafeasV1Beta1Client"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="GrafeasV1Beta1Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="GrafeasV1Beta1Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="GrafeasV1Beta1Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="GrafeasV1Beta1Client"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="GrafeasV1Beta1Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="GrafeasV1Beta1Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="GrafeasV1Beta1Client"/> RPC methods is defined as:
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
        /// <c>GrafeasV1Beta1Client.GetOccurrence</c> and <c>GrafeasV1Beta1Client.GetOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.GetOccurrence</c> and
        /// <c>GrafeasV1Beta1Client.GetOccurrenceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetOccurrenceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasV1Beta1Client.ListOccurrences</c> and <c>GrafeasV1Beta1Client.ListOccurrencesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.ListOccurrences</c> and
        /// <c>GrafeasV1Beta1Client.ListOccurrencesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListOccurrencesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasV1Beta1Client.DeleteOccurrence</c> and <c>GrafeasV1Beta1Client.DeleteOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.DeleteOccurrence</c> and
        /// <c>GrafeasV1Beta1Client.DeleteOccurrenceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteOccurrenceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasV1Beta1Client.CreateOccurrence</c> and <c>GrafeasV1Beta1Client.CreateOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.CreateOccurrence</c> and
        /// <c>GrafeasV1Beta1Client.CreateOccurrenceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateOccurrenceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasV1Beta1Client.BatchCreateOccurrences</c> and <c>GrafeasV1Beta1Client.BatchCreateOccurrencesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.BatchCreateOccurrences</c> and
        /// <c>GrafeasV1Beta1Client.BatchCreateOccurrencesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings BatchCreateOccurrencesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasV1Beta1Client.UpdateOccurrence</c> and <c>GrafeasV1Beta1Client.UpdateOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.UpdateOccurrence</c> and
        /// <c>GrafeasV1Beta1Client.UpdateOccurrenceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateOccurrenceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasV1Beta1Client.GetOccurrenceNote</c> and <c>GrafeasV1Beta1Client.GetOccurrenceNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.GetOccurrenceNote</c> and
        /// <c>GrafeasV1Beta1Client.GetOccurrenceNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetOccurrenceNoteSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasV1Beta1Client.GetNote</c> and <c>GrafeasV1Beta1Client.GetNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.GetNote</c> and
        /// <c>GrafeasV1Beta1Client.GetNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetNoteSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasV1Beta1Client.ListNotes</c> and <c>GrafeasV1Beta1Client.ListNotesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.ListNotes</c> and
        /// <c>GrafeasV1Beta1Client.ListNotesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListNotesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasV1Beta1Client.DeleteNote</c> and <c>GrafeasV1Beta1Client.DeleteNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.DeleteNote</c> and
        /// <c>GrafeasV1Beta1Client.DeleteNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteNoteSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasV1Beta1Client.CreateNote</c> and <c>GrafeasV1Beta1Client.CreateNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.CreateNote</c> and
        /// <c>GrafeasV1Beta1Client.CreateNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateNoteSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasV1Beta1Client.BatchCreateNotes</c> and <c>GrafeasV1Beta1Client.BatchCreateNotesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.BatchCreateNotes</c> and
        /// <c>GrafeasV1Beta1Client.BatchCreateNotesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings BatchCreateNotesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasV1Beta1Client.UpdateNote</c> and <c>GrafeasV1Beta1Client.UpdateNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.UpdateNote</c> and
        /// <c>GrafeasV1Beta1Client.UpdateNoteAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateNoteSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasV1Beta1Client.ListNoteOccurrences</c> and <c>GrafeasV1Beta1Client.ListNoteOccurrencesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.ListNoteOccurrences</c> and
        /// <c>GrafeasV1Beta1Client.ListNoteOccurrencesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListNoteOccurrencesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasV1Beta1Client.GetVulnerabilityOccurrencesSummary</c> and <c>GrafeasV1Beta1Client.GetVulnerabilityOccurrencesSummaryAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GrafeasV1Beta1Client.GetVulnerabilityOccurrencesSummary</c> and
        /// <c>GrafeasV1Beta1Client.GetVulnerabilityOccurrencesSummaryAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetVulnerabilityOccurrencesSummarySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="GrafeasV1Beta1Settings"/> object.</returns>
        public GrafeasV1Beta1Settings Clone() => new GrafeasV1Beta1Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GrafeasV1Beta1Client"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class GrafeasV1Beta1ClientBuilder : gaxgrpc::ClientBuilderBase<GrafeasV1Beta1Client>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public GrafeasV1Beta1Settings Settings { get; set; }

        /// <inheritdoc/>
        public override GrafeasV1Beta1Client Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GrafeasV1Beta1Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<GrafeasV1Beta1Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GrafeasV1Beta1Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => GrafeasV1Beta1Client.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => GrafeasV1Beta1Client.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => GrafeasV1Beta1Client.ChannelPool;
    }

    /// <summary>
    /// GrafeasV1Beta1 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class GrafeasV1Beta1Client
    {
        /// <summary>
        /// The default endpoint for the GrafeasV1Beta1 service, which is a host of "containeranalysis.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("containeranalysis.googleapis.com", 443);

        /// <summary>
        /// The default GrafeasV1Beta1 scopes.
        /// </summary>
        /// <remarks>
        /// The default GrafeasV1Beta1 scopes are:
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
        /// Asynchronously creates a <see cref="GrafeasV1Beta1Client"/>, applying defaults for all unspecified settings,
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
        /// GrafeasV1Beta1Client client = await GrafeasV1Beta1Client.CreateAsync();
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
        ///     GrafeasV1Beta1Client.DefaultEndpoint.Host, GrafeasV1Beta1Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// GrafeasV1Beta1Client client = GrafeasV1Beta1Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GrafeasV1Beta1Settings"/>.</param>
        /// <returns>The task representing the created <see cref="GrafeasV1Beta1Client"/>.</returns>
        public static async stt::Task<GrafeasV1Beta1Client> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, GrafeasV1Beta1Settings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="GrafeasV1Beta1Client"/>, applying defaults for all unspecified settings,
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
        /// GrafeasV1Beta1Client client = GrafeasV1Beta1Client.Create();
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
        ///     GrafeasV1Beta1Client.DefaultEndpoint.Host, GrafeasV1Beta1Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// GrafeasV1Beta1Client client = GrafeasV1Beta1Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GrafeasV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="GrafeasV1Beta1Client"/>.</returns>
        public static GrafeasV1Beta1Client Create(gaxgrpc::ServiceEndpoint endpoint = null, GrafeasV1Beta1Settings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="GrafeasV1Beta1Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GrafeasV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="GrafeasV1Beta1Client"/>.</returns>
        public static GrafeasV1Beta1Client Create(grpccore::Channel channel, GrafeasV1Beta1Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="GrafeasV1Beta1Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GrafeasV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="GrafeasV1Beta1Client"/>.</returns>
        public static GrafeasV1Beta1Client Create(grpccore::CallInvoker callInvoker, GrafeasV1Beta1Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GrafeasV1Beta1.GrafeasV1Beta1Client grpcClient = new GrafeasV1Beta1.GrafeasV1Beta1Client(callInvoker);
            return new GrafeasV1Beta1ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, GrafeasV1Beta1Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, GrafeasV1Beta1Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, GrafeasV1Beta1Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, GrafeasV1Beta1Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC GrafeasV1Beta1 client.
        /// </summary>
        public virtual GrafeasV1Beta1.GrafeasV1Beta1Client GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> GetOccurrenceAsync(
            OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceAsync(
                new gv::GetOccurrenceRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> GetOccurrenceAsync(
            OccurrenceName name,
            st::CancellationToken cancellationToken) => GetOccurrenceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Occurrence GetOccurrence(
            OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrence(
                new gv::GetOccurrenceRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> GetOccurrenceAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceAsync(
                new gv::GetOccurrenceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> GetOccurrenceAsync(
            string name,
            st::CancellationToken cancellationToken) => GetOccurrenceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Occurrence GetOccurrence(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrence(
                new gv::GetOccurrenceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified occurrence.
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
        public virtual stt::Task<gv::Occurrence> GetOccurrenceAsync(
            gv::GetOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the specified occurrence.
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
        public virtual stt::Task<gv::Occurrence> GetOccurrenceAsync(
            gv::GetOccurrenceRequest request,
            st::CancellationToken cancellationToken) => GetOccurrenceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified occurrence.
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
        public virtual gv::Occurrence GetOccurrence(
            gv::GetOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list occurrences for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrencesAsync(
            ProjectName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListOccurrencesAsync(
                new gv::ListOccurrencesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list occurrences for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrences(
            ProjectName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListOccurrences(
                new gv::ListOccurrencesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list occurrences for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrencesAsync(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListOccurrencesAsync(
                new gv::ListOccurrencesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list occurrences for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrences(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListOccurrences(
                new gv::ListOccurrencesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrencesAsync(
            gv::ListOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrences(
            gv::ListOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteOccurrenceAsync(
            OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteOccurrenceAsync(
                new gv::DeleteOccurrenceRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteOccurrenceAsync(
            OccurrenceName name,
            st::CancellationToken cancellationToken) => DeleteOccurrenceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteOccurrence(
            OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteOccurrence(
                new gv::DeleteOccurrenceRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteOccurrenceAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteOccurrenceAsync(
                new gv::DeleteOccurrenceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteOccurrenceAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteOccurrenceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteOccurrence(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteOccurrence(
                new gv::DeleteOccurrenceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
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
        public virtual stt::Task DeleteOccurrenceAsync(
            gv::DeleteOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
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
        public virtual stt::Task DeleteOccurrenceAsync(
            gv::DeleteOccurrenceRequest request,
            st::CancellationToken cancellationToken) => DeleteOccurrenceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteOccurrence(
            gv::DeleteOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> CreateOccurrenceAsync(
            ProjectName parent,
            gv::Occurrence occurrence,
            gaxgrpc::CallSettings callSettings = null) => CreateOccurrenceAsync(
                new gv::CreateOccurrenceRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                },
                callSettings);

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> CreateOccurrenceAsync(
            ProjectName parent,
            gv::Occurrence occurrence,
            st::CancellationToken cancellationToken) => CreateOccurrenceAsync(
                parent,
                occurrence,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Occurrence CreateOccurrence(
            ProjectName parent,
            gv::Occurrence occurrence,
            gaxgrpc::CallSettings callSettings = null) => CreateOccurrence(
                new gv::CreateOccurrenceRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                },
                callSettings);

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> CreateOccurrenceAsync(
            string parent,
            gv::Occurrence occurrence,
            gaxgrpc::CallSettings callSettings = null) => CreateOccurrenceAsync(
                new gv::CreateOccurrenceRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                },
                callSettings);

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> CreateOccurrenceAsync(
            string parent,
            gv::Occurrence occurrence,
            st::CancellationToken cancellationToken) => CreateOccurrenceAsync(
                parent,
                occurrence,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Occurrence CreateOccurrence(
            string parent,
            gv::Occurrence occurrence,
            gaxgrpc::CallSettings callSettings = null) => CreateOccurrence(
                new gv::CreateOccurrenceRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                },
                callSettings);

        /// <summary>
        /// Creates a new occurrence.
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
        public virtual stt::Task<gv::Occurrence> CreateOccurrenceAsync(
            gv::CreateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new occurrence.
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
        public virtual stt::Task<gv::Occurrence> CreateOccurrenceAsync(
            gv::CreateOccurrenceRequest request,
            st::CancellationToken cancellationToken) => CreateOccurrenceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new occurrence.
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
        public virtual gv::Occurrence CreateOccurrence(
            gv::CreateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            ProjectName parent,
            scg::IEnumerable<gv::Occurrence> occurrences,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateOccurrencesAsync(
                new gv::BatchCreateOccurrencesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Occurrences = { gax::GaxPreconditions.CheckNotNull(occurrences, nameof(occurrences)) },
                },
                callSettings);

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            ProjectName parent,
            scg::IEnumerable<gv::Occurrence> occurrences,
            st::CancellationToken cancellationToken) => BatchCreateOccurrencesAsync(
                parent,
                occurrences,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::BatchCreateOccurrencesResponse BatchCreateOccurrences(
            ProjectName parent,
            scg::IEnumerable<gv::Occurrence> occurrences,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateOccurrences(
                new gv::BatchCreateOccurrencesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Occurrences = { gax::GaxPreconditions.CheckNotNull(occurrences, nameof(occurrences)) },
                },
                callSettings);

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            string parent,
            scg::IEnumerable<gv::Occurrence> occurrences,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateOccurrencesAsync(
                new gv::BatchCreateOccurrencesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Occurrences = { gax::GaxPreconditions.CheckNotNull(occurrences, nameof(occurrences)) },
                },
                callSettings);

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            string parent,
            scg::IEnumerable<gv::Occurrence> occurrences,
            st::CancellationToken cancellationToken) => BatchCreateOccurrencesAsync(
                parent,
                occurrences,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::BatchCreateOccurrencesResponse BatchCreateOccurrences(
            string parent,
            scg::IEnumerable<gv::Occurrence> occurrences,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateOccurrences(
                new gv::BatchCreateOccurrencesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Occurrences = { gax::GaxPreconditions.CheckNotNull(occurrences, nameof(occurrences)) },
                },
                callSettings);

        /// <summary>
        /// Creates new occurrences in batch.
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
        public virtual stt::Task<gv::BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            gv::BatchCreateOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates new occurrences in batch.
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
        public virtual stt::Task<gv::BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            gv::BatchCreateOccurrencesRequest request,
            st::CancellationToken cancellationToken) => BatchCreateOccurrencesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new occurrences in batch.
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
        public virtual gv::BatchCreateOccurrencesResponse BatchCreateOccurrences(
            gv::BatchCreateOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> UpdateOccurrenceAsync(
            OccurrenceName name,
            gv::Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateOccurrenceAsync(
                new gv::UpdateOccurrenceRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> UpdateOccurrenceAsync(
            OccurrenceName name,
            gv::Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateOccurrenceAsync(
                name,
                occurrence,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Occurrence UpdateOccurrence(
            OccurrenceName name,
            gv::Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateOccurrence(
                new gv::UpdateOccurrenceRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> UpdateOccurrenceAsync(
            string name,
            gv::Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateOccurrenceAsync(
                new gv::UpdateOccurrenceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Occurrence> UpdateOccurrenceAsync(
            string name,
            gv::Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateOccurrenceAsync(
                name,
                occurrence,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Occurrence UpdateOccurrence(
            string name,
            gv::Occurrence occurrence,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateOccurrence(
                new gv::UpdateOccurrenceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified occurrence.
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
        public virtual stt::Task<gv::Occurrence> UpdateOccurrenceAsync(
            gv::UpdateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified occurrence.
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
        public virtual stt::Task<gv::Occurrence> UpdateOccurrenceAsync(
            gv::UpdateOccurrenceRequest request,
            st::CancellationToken cancellationToken) => UpdateOccurrenceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified occurrence.
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
        public virtual gv::Occurrence UpdateOccurrence(
            gv::UpdateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetOccurrenceNoteAsync(
            OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceNoteAsync(
                new gv::GetOccurrenceNoteRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetOccurrenceNoteAsync(
            OccurrenceName name,
            st::CancellationToken cancellationToken) => GetOccurrenceNoteAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note GetOccurrenceNote(
            OccurrenceName name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceNote(
                new gv::GetOccurrenceNoteRequest
                {
                    OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetOccurrenceNoteAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceNoteAsync(
                new gv::GetOccurrenceNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetOccurrenceNoteAsync(
            string name,
            st::CancellationToken cancellationToken) => GetOccurrenceNoteAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note GetOccurrenceNote(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOccurrenceNote(
                new gv::GetOccurrenceNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
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
        public virtual stt::Task<gv::Note> GetOccurrenceNoteAsync(
            gv::GetOccurrenceNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
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
        public virtual stt::Task<gv::Note> GetOccurrenceNoteAsync(
            gv::GetOccurrenceNoteRequest request,
            st::CancellationToken cancellationToken) => GetOccurrenceNoteAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
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
        public virtual gv::Note GetOccurrenceNote(
            gv::GetOccurrenceNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetNoteAsync(
            NoteName name,
            gaxgrpc::CallSettings callSettings = null) => GetNoteAsync(
                new gv::GetNoteRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetNoteAsync(
            NoteName name,
            st::CancellationToken cancellationToken) => GetNoteAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note GetNote(
            NoteName name,
            gaxgrpc::CallSettings callSettings = null) => GetNote(
                new gv::GetNoteRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetNoteAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetNoteAsync(
                new gv::GetNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> GetNoteAsync(
            string name,
            st::CancellationToken cancellationToken) => GetNoteAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note GetNote(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetNote(
                new gv::GetNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified note.
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
        public virtual stt::Task<gv::Note> GetNoteAsync(
            gv::GetNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the specified note.
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
        public virtual stt::Task<gv::Note> GetNoteAsync(
            gv::GetNoteRequest request,
            st::CancellationToken cancellationToken) => GetNoteAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified note.
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
        public virtual gv::Note GetNote(
            gv::GetNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list notes for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable asynchronous sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListNotesResponse, gv::Note> ListNotesAsync(
            ProjectName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotesAsync(
                new gv::ListNotesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list notes for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListNotesResponse, gv::Note> ListNotes(
            ProjectName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotes(
                new gv::ListNotesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list notes for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable asynchronous sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListNotesResponse, gv::Note> ListNotesAsync(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotesAsync(
                new gv::ListNotesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list notes for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListNotesResponse, gv::Note> ListNotes(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNotes(
                new gv::ListNotesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListNotesResponse, gv::Note> ListNotesAsync(
            gv::ListNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListNotesResponse, gv::Note> ListNotes(
            gv::ListNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteNoteAsync(
            NoteName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteNoteAsync(
                new gv::DeleteNoteRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteNoteAsync(
            NoteName name,
            st::CancellationToken cancellationToken) => DeleteNoteAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteNote(
            NoteName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteNote(
                new gv::DeleteNoteRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteNoteAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteNoteAsync(
                new gv::DeleteNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteNoteAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteNoteAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteNote(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteNote(
                new gv::DeleteNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified note.
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
        public virtual stt::Task DeleteNoteAsync(
            gv::DeleteNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified note.
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
        public virtual stt::Task DeleteNoteAsync(
            gv::DeleteNoteRequest request,
            st::CancellationToken cancellationToken) => DeleteNoteAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteNote(
            gv::DeleteNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> CreateNoteAsync(
            ProjectName parent,
            string noteId,
            gv::Note note,
            gaxgrpc::CallSettings callSettings = null) => CreateNoteAsync(
                new gv::CreateNoteRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    NoteId = gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                },
                callSettings);

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> CreateNoteAsync(
            ProjectName parent,
            string noteId,
            gv::Note note,
            st::CancellationToken cancellationToken) => CreateNoteAsync(
                parent,
                noteId,
                note,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note CreateNote(
            ProjectName parent,
            string noteId,
            gv::Note note,
            gaxgrpc::CallSettings callSettings = null) => CreateNote(
                new gv::CreateNoteRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    NoteId = gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                },
                callSettings);

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> CreateNoteAsync(
            string parent,
            string noteId,
            gv::Note note,
            gaxgrpc::CallSettings callSettings = null) => CreateNoteAsync(
                new gv::CreateNoteRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    NoteId = gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                },
                callSettings);

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> CreateNoteAsync(
            string parent,
            string noteId,
            gv::Note note,
            st::CancellationToken cancellationToken) => CreateNoteAsync(
                parent,
                noteId,
                note,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note CreateNote(
            string parent,
            string noteId,
            gv::Note note,
            gaxgrpc::CallSettings callSettings = null) => CreateNote(
                new gv::CreateNoteRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    NoteId = gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                },
                callSettings);

        /// <summary>
        /// Creates a new note.
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
        public virtual stt::Task<gv::Note> CreateNoteAsync(
            gv::CreateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new note.
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
        public virtual stt::Task<gv::Note> CreateNoteAsync(
            gv::CreateNoteRequest request,
            st::CancellationToken cancellationToken) => CreateNoteAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new note.
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
        public virtual gv::Note CreateNote(
            gv::CreateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateNotesResponse> BatchCreateNotesAsync(
            ProjectName parent,
            scg::IDictionary<string, gv::Note> notes,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateNotesAsync(
                new gv::BatchCreateNotesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Notes = { gax::GaxPreconditions.CheckNotNull(notes, nameof(notes)) },
                },
                callSettings);

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateNotesResponse> BatchCreateNotesAsync(
            ProjectName parent,
            scg::IDictionary<string, gv::Note> notes,
            st::CancellationToken cancellationToken) => BatchCreateNotesAsync(
                parent,
                notes,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::BatchCreateNotesResponse BatchCreateNotes(
            ProjectName parent,
            scg::IDictionary<string, gv::Note> notes,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateNotes(
                new gv::BatchCreateNotesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Notes = { gax::GaxPreconditions.CheckNotNull(notes, nameof(notes)) },
                },
                callSettings);

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateNotesResponse> BatchCreateNotesAsync(
            string parent,
            scg::IDictionary<string, gv::Note> notes,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateNotesAsync(
                new gv::BatchCreateNotesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Notes = { gax::GaxPreconditions.CheckNotNull(notes, nameof(notes)) },
                },
                callSettings);

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::BatchCreateNotesResponse> BatchCreateNotesAsync(
            string parent,
            scg::IDictionary<string, gv::Note> notes,
            st::CancellationToken cancellationToken) => BatchCreateNotesAsync(
                parent,
                notes,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::BatchCreateNotesResponse BatchCreateNotes(
            string parent,
            scg::IDictionary<string, gv::Note> notes,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateNotes(
                new gv::BatchCreateNotesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Notes = { gax::GaxPreconditions.CheckNotNull(notes, nameof(notes)) },
                },
                callSettings);

        /// <summary>
        /// Creates new notes in batch.
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
        public virtual stt::Task<gv::BatchCreateNotesResponse> BatchCreateNotesAsync(
            gv::BatchCreateNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates new notes in batch.
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
        public virtual stt::Task<gv::BatchCreateNotesResponse> BatchCreateNotesAsync(
            gv::BatchCreateNotesRequest request,
            st::CancellationToken cancellationToken) => BatchCreateNotesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new notes in batch.
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
        public virtual gv::BatchCreateNotesResponse BatchCreateNotes(
            gv::BatchCreateNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> UpdateNoteAsync(
            NoteName name,
            gv::Note note,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateNoteAsync(
                new gv::UpdateNoteRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> UpdateNoteAsync(
            NoteName name,
            gv::Note note,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateNoteAsync(
                name,
                note,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note UpdateNote(
            NoteName name,
            gv::Note note,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateNote(
                new gv::UpdateNoteRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> UpdateNoteAsync(
            string name,
            gv::Note note,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateNoteAsync(
                new gv::UpdateNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::Note> UpdateNoteAsync(
            string name,
            gv::Note note,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateNoteAsync(
                name,
                note,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::Note UpdateNote(
            string name,
            gv::Note note,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateNote(
                new gv::UpdateNoteRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified note.
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
        public virtual stt::Task<gv::Note> UpdateNoteAsync(
            gv::UpdateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified note.
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
        public virtual stt::Task<gv::Note> UpdateNoteAsync(
            gv::UpdateNoteRequest request,
            st::CancellationToken cancellationToken) => UpdateNoteAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified note.
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
        public virtual gv::Note UpdateNote(
            gv::UpdateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note to list occurrences for in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrencesAsync(
            NoteName name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNoteOccurrencesAsync(
                new gv::ListNoteOccurrencesRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note to list occurrences for in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrences(
            NoteName name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNoteOccurrences(
                new gv::ListNoteOccurrencesRequest
                {
                    NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note to list occurrences for in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrencesAsync(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNoteOccurrencesAsync(
                new gv::ListNoteOccurrencesRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note to list occurrences for in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrences(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListNoteOccurrences(
                new gv::ListNoteOccurrencesRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrencesAsync(
            gv::ListNoteOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrences(
            gv::ListNoteOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to get a vulnerability summary for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(
            ProjectName parent,
            string filter,
            gaxgrpc::CallSettings callSettings = null) => GetVulnerabilityOccurrencesSummaryAsync(
                new gv::GetVulnerabilityOccurrencesSummaryRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to get a vulnerability summary for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(
            ProjectName parent,
            string filter,
            st::CancellationToken cancellationToken) => GetVulnerabilityOccurrencesSummaryAsync(
                parent,
                filter,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to get a vulnerability summary for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::VulnerabilityOccurrencesSummary GetVulnerabilityOccurrencesSummary(
            ProjectName parent,
            string filter,
            gaxgrpc::CallSettings callSettings = null) => GetVulnerabilityOccurrencesSummary(
                new gv::GetVulnerabilityOccurrencesSummaryRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to get a vulnerability summary for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(
            string parent,
            string filter,
            gaxgrpc::CallSettings callSettings = null) => GetVulnerabilityOccurrencesSummaryAsync(
                new gv::GetVulnerabilityOccurrencesSummaryRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to get a vulnerability summary for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gv::VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(
            string parent,
            string filter,
            st::CancellationToken cancellationToken) => GetVulnerabilityOccurrencesSummaryAsync(
                parent,
                filter,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to get a vulnerability summary for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gv::VulnerabilityOccurrencesSummary GetVulnerabilityOccurrencesSummary(
            string parent,
            string filter,
            gaxgrpc::CallSettings callSettings = null) => GetVulnerabilityOccurrencesSummary(
                new gv::GetVulnerabilityOccurrencesSummaryRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
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
        public virtual stt::Task<gv::VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(
            gv::GetVulnerabilityOccurrencesSummaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
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
        public virtual stt::Task<gv::VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(
            gv::GetVulnerabilityOccurrencesSummaryRequest request,
            st::CancellationToken cancellationToken) => GetVulnerabilityOccurrencesSummaryAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
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
        public virtual gv::VulnerabilityOccurrencesSummary GetVulnerabilityOccurrencesSummary(
            gv::GetVulnerabilityOccurrencesSummaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// GrafeasV1Beta1 client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class GrafeasV1Beta1ClientImpl : GrafeasV1Beta1Client
    {
        private readonly gaxgrpc::ApiCall<gv::GetOccurrenceRequest, gv::Occurrence> _callGetOccurrence;
        private readonly gaxgrpc::ApiCall<gv::ListOccurrencesRequest, gv::ListOccurrencesResponse> _callListOccurrences;
        private readonly gaxgrpc::ApiCall<gv::DeleteOccurrenceRequest, pbwkt::Empty> _callDeleteOccurrence;
        private readonly gaxgrpc::ApiCall<gv::CreateOccurrenceRequest, gv::Occurrence> _callCreateOccurrence;
        private readonly gaxgrpc::ApiCall<gv::BatchCreateOccurrencesRequest, gv::BatchCreateOccurrencesResponse> _callBatchCreateOccurrences;
        private readonly gaxgrpc::ApiCall<gv::UpdateOccurrenceRequest, gv::Occurrence> _callUpdateOccurrence;
        private readonly gaxgrpc::ApiCall<gv::GetOccurrenceNoteRequest, gv::Note> _callGetOccurrenceNote;
        private readonly gaxgrpc::ApiCall<gv::GetNoteRequest, gv::Note> _callGetNote;
        private readonly gaxgrpc::ApiCall<gv::ListNotesRequest, gv::ListNotesResponse> _callListNotes;
        private readonly gaxgrpc::ApiCall<gv::DeleteNoteRequest, pbwkt::Empty> _callDeleteNote;
        private readonly gaxgrpc::ApiCall<gv::CreateNoteRequest, gv::Note> _callCreateNote;
        private readonly gaxgrpc::ApiCall<gv::BatchCreateNotesRequest, gv::BatchCreateNotesResponse> _callBatchCreateNotes;
        private readonly gaxgrpc::ApiCall<gv::UpdateNoteRequest, gv::Note> _callUpdateNote;
        private readonly gaxgrpc::ApiCall<gv::ListNoteOccurrencesRequest, gv::ListNoteOccurrencesResponse> _callListNoteOccurrences;
        private readonly gaxgrpc::ApiCall<gv::GetVulnerabilityOccurrencesSummaryRequest, gv::VulnerabilityOccurrencesSummary> _callGetVulnerabilityOccurrencesSummary;

        /// <summary>
        /// Constructs a client wrapper for the GrafeasV1Beta1 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GrafeasV1Beta1Settings"/> used within this client </param>
        public GrafeasV1Beta1ClientImpl(GrafeasV1Beta1.GrafeasV1Beta1Client grpcClient, GrafeasV1Beta1Settings settings)
        {
            GrpcClient = grpcClient;
            GrafeasV1Beta1Settings effectiveSettings = settings ?? GrafeasV1Beta1Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetOccurrence = clientHelper.BuildApiCall<gv::GetOccurrenceRequest, gv::Occurrence>(
                GrpcClient.GetOccurrenceAsync, GrpcClient.GetOccurrence, effectiveSettings.GetOccurrenceSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListOccurrences = clientHelper.BuildApiCall<gv::ListOccurrencesRequest, gv::ListOccurrencesResponse>(
                GrpcClient.ListOccurrencesAsync, GrpcClient.ListOccurrences, effectiveSettings.ListOccurrencesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callDeleteOccurrence = clientHelper.BuildApiCall<gv::DeleteOccurrenceRequest, pbwkt::Empty>(
                GrpcClient.DeleteOccurrenceAsync, GrpcClient.DeleteOccurrence, effectiveSettings.DeleteOccurrenceSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateOccurrence = clientHelper.BuildApiCall<gv::CreateOccurrenceRequest, gv::Occurrence>(
                GrpcClient.CreateOccurrenceAsync, GrpcClient.CreateOccurrence, effectiveSettings.CreateOccurrenceSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callBatchCreateOccurrences = clientHelper.BuildApiCall<gv::BatchCreateOccurrencesRequest, gv::BatchCreateOccurrencesResponse>(
                GrpcClient.BatchCreateOccurrencesAsync, GrpcClient.BatchCreateOccurrences, effectiveSettings.BatchCreateOccurrencesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateOccurrence = clientHelper.BuildApiCall<gv::UpdateOccurrenceRequest, gv::Occurrence>(
                GrpcClient.UpdateOccurrenceAsync, GrpcClient.UpdateOccurrence, effectiveSettings.UpdateOccurrenceSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetOccurrenceNote = clientHelper.BuildApiCall<gv::GetOccurrenceNoteRequest, gv::Note>(
                GrpcClient.GetOccurrenceNoteAsync, GrpcClient.GetOccurrenceNote, effectiveSettings.GetOccurrenceNoteSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetNote = clientHelper.BuildApiCall<gv::GetNoteRequest, gv::Note>(
                GrpcClient.GetNoteAsync, GrpcClient.GetNote, effectiveSettings.GetNoteSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListNotes = clientHelper.BuildApiCall<gv::ListNotesRequest, gv::ListNotesResponse>(
                GrpcClient.ListNotesAsync, GrpcClient.ListNotes, effectiveSettings.ListNotesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callDeleteNote = clientHelper.BuildApiCall<gv::DeleteNoteRequest, pbwkt::Empty>(
                GrpcClient.DeleteNoteAsync, GrpcClient.DeleteNote, effectiveSettings.DeleteNoteSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateNote = clientHelper.BuildApiCall<gv::CreateNoteRequest, gv::Note>(
                GrpcClient.CreateNoteAsync, GrpcClient.CreateNote, effectiveSettings.CreateNoteSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callBatchCreateNotes = clientHelper.BuildApiCall<gv::BatchCreateNotesRequest, gv::BatchCreateNotesResponse>(
                GrpcClient.BatchCreateNotesAsync, GrpcClient.BatchCreateNotes, effectiveSettings.BatchCreateNotesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateNote = clientHelper.BuildApiCall<gv::UpdateNoteRequest, gv::Note>(
                GrpcClient.UpdateNoteAsync, GrpcClient.UpdateNote, effectiveSettings.UpdateNoteSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListNoteOccurrences = clientHelper.BuildApiCall<gv::ListNoteOccurrencesRequest, gv::ListNoteOccurrencesResponse>(
                GrpcClient.ListNoteOccurrencesAsync, GrpcClient.ListNoteOccurrences, effectiveSettings.ListNoteOccurrencesSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetVulnerabilityOccurrencesSummary = clientHelper.BuildApiCall<gv::GetVulnerabilityOccurrencesSummaryRequest, gv::VulnerabilityOccurrencesSummary>(
                GrpcClient.GetVulnerabilityOccurrencesSummaryAsync, GrpcClient.GetVulnerabilityOccurrencesSummary, effectiveSettings.GetVulnerabilityOccurrencesSummarySettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGetOccurrence);
            Modify_GetOccurrenceApiCall(ref _callGetOccurrence);
            Modify_ApiCall(ref _callListOccurrences);
            Modify_ListOccurrencesApiCall(ref _callListOccurrences);
            Modify_ApiCall(ref _callDeleteOccurrence);
            Modify_DeleteOccurrenceApiCall(ref _callDeleteOccurrence);
            Modify_ApiCall(ref _callCreateOccurrence);
            Modify_CreateOccurrenceApiCall(ref _callCreateOccurrence);
            Modify_ApiCall(ref _callBatchCreateOccurrences);
            Modify_BatchCreateOccurrencesApiCall(ref _callBatchCreateOccurrences);
            Modify_ApiCall(ref _callUpdateOccurrence);
            Modify_UpdateOccurrenceApiCall(ref _callUpdateOccurrence);
            Modify_ApiCall(ref _callGetOccurrenceNote);
            Modify_GetOccurrenceNoteApiCall(ref _callGetOccurrenceNote);
            Modify_ApiCall(ref _callGetNote);
            Modify_GetNoteApiCall(ref _callGetNote);
            Modify_ApiCall(ref _callListNotes);
            Modify_ListNotesApiCall(ref _callListNotes);
            Modify_ApiCall(ref _callDeleteNote);
            Modify_DeleteNoteApiCall(ref _callDeleteNote);
            Modify_ApiCall(ref _callCreateNote);
            Modify_CreateNoteApiCall(ref _callCreateNote);
            Modify_ApiCall(ref _callBatchCreateNotes);
            Modify_BatchCreateNotesApiCall(ref _callBatchCreateNotes);
            Modify_ApiCall(ref _callUpdateNote);
            Modify_UpdateNoteApiCall(ref _callUpdateNote);
            Modify_ApiCall(ref _callListNoteOccurrences);
            Modify_ListNoteOccurrencesApiCall(ref _callListNoteOccurrences);
            Modify_ApiCall(ref _callGetVulnerabilityOccurrencesSummary);
            Modify_GetVulnerabilityOccurrencesSummaryApiCall(ref _callGetVulnerabilityOccurrencesSummary);
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
        partial void Modify_GetOccurrenceApiCall(ref gaxgrpc::ApiCall<gv::GetOccurrenceRequest, gv::Occurrence> call);
        partial void Modify_ListOccurrencesApiCall(ref gaxgrpc::ApiCall<gv::ListOccurrencesRequest, gv::ListOccurrencesResponse> call);
        partial void Modify_DeleteOccurrenceApiCall(ref gaxgrpc::ApiCall<gv::DeleteOccurrenceRequest, pbwkt::Empty> call);
        partial void Modify_CreateOccurrenceApiCall(ref gaxgrpc::ApiCall<gv::CreateOccurrenceRequest, gv::Occurrence> call);
        partial void Modify_BatchCreateOccurrencesApiCall(ref gaxgrpc::ApiCall<gv::BatchCreateOccurrencesRequest, gv::BatchCreateOccurrencesResponse> call);
        partial void Modify_UpdateOccurrenceApiCall(ref gaxgrpc::ApiCall<gv::UpdateOccurrenceRequest, gv::Occurrence> call);
        partial void Modify_GetOccurrenceNoteApiCall(ref gaxgrpc::ApiCall<gv::GetOccurrenceNoteRequest, gv::Note> call);
        partial void Modify_GetNoteApiCall(ref gaxgrpc::ApiCall<gv::GetNoteRequest, gv::Note> call);
        partial void Modify_ListNotesApiCall(ref gaxgrpc::ApiCall<gv::ListNotesRequest, gv::ListNotesResponse> call);
        partial void Modify_DeleteNoteApiCall(ref gaxgrpc::ApiCall<gv::DeleteNoteRequest, pbwkt::Empty> call);
        partial void Modify_CreateNoteApiCall(ref gaxgrpc::ApiCall<gv::CreateNoteRequest, gv::Note> call);
        partial void Modify_BatchCreateNotesApiCall(ref gaxgrpc::ApiCall<gv::BatchCreateNotesRequest, gv::BatchCreateNotesResponse> call);
        partial void Modify_UpdateNoteApiCall(ref gaxgrpc::ApiCall<gv::UpdateNoteRequest, gv::Note> call);
        partial void Modify_ListNoteOccurrencesApiCall(ref gaxgrpc::ApiCall<gv::ListNoteOccurrencesRequest, gv::ListNoteOccurrencesResponse> call);
        partial void Modify_GetVulnerabilityOccurrencesSummaryApiCall(ref gaxgrpc::ApiCall<gv::GetVulnerabilityOccurrencesSummaryRequest, gv::VulnerabilityOccurrencesSummary> call);
        partial void OnConstruction(GrafeasV1Beta1.GrafeasV1Beta1Client grpcClient, GrafeasV1Beta1Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC GrafeasV1Beta1 client.
        /// </summary>
        public override GrafeasV1Beta1.GrafeasV1Beta1Client GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetOccurrenceRequest(ref gv::GetOccurrenceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListOccurrencesRequest(ref gv::ListOccurrencesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteOccurrenceRequest(ref gv::DeleteOccurrenceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateOccurrenceRequest(ref gv::CreateOccurrenceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchCreateOccurrencesRequest(ref gv::BatchCreateOccurrencesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateOccurrenceRequest(ref gv::UpdateOccurrenceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetOccurrenceNoteRequest(ref gv::GetOccurrenceNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetNoteRequest(ref gv::GetNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListNotesRequest(ref gv::ListNotesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteNoteRequest(ref gv::DeleteNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateNoteRequest(ref gv::CreateNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchCreateNotesRequest(ref gv::BatchCreateNotesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateNoteRequest(ref gv::UpdateNoteRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListNoteOccurrencesRequest(ref gv::ListNoteOccurrencesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetVulnerabilityOccurrencesSummaryRequest(ref gv::GetVulnerabilityOccurrencesSummaryRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the specified occurrence.
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
        public override stt::Task<gv::Occurrence> GetOccurrenceAsync(
            gv::GetOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOccurrenceRequest(ref request, ref callSettings);
            return _callGetOccurrence.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the specified occurrence.
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
        public override gv::Occurrence GetOccurrence(
            gv::GetOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOccurrenceRequest(ref request, ref callSettings);
            return _callGetOccurrence.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrencesAsync(
            gv::ListOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<gv::ListOccurrencesRequest, gv::ListOccurrencesResponse, gv::Occurrence>(_callListOccurrences, request, callSettings);
        }

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<gv::ListOccurrencesResponse, gv::Occurrence> ListOccurrences(
            gv::ListOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<gv::ListOccurrencesRequest, gv::ListOccurrencesResponse, gv::Occurrence>(_callListOccurrences, request, callSettings);
        }

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
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
        public override stt::Task DeleteOccurrenceAsync(
            gv::DeleteOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOccurrenceRequest(ref request, ref callSettings);
            return _callDeleteOccurrence.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteOccurrence(
            gv::DeleteOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOccurrenceRequest(ref request, ref callSettings);
            _callDeleteOccurrence.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new occurrence.
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
        public override stt::Task<gv::Occurrence> CreateOccurrenceAsync(
            gv::CreateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOccurrenceRequest(ref request, ref callSettings);
            return _callCreateOccurrence.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new occurrence.
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
        public override gv::Occurrence CreateOccurrence(
            gv::CreateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOccurrenceRequest(ref request, ref callSettings);
            return _callCreateOccurrence.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates new occurrences in batch.
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
        public override stt::Task<gv::BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(
            gv::BatchCreateOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateOccurrencesRequest(ref request, ref callSettings);
            return _callBatchCreateOccurrences.Async(request, callSettings);
        }

        /// <summary>
        /// Creates new occurrences in batch.
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
        public override gv::BatchCreateOccurrencesResponse BatchCreateOccurrences(
            gv::BatchCreateOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateOccurrencesRequest(ref request, ref callSettings);
            return _callBatchCreateOccurrences.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified occurrence.
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
        public override stt::Task<gv::Occurrence> UpdateOccurrenceAsync(
            gv::UpdateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOccurrenceRequest(ref request, ref callSettings);
            return _callUpdateOccurrence.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified occurrence.
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
        public override gv::Occurrence UpdateOccurrence(
            gv::UpdateOccurrenceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOccurrenceRequest(ref request, ref callSettings);
            return _callUpdateOccurrence.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
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
        public override stt::Task<gv::Note> GetOccurrenceNoteAsync(
            gv::GetOccurrenceNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOccurrenceNoteRequest(ref request, ref callSettings);
            return _callGetOccurrenceNote.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
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
        public override gv::Note GetOccurrenceNote(
            gv::GetOccurrenceNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOccurrenceNoteRequest(ref request, ref callSettings);
            return _callGetOccurrenceNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified note.
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
        public override stt::Task<gv::Note> GetNoteAsync(
            gv::GetNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNoteRequest(ref request, ref callSettings);
            return _callGetNote.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the specified note.
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
        public override gv::Note GetNote(
            gv::GetNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNoteRequest(ref request, ref callSettings);
            return _callGetNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<gv::ListNotesResponse, gv::Note> ListNotesAsync(
            gv::ListNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<gv::ListNotesRequest, gv::ListNotesResponse, gv::Note>(_callListNotes, request, callSettings);
        }

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gv::Note"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<gv::ListNotesResponse, gv::Note> ListNotes(
            gv::ListNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<gv::ListNotesRequest, gv::ListNotesResponse, gv::Note>(_callListNotes, request, callSettings);
        }

        /// <summary>
        /// Deletes the specified note.
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
        public override stt::Task DeleteNoteAsync(
            gv::DeleteNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNoteRequest(ref request, ref callSettings);
            return _callDeleteNote.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteNote(
            gv::DeleteNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNoteRequest(ref request, ref callSettings);
            _callDeleteNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new note.
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
        public override stt::Task<gv::Note> CreateNoteAsync(
            gv::CreateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNoteRequest(ref request, ref callSettings);
            return _callCreateNote.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new note.
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
        public override gv::Note CreateNote(
            gv::CreateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNoteRequest(ref request, ref callSettings);
            return _callCreateNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates new notes in batch.
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
        public override stt::Task<gv::BatchCreateNotesResponse> BatchCreateNotesAsync(
            gv::BatchCreateNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateNotesRequest(ref request, ref callSettings);
            return _callBatchCreateNotes.Async(request, callSettings);
        }

        /// <summary>
        /// Creates new notes in batch.
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
        public override gv::BatchCreateNotesResponse BatchCreateNotes(
            gv::BatchCreateNotesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateNotesRequest(ref request, ref callSettings);
            return _callBatchCreateNotes.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified note.
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
        public override stt::Task<gv::Note> UpdateNoteAsync(
            gv::UpdateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNoteRequest(ref request, ref callSettings);
            return _callUpdateNote.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified note.
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
        public override gv::Note UpdateNote(
            gv::UpdateNoteRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNoteRequest(ref request, ref callSettings);
            return _callUpdateNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrencesAsync(
            gv::ListNoteOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNoteOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<gv::ListNoteOccurrencesRequest, gv::ListNoteOccurrencesResponse, gv::Occurrence>(_callListNoteOccurrences, request, callSettings);
        }

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gv::Occurrence"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<gv::ListNoteOccurrencesResponse, gv::Occurrence> ListNoteOccurrences(
            gv::ListNoteOccurrencesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNoteOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<gv::ListNoteOccurrencesRequest, gv::ListNoteOccurrencesResponse, gv::Occurrence>(_callListNoteOccurrences, request, callSettings);
        }

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
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
        public override stt::Task<gv::VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(
            gv::GetVulnerabilityOccurrencesSummaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVulnerabilityOccurrencesSummaryRequest(ref request, ref callSettings);
            return _callGetVulnerabilityOccurrencesSummary.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
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
        public override gv::VulnerabilityOccurrencesSummary GetVulnerabilityOccurrencesSummary(
            gv::GetVulnerabilityOccurrencesSummaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVulnerabilityOccurrencesSummaryRequest(ref request, ref callSettings);
            return _callGetVulnerabilityOccurrencesSummary.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class gv::ListOccurrencesRequest : gaxgrpc::IPageRequest { }
    public partial class gv::ListOccurrencesResponse : gaxgrpc::IPageResponse<gv::Occurrence>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<gv::Occurrence> GetEnumerator() => Occurrences.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class gv::ListNotesRequest : gaxgrpc::IPageRequest { }
    public partial class gv::ListNotesResponse : gaxgrpc::IPageResponse<gv::Note>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<gv::Note> GetEnumerator() => Notes.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class gv::ListNoteOccurrencesRequest : gaxgrpc::IPageRequest { }
    public partial class gv::ListNoteOccurrencesResponse : gaxgrpc::IPageResponse<gv::Occurrence>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<gv::Occurrence> GetEnumerator() => Occurrences.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
