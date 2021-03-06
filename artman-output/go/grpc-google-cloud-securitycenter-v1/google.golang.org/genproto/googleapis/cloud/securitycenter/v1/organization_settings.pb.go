// Code generated by protoc-gen-go. DO NOT EDIT.
// source: google/cloud/securitycenter/v1/organization_settings.proto

package securitycenter

import (
	fmt "fmt"
	proto "github.com/golang/protobuf/proto"
	_ "google.golang.org/genproto/googleapis/api/annotations"
	math "math"
)

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

// This is a compile-time assertion to ensure that this generated file
// is compatible with the proto package it is being compiled against.
// A compilation error at this line likely means your copy of the
// proto package needs to be updated.
const _ = proto.ProtoPackageIsVersion3 // please upgrade the proto package

// The mode of inclusion when running Asset Discovery.
// Asset discovery can be limited by explicitly identifying projects to be
// included or excluded. If INCLUDE_ONLY is set, then only those projects
// within the organization and their children are discovered during asset
// discovery. If EXCLUDE is set, then projects that don't match those
// projects are discovered during asset discovery. If neither are set, then
// all projects within the organization are discovered during asset
// discovery.
type OrganizationSettings_AssetDiscoveryConfig_InclusionMode int32

const (
	// Unspecified. Setting the mode with this value will disable
	// inclusion/exclusion filtering for Asset Discovery.
	OrganizationSettings_AssetDiscoveryConfig_INCLUSION_MODE_UNSPECIFIED OrganizationSettings_AssetDiscoveryConfig_InclusionMode = 0
	// Asset Discovery will capture only the resources within the projects
	// specified. All other resources will be ignored.
	OrganizationSettings_AssetDiscoveryConfig_INCLUDE_ONLY OrganizationSettings_AssetDiscoveryConfig_InclusionMode = 1
	// Asset Discovery will ignore all resources under the projects specified.
	// All other resources will be retrieved.
	OrganizationSettings_AssetDiscoveryConfig_EXCLUDE OrganizationSettings_AssetDiscoveryConfig_InclusionMode = 2
)

var OrganizationSettings_AssetDiscoveryConfig_InclusionMode_name = map[int32]string{
	0: "INCLUSION_MODE_UNSPECIFIED",
	1: "INCLUDE_ONLY",
	2: "EXCLUDE",
}

var OrganizationSettings_AssetDiscoveryConfig_InclusionMode_value = map[string]int32{
	"INCLUSION_MODE_UNSPECIFIED": 0,
	"INCLUDE_ONLY":               1,
	"EXCLUDE":                    2,
}

func (x OrganizationSettings_AssetDiscoveryConfig_InclusionMode) String() string {
	return proto.EnumName(OrganizationSettings_AssetDiscoveryConfig_InclusionMode_name, int32(x))
}

func (OrganizationSettings_AssetDiscoveryConfig_InclusionMode) EnumDescriptor() ([]byte, []int) {
	return fileDescriptor_9f5c7b1e9f2f4088, []int{0, 0, 0}
}

// User specified settings that are attached to the Cloud Security Command
// Center (Cloud SCC) organization.
type OrganizationSettings struct {
	// The relative resource name of the settings. See:
	// https://cloud.google.com/apis/design/resource_names#relative_resource_name
	// Example:
	// "organizations/{organization_id}/organizationSettings".
	Name string `protobuf:"bytes,1,opt,name=name,proto3" json:"name,omitempty"`
	// A flag that indicates if Asset Discovery should be enabled. If the flag is
	// set to `true`, then discovery of assets will occur. If it is set to `false,
	// all historical assets will remain, but discovery of future assets will not
	// occur.
	EnableAssetDiscovery bool `protobuf:"varint,2,opt,name=enable_asset_discovery,json=enableAssetDiscovery,proto3" json:"enable_asset_discovery,omitempty"`
	// The configuration used for Asset Discovery runs.
	AssetDiscoveryConfig *OrganizationSettings_AssetDiscoveryConfig `protobuf:"bytes,3,opt,name=asset_discovery_config,json=assetDiscoveryConfig,proto3" json:"asset_discovery_config,omitempty"`
	XXX_NoUnkeyedLiteral struct{}                                   `json:"-"`
	XXX_unrecognized     []byte                                     `json:"-"`
	XXX_sizecache        int32                                      `json:"-"`
}

