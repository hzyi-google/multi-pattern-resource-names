// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using sys = System;
using scg = System.Collections.Generic;
using linq = System.Linq;

namespace Google.Cloud.Logging.V2
{
    /// <summary>
    /// Resource name for the 'billing_account' resource.
    /// </summary>
    public sealed partial class BillingAccountName : gax::IResourceName, sys::IEquatable<BillingAccountName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("billingAccounts/{billing_account}");

        /// <summary>
        /// Parses the given billing_account resource name in string form into a new
        /// <see cref="BillingAccountName"/> instance.
        /// </summary>
        /// <param name="billingAccountName">The billing_account resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BillingAccountName"/> if successful.</returns>
        public static BillingAccountName Parse(string billingAccountName)
        {
            gax::GaxPreconditions.CheckNotNull(billingAccountName, nameof(billingAccountName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(billingAccountName);
            return new BillingAccountName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given billing_account resource name in string form into a new
        /// <see cref="BillingAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="billingAccountName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="billingAccountName">The billing_account resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="BillingAccountName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string billingAccountName, out BillingAccountName result)
        {
            gax::GaxPreconditions.CheckNotNull(billingAccountName, nameof(billingAccountName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(billingAccountName, out resourceName))
            {
                result = new BillingAccountName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="BillingAccountName"/>.</summary>
        /// <param name="billingAccountId">The <c>billingAccount</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="BillingAccountName"/>.</returns>
        public static string Format(string billingAccountId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(billingAccountId, nameof(billingAccountId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="BillingAccountName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="billingAccountId">The billingAccount ID. Must not be <c>null</c>.</param>
        public BillingAccountName(string billingAccountId)
        {
            BillingAccountId = gax::GaxPreconditions.CheckNotNull(billingAccountId, nameof(billingAccountId));
        }

        /// <summary>
        /// The billingAccount ID. Never <c>null</c>.
        /// </summary>
        public string BillingAccountId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(BillingAccountId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as BillingAccountName);

        /// <inheritdoc />
        public bool Equals(BillingAccountName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(BillingAccountName a, BillingAccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(BillingAccountName a, BillingAccountName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'billing_account_location' resource.
    /// </summary>
    public sealed partial class BillingAccountLocationName : gax::IResourceName, sys::IEquatable<BillingAccountLocationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("billingAccounts/{billing_account}/locations/{location}");

        /// <summary>
        /// Parses the given billing_account_location resource name in string form into a new
        /// <see cref="BillingAccountLocationName"/> instance.
        /// </summary>
        /// <param name="billingAccountLocationName">The billing_account_location resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BillingAccountLocationName"/> if successful.</returns>
        public static BillingAccountLocationName Parse(string billingAccountLocationName)
        {
            gax::GaxPreconditions.CheckNotNull(billingAccountLocationName, nameof(billingAccountLocationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(billingAccountLocationName);
            return new BillingAccountLocationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given billing_account_location resource name in string form into a new
        /// <see cref="BillingAccountLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="billingAccountLocationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="billingAccountLocationName">The billing_account_location resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="BillingAccountLocationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string billingAccountLocationName, out BillingAccountLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(billingAccountLocationName, nameof(billingAccountLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(billingAccountLocationName, out resourceName))
            {
                result = new BillingAccountLocationName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="BillingAccountLocationName"/>.</summary>
        /// <param name="billingAccountId">The <c>billingAccount</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="BillingAccountLocationName"/>.</returns>
        public static string Format(string billingAccountId, string locationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="BillingAccountLocationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="billingAccountId">The billingAccount ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        public BillingAccountLocationName(string billingAccountId, string locationId)
        {
            BillingAccountId = gax::GaxPreconditions.CheckNotNull(billingAccountId, nameof(billingAccountId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
        }

        /// <summary>
        /// The billingAccount ID. Never <c>null</c>.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(BillingAccountId, LocationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as BillingAccountLocationName);

        /// <inheritdoc />
        public bool Equals(BillingAccountLocationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(BillingAccountLocationName a, BillingAccountLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(BillingAccountLocationName a, BillingAccountLocationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// </list>
    /// </remarks>
    public sealed partial class CmekSettingsNameOneof : gax::IResourceName, sys::IEquatable<CmekSettingsNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="CmekSettingsNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="CmekSettingsNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="CmekSettingsNameOneof"/> if successful.</returns>
        public static CmekSettingsNameOneof Parse(string name, bool allowUnknown)
        {
            CmekSettingsNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="CmekSettingsNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CmekSettingsNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out CmekSettingsNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new CmekSettingsNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CmekSettingsNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public CmekSettingsNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CmekSettingsNameOneof);

        /// <inheritdoc />
        public bool Equals(CmekSettingsNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CmekSettingsNameOneof a, CmekSettingsNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CmekSettingsNameOneof a, CmekSettingsNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'folder' resource.
    /// </summary>
    public sealed partial class FolderName : gax::IResourceName, sys::IEquatable<FolderName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("folders/{folder}");

        /// <summary>
        /// Parses the given folder resource name in string form into a new
        /// <see cref="FolderName"/> instance.
        /// </summary>
        /// <param name="folderName">The folder resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FolderName"/> if successful.</returns>
        public static FolderName Parse(string folderName)
        {
            gax::GaxPreconditions.CheckNotNull(folderName, nameof(folderName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(folderName);
            return new FolderName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given folder resource name in string form into a new
        /// <see cref="FolderName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="folderName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="folderName">The folder resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FolderName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderName, out FolderName result)
        {
            gax::GaxPreconditions.CheckNotNull(folderName, nameof(folderName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(folderName, out resourceName))
            {
                result = new FolderName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="FolderName"/>.</summary>
        /// <param name="folderId">The <c>folder</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="FolderName"/>.</returns>
        public static string Format(string folderId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(folderId, nameof(folderId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="FolderName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="folderId">The folder ID. Must not be <c>null</c>.</param>
        public FolderName(string folderId)
        {
            FolderId = gax::GaxPreconditions.CheckNotNull(folderId, nameof(folderId));
        }

        /// <summary>
        /// The folder ID. Never <c>null</c>.
        /// </summary>
        public string FolderId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(FolderId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FolderName);

        /// <inheritdoc />
        public bool Equals(FolderName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FolderName a, FolderName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FolderName a, FolderName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'folder_location' resource.
    /// </summary>
    public sealed partial class FolderLocationName : gax::IResourceName, sys::IEquatable<FolderLocationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("folders/{folder}/locations/{location}");

        /// <summary>
        /// Parses the given folder_location resource name in string form into a new
        /// <see cref="FolderLocationName"/> instance.
        /// </summary>
        /// <param name="folderLocationName">The folder_location resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FolderLocationName"/> if successful.</returns>
        public static FolderLocationName Parse(string folderLocationName)
        {
            gax::GaxPreconditions.CheckNotNull(folderLocationName, nameof(folderLocationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(folderLocationName);
            return new FolderLocationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given folder_location resource name in string form into a new
        /// <see cref="FolderLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="folderLocationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="folderLocationName">The folder_location resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FolderLocationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderLocationName, out FolderLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(folderLocationName, nameof(folderLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(folderLocationName, out resourceName))
            {
                result = new FolderLocationName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="FolderLocationName"/>.</summary>
        /// <param name="folderId">The <c>folder</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="FolderLocationName"/>.</returns>
        public static string Format(string folderId, string locationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="FolderLocationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="folderId">The folder ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        public FolderLocationName(string folderId, string locationId)
        {
            FolderId = gax::GaxPreconditions.CheckNotNull(folderId, nameof(folderId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
        }

        /// <summary>
        /// The folder ID. Never <c>null</c>.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(FolderId, LocationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FolderLocationName);

        /// <inheritdoc />
        public bool Equals(FolderLocationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FolderLocationName a, FolderLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FolderLocationName a, FolderLocationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'location' resource.
    /// </summary>
    public sealed partial class LocationName : gax::IResourceName, sys::IEquatable<LocationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}");

        /// <summary>
        /// Parses the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationName"/> if successful.</returns>
        public static LocationName Parse(string locationName)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(locationName);
            return new LocationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="locationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationName, out LocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(locationName, out resourceName))
            {
                result = new LocationName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="LocationName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="LocationName"/>.</returns>
        public static string Format(string projectId, string locationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="LocationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        public LocationName(string projectId, string locationId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LocationName);

        /// <inheritdoc />
        public bool Equals(LocationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LocationName a, LocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LocationName a, LocationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// </list>
    /// </remarks>
    public sealed partial class LogBucketNameOneof : gax::IResourceName, sys::IEquatable<LogBucketNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="LogBucketNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="LogBucketNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="LogBucketNameOneof"/> if successful.</returns>
        public static LogBucketNameOneof Parse(string name, bool allowUnknown)
        {
            LogBucketNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="LogBucketNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LogBucketNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out LogBucketNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new LogBucketNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LogBucketNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public LogBucketNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LogBucketNameOneof);

        /// <inheritdoc />
        public bool Equals(LogBucketNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LogBucketNameOneof a, LogBucketNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LogBucketNameOneof a, LogBucketNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// </list>
    /// </remarks>
    public sealed partial class LogExclusionNameOneof : gax::IResourceName, sys::IEquatable<LogExclusionNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="LogExclusionNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="LogExclusionNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="LogExclusionNameOneof"/> if successful.</returns>
        public static LogExclusionNameOneof Parse(string name, bool allowUnknown)
        {
            LogExclusionNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="LogExclusionNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LogExclusionNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out LogExclusionNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new LogExclusionNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LogExclusionNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public LogExclusionNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LogExclusionNameOneof);

        /// <inheritdoc />
        public bool Equals(LogExclusionNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LogExclusionNameOneof a, LogExclusionNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LogExclusionNameOneof a, LogExclusionNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'log_metric' resource.
    /// </summary>
    public sealed partial class LogMetricName : gax::IResourceName, sys::IEquatable<LogMetricName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/metrics/{metric}");

        /// <summary>
        /// Parses the given log_metric resource name in string form into a new
        /// <see cref="LogMetricName"/> instance.
        /// </summary>
        /// <param name="logMetricName">The log_metric resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LogMetricName"/> if successful.</returns>
        public static LogMetricName Parse(string logMetricName)
        {
            gax::GaxPreconditions.CheckNotNull(logMetricName, nameof(logMetricName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(logMetricName);
            return new LogMetricName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given log_metric resource name in string form into a new
        /// <see cref="LogMetricName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="logMetricName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="logMetricName">The log_metric resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LogMetricName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logMetricName, out LogMetricName result)
        {
            gax::GaxPreconditions.CheckNotNull(logMetricName, nameof(logMetricName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(logMetricName, out resourceName))
            {
                result = new LogMetricName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="LogMetricName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="metricId">The <c>metric</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="LogMetricName"/>.</returns>
        public static string Format(string projectId, string metricId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(metricId, nameof(metricId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="LogMetricName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="metricId">The metric ID. Must not be <c>null</c>.</param>
        public LogMetricName(string projectId, string metricId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            MetricId = gax::GaxPreconditions.CheckNotNull(metricId, nameof(metricId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The metric ID. Never <c>null</c>.
        /// </summary>
        public string MetricId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, MetricId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LogMetricName);

        /// <inheritdoc />
        public bool Equals(LogMetricName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LogMetricName a, LogMetricName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LogMetricName a, LogMetricName b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// </list>
    /// </remarks>
    public sealed partial class LogNameOneof : gax::IResourceName, sys::IEquatable<LogNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="LogNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="LogNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="LogNameOneof"/> if successful.</returns>
        public static LogNameOneof Parse(string name, bool allowUnknown)
        {
            LogNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="LogNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LogNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out LogNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new LogNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LogNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public LogNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LogNameOneof);

        /// <inheritdoc />
        public bool Equals(LogNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LogNameOneof a, LogNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LogNameOneof a, LogNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// </list>
    /// </remarks>
    public sealed partial class LogSinkNameOneof : gax::IResourceName, sys::IEquatable<LogSinkNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="LogSinkNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="LogSinkNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="LogSinkNameOneof"/> if successful.</returns>
        public static LogSinkNameOneof Parse(string name, bool allowUnknown)
        {
            LogSinkNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="LogSinkNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LogSinkNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out LogSinkNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new LogSinkNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LogSinkNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public LogSinkNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LogSinkNameOneof);

        /// <inheritdoc />
        public bool Equals(LogSinkNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LogSinkNameOneof a, LogSinkNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LogSinkNameOneof a, LogSinkNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'organization' resource.
    /// </summary>
    public sealed partial class OrganizationName : gax::IResourceName, sys::IEquatable<OrganizationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}");

        /// <summary>
        /// Parses the given organization resource name in string form into a new
        /// <see cref="OrganizationName"/> instance.
        /// </summary>
        /// <param name="organizationName">The organization resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationName"/> if successful.</returns>
        public static OrganizationName Parse(string organizationName)
        {
            gax::GaxPreconditions.CheckNotNull(organizationName, nameof(organizationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(organizationName);
            return new OrganizationName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given organization resource name in string form into a new
        /// <see cref="OrganizationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="organizationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationName">The organization resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationName, out OrganizationName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationName, nameof(organizationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationName, out resourceName))
            {
                result = new OrganizationName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="OrganizationName"/>.</summary>
        /// <param name="organizationId">The <c>organization</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="OrganizationName"/>.</returns>
        public static string Format(string organizationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        public OrganizationName(string organizationId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationName);

        /// <inheritdoc />
        public bool Equals(OrganizationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationName a, OrganizationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationName a, OrganizationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'organization_location' resource.
    /// </summary>
    public sealed partial class OrganizationLocationName : gax::IResourceName, sys::IEquatable<OrganizationLocationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/locations/{location}");

        /// <summary>
        /// Parses the given organization_location resource name in string form into a new
        /// <see cref="OrganizationLocationName"/> instance.
        /// </summary>
        /// <param name="organizationLocationName">The organization_location resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationLocationName"/> if successful.</returns>
        public static OrganizationLocationName Parse(string organizationLocationName)
        {
            gax::GaxPreconditions.CheckNotNull(organizationLocationName, nameof(organizationLocationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(organizationLocationName);
            return new OrganizationLocationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given organization_location resource name in string form into a new
        /// <see cref="OrganizationLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="organizationLocationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationLocationName">The organization_location resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationLocationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationLocationName, out OrganizationLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationLocationName, nameof(organizationLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationLocationName, out resourceName))
            {
                result = new OrganizationLocationName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="OrganizationLocationName"/>.</summary>
        /// <param name="organizationId">The <c>organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="OrganizationLocationName"/>.</returns>
        public static string Format(string organizationId, string locationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationLocationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        public OrganizationLocationName(string organizationId, string locationId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, LocationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationLocationName);

        /// <inheritdoc />
        public bool Equals(OrganizationLocationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationLocationName a, OrganizationLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationLocationName a, OrganizationLocationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project' resource.
    /// </summary>
    public sealed partial class ProjectName : gax::IResourceName, sys::IEquatable<ProjectName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}");

        /// <summary>
        /// Parses the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectName"/> if successful.</returns>
        public static ProjectName Parse(string projectName)
        {
            gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(projectName);
            return new ProjectName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="projectName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectName, out ProjectName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectName, out resourceName))
            {
                result = new ProjectName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ProjectName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ProjectName"/>.</returns>
        public static string Format(string projectId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        public ProjectName(string projectId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectName);

        /// <inheritdoc />
        public bool Equals(ProjectName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectName a, ProjectName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectName a, ProjectName b) => !(a == b);
    }


    public partial class CmekSettings
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.CmekSettingsNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.CmekSettingsNameOneof CmekSettingsNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Logging.V2.CmekSettingsNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateExclusionRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Logging.V2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateLogMetricRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Logging.V2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateSinkRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Logging.V2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteExclusionRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogExclusionNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogExclusionNameOneof LogExclusionNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Logging.V2.LogExclusionNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteLogMetricRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogMetricName"/>-typed view over the <see cref="MetricName"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogMetricName MetricNameAsLogMetricName
        {
            get { return string.IsNullOrEmpty(MetricName) ? null : Google.Cloud.Logging.V2.LogMetricName.Parse(MetricName); }
            set { MetricName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteLogRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogNameOneof"/>-typed view over the <see cref="LogName"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogNameOneof LogNameAsLogNameOneof
        {
            get { return string.IsNullOrEmpty(LogName) ? null : Google.Cloud.Logging.V2.LogNameOneof.Parse(LogName, true); }
            set { LogName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteSinkRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogSinkNameOneof"/>-typed view over the <see cref="SinkName"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogSinkNameOneof SinkNameAsLogSinkNameOneof
        {
            get { return string.IsNullOrEmpty(SinkName) ? null : Google.Cloud.Logging.V2.LogSinkNameOneof.Parse(SinkName, true); }
            set { SinkName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetBucketRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogBucketNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogBucketNameOneof LogBucketNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Logging.V2.LogBucketNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetCmekSettingsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.CmekSettingsNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.CmekSettingsNameOneof CmekSettingsNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Logging.V2.CmekSettingsNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetExclusionRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogExclusionNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogExclusionNameOneof LogExclusionNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Logging.V2.LogExclusionNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetLogMetricRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogMetricName"/>-typed view over the <see cref="MetricName"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogMetricName MetricNameAsLogMetricName
        {
            get { return string.IsNullOrEmpty(MetricName) ? null : Google.Cloud.Logging.V2.LogMetricName.Parse(MetricName); }
            set { MetricName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetSinkRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogSinkNameOneof"/>-typed view over the <see cref="SinkName"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogSinkNameOneof SinkNameAsLogSinkNameOneof
        {
            get { return string.IsNullOrEmpty(SinkName) ? null : Google.Cloud.Logging.V2.LogSinkNameOneof.Parse(SinkName, true); }
            set { SinkName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListBucketsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Logging.V2.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListExclusionsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Logging.V2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListLogEntriesRequest
    {
        /// <summary>
        /// <see cref="gax::ResourceNameList{ProjectName}"/>-typed view over the <see cref="ResourceNames"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ProjectName> ResourceNamesAsProjectNames =>
            new gax::ResourceNameList<ProjectName>(ResourceNames,
                str => ProjectName.Parse(str));

    }

    public partial class ListLogMetricsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Logging.V2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListLogsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Logging.V2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListSinksRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Logging.V2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class LogBucket
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogBucketNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogBucketNameOneof LogBucketNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Logging.V2.LogBucketNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class LogEntry
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogNameOneof"/>-typed view over the <see cref="LogName"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogNameOneof LogNameAsLogNameOneof
        {
            get { return string.IsNullOrEmpty(LogName) ? null : Google.Cloud.Logging.V2.LogNameOneof.Parse(LogName, true); }
            set { LogName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class LogExclusion
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogExclusionNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogExclusionNameOneof LogExclusionNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Logging.V2.LogExclusionNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class LogMetric
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogMetricName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogMetricName LogMetricName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Logging.V2.LogMetricName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class LogSink
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogSinkNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogSinkNameOneof LogSinkNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Logging.V2.LogSinkNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Destination"/> resource name property.
        /// </summary>
        public gax::IResourceName DestinationAsResourceName
        {
            get { return string.IsNullOrEmpty(Destination) ? null : gax::UnknownResourceName.Parse(Destination); }
            set { Destination = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateBucketRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogBucketNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogBucketNameOneof LogBucketNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Logging.V2.LogBucketNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateExclusionRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogExclusionNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogExclusionNameOneof LogExclusionNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Logging.V2.LogExclusionNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateLogMetricRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogMetricName"/>-typed view over the <see cref="MetricName"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogMetricName MetricNameAsLogMetricName
        {
            get { return string.IsNullOrEmpty(MetricName) ? null : Google.Cloud.Logging.V2.LogMetricName.Parse(MetricName); }
            set { MetricName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateSinkRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogSinkNameOneof"/>-typed view over the <see cref="SinkName"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogSinkNameOneof SinkNameAsLogSinkNameOneof
        {
            get { return string.IsNullOrEmpty(SinkName) ? null : Google.Cloud.Logging.V2.LogSinkNameOneof.Parse(SinkName, true); }
            set { SinkName = value != null ? value.ToString() : ""; }
        }

    }

    public partial class WriteLogEntriesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Logging.V2.LogNameOneof"/>-typed view over the <see cref="LogName"/> resource name property.
        /// </summary>
        public Google.Cloud.Logging.V2.LogNameOneof LogNameAsLogNameOneof
        {
            get { return string.IsNullOrEmpty(LogName) ? null : Google.Cloud.Logging.V2.LogNameOneof.Parse(LogName, true); }
            set { LogName = value != null ? value.ToString() : ""; }
        }

    }

}