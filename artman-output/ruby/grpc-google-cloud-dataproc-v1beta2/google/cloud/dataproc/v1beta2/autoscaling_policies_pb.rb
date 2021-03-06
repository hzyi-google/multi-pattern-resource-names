# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dataproc/v1beta2/autoscaling_policies.proto

require 'google/protobuf'

require 'google/api/annotations_pb'
require 'google/api/client_pb'
require 'google/api/field_behavior_pb'
require 'google/api/resource_pb'
require 'google/protobuf/duration_pb'
require 'google/protobuf/empty_pb'
Google::Protobuf::DescriptorPool.generated_pool.build do
  add_message "google.cloud.dataproc.v1beta2.AutoscalingPolicy" do
    optional :id, :string, 1
    optional :name, :string, 2
    optional :worker_config, :message, 4, "google.cloud.dataproc.v1beta2.InstanceGroupAutoscalingPolicyConfig"
    optional :secondary_worker_config, :message, 5, "google.cloud.dataproc.v1beta2.InstanceGroupAutoscalingPolicyConfig"
    oneof :algorithm do
      optional :basic_algorithm, :message, 3, "google.cloud.dataproc.v1beta2.BasicAutoscalingAlgorithm"
    end
  end
  add_message "google.cloud.dataproc.v1beta2.BasicAutoscalingAlgorithm" do
    optional :yarn_config, :message, 1, "google.cloud.dataproc.v1beta2.BasicYarnAutoscalingConfig"
    optional :cooldown_period, :message, 2, "google.protobuf.Duration"
  end
  add_message "google.cloud.dataproc.v1beta2.BasicYarnAutoscalingConfig" do
    optional :graceful_decommission_timeout, :message, 5, "google.protobuf.Duration"
    optional :scale_up_factor, :double, 1
    optional :scale_down_factor, :double, 2
    optional :scale_up_min_worker_fraction, :double, 3
    optional :scale_down_min_worker_fraction, :double, 4
  end
  add_message "google.cloud.dataproc.v1beta2.InstanceGroupAutoscalingPolicyConfig" do
    optional :min_instances, :int32, 1
    optional :max_instances, :int32, 2
    optional :weight, :int32, 3
  end
  add_message "google.cloud.dataproc.v1beta2.CreateAutoscalingPolicyRequest" do
    optional :parent, :string, 1
    optional :policy, :message, 2, "google.cloud.dataproc.v1beta2.AutoscalingPolicy"
  end
  add_message "google.cloud.dataproc.v1beta2.GetAutoscalingPolicyRequest" do
    optional :name, :string, 1
  end
  add_message "google.cloud.dataproc.v1beta2.UpdateAutoscalingPolicyRequest" do
    optional :policy, :message, 1, "google.cloud.dataproc.v1beta2.AutoscalingPolicy"
  end
  add_message "google.cloud.dataproc.v1beta2.DeleteAutoscalingPolicyRequest" do
    optional :name, :string, 1
  end
  add_message "google.cloud.dataproc.v1beta2.ListAutoscalingPoliciesRequest" do
    optional :parent, :string, 1
    optional :page_size, :int32, 2
    optional :page_token, :string, 3
  end
  add_message "google.cloud.dataproc.v1beta2.ListAutoscalingPoliciesResponse" do
    repeated :policies, :message, 1, "google.cloud.dataproc.v1beta2.AutoscalingPolicy"
    optional :next_page_token, :string, 2
  end
end

module Google
  module Cloud
    module Dataproc
      module V1beta2
        AutoscalingPolicy = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dataproc.v1beta2.AutoscalingPolicy").msgclass
        BasicAutoscalingAlgorithm = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dataproc.v1beta2.BasicAutoscalingAlgorithm").msgclass
        BasicYarnAutoscalingConfig = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dataproc.v1beta2.BasicYarnAutoscalingConfig").msgclass
        InstanceGroupAutoscalingPolicyConfig = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dataproc.v1beta2.InstanceGroupAutoscalingPolicyConfig").msgclass
        CreateAutoscalingPolicyRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dataproc.v1beta2.CreateAutoscalingPolicyRequest").msgclass
        GetAutoscalingPolicyRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dataproc.v1beta2.GetAutoscalingPolicyRequest").msgclass
        UpdateAutoscalingPolicyRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dataproc.v1beta2.UpdateAutoscalingPolicyRequest").msgclass
        DeleteAutoscalingPolicyRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dataproc.v1beta2.DeleteAutoscalingPolicyRequest").msgclass
        ListAutoscalingPoliciesRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dataproc.v1beta2.ListAutoscalingPoliciesRequest").msgclass
        ListAutoscalingPoliciesResponse = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.dataproc.v1beta2.ListAutoscalingPoliciesResponse").msgclass
      end
    end
  end
end
