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

require "google/cloud/devtools/containeranalysis"
require "google/cloud/devtools/containeranalysis/v1beta1/container_analysis_v1_beta1_client"
require "google/devtools/containeranalysis/v1beta1/containeranalysis_services_pb"

class CustomTestError_v1beta1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1beta1

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

class MockContainerAnalysisV1Beta1Credentials_v1beta1 < Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials
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

describe Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client do

  describe 'set_iam_policy' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client#set_iam_policy."

    it 'invokes set_iam_policy without error' do
      # Create request parameters
      formatted_resource = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.note_path("[PROJECT]", "[NOTE]")
      policy = {}

      # Create expected grpc response
      version = 351608024
      etag = "21"
      expected_response = { version: version, etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1::Policy)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1::SetIamPolicyRequest, request)
        assert_equal(formatted_resource, request.resource)
        assert_equal(Google::Gax::to_proto(policy, Google::Iam::V1::Policy), request.policy)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:set_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockContainerAnalysisV1Beta1Credentials_v1beta1.new("set_iam_policy")

      Google::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)

          # Call method
          response = client.set_iam_policy(formatted_resource, policy)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.set_iam_policy(formatted_resource, policy) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes set_iam_policy with error' do
      # Create request parameters
      formatted_resource = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.note_path("[PROJECT]", "[NOTE]")
      policy = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1::SetIamPolicyRequest, request)
        assert_equal(formatted_resource, request.resource)
        assert_equal(Google::Gax::to_proto(policy, Google::Iam::V1::Policy), request.policy)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:set_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockContainerAnalysisV1Beta1Credentials_v1beta1.new("set_iam_policy")

      Google::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.set_iam_policy(formatted_resource, policy)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_iam_policy' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client#get_iam_policy."

    it 'invokes get_iam_policy without error' do
      # Create request parameters
      formatted_resource = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.note_path("[PROJECT]", "[NOTE]")

      # Create expected grpc response
      version = 351608024
      etag = "21"
      expected_response = { version: version, etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1::Policy)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1::GetIamPolicyRequest, request)
        assert_equal(formatted_resource, request.resource)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockContainerAnalysisV1Beta1Credentials_v1beta1.new("get_iam_policy")

      Google::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)

          # Call method
          response = client.get_iam_policy(formatted_resource)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_iam_policy(formatted_resource) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_iam_policy with error' do
      # Create request parameters
      formatted_resource = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.note_path("[PROJECT]", "[NOTE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1::GetIamPolicyRequest, request)
        assert_equal(formatted_resource, request.resource)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_iam_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockContainerAnalysisV1Beta1Credentials_v1beta1.new("get_iam_policy")

      Google::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_iam_policy(formatted_resource)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'test_iam_permissions' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client#test_iam_permissions."

    it 'invokes test_iam_permissions without error' do
      # Create request parameters
      formatted_resource = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.note_path("[PROJECT]", "[NOTE]")
      permissions = []

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::V1::TestIamPermissionsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1::TestIamPermissionsRequest, request)
        assert_equal(formatted_resource, request.resource)
        assert_equal(permissions, request.permissions)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:test_iam_permissions, mock_method)

      # Mock auth layer
      mock_credentials = MockContainerAnalysisV1Beta1Credentials_v1beta1.new("test_iam_permissions")

      Google::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)

          # Call method
          response = client.test_iam_permissions(formatted_resource, permissions)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.test_iam_permissions(formatted_resource, permissions) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes test_iam_permissions with error' do
      # Create request parameters
      formatted_resource = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.note_path("[PROJECT]", "[NOTE]")
      permissions = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::V1::TestIamPermissionsRequest, request)
        assert_equal(formatted_resource, request.resource)
        assert_equal(permissions, request.permissions)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:test_iam_permissions, mock_method)

      # Mock auth layer
      mock_credentials = MockContainerAnalysisV1Beta1Credentials_v1beta1.new("test_iam_permissions")

      Google::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.test_iam_permissions(formatted_resource, permissions)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_scan_config' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client#get_scan_config."

    it 'invokes get_scan_config without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      enabled = false
      expected_response = {
        name: name_2,
        description: description,
        enabled: enabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Devtools::Containeranalysis::V1beta1::ScanConfig)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Devtools::Containeranalysis::V1beta1::GetScanConfigRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_scan_config, mock_method)

      # Mock auth layer
      mock_credentials = MockContainerAnalysisV1Beta1Credentials_v1beta1.new("get_scan_config")

      Google::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)

          # Call method
          response = client.get_scan_config(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_scan_config(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_scan_config with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Devtools::Containeranalysis::V1beta1::GetScanConfigRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_scan_config, mock_method)

      # Mock auth layer
      mock_credentials = MockContainerAnalysisV1Beta1Credentials_v1beta1.new("get_scan_config")

      Google::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_scan_config(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_scan_configs' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client#list_scan_configs."

    it 'invokes list_scan_configs without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.project_path("[PROJECT]")

      # Create expected grpc response
      next_page_token = ""
      scan_configs_element = {}
      scan_configs = [scan_configs_element]
      expected_response = { next_page_token: next_page_token, scan_configs: scan_configs }
      expected_response = Google::Gax::to_proto(expected_response, Google::Devtools::Containeranalysis::V1beta1::ListScanConfigsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Devtools::Containeranalysis::V1beta1::ListScanConfigsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_scan_configs, mock_method)

      # Mock auth layer
      mock_credentials = MockContainerAnalysisV1Beta1Credentials_v1beta1.new("list_scan_configs")

      Google::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)

          # Call method
          response = client.list_scan_configs(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.scan_configs.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_scan_configs with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.project_path("[PROJECT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Devtools::Containeranalysis::V1beta1::ListScanConfigsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_scan_configs, mock_method)

      # Mock auth layer
      mock_credentials = MockContainerAnalysisV1Beta1Credentials_v1beta1.new("list_scan_configs")

      Google::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_scan_configs(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_scan_config' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client#update_scan_config."

    it 'invokes update_scan_config without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")
      scan_config = {}

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      enabled = false
      expected_response = {
        name: name_2,
        description: description,
        enabled: enabled
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Devtools::Containeranalysis::V1beta1::ScanConfig)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Devtools::Containeranalysis::V1beta1::UpdateScanConfigRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(scan_config, Google::Devtools::Containeranalysis::V1beta1::ScanConfig), request.scan_config)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_scan_config, mock_method)

      # Mock auth layer
      mock_credentials = MockContainerAnalysisV1Beta1Credentials_v1beta1.new("update_scan_config")

      Google::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)

          # Call method
          response = client.update_scan_config(formatted_name, scan_config)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_scan_config(formatted_name, scan_config) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_scan_config with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1Client.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")
      scan_config = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Devtools::Containeranalysis::V1beta1::UpdateScanConfigRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(scan_config, Google::Devtools::Containeranalysis::V1beta1::ScanConfig), request.scan_config)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_scan_config, mock_method)

      # Mock auth layer
      mock_credentials = MockContainerAnalysisV1Beta1Credentials_v1beta1.new("update_scan_config")

      Google::Devtools::Containeranalysis::V1beta1::ContainerAnalysisV1Beta1::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Containeranalysis::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Containeranalysis::ContainerAnalysisV1Beta1.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_scan_config(formatted_name, scan_config)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end