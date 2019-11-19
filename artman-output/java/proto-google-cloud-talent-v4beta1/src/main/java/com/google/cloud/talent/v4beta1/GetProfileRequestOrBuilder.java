// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4beta1/profile_service.proto

package com.google.cloud.talent.v4beta1;

public interface GetProfileRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.talent.v4beta1.GetProfileRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. Resource name of the profile to get.
   * The format is
   * "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}". For
   * example, "projects/foo/tenants/bar/profiles/baz".
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. Resource name of the profile to get.
   * The format is
   * "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}". For
   * example, "projects/foo/tenants/bar/profiles/baz".
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.protobuf.ByteString
      getNameBytes();
}
