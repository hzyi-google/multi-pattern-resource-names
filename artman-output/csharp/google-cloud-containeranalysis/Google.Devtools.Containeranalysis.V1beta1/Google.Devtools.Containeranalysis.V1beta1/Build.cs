// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/devtools/containeranalysis/v1beta1/build/build.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grafeas.V1Beta1.Build {

  /// <summary>Holder for reflection information generated from google/devtools/containeranalysis/v1beta1/build/build.proto</summary>
  public static partial class BuildReflection {

    #region Descriptor
    /// <summary>File descriptor for google/devtools/containeranalysis/v1beta1/build/build.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuildReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvZGV2dG9vbHMvY29udGFpbmVyYW5hbHlzaXMvdjFiZXRhMS9i",
            "dWlsZC9idWlsZC5wcm90bxIVZ3JhZmVhcy52MWJldGExLmJ1aWxkGkVnb29n",
            "bGUvZGV2dG9vbHMvY29udGFpbmVyYW5hbHlzaXMvdjFiZXRhMS9wcm92ZW5h",
            "bmNlL3Byb3ZlbmFuY2UucHJvdG8iWgoFQnVpbGQSFwoPYnVpbGRlcl92ZXJz",
            "aW9uGAEgASgJEjgKCXNpZ25hdHVyZRgCIAEoCzIlLmdyYWZlYXMudjFiZXRh",
            "MS5idWlsZC5CdWlsZFNpZ25hdHVyZSLSAQoOQnVpbGRTaWduYXR1cmUSEgoK",
            "cHVibGljX2tleRgBIAEoCRIRCglzaWduYXR1cmUYAiABKAwSDgoGa2V5X2lk",
            "GAMgASgJEj8KCGtleV90eXBlGAQgASgOMi0uZ3JhZmVhcy52MWJldGExLmJ1",
            "aWxkLkJ1aWxkU2lnbmF0dXJlLktleVR5cGUiSAoHS2V5VHlwZRIYChRLRVlf",
            "VFlQRV9VTlNQRUNJRklFRBAAEhUKEVBHUF9BU0NJSV9BUk1PUkVEEAESDAoI",
            "UEtJWF9QRU0QAiJkCgdEZXRhaWxzEj8KCnByb3ZlbmFuY2UYASABKAsyKy5n",
            "cmFmZWFzLnYxYmV0YTEucHJvdmVuYW5jZS5CdWlsZFByb3ZlbmFuY2USGAoQ",
            "cHJvdmVuYW5jZV9ieXRlcxgCIAEoCUJ4Chhpby5ncmFmZWFzLnYxYmV0YTEu",
            "YnVpbGRQAVpUZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBp",
            "cy9kZXZ0b29scy9jb250YWluZXJhbmFseXNpcy92MWJldGExL2J1aWxkO2J1",
            "aWxkogIDR1JBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Grafeas.V1Beta1.Provenance.ProvenanceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1Beta1.Build.Build), global::Grafeas.V1Beta1.Build.Build.Parser, new[]{ "BuilderVersion", "Signature" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1Beta1.Build.BuildSignature), global::Grafeas.V1Beta1.Build.BuildSignature.Parser, new[]{ "PublicKey", "Signature", "KeyId", "KeyType" }, null, new[]{ typeof(global::Grafeas.V1Beta1.Build.BuildSignature.Types.KeyType) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1Beta1.Build.Details), global::Grafeas.V1Beta1.Build.Details.Parser, new[]{ "Provenance", "ProvenanceBytes" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Note holding the version of the provider's builder and the signature of the
  /// provenance message in the build details occurrence.
  /// </summary>
  public sealed partial class Build : pb::IMessage<Build> {
    private static readonly pb::MessageParser<Build> _parser = new pb::MessageParser<Build>(() => new Build());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Build> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1Beta1.Build.BuildReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Build() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Build(Build other) : this() {
      builderVersion_ = other.builderVersion_;
      signature_ = other.signature_ != null ? other.signature_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Build Clone() {
      return new Build(this);
    }

    /// <summary>Field number for the "builder_version" field.</summary>
    public const int BuilderVersionFieldNumber = 1;
    private string builderVersion_ = "";
    /// <summary>
    /// Required. Immutable. Version of the builder which produced this build.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BuilderVersion {
      get { return builderVersion_; }
      set {
        builderVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 2;
    private global::Grafeas.V1Beta1.Build.BuildSignature signature_;
    /// <summary>
    /// Signature of the build in occurrences pointing to this build note
    /// containing build details.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grafeas.V1Beta1.Build.BuildSignature Signature {
      get { return signature_; }
      set {
        signature_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Build);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Build other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BuilderVersion != other.BuilderVersion) return false;
      if (!object.Equals(Signature, other.Signature)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BuilderVersion.Length != 0) hash ^= BuilderVersion.GetHashCode();
      if (signature_ != null) hash ^= Signature.GetHashCode();
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
      if (BuilderVersion.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BuilderVersion);
      }
      if (signature_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Signature);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BuilderVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuilderVersion);
      }
      if (signature_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Signature);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Build other) {
      if (other == null) {
        return;
      }
      if (other.BuilderVersion.Length != 0) {
        BuilderVersion = other.BuilderVersion;
      }
      if (other.signature_ != null) {
        if (signature_ == null) {
          Signature = new global::Grafeas.V1Beta1.Build.BuildSignature();
        }
        Signature.MergeFrom(other.Signature);
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
          case 10: {
            BuilderVersion = input.ReadString();
            break;
          }
          case 18: {
            if (signature_ == null) {
              Signature = new global::Grafeas.V1Beta1.Build.BuildSignature();
            }
            input.ReadMessage(Signature);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Message encapsulating the signature of the verified build.
  /// </summary>
  public sealed partial class BuildSignature : pb::IMessage<BuildSignature> {
    private static readonly pb::MessageParser<BuildSignature> _parser = new pb::MessageParser<BuildSignature>(() => new BuildSignature());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BuildSignature> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1Beta1.Build.BuildReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildSignature() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildSignature(BuildSignature other) : this() {
      publicKey_ = other.publicKey_;
      signature_ = other.signature_;
      keyId_ = other.keyId_;
      keyType_ = other.keyType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BuildSignature Clone() {
      return new BuildSignature(this);
    }

    /// <summary>Field number for the "public_key" field.</summary>
    public const int PublicKeyFieldNumber = 1;
    private string publicKey_ = "";
    /// <summary>
    /// Public key of the builder which can be used to verify that the related
    /// findings are valid and unchanged. If `key_type` is empty, this defaults
    /// to PEM encoded public keys.
    ///
    /// This field may be empty if `key_id` references an external key.
    ///
    /// For Cloud Build based signatures, this is a PEM encoded public
    /// key. To verify the Cloud Build signature, place the contents of
    /// this field into a file (public.pem). The signature field is base64-decoded
    /// into its binary representation in signature.bin, and the provenance bytes
    /// from `BuildDetails` are base64-decoded into a binary representation in
    /// signed.bin. OpenSSL can then verify the signature:
    /// `openssl sha256 -verify public.pem -signature signature.bin signed.bin`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PublicKey {
      get { return publicKey_; }
      set {
        publicKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 2;
    private pb::ByteString signature_ = pb::ByteString.Empty;
    /// <summary>
    /// Required. Signature of the related `BuildProvenance`. In JSON, this is
    /// base-64 encoded.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "key_id" field.</summary>
    public const int KeyIdFieldNumber = 3;
    private string keyId_ = "";
    /// <summary>
    /// An ID for the key used to sign. This could be either an ID for the key
    /// stored in `public_key` (such as the ID or fingerprint for a PGP key, or the
    /// CN for a cert), or a reference to an external key (such as a reference to a
    /// key in Cloud Key Management Service).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KeyId {
      get { return keyId_; }
      set {
        keyId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "key_type" field.</summary>
    public const int KeyTypeFieldNumber = 4;
    private global::Grafeas.V1Beta1.Build.BuildSignature.Types.KeyType keyType_ = global::Grafeas.V1Beta1.Build.BuildSignature.Types.KeyType.Unspecified;
    /// <summary>
    /// The type of the key, either stored in `public_key` or referenced in
    /// `key_id`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grafeas.V1Beta1.Build.BuildSignature.Types.KeyType KeyType {
      get { return keyType_; }
      set {
        keyType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BuildSignature);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BuildSignature other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PublicKey != other.PublicKey) return false;
      if (Signature != other.Signature) return false;
      if (KeyId != other.KeyId) return false;
      if (KeyType != other.KeyType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PublicKey.Length != 0) hash ^= PublicKey.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      if (KeyId.Length != 0) hash ^= KeyId.GetHashCode();
      if (KeyType != global::Grafeas.V1Beta1.Build.BuildSignature.Types.KeyType.Unspecified) hash ^= KeyType.GetHashCode();
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
      if (PublicKey.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PublicKey);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Signature);
      }
      if (KeyId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(KeyId);
      }
      if (KeyType != global::Grafeas.V1Beta1.Build.BuildSignature.Types.KeyType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) KeyType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PublicKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PublicKey);
      }
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Signature);
      }
      if (KeyId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KeyId);
      }
      if (KeyType != global::Grafeas.V1Beta1.Build.BuildSignature.Types.KeyType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) KeyType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BuildSignature other) {
      if (other == null) {
        return;
      }
      if (other.PublicKey.Length != 0) {
        PublicKey = other.PublicKey;
      }
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      if (other.KeyId.Length != 0) {
        KeyId = other.KeyId;
      }
      if (other.KeyType != global::Grafeas.V1Beta1.Build.BuildSignature.Types.KeyType.Unspecified) {
        KeyType = other.KeyType;
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
          case 10: {
            PublicKey = input.ReadString();
            break;
          }
          case 18: {
            Signature = input.ReadBytes();
            break;
          }
          case 26: {
            KeyId = input.ReadString();
            break;
          }
          case 32: {
            KeyType = (global::Grafeas.V1Beta1.Build.BuildSignature.Types.KeyType) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BuildSignature message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Public key formats.
      /// </summary>
      public enum KeyType {
        /// <summary>
        /// `KeyType` is not set.
        /// </summary>
        [pbr::OriginalName("KEY_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// `PGP ASCII Armored` public key.
        /// </summary>
        [pbr::OriginalName("PGP_ASCII_ARMORED")] PgpAsciiArmored = 1,
        /// <summary>
        /// `PKIX PEM` public key.
        /// </summary>
        [pbr::OriginalName("PKIX_PEM")] PkixPem = 2,
      }

    }
    #endregion

  }

  /// <summary>
  /// Details of a build occurrence.
  /// </summary>
  public sealed partial class Details : pb::IMessage<Details> {
    private static readonly pb::MessageParser<Details> _parser = new pb::MessageParser<Details>(() => new Details());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Details> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1Beta1.Build.BuildReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Details() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Details(Details other) : this() {
      provenance_ = other.provenance_ != null ? other.provenance_.Clone() : null;
      provenanceBytes_ = other.provenanceBytes_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Details Clone() {
      return new Details(this);
    }

    /// <summary>Field number for the "provenance" field.</summary>
    public const int ProvenanceFieldNumber = 1;
    private global::Grafeas.V1Beta1.Provenance.BuildProvenance provenance_;
    /// <summary>
    /// Required. The actual provenance for the build.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grafeas.V1Beta1.Provenance.BuildProvenance Provenance {
      get { return provenance_; }
      set {
        provenance_ = value;
      }
    }

    /// <summary>Field number for the "provenance_bytes" field.</summary>
    public const int ProvenanceBytesFieldNumber = 2;
    private string provenanceBytes_ = "";
    /// <summary>
    /// Serialized JSON representation of the provenance, used in generating the
    /// build signature in the corresponding build note. After verifying the
    /// signature, `provenance_bytes` can be unmarshalled and compared to the
    /// provenance to confirm that it is unchanged. A base64-encoded string
    /// representation of the provenance bytes is used for the signature in order
    /// to interoperate with openssl which expects this format for signature
    /// verification.
    ///
    /// The serialized form is captured both to avoid ambiguity in how the
    /// provenance is marshalled to json as well to prevent incompatibilities with
    /// future changes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProvenanceBytes {
      get { return provenanceBytes_; }
      set {
        provenanceBytes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Details);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Details other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Provenance, other.Provenance)) return false;
      if (ProvenanceBytes != other.ProvenanceBytes) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (provenance_ != null) hash ^= Provenance.GetHashCode();
      if (ProvenanceBytes.Length != 0) hash ^= ProvenanceBytes.GetHashCode();
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
      if (provenance_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Provenance);
      }
      if (ProvenanceBytes.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProvenanceBytes);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (provenance_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Provenance);
      }
      if (ProvenanceBytes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProvenanceBytes);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Details other) {
      if (other == null) {
        return;
      }
      if (other.provenance_ != null) {
        if (provenance_ == null) {
          Provenance = new global::Grafeas.V1Beta1.Provenance.BuildProvenance();
        }
        Provenance.MergeFrom(other.Provenance);
      }
      if (other.ProvenanceBytes.Length != 0) {
        ProvenanceBytes = other.ProvenanceBytes;
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
          case 10: {
            if (provenance_ == null) {
              Provenance = new global::Grafeas.V1Beta1.Provenance.BuildProvenance();
            }
            input.ReadMessage(Provenance);
            break;
          }
          case 18: {
            ProvenanceBytes = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code