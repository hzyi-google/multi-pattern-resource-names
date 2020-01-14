# Copyright 2019 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

require "minitest/autorun"
require "minitest/spec"

require "google/gax"

require "google/cloud/bigquery/data_transfer"
require "google/cloud/bigquery/data_transfer/v1/data_transfer_service_client"
require "google/cloud/bigquery/datatransfer/v1/datatransfer_services_pb"

class CustomTestError_v1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1

  # @param expected_symbol [Symbol] the symbol of the grpc method to be mocked.
  # @param mock_method [Proc] The method that is being mocked.
  def initialize(expected_symbol, mock_method)
    @expected_symbol = expected_symbol
    @mock_method = mock_method
  end

  # This overrides the Object#method method to return the mocked method when the mocked method
  # is being requested. For methods that aren't being tested, this method returns a proc that
  # will raise an error when called. This is to assure that only the mocked grpc method is being
  # called.
  #
  # @param symbol [Symbol] The symbol of the method being requested.
  # @return [Proc] The proc of the requested method. If the requested method is not being mocked
  #   the proc returned will raise when called.
  def method(symbol)
    return @mock_method if symbol == @expected_symbol

    # The requested method is not being tested, raise if it called.
    proc do
      raise "The method #{symbol} was unexpectedly called during the " \
        "test for #{@expected_symbol}."
    end
  end
end

class MockDataTransferServiceCredentials_v1 < Google::Cloud::Bigquery::DataTransfer::V1::Credentials
  def initialize(method_name)
    @method_name = method_name
  end

  def updater_proc
    proc do
      raise "The method `#{@method_name}` was trying to make a grpc request. This should not " \
          "happen since the grpc layer is being mocked."
    end
  end
end

