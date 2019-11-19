// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4beta1/common.proto

package com.google.cloud.talent.v4beta1;

public interface RequestMetadataOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.talent.v4beta1.RequestMetadata)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required if
   * [allow_missing_ids][google.cloud.talent.v4beta1.RequestMetadata.allow_missing_ids]
   * is unset or `false`.
   * The client-defined scope or source of the service call, which typically
   * is the domain on
   * which the service has been implemented and is currently being run.
   * For example, if the service is being run by client &lt;em&gt;Foo, Inc.&lt;/em&gt;, on
   * job board www.foo.com and career site www.bar.com, then this field is
   * set to "foo.com" for use on the job board, and "bar.com" for use on the
   * career site.
   * Note that any improvements to the model for a particular tenant site rely
   * on this field being set correctly to a unique domain.
   * The maximum number of allowed characters is 255.
   * </pre>
   *
   * <code>string domain = 1;</code>
   */
  java.lang.String getDomain();
  /**
   * <pre>
   * Required if
   * [allow_missing_ids][google.cloud.talent.v4beta1.RequestMetadata.allow_missing_ids]
   * is unset or `false`.
   * The client-defined scope or source of the service call, which typically
   * is the domain on
   * which the service has been implemented and is currently being run.
   * For example, if the service is being run by client &lt;em&gt;Foo, Inc.&lt;/em&gt;, on
   * job board www.foo.com and career site www.bar.com, then this field is
   * set to "foo.com" for use on the job board, and "bar.com" for use on the
   * career site.
   * Note that any improvements to the model for a particular tenant site rely
   * on this field being set correctly to a unique domain.
   * The maximum number of allowed characters is 255.
   * </pre>
   *
   * <code>string domain = 1;</code>
   */
  com.google.protobuf.ByteString
      getDomainBytes();

  /**
   * <pre>
   * Required if
   * [allow_missing_ids][google.cloud.talent.v4beta1.RequestMetadata.allow_missing_ids]
   * is unset or `false`.
   * A unique session identification string. A session is defined as the
   * duration of an end user's interaction with the service over a certain
   * period.
   * Obfuscate this field for privacy concerns before
   * providing it to the service.
   * Note that any improvements to the model for a particular tenant site rely
   * on this field being set correctly to a unique session ID.
   * The maximum number of allowed characters is 255.
   * </pre>
   *
   * <code>string session_id = 2;</code>
   */
  java.lang.String getSessionId();
  /**
   * <pre>
   * Required if
   * [allow_missing_ids][google.cloud.talent.v4beta1.RequestMetadata.allow_missing_ids]
   * is unset or `false`.
   * A unique session identification string. A session is defined as the
   * duration of an end user's interaction with the service over a certain
   * period.
   * Obfuscate this field for privacy concerns before
   * providing it to the service.
   * Note that any improvements to the model for a particular tenant site rely
   * on this field being set correctly to a unique session ID.
   * The maximum number of allowed characters is 255.
   * </pre>
   *
   * <code>string session_id = 2;</code>
   */
  com.google.protobuf.ByteString
      getSessionIdBytes();

  /**
   * <pre>
   * Required if
   * [allow_missing_ids][google.cloud.talent.v4beta1.RequestMetadata.allow_missing_ids]
   * is unset or `false`.
   * A unique user identification string, as determined by the client.
   * To have the strongest positive impact on search quality
   * make sure the client-level is unique.
   * Obfuscate this field for privacy concerns before
   * providing it to the service.
   * Note that any improvements to the model for a particular tenant site rely
   * on this field being set correctly to a unique user ID.
   * The maximum number of allowed characters is 255.
   * </pre>
   *
   * <code>string user_id = 3;</code>
   */
  java.lang.String getUserId();
  /**
   * <pre>
   * Required if
   * [allow_missing_ids][google.cloud.talent.v4beta1.RequestMetadata.allow_missing_ids]
   * is unset or `false`.
   * A unique user identification string, as determined by the client.
   * To have the strongest positive impact on search quality
   * make sure the client-level is unique.
   * Obfuscate this field for privacy concerns before
   * providing it to the service.
   * Note that any improvements to the model for a particular tenant site rely
   * on this field being set correctly to a unique user ID.
   * The maximum number of allowed characters is 255.
   * </pre>
   *
   * <code>string user_id = 3;</code>
   */
  com.google.protobuf.ByteString
      getUserIdBytes();

  /**
   * <pre>
   * Only set when any of
   * [domain][google.cloud.talent.v4beta1.RequestMetadata.domain],
   * [session_id][google.cloud.talent.v4beta1.RequestMetadata.session_id] and
   * [user_id][google.cloud.talent.v4beta1.RequestMetadata.user_id] isn't
   * available for some reason. It is highly recommended not to set this field
   * and provide accurate
   * [domain][google.cloud.talent.v4beta1.RequestMetadata.domain],
   * [session_id][google.cloud.talent.v4beta1.RequestMetadata.session_id] and
   * [user_id][google.cloud.talent.v4beta1.RequestMetadata.user_id] for the best
   * service experience.
   * </pre>
   *
   * <code>bool allow_missing_ids = 4;</code>
   */
  boolean getAllowMissingIds();

  /**
   * <pre>
   * The type of device used by the job seeker at the time of the call to the
   * service.
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.DeviceInfo device_info = 5;</code>
   */
  boolean hasDeviceInfo();
  /**
   * <pre>
   * The type of device used by the job seeker at the time of the call to the
   * service.
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.DeviceInfo device_info = 5;</code>
   */
  com.google.cloud.talent.v4beta1.DeviceInfo getDeviceInfo();
  /**
   * <pre>
   * The type of device used by the job seeker at the time of the call to the
   * service.
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.DeviceInfo device_info = 5;</code>
   */
  com.google.cloud.talent.v4beta1.DeviceInfoOrBuilder getDeviceInfoOrBuilder();
}
