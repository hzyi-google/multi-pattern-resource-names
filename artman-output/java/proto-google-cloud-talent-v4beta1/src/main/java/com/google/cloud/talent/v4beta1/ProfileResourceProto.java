// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4beta1/profile.proto

package com.google.cloud.talent.v4beta1;

public final class ProfileResourceProto {
  private ProfileResourceProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_Profile_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_Profile_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_Profile_CustomAttributesEntry_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_Profile_CustomAttributesEntry_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_AvailabilitySignal_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_AvailabilitySignal_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_Resume_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_Resume_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_PersonName_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_PersonName_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_PersonName_PersonStructuredName_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_PersonName_PersonStructuredName_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_Address_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_Address_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_Email_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_Email_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_Phone_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_Phone_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_PersonalUri_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_PersonalUri_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_AdditionalContactInfo_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_AdditionalContactInfo_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_EmploymentRecord_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_EmploymentRecord_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_EducationRecord_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_EducationRecord_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_Degree_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_Degree_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_Activity_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_Activity_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_Publication_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_Publication_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_talent_v4beta1_Patent_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_talent_v4beta1_Patent_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n)google/cloud/talent/v4beta1/profile.pr" +
      "oto\022\033google.cloud.talent.v4beta1\032\037google" +
      "/api/field_behavior.proto\032\031google/api/re" +
      "source.proto\032(google/cloud/talent/v4beta" +
      "1/common.proto\032\036google/protobuf/duration" +
      ".proto\032\037google/protobuf/timestamp.proto\032" +
      "\036google/protobuf/wrappers.proto\032\026google/" +
      "type/date.proto\032 google/type/postal_addr" +
      "ess.proto\032\034google/api/annotations.proto\"" +
      "\366\r\n\007Profile\022\014\n\004name\030\001 \001(\t\022\023\n\013external_id" +
      "\030\002 \001(\t\022\016\n\006source\030\003 \001(\t\022\013\n\003uri\030\004 \001(\t\022\020\n\010g" +
      "roup_id\030\005 \001(\t\022.\n\nis_hirable\030\006 \001(\0132\032.goog" +
      "le.protobuf.BoolValue\022/\n\013create_time\030\007 \001" +
      "(\0132\032.google.protobuf.Timestamp\022/\n\013update" +
      "_time\030\010 \001(\0132\032.google.protobuf.Timestamp\022" +
      "9\n\025candidate_update_time\030C \001(\0132\032.google." +
      "protobuf.Timestamp\0226\n\022resume_update_time" +
      "\030D \001(\0132\032.google.protobuf.Timestamp\0223\n\006re" +
      "sume\0305 \001(\0132#.google.cloud.talent.v4beta1" +
      ".Resume\022=\n\014person_names\030\013 \003(\0132\'.google.c" +
      "loud.talent.v4beta1.PersonName\0227\n\taddres" +
      "ses\030\014 \003(\0132$.google.cloud.talent.v4beta1." +
      "Address\022;\n\017email_addresses\030\r \003(\0132\".googl" +
      "e.cloud.talent.v4beta1.Email\0229\n\rphone_nu" +
      "mbers\030\016 \003(\0132\".google.cloud.talent.v4beta" +
      "1.Phone\022?\n\rpersonal_uris\030\017 \003(\0132(.google." +
      "cloud.talent.v4beta1.PersonalUri\022S\n\027addi" +
      "tional_contact_info\030\020 \003(\01322.google.cloud" +
      ".talent.v4beta1.AdditionalContactInfo\022I\n" +
      "\022employment_records\030\021 \003(\0132-.google.cloud" +
      ".talent.v4beta1.EmploymentRecord\022G\n\021educ" +
      "ation_records\030\022 \003(\0132,.google.cloud.talen" +
      "t.v4beta1.EducationRecord\0222\n\006skills\030\023 \003(" +
      "\0132\".google.cloud.talent.v4beta1.Skill\0229\n" +
      "\nactivities\030\024 \003(\0132%.google.cloud.talent." +
      "v4beta1.Activity\022>\n\014publications\030\025 \003(\0132(" +
      ".google.cloud.talent.v4beta1.Publication" +
      "\0224\n\007patents\030\026 \003(\0132#.google.cloud.talent." +
      "v4beta1.Patent\022B\n\016certifications\030\027 \003(\0132*" +
      ".google.cloud.talent.v4beta1.Certificati" +
      "on\022\031\n\014applications\030/ \003(\tB\003\340A\003\022\030\n\013assignm" +
      "ents\0300 \003(\tB\003\340A\003\022U\n\021custom_attributes\030\032 \003" +
      "(\0132:.google.cloud.talent.v4beta1.Profile" +
      ".CustomAttributesEntry\022\026\n\tprocessed\030\033 \001(" +
      "\010B\003\340A\003\022\034\n\017keyword_snippet\030\034 \001(\tB\003\340A\003\022R\n\024" +
      "availability_signals\030F \003(\0132/.google.clou" +
      "d.talent.v4beta1.AvailabilitySignalB\003\340A\003" +
      "\022E\n\021derived_addresses\030@ \003(\0132%.google.clo" +
      "ud.talent.v4beta1.LocationB\003\340A\003\032e\n\025Custo" +
      "mAttributesEntry\022\013\n\003key\030\001 \001(\t\022;\n\005value\030\002" +
      " \001(\0132,.google.cloud.talent.v4beta1.Custo" +
      "mAttribute:\0028\001:X\352AU\n\033jobs.googleapis.com" +
      "/Profile\0226projects/{project}/tenants/{te" +
      "nant}/profiles/{profile}\"\303\001\n\022Availabilit" +
      "ySignal\022A\n\004type\030\001 \001(\01623.google.cloud.tal" +
      "ent.v4beta1.AvailabilitySignalType\0224\n\020la" +
      "st_update_time\030\002 \001(\0132\032.google.protobuf.T" +
      "imestamp\0224\n\020filter_satisfied\030\003 \001(\0132\032.goo" +
      "gle.protobuf.BoolValue\"\265\001\n\006Resume\022\031\n\021str" +
      "uctured_resume\030\001 \001(\t\022C\n\013resume_type\030\002 \001(" +
      "\0162..google.cloud.talent.v4beta1.Resume.R" +
      "esumeType\"K\n\nResumeType\022\033\n\027RESUME_TYPE_U" +
      "NSPECIFIED\020\000\022\t\n\005HRXML\020\001\022\025\n\021OTHER_RESUME_" +
      "TYPE\020\002\"\274\002\n\nPersonName\022\030\n\016formatted_name\030" +
      "\001 \001(\tH\000\022W\n\017structured_name\030\002 \001(\0132<.googl" +
      "e.cloud.talent.v4beta1.PersonName.Person" +
      "StructuredNameH\000\022\026\n\016preferred_name\030\003 \001(\t" +
      "\032\223\001\n\024PersonStructuredName\022\022\n\ngiven_name\030" +
      "\001 \001(\t\022\026\n\016preferred_name\030\006 \001(\t\022\026\n\016middle_" +
      "initial\030\002 \001(\t\022\023\n\013family_name\030\003 \001(\t\022\020\n\010su" +
      "ffixes\030\004 \003(\t\022\020\n\010prefixes\030\005 \003(\tB\r\n\013person" +
      "_name\"\331\001\n\007Address\022<\n\005usage\030\001 \001(\0162-.googl" +
      "e.cloud.talent.v4beta1.ContactInfoUsage\022" +
      "\036\n\024unstructured_address\030\002 \001(\tH\000\0228\n\022struc" +
      "tured_address\030\003 \001(\0132\032.google.type.Postal" +
      "AddressH\000\022+\n\007current\030\004 \001(\0132\032.google.prot" +
      "obuf.BoolValueB\t\n\007address\"\\\n\005Email\022<\n\005us" +
      "age\030\001 \001(\0162-.google.cloud.talent.v4beta1." +
      "ContactInfoUsage\022\025\n\remail_address\030\002 \001(\t\"" +
      "\317\002\n\005Phone\022<\n\005usage\030\001 \001(\0162-.google.cloud." +
      "talent.v4beta1.ContactInfoUsage\022:\n\004type\030" +
      "\002 \001(\0162,.google.cloud.talent.v4beta1.Phon" +
      "e.PhoneType\022\016\n\006number\030\003 \001(\t\022\026\n\016when_avai" +
      "lable\030\004 \001(\t\"\243\001\n\tPhoneType\022\032\n\026PHONE_TYPE_" +
      "UNSPECIFIED\020\000\022\014\n\010LANDLINE\020\001\022\n\n\006MOBILE\020\002\022" +
      "\007\n\003FAX\020\003\022\t\n\005PAGER\020\004\022\016\n\nTTY_OR_TDD\020\005\022\r\n\tV" +
      "OICEMAIL\020\006\022\013\n\007VIRTUAL\020\007\022\010\n\004VOIP\020\010\022\026\n\022MOB" +
      "ILE_OR_LANDLINE\020\t\"\032\n\013PersonalUri\022\013\n\003uri\030" +
      "\001 \001(\t\"w\n\025AdditionalContactInfo\022<\n\005usage\030" +
      "\001 \001(\0162-.google.cloud.talent.v4beta1.Cont" +
      "actInfoUsage\022\014\n\004name\030\002 \001(\t\022\022\n\ncontact_id" +
      "\030\003 \001(\t\"\362\003\n\020EmploymentRecord\022%\n\nstart_dat" +
      "e\030\001 \001(\0132\021.google.type.Date\022#\n\010end_date\030\002" +
      " \001(\0132\021.google.type.Date\022\025\n\remployer_name" +
      "\030\003 \001(\t\022\025\n\rdivision_name\030\004 \001(\t\0225\n\007address" +
      "\030\005 \001(\0132$.google.cloud.talent.v4beta1.Add" +
      "ress\022\021\n\tjob_title\030\006 \001(\t\022\027\n\017job_descripti" +
      "on\030\007 \001(\t\0221\n\ris_supervisor\030\010 \001(\0132\032.google" +
      ".protobuf.BoolValue\0224\n\020is_self_employed\030" +
      "\t \001(\0132\032.google.protobuf.BoolValue\022.\n\nis_" +
      "current\030\n \001(\0132\032.google.protobuf.BoolValu" +
      "e\022\036\n\021job_title_snippet\030\013 \001(\tB\003\340A\003\022$\n\027job" +
      "_description_snippet\030\014 \001(\tB\003\340A\003\022\"\n\025emplo" +
      "yer_name_snippet\030\r \001(\tB\003\340A\003\"\314\003\n\017Educatio" +
      "nRecord\022%\n\nstart_date\030\001 \001(\0132\021.google.typ" +
      "e.Date\022#\n\010end_date\030\002 \001(\0132\021.google.type.D" +
      "ate\0223\n\030expected_graduation_date\030\003 \001(\0132\021." +
      "google.type.Date\022\023\n\013school_name\030\004 \001(\t\0225\n" +
      "\007address\030\005 \001(\0132$.google.cloud.talent.v4b" +
      "eta1.Address\022\034\n\022degree_description\030\006 \001(\t" +
      "H\000\022@\n\021structured_degree\030\007 \001(\0132#.google.c" +
      "loud.talent.v4beta1.DegreeH\000\022\023\n\013descript" +
      "ion\030\010 \001(\t\022.\n\nis_current\030\t \001(\0132\032.google.p" +
      "rotobuf.BoolValue\022 \n\023school_name_snippet" +
      "\030\n \001(\tB\003\340A\003\022\033\n\016degree_snippet\030\013 \001(\tB\003\340A\003" +
      "B\010\n\006degree\"t\n\006Degree\022<\n\013degree_type\030\001 \001(" +
      "\0162\'.google.cloud.talent.v4beta1.DegreeTy" +
      "pe\022\023\n\013degree_name\030\002 \001(\t\022\027\n\017fields_of_stu" +
      "dy\030\003 \003(\t\"\322\002\n\010Activity\022\024\n\014display_name\030\001 " +
      "\001(\t\022\023\n\013description\030\002 \001(\t\022\013\n\003uri\030\003 \001(\t\022&\n" +
      "\013create_date\030\004 \001(\0132\021.google.type.Date\022&\n" +
      "\013update_date\030\005 \001(\0132\021.google.type.Date\022\024\n" +
      "\014team_members\030\006 \003(\t\0227\n\013skills_used\030\007 \003(\013" +
      "2\".google.cloud.talent.v4beta1.Skill\022\"\n\025" +
      "activity_name_snippet\030\010 \001(\tB\003\340A\003\022)\n\034acti" +
      "vity_description_snippet\030\t \001(\tB\003\340A\003\022 \n\023s" +
      "kills_used_snippet\030\n \003(\tB\003\340A\003\"\313\001\n\013Public" +
      "ation\022\017\n\007authors\030\001 \003(\t\022\r\n\005title\030\002 \001(\t\022\023\n" +
      "\013description\030\003 \001(\t\022\017\n\007journal\030\004 \001(\t\022\016\n\006v" +
      "olume\030\005 \001(\t\022\021\n\tpublisher\030\006 \001(\t\022+\n\020public" +
      "ation_date\030\007 \001(\0132\021.google.type.Date\022\030\n\020p" +
      "ublication_type\030\010 \001(\t\022\014\n\004isbn\030\t \001(\t\"\251\002\n\006" +
      "Patent\022\024\n\014display_name\030\001 \001(\t\022\021\n\tinventor" +
      "s\030\002 \003(\t\022\025\n\rpatent_status\030\003 \001(\t\022-\n\022patent" +
      "_status_date\030\004 \001(\0132\021.google.type.Date\022-\n" +
      "\022patent_filing_date\030\005 \001(\0132\021.google.type." +
      "Date\022\025\n\rpatent_office\030\006 \001(\t\022\025\n\rpatent_nu" +
      "mber\030\007 \001(\t\022\032\n\022patent_description\030\010 \001(\t\0227" +
      "\n\013skills_used\030\t \003(\0132\".google.cloud.talen" +
      "t.v4beta1.SkillB\202\001\n\037com.google.cloud.tal" +
      "ent.v4beta1B\024ProfileResourceProtoP\001ZAgoo" +
      "gle.golang.org/genproto/googleapis/cloud" +
      "/talent/v4beta1;talent\242\002\003CTSb\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.FieldBehaviorProto.getDescriptor(),
          com.google.api.ResourceProto.getDescriptor(),
          com.google.cloud.talent.v4beta1.CommonProto.getDescriptor(),
          com.google.protobuf.DurationProto.getDescriptor(),
          com.google.protobuf.TimestampProto.getDescriptor(),
          com.google.protobuf.WrappersProto.getDescriptor(),
          com.google.type.DateProto.getDescriptor(),
          com.google.type.PostalAddressProto.getDescriptor(),
          com.google.api.AnnotationsProto.getDescriptor(),
        });
    internal_static_google_cloud_talent_v4beta1_Profile_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_talent_v4beta1_Profile_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_Profile_descriptor,
        new java.lang.String[] { "Name", "ExternalId", "Source", "Uri", "GroupId", "IsHirable", "CreateTime", "UpdateTime", "CandidateUpdateTime", "ResumeUpdateTime", "Resume", "PersonNames", "Addresses", "EmailAddresses", "PhoneNumbers", "PersonalUris", "AdditionalContactInfo", "EmploymentRecords", "EducationRecords", "Skills", "Activities", "Publications", "Patents", "Certifications", "Applications", "Assignments", "CustomAttributes", "Processed", "KeywordSnippet", "AvailabilitySignals", "DerivedAddresses", });
    internal_static_google_cloud_talent_v4beta1_Profile_CustomAttributesEntry_descriptor =
      internal_static_google_cloud_talent_v4beta1_Profile_descriptor.getNestedTypes().get(0);
    internal_static_google_cloud_talent_v4beta1_Profile_CustomAttributesEntry_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_Profile_CustomAttributesEntry_descriptor,
        new java.lang.String[] { "Key", "Value", });
    internal_static_google_cloud_talent_v4beta1_AvailabilitySignal_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_cloud_talent_v4beta1_AvailabilitySignal_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_AvailabilitySignal_descriptor,
        new java.lang.String[] { "Type", "LastUpdateTime", "FilterSatisfied", });
    internal_static_google_cloud_talent_v4beta1_Resume_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_google_cloud_talent_v4beta1_Resume_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_Resume_descriptor,
        new java.lang.String[] { "StructuredResume", "ResumeType", });
    internal_static_google_cloud_talent_v4beta1_PersonName_descriptor =
      getDescriptor().getMessageTypes().get(3);
    internal_static_google_cloud_talent_v4beta1_PersonName_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_PersonName_descriptor,
        new java.lang.String[] { "FormattedName", "StructuredName", "PreferredName", "PersonName", });
    internal_static_google_cloud_talent_v4beta1_PersonName_PersonStructuredName_descriptor =
      internal_static_google_cloud_talent_v4beta1_PersonName_descriptor.getNestedTypes().get(0);
    internal_static_google_cloud_talent_v4beta1_PersonName_PersonStructuredName_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_PersonName_PersonStructuredName_descriptor,
        new java.lang.String[] { "GivenName", "PreferredName", "MiddleInitial", "FamilyName", "Suffixes", "Prefixes", });
    internal_static_google_cloud_talent_v4beta1_Address_descriptor =
      getDescriptor().getMessageTypes().get(4);
    internal_static_google_cloud_talent_v4beta1_Address_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_Address_descriptor,
        new java.lang.String[] { "Usage", "UnstructuredAddress", "StructuredAddress", "Current", "Address", });
    internal_static_google_cloud_talent_v4beta1_Email_descriptor =
      getDescriptor().getMessageTypes().get(5);
    internal_static_google_cloud_talent_v4beta1_Email_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_Email_descriptor,
        new java.lang.String[] { "Usage", "EmailAddress", });
    internal_static_google_cloud_talent_v4beta1_Phone_descriptor =
      getDescriptor().getMessageTypes().get(6);
    internal_static_google_cloud_talent_v4beta1_Phone_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_Phone_descriptor,
        new java.lang.String[] { "Usage", "Type", "Number", "WhenAvailable", });
    internal_static_google_cloud_talent_v4beta1_PersonalUri_descriptor =
      getDescriptor().getMessageTypes().get(7);
    internal_static_google_cloud_talent_v4beta1_PersonalUri_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_PersonalUri_descriptor,
        new java.lang.String[] { "Uri", });
    internal_static_google_cloud_talent_v4beta1_AdditionalContactInfo_descriptor =
      getDescriptor().getMessageTypes().get(8);
    internal_static_google_cloud_talent_v4beta1_AdditionalContactInfo_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_AdditionalContactInfo_descriptor,
        new java.lang.String[] { "Usage", "Name", "ContactId", });
    internal_static_google_cloud_talent_v4beta1_EmploymentRecord_descriptor =
      getDescriptor().getMessageTypes().get(9);
    internal_static_google_cloud_talent_v4beta1_EmploymentRecord_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_EmploymentRecord_descriptor,
        new java.lang.String[] { "StartDate", "EndDate", "EmployerName", "DivisionName", "Address", "JobTitle", "JobDescription", "IsSupervisor", "IsSelfEmployed", "IsCurrent", "JobTitleSnippet", "JobDescriptionSnippet", "EmployerNameSnippet", });
    internal_static_google_cloud_talent_v4beta1_EducationRecord_descriptor =
      getDescriptor().getMessageTypes().get(10);
    internal_static_google_cloud_talent_v4beta1_EducationRecord_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_EducationRecord_descriptor,
        new java.lang.String[] { "StartDate", "EndDate", "ExpectedGraduationDate", "SchoolName", "Address", "DegreeDescription", "StructuredDegree", "Description", "IsCurrent", "SchoolNameSnippet", "DegreeSnippet", "Degree", });
    internal_static_google_cloud_talent_v4beta1_Degree_descriptor =
      getDescriptor().getMessageTypes().get(11);
    internal_static_google_cloud_talent_v4beta1_Degree_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_Degree_descriptor,
        new java.lang.String[] { "DegreeType", "DegreeName", "FieldsOfStudy", });
    internal_static_google_cloud_talent_v4beta1_Activity_descriptor =
      getDescriptor().getMessageTypes().get(12);
    internal_static_google_cloud_talent_v4beta1_Activity_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_Activity_descriptor,
        new java.lang.String[] { "DisplayName", "Description", "Uri", "CreateDate", "UpdateDate", "TeamMembers", "SkillsUsed", "ActivityNameSnippet", "ActivityDescriptionSnippet", "SkillsUsedSnippet", });
    internal_static_google_cloud_talent_v4beta1_Publication_descriptor =
      getDescriptor().getMessageTypes().get(13);
    internal_static_google_cloud_talent_v4beta1_Publication_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_Publication_descriptor,
        new java.lang.String[] { "Authors", "Title", "Description", "Journal", "Volume", "Publisher", "PublicationDate", "PublicationType", "Isbn", });
    internal_static_google_cloud_talent_v4beta1_Patent_descriptor =
      getDescriptor().getMessageTypes().get(14);
    internal_static_google_cloud_talent_v4beta1_Patent_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_talent_v4beta1_Patent_descriptor,
        new java.lang.String[] { "DisplayName", "Inventors", "PatentStatus", "PatentStatusDate", "PatentFilingDate", "PatentOffice", "PatentNumber", "PatentDescription", "SkillsUsed", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.FieldBehaviorProto.fieldBehavior);
    registry.add(com.google.api.ResourceProto.resource);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.api.FieldBehaviorProto.getDescriptor();
    com.google.api.ResourceProto.getDescriptor();
    com.google.cloud.talent.v4beta1.CommonProto.getDescriptor();
    com.google.protobuf.DurationProto.getDescriptor();
    com.google.protobuf.TimestampProto.getDescriptor();
    com.google.protobuf.WrappersProto.getDescriptor();
    com.google.type.DateProto.getDescriptor();
    com.google.type.PostalAddressProto.getDescriptor();
    com.google.api.AnnotationsProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}