describe Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient do

  describe 'get_data_source' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient#get_data_source."

    it 'invokes get_data_source without error' do
      # Create expected grpc response
      name = "name3373707"
      data_source_id = "dataSourceId-1015796374"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      client_id = "clientId-1904089585"
      supports_multiple_transfers = true
      update_deadline_seconds = 991471694
      default_schedule = "defaultSchedule-800168235"
      supports_custom_schedule = true
      help_url = "helpUrl-789431439"
      default_data_refresh_window_days = 1804935157
      manual_runs_disabled = true
      expected_response = {
        name: name,
        data_source_id: data_source_id,
        display_name: display_name,
        description: description,
        client_id: client_id,
        supports_multiple_transfers: supports_multiple_transfers,
        update_deadline_seconds: update_deadline_seconds,
        default_schedule: default_schedule,
        supports_custom_schedule: supports_custom_schedule,
        help_url: help_url,
        default_data_refresh_window_days: default_data_refresh_window_days,
        manual_runs_disabled: manual_runs_disabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Datatransfer::V1::DataSource)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_data_source, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("get_data_source")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          response = client.get_data_source

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_data_source do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_data_source with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_data_source, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("get_data_source")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_data_source
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_data_sources' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient#list_data_sources."

    it 'invokes list_data_sources without error' do
      # Create expected grpc response
      next_page_token = "nextPageToken-1530815211"
      expected_response = { next_page_token: next_page_token }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Datatransfer::V1::ListDataSourcesResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_data_sources, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("list_data_sources")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          response = client.list_data_sources

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_data_sources do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_data_sources with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_data_sources, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("list_data_sources")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_data_sources
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_transfer_config' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient#create_transfer_config."

    it 'invokes create_transfer_config without error' do
      # Create expected grpc response
      name = "name3373707"
      destination_dataset_id = "destinationDatasetId1541564179"
      display_name = "displayName1615086568"
      data_source_id = "dataSourceId-1015796374"
      schedule = "schedule-697920873"
      data_refresh_window_days = 327632845
      disabled = true
      user_id = 147132913
      dataset_region = "datasetRegion959248539"
      notification_pubsub_topic = "notificationPubsubTopic1794281191"
      expected_response = {
        name: name,
        destination_dataset_id: destination_dataset_id,
        display_name: display_name,
        data_source_id: data_source_id,
        schedule: schedule,
        data_refresh_window_days: data_refresh_window_days,
        disabled: disabled,
        user_id: user_id,
        dataset_region: dataset_region,
        notification_pubsub_topic: notification_pubsub_topic
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Datatransfer::V1::TransferConfig)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_transfer_config, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("create_transfer_config")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          response = client.create_transfer_config

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_transfer_config do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_transfer_config with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_transfer_config, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("create_transfer_config")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_transfer_config
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_transfer_config' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient#update_transfer_config."

    it 'invokes update_transfer_config without error' do
      # Create expected grpc response
      name = "name3373707"
      destination_dataset_id = "destinationDatasetId1541564179"
      display_name = "displayName1615086568"
      data_source_id = "dataSourceId-1015796374"
      schedule = "schedule-697920873"
      data_refresh_window_days = 327632845
      disabled = true
      user_id = 147132913
      dataset_region = "datasetRegion959248539"
      notification_pubsub_topic = "notificationPubsubTopic1794281191"
      expected_response = {
        name: name,
        destination_dataset_id: destination_dataset_id,
        display_name: display_name,
        data_source_id: data_source_id,
        schedule: schedule,
        data_refresh_window_days: data_refresh_window_days,
        disabled: disabled,
        user_id: user_id,
        dataset_region: dataset_region,
        notification_pubsub_topic: notification_pubsub_topic
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Datatransfer::V1::TransferConfig)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_transfer_config, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("update_transfer_config")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          response = client.update_transfer_config

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_transfer_config do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_transfer_config with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_transfer_config, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("update_transfer_config")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_transfer_config
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_transfer_config' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient#delete_transfer_config."

    it 'invokes delete_transfer_config without error' do

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_transfer_config, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("delete_transfer_config")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          response = client.delete_transfer_config

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_transfer_config do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_transfer_config with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_transfer_config, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("delete_transfer_config")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_transfer_config
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_transfer_config' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient#get_transfer_config."

    it 'invokes get_transfer_config without error' do
      # Create expected grpc response
      name = "name3373707"
      destination_dataset_id = "destinationDatasetId1541564179"
      display_name = "displayName1615086568"
      data_source_id = "dataSourceId-1015796374"
      schedule = "schedule-697920873"
      data_refresh_window_days = 327632845
      disabled = true
      user_id = 147132913
      dataset_region = "datasetRegion959248539"
      notification_pubsub_topic = "notificationPubsubTopic1794281191"
      expected_response = {
        name: name,
        destination_dataset_id: destination_dataset_id,
        display_name: display_name,
        data_source_id: data_source_id,
        schedule: schedule,
        data_refresh_window_days: data_refresh_window_days,
        disabled: disabled,
        user_id: user_id,
        dataset_region: dataset_region,
        notification_pubsub_topic: notification_pubsub_topic
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Datatransfer::V1::TransferConfig)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_transfer_config, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("get_transfer_config")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          response = client.get_transfer_config

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_transfer_config do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_transfer_config with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_transfer_config, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("get_transfer_config")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_transfer_config
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_transfer_configs' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient#list_transfer_configs."

    it 'invokes list_transfer_configs without error' do
      # Create expected grpc response
      next_page_token = "nextPageToken-1530815211"
      expected_response = { next_page_token: next_page_token }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Datatransfer::V1::ListTransferConfigsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_transfer_configs, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("list_transfer_configs")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          response = client.list_transfer_configs

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_transfer_configs do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_transfer_configs with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_transfer_configs, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("list_transfer_configs")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_transfer_configs
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'schedule_transfer_runs' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient#schedule_transfer_runs."

    it 'invokes schedule_transfer_runs without error' do
      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Datatransfer::V1::ScheduleTransferRunsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:schedule_transfer_runs, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("schedule_transfer_runs")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          response = client.schedule_transfer_runs

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.schedule_transfer_runs do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes schedule_transfer_runs with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:schedule_transfer_runs, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("schedule_transfer_runs")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.schedule_transfer_runs
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'start_manual_transfer_runs' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient#start_manual_transfer_runs."

    it 'invokes start_manual_transfer_runs without error' do
      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Datatransfer::V1::StartManualTransferRunsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:start_manual_transfer_runs, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("start_manual_transfer_runs")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          response = client.start_manual_transfer_runs

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.start_manual_transfer_runs do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes start_manual_transfer_runs with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:start_manual_transfer_runs, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("start_manual_transfer_runs")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.start_manual_transfer_runs
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_transfer_run' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient#get_transfer_run."

    it 'invokes get_transfer_run without error' do
      # Create expected grpc response
      name = "name3373707"
      destination_dataset_id = "destinationDatasetId1541564179"
      data_source_id = "dataSourceId-1015796374"
      user_id = 147132913
      schedule = "schedule-697920873"
      notification_pubsub_topic = "notificationPubsubTopic1794281191"
      expected_response = {
        name: name,
        destination_dataset_id: destination_dataset_id,
        data_source_id: data_source_id,
        user_id: user_id,
        schedule: schedule,
        notification_pubsub_topic: notification_pubsub_topic
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Datatransfer::V1::TransferRun)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_transfer_run, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("get_transfer_run")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          response = client.get_transfer_run

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_transfer_run do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_transfer_run with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_transfer_run, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("get_transfer_run")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_transfer_run
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_transfer_run' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient#delete_transfer_run."

    it 'invokes delete_transfer_run without error' do

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_transfer_run, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("delete_transfer_run")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          response = client.delete_transfer_run

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_transfer_run do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_transfer_run with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_transfer_run, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("delete_transfer_run")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_transfer_run
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_transfer_runs' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient#list_transfer_runs."

    it 'invokes list_transfer_runs without error' do
      # Create expected grpc response
      next_page_token = "nextPageToken-1530815211"
      expected_response = { next_page_token: next_page_token }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Datatransfer::V1::ListTransferRunsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_transfer_runs, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("list_transfer_runs")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          response = client.list_transfer_runs

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_transfer_runs do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_transfer_runs with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_transfer_runs, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("list_transfer_runs")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_transfer_runs
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_transfer_logs' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient#list_transfer_logs."

    it 'invokes list_transfer_logs without error' do
      # Create expected grpc response
      next_page_token = "nextPageToken-1530815211"
      expected_response = { next_page_token: next_page_token }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Datatransfer::V1::ListTransferLogsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_transfer_logs, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("list_transfer_logs")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          response = client.list_transfer_logs

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_transfer_logs do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_transfer_logs with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_transfer_logs, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("list_transfer_logs")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_transfer_logs
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'check_valid_creds' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Bigquery::DataTransfer::V1::DataTransferServiceClient#check_valid_creds."

    it 'invokes check_valid_creds without error' do
      # Create expected grpc response
      has_valid_creds = false
      expected_response = { has_valid_creds: has_valid_creds }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Datatransfer::V1::CheckValidCredsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:check_valid_creds, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("check_valid_creds")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          response = client.check_valid_creds

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.check_valid_creds do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes check_valid_creds with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:check_valid_creds, mock_method)

      # Mock auth layer
      mock_credentials = MockDataTransferServiceCredentials_v1.new("check_valid_creds")

      Google::Cloud::Bigquery::Datatransfer::V1::DataTransferService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::DataTransfer::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::DataTransfer.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.check_valid_creds
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end