// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dataproc/v1beta2/jobs.proto

package com.google.cloud.dataproc.v1beta2;

public interface YarnApplicationOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dataproc.v1beta2.YarnApplication)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Output only. The application name.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  java.lang.String getName();
  /**
   * <pre>
   * Output only. The application name.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * Output only. The application state.
   * </pre>
   *
   * <code>.google.cloud.dataproc.v1beta2.YarnApplication.State state = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  int getStateValue();
  /**
   * <pre>
   * Output only. The application state.
   * </pre>
   *
   * <code>.google.cloud.dataproc.v1beta2.YarnApplication.State state = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.cloud.dataproc.v1beta2.YarnApplication.State getState();

  /**
   * <pre>
   * Output only. The numerical progress of the application, from 1 to 100.
   * </pre>
   *
   * <code>float progress = 3 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  float getProgress();

  /**
   * <pre>
   * Optional. Output only. The HTTP URL of the ApplicationMaster, HistoryServer, or
   * TimelineServer that provides application-specific information. The URL uses
   * the internal hostname, and requires a proxy server for resolution and,
   * possibly, access.
   * </pre>
   *
   * <code>string tracking_url = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  java.lang.String getTrackingUrl();
  /**
   * <pre>
   * Optional. Output only. The HTTP URL of the ApplicationMaster, HistoryServer, or
   * TimelineServer that provides application-specific information. The URL uses
   * the internal hostname, and requires a proxy server for resolution and,
   * possibly, access.
   * </pre>
   *
   * <code>string tracking_url = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.ByteString
      getTrackingUrlBytes();
}