func (m *OrganizationSettings) Reset()         { *m = OrganizationSettings{} }
func (m *OrganizationSettings) String() string { return proto.CompactTextString(m) }
func (*OrganizationSettings) ProtoMessage()    {}
func (*OrganizationSettings) Descriptor() ([]byte, []int) {
	return fileDescriptor_9f5c7b1e9f2f4088, []int{0}
}

func (m *OrganizationSettings) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_OrganizationSettings.Unmarshal(m, b)
}
func (m *OrganizationSettings) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_OrganizationSettings.Marshal(b, m, deterministic)
}
func (m *OrganizationSettings) XXX_Merge(src proto.Message) {
	xxx_messageInfo_OrganizationSettings.Merge(m, src)
}
func (m *OrganizationSettings) XXX_Size() int {
	return xxx_messageInfo_OrganizationSettings.Size(m)
}
func (m *OrganizationSettings) XXX_DiscardUnknown() {
	xxx_messageInfo_OrganizationSettings.DiscardUnknown(m)
}

var xxx_messageInfo_OrganizationSettings proto.InternalMessageInfo

func (m *OrganizationSettings) GetName() string {
	if m != nil {
		return m.Name
	}
	return ""
}

func (m *OrganizationSettings) GetEnableAssetDiscovery() bool {
	if m != nil {
		return m.EnableAssetDiscovery
	}
	return false
}

func (m *OrganizationSettings) GetAssetDiscoveryConfig() *OrganizationSettings_AssetDiscoveryConfig {
	if m != nil {
		return m.AssetDiscoveryConfig
	}
	return nil
}

// The configuration used for Asset Discovery runs.
type OrganizationSettings_AssetDiscoveryConfig struct {
	// The project ids to use for filtering asset discovery.
	ProjectIds []string `protobuf:"bytes,1,rep,name=project_ids,json=projectIds,proto3" json:"project_ids,omitempty"`
	// The mode to use for filtering asset discovery.
	InclusionMode        OrganizationSettings_AssetDiscoveryConfig_InclusionMode `protobuf:"varint,2,opt,name=inclusion_mode,json=inclusionMode,proto3,enum=google.cloud.securitycenter.v1.OrganizationSettings_AssetDiscoveryConfig_InclusionMode" json:"inclusion_mode,omitempty"`
	XXX_NoUnkeyedLiteral struct{}                                                `json:"-"`
	XXX_unrecognized     []byte                                                  `json:"-"`
	XXX_sizecache        int32                                                   `json:"-"`
}

func (m *OrganizationSettings_AssetDiscoveryConfig) Reset() {
	*m = OrganizationSettings_AssetDiscoveryConfig{}
}
func (m *OrganizationSettings_AssetDiscoveryConfig) String() string { return proto.CompactTextString(m) }
func (*OrganizationSettings_AssetDiscoveryConfig) ProtoMessage()    {}
func (*OrganizationSettings_AssetDiscoveryConfig) Descriptor() ([]byte, []int) {
	return fileDescriptor_9f5c7b1e9f2f4088, []int{0, 0}
}

func (m *OrganizationSettings_AssetDiscoveryConfig) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_OrganizationSettings_AssetDiscoveryConfig.Unmarshal(m, b)
}
func (m *OrganizationSettings_AssetDiscoveryConfig) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_OrganizationSettings_AssetDiscoveryConfig.Marshal(b, m, deterministic)
}
func (m *OrganizationSettings_AssetDiscoveryConfig) XXX_Merge(src proto.Message) {
	xxx_messageInfo_OrganizationSettings_AssetDiscoveryConfig.Merge(m, src)
}
func (m *OrganizationSettings_AssetDiscoveryConfig) XXX_Size() int {
	return xxx_messageInfo_OrganizationSettings_AssetDiscoveryConfig.Size(m)
}
func (m *OrganizationSettings_AssetDiscoveryConfig) XXX_DiscardUnknown() {
	xxx_messageInfo_OrganizationSettings_AssetDiscoveryConfig.DiscardUnknown(m)
}

