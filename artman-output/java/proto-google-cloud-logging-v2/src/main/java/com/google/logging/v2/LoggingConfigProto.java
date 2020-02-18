// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/logging/v2/logging_config.proto

package com.google.logging.v2;

public final class LoggingConfigProto {
  private LoggingConfigProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_LogSink_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_LogSink_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_BigQueryOptions_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_BigQueryOptions_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_ListSinksRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_ListSinksRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_ListSinksResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_ListSinksResponse_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_GetSinkRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_GetSinkRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_CreateSinkRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_CreateSinkRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_UpdateSinkRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_UpdateSinkRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_DeleteSinkRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_DeleteSinkRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_LogExclusion_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_LogExclusion_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_ListExclusionsRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_ListExclusionsRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_ListExclusionsResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_ListExclusionsResponse_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_GetExclusionRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_GetExclusionRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_CreateExclusionRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_CreateExclusionRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_UpdateExclusionRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_UpdateExclusionRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_DeleteExclusionRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_DeleteExclusionRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_GetCmekSettingsRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_GetCmekSettingsRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_UpdateCmekSettingsRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_UpdateCmekSettingsRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_logging_v2_CmekSettings_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_logging_v2_CmekSettings_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n&google/logging/v2/logging_config.proto" +
      "\022\021google.logging.v2\032\027google/api/client.p" +
      "roto\032\037google/api/field_behavior.proto\032\031g" +
      "oogle/api/resource.proto\032\036google/protobu" +
      "f/duration.proto\032\033google/protobuf/empty." +
      "proto\032 google/protobuf/field_mask.proto\032" +
      "\037google/protobuf/timestamp.proto\032\034google" +
      "/api/annotations.proto\"\215\006\n\007LogSink\022\014\n\004na" +
      "me\030\001 \001(\t\022\033\n\013destination\030\003 \001(\tB\006\372A\003\n\001*\022\016\n" +
      "\006filter\030\005 \001(\t\022\023\n\013description\030\022 \001(\t\022\020\n\010di" +
      "sabled\030\023 \001(\010\022K\n\025output_version_format\030\006 " +
      "\001(\0162(.google.logging.v2.LogSink.VersionF" +
      "ormatB\002\030\001\022\034\n\017writer_identity\030\010 \001(\tB\003\340A\003\022" +
      "\030\n\020include_children\030\t \001(\010\022>\n\020bigquery_op" +
      "tions\030\014 \001(\0132\".google.logging.v2.BigQuery" +
      "OptionsH\000\0224\n\013create_time\030\r \001(\0132\032.google." +
      "protobuf.TimestampB\003\340A\003\0224\n\013update_time\030\016" +
      " \001(\0132\032.google.protobuf.TimestampB\003\340A\003\0222\n" +
      "\nstart_time\030\n \001(\0132\032.google.protobuf.Time" +
      "stampB\002\030\001\0220\n\010end_time\030\013 \001(\0132\032.google.pro" +
      "tobuf.TimestampB\002\030\001\"?\n\rVersionFormat\022\036\n\032" +
      "VERSION_FORMAT_UNSPECIFIED\020\000\022\006\n\002V2\020\001\022\006\n\002" +
      "V1\020\002:\274\001\352A\270\001\n\033logging.googleapis.com/Sink" +
      "\022\037projects/{project}/sinks/{sink}\022)organ" +
      "izations/{organization}/sinks/{sink}\022\035fo" +
      "lders/{folder}/sinks/{sink}\022.billingAcco" +
      "unts/{billing_account}/sinks/{sink}B\t\n\007o" +
      "ptions\"b\n\017BigQueryOptions\022\036\n\026use_partiti" +
      "oned_tables\030\001 \001(\010\022/\n\"uses_timestamp_colu" +
      "mn_partitioning\030\003 \001(\010B\003\340A\003\"n\n\020ListSinksR" +
      "equest\0223\n\006parent\030\001 \001(\tB#\340A\002\372A\035\022\033logging." +
      "googleapis.com/Sink\022\022\n\npage_token\030\002 \001(\t\022" +
      "\021\n\tpage_size\030\003 \001(\005\"W\n\021ListSinksResponse\022" +
      ")\n\005sinks\030\001 \003(\0132\032.google.logging.v2.LogSi" +
      "nk\022\027\n\017next_page_token\030\002 \001(\t\"H\n\016GetSinkRe" +
      "quest\0226\n\tsink_name\030\001 \001(\tB#\340A\002\372A\035\n\033loggin" +
      "g.googleapis.com/Sink\"\227\001\n\021CreateSinkRequ" +
      "est\0223\n\006parent\030\001 \001(\tB#\340A\002\372A\035\022\033logging.goo" +
      "gleapis.com/Sink\022-\n\004sink\030\002 \001(\0132\032.google." +
      "logging.v2.LogSinkB\003\340A\002\022\036\n\026unique_writer" +
      "_identity\030\003 \001(\010\"\313\001\n\021UpdateSinkRequest\0226\n" +
      "\tsink_name\030\001 \001(\tB#\340A\002\372A\035\n\033logging.google" +
      "apis.com/Sink\022-\n\004sink\030\002 \001(\0132\032.google.log" +
      "ging.v2.LogSinkB\003\340A\002\022\036\n\026unique_writer_id" +
      "entity\030\003 \001(\010\022/\n\013update_mask\030\004 \001(\0132\032.goog" +
      "le.protobuf.FieldMask\"K\n\021DeleteSinkReque" +
      "st\0226\n\tsink_name\030\001 \001(\tB#\340A\002\372A\035\n\033logging.g" +
      "oogleapis.com/Sink\"\241\003\n\014LogExclusion\022\014\n\004n" +
      "ame\030\001 \001(\t\022\023\n\013description\030\002 \001(\t\022\016\n\006filter" +
      "\030\003 \001(\t\022\020\n\010disabled\030\004 \001(\010\022/\n\013create_time\030" +
      "\005 \001(\0132\032.google.protobuf.Timestamp\022/\n\013upd" +
      "ate_time\030\006 \001(\0132\032.google.protobuf.Timesta" +
      "mp:\351\001\352A\345\001\n logging.googleapis.com/Exclus" +
      "ion\022)projects/{project}/exclusions/{excl" +
      "usion}\0223organizations/{organization}/exc" +
      "lusions/{exclusion}\022\'folders/{folder}/ex" +
      "clusions/{exclusion}\0228billingAccounts/{b" +
      "illing_account}/exclusions/{exclusion}\"x" +
      "\n\025ListExclusionsRequest\0228\n\006parent\030\001 \001(\tB" +
      "(\340A\002\372A\"\022 logging.googleapis.com/Exclusio" +
      "n\022\022\n\npage_token\030\002 \001(\t\022\021\n\tpage_size\030\003 \001(\005" +
      "\"f\n\026ListExclusionsResponse\0223\n\nexclusions" +
      "\030\001 \003(\0132\037.google.logging.v2.LogExclusion\022" +
      "\027\n\017next_page_token\030\002 \001(\t\"M\n\023GetExclusion" +
      "Request\0226\n\004name\030\001 \001(\tB(\340A\002\372A\"\n logging.g" +
      "oogleapis.com/Exclusion\"\206\001\n\026CreateExclus" +
      "ionRequest\0228\n\006parent\030\001 \001(\tB(\340A\002\372A\"\022 logg" +
      "ing.googleapis.com/Exclusion\0222\n\texclusio" +
      "n\030\002 \001(\0132\037.google.logging.v2.LogExclusion" +
      "\"\277\001\n\026UpdateExclusionRequest\0226\n\004name\030\001 \001(" +
      "\tB(\340A\002\372A\"\n logging.googleapis.com/Exclus" +
      "ion\0227\n\texclusion\030\002 \001(\0132\037.google.logging." +
      "v2.LogExclusionB\003\340A\002\0224\n\013update_mask\030\003 \001(" +
      "\0132\032.google.protobuf.FieldMaskB\003\340A\002\"P\n\026De" +
      "leteExclusionRequest\0226\n\004name\030\001 \001(\tB(\340A\002\372" +
      "A\"\n logging.googleapis.com/Exclusion\"&\n\026" +
      "GetCmekSettingsRequest\022\014\n\004name\030\001 \001(\t\"\222\001\n" +
      "\031UpdateCmekSettingsRequest\022\014\n\004name\030\001 \001(\t" +
      "\0226\n\rcmek_settings\030\002 \001(\0132\037.google.logging" +
      ".v2.CmekSettings\022/\n\013update_mask\030\003 \001(\0132\032." +
      "google.protobuf.FieldMask\"N\n\014CmekSetting" +
      "s\022\014\n\004name\030\001 \001(\t\022\024\n\014kms_key_name\030\002 \001(\t\022\032\n" +
      "\022service_account_id\030\003 \001(\t2\236\037\n\017ConfigServ" +
      "iceV2\022\220\002\n\tListSinks\022#.google.logging.v2." +
      "ListSinksRequest\032$.google.logging.v2.Lis" +
      "tSinksResponse\"\267\001\202\323\344\223\002\247\001\022\026/v2/{parent=*/" +
      "*}/sinksZ\037\022\035/v2/{parent=projects/*}/sink" +
      "sZ$\022\"/v2/{parent=organizations/*}/sinksZ" +
      "\036\022\034/v2/{parent=folders/*}/sinksZ&\022$/v2/{" +
      "parent=billingAccounts/*}/sinks\332A\006parent" +
      "\022\236\002\n\007GetSink\022!.google.logging.v2.GetSink" +
      "Request\032\032.google.logging.v2.LogSink\"\323\001\202\323" +
      "\344\223\002\300\001\022\033/v2/{sink_name=*/*/sinks/*}Z$\022\"/v" +
      "2/{sink_name=projects/*/sinks/*}Z)\022\'/v2/" +
      "{sink_name=organizations/*/sinks/*}Z#\022!/" +
      "v2/{sink_name=folders/*/sinks/*}Z+\022)/v2/" +
      "{sink_name=billingAccounts/*/sinks/*}\332A\t" +
      "sink_name\022\253\002\n\nCreateSink\022$.google.loggin" +
      "g.v2.CreateSinkRequest\032\032.google.logging." +
      "v2.LogSink\"\332\001\202\323\344\223\002\305\001\"\026/v2/{parent=*/*}/s" +
      "inks:\004sinkZ%\"\035/v2/{parent=projects/*}/si" +
      "nks:\004sinkZ*\"\"/v2/{parent=organizations/*" +
      "}/sinks:\004sinkZ$\"\034/v2/{parent=folders/*}/" +
      "sinks:\004sinkZ,\"$/v2/{parent=billingAccoun" +
      "ts/*}/sinks:\004sink\332A\013parent,sink\022\237\004\n\nUpda" +
      "teSink\022$.google.logging.v2.UpdateSinkReq" +
      "uest\032\032.google.logging.v2.LogSink\"\316\003\202\323\344\223\002" +
      "\231\003\032\033/v2/{sink_name=*/*/sinks/*}:\004sinkZ*\032" +
      "\"/v2/{sink_name=projects/*/sinks/*}:\004sin" +
      "kZ/\032\'/v2/{sink_name=organizations/*/sink" +
      "s/*}:\004sinkZ)\032!/v2/{sink_name=folders/*/s" +
      "inks/*}:\004sinkZ1\032)/v2/{sink_name=billingA" +
      "ccounts/*/sinks/*}:\004sinkZ*2\"/v2/{sink_na" +
      "me=projects/*/sinks/*}:\004sinkZ/2\'/v2/{sin" +
      "k_name=organizations/*/sinks/*}:\004sinkZ)2" +
      "!/v2/{sink_name=folders/*/sinks/*}:\004sink" +
      "Z12)/v2/{sink_name=billingAccounts/*/sin" +
      "ks/*}:\004sink\332A\032sink_name,sink,update_mask" +
      "\332A\016sink_name,sink\022\240\002\n\nDeleteSink\022$.googl" +
      "e.logging.v2.DeleteSinkRequest\032\026.google." +
      "protobuf.Empty\"\323\001\202\323\344\223\002\300\001*\033/v2/{sink_name" +
      "=*/*/sinks/*}Z$*\"/v2/{sink_name=projects" +
      "/*/sinks/*}Z)*\'/v2/{sink_name=organizati" +
      "ons/*/sinks/*}Z#*!/v2/{sink_name=folders" +
      "/*/sinks/*}Z+*)/v2/{sink_name=billingAcc" +
      "ounts/*/sinks/*}\332A\tsink_name\022\270\002\n\016ListExc" +
      "lusions\022(.google.logging.v2.ListExclusio" +
      "nsRequest\032).google.logging.v2.ListExclus" +
      "ionsResponse\"\320\001\202\323\344\223\002\300\001\022\033/v2/{parent=*/*}" +
      "/exclusionsZ$\022\"/v2/{parent=projects/*}/e" +
      "xclusionsZ)\022\'/v2/{parent=organizations/*" +
      "}/exclusionsZ#\022!/v2/{parent=folders/*}/e" +
      "xclusionsZ+\022)/v2/{parent=billingAccounts" +
      "/*}/exclusions\332A\006parent\022\250\002\n\014GetExclusion" +
      "\022&.google.logging.v2.GetExclusionRequest" +
      "\032\037.google.logging.v2.LogExclusion\"\316\001\202\323\344\223" +
      "\002\300\001\022\033/v2/{name=*/*/exclusions/*}Z$\022\"/v2/" +
      "{name=projects/*/exclusions/*}Z)\022\'/v2/{n" +
      "ame=organizations/*/exclusions/*}Z#\022!/v2" +
      "/{name=folders/*/exclusions/*}Z+\022)/v2/{n" +
      "ame=billingAccounts/*/exclusions/*}\332A\004na" +
      "me\022\361\002\n\017CreateExclusion\022).google.logging." +
      "v2.CreateExclusionRequest\032\037.google.loggi" +
      "ng.v2.LogExclusion\"\221\002\202\323\344\223\002\367\001\"\033/v2/{paren" +
      "t=*/*}/exclusions:\texclusionZ/\"\"/v2/{par" +
      "ent=projects/*}/exclusions:\texclusionZ4\"" +
      "\'/v2/{parent=organizations/*}/exclusions" +
      ":\texclusionZ.\"!/v2/{parent=folders/*}/ex" +
      "clusions:\texclusionZ6\")/v2/{parent=billi" +
      "ngAccounts/*}/exclusions:\texclusion\332A\020pa" +
      "rent,exclusion\022\373\002\n\017UpdateExclusion\022).goo" +
      "gle.logging.v2.UpdateExclusionRequest\032\037." +
      "google.logging.v2.LogExclusion\"\233\002\202\323\344\223\002\367\001" +
      "2\033/v2/{name=*/*/exclusions/*}:\texclusion" +
      "Z/2\"/v2/{name=projects/*/exclusions/*}:\t" +
      "exclusionZ42\'/v2/{name=organizations/*/e" +
      "xclusions/*}:\texclusionZ.2!/v2/{name=fol" +
      "ders/*/exclusions/*}:\texclusionZ62)/v2/{" +
      "name=billingAccounts/*/exclusions/*}:\tex" +
      "clusion\332A\032name,exclusion,update_mask\022\245\002\n" +
      "\017DeleteExclusion\022).google.logging.v2.Del" +
      "eteExclusionRequest\032\026.google.protobuf.Em" +
      "pty\"\316\001\202\323\344\223\002\300\001*\033/v2/{name=*/*/exclusions/" +
      "*}Z$*\"/v2/{name=projects/*/exclusions/*}" +
      "Z)*\'/v2/{name=organizations/*/exclusions" +
      "/*}Z#*!/v2/{name=folders/*/exclusions/*}" +
      "Z+*)/v2/{name=billingAccounts/*/exclusio" +
      "ns/*}\332A\004name\022\255\001\n\017GetCmekSettings\022).googl" +
      "e.logging.v2.GetCmekSettingsRequest\032\037.go" +
      "ogle.logging.v2.CmekSettings\"N\202\323\344\223\002H\022\033/v" +
      "2/{name=*/*}/cmekSettingsZ)\022\'/v2/{name=o" +
      "rganizations/*}/cmekSettings\022\321\001\n\022UpdateC" +
      "mekSettings\022,.google.logging.v2.UpdateCm" +
      "ekSettingsRequest\032\037.google.logging.v2.Cm" +
      "ekSettings\"l\202\323\344\223\002f2\033/v2/{name=*/*}/cmekS" +
      "ettings:\rcmek_settingsZ82\'/v2/{name=orga" +
      "nizations/*}/cmekSettings:\rcmek_settings" +
      "\032\337\001\312A\026logging.googleapis.com\322A\302\001https://" +
      "www.googleapis.com/auth/cloud-platform,h" +
      "ttps://www.googleapis.com/auth/cloud-pla" +
      "tform.read-only,https://www.googleapis.c" +
      "om/auth/logging.admin,https://www.google" +
      "apis.com/auth/logging.readB\236\001\n\025com.googl" +
      "e.logging.v2B\022LoggingConfigProtoP\001Z8goog" +
      "le.golang.org/genproto/googleapis/loggin" +
      "g/v2;logging\370\001\001\252\002\027Google.Cloud.Logging.V" +
      "2\312\002\027Google\\Cloud\\Logging\\V2b\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.ClientProto.getDescriptor(),
          com.google.api.FieldBehaviorProto.getDescriptor(),
          com.google.api.ResourceProto.getDescriptor(),
          com.google.protobuf.DurationProto.getDescriptor(),
          com.google.protobuf.EmptyProto.getDescriptor(),
          com.google.protobuf.FieldMaskProto.getDescriptor(),
          com.google.protobuf.TimestampProto.getDescriptor(),
          com.google.api.AnnotationsProto.getDescriptor(),
        });
    internal_static_google_logging_v2_LogSink_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_logging_v2_LogSink_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_LogSink_descriptor,
        new java.lang.String[] { "Name", "Destination", "Filter", "Description", "Disabled", "OutputVersionFormat", "WriterIdentity", "IncludeChildren", "BigqueryOptions", "CreateTime", "UpdateTime", "StartTime", "EndTime", "Options", });
    internal_static_google_logging_v2_BigQueryOptions_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_logging_v2_BigQueryOptions_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_BigQueryOptions_descriptor,
        new java.lang.String[] { "UsePartitionedTables", "UsesTimestampColumnPartitioning", });
    internal_static_google_logging_v2_ListSinksRequest_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_google_logging_v2_ListSinksRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_ListSinksRequest_descriptor,
        new java.lang.String[] { "Parent", "PageToken", "PageSize", });
    internal_static_google_logging_v2_ListSinksResponse_descriptor =
      getDescriptor().getMessageTypes().get(3);
    internal_static_google_logging_v2_ListSinksResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_ListSinksResponse_descriptor,
        new java.lang.String[] { "Sinks", "NextPageToken", });
    internal_static_google_logging_v2_GetSinkRequest_descriptor =
      getDescriptor().getMessageTypes().get(4);
    internal_static_google_logging_v2_GetSinkRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_GetSinkRequest_descriptor,
        new java.lang.String[] { "SinkName", });
    internal_static_google_logging_v2_CreateSinkRequest_descriptor =
      getDescriptor().getMessageTypes().get(5);
    internal_static_google_logging_v2_CreateSinkRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_CreateSinkRequest_descriptor,
        new java.lang.String[] { "Parent", "Sink", "UniqueWriterIdentity", });
    internal_static_google_logging_v2_UpdateSinkRequest_descriptor =
      getDescriptor().getMessageTypes().get(6);
    internal_static_google_logging_v2_UpdateSinkRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_UpdateSinkRequest_descriptor,
        new java.lang.String[] { "SinkName", "Sink", "UniqueWriterIdentity", "UpdateMask", });
    internal_static_google_logging_v2_DeleteSinkRequest_descriptor =
      getDescriptor().getMessageTypes().get(7);
    internal_static_google_logging_v2_DeleteSinkRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_DeleteSinkRequest_descriptor,
        new java.lang.String[] { "SinkName", });
    internal_static_google_logging_v2_LogExclusion_descriptor =
      getDescriptor().getMessageTypes().get(8);
    internal_static_google_logging_v2_LogExclusion_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_LogExclusion_descriptor,
        new java.lang.String[] { "Name", "Description", "Filter", "Disabled", "CreateTime", "UpdateTime", });
    internal_static_google_logging_v2_ListExclusionsRequest_descriptor =
      getDescriptor().getMessageTypes().get(9);
    internal_static_google_logging_v2_ListExclusionsRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_ListExclusionsRequest_descriptor,
        new java.lang.String[] { "Parent", "PageToken", "PageSize", });
    internal_static_google_logging_v2_ListExclusionsResponse_descriptor =
      getDescriptor().getMessageTypes().get(10);
    internal_static_google_logging_v2_ListExclusionsResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_ListExclusionsResponse_descriptor,
        new java.lang.String[] { "Exclusions", "NextPageToken", });
    internal_static_google_logging_v2_GetExclusionRequest_descriptor =
      getDescriptor().getMessageTypes().get(11);
    internal_static_google_logging_v2_GetExclusionRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_GetExclusionRequest_descriptor,
        new java.lang.String[] { "Name", });
    internal_static_google_logging_v2_CreateExclusionRequest_descriptor =
      getDescriptor().getMessageTypes().get(12);
    internal_static_google_logging_v2_CreateExclusionRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_CreateExclusionRequest_descriptor,
        new java.lang.String[] { "Parent", "Exclusion", });
    internal_static_google_logging_v2_UpdateExclusionRequest_descriptor =
      getDescriptor().getMessageTypes().get(13);
    internal_static_google_logging_v2_UpdateExclusionRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_UpdateExclusionRequest_descriptor,
        new java.lang.String[] { "Name", "Exclusion", "UpdateMask", });
    internal_static_google_logging_v2_DeleteExclusionRequest_descriptor =
      getDescriptor().getMessageTypes().get(14);
    internal_static_google_logging_v2_DeleteExclusionRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_DeleteExclusionRequest_descriptor,
        new java.lang.String[] { "Name", });
    internal_static_google_logging_v2_GetCmekSettingsRequest_descriptor =
      getDescriptor().getMessageTypes().get(15);
    internal_static_google_logging_v2_GetCmekSettingsRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_GetCmekSettingsRequest_descriptor,
        new java.lang.String[] { "Name", });
    internal_static_google_logging_v2_UpdateCmekSettingsRequest_descriptor =
      getDescriptor().getMessageTypes().get(16);
    internal_static_google_logging_v2_UpdateCmekSettingsRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_UpdateCmekSettingsRequest_descriptor,
        new java.lang.String[] { "Name", "CmekSettings", "UpdateMask", });
    internal_static_google_logging_v2_CmekSettings_descriptor =
      getDescriptor().getMessageTypes().get(17);
    internal_static_google_logging_v2_CmekSettings_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_logging_v2_CmekSettings_descriptor,
        new java.lang.String[] { "Name", "KmsKeyName", "ServiceAccountId", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.ClientProto.defaultHost);
    registry.add(com.google.api.FieldBehaviorProto.fieldBehavior);
    registry.add(com.google.api.AnnotationsProto.http);
    registry.add(com.google.api.ClientProto.methodSignature);
    registry.add(com.google.api.ClientProto.oauthScopes);
    registry.add(com.google.api.ResourceProto.resource);
    registry.add(com.google.api.ResourceProto.resourceReference);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.api.ClientProto.getDescriptor();
    com.google.api.FieldBehaviorProto.getDescriptor();
    com.google.api.ResourceProto.getDescriptor();
    com.google.protobuf.DurationProto.getDescriptor();
    com.google.protobuf.EmptyProto.getDescriptor();
    com.google.protobuf.FieldMaskProto.getDescriptor();
    com.google.protobuf.TimestampProto.getDescriptor();
    com.google.api.AnnotationsProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}