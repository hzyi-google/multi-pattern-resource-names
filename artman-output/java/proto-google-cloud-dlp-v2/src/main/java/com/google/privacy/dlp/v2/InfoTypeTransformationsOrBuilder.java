// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/privacy/dlp/v2/dlp.proto

package com.google.privacy.dlp.v2;

public interface InfoTypeTransformationsOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.privacy.dlp.v2.InfoTypeTransformations)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. Transformation for each infoType. Cannot specify more than one
   * for a given infoType.
   * </pre>
   *
   * <code>repeated .google.privacy.dlp.v2.InfoTypeTransformations.InfoTypeTransformation transformations = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  java.util.List<com.google.privacy.dlp.v2.InfoTypeTransformations.InfoTypeTransformation> 
      getTransformationsList();
  /**
   * <pre>
   * Required. Transformation for each infoType. Cannot specify more than one
   * for a given infoType.
   * </pre>
   *
   * <code>repeated .google.privacy.dlp.v2.InfoTypeTransformations.InfoTypeTransformation transformations = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.privacy.dlp.v2.InfoTypeTransformations.InfoTypeTransformation getTransformations(int index);
  /**
   * <pre>
   * Required. Transformation for each infoType. Cannot specify more than one
   * for a given infoType.
   * </pre>
   *
   * <code>repeated .google.privacy.dlp.v2.InfoTypeTransformations.InfoTypeTransformation transformations = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  int getTransformationsCount();
  /**
   * <pre>
   * Required. Transformation for each infoType. Cannot specify more than one
   * for a given infoType.
   * </pre>
   *
   * <code>repeated .google.privacy.dlp.v2.InfoTypeTransformations.InfoTypeTransformation transformations = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  java.util.List<? extends com.google.privacy.dlp.v2.InfoTypeTransformations.InfoTypeTransformationOrBuilder> 
      getTransformationsOrBuilderList();
  /**
   * <pre>
   * Required. Transformation for each infoType. Cannot specify more than one
   * for a given infoType.
   * </pre>
   *
   * <code>repeated .google.privacy.dlp.v2.InfoTypeTransformations.InfoTypeTransformation transformations = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.privacy.dlp.v2.InfoTypeTransformations.InfoTypeTransformationOrBuilder getTransformationsOrBuilder(
      int index);
}