var xxx_messageInfo_OrganizationSettings_AssetDiscoveryConfig proto.InternalMessageInfo

func (m *OrganizationSettings_AssetDiscoveryConfig) GetProjectIds() []string {
	if m != nil {
		return m.ProjectIds
	}
	return nil
}

func (m *OrganizationSettings_AssetDiscoveryConfig) GetInclusionMode() OrganizationSettings_AssetDiscoveryConfig_InclusionMode {
	if m != nil {
		return m.InclusionMode
	}
	return OrganizationSettings_AssetDiscoveryConfig_INCLUSION_MODE_UNSPECIFIED
}

func init() {
	proto.RegisterEnum("google.cloud.securitycenter.v1.OrganizationSettings_AssetDiscoveryConfig_InclusionMode", OrganizationSettings_AssetDiscoveryConfig_InclusionMode_name, OrganizationSettings_AssetDiscoveryConfig_InclusionMode_value)
	proto.RegisterType((*OrganizationSettings)(nil), "google.cloud.securitycenter.v1.OrganizationSettings")
	proto.RegisterType((*OrganizationSettings_AssetDiscoveryConfig)(nil), "google.cloud.securitycenter.v1.OrganizationSettings.AssetDiscoveryConfig")
}

func init() {
	proto.RegisterFile("google/cloud/securitycenter/v1/organization_settings.proto", fileDescriptor_9f5c7b1e9f2f4088)
}

