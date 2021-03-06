// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/kms/v1/service.proto

package com.google.cloud.kms.v1;

public interface ListCryptoKeyVersionsResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.kms.v1.ListCryptoKeyVersionsResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The list of [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion].
   * </pre>
   *
   * <code>repeated .google.cloud.kms.v1.CryptoKeyVersion crypto_key_versions = 1;</code>
   */
  java.util.List<com.google.cloud.kms.v1.CryptoKeyVersion> 
      getCryptoKeyVersionsList();
  /**
   * <pre>
   * The list of [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion].
   * </pre>
   *
   * <code>repeated .google.cloud.kms.v1.CryptoKeyVersion crypto_key_versions = 1;</code>
   */
  com.google.cloud.kms.v1.CryptoKeyVersion getCryptoKeyVersions(int index);
  /**
   * <pre>
   * The list of [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion].
   * </pre>
   *
   * <code>repeated .google.cloud.kms.v1.CryptoKeyVersion crypto_key_versions = 1;</code>
   */
  int getCryptoKeyVersionsCount();
  /**
   * <pre>
   * The list of [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion].
   * </pre>
   *
   * <code>repeated .google.cloud.kms.v1.CryptoKeyVersion crypto_key_versions = 1;</code>
   */
  java.util.List<? extends com.google.cloud.kms.v1.CryptoKeyVersionOrBuilder> 
      getCryptoKeyVersionsOrBuilderList();
  /**
   * <pre>
   * The list of [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion].
   * </pre>
   *
   * <code>repeated .google.cloud.kms.v1.CryptoKeyVersion crypto_key_versions = 1;</code>
   */
  com.google.cloud.kms.v1.CryptoKeyVersionOrBuilder getCryptoKeyVersionsOrBuilder(
      int index);

  /**
   * <pre>
   * A token to retrieve next page of results. Pass this value in
   * [ListCryptoKeyVersionsRequest.page_token][google.cloud.kms.v1.ListCryptoKeyVersionsRequest.page_token] to retrieve the next page of
   * results.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The nextPageToken.
   */
  java.lang.String getNextPageToken();
  /**
   * <pre>
   * A token to retrieve next page of results. Pass this value in
   * [ListCryptoKeyVersionsRequest.page_token][google.cloud.kms.v1.ListCryptoKeyVersionsRequest.page_token] to retrieve the next page of
   * results.
   * </pre>
   *
   * <code>string next_page_token = 2;</code>
   * @return The bytes for nextPageToken.
   */
  com.google.protobuf.ByteString
      getNextPageTokenBytes();

  /**
   * <pre>
   * The total number of [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion] that matched the
   * query.
   * </pre>
   *
   * <code>int32 total_size = 3;</code>
   * @return The totalSize.
   */
  int getTotalSize();
}
