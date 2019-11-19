// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/privacy/dlp/v2/dlp.proto

package com.google.privacy.dlp.v2;

/**
 * <pre>
 * Container structure for the content to inspect.
 * </pre>
 *
 * Protobuf type {@code google.privacy.dlp.v2.ContentItem}
 */
public  final class ContentItem extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.privacy.dlp.v2.ContentItem)
    ContentItemOrBuilder {
private static final long serialVersionUID = 0L;
  // Use ContentItem.newBuilder() to construct.
  private ContentItem(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private ContentItem() {
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private ContentItem(
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
          case 26: {
            java.lang.String s = input.readStringRequireUtf8();
            dataItemCase_ = 3;
            dataItem_ = s;
            break;
          }
          case 34: {
            com.google.privacy.dlp.v2.Table.Builder subBuilder = null;
            if (dataItemCase_ == 4) {
              subBuilder = ((com.google.privacy.dlp.v2.Table) dataItem_).toBuilder();
            }
            dataItem_ =
                input.readMessage(com.google.privacy.dlp.v2.Table.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom((com.google.privacy.dlp.v2.Table) dataItem_);
              dataItem_ = subBuilder.buildPartial();
            }
            dataItemCase_ = 4;
            break;
          }
          case 42: {
            com.google.privacy.dlp.v2.ByteContentItem.Builder subBuilder = null;
            if (dataItemCase_ == 5) {
              subBuilder = ((com.google.privacy.dlp.v2.ByteContentItem) dataItem_).toBuilder();
            }
            dataItem_ =
                input.readMessage(com.google.privacy.dlp.v2.ByteContentItem.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom((com.google.privacy.dlp.v2.ByteContentItem) dataItem_);
              dataItem_ = subBuilder.buildPartial();
            }
            dataItemCase_ = 5;
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
    return com.google.privacy.dlp.v2.DlpProto.internal_static_google_privacy_dlp_v2_ContentItem_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.privacy.dlp.v2.DlpProto.internal_static_google_privacy_dlp_v2_ContentItem_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.privacy.dlp.v2.ContentItem.class, com.google.privacy.dlp.v2.ContentItem.Builder.class);
  }

  private int dataItemCase_ = 0;
  private java.lang.Object dataItem_;
  public enum DataItemCase
      implements com.google.protobuf.Internal.EnumLite {
    VALUE(3),
    TABLE(4),
    BYTE_ITEM(5),
    DATAITEM_NOT_SET(0);
    private final int value;
    private DataItemCase(int value) {
      this.value = value;
    }
    /**
     * @deprecated Use {@link #forNumber(int)} instead.
     */
    @java.lang.Deprecated
    public static DataItemCase valueOf(int value) {
      return forNumber(value);
    }

    public static DataItemCase forNumber(int value) {
      switch (value) {
        case 3: return VALUE;
        case 4: return TABLE;
        case 5: return BYTE_ITEM;
        case 0: return DATAITEM_NOT_SET;
        default: return null;
      }
    }
    public int getNumber() {
      return this.value;
    }
  };

  public DataItemCase
  getDataItemCase() {
    return DataItemCase.forNumber(
        dataItemCase_);
  }

  public static final int VALUE_FIELD_NUMBER = 3;
  /**
   * <pre>
   * String data to inspect or redact.
   * </pre>
   *
   * <code>string value = 3;</code>
   */
  public java.lang.String getValue() {
    java.lang.Object ref = "";
    if (dataItemCase_ == 3) {
      ref = dataItem_;
    }
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      if (dataItemCase_ == 3) {
        dataItem_ = s;
      }
      return s;
    }
  }
  /**
   * <pre>
   * String data to inspect or redact.
   * </pre>
   *
   * <code>string value = 3;</code>
   */
  public com.google.protobuf.ByteString
      getValueBytes() {
    java.lang.Object ref = "";
    if (dataItemCase_ == 3) {
      ref = dataItem_;
    }
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      if (dataItemCase_ == 3) {
        dataItem_ = b;
      }
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int TABLE_FIELD_NUMBER = 4;
  /**
   * <pre>
   * Structured content for inspection. See
   * https://cloud.google.com/dlp/docs/inspecting-text#inspecting_a_table to
   * learn more.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.Table table = 4;</code>
   */
  public boolean hasTable() {
    return dataItemCase_ == 4;
  }
  /**
   * <pre>
   * Structured content for inspection. See
   * https://cloud.google.com/dlp/docs/inspecting-text#inspecting_a_table to
   * learn more.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.Table table = 4;</code>
   */
  public com.google.privacy.dlp.v2.Table getTable() {
    if (dataItemCase_ == 4) {
       return (com.google.privacy.dlp.v2.Table) dataItem_;
    }
    return com.google.privacy.dlp.v2.Table.getDefaultInstance();
  }
  /**
   * <pre>
   * Structured content for inspection. See
   * https://cloud.google.com/dlp/docs/inspecting-text#inspecting_a_table to
   * learn more.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.Table table = 4;</code>
   */
  public com.google.privacy.dlp.v2.TableOrBuilder getTableOrBuilder() {
    if (dataItemCase_ == 4) {
       return (com.google.privacy.dlp.v2.Table) dataItem_;
    }
    return com.google.privacy.dlp.v2.Table.getDefaultInstance();
  }

  public static final int BYTE_ITEM_FIELD_NUMBER = 5;
  /**
   * <pre>
   * Content data to inspect or redact. Replaces `type` and `data`.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.ByteContentItem byte_item = 5;</code>
   */
  public boolean hasByteItem() {
    return dataItemCase_ == 5;
  }
  /**
   * <pre>
   * Content data to inspect or redact. Replaces `type` and `data`.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.ByteContentItem byte_item = 5;</code>
   */
  public com.google.privacy.dlp.v2.ByteContentItem getByteItem() {
    if (dataItemCase_ == 5) {
       return (com.google.privacy.dlp.v2.ByteContentItem) dataItem_;
    }
    return com.google.privacy.dlp.v2.ByteContentItem.getDefaultInstance();
  }
  /**
   * <pre>
   * Content data to inspect or redact. Replaces `type` and `data`.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.ByteContentItem byte_item = 5;</code>
   */
  public com.google.privacy.dlp.v2.ByteContentItemOrBuilder getByteItemOrBuilder() {
    if (dataItemCase_ == 5) {
       return (com.google.privacy.dlp.v2.ByteContentItem) dataItem_;
    }
    return com.google.privacy.dlp.v2.ByteContentItem.getDefaultInstance();
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
    if (dataItemCase_ == 3) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 3, dataItem_);
    }
    if (dataItemCase_ == 4) {
      output.writeMessage(4, (com.google.privacy.dlp.v2.Table) dataItem_);
    }
    if (dataItemCase_ == 5) {
      output.writeMessage(5, (com.google.privacy.dlp.v2.ByteContentItem) dataItem_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (dataItemCase_ == 3) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(3, dataItem_);
    }
    if (dataItemCase_ == 4) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(4, (com.google.privacy.dlp.v2.Table) dataItem_);
    }
    if (dataItemCase_ == 5) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(5, (com.google.privacy.dlp.v2.ByteContentItem) dataItem_);
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
    if (!(obj instanceof com.google.privacy.dlp.v2.ContentItem)) {
      return super.equals(obj);
    }
    com.google.privacy.dlp.v2.ContentItem other = (com.google.privacy.dlp.v2.ContentItem) obj;

    if (!getDataItemCase().equals(other.getDataItemCase())) return false;
    switch (dataItemCase_) {
      case 3:
        if (!getValue()
            .equals(other.getValue())) return false;
        break;
      case 4:
        if (!getTable()
            .equals(other.getTable())) return false;
        break;
      case 5:
        if (!getByteItem()
            .equals(other.getByteItem())) return false;
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
    switch (dataItemCase_) {
      case 3:
        hash = (37 * hash) + VALUE_FIELD_NUMBER;
        hash = (53 * hash) + getValue().hashCode();
        break;
      case 4:
        hash = (37 * hash) + TABLE_FIELD_NUMBER;
        hash = (53 * hash) + getTable().hashCode();
        break;
      case 5:
        hash = (37 * hash) + BYTE_ITEM_FIELD_NUMBER;
        hash = (53 * hash) + getByteItem().hashCode();
        break;
      case 0:
      default:
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.privacy.dlp.v2.ContentItem parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.privacy.dlp.v2.ContentItem parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.privacy.dlp.v2.ContentItem parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.privacy.dlp.v2.ContentItem parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.privacy.dlp.v2.ContentItem parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.privacy.dlp.v2.ContentItem parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.privacy.dlp.v2.ContentItem parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.privacy.dlp.v2.ContentItem parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.privacy.dlp.v2.ContentItem parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.privacy.dlp.v2.ContentItem parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.privacy.dlp.v2.ContentItem parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.privacy.dlp.v2.ContentItem parseFrom(
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
  public static Builder newBuilder(com.google.privacy.dlp.v2.ContentItem prototype) {
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
   * Container structure for the content to inspect.
   * </pre>
   *
   * Protobuf type {@code google.privacy.dlp.v2.ContentItem}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.privacy.dlp.v2.ContentItem)
      com.google.privacy.dlp.v2.ContentItemOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.privacy.dlp.v2.DlpProto.internal_static_google_privacy_dlp_v2_ContentItem_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.privacy.dlp.v2.DlpProto.internal_static_google_privacy_dlp_v2_ContentItem_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.privacy.dlp.v2.ContentItem.class, com.google.privacy.dlp.v2.ContentItem.Builder.class);
    }

    // Construct using com.google.privacy.dlp.v2.ContentItem.newBuilder()
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
      dataItemCase_ = 0;
      dataItem_ = null;
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.privacy.dlp.v2.DlpProto.internal_static_google_privacy_dlp_v2_ContentItem_descriptor;
    }

    @java.lang.Override
    public com.google.privacy.dlp.v2.ContentItem getDefaultInstanceForType() {
      return com.google.privacy.dlp.v2.ContentItem.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.privacy.dlp.v2.ContentItem build() {
      com.google.privacy.dlp.v2.ContentItem result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.privacy.dlp.v2.ContentItem buildPartial() {
      com.google.privacy.dlp.v2.ContentItem result = new com.google.privacy.dlp.v2.ContentItem(this);
      if (dataItemCase_ == 3) {
        result.dataItem_ = dataItem_;
      }
      if (dataItemCase_ == 4) {
        if (tableBuilder_ == null) {
          result.dataItem_ = dataItem_;
        } else {
          result.dataItem_ = tableBuilder_.build();
        }
      }
      if (dataItemCase_ == 5) {
        if (byteItemBuilder_ == null) {
          result.dataItem_ = dataItem_;
        } else {
          result.dataItem_ = byteItemBuilder_.build();
        }
      }
      result.dataItemCase_ = dataItemCase_;
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
      if (other instanceof com.google.privacy.dlp.v2.ContentItem) {
        return mergeFrom((com.google.privacy.dlp.v2.ContentItem)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.privacy.dlp.v2.ContentItem other) {
      if (other == com.google.privacy.dlp.v2.ContentItem.getDefaultInstance()) return this;
      switch (other.getDataItemCase()) {
        case VALUE: {
          dataItemCase_ = 3;
          dataItem_ = other.dataItem_;
          onChanged();
          break;
        }
        case TABLE: {
          mergeTable(other.getTable());
          break;
        }
        case BYTE_ITEM: {
          mergeByteItem(other.getByteItem());
          break;
        }
        case DATAITEM_NOT_SET: {
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
      com.google.privacy.dlp.v2.ContentItem parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.privacy.dlp.v2.ContentItem) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int dataItemCase_ = 0;
    private java.lang.Object dataItem_;
    public DataItemCase
        getDataItemCase() {
      return DataItemCase.forNumber(
          dataItemCase_);
    }

    public Builder clearDataItem() {
      dataItemCase_ = 0;
      dataItem_ = null;
      onChanged();
      return this;
    }


    /**
     * <pre>
     * String data to inspect or redact.
     * </pre>
     *
     * <code>string value = 3;</code>
     */
    public java.lang.String getValue() {
      java.lang.Object ref = "";
      if (dataItemCase_ == 3) {
        ref = dataItem_;
      }
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        if (dataItemCase_ == 3) {
          dataItem_ = s;
        }
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * String data to inspect or redact.
     * </pre>
     *
     * <code>string value = 3;</code>
     */
    public com.google.protobuf.ByteString
        getValueBytes() {
      java.lang.Object ref = "";
      if (dataItemCase_ == 3) {
        ref = dataItem_;
      }
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        if (dataItemCase_ == 3) {
          dataItem_ = b;
        }
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * String data to inspect or redact.
     * </pre>
     *
     * <code>string value = 3;</code>
     */
    public Builder setValue(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  dataItemCase_ = 3;
      dataItem_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * String data to inspect or redact.
     * </pre>
     *
     * <code>string value = 3;</code>
     */
    public Builder clearValue() {
      if (dataItemCase_ == 3) {
        dataItemCase_ = 0;
        dataItem_ = null;
        onChanged();
      }
      return this;
    }
    /**
     * <pre>
     * String data to inspect or redact.
     * </pre>
     *
     * <code>string value = 3;</code>
     */
    public Builder setValueBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      dataItemCase_ = 3;
      dataItem_ = value;
      onChanged();
      return this;
    }

    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.privacy.dlp.v2.Table, com.google.privacy.dlp.v2.Table.Builder, com.google.privacy.dlp.v2.TableOrBuilder> tableBuilder_;
    /**
     * <pre>
     * Structured content for inspection. See
     * https://cloud.google.com/dlp/docs/inspecting-text#inspecting_a_table to
     * learn more.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.Table table = 4;</code>
     */
    public boolean hasTable() {
      return dataItemCase_ == 4;
    }
    /**
     * <pre>
     * Structured content for inspection. See
     * https://cloud.google.com/dlp/docs/inspecting-text#inspecting_a_table to
     * learn more.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.Table table = 4;</code>
     */
    public com.google.privacy.dlp.v2.Table getTable() {
      if (tableBuilder_ == null) {
        if (dataItemCase_ == 4) {
          return (com.google.privacy.dlp.v2.Table) dataItem_;
        }
        return com.google.privacy.dlp.v2.Table.getDefaultInstance();
      } else {
        if (dataItemCase_ == 4) {
          return tableBuilder_.getMessage();
        }
        return com.google.privacy.dlp.v2.Table.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Structured content for inspection. See
     * https://cloud.google.com/dlp/docs/inspecting-text#inspecting_a_table to
     * learn more.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.Table table = 4;</code>
     */
    public Builder setTable(com.google.privacy.dlp.v2.Table value) {
      if (tableBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        dataItem_ = value;
        onChanged();
      } else {
        tableBuilder_.setMessage(value);
      }
      dataItemCase_ = 4;
      return this;
    }
    /**
     * <pre>
     * Structured content for inspection. See
     * https://cloud.google.com/dlp/docs/inspecting-text#inspecting_a_table to
     * learn more.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.Table table = 4;</code>
     */
    public Builder setTable(
        com.google.privacy.dlp.v2.Table.Builder builderForValue) {
      if (tableBuilder_ == null) {
        dataItem_ = builderForValue.build();
        onChanged();
      } else {
        tableBuilder_.setMessage(builderForValue.build());
      }
      dataItemCase_ = 4;
      return this;
    }
    /**
     * <pre>
     * Structured content for inspection. See
     * https://cloud.google.com/dlp/docs/inspecting-text#inspecting_a_table to
     * learn more.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.Table table = 4;</code>
     */
    public Builder mergeTable(com.google.privacy.dlp.v2.Table value) {
      if (tableBuilder_ == null) {
        if (dataItemCase_ == 4 &&
            dataItem_ != com.google.privacy.dlp.v2.Table.getDefaultInstance()) {
          dataItem_ = com.google.privacy.dlp.v2.Table.newBuilder((com.google.privacy.dlp.v2.Table) dataItem_)
              .mergeFrom(value).buildPartial();
        } else {
          dataItem_ = value;
        }
        onChanged();
      } else {
        if (dataItemCase_ == 4) {
          tableBuilder_.mergeFrom(value);
        }
        tableBuilder_.setMessage(value);
      }
      dataItemCase_ = 4;
      return this;
    }
    /**
     * <pre>
     * Structured content for inspection. See
     * https://cloud.google.com/dlp/docs/inspecting-text#inspecting_a_table to
     * learn more.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.Table table = 4;</code>
     */
    public Builder clearTable() {
      if (tableBuilder_ == null) {
        if (dataItemCase_ == 4) {
          dataItemCase_ = 0;
          dataItem_ = null;
          onChanged();
        }
      } else {
        if (dataItemCase_ == 4) {
          dataItemCase_ = 0;
          dataItem_ = null;
        }
        tableBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * Structured content for inspection. See
     * https://cloud.google.com/dlp/docs/inspecting-text#inspecting_a_table to
     * learn more.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.Table table = 4;</code>
     */
    public com.google.privacy.dlp.v2.Table.Builder getTableBuilder() {
      return getTableFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Structured content for inspection. See
     * https://cloud.google.com/dlp/docs/inspecting-text#inspecting_a_table to
     * learn more.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.Table table = 4;</code>
     */
    public com.google.privacy.dlp.v2.TableOrBuilder getTableOrBuilder() {
      if ((dataItemCase_ == 4) && (tableBuilder_ != null)) {
        return tableBuilder_.getMessageOrBuilder();
      } else {
        if (dataItemCase_ == 4) {
          return (com.google.privacy.dlp.v2.Table) dataItem_;
        }
        return com.google.privacy.dlp.v2.Table.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Structured content for inspection. See
     * https://cloud.google.com/dlp/docs/inspecting-text#inspecting_a_table to
     * learn more.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.Table table = 4;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.privacy.dlp.v2.Table, com.google.privacy.dlp.v2.Table.Builder, com.google.privacy.dlp.v2.TableOrBuilder> 
        getTableFieldBuilder() {
      if (tableBuilder_ == null) {
        if (!(dataItemCase_ == 4)) {
          dataItem_ = com.google.privacy.dlp.v2.Table.getDefaultInstance();
        }
        tableBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.privacy.dlp.v2.Table, com.google.privacy.dlp.v2.Table.Builder, com.google.privacy.dlp.v2.TableOrBuilder>(
                (com.google.privacy.dlp.v2.Table) dataItem_,
                getParentForChildren(),
                isClean());
        dataItem_ = null;
      }
      dataItemCase_ = 4;
      onChanged();;
      return tableBuilder_;
    }

    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.privacy.dlp.v2.ByteContentItem, com.google.privacy.dlp.v2.ByteContentItem.Builder, com.google.privacy.dlp.v2.ByteContentItemOrBuilder> byteItemBuilder_;
    /**
     * <pre>
     * Content data to inspect or redact. Replaces `type` and `data`.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.ByteContentItem byte_item = 5;</code>
     */
    public boolean hasByteItem() {
      return dataItemCase_ == 5;
    }
    /**
     * <pre>
     * Content data to inspect or redact. Replaces `type` and `data`.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.ByteContentItem byte_item = 5;</code>
     */
    public com.google.privacy.dlp.v2.ByteContentItem getByteItem() {
      if (byteItemBuilder_ == null) {
        if (dataItemCase_ == 5) {
          return (com.google.privacy.dlp.v2.ByteContentItem) dataItem_;
        }
        return com.google.privacy.dlp.v2.ByteContentItem.getDefaultInstance();
      } else {
        if (dataItemCase_ == 5) {
          return byteItemBuilder_.getMessage();
        }
        return com.google.privacy.dlp.v2.ByteContentItem.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Content data to inspect or redact. Replaces `type` and `data`.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.ByteContentItem byte_item = 5;</code>
     */
    public Builder setByteItem(com.google.privacy.dlp.v2.ByteContentItem value) {
      if (byteItemBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        dataItem_ = value;
        onChanged();
      } else {
        byteItemBuilder_.setMessage(value);
      }
      dataItemCase_ = 5;
      return this;
    }
    /**
     * <pre>
     * Content data to inspect or redact. Replaces `type` and `data`.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.ByteContentItem byte_item = 5;</code>
     */
    public Builder setByteItem(
        com.google.privacy.dlp.v2.ByteContentItem.Builder builderForValue) {
      if (byteItemBuilder_ == null) {
        dataItem_ = builderForValue.build();
        onChanged();
      } else {
        byteItemBuilder_.setMessage(builderForValue.build());
      }
      dataItemCase_ = 5;
      return this;
    }
    /**
     * <pre>
     * Content data to inspect or redact. Replaces `type` and `data`.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.ByteContentItem byte_item = 5;</code>
     */
    public Builder mergeByteItem(com.google.privacy.dlp.v2.ByteContentItem value) {
      if (byteItemBuilder_ == null) {
        if (dataItemCase_ == 5 &&
            dataItem_ != com.google.privacy.dlp.v2.ByteContentItem.getDefaultInstance()) {
          dataItem_ = com.google.privacy.dlp.v2.ByteContentItem.newBuilder((com.google.privacy.dlp.v2.ByteContentItem) dataItem_)
              .mergeFrom(value).buildPartial();
        } else {
          dataItem_ = value;
        }
        onChanged();
      } else {
        if (dataItemCase_ == 5) {
          byteItemBuilder_.mergeFrom(value);
        }
        byteItemBuilder_.setMessage(value);
      }
      dataItemCase_ = 5;
      return this;
    }
    /**
     * <pre>
     * Content data to inspect or redact. Replaces `type` and `data`.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.ByteContentItem byte_item = 5;</code>
     */
    public Builder clearByteItem() {
      if (byteItemBuilder_ == null) {
        if (dataItemCase_ == 5) {
          dataItemCase_ = 0;
          dataItem_ = null;
          onChanged();
        }
      } else {
        if (dataItemCase_ == 5) {
          dataItemCase_ = 0;
          dataItem_ = null;
        }
        byteItemBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * Content data to inspect or redact. Replaces `type` and `data`.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.ByteContentItem byte_item = 5;</code>
     */
    public com.google.privacy.dlp.v2.ByteContentItem.Builder getByteItemBuilder() {
      return getByteItemFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     * Content data to inspect or redact. Replaces `type` and `data`.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.ByteContentItem byte_item = 5;</code>
     */
    public com.google.privacy.dlp.v2.ByteContentItemOrBuilder getByteItemOrBuilder() {
      if ((dataItemCase_ == 5) && (byteItemBuilder_ != null)) {
        return byteItemBuilder_.getMessageOrBuilder();
      } else {
        if (dataItemCase_ == 5) {
          return (com.google.privacy.dlp.v2.ByteContentItem) dataItem_;
        }
        return com.google.privacy.dlp.v2.ByteContentItem.getDefaultInstance();
      }
    }
    /**
     * <pre>
     * Content data to inspect or redact. Replaces `type` and `data`.
     * </pre>
     *
     * <code>.google.privacy.dlp.v2.ByteContentItem byte_item = 5;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        com.google.privacy.dlp.v2.ByteContentItem, com.google.privacy.dlp.v2.ByteContentItem.Builder, com.google.privacy.dlp.v2.ByteContentItemOrBuilder> 
        getByteItemFieldBuilder() {
      if (byteItemBuilder_ == null) {
        if (!(dataItemCase_ == 5)) {
          dataItem_ = com.google.privacy.dlp.v2.ByteContentItem.getDefaultInstance();
        }
        byteItemBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            com.google.privacy.dlp.v2.ByteContentItem, com.google.privacy.dlp.v2.ByteContentItem.Builder, com.google.privacy.dlp.v2.ByteContentItemOrBuilder>(
                (com.google.privacy.dlp.v2.ByteContentItem) dataItem_,
                getParentForChildren(),
                isClean());
        dataItem_ = null;
      }
      dataItemCase_ = 5;
      onChanged();;
      return byteItemBuilder_;
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


    // @@protoc_insertion_point(builder_scope:google.privacy.dlp.v2.ContentItem)
  }

  // @@protoc_insertion_point(class_scope:google.privacy.dlp.v2.ContentItem)
  private static final com.google.privacy.dlp.v2.ContentItem DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.privacy.dlp.v2.ContentItem();
  }

  public static com.google.privacy.dlp.v2.ContentItem getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<ContentItem>
      PARSER = new com.google.protobuf.AbstractParser<ContentItem>() {
    @java.lang.Override
    public ContentItem parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new ContentItem(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<ContentItem> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<ContentItem> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.privacy.dlp.v2.ContentItem getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

