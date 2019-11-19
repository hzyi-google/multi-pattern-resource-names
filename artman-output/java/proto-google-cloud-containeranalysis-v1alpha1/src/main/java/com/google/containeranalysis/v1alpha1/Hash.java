// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/containeranalysis/v1alpha1/provenance.proto

package com.google.containeranalysis.v1alpha1;

/**
 * <pre>
 * Container message for hash values.
 * </pre>
 *
 * Protobuf type {@code google.devtools.containeranalysis.v1alpha1.Hash}
 */
public  final class Hash extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.devtools.containeranalysis.v1alpha1.Hash)
    HashOrBuilder {
private static final long serialVersionUID = 0L;
  // Use Hash.newBuilder() to construct.
  private Hash(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private Hash() {
    type_ = 0;
    value_ = com.google.protobuf.ByteString.EMPTY;
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private Hash(
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

            type_ = rawValue;
            break;
          }
          case 18: {

            value_ = input.readBytes();
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
    return com.google.containeranalysis.v1alpha1.Provenance.internal_static_google_devtools_containeranalysis_v1alpha1_Hash_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.containeranalysis.v1alpha1.Provenance.internal_static_google_devtools_containeranalysis_v1alpha1_Hash_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.containeranalysis.v1alpha1.Hash.class, com.google.containeranalysis.v1alpha1.Hash.Builder.class);
  }

  /**
   * <pre>
   * Specifies the hash algorithm, if any.
   * </pre>
   *
   * Protobuf enum {@code google.devtools.containeranalysis.v1alpha1.Hash.HashType}
   */
  public enum HashType
      implements com.google.protobuf.ProtocolMessageEnum {
    /**
     * <pre>
     * No hash requested.
     * </pre>
     *
     * <code>NONE = 0;</code>
     */
    NONE(0),
    /**
     * <pre>
     * A sha256 hash.
     * </pre>
     *
     * <code>SHA256 = 1;</code>
     */
    SHA256(1),
    UNRECOGNIZED(-1),
    ;

    /**
     * <pre>
     * No hash requested.
     * </pre>
     *
     * <code>NONE = 0;</code>
     */
    public static final int NONE_VALUE = 0;
    /**
     * <pre>
     * A sha256 hash.
     * </pre>
     *
     * <code>SHA256 = 1;</code>
     */
    public static final int SHA256_VALUE = 1;


    public final int getNumber() {
      if (this == UNRECOGNIZED) {
        throw new java.lang.IllegalArgumentException(
            "Can't get the number of an unknown enum value.");
      }
      return value;
    }

    /**
     * @deprecated Use {@link #forNumber(int)} instead.
     */
    @java.lang.Deprecated
    public static HashType valueOf(int value) {
      return forNumber(value);
    }

    public static HashType forNumber(int value) {
      switch (value) {
        case 0: return NONE;
        case 1: return SHA256;
        default: return null;
      }
    }

    public static com.google.protobuf.Internal.EnumLiteMap<HashType>
        internalGetValueMap() {
      return internalValueMap;
    }
    private static final com.google.protobuf.Internal.EnumLiteMap<
        HashType> internalValueMap =
          new com.google.protobuf.Internal.EnumLiteMap<HashType>() {
            public HashType findValueByNumber(int number) {
              return HashType.forNumber(number);
            }
          };

    public final com.google.protobuf.Descriptors.EnumValueDescriptor
        getValueDescriptor() {
      return getDescriptor().getValues().get(ordinal());
    }
    public final com.google.protobuf.Descriptors.EnumDescriptor
        getDescriptorForType() {
      return getDescriptor();
    }
    public static final com.google.protobuf.Descriptors.EnumDescriptor
        getDescriptor() {
      return com.google.containeranalysis.v1alpha1.Hash.getDescriptor().getEnumTypes().get(0);
    }

    private static final HashType[] VALUES = values();

    public static HashType valueOf(
        com.google.protobuf.Descriptors.EnumValueDescriptor desc) {
      if (desc.getType() != getDescriptor()) {
        throw new java.lang.IllegalArgumentException(
          "EnumValueDescriptor is not for this type.");
      }
      if (desc.getIndex() == -1) {
        return UNRECOGNIZED;
      }
      return VALUES[desc.getIndex()];
    }

    private final int value;

    private HashType(int value) {
      this.value = value;
    }

    // @@protoc_insertion_point(enum_scope:google.devtools.containeranalysis.v1alpha1.Hash.HashType)
  }

  public static final int TYPE_FIELD_NUMBER = 1;
  private int type_;
  /**
   * <pre>
   * The type of hash that was performed.
   * </pre>
   *
   * <code>.google.devtools.containeranalysis.v1alpha1.Hash.HashType type = 1;</code>
   */
  public int getTypeValue() {
    return type_;
  }
  /**
   * <pre>
   * The type of hash that was performed.
   * </pre>
   *
   * <code>.google.devtools.containeranalysis.v1alpha1.Hash.HashType type = 1;</code>
   */
  public com.google.containeranalysis.v1alpha1.Hash.HashType getType() {
    @SuppressWarnings("deprecation")
    com.google.containeranalysis.v1alpha1.Hash.HashType result = com.google.containeranalysis.v1alpha1.Hash.HashType.valueOf(type_);
    return result == null ? com.google.containeranalysis.v1alpha1.Hash.HashType.UNRECOGNIZED : result;
  }

  public static final int VALUE_FIELD_NUMBER = 2;
  private com.google.protobuf.ByteString value_;
  /**
   * <pre>
   * The hash value.
   * </pre>
   *
   * <code>bytes value = 2;</code>
   */
  public com.google.protobuf.ByteString getValue() {
    return value_;
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
    if (type_ != com.google.containeranalysis.v1alpha1.Hash.HashType.NONE.getNumber()) {
      output.writeEnum(1, type_);
    }
    if (!value_.isEmpty()) {
      output.writeBytes(2, value_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (type_ != com.google.containeranalysis.v1alpha1.Hash.HashType.NONE.getNumber()) {
      size += com.google.protobuf.CodedOutputStream
        .computeEnumSize(1, type_);
    }
    if (!value_.isEmpty()) {
      size += com.google.protobuf.CodedOutputStream
        .computeBytesSize(2, value_);
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
    if (!(obj instanceof com.google.containeranalysis.v1alpha1.Hash)) {
      return super.equals(obj);
    }
    com.google.containeranalysis.v1alpha1.Hash other = (com.google.containeranalysis.v1alpha1.Hash) obj;

    if (type_ != other.type_) return false;
    if (!getValue()
        .equals(other.getValue())) return false;
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
    hash = (37 * hash) + TYPE_FIELD_NUMBER;
    hash = (53 * hash) + type_;
    hash = (37 * hash) + VALUE_FIELD_NUMBER;
    hash = (53 * hash) + getValue().hashCode();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.containeranalysis.v1alpha1.Hash parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.containeranalysis.v1alpha1.Hash parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.containeranalysis.v1alpha1.Hash parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.containeranalysis.v1alpha1.Hash parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.containeranalysis.v1alpha1.Hash parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.containeranalysis.v1alpha1.Hash parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.containeranalysis.v1alpha1.Hash parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.containeranalysis.v1alpha1.Hash parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.containeranalysis.v1alpha1.Hash parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.containeranalysis.v1alpha1.Hash parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.containeranalysis.v1alpha1.Hash parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.containeranalysis.v1alpha1.Hash parseFrom(
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
  public static Builder newBuilder(com.google.containeranalysis.v1alpha1.Hash prototype) {
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
   * Container message for hash values.
   * </pre>
   *
   * Protobuf type {@code google.devtools.containeranalysis.v1alpha1.Hash}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.devtools.containeranalysis.v1alpha1.Hash)
      com.google.containeranalysis.v1alpha1.HashOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.containeranalysis.v1alpha1.Provenance.internal_static_google_devtools_containeranalysis_v1alpha1_Hash_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.containeranalysis.v1alpha1.Provenance.internal_static_google_devtools_containeranalysis_v1alpha1_Hash_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.containeranalysis.v1alpha1.Hash.class, com.google.containeranalysis.v1alpha1.Hash.Builder.class);
    }

    // Construct using com.google.containeranalysis.v1alpha1.Hash.newBuilder()
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
      type_ = 0;

      value_ = com.google.protobuf.ByteString.EMPTY;

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.containeranalysis.v1alpha1.Provenance.internal_static_google_devtools_containeranalysis_v1alpha1_Hash_descriptor;
    }

    @java.lang.Override
    public com.google.containeranalysis.v1alpha1.Hash getDefaultInstanceForType() {
      return com.google.containeranalysis.v1alpha1.Hash.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.containeranalysis.v1alpha1.Hash build() {
      com.google.containeranalysis.v1alpha1.Hash result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.containeranalysis.v1alpha1.Hash buildPartial() {
      com.google.containeranalysis.v1alpha1.Hash result = new com.google.containeranalysis.v1alpha1.Hash(this);
      result.type_ = type_;
      result.value_ = value_;
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
      if (other instanceof com.google.containeranalysis.v1alpha1.Hash) {
        return mergeFrom((com.google.containeranalysis.v1alpha1.Hash)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.containeranalysis.v1alpha1.Hash other) {
      if (other == com.google.containeranalysis.v1alpha1.Hash.getDefaultInstance()) return this;
      if (other.type_ != 0) {
        setTypeValue(other.getTypeValue());
      }
      if (other.getValue() != com.google.protobuf.ByteString.EMPTY) {
        setValue(other.getValue());
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
      com.google.containeranalysis.v1alpha1.Hash parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.containeranalysis.v1alpha1.Hash) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private int type_ = 0;
    /**
     * <pre>
     * The type of hash that was performed.
     * </pre>
     *
     * <code>.google.devtools.containeranalysis.v1alpha1.Hash.HashType type = 1;</code>
     */
    public int getTypeValue() {
      return type_;
    }
    /**
     * <pre>
     * The type of hash that was performed.
     * </pre>
     *
     * <code>.google.devtools.containeranalysis.v1alpha1.Hash.HashType type = 1;</code>
     */
    public Builder setTypeValue(int value) {
      type_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The type of hash that was performed.
     * </pre>
     *
     * <code>.google.devtools.containeranalysis.v1alpha1.Hash.HashType type = 1;</code>
     */
    public com.google.containeranalysis.v1alpha1.Hash.HashType getType() {
      @SuppressWarnings("deprecation")
      com.google.containeranalysis.v1alpha1.Hash.HashType result = com.google.containeranalysis.v1alpha1.Hash.HashType.valueOf(type_);
      return result == null ? com.google.containeranalysis.v1alpha1.Hash.HashType.UNRECOGNIZED : result;
    }
    /**
     * <pre>
     * The type of hash that was performed.
     * </pre>
     *
     * <code>.google.devtools.containeranalysis.v1alpha1.Hash.HashType type = 1;</code>
     */
    public Builder setType(com.google.containeranalysis.v1alpha1.Hash.HashType value) {
      if (value == null) {
        throw new NullPointerException();
      }
      
      type_ = value.getNumber();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The type of hash that was performed.
     * </pre>
     *
     * <code>.google.devtools.containeranalysis.v1alpha1.Hash.HashType type = 1;</code>
     */
    public Builder clearType() {
      
      type_ = 0;
      onChanged();
      return this;
    }

    private com.google.protobuf.ByteString value_ = com.google.protobuf.ByteString.EMPTY;
    /**
     * <pre>
     * The hash value.
     * </pre>
     *
     * <code>bytes value = 2;</code>
     */
    public com.google.protobuf.ByteString getValue() {
      return value_;
    }
    /**
     * <pre>
     * The hash value.
     * </pre>
     *
     * <code>bytes value = 2;</code>
     */
    public Builder setValue(com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      value_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * The hash value.
     * </pre>
     *
     * <code>bytes value = 2;</code>
     */
    public Builder clearValue() {
      
      value_ = getDefaultInstance().getValue();
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


    // @@protoc_insertion_point(builder_scope:google.devtools.containeranalysis.v1alpha1.Hash)
  }

  // @@protoc_insertion_point(class_scope:google.devtools.containeranalysis.v1alpha1.Hash)
  private static final com.google.containeranalysis.v1alpha1.Hash DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.containeranalysis.v1alpha1.Hash();
  }

  public static com.google.containeranalysis.v1alpha1.Hash getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<Hash>
      PARSER = new com.google.protobuf.AbstractParser<Hash>() {
    @java.lang.Override
    public Hash parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new Hash(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<Hash> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<Hash> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.containeranalysis.v1alpha1.Hash getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

