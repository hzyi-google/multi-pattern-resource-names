// Copyright 2019 Google LLC
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

// Note: this file is purely for documentation. Any contents are not expected
// to be loaded as the JS file.

/**
 * PackageManager provides metadata about available / installed packages.
 * @typedef PackageManager
 * @memberof google.devtools.containeranalysis.v1alpha1
 * @see [google.devtools.containeranalysis.v1alpha1.PackageManager definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/bill_of_materials.proto}
 */
const PackageManager = {
  // This is for documentation. Actual contents will be loaded by gRPC.

  /**
   * This represents a particular channel of distribution for a given package.
   * e.g. Debian's jessie-backports dpkg mirror
   *
   * @property {string} cpeUri
   *   The cpe_uri in [cpe format](https://cpe.mitre.org/specification/)
   *   denoting the package manager version distributing a package.
   *
   * @property {number} architecture
   *   The CPU architecture for which packages in this distribution
   *   channel were built
   *
   *   The number should be among the values of [Architecture]{@link google.devtools.containeranalysis.v1alpha1.Architecture}
   *
   * @property {Object} latestVersion
   *   The latest available version of this package in
   *   this distribution channel.
   *
   *   This object should have the same structure as [Version]{@link google.devtools.containeranalysis.v1alpha1.Version}
   *
   * @property {string} maintainer
   *   A freeform string denoting the maintainer of this package.
   *
   * @property {string} url
   *   The distribution channel-specific homepage for this package.
   *
   * @property {string} description
   *   The distribution channel-specific description of this package.
   *
   * @typedef Distribution
   * @memberof google.devtools.containeranalysis.v1alpha1
   * @see [google.devtools.containeranalysis.v1alpha1.PackageManager.Distribution definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/bill_of_materials.proto}
   */
  Distribution: {
    // This is for documentation. Actual contents will be loaded by gRPC.
  },

  /**
   * An occurrence of a particular package installation found within a
   * system's filesystem.
   * e.g. glibc was found in /var/lib/dpkg/status
   *
   * @property {string} cpeUri
   *   The cpe_uri in [cpe format](https://cpe.mitre.org/specification/)
   *   denoting the package manager version distributing a package.
   *
   * @property {Object} version
   *   The version installed at this location.
   *
   *   This object should have the same structure as [Version]{@link google.devtools.containeranalysis.v1alpha1.Version}
   *
   * @property {string} path
   *   The path from which we gathered that this package/version is installed.
   *
   * @typedef Location
   * @memberof google.devtools.containeranalysis.v1alpha1
   * @see [google.devtools.containeranalysis.v1alpha1.PackageManager.Location definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/bill_of_materials.proto}
   */
  Location: {
    // This is for documentation. Actual contents will be loaded by gRPC.
  },

  /**
   * This represents a particular package that is distributed over
   * various channels.
   * e.g. glibc (aka libc6) is distributed by many, at various versions.
   *
   * @property {string} name
   *   The name of the package.
   *
   * @property {Object[]} distribution
   *   The various channels by which a package is distributed.
   *
   *   This object should have the same structure as [Distribution]{@link google.devtools.containeranalysis.v1alpha1.Distribution}
   *
   * @typedef Package
   * @memberof google.devtools.containeranalysis.v1alpha1
   * @see [google.devtools.containeranalysis.v1alpha1.PackageManager.Package definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/bill_of_materials.proto}
   */
  Package: {
    // This is for documentation. Actual contents will be loaded by gRPC.
  },

  /**
   * This represents how a particular software package may be installed on
   * a system.
   *
   * @property {string} name
   *   Output only. The name of the installed package.
   *
   * @property {Object[]} location
   *   All of the places within the filesystem versions of this package
   *   have been found.
   *
   *   This object should have the same structure as [Location]{@link google.devtools.containeranalysis.v1alpha1.Location}
   *
   * @typedef Installation
   * @memberof google.devtools.containeranalysis.v1alpha1
   * @see [google.devtools.containeranalysis.v1alpha1.PackageManager.Installation definition in proto format]{@link https://github.com/googleapis/googleapis/blob/master/google/devtools/containeranalysis/v1alpha1/bill_of_materials.proto}
   */
  Installation: {
    // This is for documentation. Actual contents will be loaded by gRPC.
  },

  /**
   * Instruction set architectures supported by various package managers.
   *
   * @enum {number}
   * @memberof google.devtools.containeranalysis.v1alpha1
   */
  Architecture: {

    /**
     * Unknown architecture
     */
    ARCHITECTURE_UNSPECIFIED: 0,

    /**
     * X86 architecture
     */
    X86: 1,

    /**
     * X64 architecture
     */
    X64: 2
  }
};