// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/securitycenter/v1beta1/finding.proto

package com.google.cloud.securitycenter.v1beta1;

public interface FindingOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.securitycenter.v1beta1.Finding)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The relative resource name of this finding. See:
   * https://cloud.google.com/apis/design/resource_names#relative_resource_name
   * Example:
   * "organizations/123/sources/456/findings/789"
   * </pre>
   *
   * <code>string name = 1;</code>
   */
  java.lang.String getName();
  /**
   * <pre>
   * The relative resource name of this finding. See:
   * https://cloud.google.com/apis/design/resource_names#relative_resource_name
   * Example:
   * "organizations/123/sources/456/findings/789"
   * </pre>
   *
   * <code>string name = 1;</code>
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * The relative resource name of the source the finding belongs to. See:
   * https://cloud.google.com/apis/design/resource_names#relative_resource_name
   * This field is immutable after creation time.
   * For example:
   * "organizations/123/sources/456"
   * </pre>
   *
   * <code>string parent = 2;</code>
   */
  java.lang.String getParent();
  /**
   * <pre>
   * The relative resource name of the source the finding belongs to. See:
   * https://cloud.google.com/apis/design/resource_names#relative_resource_name
   * This field is immutable after creation time.
   * For example:
   * "organizations/123/sources/456"
   * </pre>
   *
   * <code>string parent = 2;</code>
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * The full resource name of the Google Cloud Platform (GCP) resource this
   * finding is for. See:
   * https://cloud.google.com/apis/design/resource_names#full_resource_name
   * This field is immutable after creation time.
   * </pre>
   *
   * <code>string resource_name = 3;</code>
   */
  java.lang.String getResourceName();
  /**
   * <pre>
   * The full resource name of the Google Cloud Platform (GCP) resource this
   * finding is for. See:
   * https://cloud.google.com/apis/design/resource_names#full_resource_name
   * This field is immutable after creation time.
   * </pre>
   *
   * <code>string resource_name = 3;</code>
   */
  com.google.protobuf.ByteString
      getResourceNameBytes();

  /**
   * <pre>
   * The state of the finding.
   * </pre>
   *
   * <code>.google.cloud.securitycenter.v1beta1.Finding.State state = 4;</code>
   */
  int getStateValue();
  /**
   * <pre>
   * The state of the finding.
   * </pre>
   *
   * <code>.google.cloud.securitycenter.v1beta1.Finding.State state = 4;</code>
   */
  com.google.cloud.securitycenter.v1beta1.Finding.State getState();

  /**
   * <pre>
   * The additional taxonomy group within findings from a given source.
   * This field is immutable after creation time.
   * Example: "XSS_FLASH_INJECTION"
   * </pre>
   *
   * <code>string category = 5;</code>
   */
  java.lang.String getCategory();
  /**
   * <pre>
   * The additional taxonomy group within findings from a given source.
   * This field is immutable after creation time.
   * Example: "XSS_FLASH_INJECTION"
   * </pre>
   *
   * <code>string category = 5;</code>
   */
  com.google.protobuf.ByteString
      getCategoryBytes();

  /**
   * <pre>
   * The URI that, if available, points to a web page outside of Cloud SCC
   * where additional information about the finding can be found. This field is
   * guaranteed to be either empty or a well formed URL.
   * </pre>
   *
   * <code>string external_uri = 6;</code>
   */
  java.lang.String getExternalUri();
  /**
   * <pre>
   * The URI that, if available, points to a web page outside of Cloud SCC
   * where additional information about the finding can be found. This field is
   * guaranteed to be either empty or a well formed URL.
   * </pre>
   *
   * <code>string external_uri = 6;</code>
   */
  com.google.protobuf.ByteString
      getExternalUriBytes();

  /**
   * <pre>
   * Source specific properties. These properties are managed by the source
   * that writes the finding. The key names in the source_properties map must be
   * between 1 and 255 characters, and must start with a letter and contain
   * alphanumeric characters or underscores only.
   * </pre>
   *
   * <code>map&lt;string, .google.protobuf.Value&gt; source_properties = 7;</code>
   */
  int getSourcePropertiesCount();
  /**
   * <pre>
   * Source specific properties. These properties are managed by the source
   * that writes the finding. The key names in the source_properties map must be
   * between 1 and 255 characters, and must start with a letter and contain
   * alphanumeric characters or underscores only.
   * </pre>
   *
   * <code>map&lt;string, .google.protobuf.Value&gt; source_properties = 7;</code>
   */
  boolean containsSourceProperties(
      java.lang.String key);
  /**
   * Use {@link #getSourcePropertiesMap()} instead.
   */
  @java.lang.Deprecated
  java.util.Map<java.lang.String, com.google.protobuf.Value>
  getSourceProperties();
  /**
   * <pre>
   * Source specific properties. These properties are managed by the source
   * that writes the finding. The key names in the source_properties map must be
   * between 1 and 255 characters, and must start with a letter and contain
   * alphanumeric characters or underscores only.
   * </pre>
   *
   * <code>map&lt;string, .google.protobuf.Value&gt; source_properties = 7;</code>
   */
  java.util.Map<java.lang.String, com.google.protobuf.Value>
  getSourcePropertiesMap();
  /**
   * <pre>
   * Source specific properties. These properties are managed by the source
   * that writes the finding. The key names in the source_properties map must be
   * between 1 and 255 characters, and must start with a letter and contain
   * alphanumeric characters or underscores only.
   * </pre>
   *
   * <code>map&lt;string, .google.protobuf.Value&gt; source_properties = 7;</code>
   */

  com.google.protobuf.Value getSourcePropertiesOrDefault(
      java.lang.String key,
      com.google.protobuf.Value defaultValue);
  /**
   * <pre>
   * Source specific properties. These properties are managed by the source
   * that writes the finding. The key names in the source_properties map must be
   * between 1 and 255 characters, and must start with a letter and contain
   * alphanumeric characters or underscores only.
   * </pre>
   *
   * <code>map&lt;string, .google.protobuf.Value&gt; source_properties = 7;</code>
   */

  com.google.protobuf.Value getSourcePropertiesOrThrow(
      java.lang.String key);

  /**
   * <pre>
   * Output only. User specified security marks. These marks are entirely
   * managed by the user and come from the SecurityMarks resource that belongs
   * to the finding.
   * </pre>
   *
   * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 8;</code>
   */
  boolean hasSecurityMarks();
  /**
   * <pre>
   * Output only. User specified security marks. These marks are entirely
   * managed by the user and come from the SecurityMarks resource that belongs
   * to the finding.
   * </pre>
   *
   * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 8;</code>
   */
  com.google.cloud.securitycenter.v1beta1.SecurityMarks getSecurityMarks();
  /**
   * <pre>
   * Output only. User specified security marks. These marks are entirely
   * managed by the user and come from the SecurityMarks resource that belongs
   * to the finding.
   * </pre>
   *
   * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 8;</code>
   */
  com.google.cloud.securitycenter.v1beta1.SecurityMarksOrBuilder getSecurityMarksOrBuilder();

  /**
   * <pre>
   * The time at which the event took place. For example, if the finding
   * represents an open firewall it would capture the time the open firewall was
   * detected.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp event_time = 9;</code>
   */
  boolean hasEventTime();
  /**
   * <pre>
   * The time at which the event took place. For example, if the finding
   * represents an open firewall it would capture the time the open firewall was
   * detected.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp event_time = 9;</code>
   */
  com.google.protobuf.Timestamp getEventTime();
  /**
   * <pre>
   * The time at which the event took place. For example, if the finding
   * represents an open firewall it would capture the time the open firewall was
   * detected.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp event_time = 9;</code>
   */
  com.google.protobuf.TimestampOrBuilder getEventTimeOrBuilder();

  /**
   * <pre>
   * The time at which the finding was created in Cloud SCC.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp create_time = 10;</code>
   */
  boolean hasCreateTime();
  /**
   * <pre>
   * The time at which the finding was created in Cloud SCC.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp create_time = 10;</code>
   */
  com.google.protobuf.Timestamp getCreateTime();
  /**
   * <pre>
   * The time at which the finding was created in Cloud SCC.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp create_time = 10;</code>
   */
  com.google.protobuf.TimestampOrBuilder getCreateTimeOrBuilder();
}
