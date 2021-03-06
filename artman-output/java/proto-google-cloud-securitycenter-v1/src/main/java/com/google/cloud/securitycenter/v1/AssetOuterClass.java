// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/securitycenter/v1/asset.proto

package com.google.cloud.securitycenter.v1;

public final class AssetOuterClass {
  private AssetOuterClass() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_securitycenter_v1_Asset_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_securitycenter_v1_Asset_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_securitycenter_v1_Asset_SecurityCenterProperties_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_securitycenter_v1_Asset_SecurityCenterProperties_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_securitycenter_v1_Asset_IamPolicy_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_securitycenter_v1_Asset_IamPolicy_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_securitycenter_v1_Asset_ResourcePropertiesEntry_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_securitycenter_v1_Asset_ResourcePropertiesEntry_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n*google/cloud/securitycenter/v1/asset.p" +
      "roto\022\036google.cloud.securitycenter.v1\032\034go" +
      "ogle/api/annotations.proto\032\031google/api/r" +
      "esource.proto\0323google/cloud/securitycent" +
      "er/v1/security_marks.proto\032\034google/proto" +
      "buf/struct.proto\032\037google/protobuf/timest" +
      "amp.proto\"\222\007\n\005Asset\022\014\n\004name\030\001 \001(\t\022b\n\032sec" +
      "urity_center_properties\030\002 \001(\0132>.google.c" +
      "loud.securitycenter.v1.Asset.SecurityCen" +
      "terProperties\022Z\n\023resource_properties\030\007 \003" +
      "(\0132=.google.cloud.securitycenter.v1.Asse" +
      "t.ResourcePropertiesEntry\022E\n\016security_ma" +
      "rks\030\010 \001(\0132-.google.cloud.securitycenter." +
      "v1.SecurityMarks\022/\n\013create_time\030\t \001(\0132\032." +
      "google.protobuf.Timestamp\022/\n\013update_time" +
      "\030\n \001(\0132\032.google.protobuf.Timestamp\022C\n\nia" +
      "m_policy\030\013 \001(\0132/.google.cloud.securityce" +
      "nter.v1.Asset.IamPolicy\032\200\002\n\030SecurityCent" +
      "erProperties\022\025\n\rresource_name\030\001 \001(\t\022\025\n\rr" +
      "esource_type\030\002 \001(\t\022\027\n\017resource_parent\030\003 " +
      "\001(\t\022\030\n\020resource_project\030\004 \001(\t\022\027\n\017resourc" +
      "e_owners\030\005 \003(\t\022\035\n\025resource_display_name\030" +
      "\006 \001(\t\022$\n\034resource_parent_display_name\030\007 " +
      "\001(\t\022%\n\035resource_project_display_name\030\010 \001" +
      "(\t\032 \n\tIamPolicy\022\023\n\013policy_blob\030\001 \001(\t\032Q\n\027" +
      "ResourcePropertiesEntry\022\013\n\003key\030\001 \001(\t\022%\n\005" +
      "value\030\002 \001(\0132\026.google.protobuf.Value:\0028\001:" +
      "U\352AR\n#securitycenter.googleapis.com/Asse" +
      "t\022+organizations/{organization}/assets/{" +
      "asset}B\332\001\n\"com.google.cloud.securitycent" +
      "er.v1P\001ZLgoogle.golang.org/genproto/goog" +
      "leapis/cloud/securitycenter/v1;securityc" +
      "enter\252\002\036Google.Cloud.SecurityCenter.V1\312\002" +
      "\036Google\\Cloud\\SecurityCenter\\V1\352\002!Google" +
      "::Cloud::SecurityCenter::V1b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.AnnotationsProto.getDescriptor(),
          com.google.api.ResourceProto.getDescriptor(),
          com.google.cloud.securitycenter.v1.SecurityMarksOuterClass.getDescriptor(),
          com.google.protobuf.StructProto.getDescriptor(),
          com.google.protobuf.TimestampProto.getDescriptor(),
        });
    internal_static_google_cloud_securitycenter_v1_Asset_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_securitycenter_v1_Asset_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_securitycenter_v1_Asset_descriptor,
        new java.lang.String[] { "Name", "SecurityCenterProperties", "ResourceProperties", "SecurityMarks", "CreateTime", "UpdateTime", "IamPolicy", });
    internal_static_google_cloud_securitycenter_v1_Asset_SecurityCenterProperties_descriptor =
      internal_static_google_cloud_securitycenter_v1_Asset_descriptor.getNestedTypes().get(0);
    internal_static_google_cloud_securitycenter_v1_Asset_SecurityCenterProperties_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_securitycenter_v1_Asset_SecurityCenterProperties_descriptor,
        new java.lang.String[] { "ResourceName", "ResourceType", "ResourceParent", "ResourceProject", "ResourceOwners", "ResourceDisplayName", "ResourceParentDisplayName", "ResourceProjectDisplayName", });
    internal_static_google_cloud_securitycenter_v1_Asset_IamPolicy_descriptor =
      internal_static_google_cloud_securitycenter_v1_Asset_descriptor.getNestedTypes().get(1);
    internal_static_google_cloud_securitycenter_v1_Asset_IamPolicy_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_securitycenter_v1_Asset_IamPolicy_descriptor,
        new java.lang.String[] { "PolicyBlob", });
    internal_static_google_cloud_securitycenter_v1_Asset_ResourcePropertiesEntry_descriptor =
      internal_static_google_cloud_securitycenter_v1_Asset_descriptor.getNestedTypes().get(2);
    internal_static_google_cloud_securitycenter_v1_Asset_ResourcePropertiesEntry_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_securitycenter_v1_Asset_ResourcePropertiesEntry_descriptor,
        new java.lang.String[] { "Key", "Value", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.ResourceProto.resource);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.api.AnnotationsProto.getDescriptor();
    com.google.api.ResourceProto.getDescriptor();
    com.google.cloud.securitycenter.v1.SecurityMarksOuterClass.getDescriptor();
    com.google.protobuf.StructProto.getDescriptor();
    com.google.protobuf.TimestampProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
