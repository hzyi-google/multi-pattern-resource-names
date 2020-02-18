// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/kms/v1/service.proto

package com.google.cloud.kms.v1;

public interface EncryptRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.kms.v1.EncryptRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The resource name of the [CryptoKey][google.cloud.kms.v1.CryptoKey] or [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion]
   * to use for encryption.
   * If a [CryptoKey][google.cloud.kms.v1.CryptoKey] is specified, the server will use its
   * [primary version][google.cloud.kms.v1.CryptoKey.primary].
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * Required. The resource name of the [CryptoKey][google.cloud.kms.v1.CryptoKey] or [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion]
   * to use for encryption.
   * If a [CryptoKey][google.cloud.kms.v1.CryptoKey] is specified, the server will use its
   * [primary version][google.cloud.kms.v1.CryptoKey.primary].
   * </pre>
   *
   * <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * Required. The data to encrypt. Must be no larger than 64KiB.
   * The maximum size depends on the key version's
   * [protection_level][google.cloud.kms.v1.CryptoKeyVersionTemplate.protection_level]. For
   * [SOFTWARE][google.cloud.kms.v1.ProtectionLevel.SOFTWARE] keys, the plaintext must be no larger
   * than 64KiB. For [HSM][google.cloud.kms.v1.ProtectionLevel.HSM] keys, the combined length of the
   * plaintext and additional_authenticated_data fields must be no larger than
   * 8KiB.
   * </pre>
   *
   * <code>bytes plaintext = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The plaintext.
   */
  com.google.protobuf.ByteString getPlaintext();

  /**
   * <pre>
   * Optional. Optional data that, if specified, must also be provided during decryption
   * through [DecryptRequest.additional_authenticated_data][google.cloud.kms.v1.DecryptRequest.additional_authenticated_data].
   * The maximum size depends on the key version's
   * [protection_level][google.cloud.kms.v1.CryptoKeyVersionTemplate.protection_level]. For
   * [SOFTWARE][google.cloud.kms.v1.ProtectionLevel.SOFTWARE] keys, the AAD must be no larger than
   * 64KiB. For [HSM][google.cloud.kms.v1.ProtectionLevel.HSM] keys, the combined length of the
   * plaintext and additional_authenticated_data fields must be no larger than
   * 8KiB.
   * </pre>
   *
   * <code>bytes additional_authenticated_data = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
   * @return The additionalAuthenticatedData.
   */
  com.google.protobuf.ByteString getAdditionalAuthenticatedData();
}