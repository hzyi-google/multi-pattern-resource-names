# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/containeranalysis/v1beta1/common/common.proto

require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_message "grafeas.v1beta1.RelatedUrl" do
    optional :url, :string, 1
    optional :label, :string, 2
  end
  add_message "grafeas.v1beta1.Signature" do
    optional :signature, :bytes, 1
    optional :public_key_id, :string, 2
  end
  add_enum "grafeas.v1beta1.NoteKind" do
    value :NOTE_KIND_UNSPECIFIED, 0
    value :VULNERABILITY, 1
    value :BUILD, 2
    value :IMAGE, 3
    value :PACKAGE, 4
    value :DEPLOYMENT, 5
    value :DISCOVERY, 6
    value :ATTESTATION, 7
  end
end

module Grafeas
  module V1beta1
    RelatedUrl = Google::Protobuf::DescriptorPool.generated_pool.lookup("grafeas.v1beta1.RelatedUrl").msgclass
    Signature = Google::Protobuf::DescriptorPool.generated_pool.lookup("grafeas.v1beta1.Signature").msgclass
    NoteKind = Google::Protobuf::DescriptorPool.generated_pool.lookup("grafeas.v1beta1.NoteKind").enummodule
  end
end
