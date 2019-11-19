// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/privacy/dlp/v2/dlp.proto

package com.google.privacy.dlp.v2;

public interface RedactImageResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.privacy.dlp.v2.RedactImageResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The redacted image. The type will be the same as the original image.
   * </pre>
   *
   * <code>bytes redacted_image = 1;</code>
   */
  com.google.protobuf.ByteString getRedactedImage();

  /**
   * <pre>
   * If an image was being inspected and the InspectConfig's include_quote was
   * set to true, then this field will include all text, if any, that was found
   * in the image.
   * </pre>
   *
   * <code>string extracted_text = 2;</code>
   */
  java.lang.String getExtractedText();
  /**
   * <pre>
   * If an image was being inspected and the InspectConfig's include_quote was
   * set to true, then this field will include all text, if any, that was found
   * in the image.
   * </pre>
   *
   * <code>string extracted_text = 2;</code>
   */
  com.google.protobuf.ByteString
      getExtractedTextBytes();

  /**
   * <pre>
   * The findings. Populated when include_findings in the request is true.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.InspectResult inspect_result = 3;</code>
   */
  boolean hasInspectResult();
  /**
   * <pre>
   * The findings. Populated when include_findings in the request is true.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.InspectResult inspect_result = 3;</code>
   */
  com.google.privacy.dlp.v2.InspectResult getInspectResult();
  /**
   * <pre>
   * The findings. Populated when include_findings in the request is true.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.InspectResult inspect_result = 3;</code>
   */
  com.google.privacy.dlp.v2.InspectResultOrBuilder getInspectResultOrBuilder();
}
