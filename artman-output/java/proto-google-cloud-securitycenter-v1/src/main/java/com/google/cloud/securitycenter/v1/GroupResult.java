// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/securitycenter/v1/securitycenter_service.proto

package com.google.cloud.securitycenter.v1;

/**
 * <pre>
 * Result containing the properties and count of a groupBy request.
 * </pre>
 *
 * Protobuf type {@code google.cloud.securitycenter.v1.GroupResult}
 */
public  final class GroupResult extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.securitycenter.v1.GroupResult)
    GroupResultOrBuilder {
private static final long serialVersionUID = 0L;
  // Use GroupResult.newBuilder() to construct.
  private GroupResult(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private GroupResult() {
  }

  @java.lang.Override
  @SuppressWarnings({"unused"})
  protected java.lang.Object newInstance(
      UnusedPrivateParameter unused) {
    return new GroupResult();
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private GroupResult(
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
            if (!((mutable_bitField0_ & 0x00000001) != 0)) {
              properties_ = com.google.protobuf.MapField.newMapField(
                  PropertiesDefaultEntryHolder.defaultEntry);
              mutable_bitField0_ |= 0x00000001;
            }
            com.google.protobuf.MapEntry<java.lang.String, com.google.protobuf.Value>
            properties__ = input.readMessage(
                PropertiesDefaultEntryHolder.defaultEntry.getParserForType(), extensionRegistry);
            properties_.getMutableMap().put(
                properties__.getKey(), properties__.getValue());
            break;
          }
          case 16: {

            count_ = input.readInt64();
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
    return com.google.cloud.securitycenter.v1.SecuritycenterService.internal_static_google_cloud_securitycenter_v1_GroupResult_descriptor;
  }

  @SuppressWarnings({"rawtypes"})
  @java.lang.Override
  protected com.google.protobuf.MapField internalGetMapField(
      int number) {
    switch (number) {
      case 1:
        return internalGetProperties();
      default:
        throw new RuntimeException(
            "Invalid map field number: " + number);
    }
  }
  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.securitycenter.v1.SecuritycenterService.internal_static_google_cloud_securitycenter_v1_GroupResult_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.securitycenter.v1.GroupResult.class, com.google.cloud.securitycenter.v1.GroupResult.Builder.class);
  }

  public static final int PROPERTIES_FIELD_NUMBER = 1;
  private static final class PropertiesDefaultEntryHolder {
    static final com.google.protobuf.MapEntry<
        java.lang.String, com.google.protobuf.Value> defaultEntry =
            com.google.protobuf.MapEntry
            .<java.lang.String, com.google.protobuf.Value>newDefaultInstance(
                com.google.cloud.securitycenter.v1.SecuritycenterService.internal_static_google_cloud_securitycenter_v1_GroupResult_PropertiesEntry_descriptor, 
                com.google.protobuf.WireFormat.FieldType.STRING,
                "",
                com.google.protobuf.WireFormat.FieldType.MESSAGE,
                com.google.protobuf.Value.getDefaultInstance());
  }
  private com.google.protobuf.MapField<
      java.lang.String, com.google.protobuf.Value> properties_;
  private com.google.protobuf.MapField<java.lang.String, com.google.protobuf.Value>
  internalGetProperties() {
    if (properties_ == null) {
      return com.google.protobuf.MapField.emptyMapField(
          PropertiesDefaultEntryHolder.defaultEntry);
    }
    return properties_;
  }

  public int getPropertiesCount() {
    return internalGetProperties().getMap().size();
  }
  /**
   * <pre>
   * Properties matching the groupBy fields in the request.
   * </pre>
   *
   * <code>map&lt;string, .google.protobuf.Value&gt; properties = 1;</code>
   */

  public boolean containsProperties(
      java.lang.String key) {
    if (key == null) { throw new java.lang.NullPointerException(); }
    return internalGetProperties().getMap().containsKey(key);
  }
  /**
   * Use {@link #getPropertiesMap()} instead.
   */
  @java.lang.Deprecated
  public java.util.Map<java.lang.String, com.google.protobuf.Value> getProperties() {
    return getPropertiesMap();
  }
  /**
   * <pre>
   * Properties matching the groupBy fields in the request.
   * </pre>
   *
   * <code>map&lt;string, .google.protobuf.Value&gt; properties = 1;</code>
   */

  public java.util.Map<java.lang.String, com.google.protobuf.Value> getPropertiesMap() {
    return internalGetProperties().getMap();
  }
  /**
   * <pre>
   * Properties matching the groupBy fields in the request.
   * </pre>
   *
   * <code>map&lt;string, .google.protobuf.Value&gt; properties = 1;</code>
   */

  public com.google.protobuf.Value getPropertiesOrDefault(
      java.lang.String key,
      com.google.protobuf.Value defaultValue) {
    if (key == null) { throw new java.lang.NullPointerException(); }
    java.util.Map<java.lang.String, com.google.protobuf.Value> map =
        internalGetProperties().getMap();
    return map.containsKey(key) ? map.get(key) : defaultValue;
  }
  /**
   * <pre>
   * Properties matching the groupBy fields in the request.
   * </pre>
   *
   * <code>map&lt;string, .google.protobuf.Value&gt; properties = 1;</code>
   */

  public com.google.protobuf.Value getPropertiesOrThrow(
      java.lang.String key) {
    if (key == null) { throw new java.lang.NullPointerException(); }
    java.util.Map<java.lang.String, com.google.protobuf.Value> map =
        internalGetProperties().getMap();
    if (!map.containsKey(key)) {
      throw new java.lang.IllegalArgumentException();
    }
    return map.get(key);
  }

  public static final int COUNT_FIELD_NUMBER = 2;
  private long count_;
  /**
   * <pre>
   * Total count of resources for the given properties.
   * </pre>
   *
   * <code>int64 count = 2;</code>
   * @return The count.
   */
  public long getCount() {
    return count_;
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
    com.google.protobuf.GeneratedMessageV3
      .serializeStringMapTo(
        output,
        internalGetProperties(),
        PropertiesDefaultEntryHolder.defaultEntry,
        1);
    if (count_ != 0L) {
      output.writeInt64(2, count_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    for (java.util.Map.Entry<java.lang.String, com.google.protobuf.Value> entry
         : internalGetProperties().getMap().entrySet()) {
      com.google.protobuf.MapEntry<java.lang.String, com.google.protobuf.Value>
      properties__ = PropertiesDefaultEntryHolder.defaultEntry.newBuilderForType()
          .setKey(entry.getKey())
          .setValue(entry.getValue())
          .build();
      size += com.google.protobuf.CodedOutputStream
          .computeMessageSize(1, properties__);
    }
    if (count_ != 0L) {
      size += com.google.protobuf.CodedOutputStream
        .computeInt64Size(2, count_);
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
    if (!(obj instanceof com.google.cloud.securitycenter.v1.GroupResult)) {
      return super.equals(obj);
    }
    com.google.cloud.securitycenter.v1.GroupResult other = (com.google.cloud.securitycenter.v1.GroupResult) obj;

    if (!internalGetProperties().equals(
        other.internalGetProperties())) return false;
    if (getCount()
        != other.getCount()) return false;
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
    if (!internalGetProperties().getMap().isEmpty()) {
      hash = (37 * hash) + PROPERTIES_FIELD_NUMBER;
      hash = (53 * hash) + internalGetProperties().hashCode();
    }
    hash = (37 * hash) + COUNT_FIELD_NUMBER;
    hash = (53 * hash) + com.google.protobuf.Internal.hashLong(
        getCount());
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.securitycenter.v1.GroupResult parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.securitycenter.v1.GroupResult parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.securitycenter.v1.GroupResult parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.securitycenter.v1.GroupResult parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.securitycenter.v1.GroupResult parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.securitycenter.v1.GroupResult parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.securitycenter.v1.GroupResult parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.securitycenter.v1.GroupResult parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.securitycenter.v1.GroupResult parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.securitycenter.v1.GroupResult parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.securitycenter.v1.GroupResult parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.securitycenter.v1.GroupResult parseFrom(
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
  public static Builder newBuilder(com.google.cloud.securitycenter.v1.GroupResult prototype) {
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
   * Result containing the properties and count of a groupBy request.
   * </pre>
   *
   * Protobuf type {@code google.cloud.securitycenter.v1.GroupResult}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.securitycenter.v1.GroupResult)
      com.google.cloud.securitycenter.v1.GroupResultOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.securitycenter.v1.SecuritycenterService.internal_static_google_cloud_securitycenter_v1_GroupResult_descriptor;
    }

    @SuppressWarnings({"rawtypes"})
    protected com.google.protobuf.MapField internalGetMapField(
        int number) {
      switch (number) {
        case 1:
          return internalGetProperties();
        default:
          throw new RuntimeException(
              "Invalid map field number: " + number);
      }
    }
    @SuppressWarnings({"rawtypes"})
    protected com.google.protobuf.MapField internalGetMutableMapField(
        int number) {
      switch (number) {
        case 1:
          return internalGetMutableProperties();
        default:
          throw new RuntimeException(
              "Invalid map field number: " + number);
      }
    }
    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.securitycenter.v1.SecuritycenterService.internal_static_google_cloud_securitycenter_v1_GroupResult_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.securitycenter.v1.GroupResult.class, com.google.cloud.securitycenter.v1.GroupResult.Builder.class);
    }

    // Construct using com.google.cloud.securitycenter.v1.GroupResult.newBuilder()
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
      internalGetMutableProperties().clear();
      count_ = 0L;

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.securitycenter.v1.SecuritycenterService.internal_static_google_cloud_securitycenter_v1_GroupResult_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.securitycenter.v1.GroupResult getDefaultInstanceForType() {
      return com.google.cloud.securitycenter.v1.GroupResult.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.securitycenter.v1.GroupResult build() {
      com.google.cloud.securitycenter.v1.GroupResult result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.securitycenter.v1.GroupResult buildPartial() {
      com.google.cloud.securitycenter.v1.GroupResult result = new com.google.cloud.securitycenter.v1.GroupResult(this);
      int from_bitField0_ = bitField0_;
      result.properties_ = internalGetProperties();
      result.properties_.makeImmutable();
      result.count_ = count_;
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
      if (other instanceof com.google.cloud.securitycenter.v1.GroupResult) {
        return mergeFrom((com.google.cloud.securitycenter.v1.GroupResult)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.securitycenter.v1.GroupResult other) {
      if (other == com.google.cloud.securitycenter.v1.GroupResult.getDefaultInstance()) return this;
      internalGetMutableProperties().mergeFrom(
          other.internalGetProperties());
      if (other.getCount() != 0L) {
        setCount(other.getCount());
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
      com.google.cloud.securitycenter.v1.GroupResult parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.securitycenter.v1.GroupResult) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int bitField0_;

    private com.google.protobuf.MapField<
        java.lang.String, com.google.protobuf.Value> properties_;
    private com.google.protobuf.MapField<java.lang.String, com.google.protobuf.Value>
    internalGetProperties() {
      if (properties_ == null) {
        return com.google.protobuf.MapField.emptyMapField(
            PropertiesDefaultEntryHolder.defaultEntry);
      }
      return properties_;
    }
    private com.google.protobuf.MapField<java.lang.String, com.google.protobuf.Value>
    internalGetMutableProperties() {
      onChanged();;
      if (properties_ == null) {
        properties_ = com.google.protobuf.MapField.newMapField(
            PropertiesDefaultEntryHolder.defaultEntry);
      }
      if (!properties_.isMutable()) {
        properties_ = properties_.copy();
      }
      return properties_;
    }

    public int getPropertiesCount() {
      return internalGetProperties().getMap().size();
    }
    /**
     * <pre>
     * Properties matching the groupBy fields in the request.
     * </pre>
     *
     * <code>map&lt;string, .google.protobuf.Value&gt; properties = 1;</code>
     */

    public boolean containsProperties(
        java.lang.String key) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      return internalGetProperties().getMap().containsKey(key);
    }
    /**
     * Use {@link #getPropertiesMap()} instead.
     */
    @java.lang.Deprecated
    public java.util.Map<java.lang.String, com.google.protobuf.Value> getProperties() {
      return getPropertiesMap();
    }
    /**
     * <pre>
     * Properties matching the groupBy fields in the request.
     * </pre>
     *
     * <code>map&lt;string, .google.protobuf.Value&gt; properties = 1;</code>
     */

    public java.util.Map<java.lang.String, com.google.protobuf.Value> getPropertiesMap() {
      return internalGetProperties().getMap();
    }
    /**
     * <pre>
     * Properties matching the groupBy fields in the request.
     * </pre>
     *
     * <code>map&lt;string, .google.protobuf.Value&gt; properties = 1;</code>
     */

    public com.google.protobuf.Value getPropertiesOrDefault(
        java.lang.String key,
        com.google.protobuf.Value defaultValue) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      java.util.Map<java.lang.String, com.google.protobuf.Value> map =
          internalGetProperties().getMap();
      return map.containsKey(key) ? map.get(key) : defaultValue;
    }
    /**
     * <pre>
     * Properties matching the groupBy fields in the request.
     * </pre>
     *
     * <code>map&lt;string, .google.protobuf.Value&gt; properties = 1;</code>
     */

    public com.google.protobuf.Value getPropertiesOrThrow(
        java.lang.String key) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      java.util.Map<java.lang.String, com.google.protobuf.Value> map =
          internalGetProperties().getMap();
      if (!map.containsKey(key)) {
        throw new java.lang.IllegalArgumentException();
      }
      return map.get(key);
    }

    public Builder clearProperties() {
      internalGetMutableProperties().getMutableMap()
          .clear();
      return this;
    }
    /**
     * <pre>
     * Properties matching the groupBy fields in the request.
     * </pre>
     *
     * <code>map&lt;string, .google.protobuf.Value&gt; properties = 1;</code>
     */

    public Builder removeProperties(
        java.lang.String key) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      internalGetMutableProperties().getMutableMap()
          .remove(key);
      return this;
    }
    /**
     * Use alternate mutation accessors instead.
     */
    @java.lang.Deprecated
    public java.util.Map<java.lang.String, com.google.protobuf.Value>
    getMutableProperties() {
      return internalGetMutableProperties().getMutableMap();
    }
    /**
     * <pre>
     * Properties matching the groupBy fields in the request.
     * </pre>
     *
     * <code>map&lt;string, .google.protobuf.Value&gt; properties = 1;</code>
     */
    public Builder putProperties(
        java.lang.String key,
        com.google.protobuf.Value value) {
      if (key == null) { throw new java.lang.NullPointerException(); }
      if (value == null) { throw new java.lang.NullPointerException(); }
      internalGetMutableProperties().getMutableMap()
          .put(key, value);
      return this;
    }
    /**
     * <pre>
     * Properties matching the groupBy fields in the request.
     * </pre>
     *
     * <code>map&lt;string, .google.protobuf.Value&gt; properties = 1;</code>
     */

    public Builder putAllProperties(
        java.util.Map<java.lang.String, com.google.protobuf.Value> values) {
      internalGetMutableProperties().getMutableMap()
          .putAll(values);
      return this;
    }

    private long count_ ;
    /**
     * <pre>
     * Total count of resources for the given properties.
     * </pre>
     *
     * <code>int64 count = 2;</code>
     * @return The count.
     */
    public long getCount() {
      return count_;
    }
    /**
     * <pre>
     * Total count of resources for the given properties.
     * </pre>
     *
     * <code>int64 count = 2;</code>
     * @param value The count to set.
     * @return This builder for chaining.
     */
    public Builder setCount(long value) {
      
      count_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Total count of resources for the given properties.
     * </pre>
     *
     * <code>int64 count = 2;</code>
     * @return This builder for chaining.
     */
    public Builder clearCount() {
      
      count_ = 0L;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.securitycenter.v1.GroupResult)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.securitycenter.v1.GroupResult)
  private static final com.google.cloud.securitycenter.v1.GroupResult DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.securitycenter.v1.GroupResult();
  }

  public static com.google.cloud.securitycenter.v1.GroupResult getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<GroupResult>
      PARSER = new com.google.protobuf.AbstractParser<GroupResult>() {
    @java.lang.Override
    public GroupResult parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new GroupResult(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<GroupResult> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<GroupResult> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.securitycenter.v1.GroupResult getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}
