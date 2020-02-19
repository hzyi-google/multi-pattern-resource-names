// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/privacy/dlp/v2/dlp.proto

package com.google.privacy.dlp.v2;

public interface ListInfoTypesRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.privacy.dlp.v2.ListInfoTypesRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * BCP-47 language code for localized infoType friendly
   * names. If omitted, or if localized strings are not available,
   * en-US strings will be returned.
   * </pre>
   *
   * <code>string language_code = 1;</code>
   * @return The languageCode.
   */
  java.lang.String getLanguageCode();
  /**
   * <pre>
   * BCP-47 language code for localized infoType friendly
   * names. If omitted, or if localized strings are not available,
   * en-US strings will be returned.
   * </pre>
   *
   * <code>string language_code = 1;</code>
   * @return The bytes for languageCode.
   */
  com.google.protobuf.ByteString
      getLanguageCodeBytes();

  /**
   * <pre>
   * filter to only return infoTypes supported by certain parts of the
   * API. Defaults to supported_by=INSPECT.
   * </pre>
   *
   * <code>string filter = 2;</code>
   * @return The filter.
   */
  java.lang.String getFilter();
  /**
   * <pre>
   * filter to only return infoTypes supported by certain parts of the
   * API. Defaults to supported_by=INSPECT.
   * </pre>
   *
   * <code>string filter = 2;</code>
   * @return The bytes for filter.
   */
  com.google.protobuf.ByteString
      getFilterBytes();

  /**
   * <pre>
   * The geographic location to list info types. Reserved for future
   * extensions.
   * </pre>
   *
   * <code>string location_id = 3;</code>
   * @return The locationId.
   */
  java.lang.String getLocationId();
  /**
   * <pre>
   * The geographic location to list info types. Reserved for future
   * extensions.
   * </pre>
   *
   * <code>string location_id = 3;</code>
   * @return The bytes for locationId.
   */
  com.google.protobuf.ByteString
      getLocationIdBytes();
}