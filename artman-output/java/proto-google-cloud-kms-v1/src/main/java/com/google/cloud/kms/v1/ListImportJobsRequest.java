// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/kms/v1/service.proto

package com.google.cloud.kms.v1;

/**
 * <pre>
 * Request message for [KeyManagementService.ListImportJobs][google.cloud.kms.v1.KeyManagementService.ListImportJobs].
 * </pre>
 *
 * Protobuf type {@code google.cloud.kms.v1.ListImportJobsRequest}
 */
public  final class ListImportJobsRequest extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.kms.v1.ListImportJobsRequest)
    ListImportJobsRequestOrBuilder {
private static final long serialVersionUID = 0L;
  // Use ListImportJobsRequest.newBuilder() to construct.
  private ListImportJobsRequest(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private ListImportJobsRequest() {
    parent_ = "";
    pageToken_ = "";
    filter_ = "";
    orderBy_ = "";
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private ListImportJobsRequest(
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
            java.lang.String s = input.readStringRequireUtf8();

            parent_ = s;
            break;
          }
          case 16: {

            pageSize_ = input.readInt32();
            break;
          }
          case 26: {
            java.lang.String s = input.readStringRequireUtf8();

            pageToken_ = s;
            break;
          }
          case 34: {
            java.lang.String s = input.readStringRequireUtf8();

            filter_ = s;
            break;
          }
          case 42: {
            java.lang.String s = input.readStringRequireUtf8();

            orderBy_ = s;
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
    return com.google.cloud.kms.v1.KmsProto.internal_static_google_cloud_kms_v1_ListImportJobsRequest_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.kms.v1.KmsProto.internal_static_google_cloud_kms_v1_ListImportJobsRequest_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.kms.v1.ListImportJobsRequest.class, com.google.cloud.kms.v1.ListImportJobsRequest.Builder.class);
  }

  public static final int PARENT_FIELD_NUMBER = 1;
  private volatile java.lang.Object parent_;
  /**
   * <pre>
   * Required. The resource name of the [KeyRing][google.cloud.kms.v1.KeyRing] to list, in the format
   * `projects/&#42;&#47;locations/&#42;&#47;keyRings/&#42;`.
   * </pre>
   *
   * <code>string parent = 1;</code>
   */
  public java.lang.String getParent() {
    java.lang.Object ref = parent_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      parent_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Required. The resource name of the [KeyRing][google.cloud.kms.v1.KeyRing] to list, in the format
   * `projects/&#42;&#47;locations/&#42;&#47;keyRings/&#42;`.
   * </pre>
   *
   * <code>string parent = 1;</code>
   */
  public com.google.protobuf.ByteString
      getParentBytes() {
    java.lang.Object ref = parent_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      parent_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int PAGE_SIZE_FIELD_NUMBER = 2;
  private int pageSize_;
  /**
   * <pre>
   * Optional limit on the number of [ImportJobs][google.cloud.kms.v1.ImportJob] to include in the
   * response. Further [ImportJobs][google.cloud.kms.v1.ImportJob] can subsequently be obtained by
   * including the [ListImportJobsResponse.next_page_token][google.cloud.kms.v1.ListImportJobsResponse.next_page_token] in a subsequent
   * request. If unspecified, the server will pick an appropriate default.
   * </pre>
   *
   * <code>int32 page_size = 2;</code>
   */
  public int getPageSize() {
    return pageSize_;
  }

  public static final int PAGE_TOKEN_FIELD_NUMBER = 3;
  private volatile java.lang.Object pageToken_;
  /**
   * <pre>
   * Optional pagination token, returned earlier via
   * [ListImportJobsResponse.next_page_token][google.cloud.kms.v1.ListImportJobsResponse.next_page_token].
   * </pre>
   *
   * <code>string page_token = 3;</code>
   */
  public java.lang.String getPageToken() {
    java.lang.Object ref = pageToken_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      pageToken_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Optional pagination token, returned earlier via
   * [ListImportJobsResponse.next_page_token][google.cloud.kms.v1.ListImportJobsResponse.next_page_token].
   * </pre>
   *
   * <code>string page_token = 3;</code>
   */
  public com.google.protobuf.ByteString
      getPageTokenBytes() {
    java.lang.Object ref = pageToken_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      pageToken_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int FILTER_FIELD_NUMBER = 4;
  private volatile java.lang.Object filter_;
  /**
   * <pre>
   * Optional. Only include resources that match the filter in the response.
   * </pre>
   *
   * <code>string filter = 4;</code>
   */
  public java.lang.String getFilter() {
    java.lang.Object ref = filter_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      filter_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Optional. Only include resources that match the filter in the response.
   * </pre>
   *
   * <code>string filter = 4;</code>
   */
  public com.google.protobuf.ByteString
      getFilterBytes() {
    java.lang.Object ref = filter_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      filter_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int ORDER_BY_FIELD_NUMBER = 5;
  private volatile java.lang.Object orderBy_;
  /**
   * <pre>
   * Optional. Specify how the results should be sorted. If not specified, the
   * results will be sorted in the default order.
   * </pre>
   *
   * <code>string order_by = 5;</code>
   */
  public java.lang.String getOrderBy() {
    java.lang.Object ref = orderBy_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      orderBy_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Optional. Specify how the results should be sorted. If not specified, the
   * results will be sorted in the default order.
   * </pre>
   *
   * <code>string order_by = 5;</code>
   */
  public com.google.protobuf.ByteString
      getOrderByBytes() {
    java.lang.Object ref = orderBy_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      orderBy_ = b;
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
    if (!getParentBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, parent_);
    }
    if (pageSize_ != 0) {
      output.writeInt32(2, pageSize_);
    }
    if (!getPageTokenBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 3, pageToken_);
    }
    if (!getFilterBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 4, filter_);
    }
    if (!getOrderByBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 5, orderBy_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (!getParentBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(1, parent_);
    }
    if (pageSize_ != 0) {
      size += com.google.protobuf.CodedOutputStream
        .computeInt32Size(2, pageSize_);
    }
    if (!getPageTokenBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(3, pageToken_);
    }
    if (!getFilterBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(4, filter_);
    }
    if (!getOrderByBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(5, orderBy_);
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
    if (!(obj instanceof com.google.cloud.kms.v1.ListImportJobsRequest)) {
      return super.equals(obj);
    }
    com.google.cloud.kms.v1.ListImportJobsRequest other = (com.google.cloud.kms.v1.ListImportJobsRequest) obj;

    if (!getParent()
        .equals(other.getParent())) return false;
    if (getPageSize()
        != other.getPageSize()) return false;
    if (!getPageToken()
        .equals(other.getPageToken())) return false;
    if (!getFilter()
        .equals(other.getFilter())) return false;
    if (!getOrderBy()
        .equals(other.getOrderBy())) return false;
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
    hash = (37 * hash) + PARENT_FIELD_NUMBER;
    hash = (53 * hash) + getParent().hashCode();
    hash = (37 * hash) + PAGE_SIZE_FIELD_NUMBER;
    hash = (53 * hash) + getPageSize();
    hash = (37 * hash) + PAGE_TOKEN_FIELD_NUMBER;
    hash = (53 * hash) + getPageToken().hashCode();
    hash = (37 * hash) + FILTER_FIELD_NUMBER;
    hash = (53 * hash) + getFilter().hashCode();
    hash = (37 * hash) + ORDER_BY_FIELD_NUMBER;
    hash = (53 * hash) + getOrderBy().hashCode();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.kms.v1.ListImportJobsRequest parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.kms.v1.ListImportJobsRequest parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.kms.v1.ListImportJobsRequest parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.kms.v1.ListImportJobsRequest parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.kms.v1.ListImportJobsRequest parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.kms.v1.ListImportJobsRequest parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.kms.v1.ListImportJobsRequest parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.kms.v1.ListImportJobsRequest parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.kms.v1.ListImportJobsRequest parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.kms.v1.ListImportJobsRequest parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.kms.v1.ListImportJobsRequest parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.kms.v1.ListImportJobsRequest parseFrom(
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
  public static Builder newBuilder(com.google.cloud.kms.v1.ListImportJobsRequest prototype) {
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
   * Request message for [KeyManagementService.ListImportJobs][google.cloud.kms.v1.KeyManagementService.ListImportJobs].
   * </pre>
   *
   * Protobuf type {@code google.cloud.kms.v1.ListImportJobsRequest}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.kms.v1.ListImportJobsRequest)
      com.google.cloud.kms.v1.ListImportJobsRequestOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.kms.v1.KmsProto.internal_static_google_cloud_kms_v1_ListImportJobsRequest_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.kms.v1.KmsProto.internal_static_google_cloud_kms_v1_ListImportJobsRequest_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.kms.v1.ListImportJobsRequest.class, com.google.cloud.kms.v1.ListImportJobsRequest.Builder.class);
    }

    // Construct using com.google.cloud.kms.v1.ListImportJobsRequest.newBuilder()
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
      parent_ = "";

      pageSize_ = 0;

      pageToken_ = "";

      filter_ = "";

      orderBy_ = "";

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.kms.v1.KmsProto.internal_static_google_cloud_kms_v1_ListImportJobsRequest_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.kms.v1.ListImportJobsRequest getDefaultInstanceForType() {
      return com.google.cloud.kms.v1.ListImportJobsRequest.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.kms.v1.ListImportJobsRequest build() {
      com.google.cloud.kms.v1.ListImportJobsRequest result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.kms.v1.ListImportJobsRequest buildPartial() {
      com.google.cloud.kms.v1.ListImportJobsRequest result = new com.google.cloud.kms.v1.ListImportJobsRequest(this);
      result.parent_ = parent_;
      result.pageSize_ = pageSize_;
      result.pageToken_ = pageToken_;
      result.filter_ = filter_;
      result.orderBy_ = orderBy_;
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
      if (other instanceof com.google.cloud.kms.v1.ListImportJobsRequest) {
        return mergeFrom((com.google.cloud.kms.v1.ListImportJobsRequest)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.kms.v1.ListImportJobsRequest other) {
      if (other == com.google.cloud.kms.v1.ListImportJobsRequest.getDefaultInstance()) return this;
      if (!other.getParent().isEmpty()) {
        parent_ = other.parent_;
        onChanged();
      }
      if (other.getPageSize() != 0) {
        setPageSize(other.getPageSize());
      }
      if (!other.getPageToken().isEmpty()) {
        pageToken_ = other.pageToken_;
        onChanged();
      }
      if (!other.getFilter().isEmpty()) {
        filter_ = other.filter_;
        onChanged();
      }
      if (!other.getOrderBy().isEmpty()) {
        orderBy_ = other.orderBy_;
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
      com.google.cloud.kms.v1.ListImportJobsRequest parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.kms.v1.ListImportJobsRequest) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private java.lang.Object parent_ = "";
    /**
     * <pre>
     * Required. The resource name of the [KeyRing][google.cloud.kms.v1.KeyRing] to list, in the format
     * `projects/&#42;&#47;locations/&#42;&#47;keyRings/&#42;`.
     * </pre>
     *
     * <code>string parent = 1;</code>
     */
    public java.lang.String getParent() {
      java.lang.Object ref = parent_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        parent_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Required. The resource name of the [KeyRing][google.cloud.kms.v1.KeyRing] to list, in the format
     * `projects/&#42;&#47;locations/&#42;&#47;keyRings/&#42;`.
     * </pre>
     *
     * <code>string parent = 1;</code>
     */
    public com.google.protobuf.ByteString
        getParentBytes() {
      java.lang.Object ref = parent_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        parent_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Required. The resource name of the [KeyRing][google.cloud.kms.v1.KeyRing] to list, in the format
     * `projects/&#42;&#47;locations/&#42;&#47;keyRings/&#42;`.
     * </pre>
     *
     * <code>string parent = 1;</code>
     */
    public Builder setParent(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      parent_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. The resource name of the [KeyRing][google.cloud.kms.v1.KeyRing] to list, in the format
     * `projects/&#42;&#47;locations/&#42;&#47;keyRings/&#42;`.
     * </pre>
     *
     * <code>string parent = 1;</code>
     */
    public Builder clearParent() {
      
      parent_ = getDefaultInstance().getParent();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Required. The resource name of the [KeyRing][google.cloud.kms.v1.KeyRing] to list, in the format
     * `projects/&#42;&#47;locations/&#42;&#47;keyRings/&#42;`.
     * </pre>
     *
     * <code>string parent = 1;</code>
     */
    public Builder setParentBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      parent_ = value;
      onChanged();
      return this;
    }

    private int pageSize_ ;
    /**
     * <pre>
     * Optional limit on the number of [ImportJobs][google.cloud.kms.v1.ImportJob] to include in the
     * response. Further [ImportJobs][google.cloud.kms.v1.ImportJob] can subsequently be obtained by
     * including the [ListImportJobsResponse.next_page_token][google.cloud.kms.v1.ListImportJobsResponse.next_page_token] in a subsequent
     * request. If unspecified, the server will pick an appropriate default.
     * </pre>
     *
     * <code>int32 page_size = 2;</code>
     */
    public int getPageSize() {
      return pageSize_;
    }
    /**
     * <pre>
     * Optional limit on the number of [ImportJobs][google.cloud.kms.v1.ImportJob] to include in the
     * response. Further [ImportJobs][google.cloud.kms.v1.ImportJob] can subsequently be obtained by
     * including the [ListImportJobsResponse.next_page_token][google.cloud.kms.v1.ListImportJobsResponse.next_page_token] in a subsequent
     * request. If unspecified, the server will pick an appropriate default.
     * </pre>
     *
     * <code>int32 page_size = 2;</code>
     */
    public Builder setPageSize(int value) {
      
      pageSize_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Optional limit on the number of [ImportJobs][google.cloud.kms.v1.ImportJob] to include in the
     * response. Further [ImportJobs][google.cloud.kms.v1.ImportJob] can subsequently be obtained by
     * including the [ListImportJobsResponse.next_page_token][google.cloud.kms.v1.ListImportJobsResponse.next_page_token] in a subsequent
     * request. If unspecified, the server will pick an appropriate default.
     * </pre>
     *
     * <code>int32 page_size = 2;</code>
     */
    public Builder clearPageSize() {
      
      pageSize_ = 0;
      onChanged();
      return this;
    }

    private java.lang.Object pageToken_ = "";
    /**
     * <pre>
     * Optional pagination token, returned earlier via
     * [ListImportJobsResponse.next_page_token][google.cloud.kms.v1.ListImportJobsResponse.next_page_token].
     * </pre>
     *
     * <code>string page_token = 3;</code>
     */
    public java.lang.String getPageToken() {
      java.lang.Object ref = pageToken_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        pageToken_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Optional pagination token, returned earlier via
     * [ListImportJobsResponse.next_page_token][google.cloud.kms.v1.ListImportJobsResponse.next_page_token].
     * </pre>
     *
     * <code>string page_token = 3;</code>
     */
    public com.google.protobuf.ByteString
        getPageTokenBytes() {
      java.lang.Object ref = pageToken_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        pageToken_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Optional pagination token, returned earlier via
     * [ListImportJobsResponse.next_page_token][google.cloud.kms.v1.ListImportJobsResponse.next_page_token].
     * </pre>
     *
     * <code>string page_token = 3;</code>
     */
    public Builder setPageToken(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      pageToken_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Optional pagination token, returned earlier via
     * [ListImportJobsResponse.next_page_token][google.cloud.kms.v1.ListImportJobsResponse.next_page_token].
     * </pre>
     *
     * <code>string page_token = 3;</code>
     */
    public Builder clearPageToken() {
      
      pageToken_ = getDefaultInstance().getPageToken();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Optional pagination token, returned earlier via
     * [ListImportJobsResponse.next_page_token][google.cloud.kms.v1.ListImportJobsResponse.next_page_token].
     * </pre>
     *
     * <code>string page_token = 3;</code>
     */
    public Builder setPageTokenBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      pageToken_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object filter_ = "";
    /**
     * <pre>
     * Optional. Only include resources that match the filter in the response.
     * </pre>
     *
     * <code>string filter = 4;</code>
     */
    public java.lang.String getFilter() {
      java.lang.Object ref = filter_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        filter_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Optional. Only include resources that match the filter in the response.
     * </pre>
     *
     * <code>string filter = 4;</code>
     */
    public com.google.protobuf.ByteString
        getFilterBytes() {
      java.lang.Object ref = filter_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        filter_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Optional. Only include resources that match the filter in the response.
     * </pre>
     *
     * <code>string filter = 4;</code>
     */
    public Builder setFilter(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      filter_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Optional. Only include resources that match the filter in the response.
     * </pre>
     *
     * <code>string filter = 4;</code>
     */
    public Builder clearFilter() {
      
      filter_ = getDefaultInstance().getFilter();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Optional. Only include resources that match the filter in the response.
     * </pre>
     *
     * <code>string filter = 4;</code>
     */
    public Builder setFilterBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      filter_ = value;
      onChanged();
      return this;
    }

    private java.lang.Object orderBy_ = "";
    /**
     * <pre>
     * Optional. Specify how the results should be sorted. If not specified, the
     * results will be sorted in the default order.
     * </pre>
     *
     * <code>string order_by = 5;</code>
     */
    public java.lang.String getOrderBy() {
      java.lang.Object ref = orderBy_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        orderBy_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Optional. Specify how the results should be sorted. If not specified, the
     * results will be sorted in the default order.
     * </pre>
     *
     * <code>string order_by = 5;</code>
     */
    public com.google.protobuf.ByteString
        getOrderByBytes() {
      java.lang.Object ref = orderBy_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        orderBy_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Optional. Specify how the results should be sorted. If not specified, the
     * results will be sorted in the default order.
     * </pre>
     *
     * <code>string order_by = 5;</code>
     */
    public Builder setOrderBy(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      orderBy_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Optional. Specify how the results should be sorted. If not specified, the
     * results will be sorted in the default order.
     * </pre>
     *
     * <code>string order_by = 5;</code>
     */
    public Builder clearOrderBy() {
      
      orderBy_ = getDefaultInstance().getOrderBy();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Optional. Specify how the results should be sorted. If not specified, the
     * results will be sorted in the default order.
     * </pre>
     *
     * <code>string order_by = 5;</code>
     */
    public Builder setOrderByBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      orderBy_ = value;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.kms.v1.ListImportJobsRequest)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.kms.v1.ListImportJobsRequest)
  private static final com.google.cloud.kms.v1.ListImportJobsRequest DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.kms.v1.ListImportJobsRequest();
  }

  public static com.google.cloud.kms.v1.ListImportJobsRequest getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<ListImportJobsRequest>
      PARSER = new com.google.protobuf.AbstractParser<ListImportJobsRequest>() {
    @java.lang.Override
    public ListImportJobsRequest parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new ListImportJobsRequest(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<ListImportJobsRequest> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<ListImportJobsRequest> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.kms.v1.ListImportJobsRequest getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

