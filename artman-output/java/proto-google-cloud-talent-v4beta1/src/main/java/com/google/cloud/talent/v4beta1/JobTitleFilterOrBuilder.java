// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4beta1/filters.proto

package com.google.cloud.talent.v4beta1;

public interface JobTitleFilterOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.talent.v4beta1.JobTitleFilter)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The job title. For example, "Software engineer", or "Product
   * manager".
   * </pre>
   *
   * <code>string job_title = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  java.lang.String getJobTitle();
  /**
   * <pre>
   * Required. The job title. For example, "Software engineer", or "Product
   * manager".
   * </pre>
   *
   * <code>string job_title = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.protobuf.ByteString
      getJobTitleBytes();

  /**
   * <pre>
   * Whether to apply negation to the filter so profiles matching the filter
   * are excluded.
   * </pre>
   *
   * <code>bool negated = 2;</code>
   */
  boolean getNegated();
}
