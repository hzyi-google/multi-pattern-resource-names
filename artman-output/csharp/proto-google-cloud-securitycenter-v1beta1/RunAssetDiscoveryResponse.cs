// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1beta1/run_asset_discovery_response.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Securitycenter.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1beta1/run_asset_discovery_response.proto</summary>
  public static partial class RunAssetDiscoveryResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1beta1/run_asset_discovery_response.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RunAssetDiscoveryResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkZnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjFiZXRhMS9ydW5fYXNz",
            "ZXRfZGlzY292ZXJ5X3Jlc3BvbnNlLnByb3RvEiNnb29nbGUuY2xvdWQuc2Vj",
            "dXJpdHljZW50ZXIudjFiZXRhMRoeZ29vZ2xlL3Byb3RvYnVmL2R1cmF0aW9u",
            "LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIuwBChlSdW5B",
            "c3NldERpc2NvdmVyeVJlc3BvbnNlElMKBXN0YXRlGAEgASgOMkQuZ29vZ2xl",
            "LmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYxYmV0YTEuUnVuQXNzZXREaXNjb3Zl",
            "cnlSZXNwb25zZS5TdGF0ZRIrCghkdXJhdGlvbhgCIAEoCzIZLmdvb2dsZS5w",
            "cm90b2J1Zi5EdXJhdGlvbiJNCgVTdGF0ZRIVChFTVEFURV9VTlNQRUNJRklF",
            "RBAAEg0KCUNPTVBMRVRFRBABEg4KClNVUEVSU0VERUQQAhIOCgpURVJNSU5B",
            "VEVEEANCfgonY29tLmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci52MWJl",
            "dGExUAFaUWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "Y2xvdWQvc2VjdXJpdHljZW50ZXIvdjFiZXRhMTtzZWN1cml0eWNlbnRlcmIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Securitycenter.V1Beta1.RunAssetDiscoveryResponse), global::Google.Cloud.Securitycenter.V1Beta1.RunAssetDiscoveryResponse.Parser, new[]{ "State", "Duration" }, null, new[]{ typeof(global::Google.Cloud.Securitycenter.V1Beta1.RunAssetDiscoveryResponse.Types.State) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Response of asset discovery run
  /// </summary>
  public sealed partial class RunAssetDiscoveryResponse : pb::IMessage<RunAssetDiscoveryResponse> {
    private static readonly pb::MessageParser<RunAssetDiscoveryResponse> _parser = new pb::MessageParser<RunAssetDiscoveryResponse>(() => new RunAssetDiscoveryResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RunAssetDiscoveryResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Securitycenter.V1Beta1.RunAssetDiscoveryResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RunAssetDiscoveryResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RunAssetDiscoveryResponse(RunAssetDiscoveryResponse other) : this() {
      state_ = other.state_;
      duration_ = other.duration_ != null ? other.duration_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RunAssetDiscoveryResponse Clone() {
      return new RunAssetDiscoveryResponse(this);
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 1;
    private global::Google.Cloud.Securitycenter.V1Beta1.RunAssetDiscoveryResponse.Types.State state_ = global::Google.Cloud.Securitycenter.V1Beta1.RunAssetDiscoveryResponse.Types.State.Unspecified;
    /// <summary>
    /// The state of an asset discovery run.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Securitycenter.V1Beta1.RunAssetDiscoveryResponse.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Duration duration_;
    /// <summary>
    /// The duration between asset discovery run start and end
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RunAssetDiscoveryResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RunAssetDiscoveryResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (State != other.State) return false;
      if (!object.Equals(Duration, other.Duration)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (State != global::Google.Cloud.Securitycenter.V1Beta1.RunAssetDiscoveryResponse.Types.State.Unspecified) hash ^= State.GetHashCode();
      if (duration_ != null) hash ^= Duration.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (State != global::Google.Cloud.Securitycenter.V1Beta1.RunAssetDiscoveryResponse.Types.State.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) State);
      }
      if (duration_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Duration);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (State != global::Google.Cloud.Securitycenter.V1Beta1.RunAssetDiscoveryResponse.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (duration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Duration);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RunAssetDiscoveryResponse other) {
      if (other == null) {
        return;
      }
      if (other.State != global::Google.Cloud.Securitycenter.V1Beta1.RunAssetDiscoveryResponse.Types.State.Unspecified) {
        State = other.State;
      }
      if (other.duration_ != null) {
        if (duration_ == null) {
          Duration = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Duration.MergeFrom(other.Duration);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            State = (global::Google.Cloud.Securitycenter.V1Beta1.RunAssetDiscoveryResponse.Types.State) input.ReadEnum();
            break;
          }
          case 18: {
            if (duration_ == null) {
              Duration = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Duration);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the RunAssetDiscoveryResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The state of an asset discovery run.
      /// </summary>
      public enum State {
        /// <summary>
        /// Asset discovery run state was unspecified.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Asset discovery run completed successfully.
        /// </summary>
        [pbr::OriginalName("COMPLETED")] Completed = 1,
        /// <summary>
        /// Asset discovery run was cancelled with tasks still pending, as another
        /// run for the same organization was started with a higher priority.
        /// </summary>
        [pbr::OriginalName("SUPERSEDED")] Superseded = 2,
        /// <summary>
        /// Asset discovery run was killed and terminated.
        /// </summary>
        [pbr::OriginalName("TERMINATED")] Terminated = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
