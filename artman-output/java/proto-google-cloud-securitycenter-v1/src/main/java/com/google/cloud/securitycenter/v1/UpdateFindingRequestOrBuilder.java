// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/securitycenter/v1/securitycenter_service.proto

package com.google.cloud.securitycenter.v1;

public interface UpdateFindingRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.securitycenter.v1.UpdateFindingRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The finding resource to update or create if it does not already exist.
   * parent, security_marks, and update_time will be ignored.
   * In the case of creation, the finding id portion of the name must be
   * alphanumeric and less than or equal to 32 characters and greater than 0
   * characters in length.
   * </pre>
   *
   * <code>.google.cloud.securitycenter.v1.Finding finding = 1;</code>
   */
  boolean hasFinding();
  /**
   * <pre>
   * The finding resource to update or create if it does not already exist.
   * parent, security_marks, and update_time will be ignored.
   * In the case of creation, the finding id portion of the name must be
   * alphanumeric and less than or equal to 32 characters and greater than 0
   * characters in length.
   * </pre>
   *
   * <code>.google.cloud.securitycenter.v1.Finding finding = 1;</code>
   */
  com.google.cloud.securitycenter.v1.Finding getFinding();
  /**
   * <pre>
   * The finding resource to update or create if it does not already exist.
   * parent, security_marks, and update_time will be ignored.
   * In the case of creation, the finding id portion of the name must be
   * alphanumeric and less than or equal to 32 characters and greater than 0
   * characters in length.
   * </pre>
   *
   * <code>.google.cloud.securitycenter.v1.Finding finding = 1;</code>
   */
  com.google.cloud.securitycenter.v1.FindingOrBuilder getFindingOrBuilder();

  /**
   * <pre>
   * The FieldMask to use when updating the finding resource. This field should
   * not be specified when creating a finding.
   * When updating a finding, an empty mask is treated as updating all mutable
   * fields and replacing source_properties.  Individual source_properties can
   * be added/updated by using "source_properties.&lt;property key&gt;" in the field
   * mask.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2;</code>
   */
  boolean hasUpdateMask();
  /**
   * <pre>
   * The FieldMask to use when updating the finding resource. This field should
   * not be specified when creating a finding.
   * When updating a finding, an empty mask is treated as updating all mutable
   * fields and replacing source_properties.  Individual source_properties can
   * be added/updated by using "source_properties.&lt;property key&gt;" in the field
   * mask.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2;</code>
   */
  com.google.protobuf.FieldMask getUpdateMask();
  /**
   * <pre>
   * The FieldMask to use when updating the finding resource. This field should
   * not be specified when creating a finding.
   * When updating a finding, an empty mask is treated as updating all mutable
   * fields and replacing source_properties.  Individual source_properties can
   * be added/updated by using "source_properties.&lt;property key&gt;" in the field
   * mask.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2;</code>
   */
  com.google.protobuf.FieldMaskOrBuilder getUpdateMaskOrBuilder();
}
