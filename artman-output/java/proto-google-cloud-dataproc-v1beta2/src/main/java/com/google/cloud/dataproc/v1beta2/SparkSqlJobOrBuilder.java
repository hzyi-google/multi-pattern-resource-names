// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dataproc/v1beta2/jobs.proto

package com.google.cloud.dataproc.v1beta2;

public interface SparkSqlJobOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dataproc.v1beta2.SparkSqlJob)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The HCFS URI of the script that contains SQL queries.
   * </pre>
   *
   * <code>string query_file_uri = 1;</code>
   * @return The queryFileUri.
   */
  java.lang.String getQueryFileUri();
  /**
   * <pre>
   * The HCFS URI of the script that contains SQL queries.
   * </pre>
   *
   * <code>string query_file_uri = 1;</code>
   * @return The bytes for queryFileUri.
   */
  com.google.protobuf.ByteString
      getQueryFileUriBytes();

  /**
   * <pre>
   * A list of queries.
   * </pre>
   *
   * <code>.google.cloud.dataproc.v1beta2.QueryList query_list = 2;</code>
   * @return Whether the queryList field is set.
   */
  boolean hasQueryList();
  /**
   * <pre>
   * A list of queries.
   * </pre>
   *
   * <code>.google.cloud.dataproc.v1beta2.QueryList query_list = 2;</code>
   * @return The queryList.
   */
  com.google.cloud.dataproc.v1beta2.QueryList getQueryList();
  /**
   * <pre>
   * A list of queries.
   * </pre>
   *
   * <code>.google.cloud.dataproc.v1beta2.QueryList query_list = 2;</code>
   */
  com.google.cloud.dataproc.v1beta2.QueryListOrBuilder getQueryListOrBuilder();

  /**
   * <pre>
   * Optional. Mapping of query variable names to values (equivalent to the
   * Spark SQL command: SET `name="value";`).
   * </pre>
   *
   * <code>map&lt;string, string&gt; script_variables = 3;</code>
   */
  int getScriptVariablesCount();
  /**
   * <pre>
   * Optional. Mapping of query variable names to values (equivalent to the
   * Spark SQL command: SET `name="value";`).
   * </pre>
   *
   * <code>map&lt;string, string&gt; script_variables = 3;</code>
   */
  boolean containsScriptVariables(
      java.lang.String key);
  /**
   * Use {@link #getScriptVariablesMap()} instead.
   */
  @java.lang.Deprecated
  java.util.Map<java.lang.String, java.lang.String>
  getScriptVariables();
  /**
   * <pre>
   * Optional. Mapping of query variable names to values (equivalent to the
   * Spark SQL command: SET `name="value";`).
   * </pre>
   *
   * <code>map&lt;string, string&gt; script_variables = 3;</code>
   */
  java.util.Map<java.lang.String, java.lang.String>
  getScriptVariablesMap();
  /**
   * <pre>
   * Optional. Mapping of query variable names to values (equivalent to the
   * Spark SQL command: SET `name="value";`).
   * </pre>
   *
   * <code>map&lt;string, string&gt; script_variables = 3;</code>
   */

  java.lang.String getScriptVariablesOrDefault(
      java.lang.String key,
      java.lang.String defaultValue);
  /**
   * <pre>
   * Optional. Mapping of query variable names to values (equivalent to the
   * Spark SQL command: SET `name="value";`).
   * </pre>
   *
   * <code>map&lt;string, string&gt; script_variables = 3;</code>
   */

  java.lang.String getScriptVariablesOrThrow(
      java.lang.String key);

  /**
   * <pre>
   * Optional. A mapping of property names to values, used to configure
   * Spark SQL's SparkConf. Properties that conflict with values set by the
   * Cloud Dataproc API may be overwritten.
   * </pre>
   *
   * <code>map&lt;string, string&gt; properties = 4;</code>
   */
  int getPropertiesCount();
  /**
   * <pre>
   * Optional. A mapping of property names to values, used to configure
   * Spark SQL's SparkConf. Properties that conflict with values set by the
   * Cloud Dataproc API may be overwritten.
   * </pre>
   *
   * <code>map&lt;string, string&gt; properties = 4;</code>
   */
  boolean containsProperties(
      java.lang.String key);
  /**
   * Use {@link #getPropertiesMap()} instead.
   */
  @java.lang.Deprecated
  java.util.Map<java.lang.String, java.lang.String>
  getProperties();
  /**
   * <pre>
   * Optional. A mapping of property names to values, used to configure
   * Spark SQL's SparkConf. Properties that conflict with values set by the
   * Cloud Dataproc API may be overwritten.
   * </pre>
   *
   * <code>map&lt;string, string&gt; properties = 4;</code>
   */
  java.util.Map<java.lang.String, java.lang.String>
  getPropertiesMap();
  /**
   * <pre>
   * Optional. A mapping of property names to values, used to configure
   * Spark SQL's SparkConf. Properties that conflict with values set by the
   * Cloud Dataproc API may be overwritten.
   * </pre>
   *
   * <code>map&lt;string, string&gt; properties = 4;</code>
   */

  java.lang.String getPropertiesOrDefault(
      java.lang.String key,
      java.lang.String defaultValue);
  /**
   * <pre>
   * Optional. A mapping of property names to values, used to configure
   * Spark SQL's SparkConf. Properties that conflict with values set by the
   * Cloud Dataproc API may be overwritten.
   * </pre>
   *
   * <code>map&lt;string, string&gt; properties = 4;</code>
   */

  java.lang.String getPropertiesOrThrow(
      java.lang.String key);

  /**
   * <pre>
   * Optional. HCFS URIs of jar files to be added to the Spark CLASSPATH.
   * </pre>
   *
   * <code>repeated string jar_file_uris = 56;</code>
   * @return A list containing the jarFileUris.
   */
  java.util.List<java.lang.String>
      getJarFileUrisList();
  /**
   * <pre>
   * Optional. HCFS URIs of jar files to be added to the Spark CLASSPATH.
   * </pre>
   *
   * <code>repeated string jar_file_uris = 56;</code>
   * @return The count of jarFileUris.
   */
  int getJarFileUrisCount();
  /**
   * <pre>
   * Optional. HCFS URIs of jar files to be added to the Spark CLASSPATH.
   * </pre>
   *
   * <code>repeated string jar_file_uris = 56;</code>
   * @param index The index of the element to return.
   * @return The jarFileUris at the given index.
   */
  java.lang.String getJarFileUris(int index);
  /**
   * <pre>
   * Optional. HCFS URIs of jar files to be added to the Spark CLASSPATH.
   * </pre>
   *
   * <code>repeated string jar_file_uris = 56;</code>
   * @param index The index of the value to return.
   * @return The bytes of the jarFileUris at the given index.
   */
  com.google.protobuf.ByteString
      getJarFileUrisBytes(int index);

  /**
   * <pre>
   * Optional. The runtime log config for job execution.
   * </pre>
   *
   * <code>.google.cloud.dataproc.v1beta2.LoggingConfig logging_config = 6;</code>
   * @return Whether the loggingConfig field is set.
   */
  boolean hasLoggingConfig();
  /**
   * <pre>
   * Optional. The runtime log config for job execution.
   * </pre>
   *
   * <code>.google.cloud.dataproc.v1beta2.LoggingConfig logging_config = 6;</code>
   * @return The loggingConfig.
   */
  com.google.cloud.dataproc.v1beta2.LoggingConfig getLoggingConfig();
  /**
   * <pre>
   * Optional. The runtime log config for job execution.
   * </pre>
   *
   * <code>.google.cloud.dataproc.v1beta2.LoggingConfig logging_config = 6;</code>
   */
  com.google.cloud.dataproc.v1beta2.LoggingConfigOrBuilder getLoggingConfigOrBuilder();

  public com.google.cloud.dataproc.v1beta2.SparkSqlJob.QueriesCase getQueriesCase();
}