// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/securitycenter/v1beta1/securitycenter_service.proto

package com.google.cloud.securitycenter.v1beta1;

/**
 * <pre>
 * Request message for updating a SecurityMarks resource.
 * </pre>
 *
 * Protobuf type {@code google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest}
 */
public  final class UpdateSecurityMarksRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest)
    UpdateSecurityMarksRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use UpdateSecurityMarksRequest.newBuilder() to construct.
  private UpdateSecurityMarksRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private UpdateSecurityMarksRequest() {
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private UpdateSecurityMarksRequest(
      com.google.protobuf.CodedInputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    this();
    if (extensionRegistry == null) {
      throw new java.lang.NullPointerException();
    }
    int mutable_bitField0_ = 0;
    com.google.protobuf.UnknownFieldSet.Builder unknownFields =
        com.google.protobuf.UnknownFieldSet.newBuilder();
    try {
      boolean done = false;
      while (!done) {
        int tag = input.readTag();
        switch (tag) {
          case 0:
            done = true;
            break;
          case 10: {
            com.google.cloud.securitycenter.v1beta1.SecurityMarks.Builder subBuilder = null;
            if (securityMarks_ != null) {
              subBuilder = securityMarks_.toBuilder();
            }
            securityMarks_ = input.readMessage(com.google.cloud.securitycenter.v1beta1.SecurityMarks.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(securityMarks_);
              securityMarks_ = subBuilder.buildPartial();
            }

            break;
          }
          case 18: {
            com.google.protobuf.FieldMask.Builder subBuilder = null;
            if (updateMask_ != null) {
              subBuilder = updateMask_.toBuilder();
            }
            updateMask_ = input.readMessage(com.google.protobuf.FieldMask.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(updateMask_);
              updateMask_ = subBuilder.buildPartial();
            }

            break;
          }
          case 26: {
            com.google.protobuf.Timestamp.Builder subBuilder = null;
            if (startTime_ != null) {
              subBuilder = startTime_.toBuilder();
            }
            startTime_ = input.readMessage(com.google.protobuf.Timestamp.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(startTime_);
              startTime_ = subBuilder.buildPartial();
            }

            break;
          }
          default: {
            if (!parseUnknownField(
                input, unknownFields, extensionRegistry, tag)) {
              done = true;
            }
            break;
          }
        }
      }
    } catch (com.google.protobuf.InvalidProtocolBufferException e) {
      throw e.setUnfinishedMessage(this);
    } catch (java.io.IOException e) {
      throw new com.google.protobuf.InvalidProtocolBufferException(
          e).setUnfinishedMessage(this);
    } finally {
      this.unknownFields = unknownFields.build();
      makeExtensionsImmutable();
    }
  }
  public static final com.google.protobuf.Descriptors.Descriptor
      getDescriptor() {
    return com.google.cloud.securitycenter.v1beta1.SecuritycenterService.internal_static_google_cloud_securitycenter_v1beta1_UpdateSecurityMarksRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.securitycenter.v1beta1.SecuritycenterService.internal_static_google_cloud_securitycenter_v1beta1_UpdateSecurityMarksRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest.class, com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest.Builder.class);
  }

  public static final int SECURITY_MARKS_FIELD_NUMBER = 1;
  private com.google.cloud.securitycenter.v1beta1.SecurityMarks securityMarks_;
  /**
   * <pre>
   * The security marks resource to update.
   * </pre>
   *
   * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 1;</code>
   */
  public boolean hasSecurityMarks() {
    return securityMarks_ != null;
  }
  /**
   * <pre>
   * The security marks resource to update.
   * </pre>
   *
   * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 1;</code>
   */
  public com.google.cloud.securitycenter.v1beta1.SecurityMarks getSecurityMarks() {
    return securityMarks_ == null ? com.google.cloud.securitycenter.v1beta1.SecurityMarks.getDefaultInstance() : securityMarks_;
  }
  /**
   * <pre>
   * The security marks resource to update.
   * </pre>
   *
   * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 1;</code>
   */
  public com.google.cloud.securitycenter.v1beta1.SecurityMarksOrBuilder getSecurityMarksOrBuilder() {
    return getSecurityMarks();
  }

  public static final int UPDATE_MASK_FIELD_NUMBER = 2;
  private com.google.protobuf.FieldMask updateMask_;
  /**
   * <pre>
   * The FieldMask to use when updating the security marks resource.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2;</code>
   */
  public boolean hasUpdateMask() {
    return updateMask_ != null;
  }
  /**
   * <pre>
   * The FieldMask to use when updating the security marks resource.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2;</code>
   */
  public com.google.protobuf.FieldMask getUpdateMask() {
    return updateMask_ == null ? com.google.protobuf.FieldMask.getDefaultInstance() : updateMask_;
  }
  /**
   * <pre>
   * The FieldMask to use when updating the security marks resource.
   * </pre>
   *
   * <code>.google.protobuf.FieldMask update_mask = 2;</code>
   */
  public com.google.protobuf.FieldMaskOrBuilder getUpdateMaskOrBuilder() {
    return getUpdateMask();
  }

  public static final int START_TIME_FIELD_NUMBER = 3;
  private com.google.protobuf.Timestamp startTime_;
  /**
   * <pre>
   * The time at which the updated SecurityMarks take effect.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp start_time = 3;</code>
   */
  public boolean hasStartTime() {
    return startTime_ != null;
  }
  /**
   * <pre>
   * The time at which the updated SecurityMarks take effect.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp start_time = 3;</code>
   */
  public com.google.protobuf.Timestamp getStartTime() {
    return startTime_ == null ? com.google.protobuf.Timestamp.getDefaultInstance() : startTime_;
  }
  /**
   * <pre>
   * The time at which the updated SecurityMarks take effect.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp start_time = 3;</code>
   */
  public com.google.protobuf.TimestampOrBuilder getStartTimeOrBuilder() {
    return getStartTime();
  }

  private byte memoizedIsInitialized = -1;
  @java.lang.Override
  public final boolean isInitialized() {
    byte isInitialized = memoizedIsInitialized;
    if (isInitialized == 1) return true;
    if (isInitialized == 0) return false;

    memoizedIsInitialized = 1;
    return true;
  }

  @java.lang.Override
  public void writeTo(com.google.protobuf.CodedOutputStream output)
                      throws java.io.IOException {
    if (securityMarks_ != null) {
      output.writeMessage(1, getSecurityMarks());
    }
    if (updateMask_ != null) {
      output.writeMessage(2, getUpdateMask());
    }
    if (startTime_ != null) {
      output.writeMessage(3, getStartTime());
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (securityMarks_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, getSecurityMarks());
    }
    if (updateMask_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(2, getUpdateMask());
    }
    if (startTime_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(3, getStartTime());
    }
    size += unknownFields.getSerializedSize();
    memoizedSize = size;
    return size;
  }

  @java.lang.Override
  public boolean equals(final java.lang.Object obj) {
    if (obj == this) {
     return true;
    }
    if (!(obj instanceof com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest)) {
      return super.equals(obj);
    }
    com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest other = (com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest) obj;

    if (hasSecurityMarks() != other.hasSecurityMarks()) return false;
    if (hasSecurityMarks()) {
      if (!getSecurityMarks()
          .equals(other.getSecurityMarks())) return false;
    }
    if (hasUpdateMask() != other.hasUpdateMask()) return false;
    if (hasUpdateMask()) {
      if (!getUpdateMask()
          .equals(other.getUpdateMask())) return false;
    }
    if (hasStartTime() != other.hasStartTime()) return false;
    if (hasStartTime()) {
      if (!getStartTime()
          .equals(other.getStartTime())) return false;
    }
    if (!unknownFields.equals(other.unknownFields)) return false;
    return true;
  }

  @java.lang.Override
  public int hashCode() {
    if (memoizedHashCode != 0) {
      return memoizedHashCode;
    }
    int hash = 41;
    hash = (19 * hash) + getDescriptor().hashCode();
    if (hasSecurityMarks()) {
      hash = (37 * hash) + SECURITY_MARKS_FIELD_NUMBER;
      hash = (53 * hash) + getSecurityMarks().hashCode();
    }
    if (hasUpdateMask()) {
      hash = (37 * hash) + UPDATE_MASK_FIELD_NUMBER;
      hash = (53 * hash) + getUpdateMask().hashCode();
    }
    if (hasStartTime()) {
      hash = (37 * hash) + START_TIME_FIELD_NUMBER;
      hash = (53 * hash) + getStartTime().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest parseFrom(
      com.google.protobuf.CodedInputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }

  @java.lang.Override
  public Builder newBuilderForType() { return newBuilder(); }
  public static Builder newBuilder() {
    return DEFAULT_INSTANCE.toBuilder();
  }
  public static Builder newBuilder(com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest prototype) {
    return DEFAULT_INSTANCE.toBuilder().mergeFrom(prototype);
  }
  @java.lang.Override
  public Builder toBuilder() {
    return this == DEFAULT_INSTANCE
        ? new Builder() : new Builder().mergeFrom(this);
  }

  @java.lang.Override
  protected Builder newBuilderForType(
      com.google.protobuf.GeneratedMessageV3.BuilderParent parent) {
    Builder builder = new Builder(parent);
    return builder;
  }
  /**
   * <pre>
   * Request message for updating a SecurityMarks resource.
   * </pre>
   *
   * Protobuf type {@code google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest)
      com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.securitycenter.v1beta1.SecuritycenterService.internal_static_google_cloud_securitycenter_v1beta1_UpdateSecurityMarksRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.securitycenter.v1beta1.SecuritycenterService.internal_static_google_cloud_securitycenter_v1beta1_UpdateSecurityMarksRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest.class, com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest.Builder.class);
    }

    // Construct using com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest.newBuilder()
    private Builder() {
      maybeForceBuilderInitialization();
    }

    private Builder(
        com.google.protobuf.GeneratedMessageV3.BuilderParent parent) {
      super(parent);
      maybeForceBuilderInitialization();
    }
    private void maybeForceBuilderInitialization() {
      if (com.google.protobuf.GeneratedMessageV3
              .alwaysUseFieldBuilders) {
      }
    }
    @java.lang.Override
    public Builder clear() {
      super.clear();
      if (securityMarksBuilder_ == null) {
        securityMarks_ = null;
      } else {
        securityMarks_ = null;
        securityMarksBuilder_ = null;
      }
      if (updateMaskBuilder_ == null) {
        updateMask_ = null;
      } else {
        updateMask_ = null;
        updateMaskBuilder_ = null;
      }
      if (startTimeBuilder_ == null) {
        startTime_ = null;
      } else {
        startTime_ = null;
        startTimeBuilder_ = null;
      }
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.securitycenter.v1beta1.SecuritycenterService.internal_static_google_cloud_securitycenter_v1beta1_UpdateSecurityMarksRequest_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest getDefaultInstanceForType() {
      return com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest build() {
      com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest buildPartial() {
      com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest result = new com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest(this);
      if (securityMarksBuilder_ == null) {
        result.securityMarks_ = securityMarks_;
      } else {
        result.securityMarks_ = securityMarksBuilder_.build();
      }
      if (updateMaskBuilder_ == null) {
        result.updateMask_ = updateMask_;
      } else {
        result.updateMask_ = updateMaskBuilder_.build();
      }
      if (startTimeBuilder_ == null) {
        result.startTime_ = startTime_;
      } else {
        result.startTime_ = startTimeBuilder_.build();
      }
      onBuilt();
      return result;
    }

    @java.lang.Override
    public Builder clone() {
      return super.clone();
    }
    @java.lang.Override
    public Builder setField(
        com.google.protobuf.Descriptors.FieldDescriptor field,
        java.lang.Object value) {
      return super.setField(field, value);
    }
    @java.lang.Override
    public Builder clearField(
        com.google.protobuf.Descriptors.FieldDescriptor field) {
      return super.clearField(field);
    }
    @java.lang.Override
    public Builder clearOneof(
        com.google.protobuf.Descriptors.OneofDescriptor oneof) {
      return super.clearOneof(oneof);
    }
    @java.lang.Override
    public Builder setRepeatedField(
        com.google.protobuf.Descriptors.FieldDescriptor field,
        int index, java.lang.Object value) {
      return super.setRepeatedField(field, index, value);
    }
    @java.lang.Override
    public Builder addRepeatedField(
        com.google.protobuf.Descriptors.FieldDescriptor field,
        java.lang.Object value) {
      return super.addRepeatedField(field, value);
    }
    @java.lang.Override
    public Builder mergeFrom(com.google.protobuf.Message other) {
      if (other instanceof com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest) {
        return mergeFrom((com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest other) {
      if (other == com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest.getDefaultInstance()) return this;
      if (other.hasSecurityMarks()) {
        mergeSecurityMarks(other.getSecurityMarks());
      }
      if (other.hasUpdateMask()) {
        mergeUpdateMask(other.getUpdateMask());
      }
      if (other.hasStartTime()) {
        mergeStartTime(other.getStartTime());
      }
      this.mergeUnknownFields(other.unknownFields);
      onChanged();
      return this;
    }

    @java.lang.Override
    public final boolean isInitialized() {
      return true;
    }

    @java.lang.Override
    public Builder mergeFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private com.google.cloud.securitycenter.v1beta1.SecurityMarks securityMarks_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.securitycenter.v1beta1.SecurityMarks, com.google.cloud.securitycenter.v1beta1.SecurityMarks.Builder, com.google.cloud.securitycenter.v1beta1.SecurityMarksOrBuilder> securityMarksBuilder_;
    /**
     * <pre>
     * The security marks resource to update.
     * </pre>
     *
     * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 1;</code>
     */
    public boolean hasSecurityMarks() {
      return securityMarksBuilder_ != null || securityMarks_ != null;
    }
    /**
     * <pre>
     * The security marks resource to update.
     * </pre>
     *
     * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 1;</code>
     */
    public com.google.cloud.securitycenter.v1beta1.SecurityMarks getSecurityMarks() {
      if (securityMarksBuilder_ == null) {
        return securityMarks_ == null ? com.google.cloud.securitycenter.v1beta1.SecurityMarks.getDefaultInstance() : securityMarks_;
      } else {
        return securityMarksBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * The security marks resource to update.
     * </pre>
     *
     * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 1;</code>
     */
    public Builder setSecurityMarks(com.google.cloud.securitycenter.v1beta1.SecurityMarks value) {
      if (securityMarksBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        securityMarks_ = value;
        onChanged();
      } else {
        securityMarksBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * The security marks resource to update.
     * </pre>
     *
     * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 1;</code>
     */
    public Builder setSecurityMarks(
        com.google.cloud.securitycenter.v1beta1.SecurityMarks.Builder builderForValue) {
      if (securityMarksBuilder_ == null) {
        securityMarks_ = builderForValue.build();
        onChanged();
      } else {
        securityMarksBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * The security marks resource to update.
     * </pre>
     *
     * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 1;</code>
     */
    public Builder mergeSecurityMarks(com.google.cloud.securitycenter.v1beta1.SecurityMarks value) {
      if (securityMarksBuilder_ == null) {
        if (securityMarks_ != null) {
          securityMarks_ =
            com.google.cloud.securitycenter.v1beta1.SecurityMarks.newBuilder(securityMarks_).mergeFrom(value).buildPartial();
        } else {
          securityMarks_ = value;
        }
        onChanged();
      } else {
        securityMarksBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * The security marks resource to update.
     * </pre>
     *
     * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 1;</code>
     */
    public Builder clearSecurityMarks() {
      if (securityMarksBuilder_ == null) {
        securityMarks_ = null;
        onChanged();
      } else {
        securityMarks_ = null;
        securityMarksBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * The security marks resource to update.
     * </pre>
     *
     * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 1;</code>
     */
    public com.google.cloud.securitycenter.v1beta1.SecurityMarks.Builder getSecurityMarksBuilder() {
      
      onChanged();
      return getSecurityMarksFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * The security marks resource to update.
     * </pre>
     *
     * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 1;</code>
     */
    public com.google.cloud.securitycenter.v1beta1.SecurityMarksOrBuilder getSecurityMarksOrBuilder() {
      if (securityMarksBuilder_ != null) {
        return securityMarksBuilder_.getMessageOrBuilder();
      } else {
        return securityMarks_ == null ?
            com.google.cloud.securitycenter.v1beta1.SecurityMarks.getDefaultInstance() : securityMarks_;
      }
    }
    /**
     * <pre>
     * The security marks resource to update.
     * </pre>
     *
     * <code>.google.cloud.securitycenter.v1beta1.SecurityMarks security_marks = 1;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.cloud.securitycenter.v1beta1.SecurityMarks, com.google.cloud.securitycenter.v1beta1.SecurityMarks.Builder, com.google.cloud.securitycenter.v1beta1.SecurityMarksOrBuilder> 
        getSecurityMarksFieldBuilder() {
      if (securityMarksBuilder_ == null) {
        securityMarksBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.cloud.securitycenter.v1beta1.SecurityMarks, com.google.cloud.securitycenter.v1beta1.SecurityMarks.Builder, com.google.cloud.securitycenter.v1beta1.SecurityMarksOrBuilder>(
                getSecurityMarks(),
                getParentForChildren(),
                isClean());
        securityMarks_ = null;
      }
      return securityMarksBuilder_;
    }

    private com.google.protobuf.FieldMask updateMask_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.protobuf.FieldMask, com.google.protobuf.FieldMask.Builder, com.google.protobuf.FieldMaskOrBuilder> updateMaskBuilder_;
    /**
     * <pre>
     * The FieldMask to use when updating the security marks resource.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2;</code>
     */
    public boolean hasUpdateMask() {
      return updateMaskBuilder_ != null || updateMask_ != null;
    }
    /**
     * <pre>
     * The FieldMask to use when updating the security marks resource.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2;</code>
     */
    public com.google.protobuf.FieldMask getUpdateMask() {
      if (updateMaskBuilder_ == null) {
        return updateMask_ == null ? com.google.protobuf.FieldMask.getDefaultInstance() : updateMask_;
      } else {
        return updateMaskBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * The FieldMask to use when updating the security marks resource.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2;</code>
     */
    public Builder setUpdateMask(com.google.protobuf.FieldMask value) {
      if (updateMaskBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        updateMask_ = value;
        onChanged();
      } else {
        updateMaskBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * The FieldMask to use when updating the security marks resource.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2;</code>
     */
    public Builder setUpdateMask(
        com.google.protobuf.FieldMask.Builder builderForValue) {
      if (updateMaskBuilder_ == null) {
        updateMask_ = builderForValue.build();
        onChanged();
      } else {
        updateMaskBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * The FieldMask to use when updating the security marks resource.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2;</code>
     */
    public Builder mergeUpdateMask(com.google.protobuf.FieldMask value) {
      if (updateMaskBuilder_ == null) {
        if (updateMask_ != null) {
          updateMask_ =
            com.google.protobuf.FieldMask.newBuilder(updateMask_).mergeFrom(value).buildPartial();
        } else {
          updateMask_ = value;
        }
        onChanged();
      } else {
        updateMaskBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * The FieldMask to use when updating the security marks resource.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2;</code>
     */
    public Builder clearUpdateMask() {
      if (updateMaskBuilder_ == null) {
        updateMask_ = null;
        onChanged();
      } else {
        updateMask_ = null;
        updateMaskBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * The FieldMask to use when updating the security marks resource.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2;</code>
     */
    public com.google.protobuf.FieldMask.Builder getUpdateMaskBuilder() {
      
      onChanged();
      return getUpdateMaskFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * The FieldMask to use when updating the security marks resource.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2;</code>
     */
    public com.google.protobuf.FieldMaskOrBuilder getUpdateMaskOrBuilder() {
      if (updateMaskBuilder_ != null) {
        return updateMaskBuilder_.getMessageOrBuilder();
      } else {
        return updateMask_ == null ?
            com.google.protobuf.FieldMask.getDefaultInstance() : updateMask_;
      }
    }
    /**
     * <pre>
     * The FieldMask to use when updating the security marks resource.
     * </pre>
     *
     * <code>.google.protobuf.FieldMask update_mask = 2;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.protobuf.FieldMask, com.google.protobuf.FieldMask.Builder, com.google.protobuf.FieldMaskOrBuilder> 
        getUpdateMaskFieldBuilder() {
      if (updateMaskBuilder_ == null) {
        updateMaskBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.protobuf.FieldMask, com.google.protobuf.FieldMask.Builder, com.google.protobuf.FieldMaskOrBuilder>(
                getUpdateMask(),
                getParentForChildren(),
                isClean());
        updateMask_ = null;
      }
      return updateMaskBuilder_;
    }

    private com.google.protobuf.Timestamp startTime_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.protobuf.Timestamp, com.google.protobuf.Timestamp.Builder, com.google.protobuf.TimestampOrBuilder> startTimeBuilder_;
    /**
     * <pre>
     * The time at which the updated SecurityMarks take effect.
     * </pre>
     *
     * <code>.google.protobuf.Timestamp start_time = 3;</code>
     */
    public boolean hasStartTime() {
      return startTimeBuilder_ != null || startTime_ != null;
    }
    /**
     * <pre>
     * The time at which the updated SecurityMarks take effect.
     * </pre>
     *
     * <code>.google.protobuf.Timestamp start_time = 3;</code>
     */
    public com.google.protobuf.Timestamp getStartTime() {
      if (startTimeBuilder_ == null) {
        return startTime_ == null ? com.google.protobuf.Timestamp.getDefaultInstance() : startTime_;
      } else {
        return startTimeBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * The time at which the updated SecurityMarks take effect.
     * </pre>
     *
     * <code>.google.protobuf.Timestamp start_time = 3;</code>
     */
    public Builder setStartTime(com.google.protobuf.Timestamp value) {
      if (startTimeBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        startTime_ = value;
        onChanged();
      } else {
        startTimeBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * The time at which the updated SecurityMarks take effect.
     * </pre>
     *
     * <code>.google.protobuf.Timestamp start_time = 3;</code>
     */
    public Builder setStartTime(
        com.google.protobuf.Timestamp.Builder builderForValue) {
      if (startTimeBuilder_ == null) {
        startTime_ = builderForValue.build();
        onChanged();
      } else {
        startTimeBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * The time at which the updated SecurityMarks take effect.
     * </pre>
     *
     * <code>.google.protobuf.Timestamp start_time = 3;</code>
     */
    public Builder mergeStartTime(com.google.protobuf.Timestamp value) {
      if (startTimeBuilder_ == null) {
        if (startTime_ != null) {
          startTime_ =
            com.google.protobuf.Timestamp.newBuilder(startTime_).mergeFrom(value).buildPartial();
        } else {
          startTime_ = value;
        }
        onChanged();
      } else {
        startTimeBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * The time at which the updated SecurityMarks take effect.
     * </pre>
     *
     * <code>.google.protobuf.Timestamp start_time = 3;</code>
     */
    public Builder clearStartTime() {
      if (startTimeBuilder_ == null) {
        startTime_ = null;
        onChanged();
      } else {
        startTime_ = null;
        startTimeBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * The time at which the updated SecurityMarks take effect.
     * </pre>
     *
     * <code>.google.protobuf.Timestamp start_time = 3;</code>
     */
    public com.google.protobuf.Timestamp.Builder getStartTimeBuilder() {
      
      onChanged();
      return getStartTimeFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * The time at which the updated SecurityMarks take effect.
     * </pre>
     *
     * <code>.google.protobuf.Timestamp start_time = 3;</code>
     */
    public com.google.protobuf.TimestampOrBuilder getStartTimeOrBuilder() {
      if (startTimeBuilder_ != null) {
        return startTimeBuilder_.getMessageOrBuilder();
      } else {
        return startTime_ == null ?
            com.google.protobuf.Timestamp.getDefaultInstance() : startTime_;
      }
    }
    /**
     * <pre>
     * The time at which the updated SecurityMarks take effect.
     * </pre>
     *
     * <code>.google.protobuf.Timestamp start_time = 3;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.protobuf.Timestamp, com.google.protobuf.Timestamp.Builder, com.google.protobuf.TimestampOrBuilder> 
        getStartTimeFieldBuilder() {
      if (startTimeBuilder_ == null) {
        startTimeBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.protobuf.Timestamp, com.google.protobuf.Timestamp.Builder, com.google.protobuf.TimestampOrBuilder>(
                getStartTime(),
                getParentForChildren(),
                isClean());
        startTime_ = null;
      }
      return startTimeBuilder_;
    }
    @java.lang.Override
    public final Builder setUnknownFields(
        final com.google.protobuf.UnknownFieldSet unknownFields) {
      return super.setUnknownFields(unknownFields);
    }

    @java.lang.Override
    public final Builder mergeUnknownFields(
        final com.google.protobuf.UnknownFieldSet unknownFields) {
      return super.mergeUnknownFields(unknownFields);
    }


    // @@protoc_insertion_point(builder_scope:google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest)
  private static final com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest();
  }

  public static com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<UpdateSecurityMarksRequest>
      PARSER = new com.google.protobuf.AbstractParser<UpdateSecurityMarksRequest>() {
    @java.lang.Override
    public UpdateSecurityMarksRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new UpdateSecurityMarksRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<UpdateSecurityMarksRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<UpdateSecurityMarksRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

