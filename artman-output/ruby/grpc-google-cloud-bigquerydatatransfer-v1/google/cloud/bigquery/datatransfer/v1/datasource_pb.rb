# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/bigquery/datatransfer/v1/datasource.proto

require 'google/protobuf'

require 'google/api/annotations_pb'
require 'google/cloud/bigquery/datatransfer/v1/datatransfer_pb'
require 'google/cloud/bigquery/datatransfer/v1/transfer_pb'
require 'google/protobuf/duration_pb'
require 'google/protobuf/empty_pb'
require 'google/protobuf/field_mask_pb'
require 'google/protobuf/timestamp_pb'
require 'google/protobuf/wrappers_pb'
require 'google/api/client_pb'
Google::Protobuf::DescriptorPool.generated_pool.build do
  add_message "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo" do
    optional :sql, :string, 1
    optional :destination_table_id, :string, 2
    optional :destination_table_description, :string, 10
    repeated :table_defs, :message, 3, "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.TableDefinition"
    repeated :user_defined_functions, :string, 4
    optional :write_disposition, :enum, 6, "google.cloud.bigquery.datatransfer.v1.WriteDisposition"
  end
  add_message "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.FieldSchema" do
    optional :field_name, :string, 1
    optional :type, :enum, 2, "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.FieldSchema.Type"
    optional :is_repeated, :bool, 3
    optional :description, :string, 4
    optional :schema, :message, 5, "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.RecordSchema"
  end
  add_enum "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.FieldSchema.Type" do
    value :TYPE_UNSPECIFIED, 0
    value :STRING, 1
    value :INTEGER, 2
    value :FLOAT, 3
    value :RECORD, 4
    value :BYTES, 5
    value :BOOLEAN, 6
    value :TIMESTAMP, 7
    value :DATE, 8
    value :TIME, 9
    value :DATETIME, 10
    value :NUMERIC, 11
    value :GEOGRAPHY, 12
  end
  add_message "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.RecordSchema" do
    repeated :fields, :message, 1, "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.FieldSchema"
  end
  add_message "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.TableDefinition" do
    optional :table_id, :string, 1
    repeated :source_uris, :string, 2
    optional :format, :enum, 3, "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.Format"
    optional :max_bad_records, :int32, 4
    optional :encoding, :enum, 5, "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.Encoding"
    optional :csv_options, :message, 6, "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.TableDefinition.CsvOptions"
    optional :schema, :message, 7, "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.RecordSchema"
    optional :ignore_unknown_values, :message, 10, "google.protobuf.BoolValue"
  end
  add_message "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.TableDefinition.CsvOptions" do
    optional :field_delimiter, :message, 1, "google.protobuf.StringValue"
    optional :allow_quoted_newlines, :message, 2, "google.protobuf.BoolValue"
    optional :quote_char, :message, 3, "google.protobuf.StringValue"
    optional :skip_leading_rows, :message, 4, "google.protobuf.Int64Value"
    optional :allow_jagged_rows, :message, 5, "google.protobuf.BoolValue"
  end
  add_enum "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.Format" do
    value :FORMAT_UNSPECIFIED, 0
    value :CSV, 1
    value :JSON, 2
    value :AVRO, 3
    value :RECORDIO, 4
    value :COLUMNIO, 5
    value :CAPACITOR, 6
    value :PARQUET, 7
    value :ORC, 8
  end
  add_enum "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.Encoding" do
    value :ENCODING_UNSPECIFIED, 0
    value :ISO_8859_1, 1
    value :UTF8, 2
  end
  add_message "google.cloud.bigquery.datatransfer.v1.UpdateTransferRunRequest" do
    optional :transfer_run, :message, 1, "google.cloud.bigquery.datatransfer.v1.TransferRun"
    optional :update_mask, :message, 2, "google.protobuf.FieldMask"
  end
  add_message "google.cloud.bigquery.datatransfer.v1.LogTransferRunMessagesRequest" do
    optional :name, :string, 1
    repeated :transfer_messages, :message, 2, "google.cloud.bigquery.datatransfer.v1.TransferMessage"
  end
  add_message "google.cloud.bigquery.datatransfer.v1.StartBigQueryJobsRequest" do
    optional :name, :string, 1
    repeated :imported_data, :message, 2, "google.cloud.bigquery.datatransfer.v1.ImportedDataInfo"
    optional :user_credentials, :bytes, 3
    optional :max_parallelism, :int32, 8
  end
  add_message "google.cloud.bigquery.datatransfer.v1.FinishRunRequest" do
    optional :name, :string, 1
  end
  add_message "google.cloud.bigquery.datatransfer.v1.CreateDataSourceDefinitionRequest" do
    optional :parent, :string, 1
    optional :data_source_definition, :message, 2, "google.cloud.bigquery.datatransfer.v1.DataSourceDefinition"
  end
  add_message "google.cloud.bigquery.datatransfer.v1.UpdateDataSourceDefinitionRequest" do
    optional :data_source_definition, :message, 1, "google.cloud.bigquery.datatransfer.v1.DataSourceDefinition"
    optional :update_mask, :message, 2, "google.protobuf.FieldMask"
  end
  add_message "google.cloud.bigquery.datatransfer.v1.DeleteDataSourceDefinitionRequest" do
    optional :name, :string, 1
  end
  add_message "google.cloud.bigquery.datatransfer.v1.GetDataSourceDefinitionRequest" do
    optional :name, :string, 1
  end
  add_message "google.cloud.bigquery.datatransfer.v1.ListDataSourceDefinitionsRequest" do
    optional :parent, :string, 1
    optional :page_token, :string, 2
    optional :page_size, :int32, 3
  end
  add_message "google.cloud.bigquery.datatransfer.v1.ListDataSourceDefinitionsResponse" do
    repeated :data_source_definitions, :message, 1, "google.cloud.bigquery.datatransfer.v1.DataSourceDefinition"
    optional :next_page_token, :string, 2
  end
  add_message "google.cloud.bigquery.datatransfer.v1.DataSourceDefinition" do
    optional :name, :string, 21
    optional :data_source, :message, 1, "google.cloud.bigquery.datatransfer.v1.DataSource"
    optional :transfer_run_pubsub_topic, :string, 13
    optional :run_time_offset, :message, 16, "google.protobuf.Duration"
    optional :support_email, :string, 22
    optional :service_account, :string, 2
    optional :disabled, :bool, 5
    optional :transfer_config_pubsub_topic, :string, 12
    repeated :supported_location_ids, :string, 23
  end
  add_enum "google.cloud.bigquery.datatransfer.v1.WriteDisposition" do
    value :WRITE_DISPOSITION_UNSPECIFIED, 0
    value :WRITE_TRUNCATE, 1
    value :WRITE_APPEND, 2
  end
