// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/privacy/dlp/v2/dlp.proto

package com.google.privacy.dlp.v2;

public interface ReidentifyContentRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.privacy.dlp.v2.ReidentifyContentRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The parent resource name.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. The parent resource name.
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Configuration for the re-identification of the content item.
   * This field shares the same proto message type that is used for
   * de-identification, however its usage here is for the reversal of the
   * previous de-identification. Re-identification is performed by examining
   * the transformations used to de-identify the items and executing the
   * reverse. This requires that only reversible transformations
   * be provided here. The reversible transformations are:
   *  - `CryptoDeterministicConfig`
   *  - `CryptoReplaceFfxFpeConfig`
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.DeidentifyConfig reidentify_config = 2;</code>
   */
  boolean hasReidentifyConfig();
  /**
   * <pre>
   * Configuration for the re-identification of the content item.
   * This field shares the same proto message type that is used for
   * de-identification, however its usage here is for the reversal of the
   * previous de-identification. Re-identification is performed by examining
   * the transformations used to de-identify the items and executing the
   * reverse. This requires that only reversible transformations
   * be provided here. The reversible transformations are:
   *  - `CryptoDeterministicConfig`
   *  - `CryptoReplaceFfxFpeConfig`
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.DeidentifyConfig reidentify_config = 2;</code>
   */
  com.google.privacy.dlp.v2.DeidentifyConfig getReidentifyConfig();
  /**
   * <pre>
   * Configuration for the re-identification of the content item.
   * This field shares the same proto message type that is used for
   * de-identification, however its usage here is for the reversal of the
   * previous de-identification. Re-identification is performed by examining
   * the transformations used to de-identify the items and executing the
   * reverse. This requires that only reversible transformations
   * be provided here. The reversible transformations are:
   *  - `CryptoDeterministicConfig`
   *  - `CryptoReplaceFfxFpeConfig`
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.DeidentifyConfig reidentify_config = 2;</code>
   */
  com.google.privacy.dlp.v2.DeidentifyConfigOrBuilder getReidentifyConfigOrBuilder();

  /**
   * <pre>
   * Configuration for the inspector.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.InspectConfig inspect_config = 3;</code>
   */
  boolean hasInspectConfig();
  /**
   * <pre>
   * Configuration for the inspector.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.InspectConfig inspect_config = 3;</code>
   */
  com.google.privacy.dlp.v2.InspectConfig getInspectConfig();
  /**
   * <pre>
   * Configuration for the inspector.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.InspectConfig inspect_config = 3;</code>
   */
  com.google.privacy.dlp.v2.InspectConfigOrBuilder getInspectConfigOrBuilder();

  /**
   * <pre>
   * The item to re-identify. Will be treated as text.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.ContentItem item = 4;</code>
   */
  boolean hasItem();
  /**
   * <pre>
   * The item to re-identify. Will be treated as text.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.ContentItem item = 4;</code>
   */
  com.google.privacy.dlp.v2.ContentItem getItem();
  /**
   * <pre>
   * The item to re-identify. Will be treated as text.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.ContentItem item = 4;</code>
   */
  com.google.privacy.dlp.v2.ContentItemOrBuilder getItemOrBuilder();

  /**
   * <pre>
   * Optional template to use. Any configuration directly specified in
   * `inspect_config` will override those set in the template. Singular fields
   * that are set in this request will replace their corresponding fields in the
   * template. Repeated fields are appended. Singular sub-messages and groups
   * are recursively merged.
   * </pre>
   *
   * <code>string inspect_template_name = 5;</code>
   */
  java.lang.String getInspectTemplateName();
  /**
   * <pre>
   * Optional template to use. Any configuration directly specified in
   * `inspect_config` will override those set in the template. Singular fields
   * that are set in this request will replace their corresponding fields in the
   * template. Repeated fields are appended. Singular sub-messages and groups
   * are recursively merged.
   * </pre>
   *
   * <code>string inspect_template_name = 5;</code>
   */
  com.google.protobuf.ByteString
      getInspectTemplateNameBytes();

  /**
   * <pre>
   * Optional template to use. References an instance of `DeidentifyTemplate`.
   * Any configuration directly specified in `reidentify_config` or
   * `inspect_config` will override those set in the template. Singular fields
   * that are set in this request will replace their corresponding fields in the
   * template. Repeated fields are appended. Singular sub-messages and groups
   * are recursively merged.
   * </pre>
   *
   * <code>string reidentify_template_name = 6;</code>
   */
  java.lang.String getReidentifyTemplateName();
  /**
   * <pre>
   * Optional template to use. References an instance of `DeidentifyTemplate`.
   * Any configuration directly specified in `reidentify_config` or
   * `inspect_config` will override those set in the template. Singular fields
   * that are set in this request will replace their corresponding fields in the
   * template. Repeated fields are appended. Singular sub-messages and groups
   * are recursively merged.
   * </pre>
   *
   * <code>string reidentify_template_name = 6;</code>
   */
  com.google.protobuf.ByteString
      getReidentifyTemplateNameBytes();
}
