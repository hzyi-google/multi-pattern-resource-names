<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/pubsub/v1/pubsub.proto

namespace Google\Cloud\PubSub\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A subscription resource.
 *
 * Generated from protobuf message <code>google.pubsub.v1.Subscription</code>
 */
class Subscription extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the subscription. It must have the format
     * `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
     * start with a letter, and contain only letters (`[A-Za-z]`), numbers
     * (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
     * plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
     * in length, and it must not start with `"goog"`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $name = '';
    /**
     * Required. The name of the topic from which this subscription is receiving
     * messages. Format is `projects/{project}/topics/{topic}`. The value of this
     * field will be `_deleted-topic_` if the topic has been deleted.
     *
     * Generated from protobuf field <code>string topic = 2 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $topic = '';
    /**
     * If push delivery is used with this subscription, this field is
     * used to configure it. An empty `pushConfig` signifies that the subscriber
     * will pull and ack messages using API methods.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.PushConfig push_config = 4;</code>
     */
    protected $push_config = null;
    /**
     * The approximate amount of time (on a best-effort basis) Pub/Sub waits for
     * the subscriber to acknowledge receipt before resending the message. In the
     * interval after the message is delivered and before it is acknowledged, it
     * is considered to be <i>outstanding</i>. During that time period, the
     * message will not be redelivered (on a best-effort basis).
     * For pull subscriptions, this value is used as the initial value for the ack
     * deadline. To override this value for a given message, call
     * `ModifyAckDeadline` with the corresponding `ack_id` if using
     * non-streaming pull or send the `ack_id` in a
     * `StreamingModifyAckDeadlineRequest` if using streaming pull.
     * The minimum custom deadline you can specify is 10 seconds.
     * The maximum custom deadline you can specify is 600 seconds (10 minutes).
     * If this parameter is 0, a default value of 10 seconds is used.
     * For push delivery, this value is also used to set the request timeout for
     * the call to the push endpoint.
     * If the subscriber never acknowledges the message, the Pub/Sub
     * system will eventually redeliver the message.
     *
     * Generated from protobuf field <code>int32 ack_deadline_seconds = 5;</code>
     */
    protected $ack_deadline_seconds = 0;
    /**
     * Indicates whether to retain acknowledged messages. If true, then
     * messages are not expunged from the subscription's backlog, even if they are
     * acknowledged, until they fall out of the `message_retention_duration`
     * window. This must be true if you would like to
     * <a
     * href="https://cloud.google.com/pubsub/docs/replay-overview#seek_to_a_time">
     * Seek to a timestamp</a>.
     *
     * Generated from protobuf field <code>bool retain_acked_messages = 7;</code>
     */
    protected $retain_acked_messages = false;
    /**
     * How long to retain unacknowledged messages in the subscription's backlog,
     * from the moment a message is published.
     * If `retain_acked_messages` is true, then this also configures the retention
     * of acknowledged messages, and thus configures how far back in time a `Seek`
     * can be done. Defaults to 7 days. Cannot be more than 7 days or less than 10
     * minutes.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration message_retention_duration = 8;</code>
     */
    protected $message_retention_duration = null;
    /**
     * See <a href="https://cloud.google.com/pubsub/docs/labels"> Creating and
     * managing labels</a>.
     *
     * Generated from protobuf field <code>map<string, string> labels = 9;</code>
     */
    private $labels;
    /**
     * If true, messages published with the same `ordering_key` in `PubsubMessage`
     * will be delivered to the subscribers in the order in which they
     * are received by the Pub/Sub system. Otherwise, they may be delivered in
     * any order.
     * <b>EXPERIMENTAL:</b> This feature is part of a closed alpha release. This
     * API might be changed in backward-incompatible ways and is not recommended
     * for production use. It is not subject to any SLA or deprecation policy.
     *
     * Generated from protobuf field <code>bool enable_message_ordering = 10;</code>
     */
    protected $enable_message_ordering = false;
    /**
     * A policy that specifies the conditions for this subscription's expiration.
     * A subscription is considered active as long as any connected subscriber is
     * successfully consuming messages from the subscription or is issuing
     * operations on the subscription. If `expiration_policy` is not set, a
     * *default policy* with `ttl` of 31 days will be used. The minimum allowed
     * value for `expiration_policy.ttl` is 1 day.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.ExpirationPolicy expiration_policy = 11;</code>
     */
    protected $expiration_policy = null;
    /**
     * An expression written in the Cloud Pub/Sub filter language. If non-empty,
     * then only `PubsubMessage`s whose `attributes` field matches the filter are
     * delivered on this subscription. If empty, then no messages are filtered
     * out.
     * <b>EXPERIMENTAL:</b> This feature is part of a closed alpha release. This
     * API might be changed in backward-incompatible ways and is not recommended
     * for production use. It is not subject to any SLA or deprecation policy.
     *
     * Generated from protobuf field <code>string filter = 12;</code>
     */
    protected $filter = '';
    /**
     * A policy that specifies the conditions for dead lettering messages in
     * this subscription. If dead_letter_policy is not set, dead lettering
     * is disabled.
     * The Cloud Pub/Sub service account associated with this subscriptions's
     * parent project (i.e.,
     * service-{project_number}&#64;gcp-sa-pubsub.iam.gserviceaccount.com) must have
     * permission to Acknowledge() messages on this subscription.
     * <b>EXPERIMENTAL:</b> This feature is part of a closed alpha release. This
     * API might be changed in backward-incompatible ways and is not recommended
     * for production use. It is not subject to any SLA or deprecation policy.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.DeadLetterPolicy dead_letter_policy = 13;</code>
     */
    protected $dead_letter_policy = null;
    /**
     * A policy that specifies how Cloud Pub/Sub retries message delivery for this
     * subscription.
     * If not set, the default retry policy is applied. This generally implies
     * that messages will be retried as soon as possible for healthy subscribers.
     * RetryPolicy will be triggered on NACKs or acknowledgement deadline
     * exceeded events for a given message.
     * <b>EXPERIMENTAL:</b> This API might be changed in backward-incompatible
     * ways and is not recommended for production use. It is not subject to any
     * SLA or deprecation policy.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.RetryPolicy retry_policy = 14;</code>
     */
    protected $retry_policy = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The name of the subscription. It must have the format
     *           `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
     *           start with a letter, and contain only letters (`[A-Za-z]`), numbers
     *           (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
     *           plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
     *           in length, and it must not start with `"goog"`.
     *     @type string $topic
     *           Required. The name of the topic from which this subscription is receiving
     *           messages. Format is `projects/{project}/topics/{topic}`. The value of this
     *           field will be `_deleted-topic_` if the topic has been deleted.
     *     @type \Google\Cloud\PubSub\V1\PushConfig $push_config
     *           If push delivery is used with this subscription, this field is
     *           used to configure it. An empty `pushConfig` signifies that the subscriber
     *           will pull and ack messages using API methods.
     *     @type int $ack_deadline_seconds
     *           The approximate amount of time (on a best-effort basis) Pub/Sub waits for
     *           the subscriber to acknowledge receipt before resending the message. In the
     *           interval after the message is delivered and before it is acknowledged, it
     *           is considered to be <i>outstanding</i>. During that time period, the
     *           message will not be redelivered (on a best-effort basis).
     *           For pull subscriptions, this value is used as the initial value for the ack
     *           deadline. To override this value for a given message, call
     *           `ModifyAckDeadline` with the corresponding `ack_id` if using
     *           non-streaming pull or send the `ack_id` in a
     *           `StreamingModifyAckDeadlineRequest` if using streaming pull.
     *           The minimum custom deadline you can specify is 10 seconds.
     *           The maximum custom deadline you can specify is 600 seconds (10 minutes).
     *           If this parameter is 0, a default value of 10 seconds is used.
     *           For push delivery, this value is also used to set the request timeout for
     *           the call to the push endpoint.
     *           If the subscriber never acknowledges the message, the Pub/Sub
     *           system will eventually redeliver the message.
     *     @type bool $retain_acked_messages
     *           Indicates whether to retain acknowledged messages. If true, then
     *           messages are not expunged from the subscription's backlog, even if they are
     *           acknowledged, until they fall out of the `message_retention_duration`
     *           window. This must be true if you would like to
     *           <a
     *           href="https://cloud.google.com/pubsub/docs/replay-overview#seek_to_a_time">
     *           Seek to a timestamp</a>.
     *     @type \Google\Protobuf\Duration $message_retention_duration
     *           How long to retain unacknowledged messages in the subscription's backlog,
     *           from the moment a message is published.
     *           If `retain_acked_messages` is true, then this also configures the retention
     *           of acknowledged messages, and thus configures how far back in time a `Seek`
     *           can be done. Defaults to 7 days. Cannot be more than 7 days or less than 10
     *           minutes.
     *     @type array|\Google\Protobuf\Internal\MapField $labels
     *           See <a href="https://cloud.google.com/pubsub/docs/labels"> Creating and
     *           managing labels</a>.
     *     @type bool $enable_message_ordering
     *           If true, messages published with the same `ordering_key` in `PubsubMessage`
     *           will be delivered to the subscribers in the order in which they
     *           are received by the Pub/Sub system. Otherwise, they may be delivered in
     *           any order.
     *           <b>EXPERIMENTAL:</b> This feature is part of a closed alpha release. This
     *           API might be changed in backward-incompatible ways and is not recommended
     *           for production use. It is not subject to any SLA or deprecation policy.
     *     @type \Google\Cloud\PubSub\V1\ExpirationPolicy $expiration_policy
     *           A policy that specifies the conditions for this subscription's expiration.
     *           A subscription is considered active as long as any connected subscriber is
     *           successfully consuming messages from the subscription or is issuing
     *           operations on the subscription. If `expiration_policy` is not set, a
     *           *default policy* with `ttl` of 31 days will be used. The minimum allowed
     *           value for `expiration_policy.ttl` is 1 day.
     *     @type string $filter
     *           An expression written in the Cloud Pub/Sub filter language. If non-empty,
     *           then only `PubsubMessage`s whose `attributes` field matches the filter are
     *           delivered on this subscription. If empty, then no messages are filtered
     *           out.
     *           <b>EXPERIMENTAL:</b> This feature is part of a closed alpha release. This
     *           API might be changed in backward-incompatible ways and is not recommended
     *           for production use. It is not subject to any SLA or deprecation policy.
     *     @type \Google\Cloud\PubSub\V1\DeadLetterPolicy $dead_letter_policy
     *           A policy that specifies the conditions for dead lettering messages in
     *           this subscription. If dead_letter_policy is not set, dead lettering
     *           is disabled.
     *           The Cloud Pub/Sub service account associated with this subscriptions's
     *           parent project (i.e.,
     *           service-{project_number}&#64;gcp-sa-pubsub.iam.gserviceaccount.com) must have
     *           permission to Acknowledge() messages on this subscription.
     *           <b>EXPERIMENTAL:</b> This feature is part of a closed alpha release. This
     *           API might be changed in backward-incompatible ways and is not recommended
     *           for production use. It is not subject to any SLA or deprecation policy.
     *     @type \Google\Cloud\PubSub\V1\RetryPolicy $retry_policy
     *           A policy that specifies how Cloud Pub/Sub retries message delivery for this
     *           subscription.
     *           If not set, the default retry policy is applied. This generally implies
     *           that messages will be retried as soon as possible for healthy subscribers.
     *           RetryPolicy will be triggered on NACKs or acknowledgement deadline
     *           exceeded events for a given message.
     *           <b>EXPERIMENTAL:</b> This API might be changed in backward-incompatible
     *           ways and is not recommended for production use. It is not subject to any
     *           SLA or deprecation policy.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Pubsub\V1\Pubsub::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the subscription. It must have the format
     * `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
     * start with a letter, and contain only letters (`[A-Za-z]`), numbers
     * (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
     * plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
     * in length, and it must not start with `"goog"`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The name of the subscription. It must have the format
     * `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
     * start with a letter, and contain only letters (`[A-Za-z]`), numbers
     * (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
     * plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
     * in length, and it must not start with `"goog"`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

    /**
     * Required. The name of the topic from which this subscription is receiving
     * messages. Format is `projects/{project}/topics/{topic}`. The value of this
     * field will be `_deleted-topic_` if the topic has been deleted.
     *
     * Generated from protobuf field <code>string topic = 2 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getTopic()
    {
        return $this->topic;
    }

    /**
     * Required. The name of the topic from which this subscription is receiving
     * messages. Format is `projects/{project}/topics/{topic}`. The value of this
     * field will be `_deleted-topic_` if the topic has been deleted.
     *
     * Generated from protobuf field <code>string topic = 2 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setTopic($var)
    {
        GPBUtil::checkString($var, True);
        $this->topic = $var;

        return $this;
    }

    /**
     * If push delivery is used with this subscription, this field is
     * used to configure it. An empty `pushConfig` signifies that the subscriber
     * will pull and ack messages using API methods.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.PushConfig push_config = 4;</code>
     * @return \Google\Cloud\PubSub\V1\PushConfig
     */
    public function getPushConfig()
    {
        return $this->push_config;
    }

    /**
     * If push delivery is used with this subscription, this field is
     * used to configure it. An empty `pushConfig` signifies that the subscriber
     * will pull and ack messages using API methods.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.PushConfig push_config = 4;</code>
     * @param \Google\Cloud\PubSub\V1\PushConfig $var
     * @return $this
     */
    public function setPushConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\PubSub\V1\PushConfig::class);
        $this->push_config = $var;

        return $this;
    }

    /**
     * The approximate amount of time (on a best-effort basis) Pub/Sub waits for
     * the subscriber to acknowledge receipt before resending the message. In the
     * interval after the message is delivered and before it is acknowledged, it
     * is considered to be <i>outstanding</i>. During that time period, the
     * message will not be redelivered (on a best-effort basis).
     * For pull subscriptions, this value is used as the initial value for the ack
     * deadline. To override this value for a given message, call
     * `ModifyAckDeadline` with the corresponding `ack_id` if using
     * non-streaming pull or send the `ack_id` in a
     * `StreamingModifyAckDeadlineRequest` if using streaming pull.
     * The minimum custom deadline you can specify is 10 seconds.
     * The maximum custom deadline you can specify is 600 seconds (10 minutes).
     * If this parameter is 0, a default value of 10 seconds is used.
     * For push delivery, this value is also used to set the request timeout for
     * the call to the push endpoint.
     * If the subscriber never acknowledges the message, the Pub/Sub
     * system will eventually redeliver the message.
     *
     * Generated from protobuf field <code>int32 ack_deadline_seconds = 5;</code>
     * @return int
     */
    public function getAckDeadlineSeconds()
    {
        return $this->ack_deadline_seconds;
    }

    /**
     * The approximate amount of time (on a best-effort basis) Pub/Sub waits for
     * the subscriber to acknowledge receipt before resending the message. In the
     * interval after the message is delivered and before it is acknowledged, it
     * is considered to be <i>outstanding</i>. During that time period, the
     * message will not be redelivered (on a best-effort basis).
     * For pull subscriptions, this value is used as the initial value for the ack
     * deadline. To override this value for a given message, call
     * `ModifyAckDeadline` with the corresponding `ack_id` if using
     * non-streaming pull or send the `ack_id` in a
     * `StreamingModifyAckDeadlineRequest` if using streaming pull.
     * The minimum custom deadline you can specify is 10 seconds.
     * The maximum custom deadline you can specify is 600 seconds (10 minutes).
     * If this parameter is 0, a default value of 10 seconds is used.
     * For push delivery, this value is also used to set the request timeout for
     * the call to the push endpoint.
     * If the subscriber never acknowledges the message, the Pub/Sub
     * system will eventually redeliver the message.
     *
     * Generated from protobuf field <code>int32 ack_deadline_seconds = 5;</code>
     * @param int $var
     * @return $this
     */
    public function setAckDeadlineSeconds($var)
    {
        GPBUtil::checkInt32($var);
        $this->ack_deadline_seconds = $var;

        return $this;
    }

    /**
     * Indicates whether to retain acknowledged messages. If true, then
     * messages are not expunged from the subscription's backlog, even if they are
     * acknowledged, until they fall out of the `message_retention_duration`
     * window. This must be true if you would like to
     * <a
     * href="https://cloud.google.com/pubsub/docs/replay-overview#seek_to_a_time">
     * Seek to a timestamp</a>.
     *
     * Generated from protobuf field <code>bool retain_acked_messages = 7;</code>
     * @return bool
     */
    public function getRetainAckedMessages()
    {
        return $this->retain_acked_messages;
    }

    /**
     * Indicates whether to retain acknowledged messages. If true, then
     * messages are not expunged from the subscription's backlog, even if they are
     * acknowledged, until they fall out of the `message_retention_duration`
     * window. This must be true if you would like to
     * <a
     * href="https://cloud.google.com/pubsub/docs/replay-overview#seek_to_a_time">
     * Seek to a timestamp</a>.
     *
     * Generated from protobuf field <code>bool retain_acked_messages = 7;</code>
     * @param bool $var
     * @return $this
     */
    public function setRetainAckedMessages($var)
    {
        GPBUtil::checkBool($var);
        $this->retain_acked_messages = $var;

        return $this;
    }

    /**
     * How long to retain unacknowledged messages in the subscription's backlog,
     * from the moment a message is published.
     * If `retain_acked_messages` is true, then this also configures the retention
     * of acknowledged messages, and thus configures how far back in time a `Seek`
     * can be done. Defaults to 7 days. Cannot be more than 7 days or less than 10
     * minutes.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration message_retention_duration = 8;</code>
     * @return \Google\Protobuf\Duration
     */
    public function getMessageRetentionDuration()
    {
        return $this->message_retention_duration;
    }

    /**
     * How long to retain unacknowledged messages in the subscription's backlog,
     * from the moment a message is published.
     * If `retain_acked_messages` is true, then this also configures the retention
     * of acknowledged messages, and thus configures how far back in time a `Seek`
     * can be done. Defaults to 7 days. Cannot be more than 7 days or less than 10
     * minutes.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration message_retention_duration = 8;</code>
     * @param \Google\Protobuf\Duration $var
     * @return $this
     */
    public function setMessageRetentionDuration($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Duration::class);
        $this->message_retention_duration = $var;

        return $this;
    }

    /**
     * See <a href="https://cloud.google.com/pubsub/docs/labels"> Creating and
     * managing labels</a>.
     *
     * Generated from protobuf field <code>map<string, string> labels = 9;</code>
     * @return \Google\Protobuf\Internal\MapField
     */
    public function getLabels()
    {
        return $this->labels;
    }

    /**
     * See <a href="https://cloud.google.com/pubsub/docs/labels"> Creating and
     * managing labels</a>.
     *
     * Generated from protobuf field <code>map<string, string> labels = 9;</code>
     * @param array|\Google\Protobuf\Internal\MapField $var
     * @return $this
     */
    public function setLabels($var)
    {
        $arr = GPBUtil::checkMapField($var, \Google\Protobuf\Internal\GPBType::STRING, \Google\Protobuf\Internal\GPBType::STRING);
        $this->labels = $arr;

        return $this;
    }

    /**
     * If true, messages published with the same `ordering_key` in `PubsubMessage`
     * will be delivered to the subscribers in the order in which they
     * are received by the Pub/Sub system. Otherwise, they may be delivered in
     * any order.
     * <b>EXPERIMENTAL:</b> This feature is part of a closed alpha release. This
     * API might be changed in backward-incompatible ways and is not recommended
     * for production use. It is not subject to any SLA or deprecation policy.
     *
     * Generated from protobuf field <code>bool enable_message_ordering = 10;</code>
     * @return bool
     */
    public function getEnableMessageOrdering()
    {
        return $this->enable_message_ordering;
    }

    /**
     * If true, messages published with the same `ordering_key` in `PubsubMessage`
     * will be delivered to the subscribers in the order in which they
     * are received by the Pub/Sub system. Otherwise, they may be delivered in
     * any order.
     * <b>EXPERIMENTAL:</b> This feature is part of a closed alpha release. This
     * API might be changed in backward-incompatible ways and is not recommended
     * for production use. It is not subject to any SLA or deprecation policy.
     *
     * Generated from protobuf field <code>bool enable_message_ordering = 10;</code>
     * @param bool $var
     * @return $this
     */
    public function setEnableMessageOrdering($var)
    {
        GPBUtil::checkBool($var);
        $this->enable_message_ordering = $var;

        return $this;
    }

    /**
     * A policy that specifies the conditions for this subscription's expiration.
     * A subscription is considered active as long as any connected subscriber is
     * successfully consuming messages from the subscription or is issuing
     * operations on the subscription. If `expiration_policy` is not set, a
     * *default policy* with `ttl` of 31 days will be used. The minimum allowed
     * value for `expiration_policy.ttl` is 1 day.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.ExpirationPolicy expiration_policy = 11;</code>
     * @return \Google\Cloud\PubSub\V1\ExpirationPolicy
     */
    public function getExpirationPolicy()
    {
        return $this->expiration_policy;
    }

    /**
     * A policy that specifies the conditions for this subscription's expiration.
     * A subscription is considered active as long as any connected subscriber is
     * successfully consuming messages from the subscription or is issuing
     * operations on the subscription. If `expiration_policy` is not set, a
     * *default policy* with `ttl` of 31 days will be used. The minimum allowed
     * value for `expiration_policy.ttl` is 1 day.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.ExpirationPolicy expiration_policy = 11;</code>
     * @param \Google\Cloud\PubSub\V1\ExpirationPolicy $var
     * @return $this
     */
    public function setExpirationPolicy($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\PubSub\V1\ExpirationPolicy::class);
        $this->expiration_policy = $var;

        return $this;
    }

    /**
     * An expression written in the Cloud Pub/Sub filter language. If non-empty,
     * then only `PubsubMessage`s whose `attributes` field matches the filter are
     * delivered on this subscription. If empty, then no messages are filtered
     * out.
     * <b>EXPERIMENTAL:</b> This feature is part of a closed alpha release. This
     * API might be changed in backward-incompatible ways and is not recommended
     * for production use. It is not subject to any SLA or deprecation policy.
     *
     * Generated from protobuf field <code>string filter = 12;</code>
     * @return string
     */
    public function getFilter()
    {
        return $this->filter;
    }

    /**
     * An expression written in the Cloud Pub/Sub filter language. If non-empty,
     * then only `PubsubMessage`s whose `attributes` field matches the filter are
     * delivered on this subscription. If empty, then no messages are filtered
     * out.
     * <b>EXPERIMENTAL:</b> This feature is part of a closed alpha release. This
     * API might be changed in backward-incompatible ways and is not recommended
     * for production use. It is not subject to any SLA or deprecation policy.
     *
     * Generated from protobuf field <code>string filter = 12;</code>
     * @param string $var
     * @return $this
     */
    public function setFilter($var)
    {
        GPBUtil::checkString($var, True);
        $this->filter = $var;

        return $this;
    }

    /**
     * A policy that specifies the conditions for dead lettering messages in
     * this subscription. If dead_letter_policy is not set, dead lettering
     * is disabled.
     * The Cloud Pub/Sub service account associated with this subscriptions's
     * parent project (i.e.,
     * service-{project_number}&#64;gcp-sa-pubsub.iam.gserviceaccount.com) must have
     * permission to Acknowledge() messages on this subscription.
     * <b>EXPERIMENTAL:</b> This feature is part of a closed alpha release. This
     * API might be changed in backward-incompatible ways and is not recommended
     * for production use. It is not subject to any SLA or deprecation policy.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.DeadLetterPolicy dead_letter_policy = 13;</code>
     * @return \Google\Cloud\PubSub\V1\DeadLetterPolicy
     */
    public function getDeadLetterPolicy()
    {
        return $this->dead_letter_policy;
    }

    /**
     * A policy that specifies the conditions for dead lettering messages in
     * this subscription. If dead_letter_policy is not set, dead lettering
     * is disabled.
     * The Cloud Pub/Sub service account associated with this subscriptions's
     * parent project (i.e.,
     * service-{project_number}&#64;gcp-sa-pubsub.iam.gserviceaccount.com) must have
     * permission to Acknowledge() messages on this subscription.
     * <b>EXPERIMENTAL:</b> This feature is part of a closed alpha release. This
     * API might be changed in backward-incompatible ways and is not recommended
     * for production use. It is not subject to any SLA or deprecation policy.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.DeadLetterPolicy dead_letter_policy = 13;</code>
     * @param \Google\Cloud\PubSub\V1\DeadLetterPolicy $var
     * @return $this
     */
    public function setDeadLetterPolicy($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\PubSub\V1\DeadLetterPolicy::class);
        $this->dead_letter_policy = $var;

        return $this;
    }

    /**
     * A policy that specifies how Cloud Pub/Sub retries message delivery for this
     * subscription.
     * If not set, the default retry policy is applied. This generally implies
     * that messages will be retried as soon as possible for healthy subscribers.
     * RetryPolicy will be triggered on NACKs or acknowledgement deadline
     * exceeded events for a given message.
     * <b>EXPERIMENTAL:</b> This API might be changed in backward-incompatible
     * ways and is not recommended for production use. It is not subject to any
     * SLA or deprecation policy.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.RetryPolicy retry_policy = 14;</code>
     * @return \Google\Cloud\PubSub\V1\RetryPolicy
     */
    public function getRetryPolicy()
    {
        return $this->retry_policy;
    }

    /**
     * A policy that specifies how Cloud Pub/Sub retries message delivery for this
     * subscription.
     * If not set, the default retry policy is applied. This generally implies
     * that messages will be retried as soon as possible for healthy subscribers.
     * RetryPolicy will be triggered on NACKs or acknowledgement deadline
     * exceeded events for a given message.
     * <b>EXPERIMENTAL:</b> This API might be changed in backward-incompatible
     * ways and is not recommended for production use. It is not subject to any
     * SLA or deprecation policy.
     *
     * Generated from protobuf field <code>.google.pubsub.v1.RetryPolicy retry_policy = 14;</code>
     * @param \Google\Cloud\PubSub\V1\RetryPolicy $var
     * @return $this
     */
    public function setRetryPolicy($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\PubSub\V1\RetryPolicy::class);
        $this->retry_policy = $var;

        return $this;
    }

}

