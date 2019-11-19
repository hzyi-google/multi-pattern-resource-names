// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/containeranalysis/v1alpha1/source_context.proto

package com.google.containeranalysis.v1alpha1;

public interface GitSourceContextOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.devtools.containeranalysis.v1alpha1.GitSourceContext)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Git repository URL.
   * </pre>
   *
   * <code>string url = 1;</code>
   */
  java.lang.String getUrl();
  /**
   * <pre>
   * Git repository URL.
   * </pre>
   *
   * <code>string url = 1;</code>
   */
  com.google.protobuf.ByteString
      getUrlBytes();

  /**
   * <pre>
   * Required.
   * Git commit hash.
   * </pre>
   *
   * <code>string revision_id = 2;</code>
   */
  java.lang.String getRevisionId();
  /**
   * <pre>
   * Required.
   * Git commit hash.
   * </pre>
   *
   * <code>string revision_id = 2;</code>
   */
  com.google.protobuf.ByteString
      getRevisionIdBytes();
}
