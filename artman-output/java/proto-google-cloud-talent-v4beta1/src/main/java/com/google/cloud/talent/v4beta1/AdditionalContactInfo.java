// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4beta1/profile.proto

package com.google.cloud.talent.v4beta1;

/**
 * <pre>
 * Resource that represents contact information other than phone, email,
 * URI and addresses.
 * </pre>
 *
 * Protobuf type {@code google.cloud.talent.v4beta1.AdditionalContactInfo}
 */
public  final class AdditionalContactInfo extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.talent.v4beta1.AdditionalContactInfo)
    AdditionalContactInfoOrBuilder {
private static final long serialVersionUID = 0L;
  // Use AdditionalContactInfo.newBuilder() to construct.
  private AdditionalContactInfo(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private AdditionalContactInfo() {
    usage_ = 0;
    name_ = "";
    contactId_ = "";
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private AdditionalContactInfo(
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
          case 8: {
            int rawValue = input.readEnum();

            usage_ = rawValue;
            break;
          }
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();

            name_ = s;
            break;
          }
          case 26: {
            java.lang.String s = input.readStringRequireUtf8();

            contactId_ = s;
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
    return com.google.cloud.talent.v4beta1.ProfileResourceProto.internal_static_google_cloud_talent_v4beta1_AdditionalContactInfo_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.talent.v4beta1.ProfileResourceProto.internal_static_google_cloud_talent_v4beta1_AdditionalContactInfo_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.talent.v4beta1.AdditionalContactInfo.class, com.google.cloud.talent.v4beta1.AdditionalContactInfo.Builder.class);
  }

  public static final int USAGE_FIELD_NUMBER = 1;
  private int usage_;
  /**
   * <pre>
   * The usage of this contact method. For example, SCHOOL, WORK, PERSONAL.
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.ContactInfoUsage usage = 1;</code>
   */
  public int getUsageValue() {
    return usage_;
  }
  /**
   * <pre>
   * The usage of this contact method. For example, SCHOOL, WORK, PERSONAL.
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.ContactInfoUsage usage = 1;</code>
   */
  public com.google.cloud.talent.v4beta1.ContactInfoUsage getUsage() {
    @SuppressWarnings("deprecation")
    com.google.cloud.talent.v4beta1.ContactInfoUsage result = com.google.cloud.talent.v4beta1.ContactInfoUsage.valueOf(usage_);
    return result == null ? com.google.cloud.talent.v4beta1.ContactInfoUsage.UNRECOGNIZED : result;
  }

  public static final int NAME_FIELD_NUMBER = 2;
  private volatile java.lang.Object name_;
  /**
   * <pre>
   * The name of the contact method.
   * For example, "hangout", "skype".
   * Number of characters allowed is 100.
   * </pre>
   *
   * <code>string name = 2;</code>
   */
  public java.lang.String getName() {
    java.lang.Object ref = name_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      name_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * The name of the contact method.
   * For example, "hangout", "skype".
   * Number of characters allowed is 100.
   * </pre>
   *
   * <code>string name = 2;</code>
   */
  public com.google.protobuf.ByteString
      getNameBytes() {
    java.lang.Object ref = name_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      name_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int CONTACT_ID_FIELD_NUMBER = 3;
  private volatile java.lang.Object contactId_;
  /**
   * <pre>
   * The contact id.
   * Number of characters allowed is 100.
   * </pre>
   *
   * <code>string contact_id = 3;</code>
   */
  public java.lang.String getContactId() {
    java.lang.Object ref = contactId_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      contactId_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * The contact id.
   * Number of characters allowed is 100.
   * </pre>
   *
   * <code>string contact_id = 3;</code>
   */
  public com.google.protobuf.ByteString
      getContactIdBytes() {
    java.lang.Object ref = contactId_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      contactId_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
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
    if (usage_ != com.google.cloud.talent.v4beta1.ContactInfoUsage.CONTACT_INFO_USAGE_UNSPECIFIED.getNumber()) {
      output.writeEnum(1, usage_);
    }
    if (!getNameBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, name_);
    }
    if (!getContactIdBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 3, contactId_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (usage_ != com.google.cloud.talent.v4beta1.ContactInfoUsage.CONTACT_INFO_USAGE_UNSPECIFIED.getNumber()) {
      size += com.google.protobuf.CodedOutputStream
        .computeEnumSize(1, usage_);
    }
    if (!getNameBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, name_);
    }
    if (!getContactIdBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(3, contactId_);
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
    if (!(obj instanceof com.google.cloud.talent.v4beta1.AdditionalContactInfo)) {
      return super.equals(obj);
    }
    com.google.cloud.talent.v4beta1.AdditionalContactInfo other = (com.google.cloud.talent.v4beta1.AdditionalContactInfo) obj;

    if (usage_ != other.usage_) return false;
    if (!getName()
        .equals(other.getName())) return false;
    if (!getContactId()
        .equals(other.getContactId())) return false;
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
    hash = (37 * hash) + USAGE_FIELD_NUMBER;
    hash = (53 * hash) + usage_;
    hash = (37 * hash) + NAME_FIELD_NUMBER;
    hash = (53 * hash) + getName().hashCode();
    hash = (37 * hash) + CONTACT_ID_FIELD_NUMBER;
    hash = (53 * hash) + getContactId().hashCode();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.talent.v4beta1.AdditionalContactInfo parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.talent.v4beta1.AdditionalContactInfo parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.talent.v4beta1.AdditionalContactInfo parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.talent.v4beta1.AdditionalContactInfo parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.talent.v4beta1.AdditionalContactInfo parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.talent.v4beta1.AdditionalContactInfo parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.talent.v4beta1.AdditionalContactInfo parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.talent.v4beta1.AdditionalContactInfo parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.talent.v4beta1.AdditionalContactInfo parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.talent.v4beta1.AdditionalContactInfo parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.talent.v4beta1.AdditionalContactInfo parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.talent.v4beta1.AdditionalContactInfo parseFrom(
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
  public static Builder newBuilder(com.google.cloud.talent.v4beta1.AdditionalContactInfo prototype) {
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
   * Resource that represents contact information other than phone, email,
   * URI and addresses.
   * </pre>
   *
   * Protobuf type {@code google.cloud.talent.v4beta1.AdditionalContactInfo}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.talent.v4beta1.AdditionalContactInfo)
      com.google.cloud.talent.v4beta1.AdditionalContactInfoOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.talent.v4beta1.ProfileResourceProto.internal_static_google_cloud_talent_v4beta1_AdditionalContactInfo_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.talent.v4beta1.ProfileResourceProto.internal_static_google_cloud_talent_v4beta1_AdditionalContactInfo_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.talent.v4beta1.AdditionalContactInfo.class, com.google.cloud.talent.v4beta1.AdditionalContactInfo.Builder.class);
    }

    // Construct using com.google.cloud.talent.v4beta1.AdditionalContactInfo.newBuilder()
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
      usage_ = 0;

      name_ = "";

      contactId_ = "";

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.talent.v4beta1.ProfileResourceProto.internal_static_google_cloud_talent_v4beta1_AdditionalContactInfo_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.talent.v4beta1.AdditionalContactInfo getDefaultInstanceForType() {
      return com.google.cloud.talent.v4beta1.AdditionalContactInfo.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.talent.v4beta1.AdditionalContactInfo build() {
      com.google.cloud.talent.v4beta1.AdditionalContactInfo result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.talent.v4beta1.AdditionalContactInfo buildPartial() {
      com.google.cloud.talent.v4beta1.AdditionalContactInfo result = new com.google.cloud.talent.v4beta1.AdditionalContactInfo(this);
      result.usage_ = usage_;
      result.name_ = name_;
      result.contactId_ = contactId_;
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
      if (other instanceof com.google.cloud.talent.v4beta1.AdditionalContactInfo) {
        return mergeFrom((com.google.cloud.talent.v4beta1.AdditionalContactInfo)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.talent.v4beta1.AdditionalContactInfo other) {
      if (other == com.google.cloud.talent.v4beta1.AdditionalContactInfo.getDefaultInstance()) return this;
      if (other.usage_ != 0) {
        setUsageValue(other.getUsageValue());
      }
      if (!other.getName().isEmpty()) {
        name_ = other.name_;
        onChanged();
      }
      if (!other.getContactId().isEmpty()) {
        contactId_ = other.contactId_;
        onChanged();
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
      com.google.cloud.talent.v4beta1.AdditionalContactInfo parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.talent.v4beta1.AdditionalContactInfo) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private int usage_ = 0;
    /**
     * <pre>
     * The usage of this contact method. For example, SCHOOL, WORK, PERSONAL.
     * </pre>
     *
     * <code>.google.cloud.talent.v4beta1.ContactInfoUsage usage = 1;</code>
     */
    public int getUsageValue() {
      return usage_;
    }
    /**
     * <pre>
     * The usage of this contact method. For example, SCHOOL, WORK, PERSONAL.
     * </pre>
     *
     * <code>.google.cloud.talent.v4beta1.ContactInfoUsage usage = 1;</code>
     */
    public Builder setUsageValue(int value) {
      usage_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The usage of this contact method. For example, SCHOOL, WORK, PERSONAL.
     * </pre>
     *
     * <code>.google.cloud.talent.v4beta1.ContactInfoUsage usage = 1;</code>
     */
    public com.google.cloud.talent.v4beta1.ContactInfoUsage getUsage() {
      @SuppressWarnings("deprecation")
      com.google.cloud.talent.v4beta1.ContactInfoUsage result = com.google.cloud.talent.v4beta1.ContactInfoUsage.valueOf(usage_);
      return result == null ? com.google.cloud.talent.v4beta1.ContactInfoUsage.UNRECOGNIZED : result;
    }
    /**
     * <pre>
     * The usage of this contact method. For example, SCHOOL, WORK, PERSONAL.
     * </pre>
     *
     * <code>.google.cloud.talent.v4beta1.ContactInfoUsage usage = 1;</code>
     */
    public Builder setUsage(com.google.cloud.talent.v4beta1.ContactInfoUsage value) {
      if (value == null) {
        throw new NullPointerException();
      }
      
      usage_ = value.getNumber();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The usage of this contact method. For example, SCHOOL, WORK, PERSONAL.
     * </pre>
     *
     * <code>.google.cloud.talent.v4beta1.ContactInfoUsage usage = 1;</code>
     */
    public Builder clearUsage() {
      
      usage_ = 0;
      onChanged();
      return this;
    }

    private java.lang.Object name_ = "";
    /**
     * <pre>
     * The name of the contact method.
     * For example, "hangout", "skype".
     * Number of characters allowed is 100.
     * </pre>
     *
     * <code>string name = 2;</code>
     */
    public java.lang.String getName() {
      java.lang.Object ref = name_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        name_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The name of the contact method.
     * For example, "hangout", "skype".
     * Number of characters allowed is 100.
     * </pre>
     *
     * <code>string name = 2;</code>
     */
    public com.google.protobuf.ByteString
        getNameBytes() {
      java.lang.Object ref = name_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        name_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The name of the contact method.
     * For example, "hangout", "skype".
     * Number of characters allowed is 100.
     * </pre>
     *
     * <code>string name = 2;</code>
     */
    public Builder setName(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      name_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The name of the contact method.
     * For example, "hangout", "skype".
     * Number of characters allowed is 100.
     * </pre>
     *
     * <code>string name = 2;</code>
     */
    public Builder clearName() {
      
      name_ = getDefaultInstance().getName();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The name of the contact method.
     * For example, "hangout", "skype".
     * Number of characters allowed is 100.
     * </pre>
     *
     * <code>string name = 2;</code>
     */
    public Builder setNameBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      name_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object contactId_ = "";
    /**
     * <pre>
     * The contact id.
     * Number of characters allowed is 100.
     * </pre>
     *
     * <code>string contact_id = 3;</code>
     */
    public java.lang.String getContactId() {
      java.lang.Object ref = contactId_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        contactId_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * The contact id.
     * Number of characters allowed is 100.
     * </pre>
     *
     * <code>string contact_id = 3;</code>
     */
    public com.google.protobuf.ByteString
        getContactIdBytes() {
      java.lang.Object ref = contactId_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        contactId_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * The contact id.
     * Number of characters allowed is 100.
     * </pre>
     *
     * <code>string contact_id = 3;</code>
     */
    public Builder setContactId(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      contactId_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The contact id.
     * Number of characters allowed is 100.
     * </pre>
     *
     * <code>string contact_id = 3;</code>
     */
    public Builder clearContactId() {
      
      contactId_ = getDefaultInstance().getContactId();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The contact id.
     * Number of characters allowed is 100.
     * </pre>
     *
     * <code>string contact_id = 3;</code>
     */
    public Builder setContactIdBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      contactId_ = value;
      onChanged();
      return this;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.talent.v4beta1.AdditionalContactInfo)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.talent.v4beta1.AdditionalContactInfo)
  private static final com.google.cloud.talent.v4beta1.AdditionalContactInfo DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.talent.v4beta1.AdditionalContactInfo();
  }

  public static com.google.cloud.talent.v4beta1.AdditionalContactInfo getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<AdditionalContactInfo>
      PARSER = new com.google.protobuf.AbstractParser<AdditionalContactInfo>() {
    @java.lang.Override
    public AdditionalContactInfo parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new AdditionalContactInfo(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<AdditionalContactInfo> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<AdditionalContactInfo> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.talent.v4beta1.AdditionalContactInfo getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

