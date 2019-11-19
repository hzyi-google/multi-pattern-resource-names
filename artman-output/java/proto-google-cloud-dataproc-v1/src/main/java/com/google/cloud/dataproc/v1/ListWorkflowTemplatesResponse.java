// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dataproc/v1/workflow_templates.proto

package com.google.cloud.dataproc.v1;

/**
 * <pre>
 * A response to a request to list workflow templates in a project.
 * </pre>
 *
 * Protobuf type {@code google.cloud.dataproc.v1.ListWorkflowTemplatesResponse}
 */
public  final class ListWorkflowTemplatesResponse extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.dataproc.v1.ListWorkflowTemplatesResponse)
    ListWorkflowTemplatesResponseOrBuilder {
private static final long serialVersionUID = 0L;
  // Use ListWorkflowTemplatesResponse.newBuilder() to construct.
  private ListWorkflowTemplatesResponse(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private ListWorkflowTemplatesResponse() {
    templates_ = java.util.Collections.emptyList();
    nextPageToken_ = "";
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private ListWorkflowTemplatesResponse(
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
              templates_ = new java.util.ArrayList<com.google.cloud.dataproc.v1.WorkflowTemplate>();
              mutable_bitField0_ |= 0x00000001;
            }
            templates_.add(
                input.readMessage(com.google.cloud.dataproc.v1.WorkflowTemplate.parser(), extensionRegistry));
            break;
          }
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();

            nextPageToken_ = s;
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
      if (((mutable_bitField0_ & 0x00000001) != 0)) {
        templates_ = java.util.Collections.unmodifiableList(templates_);
      }
      this.unknownFields = unknownFields.build();
      makeExtensionsImmutable();
    }
  }
  public static final com.google.protobuf.Descriptors.Descriptor
      getDescriptor() {
    return com.google.cloud.dataproc.v1.WorkflowTemplatesProto.internal_static_google_cloud_dataproc_v1_ListWorkflowTemplatesResponse_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.dataproc.v1.WorkflowTemplatesProto.internal_static_google_cloud_dataproc_v1_ListWorkflowTemplatesResponse_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse.class, com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse.Builder.class);
  }

  private int bitField0_;
  public static final int TEMPLATES_FIELD_NUMBER = 1;
  private java.util.List<com.google.cloud.dataproc.v1.WorkflowTemplate> templates_;
  /**
   * <pre>
   * Output only. WorkflowTemplates list.
   * </pre>
   *
   * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  public java.util.List<com.google.cloud.dataproc.v1.WorkflowTemplate> getTemplatesList() {
    return templates_;
  }
  /**
   * <pre>
   * Output only. WorkflowTemplates list.
   * </pre>
   *
   * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  public java.util.List<? extends com.google.cloud.dataproc.v1.WorkflowTemplateOrBuilder> 
      getTemplatesOrBuilderList() {
    return templates_;
  }
  /**
   * <pre>
   * Output only. WorkflowTemplates list.
   * </pre>
   *
   * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  public int getTemplatesCount() {
    return templates_.size();
  }
  /**
   * <pre>
   * Output only. WorkflowTemplates list.
   * </pre>
   *
   * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  public com.google.cloud.dataproc.v1.WorkflowTemplate getTemplates(int index) {
    return templates_.get(index);
  }
  /**
   * <pre>
   * Output only. WorkflowTemplates list.
   * </pre>
   *
   * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  public com.google.cloud.dataproc.v1.WorkflowTemplateOrBuilder getTemplatesOrBuilder(
      int index) {
    return templates_.get(index);
  }

  public static final int NEXT_PAGE_TOKEN_FIELD_NUMBER = 2;
  private volatile java.lang.Object nextPageToken_;
  /**
   * <pre>
   * Output only. This token is included in the response if there are more
   * results to fetch. To fetch additional results, provide this value as the
   * page_token in a subsequent &lt;code&gt;ListWorkflowTemplatesRequest&lt;/code&gt;.
   * </pre>
   *
   * <code>string next_page_token = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  public java.lang.String getNextPageToken() {
    java.lang.Object ref = nextPageToken_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      nextPageToken_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Output only. This token is included in the response if there are more
   * results to fetch. To fetch additional results, provide this value as the
   * page_token in a subsequent &lt;code&gt;ListWorkflowTemplatesRequest&lt;/code&gt;.
   * </pre>
   *
   * <code>string next_page_token = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  public com.google.protobuf.ByteString
      getNextPageTokenBytes() {
    java.lang.Object ref = nextPageToken_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      nextPageToken_ = b;
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
    for (int i = 0; i < templates_.size(); i++) {
      output.writeMessage(1, templates_.get(i));
    }
    if (!getNextPageTokenBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, nextPageToken_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    for (int i = 0; i < templates_.size(); i++) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(1, templates_.get(i));
    }
    if (!getNextPageTokenBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, nextPageToken_);
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
    if (!(obj instanceof com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse)) {
      return super.equals(obj);
    }
    com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse other = (com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse) obj;

    if (!getTemplatesList()
        .equals(other.getTemplatesList())) return false;
    if (!getNextPageToken()
        .equals(other.getNextPageToken())) return false;
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
    if (getTemplatesCount() > 0) {
      hash = (37 * hash) + TEMPLATES_FIELD_NUMBER;
      hash = (53 * hash) + getTemplatesList().hashCode();
    }
    hash = (37 * hash) + NEXT_PAGE_TOKEN_FIELD_NUMBER;
    hash = (53 * hash) + getNextPageToken().hashCode();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse parseFrom(
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
  public static Builder newBuilder(com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse prototype) {
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
   * A response to a request to list workflow templates in a project.
   * </pre>
   *
   * Protobuf type {@code google.cloud.dataproc.v1.ListWorkflowTemplatesResponse}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.dataproc.v1.ListWorkflowTemplatesResponse)
      com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponseOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.dataproc.v1.WorkflowTemplatesProto.internal_static_google_cloud_dataproc_v1_ListWorkflowTemplatesResponse_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.dataproc.v1.WorkflowTemplatesProto.internal_static_google_cloud_dataproc_v1_ListWorkflowTemplatesResponse_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse.class, com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse.Builder.class);
    }

    // Construct using com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse.newBuilder()
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
        getTemplatesFieldBuilder();
      }
    }
    @java.lang.Override
    public Builder clear() {
      super.clear();
      if (templatesBuilder_ == null) {
        templates_ = java.util.Collections.emptyList();
        bitField0_ = (bitField0_ & ~0x00000001);
      } else {
        templatesBuilder_.clear();
      }
      nextPageToken_ = "";

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.dataproc.v1.WorkflowTemplatesProto.internal_static_google_cloud_dataproc_v1_ListWorkflowTemplatesResponse_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse getDefaultInstanceForType() {
      return com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse build() {
      com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse buildPartial() {
      com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse result = new com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse(this);
      int from_bitField0_ = bitField0_;
      int to_bitField0_ = 0;
      if (templatesBuilder_ == null) {
        if (((bitField0_ & 0x00000001) != 0)) {
          templates_ = java.util.Collections.unmodifiableList(templates_);
          bitField0_ = (bitField0_ & ~0x00000001);
        }
        result.templates_ = templates_;
      } else {
        result.templates_ = templatesBuilder_.build();
      }
      result.nextPageToken_ = nextPageToken_;
      result.bitField0_ = to_bitField0_;
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
      if (other instanceof com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse) {
        return mergeFrom((com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse other) {
      if (other == com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse.getDefaultInstance()) return this;
      if (templatesBuilder_ == null) {
        if (!other.templates_.isEmpty()) {
          if (templates_.isEmpty()) {
            templates_ = other.templates_;
            bitField0_ = (bitField0_ & ~0x00000001);
          } else {
            ensureTemplatesIsMutable();
            templates_.addAll(other.templates_);
          }
          onChanged();
        }
      } else {
        if (!other.templates_.isEmpty()) {
          if (templatesBuilder_.isEmpty()) {
            templatesBuilder_.dispose();
            templatesBuilder_ = null;
            templates_ = other.templates_;
            bitField0_ = (bitField0_ & ~0x00000001);
            templatesBuilder_ = 
              com.google.protobuf.GeneratedMessageV3.alwaysUseFieldBuilders ?
                 getTemplatesFieldBuilder() : null;
          } else {
            templatesBuilder_.addAllMessages(other.templates_);
          }
        }
      }
      if (!other.getNextPageToken().isEmpty()) {
        nextPageToken_ = other.nextPageToken_;
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
      com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }
    private int bitField0_;

    private java.util.List<com.google.cloud.dataproc.v1.WorkflowTemplate> templates_ =
      java.util.Collections.emptyList();
    private void ensureTemplatesIsMutable() {
      if (!((bitField0_ & 0x00000001) != 0)) {
        templates_ = new java.util.ArrayList<com.google.cloud.dataproc.v1.WorkflowTemplate>(templates_);
        bitField0_ |= 0x00000001;
       }
    }

    private com.google.protobuf.RepeatedFieldBuilderV3<
        com.google.cloud.dataproc.v1.WorkflowTemplate, com.google.cloud.dataproc.v1.WorkflowTemplate.Builder, com.google.cloud.dataproc.v1.WorkflowTemplateOrBuilder> templatesBuilder_;

    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public java.util.List<com.google.cloud.dataproc.v1.WorkflowTemplate> getTemplatesList() {
      if (templatesBuilder_ == null) {
        return java.util.Collections.unmodifiableList(templates_);
      } else {
        return templatesBuilder_.getMessageList();
      }
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public int getTemplatesCount() {
      if (templatesBuilder_ == null) {
        return templates_.size();
      } else {
        return templatesBuilder_.getCount();
      }
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public com.google.cloud.dataproc.v1.WorkflowTemplate getTemplates(int index) {
      if (templatesBuilder_ == null) {
        return templates_.get(index);
      } else {
        return templatesBuilder_.getMessage(index);
      }
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder setTemplates(
        int index, com.google.cloud.dataproc.v1.WorkflowTemplate value) {
      if (templatesBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureTemplatesIsMutable();
        templates_.set(index, value);
        onChanged();
      } else {
        templatesBuilder_.setMessage(index, value);
      }
      return this;
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder setTemplates(
        int index, com.google.cloud.dataproc.v1.WorkflowTemplate.Builder builderForValue) {
      if (templatesBuilder_ == null) {
        ensureTemplatesIsMutable();
        templates_.set(index, builderForValue.build());
        onChanged();
      } else {
        templatesBuilder_.setMessage(index, builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder addTemplates(com.google.cloud.dataproc.v1.WorkflowTemplate value) {
      if (templatesBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureTemplatesIsMutable();
        templates_.add(value);
        onChanged();
      } else {
        templatesBuilder_.addMessage(value);
      }
      return this;
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder addTemplates(
        int index, com.google.cloud.dataproc.v1.WorkflowTemplate value) {
      if (templatesBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        ensureTemplatesIsMutable();
        templates_.add(index, value);
        onChanged();
      } else {
        templatesBuilder_.addMessage(index, value);
      }
      return this;
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder addTemplates(
        com.google.cloud.dataproc.v1.WorkflowTemplate.Builder builderForValue) {
      if (templatesBuilder_ == null) {
        ensureTemplatesIsMutable();
        templates_.add(builderForValue.build());
        onChanged();
      } else {
        templatesBuilder_.addMessage(builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder addTemplates(
        int index, com.google.cloud.dataproc.v1.WorkflowTemplate.Builder builderForValue) {
      if (templatesBuilder_ == null) {
        ensureTemplatesIsMutable();
        templates_.add(index, builderForValue.build());
        onChanged();
      } else {
        templatesBuilder_.addMessage(index, builderForValue.build());
      }
      return this;
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder addAllTemplates(
        java.lang.Iterable<? extends com.google.cloud.dataproc.v1.WorkflowTemplate> values) {
      if (templatesBuilder_ == null) {
        ensureTemplatesIsMutable();
        com.google.protobuf.AbstractMessageLite.Builder.addAll(
            values, templates_);
        onChanged();
      } else {
        templatesBuilder_.addAllMessages(values);
      }
      return this;
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder clearTemplates() {
      if (templatesBuilder_ == null) {
        templates_ = java.util.Collections.emptyList();
        bitField0_ = (bitField0_ & ~0x00000001);
        onChanged();
      } else {
        templatesBuilder_.clear();
      }
      return this;
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder removeTemplates(int index) {
      if (templatesBuilder_ == null) {
        ensureTemplatesIsMutable();
        templates_.remove(index);
        onChanged();
      } else {
        templatesBuilder_.remove(index);
      }
      return this;
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public com.google.cloud.dataproc.v1.WorkflowTemplate.Builder getTemplatesBuilder(
        int index) {
      return getTemplatesFieldBuilder().getBuilder(index);
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public com.google.cloud.dataproc.v1.WorkflowTemplateOrBuilder getTemplatesOrBuilder(
        int index) {
      if (templatesBuilder_ == null) {
        return templates_.get(index);  } else {
        return templatesBuilder_.getMessageOrBuilder(index);
      }
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public java.util.List<? extends com.google.cloud.dataproc.v1.WorkflowTemplateOrBuilder> 
         getTemplatesOrBuilderList() {
      if (templatesBuilder_ != null) {
        return templatesBuilder_.getMessageOrBuilderList();
      } else {
        return java.util.Collections.unmodifiableList(templates_);
      }
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public com.google.cloud.dataproc.v1.WorkflowTemplate.Builder addTemplatesBuilder() {
      return getTemplatesFieldBuilder().addBuilder(
          com.google.cloud.dataproc.v1.WorkflowTemplate.getDefaultInstance());
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public com.google.cloud.dataproc.v1.WorkflowTemplate.Builder addTemplatesBuilder(
        int index) {
      return getTemplatesFieldBuilder().addBuilder(
          index, com.google.cloud.dataproc.v1.WorkflowTemplate.getDefaultInstance());
    }
    /**
     * <pre>
     * Output only. WorkflowTemplates list.
     * </pre>
     *
     * <code>repeated .google.cloud.dataproc.v1.WorkflowTemplate templates = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public java.util.List<com.google.cloud.dataproc.v1.WorkflowTemplate.Builder> 
         getTemplatesBuilderList() {
      return getTemplatesFieldBuilder().getBuilderList();
    }
    private com.google.protobuf.RepeatedFieldBuilderV3<
        com.google.cloud.dataproc.v1.WorkflowTemplate, com.google.cloud.dataproc.v1.WorkflowTemplate.Builder, com.google.cloud.dataproc.v1.WorkflowTemplateOrBuilder> 
        getTemplatesFieldBuilder() {
      if (templatesBuilder_ == null) {
        templatesBuilder_ = new com.google.protobuf.RepeatedFieldBuilderV3<
            com.google.cloud.dataproc.v1.WorkflowTemplate, com.google.cloud.dataproc.v1.WorkflowTemplate.Builder, com.google.cloud.dataproc.v1.WorkflowTemplateOrBuilder>(
                templates_,
                ((bitField0_ & 0x00000001) != 0),
                getParentForChildren(),
                isClean());
        templates_ = null;
      }
      return templatesBuilder_;
    }

    private java.lang.Object nextPageToken_ = "";
    /**
     * <pre>
     * Output only. This token is included in the response if there are more
     * results to fetch. To fetch additional results, provide this value as the
     * page_token in a subsequent &lt;code&gt;ListWorkflowTemplatesRequest&lt;/code&gt;.
     * </pre>
     *
     * <code>string next_page_token = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public java.lang.String getNextPageToken() {
      java.lang.Object ref = nextPageToken_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        nextPageToken_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Output only. This token is included in the response if there are more
     * results to fetch. To fetch additional results, provide this value as the
     * page_token in a subsequent &lt;code&gt;ListWorkflowTemplatesRequest&lt;/code&gt;.
     * </pre>
     *
     * <code>string next_page_token = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public com.google.protobuf.ByteString
        getNextPageTokenBytes() {
      java.lang.Object ref = nextPageToken_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        nextPageToken_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Output only. This token is included in the response if there are more
     * results to fetch. To fetch additional results, provide this value as the
     * page_token in a subsequent &lt;code&gt;ListWorkflowTemplatesRequest&lt;/code&gt;.
     * </pre>
     *
     * <code>string next_page_token = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder setNextPageToken(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      nextPageToken_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Output only. This token is included in the response if there are more
     * results to fetch. To fetch additional results, provide this value as the
     * page_token in a subsequent &lt;code&gt;ListWorkflowTemplatesRequest&lt;/code&gt;.
     * </pre>
     *
     * <code>string next_page_token = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder clearNextPageToken() {
      
      nextPageToken_ = getDefaultInstance().getNextPageToken();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Output only. This token is included in the response if there are more
     * results to fetch. To fetch additional results, provide this value as the
     * page_token in a subsequent &lt;code&gt;ListWorkflowTemplatesRequest&lt;/code&gt;.
     * </pre>
     *
     * <code>string next_page_token = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder setNextPageTokenBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      nextPageToken_ = value;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.dataproc.v1.ListWorkflowTemplatesResponse)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.dataproc.v1.ListWorkflowTemplatesResponse)
  private static final com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse();
  }

  public static com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<ListWorkflowTemplatesResponse>
      PARSER = new com.google.protobuf.AbstractParser<ListWorkflowTemplatesResponse>() {
    @java.lang.Override
    public ListWorkflowTemplatesResponse parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new ListWorkflowTemplatesResponse(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<ListWorkflowTemplatesResponse> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<ListWorkflowTemplatesResponse> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.dataproc.v1.ListWorkflowTemplatesResponse getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

