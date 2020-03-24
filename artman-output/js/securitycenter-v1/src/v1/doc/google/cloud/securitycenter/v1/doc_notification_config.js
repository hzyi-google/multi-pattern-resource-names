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

// Note: this file is purely for documentation. Any contents are not expected
// to be loaded as the JS file.

/**
 * Cloud Security Command Center (Cloud SCC) notification configs.
 *
 * A notification config is a Cloud SCC resource that contains the configuration
 * to send notifications for create/update events of findings, assets and etc.
 *
 * @property {string} name
 *   The relative resource name of this notification config. See:
 *   https://cloud.google.com/apis/design/resource_names#relative_resource_name
 *   Example:
 *   "organizations/{organization_id}/notificationConfigs/notify_public_bucket".
 *
 * @property {string} description
 *   The description of the notification config (max of 1024 characters).
 *
 * @property {string} pubsubTopic
 *   The PubSub topic to send notifications to. Its format is
 *   "projects/[project_id]/topics/[topic]".
 *
 * @property {string} serviceAccount
 *   Output only. The service account that needs "pubsub.topics.publish"
 *   permission to publish to the PubSub topic.
 *
 * @property {Object} streamingConfig
 *   The config for triggering streaming-based notifications.
 *
 *   This object should have the same structure as [StreamingConfig]{@link google.cloud.securitycenter.v1.StreamingConfig}
 *
 * @typedef NotificationConfig
 * @memberof google.cloud.securitycenter.v1
 * @see [google.cloud.securitycenter.v1.NotificationConfig definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/cloud/securitycenter/v1/notification_config.proto}
 */
const NotificationConfig = {
  // This is for documentation. Actual contents will be loaded by gRPC.

  /**
   * The config for streaming-based notifications, which send each event as soon
   * as it is detected.
   *
   * @property {string} filter
   *   Expression that defines the filter to apply across create/update events
   *   of assets or findings as specified by the event type. The expression is a
   *   list of zero or more restrictions combined via logical operators `AND`
   *   and `OR`. Parentheses are supported, and `OR` has higher precedence than
   *   `AND`.
   *
   *   Restrictions have the form `<field> <operator> <value>` and may have a
   *   `-` character in front of them to indicate negation. The fields map to
   *   those defined in the corresponding resource.
   *
   *   The supported operators are:
   *
   *   * `=` for all value types.
   *   * `>`, `<`, `>=`, `<=` for integer values.
   *   * `:`, meaning substring matching, for strings.
   *
   *   The supported value types are:
   *
   *   * string literals in quotes.
   *   * integer literals without quotes.
   *   * boolean literals `true` and `false` without quotes.
   *
   * @typedef StreamingConfig
   * @memberof google.cloud.securitycenter.v1
   * @see [google.cloud.securitycenter.v1.NotificationConfig.StreamingConfig definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/cloud/securitycenter/v1/notification_config.proto}
   */
  StreamingConfig: {
    // This is for documentation. Actual contents will be loaded by gRPC.
  }
};