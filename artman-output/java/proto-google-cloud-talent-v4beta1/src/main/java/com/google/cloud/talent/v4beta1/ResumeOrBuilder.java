// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4beta1/profile.proto

package com.google.cloud.talent.v4beta1;

public interface ResumeOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.talent.v4beta1.Resume)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Users can create a profile with only this field field, if [resume_type][google.cloud.talent.v4beta1.Resume.resume_type]
   * is [HRXML][google.cloud.talent.v4beta1.Resume.ResumeType.HRXML]. For example, the API parses this field and
   * creates a profile
   * with all structured fields populated. [EmploymentRecord][google.cloud.talent.v4beta1.EmploymentRecord],
   * [EducationRecord][google.cloud.talent.v4beta1.EducationRecord], and so on. An error is thrown if this field cannot be
   * parsed.
   * Note that the use of the functionality offered by this field to extract
   * data from resumes is an Alpha feature and as such is not covered by any
   * SLA.
   * </pre>
   *
   * <code>string structured_resume = 1;</code>
   * @return The structuredResume.
   */
  java.lang.String getStructuredResume();
  /**
   * <pre>
   * Users can create a profile with only this field field, if [resume_type][google.cloud.talent.v4beta1.Resume.resume_type]
   * is [HRXML][google.cloud.talent.v4beta1.Resume.ResumeType.HRXML]. For example, the API parses this field and
   * creates a profile
   * with all structured fields populated. [EmploymentRecord][google.cloud.talent.v4beta1.EmploymentRecord],
   * [EducationRecord][google.cloud.talent.v4beta1.EducationRecord], and so on. An error is thrown if this field cannot be
   * parsed.
   * Note that the use of the functionality offered by this field to extract
   * data from resumes is an Alpha feature and as such is not covered by any
   * SLA.
   * </pre>
   *
   * <code>string structured_resume = 1;</code>
   * @return The bytes for structuredResume.
   */
  com.google.protobuf.ByteString
      getStructuredResumeBytes();

  /**
   * <pre>
   * The format of [structured_resume][google.cloud.talent.v4beta1.Resume.structured_resume].
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.Resume.ResumeType resume_type = 2;</code>
   * @return The enum numeric value on the wire for resumeType.
   */
  int getResumeTypeValue();
  /**
   * <pre>
   * The format of [structured_resume][google.cloud.talent.v4beta1.Resume.structured_resume].
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.Resume.ResumeType resume_type = 2;</code>
   * @return The resumeType.
   */
  com.google.cloud.talent.v4beta1.Resume.ResumeType getResumeType();
}
