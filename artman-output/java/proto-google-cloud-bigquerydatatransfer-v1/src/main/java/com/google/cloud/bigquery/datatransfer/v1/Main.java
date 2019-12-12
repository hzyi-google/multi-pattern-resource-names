/*
 * Copyright 2018 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
 * in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under the License
 * is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and limitations under
 * the License.
 */

package com.google.cloud.bigquery.datatransfer.v1;

import com.google.common.collect.ImmutableList;
import java.util.List;

public class Main {

  public static void main(String[] args) {

    ParentName parentName1 = ParentName.of("my-project");
    System.out.println(parentName1.toString());

    ParentName parentName2 = ParentName.ofProjectName("my-project-1");
    System.out.println(parentName2.toString());

    ParentName parentName3 = ParentName.ofProjectLocationName("my-project-2", "my-location-1");
    System.out.println(parentName3.toString());

    System.out.println(ParentName.format("my-project-4"));

    System.out.println(ParentName.formatProjectName("my-project-5"));

    System.out.println(ParentName.formatProjectLocationName("my-project-6", "my-location-2"));

    ParentName parentName4 = ParentName.newBuilder().setProject("my-project-7").build();
    System.out.println(parentName4.toString());

    ParentName parentName5 = ParentName.newProjectBuilder().setProject("my-project-8").build();
    System.out.println(parentName5.toString());

    ParentName parentName6 =
        ParentName.newProjectLocationBuilder()
            .setProject("my-project-9")
            .setLocation("my-location-3")
            .build();
    System.out.println(parentName6.toString());

    ParentName parentName7 = parentName5.toBuilder().setProject("my-project-10").build();
    System.out.println(parentName7.toString());

    List<String> parentNameStrings =
        ImmutableList.of(
            parentName1.toString(),
            parentName2.toString(),
            parentName3.toString(),
            parentName4.toString(),
            parentName5.toString(),
            parentName6.toString(),
            parentName7.toString());
    List<ParentName> parentNames = ParentName.parse(parentNameStrings);
   	parentNameStrings = ParentName.toStrings(parentNames);
   	for (String p : parentNameStrings) {
   		System.out.println(p);
   	}

   	System.out.println(ParentName.isParsableFrom(parentName1.toString()));
   	System.out.println(ParentName.isParsableFrom(parentName1 + "/hahaha"));

   	System.out.println(parentName7.getFieldValue("project"));
   	System.out.println(parentName3.getFieldValue("location"));

   	System.out.println(parentName1.equals(parentName1.toBuilder().build()));
   	System.out.println(parentName1.hashCode());
  }
}
