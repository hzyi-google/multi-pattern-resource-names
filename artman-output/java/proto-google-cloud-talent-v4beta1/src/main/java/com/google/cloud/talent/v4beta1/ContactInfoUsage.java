// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4beta1/common.proto

package com.google.cloud.talent.v4beta1;

/**
 * <pre>
 * Enum that represents the usage of the contact information.
 * </pre>
 *
 * Protobuf enum {@code google.cloud.talent.v4beta1.ContactInfoUsage}
 */
public enum ContactInfoUsage
    implements com.google.protobuf.ProtocolMessageEnum {
  /**
   * <pre>
   * Default value.
   * </pre>
   *
   * <code>CONTACT_INFO_USAGE_UNSPECIFIED = 0;</code>
   */
  CONTACT_INFO_USAGE_UNSPECIFIED(0),
  /**
   * <pre>
   * Personal use.
   * </pre>
   *
   * <code>PERSONAL = 1;</code>
   */
  PERSONAL(1),
  /**
   * <pre>
   * Work use.
   * </pre>
   *
   * <code>WORK = 2;</code>
   */
  WORK(2),
  /**
   * <pre>
   * School use.
   * </pre>
   *
   * <code>SCHOOL = 3;</code>
   */
  SCHOOL(3),
  UNRECOGNIZED(-1),
  ;

  /**
   * <pre>
   * Default value.
   * </pre>
   *
   * <code>CONTACT_INFO_USAGE_UNSPECIFIED = 0;</code>
   */
  public static final int CONTACT_INFO_USAGE_UNSPECIFIED_VALUE = 0;
  /**
   * <pre>
   * Personal use.
   * </pre>
   *
   * <code>PERSONAL = 1;</code>
   */
  public static final int PERSONAL_VALUE = 1;
  /**
   * <pre>
   * Work use.
   * </pre>
   *
   * <code>WORK = 2;</code>
   */
  public static final int WORK_VALUE = 2;
  /**
   * <pre>
   * School use.
   * </pre>
   *
   * <code>SCHOOL = 3;</code>
   */
  public static final int SCHOOL_VALUE = 3;


  public final int getNumber() {
    if (this == UNRECOGNIZED) {
      throw new java.lang.IllegalArgumentException(
          "Can't get the number of an unknown enum value.");
    }
    return value;
  }

  /**
   * @deprecated Use {@link #forNumber(int)} instead.
   */
  @java.lang.Deprecated
  public static ContactInfoUsage valueOf(int value) {
    return forNumber(value);
  }

  public static ContactInfoUsage forNumber(int value) {
    switch (value) {
      case 0: return CONTACT_INFO_USAGE_UNSPECIFIED;
      case 1: return PERSONAL;
      case 2: return WORK;
      case 3: return SCHOOL;
      default: return null;
    }
  }

  public static com.google.protobuf.Internal.EnumLiteMap<ContactInfoUsage>
      internalGetValueMap() {
    return internalValueMap;
  }
  private static final com.google.protobuf.Internal.EnumLiteMap<
      ContactInfoUsage> internalValueMap =
        new com.google.protobuf.Internal.EnumLiteMap<ContactInfoUsage>() {
          public ContactInfoUsage findValueByNumber(int number) {
            return ContactInfoUsage.forNumber(number);
          }
        };

  public final com.google.protobuf.Descriptors.EnumValueDescriptor
      getValueDescriptor() {
    return getDescriptor().getValues().get(ordinal());
  }
  public final com.google.protobuf.Descriptors.EnumDescriptor
      getDescriptorForType() {
    return getDescriptor();
  }
  public static final com.google.protobuf.Descriptors.EnumDescriptor
      getDescriptor() {
    return com.google.cloud.talent.v4beta1.CommonProto.getDescriptor().getEnumTypes().get(8);
  }

  private static final ContactInfoUsage[] VALUES = values();

  public static ContactInfoUsage valueOf(
      com.google.protobuf.Descriptors.EnumValueDescriptor desc) {
    if (desc.getType() != getDescriptor()) {
      throw new java.lang.IllegalArgumentException(
        "EnumValueDescriptor is not for this type.");
    }
    if (desc.getIndex() == -1) {
      return UNRECOGNIZED;
    }
    return VALUES[desc.getIndex()];
  }

  private final int value;

  private ContactInfoUsage(int value) {
    this.value = value;
  }

  // @@protoc_insertion_point(enum_scope:google.cloud.talent.v4beta1.ContactInfoUsage)
}

