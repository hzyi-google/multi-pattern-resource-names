// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/privacy/dlp/v2/dlp.proto

package com.google.privacy.dlp.v2;

/**
 * <pre>
 * Shifts dates by random number of days, with option to be consistent for the
 * same context. See https://cloud.google.com/dlp/docs/concepts-date-shifting
 * to learn more.
 * </pre>
 *
 * Protobuf type {@code google.privacy.dlp.v2.DateShiftConfig}
 */
public  final class DateShiftConfig extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.privacy.dlp.v2.DateShiftConfig)
    DateShiftConfigOrBuilder {
private static final long serialVersionUID = 0L;
  // Use DateShiftConfig.newBuilder() to construct.
  private DateShiftConfig(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private DateShiftConfig() {
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private DateShiftConfig(
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

            upperBoundDays_ = input.readInt32();
            break;
          }
          case 16: {

            lowerBoundDays_ = input.readInt32();
            break;
          }
          case 26: {
            com.google.privacy.dlp.v2.FieldId.Builder subBuilder = null;
            if (context_ != null) {
              subBuilder = context_.toBuilder();
            }
            context_ = input.readMessage(com.google.privacy.dlp.v2.FieldId.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(context_);
              context_ = subBuilder.buildPartial();
            }

            break;
          }
          case 34: {
            com.google.privacy.dlp.v2.CryptoKey.Builder subBuilder = null;
            if (methodCase_ == 4) {
              subBuilder = ((com.google.privacy.dlp.v2.CryptoKey) method_).toBuilder();
            }
            method_ =
                input.readMessage(com.google.privacy.dlp.v2.CryptoKey.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom((com.google.privacy.dlp.v2.CryptoKey) method_);
              method_ = subBuilder.buildPartial();
            }
            methodCase_ = 4;
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
    return com.google.privacy.dlp.v2.DlpProto.internal_static_google_privacy_dlp_v2_DateShiftConfig_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.privacy.dlp.v2.DlpProto.internal_static_google_privacy_dlp_v2_DateShiftConfig_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.privacy.dlp.v2.DateShiftConfig.class, com.google.privacy.dlp.v2.DateShiftConfig.Builder.class);
  }

  private int methodCase_ = 0;
  private java.lang.Object method_;
  public enum MethodCase
      implements com.google.protobuf.Internal.EnumLite {
    CRYPTO_KEY(4),
    METHOD_NOT_SET(0);
    private final int value;
    private MethodCase(int value) {
      this.value = value;
    }
    /**
     * @deprecated Use {@link #forNumber(int)} instead.
     */
    @java.lang.Deprecated
    public static MethodCase valueOf(int value) {
      return forNumber(value);
    }

    public static MethodCase forNumber(int value) {
      switch (value) {
        case 4: return CRYPTO_KEY;
        case 0: return METHOD_NOT_SET;
        default: return null;
      }
    }
    public int getNumber() {
      return this.value;
    }
  };

  public MethodCase
  getMethodCase() {
    return MethodCase.forNumber(
        methodCase_);
  }

  public static final int UPPER_BOUND_DAYS_FIELD_NUMBER = 1;
  private int upperBoundDays_;
  /**
   * <pre>
   * Range of shift in days. Actual shift will be selected at random within this
   * range (inclusive ends). Negative means shift to earlier in time. Must not
   * be more than 365250 days (1000 years) each direction.
   * For example, 3 means shift date to at most 3 days into the future.
   * [Required]
   * </pre>
   *
   * <code>int32 upper_bound_days = 1;</code>
   */
  public int getUpperBoundDays() {
    return upperBoundDays_;
  }

  public static final int LOWER_BOUND_DAYS_FIELD_NUMBER = 2;
  private int lowerBoundDays_;
  /**
   * <pre>
   * For example, -5 means shift date to at most 5 days back in the past.
   * [Required]
   * </pre>
   *
   * <code>int32 lower_bound_days = 2;</code>
   */
  public int getLowerBoundDays() {
    return lowerBoundDays_;
  }

  public static final int CONTEXT_FIELD_NUMBER = 3;
  private com.google.privacy.dlp.v2.FieldId context_;
  /**
   * <pre>
   * Points to the field that contains the context, for example, an entity id.
   * If set, must also set method. If set, shift will be consistent for the
   * given context.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.FieldId context = 3;</code>
   */
  public boolean hasContext() {
    return context_ != null;
  }
  /**
   * <pre>
   * Points to the field that contains the context, for example, an entity id.
   * If set, must also set method. If set, shift will be consistent for the
   * given context.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.FieldId context = 3;</code>
   */
  public com.google.privacy.dlp.v2.FieldId getContext() {
    return context_ == null ? com.google.privacy.dlp.v2.FieldId.getDefaultInstance() : context_;
  }
  /**
   * <pre>
   * Points to the field that contains the context, for example, an entity id.
   * If set, must also set method. If set, shift will be consistent for the
   * given context.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.FieldId context = 3;</code>
   */
  public com.google.privacy.dlp.v2.FieldIdOrBuilder getContextOrBuilder() {
    return getContext();
  }

  public static final int CRYPTO_KEY_FIELD_NUMBER = 4;
  /**
   * <pre>
   * Causes the shift to be computed based on this key and the context. This
   * results in the same shift for the same context and crypto_key.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.CryptoKey crypto_key = 4;</code>
   */
  public boolean hasCryptoKey() {
    return methodCase_ == 4;
  }
  /**
   * <pre>
   * Causes the shift to be computed based on this key and the context. This
   * results in the same shift for the same context and crypto_key.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.CryptoKey crypto_key = 4;</code>
   */
  public com.google.privacy.dlp.v2.CryptoKey getCryptoKey() {
    if (methodCase_ == 4) {
       return (com.google.privacy.dlp.v2.CryptoKey) method_;
    }
    return com.google.privacy.dlp.v2.CryptoKey.getDefaultInstance();
  }
  /**
   * <pre>
   * Causes the shift to be computed based on this key and the context. This
   * results in the same shift for the same context and crypto_key.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.CryptoKey crypto_key = 4;</code>
   */
  public com.google.privacy.dlp.v2.CryptoKeyOrBuilder getCryptoKeyOrBuilder() {
    if (methodCase_ == 4) {
       return (com.google.privacy.dlp.v2.CryptoKey) method_;
    }
    return com.google.privacy.dlp.v2.CryptoKey.getDefaultInstance();
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
    if (upperBoundDays_ != 0) {
      output.writeInt32(1, upperBoundDays_);
    }
    if (lowerBoundDays_ != 0) {
      output.writeInt32(2, lowerBoundDays_);
    }
    if (context_ != null) {
      output.writeMessage(3, getContext());
    }
    if (methodCase_ == 4) {
      output.writeMessage(4, (com.google.privacy.dlp.v2.CryptoKey) method_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (upperBoundDays_ != 0) {
      size += com.google.protobuf.CodedOutputStream
        .computeInt32Size(1, upperBoundDays_);
    }
    if (lowerBoundDays_ != 0) {
      size += com.google.protobuf.CodedOutputStream
        .computeInt32Size(2, lowerBoundDays_);
    }
    if (context_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(3, getContext());
    }
    if (methodCase_ == 4) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(4, (com.google.privacy.dlp.v2.CryptoKey) method_);
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
    if (!(obj instanceof com.google.privacy.dlp.v2.DateShiftConfig)) {
      return super.equals(obj);
    }
    com.google.privacy.dlp.v2.DateShiftConfig other = (com.google.privacy.dlp.v2.DateShiftConfig) obj;

    if (getUpperBoundDays()
        != other.getUpperBoundDays()) return false;
    if (getLowerBoundDays()
        != other.getLowerBoundDays()) return false;
    if (hasContext() != other.hasContext()) return false;
    if (hasContext()) {
      if (!getContext()
          .equals(other.getContext())) return false;
    }
    if (!getMethodCase().equals(other.getMethodCase())) return false;
    switch (methodCase_) {
      case 4:
        if (!getCryptoKey()
            .equals(other.getCryptoKey())) return false;
        break;
      case 0:
      default:
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
    hash = (37 * hash) + UPPER_BOUND_DAYS_FIELD_NUMBER;
    hash = (53 * hash) + getUpperBoundDays();
    hash = (37 * hash) + LOWER_BOUND_DAYS_FIELD_NUMBER;
    hash = (53 * hash) + getLowerBoundDays();
    if (hasContext()) {
      hash = (37 * hash) + CONTEXT_FIELD_NUMBER;
      hash = (53 * hash) + getContext().hashCode();
    }
    switch (methodCase_) {
      case 4:
        hash = (37 * hash) + CRYPTO_KEY_FIELD_NUMBER;
        hash = (53 * hash) + getCryptoKey().hashCode();
        break;
      case 0:
      default:
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.privacy.dlp.v2.DateShiftConfig parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.privacy.dlp.v2.DateShiftConfig parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.privacy.dlp.v2.DateShiftConfig parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.privacy.dlp.v2.DateShiftConfig parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.privacy.dlp.v2.DateShiftConfig parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.privacy.dlp.v2.DateShiftConfig parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.privacy.dlp.v2.DateShiftConfig parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.privacy.dlp.v2.DateShiftConfig parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.privacy.dlp.v2.DateShiftConfig parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.privacy.dlp.v2.DateShiftConfig parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.privacy.dlp.v2.DateShiftConfig parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.privacy.dlp.v2.DateShiftConfig parseFrom(
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
  public static Builder newBuilder(com.google.privacy.dlp.v2.DateShiftConfig prototype) {
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
   * Shifts dates by random number of days, with option to be consistent for the
   * same context. See https://cloud.google.com/dlp/docs/concepts-date-shifting
   * to learn more.
   * </pre>
   *
   * Protobuf type {@code google.privacy.dlp.v2.DateShiftConfig}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.privacy.dlp.v2.DateShiftConfig)
      com.google.privacy.dlp.v2.DateShiftConfigOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.privacy.dlp.v2.DlpProto.internal_static_google_privacy_dlp_v2_DateShiftConfig_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.privacy.dlp.v2.DlpProto.internal_static_google_privacy_dlp_v2_DateShiftConfig_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.privacy.dlp.v2.DateShiftConfig.class, com.google.privacy.dlp.v2.DateShiftConfig.Builder.class);
    }

    // Construct using com.google.privacy.dlp.v2.DateShiftConfig.newBuilder()
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
      upperBoundDays_ = 0;

      lowerBoundDays_ = 0;

      if (contextBuilder_ == null) {
        context_ = null;
      } else {
        context_ = null;
        contextBuilder_ = null;
      }
      methodCase_ = 0;
      method_ = null;
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.privacy.dlp.v2.DlpProto.internal_static_google_privacy_dlp_v2_DateShiftConfig_descriptor;
    }

    @java.lang.Override
    public com.google.privacy.dlp.v2.DateShiftConfig getDefaultInstanceForType() {
      return com.google.privacy.dlp.v2.DateShiftConfig.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.privacy.dlp.v2.DateShiftConfig build() {
      com.google.privacy.dlp.v2.DateShiftConfig result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.privacy.dlp.v2.DateShiftConfig buildPartial() {
      com.google.privacy.dlp.v2.DateShiftConfig result = new com.google.privacy.dlp.v2.DateShiftConfig(this);
      result.upperBoundDays_ = upperBoundDays_;
      result.lowerBoundDays_ = lowerBoundDays_;
      if (contextBuilder_ == null) {
        result.context_ = context_;
      } else {
        result.context_ = contextBuilder_.build();
      }
      if (methodCase_ == 4) {
        if (cryptoKeyBuilder_ == null) {
          result.method_ = method_;
        } else {
          result.method_ = cryptoKeyBuilder_.build();
        }
      }
      result.methodCase_ = methodCase_;
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
      if (other instanceof com.google.privacy.dlp.v2.DateShiftConfig) {
        return mergeFrom((com.google.privacy.dlp.v2.DateShiftConfig)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.privacy.dlp.v2.DateShiftConfig other) {
      if (other == com.google.privacy.dlp.v2.DateShiftConfig.getDefaultInstance()) return this;
      if (other.getUpperBoundDays() != 0) {
        setUpperBoundDays(other.getUpperBoundDays());
      }
      if (other.getLowerBoundDays() != 0) {
        setLowerBoundDays(other.getLowerBoundDays());
      }
      if (other.hasContext()) {
        mergeContext(other.getContext());
      }
      switch (other.getMethodCase()) {
        case CRYPTO_KEY: {
          mergeCryptoKey(other.getCryptoKey());
          break;
        }
        case METHOD_NOT_SET: {
          break;
        }
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
      com.google.privacy.dlp.v2.DateShiftConfig parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.privacy.dlp.v2.DateShiftConfig) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int methodCase_ = 0;
    private java.lang.Object method_;
    public MethodCase
        getMethodCase() {
      return MethodCase.forNumber(
          methodCase_);
    }

    public Builder clearMethod() {
      methodCase_ = 0;
      method_ = null;
      onChanged();
      return this;
    }


    private int upperBoundDays_ ;
    /**
     * <pre>
     * Range of shift in days. Actual shift will be selected at random within this
     * range (inclusive ends). Negative means shift to earlier in time. Must not
     * be more than 365250 days (1000 years) each direction.
     * For example, 3 means shift date to at most 3 days into the future.
     * [Required]
     * </pre>
     *
     * <code>int32 upper_bound_days = 1;</code>
     */
    public int getUpperBoundDays() {
      return upperBoundDays_;
    }
    /**
     * <pre>
     * Range of shift in days. Actual shift will be selected at random within this
     * range (inclusive ends). Negative means shift to earlier in time. Must not
     * be more than 365250 days (1000 years) each direction.
     * For example, 3 means shift date to at most 3 days into the future.
     * [Required]
     * </pre>
     *
     * <code>int32 upper_bound_days = 1;</code>
     */
    public Builder setUpperBoundDays(int value) {
      
      upperBoundDays_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Range of shift in days. Actual shift will be selected at random within this
     * range (inclusive ends). Negative means shift to earlier in time. Must not
     * be more than 365250 days (1000 years) each direction.
     * For example, 3 means shift date to at most 3 days into the future.
     * [Required]
     * </pre>
     *
     * <code>int32 upper_bound_days = 1;</code>
     */
    public Builder clearUpperBoundDays() {
      
      upperBoundDays_ = 0;
      onChanged();
      return this;
    }

    private int lowerBoundDays_ ;
    /**
     * <pre>
     * For example, -5 means shift date to at most 5 days back in the past.
     * [Required]
     * </pre>
     *
     * <code>int32 lower_bound_days = 2;</code>
     */
    public int getLowerBoundDays() {
      return lowerBoundDays_;
    }
    /**
     * <pre>
     * For example, -5 means shift date to at most 5 days back in the past.
     * [Required]
     * </pre>
     *
     * <code>int32 lower_bound_days = 2;</code>
     */
    public Builder setLowerBoundDays(int value) {
      
      lowerBoundDays_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * For example, -5 means shift date to at most 5 days back in the past.
     * [Required]
     * </pre>
     *
     * <code>int32 lower_bound_days = 2;</code>
     */
    public Builder clearLowerBoundDays() {
      
      lowerBoundDays_ = 0;
      onChanged();
      return this;
    }

    private com.google.privacy.dlp.v2.FieldId context_;
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.privacy.dlp.v2.FieldId, com.google.privacy.dlp.v2.FieldId.Builder, com.google.privacy.dlp.v2.FieldIdOrBuilder> contextBuilder_;
    /**
     * <pre>
     * Points to the field that contains the context, for example, an entity id.
     * If set, must also set method. If set, shift will be consistent for the
     * given context.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.FieldId context = 3;</code>
     */
    public boolean hasContext() {
      return contextBuilder_ != null || context_ != null;
    }
    /**
     * <pre>
     * Points to the field that contains the context, for example, an entity id.
     * If set, must also set method. If set, shift will be consistent for the
     * given context.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.FieldId context = 3;</code>
     */
    public com.google.privacy.dlp.v2.FieldId getContext() {
      if (contextBuilder_ == null) {
        return context_ == null ? com.google.privacy.dlp.v2.FieldId.getDefaultInstance() : context_;
      } else {
        return contextBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     * Points to the field that contains the context, for example, an entity id.
     * If set, must also set method. If set, shift will be consistent for the
     * given context.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.FieldId context = 3;</code>
     */
    public Builder setContext(com.google.privacy.dlp.v2.FieldId value) {
      if (contextBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        context_ = value;
        onChanged();
      } else {
        contextBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     * Points to the field that contains the context, for example, an entity id.
     * If set, must also set method. If set, shift will be consistent for the
     * given context.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.FieldId context = 3;</code>
     */
    public Builder setContext(
        com.google.privacy.dlp.v2.FieldId.Builder builderForValue) {
      if (contextBuilder_ == null) {
        context_ = builderForValue.build();
        onChanged();
      } else {
        contextBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     * Points to the field that contains the context, for example, an entity id.
     * If set, must also set method. If set, shift will be consistent for the
     * given context.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.FieldId context = 3;</code>
     */
    public Builder mergeContext(com.google.privacy.dlp.v2.FieldId value) {
      if (contextBuilder_ == null) {
        if (context_ != null) {
          context_ =
            com.google.privacy.dlp.v2.FieldId.newBuilder(context_).mergeFrom(value).buildPartial();
        } else {
          context_ = value;
        }
        onChanged();
      } else {
        contextBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     * Points to the field that contains the context, for example, an entity id.
     * If set, must also set method. If set, shift will be consistent for the
     * given context.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.FieldId context = 3;</code>
     */
    public Builder clearContext() {
      if (contextBuilder_ == null) {
        context_ = null;
        onChanged();
      } else {
        context_ = null;
        contextBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     * Points to the field that contains the context, for example, an entity id.
     * If set, must also set method. If set, shift will be consistent for the
     * given context.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.FieldId context = 3;</code>
     */
    public com.google.privacy.dlp.v2.FieldId.Builder getContextBuilder() {
      
      onChanged();
      return getContextFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Points to the field that contains the context, for example, an entity id.
     * If set, must also set method. If set, shift will be consistent for the
     * given context.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.FieldId context = 3;</code>
     */
    public com.google.privacy.dlp.v2.FieldIdOrBuilder getContextOrBuilder() {
      if (contextBuilder_ != null) {
        return contextBuilder_.getMessageOrBuilder();
      } else {
        return context_ == null ?
            com.google.privacy.dlp.v2.FieldId.getDefaultInstance() : context_;
      }
    }
    /**
     * <pre>
     * Points to the field that contains the context, for example, an entity id.
     * If set, must also set method. If set, shift will be consistent for the
     * given context.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.FieldId context = 3;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.privacy.dlp.v2.FieldId, com.google.privacy.dlp.v2.FieldId.Builder, com.google.privacy.dlp.v2.FieldIdOrBuilder> 
        getContextFieldBuilder() {
      if (contextBuilder_ == null) {
        contextBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.privacy.dlp.v2.FieldId, com.google.privacy.dlp.v2.FieldId.Builder, com.google.privacy.dlp.v2.FieldIdOrBuilder>(
                getContext(),
                getParentForChildren(),
                isClean());
        context_ = null;
      }
      return contextBuilder_;
    }

    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.privacy.dlp.v2.CryptoKey, com.google.privacy.dlp.v2.CryptoKey.Builder, com.google.privacy.dlp.v2.CryptoKeyOrBuilder> cryptoKeyBuilder_;
    /**
     * <pre>
     * Causes the shift to be computed based on this key and the context. This
     * results in the same shift for the same context and crypto_key.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.CryptoKey crypto_key = 4;</code>
     */
    public boolean hasCryptoKey() {
      return methodCase_ == 4;
    }
    /**
     * <pre>
     * Causes the shift to be computed based on this key and the context. This
     * results in the same shift for the same context and crypto_key.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.CryptoKey crypto_key = 4;</code>
     */
    public com.google.privacy.dlp.v2.CryptoKey getCryptoKey() {
      if (cryptoKeyBuilder_ == null) {
        if (methodCase_ == 4) {
          return (com.google.privacy.dlp.v2.CryptoKey) method_;
        }
        return com.google.privacy.dlp.v2.CryptoKey.getDefaultInstance();
      } else {
        if (methodCase_ == 4) {
          return cryptoKeyBuilder_.getMessage();
        }
        return com.google.privacy.dlp.v2.CryptoKey.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Causes the shift to be computed based on this key and the context. This
     * results in the same shift for the same context and crypto_key.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.CryptoKey crypto_key = 4;</code>
     */
    public Builder setCryptoKey(com.google.privacy.dlp.v2.CryptoKey value) {
      if (cryptoKeyBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        method_ = value;
        onChanged();
      } else {
        cryptoKeyBuilder_.setMessage(value);
      }
      methodCase_ = 4;
      return this;
    }
    /**
     * <pre>
     * Causes the shift to be computed based on this key and the context. This
     * results in the same shift for the same context and crypto_key.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.CryptoKey crypto_key = 4;</code>
     */
    public Builder setCryptoKey(
        com.google.privacy.dlp.v2.CryptoKey.Builder builderForValue) {
      if (cryptoKeyBuilder_ == null) {
        method_ = builderForValue.build();
        onChanged();
      } else {
        cryptoKeyBuilder_.setMessage(builderForValue.build());
      }
      methodCase_ = 4;
      return this;
    }
    /**
     * <pre>
     * Causes the shift to be computed based on this key and the context. This
     * results in the same shift for the same context and crypto_key.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.CryptoKey crypto_key = 4;</code>
     */
    public Builder mergeCryptoKey(com.google.privacy.dlp.v2.CryptoKey value) {
      if (cryptoKeyBuilder_ == null) {
        if (methodCase_ == 4 &&
            method_ != com.google.privacy.dlp.v2.CryptoKey.getDefaultInstance()) {
          method_ = com.google.privacy.dlp.v2.CryptoKey.newBuilder((com.google.privacy.dlp.v2.CryptoKey) method_)
              .mergeFrom(value).buildPartial();
        } else {
          method_ = value;
        }
        onChanged();
      } else {
        if (methodCase_ == 4) {
          cryptoKeyBuilder_.mergeFrom(value);
        }
        cryptoKeyBuilder_.setMessage(value);
      }
      methodCase_ = 4;
      return this;
    }
    /**
     * <pre>
     * Causes the shift to be computed based on this key and the context. This
     * results in the same shift for the same context and crypto_key.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.CryptoKey crypto_key = 4;</code>
     */
    public Builder clearCryptoKey() {
      if (cryptoKeyBuilder_ == null) {
        if (methodCase_ == 4) {
          methodCase_ = 0;
          method_ = null;
          onChanged();
        }
      } else {
        if (methodCase_ == 4) {
          methodCase_ = 0;
          method_ = null;
        }
        cryptoKeyBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * Causes the shift to be computed based on this key and the context. This
     * results in the same shift for the same context and crypto_key.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.CryptoKey crypto_key = 4;</code>
     */
    public com.google.privacy.dlp.v2.CryptoKey.Builder getCryptoKeyBuilder() {
      return getCryptoKeyFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Causes the shift to be computed based on this key and the context. This
     * results in the same shift for the same context and crypto_key.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.CryptoKey crypto_key = 4;</code>
     */
    public com.google.privacy.dlp.v2.CryptoKeyOrBuilder getCryptoKeyOrBuilder() {
      if ((methodCase_ == 4) && (cryptoKeyBuilder_ != null)) {
        return cryptoKeyBuilder_.getMessageOrBuilder();
      } else {
        if (methodCase_ == 4) {
          return (com.google.privacy.dlp.v2.CryptoKey) method_;
        }
        return com.google.privacy.dlp.v2.CryptoKey.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Causes the shift to be computed based on this key and the context. This
     * results in the same shift for the same context and crypto_key.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.CryptoKey crypto_key = 4;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.privacy.dlp.v2.CryptoKey, com.google.privacy.dlp.v2.CryptoKey.Builder, com.google.privacy.dlp.v2.CryptoKeyOrBuilder> 
        getCryptoKeyFieldBuilder() {
      if (cryptoKeyBuilder_ == null) {
        if (!(methodCase_ == 4)) {
          method_ = com.google.privacy.dlp.v2.CryptoKey.getDefaultInstance();
        }
        cryptoKeyBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.privacy.dlp.v2.CryptoKey, com.google.privacy.dlp.v2.CryptoKey.Builder, com.google.privacy.dlp.v2.CryptoKeyOrBuilder>(
                (com.google.privacy.dlp.v2.CryptoKey) method_,
                getParentForChildren(),
                isClean());
        method_ = null;
      }
      methodCase_ = 4;
      onChanged();;
      return cryptoKeyBuilder_;
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


    // @@protoc_insertion_point(builder_scope:google.privacy.dlp.v2.DateShiftConfig)
  }

  // @@protoc_insertion_point(class_scope:google.privacy.dlp.v2.DateShiftConfig)
  private static final com.google.privacy.dlp.v2.DateShiftConfig DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.privacy.dlp.v2.DateShiftConfig();
  }

  public static com.google.privacy.dlp.v2.DateShiftConfig getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<DateShiftConfig>
      PARSER = new com.google.protobuf.AbstractParser<DateShiftConfig>() {
    @java.lang.Override
    public DateShiftConfig parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new DateShiftConfig(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<DateShiftConfig> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<DateShiftConfig> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.privacy.dlp.v2.DateShiftConfig getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

