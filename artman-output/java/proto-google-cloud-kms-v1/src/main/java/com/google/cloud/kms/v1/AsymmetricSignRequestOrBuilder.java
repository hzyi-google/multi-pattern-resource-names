// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/kms/v1/service.proto

package com.google.cloud.kms.v1;

public interface AsymmetricSignRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.kms.v1.AsymmetricSignRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The resource name of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to use for signing.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. The resource name of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to use for signing.
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * Required. The digest of the data to sign. The digest must be produced with
   * the same digest algorithm as specified by the key version's
   * [algorithm][google.cloud.kms.v1.CryptoKeyVersion.algorithm].
   * </pre>
   *
   * <code>.google.cloud.kms.v1.Digest digest = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the digest field is set.
   */
  boolean hasDigest();
  /**
   * <pre>
   * Required. The digest of the data to sign. The digest must be produced with
   * the same digest algorithm as specified by the key version's
   * [algorithm][google.cloud.kms.v1.CryptoKeyVersion.algorithm].
   * </pre>
   *
   * <code>.google.cloud.kms.v1.Digest digest = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The digest.
   */
  com.google.cloud.kms.v1.Digest getDigest();
  /**
   * <pre>
   * Required. The digest of the data to sign. The digest must be produced with
   * the same digest algorithm as specified by the key version's
   * [algorithm][google.cloud.kms.v1.CryptoKeyVersion.algorithm].
   * </pre>
   *
   * <code>.google.cloud.kms.v1.Digest digest = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.kms.v1.DigestOrBuilder getDigestOrBuilder();
}
