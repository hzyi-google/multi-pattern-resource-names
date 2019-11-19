// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/privacy/dlp/v2/dlp.proto

package com.google.privacy.dlp.v2;

public interface PrivacyMetricOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.privacy.dlp.v2.PrivacyMetric)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.NumericalStatsConfig numerical_stats_config = 1;</code>
   */
  boolean hasNumericalStatsConfig();
  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.NumericalStatsConfig numerical_stats_config = 1;</code>
   */
  com.google.privacy.dlp.v2.PrivacyMetric.NumericalStatsConfig getNumericalStatsConfig();
  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.NumericalStatsConfig numerical_stats_config = 1;</code>
   */
  com.google.privacy.dlp.v2.PrivacyMetric.NumericalStatsConfigOrBuilder getNumericalStatsConfigOrBuilder();

  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.CategoricalStatsConfig categorical_stats_config = 2;</code>
   */
  boolean hasCategoricalStatsConfig();
  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.CategoricalStatsConfig categorical_stats_config = 2;</code>
   */
  com.google.privacy.dlp.v2.PrivacyMetric.CategoricalStatsConfig getCategoricalStatsConfig();
  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.CategoricalStatsConfig categorical_stats_config = 2;</code>
   */
  com.google.privacy.dlp.v2.PrivacyMetric.CategoricalStatsConfigOrBuilder getCategoricalStatsConfigOrBuilder();

  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.KAnonymityConfig k_anonymity_config = 3;</code>
   */
  boolean hasKAnonymityConfig();
  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.KAnonymityConfig k_anonymity_config = 3;</code>
   */
  com.google.privacy.dlp.v2.PrivacyMetric.KAnonymityConfig getKAnonymityConfig();
  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.KAnonymityConfig k_anonymity_config = 3;</code>
   */
  com.google.privacy.dlp.v2.PrivacyMetric.KAnonymityConfigOrBuilder getKAnonymityConfigOrBuilder();

  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.LDiversityConfig l_diversity_config = 4;</code>
   */
  boolean hasLDiversityConfig();
  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.LDiversityConfig l_diversity_config = 4;</code>
   */
  com.google.privacy.dlp.v2.PrivacyMetric.LDiversityConfig getLDiversityConfig();
  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.LDiversityConfig l_diversity_config = 4;</code>
   */
  com.google.privacy.dlp.v2.PrivacyMetric.LDiversityConfigOrBuilder getLDiversityConfigOrBuilder();

  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.KMapEstimationConfig k_map_estimation_config = 5;</code>
   */
  boolean hasKMapEstimationConfig();
  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.KMapEstimationConfig k_map_estimation_config = 5;</code>
   */
  com.google.privacy.dlp.v2.PrivacyMetric.KMapEstimationConfig getKMapEstimationConfig();
  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.KMapEstimationConfig k_map_estimation_config = 5;</code>
   */
  com.google.privacy.dlp.v2.PrivacyMetric.KMapEstimationConfigOrBuilder getKMapEstimationConfigOrBuilder();

  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.DeltaPresenceEstimationConfig delta_presence_estimation_config = 6;</code>
   */
  boolean hasDeltaPresenceEstimationConfig();
  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.DeltaPresenceEstimationConfig delta_presence_estimation_config = 6;</code>
   */
  com.google.privacy.dlp.v2.PrivacyMetric.DeltaPresenceEstimationConfig getDeltaPresenceEstimationConfig();
  /**
   * <code>.google.privacy.dlp.v2.PrivacyMetric.DeltaPresenceEstimationConfig delta_presence_estimation_config = 6;</code>
   */
  com.google.privacy.dlp.v2.PrivacyMetric.DeltaPresenceEstimationConfigOrBuilder getDeltaPresenceEstimationConfigOrBuilder();

  public com.google.privacy.dlp.v2.PrivacyMetric.TypeCase getTypeCase();
}
