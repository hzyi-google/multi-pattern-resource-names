// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/bigquery/datatransfer/v1/transfer.proto

package com.google.cloud.bigquery.datatransfer.v1;

public interface TransferConfigOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.bigquery.datatransfer.v1.TransferConfig)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The resource name of the transfer config.
   * Transfer config names have the form of
   * `projects/{project_id}/locations/{region}/transferConfigs/{config_id}`.
   * The name is automatically generated based on the config_id specified in
   * CreateTransferConfigRequest along with project_id and region. If config_id
   * is not provided, usually a uuid, even though it is not guaranteed or
   * required, will be generated for config_id.
   * </pre>
   *
   * <code>string name = 1;</code>
   */
  java.lang.String getName();
  /**
   * <pre>
   * The resource name of the transfer config.
   * Transfer config names have the form of
   * `projects/{project_id}/locations/{region}/transferConfigs/{config_id}`.
   * The name is automatically generated based on the config_id specified in
   * CreateTransferConfigRequest along with project_id and region. If config_id
   * is not provided, usually a uuid, even though it is not guaranteed or
   * required, will be generated for config_id.
   * </pre>
   *
   * <code>string name = 1;</code>
   */
  com.google.protobuf.ByteString
      getNameBytes();

  /**
   * <pre>
   * The BigQuery target dataset id.
   * </pre>
   *
   * <code>string destination_dataset_id = 2;</code>
   */
  java.lang.String getDestinationDatasetId();
  /**
   * <pre>
   * The BigQuery target dataset id.
   * </pre>
   *
   * <code>string destination_dataset_id = 2;</code>
   */
  com.google.protobuf.ByteString
      getDestinationDatasetIdBytes();

  /**
   * <pre>
   * User specified display name for the data transfer.
   * </pre>
   *
   * <code>string display_name = 3;</code>
   */
  java.lang.String getDisplayName();
  /**
   * <pre>
   * User specified display name for the data transfer.
   * </pre>
   *
   * <code>string display_name = 3;</code>
   */
  com.google.protobuf.ByteString
      getDisplayNameBytes();

  /**
   * <pre>
   * Data source id. Cannot be changed once data transfer is created.
   * </pre>
   *
   * <code>string data_source_id = 5;</code>
   */
  java.lang.String getDataSourceId();
  /**
   * <pre>
   * Data source id. Cannot be changed once data transfer is created.
   * </pre>
   *
   * <code>string data_source_id = 5;</code>
   */
  com.google.protobuf.ByteString
      getDataSourceIdBytes();

  /**
   * <pre>
   * Data transfer specific parameters.
   * </pre>
   *
   * <code>.google.protobuf.Struct params = 9;</code>
   */
  boolean hasParams();
  /**
   * <pre>
   * Data transfer specific parameters.
   * </pre>
   *
   * <code>.google.protobuf.Struct params = 9;</code>
   */
  com.google.protobuf.Struct getParams();
  /**
   * <pre>
   * Data transfer specific parameters.
   * </pre>
   *
   * <code>.google.protobuf.Struct params = 9;</code>
   */
  com.google.protobuf.StructOrBuilder getParamsOrBuilder();

  /**
   * <pre>
   * Data transfer schedule.
   * If the data source does not support a custom schedule, this should be
   * empty. If it is empty, the default value for the data source will be
   * used.
   * The specified times are in UTC.
   * Examples of valid format:
   * `1st,3rd monday of month 15:30`,
   * `every wed,fri of jan,jun 13:15`, and
   * `first sunday of quarter 00:00`.
   * See more explanation about the format here:
   * https://cloud.google.com/appengine/docs/flexible/python/scheduling-jobs-with-cron-yaml#the_schedule_format
   * NOTE: the granularity should be at least 8 hours, or less frequent.
   * </pre>
   *
   * <code>string schedule = 7;</code>
   */
  java.lang.String getSchedule();
  /**
   * <pre>
   * Data transfer schedule.
   * If the data source does not support a custom schedule, this should be
   * empty. If it is empty, the default value for the data source will be
   * used.
   * The specified times are in UTC.
   * Examples of valid format:
   * `1st,3rd monday of month 15:30`,
   * `every wed,fri of jan,jun 13:15`, and
   * `first sunday of quarter 00:00`.
   * See more explanation about the format here:
   * https://cloud.google.com/appengine/docs/flexible/python/scheduling-jobs-with-cron-yaml#the_schedule_format
   * NOTE: the granularity should be at least 8 hours, or less frequent.
   * </pre>
   *
   * <code>string schedule = 7;</code>
   */
  com.google.protobuf.ByteString
      getScheduleBytes();

  /**
   * <pre>
   * Options customizing the data transfer schedule.
   * </pre>
   *
   * <code>.google.cloud.bigquery.datatransfer.v1.ScheduleOptions schedule_options = 24;</code>
   */
  boolean hasScheduleOptions();
  /**
   * <pre>
   * Options customizing the data transfer schedule.
   * </pre>
   *
   * <code>.google.cloud.bigquery.datatransfer.v1.ScheduleOptions schedule_options = 24;</code>
   */
  com.google.cloud.bigquery.datatransfer.v1.ScheduleOptions getScheduleOptions();
  /**
   * <pre>
   * Options customizing the data transfer schedule.
   * </pre>
   *
   * <code>.google.cloud.bigquery.datatransfer.v1.ScheduleOptions schedule_options = 24;</code>
   */
  com.google.cloud.bigquery.datatransfer.v1.ScheduleOptionsOrBuilder getScheduleOptionsOrBuilder();

  /**
   * <pre>
   * The number of days to look back to automatically refresh the data.
   * For example, if `data_refresh_window_days = 10`, then every day
   * BigQuery reingests data for [today-10, today-1], rather than ingesting data
   * for just [today-1].
   * Only valid if the data source supports the feature. Set the value to  0
   * to use the default value.
   * </pre>
   *
   * <code>int32 data_refresh_window_days = 12;</code>
   */
  int getDataRefreshWindowDays();

  /**
   * <pre>
   * Is this config disabled. When set to true, no runs are scheduled
   * for a given transfer.
   * </pre>
   *
   * <code>bool disabled = 13;</code>
   */
  boolean getDisabled();

  /**
   * <pre>
   * Output only. Data transfer modification time. Ignored by server on input.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp update_time = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  boolean hasUpdateTime();
  /**
   * <pre>
   * Output only. Data transfer modification time. Ignored by server on input.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp update_time = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.Timestamp getUpdateTime();
  /**
   * <pre>
   * Output only. Data transfer modification time. Ignored by server on input.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp update_time = 4 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.TimestampOrBuilder getUpdateTimeOrBuilder();

  /**
   * <pre>
   * Output only. Next time when data transfer will run.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp next_run_time = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  boolean hasNextRunTime();
  /**
   * <pre>
   * Output only. Next time when data transfer will run.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp next_run_time = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.Timestamp getNextRunTime();
  /**
   * <pre>
   * Output only. Next time when data transfer will run.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp next_run_time = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.TimestampOrBuilder getNextRunTimeOrBuilder();

  /**
   * <pre>
   * Output only. State of the most recently updated transfer run.
   * </pre>
   *
   * <code>.google.cloud.bigquery.datatransfer.v1.TransferState state = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  int getStateValue();
  /**
   * <pre>
   * Output only. State of the most recently updated transfer run.
   * </pre>
   *
   * <code>.google.cloud.bigquery.datatransfer.v1.TransferState state = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.cloud.bigquery.datatransfer.v1.TransferState getState();

  /**
   * <pre>
   * Deprecated. Unique ID of the user on whose behalf transfer is done.
   * </pre>
   *
   * <code>int64 user_id = 11;</code>
   */
  long getUserId();

  /**
   * <pre>
   * Output only. Region in which BigQuery dataset is located.
   * </pre>
   *
   * <code>string dataset_region = 14 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  java.lang.String getDatasetRegion();
  /**
   * <pre>
   * Output only. Region in which BigQuery dataset is located.
   * </pre>
   *
   * <code>string dataset_region = 14 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.ByteString
      getDatasetRegionBytes();

  public com.google.cloud.bigquery.datatransfer.v1.TransferConfig.DestinationCase getDestinationCase();
}
