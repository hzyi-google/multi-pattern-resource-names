# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/containeranalysis/v1beta1/cvss/cvss.proto

require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_message "grafeas.v1beta1.vulnerability.CVSSv3" do
    optional :base_score, :float, 1
    optional :exploitability_score, :float, 2
    optional :impact_score, :float, 3
    optional :attack_vector, :enum, 5, "grafeas.v1beta1.vulnerability.CVSSv3.AttackVector"
    optional :attack_complexity, :enum, 6, "grafeas.v1beta1.vulnerability.CVSSv3.AttackComplexity"
    optional :privileges_required, :enum, 7, "grafeas.v1beta1.vulnerability.CVSSv3.PrivilegesRequired"
    optional :user_interaction, :enum, 8, "grafeas.v1beta1.vulnerability.CVSSv3.UserInteraction"
    optional :scope, :enum, 9, "grafeas.v1beta1.vulnerability.CVSSv3.Scope"
    optional :confidentiality_impact, :enum, 10, "grafeas.v1beta1.vulnerability.CVSSv3.Impact"
    optional :integrity_impact, :enum, 11, "grafeas.v1beta1.vulnerability.CVSSv3.Impact"
    optional :availability_impact, :enum, 12, "grafeas.v1beta1.vulnerability.CVSSv3.Impact"
  end
  add_enum "grafeas.v1beta1.vulnerability.CVSSv3.AttackVector" do
    value :ATTACK_VECTOR_UNSPECIFIED, 0
    value :ATTACK_VECTOR_NETWORK, 1
    value :ATTACK_VECTOR_ADJACENT, 2
    value :ATTACK_VECTOR_LOCAL, 3
    value :ATTACK_VECTOR_PHYSICAL, 4
  end
  add_enum "grafeas.v1beta1.vulnerability.CVSSv3.AttackComplexity" do
    value :ATTACK_COMPLEXITY_UNSPECIFIED, 0
    value :ATTACK_COMPLEXITY_LOW, 1
    value :ATTACK_COMPLEXITY_HIGH, 2
  end
  add_enum "grafeas.v1beta1.vulnerability.CVSSv3.PrivilegesRequired" do
    value :PRIVILEGES_REQUIRED_UNSPECIFIED, 0
    value :PRIVILEGES_REQUIRED_NONE, 1
    value :PRIVILEGES_REQUIRED_LOW, 2
    value :PRIVILEGES_REQUIRED_HIGH, 3
  end
  add_enum "grafeas.v1beta1.vulnerability.CVSSv3.UserInteraction" do
    value :USER_INTERACTION_UNSPECIFIED, 0
    value :USER_INTERACTION_NONE, 1
    value :USER_INTERACTION_REQUIRED, 2
  end
  add_enum "grafeas.v1beta1.vulnerability.CVSSv3.Scope" do
    value :SCOPE_UNSPECIFIED, 0
    value :SCOPE_UNCHANGED, 1
    value :SCOPE_CHANGED, 2
  end
  add_enum "grafeas.v1beta1.vulnerability.CVSSv3.Impact" do
    value :IMPACT_UNSPECIFIED, 0
    value :IMPACT_HIGH, 1
    value :IMPACT_LOW, 2
    value :IMPACT_NONE, 3
  end
end

module Grafeas
  module V1beta1
    module Vulnerability
      CVSSv3 = Google::Protobuf::DescriptorPool.generated_pool.lookup("grafeas.v1beta1.vulnerability.CVSSv3").msgclass
      CVSSv3::AttackVector = Google::Protobuf::DescriptorPool.generated_pool.lookup("grafeas.v1beta1.vulnerability.CVSSv3.AttackVector").enummodule
      CVSSv3::AttackComplexity = Google::Protobuf::DescriptorPool.generated_pool.lookup("grafeas.v1beta1.vulnerability.CVSSv3.AttackComplexity").enummodule
      CVSSv3::PrivilegesRequired = Google::Protobuf::DescriptorPool.generated_pool.lookup("grafeas.v1beta1.vulnerability.CVSSv3.PrivilegesRequired").enummodule
      CVSSv3::UserInteraction = Google::Protobuf::DescriptorPool.generated_pool.lookup("grafeas.v1beta1.vulnerability.CVSSv3.UserInteraction").enummodule
      CVSSv3::Scope = Google::Protobuf::DescriptorPool.generated_pool.lookup("grafeas.v1beta1.vulnerability.CVSSv3.Scope").enummodule
      CVSSv3::Impact = Google::Protobuf::DescriptorPool.generated_pool.lookup("grafeas.v1beta1.vulnerability.CVSSv3.Impact").enummodule
    end
  end
end
