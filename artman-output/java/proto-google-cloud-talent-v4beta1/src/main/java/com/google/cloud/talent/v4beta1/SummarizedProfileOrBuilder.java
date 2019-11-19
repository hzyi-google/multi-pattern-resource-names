// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4beta1/profile_service.proto

package com.google.cloud.talent.v4beta1;

public interface SummarizedProfileOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.talent.v4beta1.SummarizedProfile)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * A list of profiles that are linked by
   * [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id].
   * </pre>
   *
   * <code>repeated .google.cloud.talent.v4beta1.Profile profiles = 1;</code>
   */
  java.util.List<com.google.cloud.talent.v4beta1.Profile> 
      getProfilesList();
  /**
   * <pre>
   * A list of profiles that are linked by
   * [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id].
   * </pre>
   *
   * <code>repeated .google.cloud.talent.v4beta1.Profile profiles = 1;</code>
   */
  com.google.cloud.talent.v4beta1.Profile getProfiles(int index);
  /**
   * <pre>
   * A list of profiles that are linked by
   * [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id].
   * </pre>
   *
   * <code>repeated .google.cloud.talent.v4beta1.Profile profiles = 1;</code>
   */
  int getProfilesCount();
  /**
   * <pre>
   * A list of profiles that are linked by
   * [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id].
   * </pre>
   *
   * <code>repeated .google.cloud.talent.v4beta1.Profile profiles = 1;</code>
   */
  java.util.List<? extends com.google.cloud.talent.v4beta1.ProfileOrBuilder> 
      getProfilesOrBuilderList();
  /**
   * <pre>
   * A list of profiles that are linked by
   * [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id].
   * </pre>
   *
   * <code>repeated .google.cloud.talent.v4beta1.Profile profiles = 1;</code>
   */
  com.google.cloud.talent.v4beta1.ProfileOrBuilder getProfilesOrBuilder(
      int index);

  /**
   * <pre>
   * A profile summary shows the profile summary and how the profile matches the
   * search query.
   * In profile summary, the profiles with the same
   * [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id] are merged
   * together. Among profiles, same education/employment records may be slightly
   * different but they are merged into one with best efforts.
   * For example, in one profile the school name is "UC Berkeley" and the field
   * study is "Computer Science" and in another one the school name is
   * "University of California at Berkeley" and the field study is "CS". The API
   * merges these two inputs into one and selects one value for each field. For
   * example, the school name in summary is set to "University of California at
   * Berkeley" and the field of study is set to "Computer Science".
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.Profile summary = 2;</code>
   */
  boolean hasSummary();
  /**
   * <pre>
   * A profile summary shows the profile summary and how the profile matches the
   * search query.
   * In profile summary, the profiles with the same
   * [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id] are merged
   * together. Among profiles, same education/employment records may be slightly
   * different but they are merged into one with best efforts.
   * For example, in one profile the school name is "UC Berkeley" and the field
   * study is "Computer Science" and in another one the school name is
   * "University of California at Berkeley" and the field study is "CS". The API
   * merges these two inputs into one and selects one value for each field. For
   * example, the school name in summary is set to "University of California at
   * Berkeley" and the field of study is set to "Computer Science".
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.Profile summary = 2;</code>
   */
  com.google.cloud.talent.v4beta1.Profile getSummary();
  /**
   * <pre>
   * A profile summary shows the profile summary and how the profile matches the
   * search query.
   * In profile summary, the profiles with the same
   * [Profile.group_id][google.cloud.talent.v4beta1.Profile.group_id] are merged
   * together. Among profiles, same education/employment records may be slightly
   * different but they are merged into one with best efforts.
   * For example, in one profile the school name is "UC Berkeley" and the field
   * study is "Computer Science" and in another one the school name is
   * "University of California at Berkeley" and the field study is "CS". The API
   * merges these two inputs into one and selects one value for each field. For
   * example, the school name in summary is set to "University of California at
   * Berkeley" and the field of study is set to "Computer Science".
   * </pre>
   *
   * <code>.google.cloud.talent.v4beta1.Profile summary = 2;</code>
   */
  com.google.cloud.talent.v4beta1.ProfileOrBuilder getSummaryOrBuilder();
}
