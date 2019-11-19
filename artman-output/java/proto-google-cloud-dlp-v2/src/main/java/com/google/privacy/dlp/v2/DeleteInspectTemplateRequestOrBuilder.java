// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/privacy/dlp/v2/dlp.proto

package com.google.privacy.dlp.v2;

public interface DeleteInspectTemplateRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.privacy.dlp.v2.DeleteInspectTemplateRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. Resource name of the organization and inspectTemplate to be deleted, for
   * example `organizations/433245324/inspectTemplates/432452342` or
   * projects/project-id/inspectTemplates/432452342.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. Resource name of the organization and inspectTemplate to be deleted, for
   * example `organizations/433245324/inspectTemplates/432452342` or
   * projects/project-id/inspectTemplates/432452342.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   */
  com.google.protobuf.ByteString
      getNameBytes();
}