var fileDescriptor_9f5c7b1e9f2f4088 = []byte{
	// 481 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0xff, 0xac, 0x53, 0xcf, 0x8a, 0xd3, 0x40,
	0x18, 0x37, 0xdd, 0x45, 0xdd, 0xa9, 0xbb, 0x94, 0xa1, 0x2c, 0xb5, 0x48, 0xad, 0x3d, 0xf5, 0x34,
	0x21, 0xd5, 0x53, 0x3c, 0xad, 0x69, 0x94, 0x40, 0x37, 0x5d, 0x52, 0xb6, 0xfe, 0xa1, 0x10, 0x66,
	0x27, 0xe3, 0x30, 0x4b, 0x3a, 0x5f, 0xc9, 0xa4, 0x85, 0x55, 0xd4, 0xa3, 0xef, 0xe2, 0xa3, 0xf8,
	0x02, 0x82, 0x8f, 0xb0, 0x4f, 0x21, 0x3b, 0x49, 0x31, 0x59, 0xaa, 0x5e, 0xbc, 0x65, 0xbe, 0xdf,
	0xdf, 0x49, 0xbe, 0x20, 0x57, 0x00, 0x88, 0x94, 0xdb, 0x2c, 0x85, 0x75, 0x62, 0x6b, 0xce, 0xd6,
	0x99, 0xcc, 0xaf, 0x18, 0x57, 0x39, 0xcf, 0xec, 0x8d, 0x63, 0x43, 0x26, 0xa8, 0x92, 0x1f, 0x68,
	0x2e, 0x41, 0xc5, 0x9a, 0xe7, 0xb9, 0x54, 0x42, 0x93, 0x55, 0x06, 0x39, 0xe0, 0x5e, 0xa1, 0x25,
	0x46, 0x4b, 0xea, 0x5a, 0xb2, 0x71, 0xba, 0x8f, 0x4a, 0x6f, 0xba, 0x92, 0x36, 0x55, 0x0a, 0x72,
	0xe3, 0x52, 0xaa, 0xbb, 0x0f, 0x2b, 0x68, 0xc6, 0x35, 0xac, 0x33, 0xc6, 0x0b, 0x68, 0xf0, 0x63,
	0x1f, 0xb5, 0xa7, 0x95, 0xe0, 0x59, 0x99, 0x8b, 0x31, 0xda, 0x57, 0x74, 0xc9, 0x3b, 0x56, 0xdf,
	0x1a, 0x1e, 0x44, 0xe6, 0x19, 0x3f, 0x43, 0xc7, 0x5c, 0xd1, 0x8b, 0x94, 0xc7, 0x54, 0x6b, 0x9e,
	0xc7, 0x89, 0xd4, 0x0c, 0x36, 0x3c, 0xbb, 0xea, 0x34, 0xfa, 0xd6, 0xf0, 0x7e, 0xd4, 0x2e, 0xd0,
	0x93, 0x1b, 0x70, 0xbc, 0xc5, 0xf0, 0x17, 0x74, 0x7c, 0x8b, 0x1e, 0x33, 0x50, 0xef, 0xa5, 0xe8,
	0xec, 0xf5, 0xad, 0x61, 0x73, 0x14, 0x90, 0xbf, 0x5f, 0x8e, 0xec, 0xea, 0x47, 0xea, 0x21, 0x9e,
	0x31, 0x8c, 0xda, 0x74, 0xc7, 0xb4, 0xfb, 0xb5, 0x81, 0xda, 0xbb, 0xe8, 0xf8, 0x31, 0x6a, 0xae,
	0x32, 0xb8, 0xe4, 0x2c, 0x8f, 0x65, 0xa2, 0x3b, 0x56, 0x7f, 0x6f, 0x78, 0x10, 0xa1, 0x72, 0x14,
	0x24, 0x1a, 0x7f, 0x46, 0x47, 0x52, 0xb1, 0x74, 0xad, 0x6f, 0x3e, 0xc9, 0x12, 0x12, 0x6e, 0x2e,
	0x7a, 0x34, 0x7a, 0xfd, 0xdf, 0x2a, 0x93, 0x60, 0xeb, 0x7f, 0x0a, 0x09, 0x8f, 0x0e, 0x65, 0xf5,
	0x38, 0x08, 0xd1, 0x61, 0x0d, 0xc7, 0x3d, 0xd4, 0x0d, 0x42, 0x6f, 0x72, 0x3e, 0x0b, 0xa6, 0x61,
	0x7c, 0x3a, 0x1d, 0xfb, 0xf1, 0x79, 0x38, 0x3b, 0xf3, 0xbd, 0xe0, 0x65, 0xe0, 0x8f, 0x5b, 0x77,
	0x70, 0x0b, 0x3d, 0x30, 0xf8, 0xd8, 0x8f, 0xa7, 0xe1, 0xe4, 0x6d, 0xcb, 0xc2, 0x4d, 0x74, 0xcf,
	0x7f, 0x63, 0x26, 0xad, 0x86, 0x7b, 0x79, 0x7d, 0x22, 0xd0, 0xe8, 0x56, 0xdd, 0xe2, 0x2a, 0x74,
	0x25, 0x35, 0x61, 0xb0, 0xb4, 0x77, 0x6e, 0x83, 0x53, 0x5d, 0x4e, 0x6d, 0x7f, 0xac, 0x1e, 0x3f,
	0xd5, 0x36, 0x77, 0x2b, 0x79, 0xf1, 0xd3, 0x42, 0x03, 0x06, 0xcb, 0x7f, 0xbc, 0xa9, 0x33, 0xeb,
	0xdd, 0xa4, 0x64, 0x08, 0x48, 0xa9, 0x12, 0x04, 0x32, 0x61, 0x0b, 0xae, 0xcc, 0x7a, 0xda, 0xbf,
	0xbb, 0xfd, 0xe9, 0xb7, 0x79, 0x5e, 0x9f, 0x7c, 0x6b, 0xf4, 0x5e, 0x15, 0x76, 0x9e, 0x09, 0x9c,
	0x95, 0xa8, 0x57, 0x04, 0xce, 0x9d, 0xef, 0x5b, 0xc2, 0xc2, 0x10, 0x16, 0x75, 0xc2, 0x62, 0xee,
	0x5c, 0x37, 0x9e, 0x14, 0x04, 0xd7, 0x35, 0x0c, 0xd7, 0xad, 0x53, 0x5c, 0x77, 0xee, 0x5c, 0xdc,
	0x35, 0xf5, 0x9e, 0xfe, 0x0a, 0x00, 0x00, 0xff, 0xff, 0x6c, 0xcd, 0x64, 0xa3, 0xd4, 0x03, 0x00,
	0x00,
}
