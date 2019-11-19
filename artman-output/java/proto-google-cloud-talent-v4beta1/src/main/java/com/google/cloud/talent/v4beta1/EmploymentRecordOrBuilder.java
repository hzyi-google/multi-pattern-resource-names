// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4beta1/profile.proto

package com.google.cloud.talent.v4beta1;

public interface EmploymentRecordOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.talent.v4beta1.EmploymentRecord)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Start date of the employment.
   * </pre>
   *
   * <code>.google.type.Date start_date = 1;</code>
   */
  boolean hasStartDate();
  /**
   * <pre>
   * Start date of the employment.
   * </pre>
   *
   * <code>.google.type.Date start_date = 1;</code>
   */
  com.google.type.Date getStartDate();
  /**
   * <pre>
   * Start date of the employment.
   * </pre>
   *
   * <code>.google.type.Date start_date = 1;</code>
   */
  com.google.type.DateOrBuilder getStartDateOrBuilder();

  /**
   * <pre>
   * End date of the employment.
   * </pre>
   *
   * <code>.google.type.Date end_date = 2;</code>
   */
  boolean hasEndDate();
  /**
   * <pre>
   * End date of the employment.
   * </pre>
   *
   * <code>.google.type.Date end_date = 2;</code>
   */
  com.google.type.Date getEndDate();
  /**
   * <pre>
   * End date of the employment.
   * </pre>
   *
   * <code>.google.type.Date end_date = 2;</code>
   */
  com.google.type.DateOrBuilder getEndDateOrBuilder();

  /**
   * <pre>
   * The name of the employer company/organization.
   * For example, "Google", "Alphabet", and so on.
   * Number of characters allowed is 250.
   * </pre>
   *
   * <code>string employer_name = 3;</code>
   */
  java.lang.String getEmployerName();
  /**
   * <pre>
   * The name of the employer company/organization.
   * For example, "Google", "Alphabet", and so on.
   * Number of characters allowed is 250.
   * </pre>
   *
   * <code>string employer_name = 3;</code>
   */
  com.google.protobuf.ByteString
      getEmployerNameBytes();

  /**
   * <pre>
   * The division name of the employment.
   * For example, division, department, client, and so on.
   * Number of characters allowed is 100.
   * </pre>
   *
   * <code>string division_name = 4;</code>
   */
  java.lang.String getDivisionName();
  /**
   * <pre>
   * The division name of the employment.
   * For example, division, department, client, and so on.
   * Number of characters allowed is 100.
   * </pre>
   *
   * <code>string division_name = 4;</code>
   */
  com.google.protobuf.ByteString
      getDivisionNameBytes();

  /**
   * <pre>
   * The physical address of the employer.
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.Address address = 5;</code>
   */
  boolean hasAddress();
  /**
   * <pre>
   * The physical address of the employer.
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.Address address = 5;</code>
   */
  com.google.cloud.talent.v4beta1.Address getAddress();
  /**
   * <pre>
   * The physical address of the employer.
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.Address address = 5;</code>
   */
  com.google.cloud.talent.v4beta1.AddressOrBuilder getAddressOrBuilder();

  /**
   * <pre>
   * The job title of the employment.
   * For example, "Software Engineer", "Data Scientist", and so on.
   * Number of characters allowed is 250.
   * </pre>
   *
   * <code>string job_title = 6;</code>
   */
  java.lang.String getJobTitle();
  /**
   * <pre>
   * The job title of the employment.
   * For example, "Software Engineer", "Data Scientist", and so on.
   * Number of characters allowed is 250.
   * </pre>
   *
   * <code>string job_title = 6;</code>
   */
  com.google.protobuf.ByteString
      getJobTitleBytes();

  /**
   * <pre>
   * The description of job content.
   * Number of characters allowed is 100,000.
   * </pre>
   *
   * <code>string job_description = 7;</code>
   */
  java.lang.String getJobDescription();
  /**
   * <pre>
   * The description of job content.
   * Number of characters allowed is 100,000.
   * </pre>
   *
   * <code>string job_description = 7;</code>
   */
  com.google.protobuf.ByteString
      getJobDescriptionBytes();

  /**
   * <pre>
   * If the jobs is a supervisor position.
   * </pre>
   *
   * <code>.google.protobuf.BoolValue is_supervisor = 8;</code>
   */
  boolean hasIsSupervisor();
  /**
   * <pre>
   * If the jobs is a supervisor position.
   * </pre>
   *
   * <code>.google.protobuf.BoolValue is_supervisor = 8;</code>
   */
  com.google.protobuf.BoolValue getIsSupervisor();
  /**
   * <pre>
   * If the jobs is a supervisor position.
   * </pre>
   *
   * <code>.google.protobuf.BoolValue is_supervisor = 8;</code>
   */
  com.google.protobuf.BoolValueOrBuilder getIsSupervisorOrBuilder();

  /**
   * <pre>
   * If this employment is self-employed.
   * </pre>
   *
   * <code>.google.protobuf.BoolValue is_self_employed = 9;</code>
   */
  boolean hasIsSelfEmployed();
  /**
   * <pre>
   * If this employment is self-employed.
   * </pre>
   *
   * <code>.google.protobuf.BoolValue is_self_employed = 9;</code>
   */
  com.google.protobuf.BoolValue getIsSelfEmployed();
  /**
   * <pre>
   * If this employment is self-employed.
   * </pre>
   *
   * <code>.google.protobuf.BoolValue is_self_employed = 9;</code>
   */
  com.google.protobuf.BoolValueOrBuilder getIsSelfEmployedOrBuilder();

  /**
   * <pre>
   * If this employment is current.
   * </pre>
   *
   * <code>.google.protobuf.BoolValue is_current = 10;</code>
   */
  boolean hasIsCurrent();
  /**
   * <pre>
   * If this employment is current.
   * </pre>
   *
   * <code>.google.protobuf.BoolValue is_current = 10;</code>
   */
  com.google.protobuf.BoolValue getIsCurrent();
  /**
   * <pre>
   * If this employment is current.
   * </pre>
   *
   * <code>.google.protobuf.BoolValue is_current = 10;</code>
   */
  com.google.protobuf.BoolValueOrBuilder getIsCurrentOrBuilder();

  /**
   * <pre>
   * Output only. The job title snippet shows how the
   * [job_title][google.cloud.talent.v4beta1.EmploymentRecord.job_title] is
   * related to a search query. It's empty if the
   * [job_title][google.cloud.talent.v4beta1.EmploymentRecord.job_title] isn't
   * related to the search query.
   * </pre>
   *
   * <code>string job_title_snippet = 11 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  java.lang.String getJobTitleSnippet();
  /**
   * <pre>
   * Output only. The job title snippet shows how the
   * [job_title][google.cloud.talent.v4beta1.EmploymentRecord.job_title] is
   * related to a search query. It's empty if the
   * [job_title][google.cloud.talent.v4beta1.EmploymentRecord.job_title] isn't
   * related to the search query.
   * </pre>
   *
   * <code>string job_title_snippet = 11 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.ByteString
      getJobTitleSnippetBytes();

  /**
   * <pre>
   * Output only. The job description snippet shows how the
   * [job_description][google.cloud.talent.v4beta1.EmploymentRecord.job_description]
   * is related to a search query. It's empty if the
   * [job_description][google.cloud.talent.v4beta1.EmploymentRecord.job_description]
   * isn't related to the search query.
   * </pre>
   *
   * <code>string job_description_snippet = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  java.lang.String getJobDescriptionSnippet();
  /**
   * <pre>
   * Output only. The job description snippet shows how the
   * [job_description][google.cloud.talent.v4beta1.EmploymentRecord.job_description]
   * is related to a search query. It's empty if the
   * [job_description][google.cloud.talent.v4beta1.EmploymentRecord.job_description]
   * isn't related to the search query.
   * </pre>
   *
   * <code>string job_description_snippet = 12 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.ByteString
      getJobDescriptionSnippetBytes();

  /**
   * <pre>
   * Output only. The employer name snippet shows how the
   * [employer_name][google.cloud.talent.v4beta1.EmploymentRecord.employer_name]
   * is related to a search query. It's empty if the
   * [employer_name][google.cloud.talent.v4beta1.EmploymentRecord.employer_name]
   * isn't related to the search query.
   * </pre>
   *
   * <code>string employer_name_snippet = 13 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  java.lang.String getEmployerNameSnippet();
  /**
   * <pre>
   * Output only. The employer name snippet shows how the
   * [employer_name][google.cloud.talent.v4beta1.EmploymentRecord.employer_name]
   * is related to a search query. It's empty if the
   * [employer_name][google.cloud.talent.v4beta1.EmploymentRecord.employer_name]
   * isn't related to the search query.
   * </pre>
   *
   * <code>string employer_name_snippet = 13 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   */
  com.google.protobuf.ByteString
      getEmployerNameSnippetBytes();
}
