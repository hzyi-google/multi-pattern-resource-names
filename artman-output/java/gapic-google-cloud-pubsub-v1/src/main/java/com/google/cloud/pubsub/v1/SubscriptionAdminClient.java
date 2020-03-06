/*
 * Copyright 2020 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package com.google.cloud.pubsub.v1;

import com.google.api.core.ApiFunction;
import com.google.api.core.ApiFuture;
import com.google.api.core.ApiFutures;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.paging.AbstractFixedSizeCollection;
import com.google.api.gax.paging.AbstractPage;
import com.google.api.gax.paging.AbstractPagedListResponse;
import com.google.api.gax.rpc.BidiStreamingCallable;
import com.google.api.gax.rpc.PageContext;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.pubsub.v1.stub.SubscriberStub;
import com.google.cloud.pubsub.v1.stub.SubscriberStubSettings;
import com.google.common.util.concurrent.MoreExecutors;
import com.google.iam.v1.GetIamPolicyRequest;
import com.google.iam.v1.Policy;
import com.google.iam.v1.SetIamPolicyRequest;
import com.google.iam.v1.TestIamPermissionsRequest;
import com.google.iam.v1.TestIamPermissionsResponse;
import com.google.protobuf.Empty;
import com.google.pubsub.v1.AcknowledgeRequest;
import com.google.pubsub.v1.CreateSnapshotRequest;
import com.google.pubsub.v1.DeleteSnapshotRequest;
import com.google.pubsub.v1.DeleteSubscriptionRequest;
import com.google.pubsub.v1.GetSubscriptionRequest;
import com.google.pubsub.v1.ListSnapshotsRequest;
import com.google.pubsub.v1.ListSnapshotsResponse;
import com.google.pubsub.v1.ListSubscriptionsRequest;
import com.google.pubsub.v1.ListSubscriptionsResponse;
import com.google.pubsub.v1.ModifyAckDeadlineRequest;
import com.google.pubsub.v1.ModifyPushConfigRequest;
import com.google.pubsub.v1.ProjectName;
import com.google.pubsub.v1.ProjectSnapshotName;
import com.google.pubsub.v1.ProjectSubscriptionName;
import com.google.pubsub.v1.PullRequest;
import com.google.pubsub.v1.PullResponse;
import com.google.pubsub.v1.PushConfig;
import com.google.pubsub.v1.SeekRequest;
import com.google.pubsub.v1.SeekResponse;
import com.google.pubsub.v1.Snapshot;
import com.google.pubsub.v1.StreamingPullRequest;
import com.google.pubsub.v1.StreamingPullResponse;
import com.google.pubsub.v1.Subscription;
import com.google.pubsub.v1.TopicName;
import com.google.pubsub.v1.UpdateSnapshotRequest;
import com.google.pubsub.v1.UpdateSubscriptionRequest;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND SERVICE
/**
 * Service Description: The service that an application uses to manipulate subscriptions and to
 * consume messages from a subscription via the `Pull` method or by establishing a bi-directional
 * stream using the `StreamingPull` method.
 *
 * <p>To retrieve messages from a subscription, see the Subscriber class.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>
 * <code>
 * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
 *   String formattedName = ProjectSubscriptionName.format("[PROJECT]", "[SUBSCRIPTION]");
 *   TopicName topic = TopicName.ofDeletedTopicName();
 *   PushConfig pushConfig = PushConfig.newBuilder().build();
 *   int ackDeadlineSeconds = 0;
 *   Subscription response = subscriptionAdminClient.createSubscription(formattedName, topic, pushConfig, ackDeadlineSeconds);
 * }
 * </code>
 * </pre>
 *
 * <p>Note: close() needs to be called on the subscriptionAdminClient object to clean up resources
 * such as threads. In the example above, try-with-resources is used, which automatically calls
 * close().
 *
 * <p>The surface of this class includes several types of Java methods for each of the API's
 * methods:
 *
 * <ol>
 *   <li> A "flattened" method. With this type of method, the fields of the request type have been
 *       converted into function parameters. It may be the case that not all fields are available as
 *       parameters, and not every API method will have a flattened method entry point.
 *   <li> A "request object" method. This type of method only takes one parameter, a request object,
 *       which must be constructed before the call. Not every API method will have a request object
 *       method.
 *   <li> A "callable" method. This type of method takes no parameters and returns an immutable API
 *       callable object, which can be used to initiate calls to the service.
 * </ol>
 *
 * <p>See the individual methods for example code.
 *
 * <p>Many parameters require resource names to be formatted in a particular way. To assist with
 * these names, this class includes a format method for each type of name, and additionally a parse
 * method to extract the individual identifiers contained within names that are returned.
 *
 * <p>This class can be customized by passing in a custom instance of SubscriptionAdminSettings to
 * create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>
 * <code>
 * SubscriptionAdminSettings subscriptionAdminSettings =
 *     SubscriptionAdminSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * SubscriptionAdminClient subscriptionAdminClient =
 *     SubscriptionAdminClient.create(subscriptionAdminSettings);
 * </code>
 * </pre>
 *
 * To customize the endpoint:
 *
 * <pre>
 * <code>
 * SubscriptionAdminSettings subscriptionAdminSettings =
 *     SubscriptionAdminSettings.newBuilder().setEndpoint(myEndpoint).build();
 * SubscriptionAdminClient subscriptionAdminClient =
 *     SubscriptionAdminClient.create(subscriptionAdminSettings);
 * </code>
 * </pre>
 */
@Generated("by gapic-generator")
public class SubscriptionAdminClient implements BackgroundResource {
  private final SubscriptionAdminSettings settings;
  private final SubscriberStub stub;

