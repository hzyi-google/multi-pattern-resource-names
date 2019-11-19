# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/talent/v4beta1/company_service.proto

require 'google/protobuf'

require 'google/api/annotations_pb'
require 'google/api/client_pb'
require 'google/api/field_behavior_pb'
require 'google/cloud/talent/v4beta1/common_pb'
require 'google/cloud/talent/v4beta1/company_pb'
require 'google/protobuf/empty_pb'
require 'google/protobuf/field_mask_pb'
Google::Protobuf::DescriptorPool.generated_pool.build do
  add_message "google.cloud.talent.v4beta1.CreateCompanyRequest" do
    optional :parent, :string, 1
    optional :company, :message, 2, "google.cloud.talent.v4beta1.Company"
  end
  add_message "google.cloud.talent.v4beta1.GetCompanyRequest" do
    optional :name, :string, 1
  end
  add_message "google.cloud.talent.v4beta1.UpdateCompanyRequest" do
    optional :company, :message, 1, "google.cloud.talent.v4beta1.Company"
    optional :update_mask, :message, 2, "google.protobuf.FieldMask"
  end
  add_message "google.cloud.talent.v4beta1.DeleteCompanyRequest" do
    optional :name, :string, 1
  end
  add_message "google.cloud.talent.v4beta1.ListCompaniesRequest" do
    optional :parent, :string, 1
    optional :page_token, :string, 2
    optional :page_size, :int32, 3
    optional :require_open_jobs, :bool, 4
  end
  add_message "google.cloud.talent.v4beta1.ListCompaniesResponse" do
    repeated :companies, :message, 1, "google.cloud.talent.v4beta1.Company"
    optional :next_page_token, :string, 2
    optional :metadata, :message, 3, "google.cloud.talent.v4beta1.ResponseMetadata"
  end
end

module Google
  module Cloud
    module Talent
      module V4beta1
        CreateCompanyRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.talent.v4beta1.CreateCompanyRequest").msgclass
        GetCompanyRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.talent.v4beta1.GetCompanyRequest").msgclass
        UpdateCompanyRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.talent.v4beta1.UpdateCompanyRequest").msgclass
        DeleteCompanyRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.talent.v4beta1.DeleteCompanyRequest").msgclass
        ListCompaniesRequest = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.talent.v4beta1.ListCompaniesRequest").msgclass
        ListCompaniesResponse = Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.talent.v4beta1.ListCompaniesResponse").msgclass
      end
    end
  end
end
