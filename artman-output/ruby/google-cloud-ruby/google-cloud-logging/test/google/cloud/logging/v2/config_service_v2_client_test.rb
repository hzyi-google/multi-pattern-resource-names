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

require "google/cloud/logging"
require "google/cloud/logging/v2/config_service_v2_client"
require "google/logging/v2/logging_config_services_pb"

class CustomTestError_v2 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v2

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

class MockConfigServiceV2Credentials_v2 < Google::Cloud::Logging::V2::Credentials
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

describe Google::Cloud::Logging::V2::ConfigServiceV2Client do

  describe 'list_sinks' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Logging::V2::ConfigServiceV2Client#list_sinks."

    it 'invokes list_sinks without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Logging::V2::ConfigServiceV2Client.project_path("[PROJECT]")

      # Create expected grpc response
      next_page_token = ""
      sinks_element = {}
      sinks = [sinks_element]
      expected_response = { next_page_token: next_page_token, sinks: sinks }
      expected_response = Google::Gax::to_proto(expected_response, Google::Logging::V2::ListSinksResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::ListSinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:list_sinks, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("list_sinks")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          response = client.list_sinks(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.sinks.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_sinks with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Logging::V2::ConfigServiceV2Client.project_path("[PROJECT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::ListSinksRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:list_sinks, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("list_sinks")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.list_sinks(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_sink' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Logging::V2::ConfigServiceV2Client#get_sink."

    it 'invokes get_sink without error' do
      # Create request parameters
      formatted_sink_name = Google::Cloud::Logging::V2::ConfigServiceV2Client.sink_path("[PROJECT]", "[SINK]")

      # Create expected grpc response
      name = "name3373707"
      destination = "destination-1429847026"
      filter = "filter-1274492040"
      writer_identity = "writerIdentity775638794"
      include_children = true
      expected_response = {
        name: name,
        destination: destination,
        filter: filter,
        writer_identity: writer_identity,
        include_children: include_children
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Logging::V2::LogSink)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::GetSinkRequest, request)
        assert_equal(formatted_sink_name, request.sink_name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:get_sink, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("get_sink")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          response = client.get_sink(formatted_sink_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_sink(formatted_sink_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_sink with error' do
      # Create request parameters
      formatted_sink_name = Google::Cloud::Logging::V2::ConfigServiceV2Client.sink_path("[PROJECT]", "[SINK]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::GetSinkRequest, request)
        assert_equal(formatted_sink_name, request.sink_name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:get_sink, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("get_sink")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.get_sink(formatted_sink_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_sink' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Logging::V2::ConfigServiceV2Client#create_sink."

    it 'invokes create_sink without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Logging::V2::ConfigServiceV2Client.project_path("[PROJECT]")
      sink = {}

      # Create expected grpc response
      name = "name3373707"
      destination = "destination-1429847026"
      filter = "filter-1274492040"
      writer_identity = "writerIdentity775638794"
      include_children = true
      expected_response = {
        name: name,
        destination: destination,
        filter: filter,
        writer_identity: writer_identity,
        include_children: include_children
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Logging::V2::LogSink)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::CreateSinkRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(sink, Google::Logging::V2::LogSink), request.sink)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:create_sink, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("create_sink")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          response = client.create_sink(formatted_parent, sink)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_sink(formatted_parent, sink) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_sink with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Logging::V2::ConfigServiceV2Client.project_path("[PROJECT]")
      sink = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::CreateSinkRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(sink, Google::Logging::V2::LogSink), request.sink)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:create_sink, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("create_sink")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.create_sink(formatted_parent, sink)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_sink' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Logging::V2::ConfigServiceV2Client#update_sink."

    it 'invokes update_sink without error' do
      # Create request parameters
      formatted_sink_name = Google::Cloud::Logging::V2::ConfigServiceV2Client.sink_path("[PROJECT]", "[SINK]")
      sink = {}

      # Create expected grpc response
      name = "name3373707"
      destination = "destination-1429847026"
      filter = "filter-1274492040"
      writer_identity = "writerIdentity775638794"
      include_children = true
      expected_response = {
        name: name,
        destination: destination,
        filter: filter,
        writer_identity: writer_identity,
        include_children: include_children
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Logging::V2::LogSink)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::UpdateSinkRequest, request)
        assert_equal(formatted_sink_name, request.sink_name)
        assert_equal(Google::Gax::to_proto(sink, Google::Logging::V2::LogSink), request.sink)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:update_sink, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("update_sink")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          response = client.update_sink(formatted_sink_name, sink)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_sink(formatted_sink_name, sink) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_sink with error' do
      # Create request parameters
      formatted_sink_name = Google::Cloud::Logging::V2::ConfigServiceV2Client.sink_path("[PROJECT]", "[SINK]")
      sink = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::UpdateSinkRequest, request)
        assert_equal(formatted_sink_name, request.sink_name)
        assert_equal(Google::Gax::to_proto(sink, Google::Logging::V2::LogSink), request.sink)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:update_sink, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("update_sink")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.update_sink(formatted_sink_name, sink)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_sink' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Logging::V2::ConfigServiceV2Client#delete_sink."

    it 'invokes delete_sink without error' do
      # Create request parameters
      formatted_sink_name = Google::Cloud::Logging::V2::ConfigServiceV2Client.sink_path("[PROJECT]", "[SINK]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::DeleteSinkRequest, request)
        assert_equal(formatted_sink_name, request.sink_name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v2.new(:delete_sink, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("delete_sink")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          response = client.delete_sink(formatted_sink_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_sink(formatted_sink_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_sink with error' do
      # Create request parameters
      formatted_sink_name = Google::Cloud::Logging::V2::ConfigServiceV2Client.sink_path("[PROJECT]", "[SINK]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::DeleteSinkRequest, request)
        assert_equal(formatted_sink_name, request.sink_name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:delete_sink, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("delete_sink")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.delete_sink(formatted_sink_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_exclusions' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Logging::V2::ConfigServiceV2Client#list_exclusions."

    it 'invokes list_exclusions without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Logging::V2::ConfigServiceV2Client.project_path("[PROJECT]")

      # Create expected grpc response
      next_page_token = ""
      exclusions_element = {}
      exclusions = [exclusions_element]
      expected_response = { next_page_token: next_page_token, exclusions: exclusions }
      expected_response = Google::Gax::to_proto(expected_response, Google::Logging::V2::ListExclusionsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::ListExclusionsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:list_exclusions, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("list_exclusions")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          response = client.list_exclusions(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.exclusions.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_exclusions with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Logging::V2::ConfigServiceV2Client.project_path("[PROJECT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::ListExclusionsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:list_exclusions, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("list_exclusions")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.list_exclusions(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_exclusion' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Logging::V2::ConfigServiceV2Client#get_exclusion."

    it 'invokes get_exclusion without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Logging::V2::ConfigServiceV2Client.exclusion_path("[PROJECT]", "[EXCLUSION]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      filter = "filter-1274492040"
      disabled = true
      expected_response = {
        name: name_2,
        description: description,
        filter: filter,
        disabled: disabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Logging::V2::LogExclusion)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::GetExclusionRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:get_exclusion, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("get_exclusion")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          response = client.get_exclusion(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_exclusion(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_exclusion with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Logging::V2::ConfigServiceV2Client.exclusion_path("[PROJECT]", "[EXCLUSION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::GetExclusionRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:get_exclusion, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("get_exclusion")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.get_exclusion(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_exclusion' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Logging::V2::ConfigServiceV2Client#create_exclusion."

    it 'invokes create_exclusion without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Logging::V2::ConfigServiceV2Client.project_path("[PROJECT]")
      exclusion = {}

      # Create expected grpc response
      name = "name3373707"
      description = "description-1724546052"
      filter = "filter-1274492040"
      disabled = true
      expected_response = {
        name: name,
        description: description,
        filter: filter,
        disabled: disabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Logging::V2::LogExclusion)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::CreateExclusionRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(exclusion, Google::Logging::V2::LogExclusion), request.exclusion)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:create_exclusion, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("create_exclusion")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          response = client.create_exclusion(formatted_parent, exclusion)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_exclusion(formatted_parent, exclusion) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_exclusion with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Logging::V2::ConfigServiceV2Client.project_path("[PROJECT]")
      exclusion = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::CreateExclusionRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(exclusion, Google::Logging::V2::LogExclusion), request.exclusion)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:create_exclusion, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("create_exclusion")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.create_exclusion(formatted_parent, exclusion)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_exclusion' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Logging::V2::ConfigServiceV2Client#update_exclusion."

    it 'invokes update_exclusion without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Logging::V2::ConfigServiceV2Client.exclusion_path("[PROJECT]", "[EXCLUSION]")
      exclusion = {}
      update_mask = {}

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      filter = "filter-1274492040"
      disabled = true
      expected_response = {
        name: name_2,
        description: description,
        filter: filter,
        disabled: disabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Logging::V2::LogExclusion)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::UpdateExclusionRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(exclusion, Google::Logging::V2::LogExclusion), request.exclusion)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:update_exclusion, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("update_exclusion")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          response = client.update_exclusion(
            formatted_name,
            exclusion,
            update_mask
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_exclusion(
            formatted_name,
            exclusion,
            update_mask
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_exclusion with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Logging::V2::ConfigServiceV2Client.exclusion_path("[PROJECT]", "[EXCLUSION]")
      exclusion = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::UpdateExclusionRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(exclusion, Google::Logging::V2::LogExclusion), request.exclusion)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:update_exclusion, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("update_exclusion")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.update_exclusion(
              formatted_name,
              exclusion,
              update_mask
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_exclusion' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Logging::V2::ConfigServiceV2Client#delete_exclusion."

    it 'invokes delete_exclusion without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Logging::V2::ConfigServiceV2Client.exclusion_path("[PROJECT]", "[EXCLUSION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::DeleteExclusionRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v2.new(:delete_exclusion, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("delete_exclusion")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          response = client.delete_exclusion(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_exclusion(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_exclusion with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Logging::V2::ConfigServiceV2Client.exclusion_path("[PROJECT]", "[EXCLUSION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Logging::V2::DeleteExclusionRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:delete_exclusion, mock_method)

      # Mock auth layer
      mock_credentials = MockConfigServiceV2Credentials_v2.new("delete_exclusion")

      Google::Logging::V2::ConfigServiceV2::Stub.stub(:new, mock_stub) do
        Google::Cloud::Logging::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Logging::Config.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.delete_exclusion(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end