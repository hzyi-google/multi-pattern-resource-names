// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4beta1/profile.proto

package com.google.cloud.talent.v4beta1;

public interface DegreeOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.talent.v4beta1.Degree)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * ISCED degree type.
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.DegreeType degree_type = 1;</code>
   */
  int getDegreeTypeValue();
  /**
   * <pre>
   * ISCED degree type.
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.DegreeType degree_type = 1;</code>
   */
  com.google.cloud.talent.v4beta1.DegreeType getDegreeType();

  /**
   * <pre>
   * Full Degree name.
   * For example, "B.S.", "Master of Arts", and so on.
   * Number of characters allowed is 100.
   * </pre>
   *
   * <code>string degree_name = 2;</code>
   */
  java.lang.String getDegreeName();
  /**
   * <pre>
   * Full Degree name.
   * For example, "B.S.", "Master of Arts", and so on.
   * Number of characters allowed is 100.
   * </pre>
   *
   * <code>string degree_name = 2;</code>
   */
  com.google.protobuf.ByteString
      getDegreeNameBytes();

  /**
   * <pre>
   * Fields of study for the degree.
   * For example, "Computer science", "engineering".
   * Number of characters allowed is 100.
   * </pre>
   *
   * <code>repeated string fields_of_study = 3;</code>
   */
  java.util.List<java.lang.String>
      getFieldsOfStudyList();
  /**
   * <pre>
   * Fields of study for the degree.
   * For example, "Computer science", "engineering".
   * Number of characters allowed is 100.
   * </pre>
   *
   * <code>repeated string fields_of_study = 3;</code>
   */
  int getFieldsOfStudyCount();
  /**
   * <pre>
   * Fields of study for the degree.
   * For example, "Computer science", "engineering".
   * Number of characters allowed is 100.
   * </pre>
   *
   * <code>repeated string fields_of_study = 3;</code>
   */
  java.lang.String getFieldsOfStudy(int index);
  /**
   * <pre>
   * Fields of study for the degree.
   * For example, "Computer science", "engineering".
   * Number of characters allowed is 100.
   * </pre>
   *
   * <code>repeated string fields_of_study = 3;</code>
   */
  com.google.protobuf.ByteString
      getFieldsOfStudyBytes(int index);
}
