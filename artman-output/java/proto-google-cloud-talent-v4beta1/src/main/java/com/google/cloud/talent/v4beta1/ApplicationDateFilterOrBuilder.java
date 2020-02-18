// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4beta1/filters.proto

package com.google.cloud.talent.v4beta1;

public interface ApplicationDateFilterOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.talent.v4beta1.ApplicationDateFilter)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Start date. If it's missing, The API matches profiles with application date
   * not after the end date.
   * </pre>
   *
   * <code>.google.type.Date start_date = 1;</code>
   * @return Whether the startDate field is set.
   */
  boolean hasStartDate();
  /**
   * <pre>
   * Start date. If it's missing, The API matches profiles with application date
   * not after the end date.
   * </pre>
   *
   * <code>.google.type.Date start_date = 1;</code>
   * @return The startDate.
   */
  com.google.type.Date getStartDate();
  /**
   * <pre>
   * Start date. If it's missing, The API matches profiles with application date
   * not after the end date.
   * </pre>
   *
   * <code>.google.type.Date start_date = 1;</code>
   */
  com.google.type.DateOrBuilder getStartDateOrBuilder();

  /**
   * <pre>
   * End date. If it's missing, The API matches profiles with application date
   * not before the start date.
   * </pre>
   *
   * <code>.google.type.Date end_date = 2;</code>
   * @return Whether the endDate field is set.
   */
  boolean hasEndDate();
  /**
   * <pre>
   * End date. If it's missing, The API matches profiles with application date
   * not before the start date.
   * </pre>
   *
   * <code>.google.type.Date end_date = 2;</code>
   * @return The endDate.
   */
  com.google.type.Date getEndDate();
  /**
   * <pre>
   * End date. If it's missing, The API matches profiles with application date
   * not before the start date.
   * </pre>
   *
   * <code>.google.type.Date end_date = 2;</code>
   */
  com.google.type.DateOrBuilder getEndDateOrBuilder();
}