  /** Constructs an instance of SubscriptionAdminClient with default settings. */
  public static final SubscriptionAdminClient create() throws IOException {
    return create(SubscriptionAdminSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of SubscriptionAdminClient, using the given settings. The channels are
   * created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final SubscriptionAdminClient create(SubscriptionAdminSettings settings)
      throws IOException {
    return new SubscriptionAdminClient(settings);
  }

  /**
   * Constructs an instance of SubscriptionAdminClient, using the given stub for making calls. This
   * is for advanced usage - prefer to use SubscriptionAdminSettings}.
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final SubscriptionAdminClient create(SubscriberStub stub) {
    return new SubscriptionAdminClient(stub);
  }

  /**
   * Constructs an instance of SubscriptionAdminClient, using the given settings. This is protected
   * so that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected SubscriptionAdminClient(SubscriptionAdminSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((SubscriberStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected SubscriptionAdminClient(SubscriberStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final SubscriptionAdminSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public SubscriberStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Creates a subscription to a given topic. See the &lt;a
   * href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt; resource name
   * rules&lt;/a&gt;. If the subscription already exists, returns `ALREADY_EXISTS`. If the
   * corresponding topic doesn't exist, returns `NOT_FOUND`.
   *
   * <p>If the name is not provided in the request, the server will assign a random name for this
   * subscription on the same project as the topic, conforming to the [resource name
   * format](https://cloud.google.com/pubsub/docs/admin#resource_names). The generated name is
   * populated in the returned Subscription object. Note that for REST API requests, you must
   * specify a name in the request.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   String formattedName = ProjectSubscriptionName.format("[PROJECT]", "[SUBSCRIPTION]");
   *   TopicName topic = TopicName.ofDeletedTopicName();
   *   PushConfig pushConfig = PushConfig.newBuilder().build();
   *   int ackDeadlineSeconds = 0;
   *   Subscription response = subscriptionAdminClient.createSubscription(formattedName, topic, pushConfig, ackDeadlineSeconds);
   * }
   * </code></pre>
   *
   * @param name Required. The name of the subscription. It must have the format
   *     `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must start with a
   *     letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores
   *     (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3
   *     and 255 characters in length, and it must not start with `"goog"`.
   * @param topic Required. The name of the topic from which this subscription is receiving
   *     messages. Format is `projects/{project}/topics/{topic}`. The value of this field will be
   *     `_deleted-topic_` if the topic has been deleted.
   * @param pushConfig If push delivery is used with this subscription, this field is used to
   *     configure it. An empty `pushConfig` signifies that the subscriber will pull and ack
   *     messages using API methods.
   * @param ackDeadlineSeconds The approximate amount of time (on a best-effort basis) Pub/Sub waits
   *     for the subscriber to acknowledge receipt before resending the message. In the interval
   *     after the message is delivered and before it is acknowledged, it is considered to be
   *     &lt;i&gt;outstanding&lt;/i&gt;. During that time period, the message will not be
   *     redelivered (on a best-effort basis).
   *     <p>For pull subscriptions, this value is used as the initial value for the ack deadline. To
   *     override this value for a given message, call `ModifyAckDeadline` with the corresponding
   *     `ack_id` if using non-streaming pull or send the `ack_id` in a
   *     `StreamingModifyAckDeadlineRequest` if using streaming pull. The minimum custom deadline
   *     you can specify is 10 seconds. The maximum custom deadline you can specify is 600 seconds
   *     (10 minutes). If this parameter is 0, a default value of 10 seconds is used.
   *     <p>For push delivery, this value is also used to set the request timeout for the call to
   *     the push endpoint.
   *     <p>If the subscriber never acknowledges the message, the Pub/Sub system will eventually
   *     redeliver the message.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Subscription createSubscription(
      String name, TopicName topic, PushConfig pushConfig, int ackDeadlineSeconds) {
    Subscription request =
        Subscription.newBuilder()
            .setName(name)
            .setTopic(topic == null ? null : topic.toString())
            .setPushConfig(pushConfig)
            .setAckDeadlineSeconds(ackDeadlineSeconds)
            .build();
    return createSubscription(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Creates a subscription to a given topic. See the &lt;a
   * href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt; resource name
   * rules&lt;/a&gt;. If the subscription already exists, returns `ALREADY_EXISTS`. If the
   * corresponding topic doesn't exist, returns `NOT_FOUND`.
   *
   * <p>If the name is not provided in the request, the server will assign a random name for this
   * subscription on the same project as the topic, conforming to the [resource name
   * format](https://cloud.google.com/pubsub/docs/admin#resource_names). The generated name is
   * populated in the returned Subscription object. Note that for REST API requests, you must
   * specify a name in the request.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   String formattedName = ProjectSubscriptionName.format("[PROJECT]", "[SUBSCRIPTION]");
   *   TopicName topic = TopicName.ofDeletedTopicName();
   *   PushConfig pushConfig = PushConfig.newBuilder().build();
   *   int ackDeadlineSeconds = 0;
   *   Subscription response = subscriptionAdminClient.createSubscription(formattedName, topic.toString(), pushConfig, ackDeadlineSeconds);
   * }
   * </code></pre>
   *
   * @param name Required. The name of the subscription. It must have the format
   *     `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must start with a
   *     letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores
   *     (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3
   *     and 255 characters in length, and it must not start with `"goog"`.
   * @param topic Required. The name of the topic from which this subscription is receiving
   *     messages. Format is `projects/{project}/topics/{topic}`. The value of this field will be
   *     `_deleted-topic_` if the topic has been deleted.
   * @param pushConfig If push delivery is used with this subscription, this field is used to
   *     configure it. An empty `pushConfig` signifies that the subscriber will pull and ack
   *     messages using API methods.
   * @param ackDeadlineSeconds The approximate amount of time (on a best-effort basis) Pub/Sub waits
   *     for the subscriber to acknowledge receipt before resending the message. In the interval
   *     after the message is delivered and before it is acknowledged, it is considered to be
   *     &lt;i&gt;outstanding&lt;/i&gt;. During that time period, the message will not be
   *     redelivered (on a best-effort basis).
   *     <p>For pull subscriptions, this value is used as the initial value for the ack deadline. To
   *     override this value for a given message, call `ModifyAckDeadline` with the corresponding
   *     `ack_id` if using non-streaming pull or send the `ack_id` in a
   *     `StreamingModifyAckDeadlineRequest` if using streaming pull. The minimum custom deadline
   *     you can specify is 10 seconds. The maximum custom deadline you can specify is 600 seconds
   *     (10 minutes). If this parameter is 0, a default value of 10 seconds is used.
   *     <p>For push delivery, this value is also used to set the request timeout for the call to
   *     the push endpoint.
   *     <p>If the subscriber never acknowledges the message, the Pub/Sub system will eventually
   *     redeliver the message.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Subscription createSubscription(
      String name, String topic, PushConfig pushConfig, int ackDeadlineSeconds) {
    Subscription request =
        Subscription.newBuilder()
            .setName(name)
            .setTopic(topic)
            .setPushConfig(pushConfig)
            .setAckDeadlineSeconds(ackDeadlineSeconds)
            .build();
    return createSubscription(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Creates a subscription to a given topic. See the &lt;a
   * href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt; resource name
   * rules&lt;/a&gt;. If the subscription already exists, returns `ALREADY_EXISTS`. If the
   * corresponding topic doesn't exist, returns `NOT_FOUND`.
   *
   * <p>If the name is not provided in the request, the server will assign a random name for this
   * subscription on the same project as the topic, conforming to the [resource name
   * format](https://cloud.google.com/pubsub/docs/admin#resource_names). The generated name is
   * populated in the returned Subscription object. Note that for REST API requests, you must
   * specify a name in the request.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName name = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   TopicName topic = TopicName.ofDeletedTopicName();
   *   Subscription request = Subscription.newBuilder()
   *     .setName(name.toString())
   *     .setTopic(topic.toString())
   *     .build();
   *   Subscription response = subscriptionAdminClient.createSubscription(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Subscription createSubscription(Subscription request) {
    return createSubscriptionCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Creates a subscription to a given topic. See the &lt;a
   * href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt; resource name
   * rules&lt;/a&gt;. If the subscription already exists, returns `ALREADY_EXISTS`. If the
   * corresponding topic doesn't exist, returns `NOT_FOUND`.
   *
   * <p>If the name is not provided in the request, the server will assign a random name for this
   * subscription on the same project as the topic, conforming to the [resource name
   * format](https://cloud.google.com/pubsub/docs/admin#resource_names). The generated name is
   * populated in the returned Subscription object. Note that for REST API requests, you must
   * specify a name in the request.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName name = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   TopicName topic = TopicName.ofDeletedTopicName();
   *   Subscription request = Subscription.newBuilder()
   *     .setName(name.toString())
   *     .setTopic(topic.toString())
   *     .build();
   *   ApiFuture&lt;Subscription&gt; future = subscriptionAdminClient.createSubscriptionCallable().futureCall(request);
   *   // Do something
   *   Subscription response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<Subscription, Subscription> createSubscriptionCallable() {
    return stub.createSubscriptionCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Gets the configuration details of a subscription.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   Subscription response = subscriptionAdminClient.getSubscription(subscription);
   * }
   * </code></pre>
   *
   * @param subscription Required. The name of the subscription to get. Format is
   *     `projects/{project}/subscriptions/{sub}`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Subscription getSubscription(ProjectSubscriptionName subscription) {
    GetSubscriptionRequest request =
        GetSubscriptionRequest.newBuilder()
            .setSubscription(subscription == null ? null : subscription.toString())
            .build();
    return getSubscription(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Gets the configuration details of a subscription.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   Subscription response = subscriptionAdminClient.getSubscription(subscription.toString());
   * }
   * </code></pre>
   *
   * @param subscription Required. The name of the subscription to get. Format is
   *     `projects/{project}/subscriptions/{sub}`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Subscription getSubscription(String subscription) {
    GetSubscriptionRequest request =
        GetSubscriptionRequest.newBuilder().setSubscription(subscription).build();
    return getSubscription(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Gets the configuration details of a subscription.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   GetSubscriptionRequest request = GetSubscriptionRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .build();
   *   Subscription response = subscriptionAdminClient.getSubscription(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Subscription getSubscription(GetSubscriptionRequest request) {
    return getSubscriptionCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Gets the configuration details of a subscription.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   GetSubscriptionRequest request = GetSubscriptionRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .build();
   *   ApiFuture&lt;Subscription&gt; future = subscriptionAdminClient.getSubscriptionCallable().futureCall(request);
   *   // Do something
   *   Subscription response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<GetSubscriptionRequest, Subscription> getSubscriptionCallable() {
    return stub.getSubscriptionCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Updates an existing subscription. Note that certain properties of a subscription, such as its
   * topic, are not modifiable.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   int ackDeadlineSeconds = 42;
   *   Subscription subscription = Subscription.newBuilder()
   *     .setAckDeadlineSeconds(ackDeadlineSeconds)
   *     .build();
   *   String pathsElement = "ack_deadline_seconds";
   *   List&lt;String&gt; paths = Arrays.asList(pathsElement);
   *   FieldMask updateMask = FieldMask.newBuilder()
   *     .addAllPaths(paths)
   *     .build();
   *   UpdateSubscriptionRequest request = UpdateSubscriptionRequest.newBuilder()
   *     .setSubscription(subscription)
   *     .setUpdateMask(updateMask)
   *     .build();
   *   Subscription response = subscriptionAdminClient.updateSubscription(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Subscription updateSubscription(UpdateSubscriptionRequest request) {
    return updateSubscriptionCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Updates an existing subscription. Note that certain properties of a subscription, such as its
   * topic, are not modifiable.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   int ackDeadlineSeconds = 42;
   *   Subscription subscription = Subscription.newBuilder()
   *     .setAckDeadlineSeconds(ackDeadlineSeconds)
   *     .build();
   *   String pathsElement = "ack_deadline_seconds";
   *   List&lt;String&gt; paths = Arrays.asList(pathsElement);
   *   FieldMask updateMask = FieldMask.newBuilder()
   *     .addAllPaths(paths)
   *     .build();
   *   UpdateSubscriptionRequest request = UpdateSubscriptionRequest.newBuilder()
   *     .setSubscription(subscription)
   *     .setUpdateMask(updateMask)
   *     .build();
   *   ApiFuture&lt;Subscription&gt; future = subscriptionAdminClient.updateSubscriptionCallable().futureCall(request);
   *   // Do something
   *   Subscription response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<UpdateSubscriptionRequest, Subscription> updateSubscriptionCallable() {
    return stub.updateSubscriptionCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Lists matching subscriptions.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectName project = ProjectName.of("[PROJECT]");
   *   for (Subscription element : subscriptionAdminClient.listSubscriptions(project).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * </code></pre>
   *
   * @param project Required. The name of the project in which to list subscriptions. Format is
   *     `projects/{project-id}`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListSubscriptionsPagedResponse listSubscriptions(ProjectName project) {
    ListSubscriptionsRequest request =
        ListSubscriptionsRequest.newBuilder()
            .setProject(project == null ? null : project.toString())
            .build();
    return listSubscriptions(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Lists matching subscriptions.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectName project = ProjectName.of("[PROJECT]");
   *   for (Subscription element : subscriptionAdminClient.listSubscriptions(project.toString()).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * </code></pre>
   *
   * @param project Required. The name of the project in which to list subscriptions. Format is
   *     `projects/{project-id}`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListSubscriptionsPagedResponse listSubscriptions(String project) {
    ListSubscriptionsRequest request =
        ListSubscriptionsRequest.newBuilder().setProject(project).build();
    return listSubscriptions(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Lists matching subscriptions.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectName project = ProjectName.of("[PROJECT]");
   *   ListSubscriptionsRequest request = ListSubscriptionsRequest.newBuilder()
   *     .setProject(project.toString())
   *     .build();
   *   for (Subscription element : subscriptionAdminClient.listSubscriptions(request).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListSubscriptionsPagedResponse listSubscriptions(ListSubscriptionsRequest request) {
    return listSubscriptionsPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Lists matching subscriptions.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectName project = ProjectName.of("[PROJECT]");
   *   ListSubscriptionsRequest request = ListSubscriptionsRequest.newBuilder()
   *     .setProject(project.toString())
   *     .build();
   *   ApiFuture&lt;ListSubscriptionsPagedResponse&gt; future = subscriptionAdminClient.listSubscriptionsPagedCallable().futureCall(request);
   *   // Do something
   *   for (Subscription element : future.get().iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * </code></pre>
   */
  public final UnaryCallable<ListSubscriptionsRequest, ListSubscriptionsPagedResponse>
      listSubscriptionsPagedCallable() {
    return stub.listSubscriptionsPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Lists matching subscriptions.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectName project = ProjectName.of("[PROJECT]");
   *   ListSubscriptionsRequest request = ListSubscriptionsRequest.newBuilder()
   *     .setProject(project.toString())
   *     .build();
   *   while (true) {
   *     ListSubscriptionsResponse response = subscriptionAdminClient.listSubscriptionsCallable().call(request);
   *     for (Subscription element : response.getSubscriptionsList()) {
   *       // doThingsWith(element);
   *     }
   *     String nextPageToken = response.getNextPageToken();
   *     if (!Strings.isNullOrEmpty(nextPageToken)) {
   *       request = request.toBuilder().setPageToken(nextPageToken).build();
   *     } else {
   *       break;
   *     }
   *   }
   * }
   * </code></pre>
   */
  public final UnaryCallable<ListSubscriptionsRequest, ListSubscriptionsResponse>
      listSubscriptionsCallable() {
    return stub.listSubscriptionsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Deletes an existing subscription. All messages retained in the subscription are immediately
   * dropped. Calls to `Pull` after deletion will return `NOT_FOUND`. After a subscription is
   * deleted, a new one may be created with the same name, but the new one has no association with
   * the old subscription or its topic unless the same topic is specified.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   subscriptionAdminClient.deleteSubscription(subscription);
   * }
   * </code></pre>
   *
   * @param subscription Required. The subscription to delete. Format is
   *     `projects/{project}/subscriptions/{sub}`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteSubscription(ProjectSubscriptionName subscription) {
    DeleteSubscriptionRequest request =
        DeleteSubscriptionRequest.newBuilder()
            .setSubscription(subscription == null ? null : subscription.toString())
            .build();
    deleteSubscription(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Deletes an existing subscription. All messages retained in the subscription are immediately
   * dropped. Calls to `Pull` after deletion will return `NOT_FOUND`. After a subscription is
   * deleted, a new one may be created with the same name, but the new one has no association with
   * the old subscription or its topic unless the same topic is specified.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   subscriptionAdminClient.deleteSubscription(subscription.toString());
   * }
   * </code></pre>
   *
   * @param subscription Required. The subscription to delete. Format is
   *     `projects/{project}/subscriptions/{sub}`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteSubscription(String subscription) {
    DeleteSubscriptionRequest request =
        DeleteSubscriptionRequest.newBuilder().setSubscription(subscription).build();
    deleteSubscription(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Deletes an existing subscription. All messages retained in the subscription are immediately
   * dropped. Calls to `Pull` after deletion will return `NOT_FOUND`. After a subscription is
   * deleted, a new one may be created with the same name, but the new one has no association with
   * the old subscription or its topic unless the same topic is specified.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   DeleteSubscriptionRequest request = DeleteSubscriptionRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .build();
   *   subscriptionAdminClient.deleteSubscription(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteSubscription(DeleteSubscriptionRequest request) {
    deleteSubscriptionCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Deletes an existing subscription. All messages retained in the subscription are immediately
   * dropped. Calls to `Pull` after deletion will return `NOT_FOUND`. After a subscription is
   * deleted, a new one may be created with the same name, but the new one has no association with
   * the old subscription or its topic unless the same topic is specified.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   DeleteSubscriptionRequest request = DeleteSubscriptionRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .build();
   *   ApiFuture&lt;Void&gt; future = subscriptionAdminClient.deleteSubscriptionCallable().futureCall(request);
   *   // Do something
   *   future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<DeleteSubscriptionRequest, Empty> deleteSubscriptionCallable() {
    return stub.deleteSubscriptionCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Modifies the ack deadline for a specific message. This method is useful to indicate that more
   * time is needed to process a message by the subscriber, or to make the message available for
   * redelivery if the processing was interrupted. Note that this does not modify the
   * subscription-level `ackDeadlineSeconds` used for subsequent messages.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   List&lt;String&gt; ackIds = new ArrayList&lt;&gt;();
   *   int ackDeadlineSeconds = 0;
   *   subscriptionAdminClient.modifyAckDeadline(subscription, ackIds, ackDeadlineSeconds);
   * }
   * </code></pre>
   *
   * @param subscription Required. The name of the subscription. Format is
   *     `projects/{project}/subscriptions/{sub}`.
   * @param ackIds Required. List of acknowledgment IDs.
   * @param ackDeadlineSeconds Required. The new ack deadline with respect to the time this request
   *     was sent to the Pub/Sub system. For example, if the value is 10, the new ack deadline will
   *     expire 10 seconds after the `ModifyAckDeadline` call was made. Specifying zero might
   *     immediately make the message available for delivery to another subscriber client. This
   *     typically results in an increase in the rate of message redeliveries (that is, duplicates).
   *     The minimum deadline you can specify is 0 seconds. The maximum deadline you can specify is
   *     600 seconds (10 minutes).
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  /* package-private */ final void modifyAckDeadline(
      ProjectSubscriptionName subscription, List<String> ackIds, int ackDeadlineSeconds) {
    ModifyAckDeadlineRequest request =
        ModifyAckDeadlineRequest.newBuilder()
            .setSubscription(subscription == null ? null : subscription.toString())
            .addAllAckIds(ackIds)
            .setAckDeadlineSeconds(ackDeadlineSeconds)
            .build();
    modifyAckDeadline(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Modifies the ack deadline for a specific message. This method is useful to indicate that more
   * time is needed to process a message by the subscriber, or to make the message available for
   * redelivery if the processing was interrupted. Note that this does not modify the
   * subscription-level `ackDeadlineSeconds` used for subsequent messages.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   List&lt;String&gt; ackIds = new ArrayList&lt;&gt;();
   *   int ackDeadlineSeconds = 0;
   *   subscriptionAdminClient.modifyAckDeadline(subscription.toString(), ackIds, ackDeadlineSeconds);
   * }
   * </code></pre>
   *
   * @param subscription Required. The name of the subscription. Format is
   *     `projects/{project}/subscriptions/{sub}`.
   * @param ackIds Required. List of acknowledgment IDs.
   * @param ackDeadlineSeconds Required. The new ack deadline with respect to the time this request
   *     was sent to the Pub/Sub system. For example, if the value is 10, the new ack deadline will
   *     expire 10 seconds after the `ModifyAckDeadline` call was made. Specifying zero might
   *     immediately make the message available for delivery to another subscriber client. This
   *     typically results in an increase in the rate of message redeliveries (that is, duplicates).
   *     The minimum deadline you can specify is 0 seconds. The maximum deadline you can specify is
   *     600 seconds (10 minutes).
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  /* package-private */ final void modifyAckDeadline(
      String subscription, List<String> ackIds, int ackDeadlineSeconds) {
    ModifyAckDeadlineRequest request =
        ModifyAckDeadlineRequest.newBuilder()
            .setSubscription(subscription)
            .addAllAckIds(ackIds)
            .setAckDeadlineSeconds(ackDeadlineSeconds)
            .build();
    modifyAckDeadline(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Modifies the ack deadline for a specific message. This method is useful to indicate that more
   * time is needed to process a message by the subscriber, or to make the message available for
   * redelivery if the processing was interrupted. Note that this does not modify the
   * subscription-level `ackDeadlineSeconds` used for subsequent messages.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   List&lt;String&gt; ackIds = new ArrayList&lt;&gt;();
   *   int ackDeadlineSeconds = 0;
   *   ModifyAckDeadlineRequest request = ModifyAckDeadlineRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .addAllAckIds(ackIds)
   *     .setAckDeadlineSeconds(ackDeadlineSeconds)
   *     .build();
   *   subscriptionAdminClient.modifyAckDeadline(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  /* package-private */ final void modifyAckDeadline(ModifyAckDeadlineRequest request) {
    modifyAckDeadlineCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Modifies the ack deadline for a specific message. This method is useful to indicate that more
   * time is needed to process a message by the subscriber, or to make the message available for
   * redelivery if the processing was interrupted. Note that this does not modify the
   * subscription-level `ackDeadlineSeconds` used for subsequent messages.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   List&lt;String&gt; ackIds = new ArrayList&lt;&gt;();
   *   int ackDeadlineSeconds = 0;
   *   ModifyAckDeadlineRequest request = ModifyAckDeadlineRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .addAllAckIds(ackIds)
   *     .setAckDeadlineSeconds(ackDeadlineSeconds)
   *     .build();
   *   ApiFuture&lt;Void&gt; future = subscriptionAdminClient.modifyAckDeadlineCallable().futureCall(request);
   *   // Do something
   *   future.get();
   * }
   * </code></pre>
   */
  /* package-private */ final UnaryCallable<ModifyAckDeadlineRequest, Empty>
      modifyAckDeadlineCallable() {
    return stub.modifyAckDeadlineCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Acknowledges the messages associated with the `ack_ids` in the `AcknowledgeRequest`. The
   * Pub/Sub system can remove the relevant messages from the subscription.
   *
   * <p>Acknowledging a message whose ack deadline has expired may succeed, but such a message may
   * be redelivered later. Acknowledging a message more than once will not result in an error.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   List&lt;String&gt; ackIds = new ArrayList&lt;&gt;();
   *   subscriptionAdminClient.acknowledge(subscription, ackIds);
   * }
   * </code></pre>
   *
   * @param subscription Required. The subscription whose message is being acknowledged. Format is
   *     `projects/{project}/subscriptions/{sub}`.
   * @param ackIds Required. The acknowledgment ID for the messages being acknowledged that was
   *     returned by the Pub/Sub system in the `Pull` response. Must not be empty.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  /* package-private */ final void acknowledge(
      ProjectSubscriptionName subscription, List<String> ackIds) {
    AcknowledgeRequest request =
        AcknowledgeRequest.newBuilder()
            .setSubscription(subscription == null ? null : subscription.toString())
            .addAllAckIds(ackIds)
            .build();
    acknowledge(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Acknowledges the messages associated with the `ack_ids` in the `AcknowledgeRequest`. The
   * Pub/Sub system can remove the relevant messages from the subscription.
   *
   * <p>Acknowledging a message whose ack deadline has expired may succeed, but such a message may
   * be redelivered later. Acknowledging a message more than once will not result in an error.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   List&lt;String&gt; ackIds = new ArrayList&lt;&gt;();
   *   subscriptionAdminClient.acknowledge(subscription.toString(), ackIds);
   * }
   * </code></pre>
   *
   * @param subscription Required. The subscription whose message is being acknowledged. Format is
   *     `projects/{project}/subscriptions/{sub}`.
   * @param ackIds Required. The acknowledgment ID for the messages being acknowledged that was
   *     returned by the Pub/Sub system in the `Pull` response. Must not be empty.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  /* package-private */ final void acknowledge(String subscription, List<String> ackIds) {
    AcknowledgeRequest request =
        AcknowledgeRequest.newBuilder().setSubscription(subscription).addAllAckIds(ackIds).build();
    acknowledge(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Acknowledges the messages associated with the `ack_ids` in the `AcknowledgeRequest`. The
   * Pub/Sub system can remove the relevant messages from the subscription.
   *
   * <p>Acknowledging a message whose ack deadline has expired may succeed, but such a message may
   * be redelivered later. Acknowledging a message more than once will not result in an error.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   List&lt;String&gt; ackIds = new ArrayList&lt;&gt;();
   *   AcknowledgeRequest request = AcknowledgeRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .addAllAckIds(ackIds)
   *     .build();
   *   subscriptionAdminClient.acknowledge(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  /* package-private */ final void acknowledge(AcknowledgeRequest request) {
    acknowledgeCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Acknowledges the messages associated with the `ack_ids` in the `AcknowledgeRequest`. The
   * Pub/Sub system can remove the relevant messages from the subscription.
   *
   * <p>Acknowledging a message whose ack deadline has expired may succeed, but such a message may
   * be redelivered later. Acknowledging a message more than once will not result in an error.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   List&lt;String&gt; ackIds = new ArrayList&lt;&gt;();
   *   AcknowledgeRequest request = AcknowledgeRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .addAllAckIds(ackIds)
   *     .build();
   *   ApiFuture&lt;Void&gt; future = subscriptionAdminClient.acknowledgeCallable().futureCall(request);
   *   // Do something
   *   future.get();
   * }
   * </code></pre>
   */
  /* package-private */ final UnaryCallable<AcknowledgeRequest, Empty> acknowledgeCallable() {
    return stub.acknowledgeCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Pulls messages from the server. The server may return `UNAVAILABLE` if there are too many
   * concurrent pull requests pending for the given subscription.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   boolean returnImmediately = false;
   *   int maxMessages = 0;
   *   PullResponse response = subscriptionAdminClient.pull(subscription, returnImmediately, maxMessages);
   * }
   * </code></pre>
   *
   * @param subscription Required. The subscription from which messages should be pulled. Format is
   *     `projects/{project}/subscriptions/{sub}`.
   * @param returnImmediately If this field set to true, the system will respond immediately even if
   *     it there are no messages available to return in the `Pull` response. Otherwise, the system
   *     may wait (for a bounded amount of time) until at least one message is available, rather
   *     than returning no messages.
   * @param maxMessages Required. The maximum number of messages to return for this request. Must be
   *     a positive integer. The Pub/Sub system may return fewer than the number specified.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  /* package-private */ final PullResponse pull(
      ProjectSubscriptionName subscription, boolean returnImmediately, int maxMessages) {
    PullRequest request =
        PullRequest.newBuilder()
            .setSubscription(subscription == null ? null : subscription.toString())
            .setReturnImmediately(returnImmediately)
            .setMaxMessages(maxMessages)
            .build();
    return pull(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Pulls messages from the server. The server may return `UNAVAILABLE` if there are too many
   * concurrent pull requests pending for the given subscription.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   boolean returnImmediately = false;
   *   int maxMessages = 0;
   *   PullResponse response = subscriptionAdminClient.pull(subscription.toString(), returnImmediately, maxMessages);
   * }
   * </code></pre>
   *
   * @param subscription Required. The subscription from which messages should be pulled. Format is
   *     `projects/{project}/subscriptions/{sub}`.
   * @param returnImmediately If this field set to true, the system will respond immediately even if
   *     it there are no messages available to return in the `Pull` response. Otherwise, the system
   *     may wait (for a bounded amount of time) until at least one message is available, rather
   *     than returning no messages.
   * @param maxMessages Required. The maximum number of messages to return for this request. Must be
   *     a positive integer. The Pub/Sub system may return fewer than the number specified.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  /* package-private */ final PullResponse pull(
      String subscription, boolean returnImmediately, int maxMessages) {
    PullRequest request =
        PullRequest.newBuilder()
            .setSubscription(subscription)
            .setReturnImmediately(returnImmediately)
            .setMaxMessages(maxMessages)
            .build();
    return pull(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Pulls messages from the server. The server may return `UNAVAILABLE` if there are too many
   * concurrent pull requests pending for the given subscription.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   int maxMessages = 0;
   *   PullRequest request = PullRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .setMaxMessages(maxMessages)
   *     .build();
   *   PullResponse response = subscriptionAdminClient.pull(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  /* package-private */ final PullResponse pull(PullRequest request) {
    return pullCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Pulls messages from the server. The server may return `UNAVAILABLE` if there are too many
   * concurrent pull requests pending for the given subscription.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   int maxMessages = 0;
   *   PullRequest request = PullRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .setMaxMessages(maxMessages)
   *     .build();
   *   ApiFuture&lt;PullResponse&gt; future = subscriptionAdminClient.pullCallable().futureCall(request);
   *   // Do something
   *   PullResponse response = future.get();
   * }
   * </code></pre>
   */
  /* package-private */ final UnaryCallable<PullRequest, PullResponse> pullCallable() {
    return stub.pullCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Establishes a stream with the server, which sends messages down to the client. The client
   * streams acknowledgements and ack deadline modifications back to the server. The server will
   * close the stream and return the status on any error. The server may close the stream with
   * status `UNAVAILABLE` to reassign server-side resources, in which case, the client should
   * re-establish the stream. Flow control can be achieved by configuring the underlying RPC
   * channel.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   BidiStream&lt;StreamingPullRequest, StreamingPullResponse&gt; bidiStream =
   *       subscriptionAdminClient.streamingPullCallable().call();
   *
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   int streamAckDeadlineSeconds = 0;
   *   StreamingPullRequest request = StreamingPullRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .setStreamAckDeadlineSeconds(streamAckDeadlineSeconds)
   *     .build();
   *   bidiStream.send(request);
   *   for (StreamingPullResponse response : bidiStream) {
   *     // Do something when receive a response
   *   }
   * }
   * </code></pre>
   */
  /* package-private */ final BidiStreamingCallable<StreamingPullRequest, StreamingPullResponse>
      streamingPullCallable() {
    return stub.streamingPullCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Modifies the `PushConfig` for a specified subscription.
   *
   * <p>This may be used to change a push subscription to a pull one (signified by an empty
   * `PushConfig`) or vice versa, or change the endpoint URL and other attributes of a push
   * subscription. Messages will accumulate for delivery continuously through the call regardless of
   * changes to the `PushConfig`.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   PushConfig pushConfig = PushConfig.newBuilder().build();
   *   subscriptionAdminClient.modifyPushConfig(subscription, pushConfig);
   * }
   * </code></pre>
   *
   * @param subscription Required. The name of the subscription. Format is
   *     `projects/{project}/subscriptions/{sub}`.
   * @param pushConfig Required. The push configuration for future deliveries.
   *     <p>An empty `pushConfig` indicates that the Pub/Sub system should stop pushing messages
   *     from the given subscription and allow messages to be pulled and acknowledged - effectively
   *     pausing the subscription if `Pull` or `StreamingPull` is not called.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void modifyPushConfig(ProjectSubscriptionName subscription, PushConfig pushConfig) {
    ModifyPushConfigRequest request =
        ModifyPushConfigRequest.newBuilder()
            .setSubscription(subscription == null ? null : subscription.toString())
            .setPushConfig(pushConfig)
            .build();
    modifyPushConfig(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Modifies the `PushConfig` for a specified subscription.
   *
   * <p>This may be used to change a push subscription to a pull one (signified by an empty
   * `PushConfig`) or vice versa, or change the endpoint URL and other attributes of a push
   * subscription. Messages will accumulate for delivery continuously through the call regardless of
   * changes to the `PushConfig`.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   PushConfig pushConfig = PushConfig.newBuilder().build();
   *   subscriptionAdminClient.modifyPushConfig(subscription.toString(), pushConfig);
   * }
   * </code></pre>
   *
   * @param subscription Required. The name of the subscription. Format is
   *     `projects/{project}/subscriptions/{sub}`.
   * @param pushConfig Required. The push configuration for future deliveries.
   *     <p>An empty `pushConfig` indicates that the Pub/Sub system should stop pushing messages
   *     from the given subscription and allow messages to be pulled and acknowledged - effectively
   *     pausing the subscription if `Pull` or `StreamingPull` is not called.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void modifyPushConfig(String subscription, PushConfig pushConfig) {
    ModifyPushConfigRequest request =
        ModifyPushConfigRequest.newBuilder()
            .setSubscription(subscription)
            .setPushConfig(pushConfig)
            .build();
    modifyPushConfig(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Modifies the `PushConfig` for a specified subscription.
   *
   * <p>This may be used to change a push subscription to a pull one (signified by an empty
   * `PushConfig`) or vice versa, or change the endpoint URL and other attributes of a push
   * subscription. Messages will accumulate for delivery continuously through the call regardless of
   * changes to the `PushConfig`.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   PushConfig pushConfig = PushConfig.newBuilder().build();
   *   ModifyPushConfigRequest request = ModifyPushConfigRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .setPushConfig(pushConfig)
   *     .build();
   *   subscriptionAdminClient.modifyPushConfig(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void modifyPushConfig(ModifyPushConfigRequest request) {
    modifyPushConfigCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Modifies the `PushConfig` for a specified subscription.
   *
   * <p>This may be used to change a push subscription to a pull one (signified by an empty
   * `PushConfig`) or vice versa, or change the endpoint URL and other attributes of a push
   * subscription. Messages will accumulate for delivery continuously through the call regardless of
   * changes to the `PushConfig`.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   PushConfig pushConfig = PushConfig.newBuilder().build();
   *   ModifyPushConfigRequest request = ModifyPushConfigRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .setPushConfig(pushConfig)
   *     .build();
   *   ApiFuture&lt;Void&gt; future = subscriptionAdminClient.modifyPushConfigCallable().futureCall(request);
   *   // Do something
   *   future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<ModifyPushConfigRequest, Empty> modifyPushConfigCallable() {
    return stub.modifyPushConfigCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Lists the existing snapshots. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a snapshot.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectName project = ProjectName.of("[PROJECT]");
   *   for (Snapshot element : subscriptionAdminClient.listSnapshots(project).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * </code></pre>
   *
   * @param project Required. The name of the project in which to list snapshots. Format is
   *     `projects/{project-id}`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListSnapshotsPagedResponse listSnapshots(ProjectName project) {
    ListSnapshotsRequest request =
        ListSnapshotsRequest.newBuilder()
            .setProject(project == null ? null : project.toString())
            .build();
    return listSnapshots(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Lists the existing snapshots. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a snapshot.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectName project = ProjectName.of("[PROJECT]");
   *   for (Snapshot element : subscriptionAdminClient.listSnapshots(project.toString()).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * </code></pre>
   *
   * @param project Required. The name of the project in which to list snapshots. Format is
   *     `projects/{project-id}`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListSnapshotsPagedResponse listSnapshots(String project) {
    ListSnapshotsRequest request = ListSnapshotsRequest.newBuilder().setProject(project).build();
    return listSnapshots(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Lists the existing snapshots. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a snapshot.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectName project = ProjectName.of("[PROJECT]");
   *   ListSnapshotsRequest request = ListSnapshotsRequest.newBuilder()
   *     .setProject(project.toString())
   *     .build();
   *   for (Snapshot element : subscriptionAdminClient.listSnapshots(request).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListSnapshotsPagedResponse listSnapshots(ListSnapshotsRequest request) {
    return listSnapshotsPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Lists the existing snapshots. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a snapshot.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectName project = ProjectName.of("[PROJECT]");
   *   ListSnapshotsRequest request = ListSnapshotsRequest.newBuilder()
   *     .setProject(project.toString())
   *     .build();
   *   ApiFuture&lt;ListSnapshotsPagedResponse&gt; future = subscriptionAdminClient.listSnapshotsPagedCallable().futureCall(request);
   *   // Do something
   *   for (Snapshot element : future.get().iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * </code></pre>
   */
  public final UnaryCallable<ListSnapshotsRequest, ListSnapshotsPagedResponse>
      listSnapshotsPagedCallable() {
    return stub.listSnapshotsPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Lists the existing snapshots. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a snapshot.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectName project = ProjectName.of("[PROJECT]");
   *   ListSnapshotsRequest request = ListSnapshotsRequest.newBuilder()
   *     .setProject(project.toString())
   *     .build();
   *   while (true) {
   *     ListSnapshotsResponse response = subscriptionAdminClient.listSnapshotsCallable().call(request);
   *     for (Snapshot element : response.getSnapshotsList()) {
   *       // doThingsWith(element);
   *     }
   *     String nextPageToken = response.getNextPageToken();
   *     if (!Strings.isNullOrEmpty(nextPageToken)) {
   *       request = request.toBuilder().setPageToken(nextPageToken).build();
   *     } else {
   *       break;
   *     }
   *   }
   * }
   * </code></pre>
   */
  public final UnaryCallable<ListSnapshotsRequest, ListSnapshotsResponse> listSnapshotsCallable() {
    return stub.listSnapshotsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Creates a snapshot from the requested subscription. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a snapshot.
   * &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`. If the requested
   * subscription doesn't exist, returns `NOT_FOUND`. If the backlog in the subscription is too old
   * -- and the resulting snapshot would expire in less than 1 hour -- then `FAILED_PRECONDITION` is
   * returned. See also the `Snapshot.expire_time` field. If the name is not provided in the
   * request, the server will assign a random name for this snapshot on the same project as the
   * subscription, conforming to the [resource name
   * format](https://cloud.google.com/pubsub/docs/admin#resource_names). The generated name is
   * populated in the returned Snapshot object. Note that for REST API requests, you must specify a
   * name in the request.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSnapshotName name = ProjectSnapshotName.of("[PROJECT]", "[SNAPSHOT]");
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   Snapshot response = subscriptionAdminClient.createSnapshot(name, subscription);
   * }
   * </code></pre>
   *
   * @param name Required. User-provided name for this snapshot. If the name is not provided in the
   *     request, the server will assign a random name for this snapshot on the same project as the
   *     subscription. Note that for REST API requests, you must specify a name. See the &lt;a
   *     href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt; resource name
   *     rules&lt;/a&gt;. Format is `projects/{project}/snapshots/{snap}`.
   * @param subscription Required. The subscription whose backlog the snapshot retains.
   *     Specifically, the created snapshot is guaranteed to retain: (a) The existing backlog on the
   *     subscription. More precisely, this is defined as the messages in the subscription's backlog
   *     that are unacknowledged upon the successful completion of the `CreateSnapshot` request; as
   *     well as: (b) Any messages published to the subscription's topic following the successful
   *     completion of the CreateSnapshot request. Format is
   *     `projects/{project}/subscriptions/{sub}`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Snapshot createSnapshot(
      ProjectSnapshotName name, ProjectSubscriptionName subscription) {
    CreateSnapshotRequest request =
        CreateSnapshotRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .setSubscription(subscription == null ? null : subscription.toString())
            .build();
    return createSnapshot(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Creates a snapshot from the requested subscription. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a snapshot.
   * &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`. If the requested
   * subscription doesn't exist, returns `NOT_FOUND`. If the backlog in the subscription is too old
   * -- and the resulting snapshot would expire in less than 1 hour -- then `FAILED_PRECONDITION` is
   * returned. See also the `Snapshot.expire_time` field. If the name is not provided in the
   * request, the server will assign a random name for this snapshot on the same project as the
   * subscription, conforming to the [resource name
   * format](https://cloud.google.com/pubsub/docs/admin#resource_names). The generated name is
   * populated in the returned Snapshot object. Note that for REST API requests, you must specify a
   * name in the request.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSnapshotName name = ProjectSnapshotName.of("[PROJECT]", "[SNAPSHOT]");
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   Snapshot response = subscriptionAdminClient.createSnapshot(name.toString(), subscription.toString());
   * }
   * </code></pre>
   *
   * @param name Required. User-provided name for this snapshot. If the name is not provided in the
   *     request, the server will assign a random name for this snapshot on the same project as the
   *     subscription. Note that for REST API requests, you must specify a name. See the &lt;a
   *     href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt; resource name
   *     rules&lt;/a&gt;. Format is `projects/{project}/snapshots/{snap}`.
   * @param subscription Required. The subscription whose backlog the snapshot retains.
   *     Specifically, the created snapshot is guaranteed to retain: (a) The existing backlog on the
   *     subscription. More precisely, this is defined as the messages in the subscription's backlog
   *     that are unacknowledged upon the successful completion of the `CreateSnapshot` request; as
   *     well as: (b) Any messages published to the subscription's topic following the successful
   *     completion of the CreateSnapshot request. Format is
   *     `projects/{project}/subscriptions/{sub}`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Snapshot createSnapshot(String name, String subscription) {
    CreateSnapshotRequest request =
        CreateSnapshotRequest.newBuilder().setName(name).setSubscription(subscription).build();
    return createSnapshot(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Creates a snapshot from the requested subscription. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a snapshot.
   * &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`. If the requested
   * subscription doesn't exist, returns `NOT_FOUND`. If the backlog in the subscription is too old
   * -- and the resulting snapshot would expire in less than 1 hour -- then `FAILED_PRECONDITION` is
   * returned. See also the `Snapshot.expire_time` field. If the name is not provided in the
   * request, the server will assign a random name for this snapshot on the same project as the
   * subscription, conforming to the [resource name
   * format](https://cloud.google.com/pubsub/docs/admin#resource_names). The generated name is
   * populated in the returned Snapshot object. Note that for REST API requests, you must specify a
   * name in the request.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSnapshotName name = ProjectSnapshotName.of("[PROJECT]", "[SNAPSHOT]");
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   CreateSnapshotRequest request = CreateSnapshotRequest.newBuilder()
   *     .setName(name.toString())
   *     .setSubscription(subscription.toString())
   *     .build();
   *   Snapshot response = subscriptionAdminClient.createSnapshot(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Snapshot createSnapshot(CreateSnapshotRequest request) {
    return createSnapshotCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Creates a snapshot from the requested subscription. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a snapshot.
   * &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`. If the requested
   * subscription doesn't exist, returns `NOT_FOUND`. If the backlog in the subscription is too old
   * -- and the resulting snapshot would expire in less than 1 hour -- then `FAILED_PRECONDITION` is
   * returned. See also the `Snapshot.expire_time` field. If the name is not provided in the
   * request, the server will assign a random name for this snapshot on the same project as the
   * subscription, conforming to the [resource name
   * format](https://cloud.google.com/pubsub/docs/admin#resource_names). The generated name is
   * populated in the returned Snapshot object. Note that for REST API requests, you must specify a
   * name in the request.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSnapshotName name = ProjectSnapshotName.of("[PROJECT]", "[SNAPSHOT]");
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   CreateSnapshotRequest request = CreateSnapshotRequest.newBuilder()
   *     .setName(name.toString())
   *     .setSubscription(subscription.toString())
   *     .build();
   *   ApiFuture&lt;Snapshot&gt; future = subscriptionAdminClient.createSnapshotCallable().futureCall(request);
   *   // Do something
   *   Snapshot response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<CreateSnapshotRequest, Snapshot> createSnapshotCallable() {
    return stub.createSnapshotCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Updates an existing snapshot. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a snapshot.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   long seconds = 123456L;
   *   Timestamp expireTime = Timestamp.newBuilder()
   *     .setSeconds(seconds)
   *     .build();
   *   Snapshot snapshot = Snapshot.newBuilder()
   *     .setExpireTime(expireTime)
   *     .build();
   *   String pathsElement = "expire_time";
   *   List&lt;String&gt; paths = Arrays.asList(pathsElement);
   *   FieldMask updateMask = FieldMask.newBuilder()
   *     .addAllPaths(paths)
   *     .build();
   *   UpdateSnapshotRequest request = UpdateSnapshotRequest.newBuilder()
   *     .setSnapshot(snapshot)
   *     .setUpdateMask(updateMask)
   *     .build();
   *   Snapshot response = subscriptionAdminClient.updateSnapshot(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Snapshot updateSnapshot(UpdateSnapshotRequest request) {
    return updateSnapshotCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Updates an existing snapshot. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a snapshot.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   long seconds = 123456L;
   *   Timestamp expireTime = Timestamp.newBuilder()
   *     .setSeconds(seconds)
   *     .build();
   *   Snapshot snapshot = Snapshot.newBuilder()
   *     .setExpireTime(expireTime)
   *     .build();
   *   String pathsElement = "expire_time";
   *   List&lt;String&gt; paths = Arrays.asList(pathsElement);
   *   FieldMask updateMask = FieldMask.newBuilder()
   *     .addAllPaths(paths)
   *     .build();
   *   UpdateSnapshotRequest request = UpdateSnapshotRequest.newBuilder()
   *     .setSnapshot(snapshot)
   *     .setUpdateMask(updateMask)
   *     .build();
   *   ApiFuture&lt;Snapshot&gt; future = subscriptionAdminClient.updateSnapshotCallable().futureCall(request);
   *   // Do something
   *   Snapshot response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<UpdateSnapshotRequest, Snapshot> updateSnapshotCallable() {
    return stub.updateSnapshotCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Removes an existing snapshot. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a
   * snapshot.&lt;br&gt;&lt;br&gt; When the snapshot is deleted, all messages retained in the
   * snapshot are immediately dropped. After a snapshot is deleted, a new one may be created with
   * the same name, but the new one has no association with the old snapshot or its subscription,
   * unless the same subscription is specified.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSnapshotName snapshot = ProjectSnapshotName.of("[PROJECT]", "[SNAPSHOT]");
   *   subscriptionAdminClient.deleteSnapshot(snapshot);
   * }
   * </code></pre>
   *
   * @param snapshot Required. The name of the snapshot to delete. Format is
   *     `projects/{project}/snapshots/{snap}`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteSnapshot(ProjectSnapshotName snapshot) {
    DeleteSnapshotRequest request =
        DeleteSnapshotRequest.newBuilder()
            .setSnapshot(snapshot == null ? null : snapshot.toString())
            .build();
    deleteSnapshot(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Removes an existing snapshot. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a
   * snapshot.&lt;br&gt;&lt;br&gt; When the snapshot is deleted, all messages retained in the
   * snapshot are immediately dropped. After a snapshot is deleted, a new one may be created with
   * the same name, but the new one has no association with the old snapshot or its subscription,
   * unless the same subscription is specified.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSnapshotName snapshot = ProjectSnapshotName.of("[PROJECT]", "[SNAPSHOT]");
   *   subscriptionAdminClient.deleteSnapshot(snapshot.toString());
   * }
   * </code></pre>
   *
   * @param snapshot Required. The name of the snapshot to delete. Format is
   *     `projects/{project}/snapshots/{snap}`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteSnapshot(String snapshot) {
    DeleteSnapshotRequest request =
        DeleteSnapshotRequest.newBuilder().setSnapshot(snapshot).build();
    deleteSnapshot(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Removes an existing snapshot. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a
   * snapshot.&lt;br&gt;&lt;br&gt; When the snapshot is deleted, all messages retained in the
   * snapshot are immediately dropped. After a snapshot is deleted, a new one may be created with
   * the same name, but the new one has no association with the old snapshot or its subscription,
   * unless the same subscription is specified.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSnapshotName snapshot = ProjectSnapshotName.of("[PROJECT]", "[SNAPSHOT]");
   *   DeleteSnapshotRequest request = DeleteSnapshotRequest.newBuilder()
   *     .setSnapshot(snapshot.toString())
   *     .build();
   *   subscriptionAdminClient.deleteSnapshot(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteSnapshot(DeleteSnapshotRequest request) {
    deleteSnapshotCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Removes an existing snapshot. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a
   * snapshot.&lt;br&gt;&lt;br&gt; When the snapshot is deleted, all messages retained in the
   * snapshot are immediately dropped. After a snapshot is deleted, a new one may be created with
   * the same name, but the new one has no association with the old snapshot or its subscription,
   * unless the same subscription is specified.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSnapshotName snapshot = ProjectSnapshotName.of("[PROJECT]", "[SNAPSHOT]");
   *   DeleteSnapshotRequest request = DeleteSnapshotRequest.newBuilder()
   *     .setSnapshot(snapshot.toString())
   *     .build();
   *   ApiFuture&lt;Void&gt; future = subscriptionAdminClient.deleteSnapshotCallable().futureCall(request);
   *   // Do something
   *   future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<DeleteSnapshotRequest, Empty> deleteSnapshotCallable() {
    return stub.deleteSnapshotCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Seeks an existing subscription to a point in time or to a given snapshot, whichever is provided
   * in the request. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a snapshot. Note that
   * both the subscription and the snapshot must be on the same topic.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   SeekRequest request = SeekRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .build();
   *   SeekResponse response = subscriptionAdminClient.seek(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final SeekResponse seek(SeekRequest request) {
    return seekCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Seeks an existing subscription to a point in time or to a given snapshot, whichever is provided
   * in the request. Snapshots are used in &lt;a
   * href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt; operations, which
   * allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
   * state of messages in an existing subscription to the state captured by a snapshot. Note that
   * both the subscription and the snapshot must be on the same topic.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ProjectSubscriptionName subscription = ProjectSubscriptionName.of("[PROJECT]", "[SUBSCRIPTION]");
   *   SeekRequest request = SeekRequest.newBuilder()
   *     .setSubscription(subscription.toString())
   *     .build();
   *   ApiFuture&lt;SeekResponse&gt; future = subscriptionAdminClient.seekCallable().futureCall(request);
   *   // Do something
   *   SeekResponse response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<SeekRequest, SeekResponse> seekCallable() {
    return stub.seekCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Sets the access control policy on the specified resource. Replaces any existing policy.
   *
   * <p>Can return Public Errors: NOT_FOUND, INVALID_ARGUMENT and PERMISSION_DENIED
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ResourceName resource = ProjectName.of("[PROJECT]");
   *   Policy policy = Policy.newBuilder().build();
   *   SetIamPolicyRequest request = SetIamPolicyRequest.newBuilder()
   *     .setResource(resource.toString())
   *     .setPolicy(policy)
   *     .build();
   *   Policy response = subscriptionAdminClient.setIamPolicy(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Policy setIamPolicy(SetIamPolicyRequest request) {
    return setIamPolicyCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Sets the access control policy on the specified resource. Replaces any existing policy.
   *
   * <p>Can return Public Errors: NOT_FOUND, INVALID_ARGUMENT and PERMISSION_DENIED
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ResourceName resource = ProjectName.of("[PROJECT]");
   *   Policy policy = Policy.newBuilder().build();
   *   SetIamPolicyRequest request = SetIamPolicyRequest.newBuilder()
   *     .setResource(resource.toString())
   *     .setPolicy(policy)
   *     .build();
   *   ApiFuture&lt;Policy&gt; future = subscriptionAdminClient.setIamPolicyCallable().futureCall(request);
   *   // Do something
   *   Policy response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<SetIamPolicyRequest, Policy> setIamPolicyCallable() {
    return stub.setIamPolicyCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Gets the access control policy for a resource. Returns an empty policy if the resource exists
   * and does not have a policy set.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ResourceName resource = ProjectName.of("[PROJECT]");
   *   GetIamPolicyRequest request = GetIamPolicyRequest.newBuilder()
   *     .setResource(resource.toString())
   *     .build();
   *   Policy response = subscriptionAdminClient.getIamPolicy(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Policy getIamPolicy(GetIamPolicyRequest request) {
    return getIamPolicyCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Gets the access control policy for a resource. Returns an empty policy if the resource exists
   * and does not have a policy set.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ResourceName resource = ProjectName.of("[PROJECT]");
   *   GetIamPolicyRequest request = GetIamPolicyRequest.newBuilder()
   *     .setResource(resource.toString())
   *     .build();
   *   ApiFuture&lt;Policy&gt; future = subscriptionAdminClient.getIamPolicyCallable().futureCall(request);
   *   // Do something
   *   Policy response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<GetIamPolicyRequest, Policy> getIamPolicyCallable() {
    return stub.getIamPolicyCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns permissions that a caller has on the specified resource. If the resource does not
   * exist, this will return an empty set of permissions, not a NOT_FOUND error.
   *
   * <p>Note: This operation is designed to be used for building permission-aware UIs and
   * command-line tools, not for authorization checking. This operation may "fail open" without
   * warning.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ResourceName resource = ProjectName.of("[PROJECT]");
   *   List&lt;String&gt; permissions = new ArrayList&lt;&gt;();
   *   TestIamPermissionsRequest request = TestIamPermissionsRequest.newBuilder()
   *     .setResource(resource.toString())
   *     .addAllPermissions(permissions)
   *     .build();
   *   TestIamPermissionsResponse response = subscriptionAdminClient.testIamPermissions(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final TestIamPermissionsResponse testIamPermissions(TestIamPermissionsRequest request) {
    return testIamPermissionsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns permissions that a caller has on the specified resource. If the resource does not
   * exist, this will return an empty set of permissions, not a NOT_FOUND error.
   *
   * <p>Note: This operation is designed to be used for building permission-aware UIs and
   * command-line tools, not for authorization checking. This operation may "fail open" without
   * warning.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (SubscriptionAdminClient subscriptionAdminClient = SubscriptionAdminClient.create()) {
   *   ResourceName resource = ProjectName.of("[PROJECT]");
   *   List&lt;String&gt; permissions = new ArrayList&lt;&gt;();
   *   TestIamPermissionsRequest request = TestIamPermissionsRequest.newBuilder()
   *     .setResource(resource.toString())
   *     .addAllPermissions(permissions)
   *     .build();
   *   ApiFuture&lt;TestIamPermissionsResponse&gt; future = subscriptionAdminClient.testIamPermissionsCallable().futureCall(request);
   *   // Do something
   *   TestIamPermissionsResponse response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<TestIamPermissionsRequest, TestIamPermissionsResponse>
      testIamPermissionsCallable() {
    return stub.testIamPermissionsCallable();
  }

  @Override
  public final void close() {
    stub.close();
  }

  @Override
  public void shutdown() {
    stub.shutdown();
  }

  @Override
  public boolean isShutdown() {
    return stub.isShutdown();
  }

  @Override
  public boolean isTerminated() {
    return stub.isTerminated();
  }

  @Override
  public void shutdownNow() {
    stub.shutdownNow();
  }

  @Override
  public boolean awaitTermination(long duration, TimeUnit unit) throws InterruptedException {
    return stub.awaitTermination(duration, unit);
  }

  public static class ListSubscriptionsPagedResponse
      extends AbstractPagedListResponse<
          ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription, ListSubscriptionsPage,
          ListSubscriptionsFixedSizeCollection> {

    public static ApiFuture<ListSubscriptionsPagedResponse> createAsync(
        PageContext<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription> context,
        ApiFuture<ListSubscriptionsResponse> futureResponse) {
      ApiFuture<ListSubscriptionsPage> futurePage =
          ListSubscriptionsPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<ListSubscriptionsPage, ListSubscriptionsPagedResponse>() {
            @Override
            public ListSubscriptionsPagedResponse apply(ListSubscriptionsPage input) {
              return new ListSubscriptionsPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private ListSubscriptionsPagedResponse(ListSubscriptionsPage page) {
      super(page, ListSubscriptionsFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListSubscriptionsPage
      extends AbstractPage<
          ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription,
          ListSubscriptionsPage> {

    private ListSubscriptionsPage(
        PageContext<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription> context,
        ListSubscriptionsResponse response) {
      super(context, response);
    }

    private static ListSubscriptionsPage createEmptyPage() {
      return new ListSubscriptionsPage(null, null);
    }

    @Override
    protected ListSubscriptionsPage createPage(
        PageContext<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription> context,
        ListSubscriptionsResponse response) {
      return new ListSubscriptionsPage(context, response);
    }

    @Override
    public ApiFuture<ListSubscriptionsPage> createPageAsync(
        PageContext<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription> context,
        ApiFuture<ListSubscriptionsResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListSubscriptionsFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription, ListSubscriptionsPage,
          ListSubscriptionsFixedSizeCollection> {

    private ListSubscriptionsFixedSizeCollection(
        List<ListSubscriptionsPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListSubscriptionsFixedSizeCollection createEmptyCollection() {
      return new ListSubscriptionsFixedSizeCollection(null, 0);
    }

    @Override
    protected ListSubscriptionsFixedSizeCollection createCollection(
        List<ListSubscriptionsPage> pages, int collectionSize) {
      return new ListSubscriptionsFixedSizeCollection(pages, collectionSize);
    }
  }

  public static class ListSnapshotsPagedResponse
      extends AbstractPagedListResponse<
          ListSnapshotsRequest, ListSnapshotsResponse, Snapshot, ListSnapshotsPage,
          ListSnapshotsFixedSizeCollection> {

    public static ApiFuture<ListSnapshotsPagedResponse> createAsync(
        PageContext<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot> context,
        ApiFuture<ListSnapshotsResponse> futureResponse) {
      ApiFuture<ListSnapshotsPage> futurePage =
          ListSnapshotsPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<ListSnapshotsPage, ListSnapshotsPagedResponse>() {
            @Override
            public ListSnapshotsPagedResponse apply(ListSnapshotsPage input) {
              return new ListSnapshotsPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private ListSnapshotsPagedResponse(ListSnapshotsPage page) {
      super(page, ListSnapshotsFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListSnapshotsPage
      extends AbstractPage<
          ListSnapshotsRequest, ListSnapshotsResponse, Snapshot, ListSnapshotsPage> {

    private ListSnapshotsPage(
        PageContext<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot> context,
        ListSnapshotsResponse response) {
      super(context, response);
    }

    private static ListSnapshotsPage createEmptyPage() {
      return new ListSnapshotsPage(null, null);
    }

    @Override
    protected ListSnapshotsPage createPage(
        PageContext<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot> context,
        ListSnapshotsResponse response) {
      return new ListSnapshotsPage(context, response);
    }

    @Override
    public ApiFuture<ListSnapshotsPage> createPageAsync(
        PageContext<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot> context,
        ApiFuture<ListSnapshotsResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListSnapshotsFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListSnapshotsRequest, ListSnapshotsResponse, Snapshot, ListSnapshotsPage,
          ListSnapshotsFixedSizeCollection> {

    private ListSnapshotsFixedSizeCollection(List<ListSnapshotsPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListSnapshotsFixedSizeCollection createEmptyCollection() {
      return new ListSnapshotsFixedSizeCollection(null, 0);
    }

    @Override
    protected ListSnapshotsFixedSizeCollection createCollection(
        List<ListSnapshotsPage> pages, int collectionSize) {
      return new ListSnapshotsFixedSizeCollection(pages, collectionSize);
    }
  }
}
