// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/privacy/dlp/v2/dlp.proto

package com.google.privacy.dlp.v2;

public interface StoredInfoTypeVersionOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.privacy.dlp.v2.StoredInfoTypeVersion)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * StoredInfoType configuration.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.StoredInfoTypeConfig config = 1;</code>
   */
  boolean hasConfig();
  /**
   * <pre>
   * StoredInfoType configuration.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.StoredInfoTypeConfig config = 1;</code>
   */
  com.google.privacy.dlp.v2.StoredInfoTypeConfig getConfig();
  /**
   * <pre>
   * StoredInfoType configuration.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.StoredInfoTypeConfig config = 1;</code>
   */
  com.google.privacy.dlp.v2.StoredInfoTypeConfigOrBuilder getConfigOrBuilder();

  /**
   * <pre>
   * Create timestamp of the version. Read-only, determined by the system
   * when the version is created.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp create_time = 2;</code>
   */
  boolean hasCreateTime();
  /**
   * <pre>
   * Create timestamp of the version. Read-only, determined by the system
   * when the version is created.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp create_time = 2;</code>
   */
  com.google.protobuf.Timestamp getCreateTime();
  /**
   * <pre>
   * Create timestamp of the version. Read-only, determined by the system
   * when the version is created.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp create_time = 2;</code>
   */
  com.google.protobuf.TimestampOrBuilder getCreateTimeOrBuilder();

  /**
   * <pre>
   * Stored info type version state. Read-only, updated by the system
   * during dictionary creation.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.StoredInfoTypeState state = 3;</code>
   */
  int getStateValue();
  /**
   * <pre>
   * Stored info type version state. Read-only, updated by the system
   * during dictionary creation.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.StoredInfoTypeState state = 3;</code>
   */
  com.google.privacy.dlp.v2.StoredInfoTypeState getState();

  /**
   * <pre>
   * Errors that occurred when creating this storedInfoType version, or
   * anomalies detected in the storedInfoType data that render it unusable. Only
   * the five most recent errors will be displayed, with the most recent error
   * appearing first.
   * &lt;p&gt;For example, some of the data for stored custom dictionaries is put in
   * the user's Google Cloud Storage bucket, and if this data is modified or
   * deleted by the user or another system, the dictionary becomes invalid.
   * &lt;p&gt;If any errors occur, fix the problem indicated by the error message and
   * use the UpdateStoredInfoType API method to create another version of the
   * storedInfoType to continue using it, reusing the same `config` if it was
   * not the source of the error.
   * </pre>
   *
   * <code>repeated .google.privacy.dlp.v2.Error errors = 4;</code>
   */
  java.util.List<com.google.privacy.dlp.v2.Error> 
      getErrorsList();
  /**
   * <pre>
   * Errors that occurred when creating this storedInfoType version, or
   * anomalies detected in the storedInfoType data that render it unusable. Only
   * the five most recent errors will be displayed, with the most recent error
   * appearing first.
   * &lt;p&gt;For example, some of the data for stored custom dictionaries is put in
   * the user's Google Cloud Storage bucket, and if this data is modified or
   * deleted by the user or another system, the dictionary becomes invalid.
   * &lt;p&gt;If any errors occur, fix the problem indicated by the error message and
   * use the UpdateStoredInfoType API method to create another version of the
   * storedInfoType to continue using it, reusing the same `config` if it was
   * not the source of the error.
   * </pre>
   *
   * <code>repeated .google.privacy.dlp.v2.Error errors = 4;</code>
   */
  com.google.privacy.dlp.v2.Error getErrors(int index);
  /**
   * <pre>
   * Errors that occurred when creating this storedInfoType version, or
   * anomalies detected in the storedInfoType data that render it unusable. Only
   * the five most recent errors will be displayed, with the most recent error
   * appearing first.
   * &lt;p&gt;For example, some of the data for stored custom dictionaries is put in
   * the user's Google Cloud Storage bucket, and if this data is modified or
   * deleted by the user or another system, the dictionary becomes invalid.
   * &lt;p&gt;If any errors occur, fix the problem indicated by the error message and
   * use the UpdateStoredInfoType API method to create another version of the
   * storedInfoType to continue using it, reusing the same `config` if it was
   * not the source of the error.
   * </pre>
   *
   * <code>repeated .google.privacy.dlp.v2.Error errors = 4;</code>
   */
  int getErrorsCount();
  /**
   * <pre>
   * Errors that occurred when creating this storedInfoType version, or
   * anomalies detected in the storedInfoType data that render it unusable. Only
   * the five most recent errors will be displayed, with the most recent error
   * appearing first.
   * &lt;p&gt;For example, some of the data for stored custom dictionaries is put in
   * the user's Google Cloud Storage bucket, and if this data is modified or
   * deleted by the user or another system, the dictionary becomes invalid.
   * &lt;p&gt;If any errors occur, fix the problem indicated by the error message and
   * use the UpdateStoredInfoType API method to create another version of the
   * storedInfoType to continue using it, reusing the same `config` if it was
   * not the source of the error.
   * </pre>
   *
   * <code>repeated .google.privacy.dlp.v2.Error errors = 4;</code>
   */
  java.util.List<? extends com.google.privacy.dlp.v2.ErrorOrBuilder> 
      getErrorsOrBuilderList();
  /**
   * <pre>
   * Errors that occurred when creating this storedInfoType version, or
   * anomalies detected in the storedInfoType data that render it unusable. Only
   * the five most recent errors will be displayed, with the most recent error
   * appearing first.
   * &lt;p&gt;For example, some of the data for stored custom dictionaries is put in
   * the user's Google Cloud Storage bucket, and if this data is modified or
   * deleted by the user or another system, the dictionary becomes invalid.
   * &lt;p&gt;If any errors occur, fix the problem indicated by the error message and
   * use the UpdateStoredInfoType API method to create another version of the
   * storedInfoType to continue using it, reusing the same `config` if it was
   * not the source of the error.
   * </pre>
   *
   * <code>repeated .google.privacy.dlp.v2.Error errors = 4;</code>
   */
  com.google.privacy.dlp.v2.ErrorOrBuilder getErrorsOrBuilder(
      int index);

  /**
   * <pre>
   * Statistics about this storedInfoType version.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.StoredInfoTypeStats stats = 5;</code>
   */
  boolean hasStats();
  /**
   * <pre>
   * Statistics about this storedInfoType version.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.StoredInfoTypeStats stats = 5;</code>
   */
  com.google.privacy.dlp.v2.StoredInfoTypeStats getStats();
  /**
   * <pre>
   * Statistics about this storedInfoType version.
   * </pre>
   *
   * <code>.google.privacy.dlp.v2.StoredInfoTypeStats stats = 5;</code>
   */
  com.google.privacy.dlp.v2.StoredInfoTypeStatsOrBuilder getStatsOrBuilder();
}
