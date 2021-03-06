// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/logging/v2/logging_metrics.proto

package com.google.logging.v2;

public interface DeleteLogMetricRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.logging.v2.DeleteLogMetricRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The resource name of the metric to delete:
   *     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
   * </pre>
   *
   * <code>string metric_name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The metricName.
   */
  java.lang.String getMetricName();
  /**
   * <pre>
   * Required. The resource name of the metric to delete:
   *     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
   * </pre>
   *
   * <code>string metric_name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for metricName.
   */
  com.google.protobuf.ByteString
      getMetricNameBytes();
}
