// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dataproc/v1beta2/clusters.proto

package com.google.cloud.dataproc.v1beta2;

/**
 * <pre>
 * The location of diagnostic output.
 * </pre>
 *
 * Protobuf type {@code google.cloud.dataproc.v1beta2.DiagnoseClusterResults}
 */
public  final class DiagnoseClusterResults extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:google.cloud.dataproc.v1beta2.DiagnoseClusterResults)
    DiagnoseClusterResultsOrBuilder {
private static final long serialVersionUID = 0L;
  // Use DiagnoseClusterResults.newBuilder() to construct.
  private DiagnoseClusterResults(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private DiagnoseClusterResults() {
    outputUri_ = "";
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private DiagnoseClusterResults(
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

            outputUri_ = s;
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
    return com.google.cloud.dataproc.v1beta2.ClustersProto.internal_static_google_cloud_dataproc_v1beta2_DiagnoseClusterResults_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return com.google.cloud.dataproc.v1beta2.ClustersProto.internal_static_google_cloud_dataproc_v1beta2_DiagnoseClusterResults_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults.class, com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults.Builder.class);
  }

  public static final int OUTPUT_URI_FIELD_NUMBER = 1;
  private volatile java.lang.Object outputUri_;
  /**
   * <pre>
   * Output only. The Cloud Storage URI of the diagnostic output.
   * The output report is a plain text file with a summary of collected
   * diagnostics.
   * </pre>
   *
   * <code>string output_uri = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  public java.lang.String getOutputUri() {
    java.lang.Object ref = outputUri_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      outputUri_ = s;
      return s;
    }
  }
  /**
   * <pre>
   * Output only. The Cloud Storage URI of the diagnostic output.
   * The output report is a plain text file with a summary of collected
   * diagnostics.
   * </pre>
   *
   * <code>string output_uri = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  public com.google.protobuf.ByteString
      getOutputUriBytes() {
    java.lang.Object ref = outputUri_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      outputUri_ = b;
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
    if (!getOutputUriBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 1, outputUri_);
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (!getOutputUriBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(1, outputUri_);
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
    if (!(obj instanceof com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults)) {
      return super.equals(obj);
    }
    com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults other = (com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults) obj;

    if (!getOutputUri()
        .equals(other.getOutputUri())) return false;
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
    hash = (37 * hash) + OUTPUT_URI_FIELD_NUMBER;
    hash = (53 * hash) + getOutputUri().hashCode();
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults parseFrom(
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
  public static Builder newBuilder(com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults prototype) {
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
   * The location of diagnostic output.
   * </pre>
   *
   * Protobuf type {@code google.cloud.dataproc.v1beta2.DiagnoseClusterResults}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:google.cloud.dataproc.v1beta2.DiagnoseClusterResults)
      com.google.cloud.dataproc.v1beta2.DiagnoseClusterResultsOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.google.cloud.dataproc.v1beta2.ClustersProto.internal_static_google_cloud_dataproc_v1beta2_DiagnoseClusterResults_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.google.cloud.dataproc.v1beta2.ClustersProto.internal_static_google_cloud_dataproc_v1beta2_DiagnoseClusterResults_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults.class, com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults.Builder.class);
    }

    // Construct using com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults.newBuilder()
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
      outputUri_ = "";

      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return com.google.cloud.dataproc.v1beta2.ClustersProto.internal_static_google_cloud_dataproc_v1beta2_DiagnoseClusterResults_descriptor;
    }

    @java.lang.Override
    public com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults getDefaultInstanceForType() {
      return com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults.getDefaultInstance();
    }

    @java.lang.Override
    public com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults build() {
      com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults buildPartial() {
      com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults result = new com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults(this);
      result.outputUri_ = outputUri_;
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
      if (other instanceof com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults) {
        return mergeFrom((com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults other) {
      if (other == com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults.getDefaultInstance()) return this;
      if (!other.getOutputUri().isEmpty()) {
        outputUri_ = other.outputUri_;
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
      com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private java.lang.Object outputUri_ = "";
    /**
     * <pre>
     * Output only. The Cloud Storage URI of the diagnostic output.
     * The output report is a plain text file with a summary of collected
     * diagnostics.
     * </pre>
     *
     * <code>string output_uri = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public java.lang.String getOutputUri() {
      java.lang.Object ref = outputUri_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        outputUri_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <pre>
     * Output only. The Cloud Storage URI of the diagnostic output.
     * The output report is a plain text file with a summary of collected
     * diagnostics.
     * </pre>
     *
     * <code>string output_uri = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public com.google.protobuf.ByteString
        getOutputUriBytes() {
      java.lang.Object ref = outputUri_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        outputUri_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <pre>
     * Output only. The Cloud Storage URI of the diagnostic output.
     * The output report is a plain text file with a summary of collected
     * diagnostics.
     * </pre>
     *
     * <code>string output_uri = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder setOutputUri(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      outputUri_ = value;
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Output only. The Cloud Storage URI of the diagnostic output.
     * The output report is a plain text file with a summary of collected
     * diagnostics.
     * </pre>
     *
     * <code>string output_uri = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder clearOutputUri() {
      
      outputUri_ = getDefaultInstance().getOutputUri();
      onChanged();
      return this;
    }
    /**
     * <pre>
     * Output only. The Cloud Storage URI of the diagnostic output.
     * The output report is a plain text file with a summary of collected
     * diagnostics.
     * </pre>
     *
     * <code>string output_uri = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     */
    public Builder setOutputUriBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      outputUri_ = value;
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


    // @@protoc_insertion_point(builder_scope:google.cloud.dataproc.v1beta2.DiagnoseClusterResults)
  }

  // @@protoc_insertion_point(class_scope:google.cloud.dataproc.v1beta2.DiagnoseClusterResults)
  private static final com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults();
  }

  public static com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<DiagnoseClusterResults>
      PARSER = new com.google.protobuf.AbstractParser<DiagnoseClusterResults>() {
    @java.lang.Override
    public DiagnoseClusterResults parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new DiagnoseClusterResults(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<DiagnoseClusterResults> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<DiagnoseClusterResults> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.cloud.dataproc.v1beta2.DiagnoseClusterResults getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