end

module Google
  module Cloud
    module Bigquery
      module Datatransfer
        module V1
          ImportedDataInfo = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.ImportedDataInfo").msgclass
          ImportedDataInfo::FieldSchema = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.FieldSchema").msgclass
          ImportedDataInfo::FieldSchema::Type = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.FieldSchema.Type").enummodule
          ImportedDataInfo::RecordSchema = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.RecordSchema").msgclass
          ImportedDataInfo::TableDefinition = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.TableDefinition").msgclass
          ImportedDataInfo::TableDefinition::CsvOptions = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.TableDefinition.CsvOptions").msgclass
          ImportedDataInfo::Format = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.Format").enummodule
          ImportedDataInfo::Encoding = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.ImportedDataInfo.Encoding").enummodule
          UpdateTransferRunRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.UpdateTransferRunRequest").msgclass
          LogTransferRunMessagesRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.LogTransferRunMessagesRequest").msgclass
          StartBigQueryJobsRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.StartBigQueryJobsRequest").msgclass
          FinishRunRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.FinishRunRequest").msgclass
          CreateDataSourceDefinitionRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.CreateDataSourceDefinitionRequest").msgclass
          UpdateDataSourceDefinitionRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.UpdateDataSourceDefinitionRequest").msgclass
          DeleteDataSourceDefinitionRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.DeleteDataSourceDefinitionRequest").msgclass
          GetDataSourceDefinitionRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.GetDataSourceDefinitionRequest").msgclass
          ListDataSourceDefinitionsRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.ListDataSourceDefinitionsRequest").msgclass
          ListDataSourceDefinitionsResponse = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.ListDataSourceDefinitionsResponse").msgclass
          DataSourceDefinition = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.DataSourceDefinition").msgclass
          WriteDisposition = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.datatransfer.v1.WriteDisposition").enummodule
        end
      end
    end
  end
end
