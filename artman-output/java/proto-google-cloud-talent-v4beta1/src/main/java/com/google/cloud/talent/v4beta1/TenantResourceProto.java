// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4beta1/tenant.proto

package com.google.cloud.talent.v4beta1;

public final class TenantResourceProto {
  private TenantResourceProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_Tenant_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_Tenant_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n(google/cloud/talent/v4beta1/tenant.pro" +
      "to\022\033google.cloud.talent.v4beta1\032\034google/" +
      "api/annotations.proto\032\037google/api/field_" +
      "behavior.proto\032\037google/protobuf/timestam" +
      "p.proto\"\375\001\n\006Tenant\022\014\n\004name\030\001 \001(\t\022\030\n\013exte" +
      "rnal_id\030\002 \001(\tB\003\340A\002\022E\n\nusage_type\030\003 \001(\01621" +
      ".google.cloud.talent.v4beta1.Tenant.Data" +
      "UsageType\0224\n,keyword_searchable_profile_" +
      "custom_attributes\030\004 \003(\t\"N\n\rDataUsageType" +
      "\022\037\n\033DATA_USAGE_TYPE_UNSPECIFIED\020\000\022\016\n\nAGG" +
      "REGATED\020\001\022\014\n\010ISOLATED\020\002B\201\001\n\037com.google.c" +
      "loud.talent.v4beta1B\023TenantResourceProto" +
      "P\001ZAgoogle.golang.org/genproto/googleapi" +
      "s/cloud/talent/v4beta1;talent\242\002\003CTSb\006pro" +
      "to3"
    };
    com.google.protobuf.Descriptors.FileDescriptor.InternalDescriptorAssigner assigner =
        new com.google.protobuf.Descriptors.FileDescriptor.    InternalDescriptorAssigner() {
          public com.google.protobuf.ExtensionRegistry assignDescriptors(
              com.google.protobuf.Descriptors.FileDescriptor root) {
            descriptor = root;
            return null;
          }
        };
    com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.AnnotationsProto.getDescriptor(),
          com.google.api.FieldBehaviorProto.getDescriptor(),
          com.google.protobuf.TimestampProto.getDescriptor(),
        }, assigner);
    internal_static_google_cloud_talent_v4beta1_Tenant_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_talent_v4beta1_Tenant_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_Tenant_descriptor,
        new java.lang.String[] { "Name", "ExternalId", "UsageType", "KeywordSearchableProfileCustomAttributes", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.FieldBehaviorProto.fieldBehavior);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.api.AnnotationsProto.getDescriptor();
    com.google.api.FieldBehaviorProto.getDescriptor();
    com.google.protobuf.TimestampProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
