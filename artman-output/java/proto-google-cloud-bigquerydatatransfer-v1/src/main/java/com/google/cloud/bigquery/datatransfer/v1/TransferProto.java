// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/bigquery/datatransfer/v1/transfer.proto

package com.google.cloud.bigquery.datatransfer.v1;

public final class TransferProto {
  private TransferProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_bigquery_datatransfer_v1_ScheduleOptions_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_bigquery_datatransfer_v1_ScheduleOptions_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferConfig_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_bigquery_datatransfer_v1_TransferConfig_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferRun_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_bigquery_datatransfer_v1_TransferRun_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferMessage_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_bigquery_datatransfer_v1_TransferMessage_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n4google/cloud/bigquery/datatransfer/v1/" +
      "transfer.proto\022%google.cloud.bigquery.da" +
      "tatransfer.v1\032\037google/api/field_behavior" +
      ".proto\032\031google/api/resource.proto\032\034googl" +
      "e/protobuf/struct.proto\032\037google/protobuf" +
      "/timestamp.proto\032\027google/rpc/status.prot" +
      "o\"\220\001\n\017ScheduleOptions\022\037\n\027disable_auto_sc" +
      "heduling\030\003 \001(\010\022.\n\nstart_time\030\001 \001(\0132\032.goo" +
      "gle.protobuf.Timestamp\022,\n\010end_time\030\002 \001(\013" +
      "2\032.google.protobuf.Timestamp\"\223\005\n\016Transfe" +
      "rConfig\022\014\n\004name\030\001 \001(\t\022 \n\026destination_dat" +
      "aset_id\030\002 \001(\tH\000\022\024\n\014display_name\030\003 \001(\t\022\026\n" +
      "\016data_source_id\030\005 \001(\t\022\'\n\006params\030\t \001(\0132\027." +
      "google.protobuf.Struct\022\020\n\010schedule\030\007 \001(\t" +
      "\022P\n\020schedule_options\030\030 \001(\01326.google.clou" +
      "d.bigquery.datatransfer.v1.ScheduleOptio" +
      "ns\022 \n\030data_refresh_window_days\030\014 \001(\005\022\020\n\010" +
      "disabled\030\r \001(\010\0224\n\013update_time\030\004 \001(\0132\032.go" +
      "ogle.protobuf.TimestampB\003\340A\003\0226\n\rnext_run" +
      "_time\030\010 \001(\0132\032.google.protobuf.TimestampB" +
      "\003\340A\003\022H\n\005state\030\n \001(\01624.google.cloud.bigqu" +
      "ery.datatransfer.v1.TransferStateB\003\340A\003\022\017" +
      "\n\007user_id\030\013 \001(\003\022\033\n\016dataset_region\030\016 \001(\tB" +
      "\003\340A\003:m\352Aj\n2bigquerydatatransfer.googleap" +
      "is.com/TransferConfig\0224projects/{project" +
      "}/transferConfigs/{transfer_config}B\r\n\013d" +
      "estination\"\300\005\n\013TransferRun\022\014\n\004name\030\001 \001(\t" +
      "\0221\n\rschedule_time\030\003 \001(\0132\032.google.protobu" +
      "f.Timestamp\022,\n\010run_time\030\n \001(\0132\032.google.p" +
      "rotobuf.Timestamp\022(\n\014error_status\030\025 \001(\0132" +
      "\022.google.rpc.Status\0223\n\nstart_time\030\004 \001(\0132" +
      "\032.google.protobuf.TimestampB\003\340A\003\0221\n\010end_" +
      "time\030\005 \001(\0132\032.google.protobuf.TimestampB\003" +
      "\340A\003\0224\n\013update_time\030\006 \001(\0132\032.google.protob" +
      "uf.TimestampB\003\340A\003\022,\n\006params\030\t \001(\0132\027.goog" +
      "le.protobuf.StructB\003\340A\003\022%\n\026destination_d" +
      "ataset_id\030\002 \001(\tB\003\340A\003H\000\022\033\n\016data_source_id" +
      "\030\007 \001(\tB\003\340A\003\022C\n\005state\030\010 \001(\01624.google.clou" +
      "d.bigquery.datatransfer.v1.TransferState" +
      "\022\017\n\007user_id\030\013 \001(\003\022\025\n\010schedule\030\014 \001(\tB\003\340A\003" +
      ":\213\001\352A\207\001\n/bigquerydatatransfer.googleapis" +
      ".com/TransferRun\022Tprojects/{project}/loc" +
      "ations/{location}/transferConfigs/{trans" +
      "fer_config}/runs/{run}B\r\n\013destination\"\212\002" +
      "\n\017TransferMessage\0220\n\014message_time\030\001 \001(\0132" +
      "\032.google.protobuf.Timestamp\022X\n\010severity\030" +
      "\002 \001(\0162F.google.cloud.bigquery.datatransf" +
      "er.v1.TransferMessage.MessageSeverity\022\024\n" +
      "\014message_text\030\003 \001(\t\"U\n\017MessageSeverity\022 " +
      "\n\034MESSAGE_SEVERITY_UNSPECIFIED\020\000\022\010\n\004INFO" +
      "\020\001\022\013\n\007WARNING\020\002\022\t\n\005ERROR\020\003*K\n\014TransferTy" +
      "pe\022\035\n\031TRANSFER_TYPE_UNSPECIFIED\020\000\022\t\n\005BAT" +
      "CH\020\001\022\r\n\tSTREAMING\020\002\032\002\030\001*s\n\rTransferState" +
      "\022\036\n\032TRANSFER_STATE_UNSPECIFIED\020\000\022\013\n\007PEND" +
      "ING\020\002\022\013\n\007RUNNING\020\003\022\r\n\tSUCCEEDED\020\004\022\n\n\006FAI" +
      "LED\020\005\022\r\n\tCANCELLED\020\006B\347\001\n)com.google.clou" +
      "d.bigquery.datatransfer.v1B\rTransferProt" +
      "oP\001ZQgoogle.golang.org/genproto/googleap" +
      "is/cloud/bigquery/datatransfer/v1;datatr" +
      "ansfer\242\002\005GCBDT\252\002%Google.Cloud.BigQuery.D" +
      "ataTransfer.V1\312\002%Google\\Cloud\\BigQuery\\D" +
      "ataTransfer\\V1b\006proto3"
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
          com.google.api.FieldBehaviorProto.getDescriptor(),
          com.google.api.ResourceProto.getDescriptor(),
          com.google.protobuf.StructProto.getDescriptor(),
          com.google.protobuf.TimestampProto.getDescriptor(),
          com.google.rpc.StatusProto.getDescriptor(),
        }, assigner);
    internal_static_google_cloud_bigquery_datatransfer_v1_ScheduleOptions_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_bigquery_datatransfer_v1_ScheduleOptions_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_bigquery_datatransfer_v1_ScheduleOptions_descriptor,
        new java.lang.String[] { "DisableAutoScheduling", "StartTime", "EndTime", });
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferConfig_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferConfig_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_bigquery_datatransfer_v1_TransferConfig_descriptor,
        new java.lang.String[] { "Name", "DestinationDatasetId", "DisplayName", "DataSourceId", "Params", "Schedule", "ScheduleOptions", "DataRefreshWindowDays", "Disabled", "UpdateTime", "NextRunTime", "State", "UserId", "DatasetRegion", "Destination", });
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferRun_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferRun_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_bigquery_datatransfer_v1_TransferRun_descriptor,
        new java.lang.String[] { "Name", "ScheduleTime", "RunTime", "ErrorStatus", "StartTime", "EndTime", "UpdateTime", "Params", "DestinationDatasetId", "DataSourceId", "State", "UserId", "Schedule", "Destination", });
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferMessage_descriptor =
      getDescriptor().getMessageTypes().get(3);
    internal_static_google_cloud_bigquery_datatransfer_v1_TransferMessage_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_bigquery_datatransfer_v1_TransferMessage_descriptor,
        new java.lang.String[] { "MessageTime", "Severity", "MessageText", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.FieldBehaviorProto.fieldBehavior);
    registry.add(com.google.api.ResourceProto.resource);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.api.FieldBehaviorProto.getDescriptor();
    com.google.api.ResourceProto.getDescriptor();
    com.google.protobuf.StructProto.getDescriptor();
    com.google.protobuf.TimestampProto.getDescriptor();
    com.google.rpc.StatusProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
