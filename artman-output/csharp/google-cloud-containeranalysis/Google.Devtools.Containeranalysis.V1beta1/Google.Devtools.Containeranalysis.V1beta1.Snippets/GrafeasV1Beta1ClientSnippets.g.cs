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

namespace Google.Devtools.Containeranalysis.V1beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grafeas.V1Beta1;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedGrafeasV1Beta1ClientSnippets
    {
        /// <summary>Snippet for GetOccurrenceAsync</summary>
        public async Task GetOccurrenceAsync()
        {
            // Snippet: GetOccurrenceAsync(OccurrenceName,CallSettings)
            // Additional: GetOccurrenceAsync(OccurrenceName,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            Occurrence response = await grafeasV1Beta1Client.GetOccurrenceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrence</summary>
        public void GetOccurrence()
        {
            // Snippet: GetOccurrence(OccurrenceName,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            Occurrence response = grafeasV1Beta1Client.GetOccurrence(name);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceAsync</summary>
        public async Task GetOccurrenceAsync_RequestObject()
        {
            // Snippet: GetOccurrenceAsync(GetOccurrenceRequest,CallSettings)
            // Additional: GetOccurrenceAsync(GetOccurrenceRequest,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            GetOccurrenceRequest request = new GetOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            Occurrence response = await grafeasV1Beta1Client.GetOccurrenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrence</summary>
        public void GetOccurrence_RequestObject()
        {
            // Snippet: GetOccurrence(GetOccurrenceRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            GetOccurrenceRequest request = new GetOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            Occurrence response = grafeasV1Beta1Client.GetOccurrence(request);
            // End snippet
        }

        /// <summary>Snippet for ListOccurrencesAsync</summary>
        public async Task ListOccurrencesAsync()
        {
            // Snippet: ListOccurrencesAsync(ProjectName,string,string,int?,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> response =
                grafeasV1Beta1Client.ListOccurrencesAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Occurrence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOccurrencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOccurrences</summary>
        public void ListOccurrences()
        {
            // Snippet: ListOccurrences(ProjectName,string,string,int?,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListOccurrencesResponse, Occurrence> response =
                grafeasV1Beta1Client.ListOccurrences(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Occurrence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOccurrencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOccurrencesAsync</summary>
        public async Task ListOccurrencesAsync_RequestObject()
        {
            // Snippet: ListOccurrencesAsync(ListOccurrencesRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ListOccurrencesRequest request = new ListOccurrencesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> response =
                grafeasV1Beta1Client.ListOccurrencesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Occurrence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOccurrencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOccurrences</summary>
        public void ListOccurrences_RequestObject()
        {
            // Snippet: ListOccurrences(ListOccurrencesRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            ListOccurrencesRequest request = new ListOccurrencesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListOccurrencesResponse, Occurrence> response =
                grafeasV1Beta1Client.ListOccurrences(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Occurrence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOccurrencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteOccurrenceAsync</summary>
        public async Task DeleteOccurrenceAsync()
        {
            // Snippet: DeleteOccurrenceAsync(OccurrenceName,CallSettings)
            // Additional: DeleteOccurrenceAsync(OccurrenceName,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            await grafeasV1Beta1Client.DeleteOccurrenceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteOccurrence</summary>
        public void DeleteOccurrence()
        {
            // Snippet: DeleteOccurrence(OccurrenceName,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            grafeasV1Beta1Client.DeleteOccurrence(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteOccurrenceAsync</summary>
        public async Task DeleteOccurrenceAsync_RequestObject()
        {
            // Snippet: DeleteOccurrenceAsync(DeleteOccurrenceRequest,CallSettings)
            // Additional: DeleteOccurrenceAsync(DeleteOccurrenceRequest,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            DeleteOccurrenceRequest request = new DeleteOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            await grafeasV1Beta1Client.DeleteOccurrenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteOccurrence</summary>
        public void DeleteOccurrence_RequestObject()
        {
            // Snippet: DeleteOccurrence(DeleteOccurrenceRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            DeleteOccurrenceRequest request = new DeleteOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            grafeasV1Beta1Client.DeleteOccurrence(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOccurrenceAsync</summary>
        public async Task CreateOccurrenceAsync()
        {
            // Snippet: CreateOccurrenceAsync(ProjectName,Occurrence,CallSettings)
            // Additional: CreateOccurrenceAsync(ProjectName,Occurrence,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            Occurrence occurrence = new Occurrence();
            // Make the request
            Occurrence response = await grafeasV1Beta1Client.CreateOccurrenceAsync(parent, occurrence);
            // End snippet
        }

        /// <summary>Snippet for CreateOccurrence</summary>
        public void CreateOccurrence()
        {
            // Snippet: CreateOccurrence(ProjectName,Occurrence,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            Occurrence occurrence = new Occurrence();
            // Make the request
            Occurrence response = grafeasV1Beta1Client.CreateOccurrence(parent, occurrence);
            // End snippet
        }

        /// <summary>Snippet for CreateOccurrenceAsync</summary>
        public async Task CreateOccurrenceAsync_RequestObject()
        {
            // Snippet: CreateOccurrenceAsync(CreateOccurrenceRequest,CallSettings)
            // Additional: CreateOccurrenceAsync(CreateOccurrenceRequest,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            CreateOccurrenceRequest request = new CreateOccurrenceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            // Make the request
            Occurrence response = await grafeasV1Beta1Client.CreateOccurrenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOccurrence</summary>
        public void CreateOccurrence_RequestObject()
        {
            // Snippet: CreateOccurrence(CreateOccurrenceRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            CreateOccurrenceRequest request = new CreateOccurrenceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            // Make the request
            Occurrence response = grafeasV1Beta1Client.CreateOccurrence(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOccurrencesAsync</summary>
        public async Task BatchCreateOccurrencesAsync()
        {
            // Snippet: BatchCreateOccurrencesAsync(ProjectName,IEnumerable<Occurrence>,CallSettings)
            // Additional: BatchCreateOccurrencesAsync(ProjectName,IEnumerable<Occurrence>,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            IEnumerable<Occurrence> occurrences = new List<Occurrence>();
            // Make the request
            BatchCreateOccurrencesResponse response = await grafeasV1Beta1Client.BatchCreateOccurrencesAsync(parent, occurrences);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOccurrences</summary>
        public void BatchCreateOccurrences()
        {
            // Snippet: BatchCreateOccurrences(ProjectName,IEnumerable<Occurrence>,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            IEnumerable<Occurrence> occurrences = new List<Occurrence>();
            // Make the request
            BatchCreateOccurrencesResponse response = grafeasV1Beta1Client.BatchCreateOccurrences(parent, occurrences);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOccurrencesAsync</summary>
        public async Task BatchCreateOccurrencesAsync_RequestObject()
        {
            // Snippet: BatchCreateOccurrencesAsync(BatchCreateOccurrencesRequest,CallSettings)
            // Additional: BatchCreateOccurrencesAsync(BatchCreateOccurrencesRequest,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            BatchCreateOccurrencesRequest request = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrences = { },
            };
            // Make the request
            BatchCreateOccurrencesResponse response = await grafeasV1Beta1Client.BatchCreateOccurrencesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOccurrences</summary>
        public void BatchCreateOccurrences_RequestObject()
        {
            // Snippet: BatchCreateOccurrences(BatchCreateOccurrencesRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            BatchCreateOccurrencesRequest request = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrences = { },
            };
            // Make the request
            BatchCreateOccurrencesResponse response = grafeasV1Beta1Client.BatchCreateOccurrences(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateOccurrenceAsync</summary>
        public async Task UpdateOccurrenceAsync()
        {
            // Snippet: UpdateOccurrenceAsync(OccurrenceName,Occurrence,FieldMask,CallSettings)
            // Additional: UpdateOccurrenceAsync(OccurrenceName,Occurrence,FieldMask,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            Occurrence occurrence = new Occurrence();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Occurrence response = await grafeasV1Beta1Client.UpdateOccurrenceAsync(name, occurrence, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateOccurrence</summary>
        public void UpdateOccurrence()
        {
            // Snippet: UpdateOccurrence(OccurrenceName,Occurrence,FieldMask,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            Occurrence occurrence = new Occurrence();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Occurrence response = grafeasV1Beta1Client.UpdateOccurrence(name, occurrence, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateOccurrenceAsync</summary>
        public async Task UpdateOccurrenceAsync_RequestObject()
        {
            // Snippet: UpdateOccurrenceAsync(UpdateOccurrenceRequest,CallSettings)
            // Additional: UpdateOccurrenceAsync(UpdateOccurrenceRequest,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
            };
            // Make the request
            Occurrence response = await grafeasV1Beta1Client.UpdateOccurrenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateOccurrence</summary>
        public void UpdateOccurrence_RequestObject()
        {
            // Snippet: UpdateOccurrence(UpdateOccurrenceRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
            };
            // Make the request
            Occurrence response = grafeasV1Beta1Client.UpdateOccurrence(request);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceNoteAsync</summary>
        public async Task GetOccurrenceNoteAsync()
        {
            // Snippet: GetOccurrenceNoteAsync(OccurrenceName,CallSettings)
            // Additional: GetOccurrenceNoteAsync(OccurrenceName,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            Note response = await grafeasV1Beta1Client.GetOccurrenceNoteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceNote</summary>
        public void GetOccurrenceNote()
        {
            // Snippet: GetOccurrenceNote(OccurrenceName,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            Note response = grafeasV1Beta1Client.GetOccurrenceNote(name);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceNoteAsync</summary>
        public async Task GetOccurrenceNoteAsync_RequestObject()
        {
            // Snippet: GetOccurrenceNoteAsync(GetOccurrenceNoteRequest,CallSettings)
            // Additional: GetOccurrenceNoteAsync(GetOccurrenceNoteRequest,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            GetOccurrenceNoteRequest request = new GetOccurrenceNoteRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            Note response = await grafeasV1Beta1Client.GetOccurrenceNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceNote</summary>
        public void GetOccurrenceNote_RequestObject()
        {
            // Snippet: GetOccurrenceNote(GetOccurrenceNoteRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            GetOccurrenceNoteRequest request = new GetOccurrenceNoteRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            Note response = grafeasV1Beta1Client.GetOccurrenceNote(request);
            // End snippet
        }

        /// <summary>Snippet for GetNoteAsync</summary>
        public async Task GetNoteAsync()
        {
            // Snippet: GetNoteAsync(NoteName,CallSettings)
            // Additional: GetNoteAsync(NoteName,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            // Make the request
            Note response = await grafeasV1Beta1Client.GetNoteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNote</summary>
        public void GetNote()
        {
            // Snippet: GetNote(NoteName,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            // Make the request
            Note response = grafeasV1Beta1Client.GetNote(name);
            // End snippet
        }

        /// <summary>Snippet for GetNoteAsync</summary>
        public async Task GetNoteAsync_RequestObject()
        {
            // Snippet: GetNoteAsync(GetNoteRequest,CallSettings)
            // Additional: GetNoteAsync(GetNoteRequest,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            GetNoteRequest request = new GetNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            Note response = await grafeasV1Beta1Client.GetNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNote</summary>
        public void GetNote_RequestObject()
        {
            // Snippet: GetNote(GetNoteRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            GetNoteRequest request = new GetNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            Note response = grafeasV1Beta1Client.GetNote(request);
            // End snippet
        }

        /// <summary>Snippet for ListNotesAsync</summary>
        public async Task ListNotesAsync()
        {
            // Snippet: ListNotesAsync(ProjectName,string,string,int?,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListNotesResponse, Note> response =
                grafeasV1Beta1Client.ListNotesAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Note item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Note item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Note> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Note item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotes</summary>
        public void ListNotes()
        {
            // Snippet: ListNotes(ProjectName,string,string,int?,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListNotesResponse, Note> response =
                grafeasV1Beta1Client.ListNotes(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Note item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Note item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Note> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Note item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotesAsync</summary>
        public async Task ListNotesAsync_RequestObject()
        {
            // Snippet: ListNotesAsync(ListNotesRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ListNotesRequest request = new ListNotesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNotesResponse, Note> response =
                grafeasV1Beta1Client.ListNotesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Note item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Note item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Note> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Note item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotes</summary>
        public void ListNotes_RequestObject()
        {
            // Snippet: ListNotes(ListNotesRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            ListNotesRequest request = new ListNotesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListNotesResponse, Note> response =
                grafeasV1Beta1Client.ListNotes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Note item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Note item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Note> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Note item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteNoteAsync</summary>
        public async Task DeleteNoteAsync()
        {
            // Snippet: DeleteNoteAsync(NoteName,CallSettings)
            // Additional: DeleteNoteAsync(NoteName,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            // Make the request
            await grafeasV1Beta1Client.DeleteNoteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNote</summary>
        public void DeleteNote()
        {
            // Snippet: DeleteNote(NoteName,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            // Make the request
            grafeasV1Beta1Client.DeleteNote(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNoteAsync</summary>
        public async Task DeleteNoteAsync_RequestObject()
        {
            // Snippet: DeleteNoteAsync(DeleteNoteRequest,CallSettings)
            // Additional: DeleteNoteAsync(DeleteNoteRequest,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            DeleteNoteRequest request = new DeleteNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            await grafeasV1Beta1Client.DeleteNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNote</summary>
        public void DeleteNote_RequestObject()
        {
            // Snippet: DeleteNote(DeleteNoteRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            DeleteNoteRequest request = new DeleteNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            grafeasV1Beta1Client.DeleteNote(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNoteAsync</summary>
        public async Task CreateNoteAsync()
        {
            // Snippet: CreateNoteAsync(ProjectName,string,Note,CallSettings)
            // Additional: CreateNoteAsync(ProjectName,string,Note,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string noteId = "";
            Note note = new Note();
            // Make the request
            Note response = await grafeasV1Beta1Client.CreateNoteAsync(parent, noteId, note);
            // End snippet
        }

        /// <summary>Snippet for CreateNote</summary>
        public void CreateNote()
        {
            // Snippet: CreateNote(ProjectName,string,Note,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string noteId = "";
            Note note = new Note();
            // Make the request
            Note response = grafeasV1Beta1Client.CreateNote(parent, noteId, note);
            // End snippet
        }

        /// <summary>Snippet for CreateNoteAsync</summary>
        public async Task CreateNoteAsync_RequestObject()
        {
            // Snippet: CreateNoteAsync(CreateNoteRequest,CallSettings)
            // Additional: CreateNoteAsync(CreateNoteRequest,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            CreateNoteRequest request = new CreateNoteRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                NoteId = "",
                Note = new Note(),
            };
            // Make the request
            Note response = await grafeasV1Beta1Client.CreateNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNote</summary>
        public void CreateNote_RequestObject()
        {
            // Snippet: CreateNote(CreateNoteRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            CreateNoteRequest request = new CreateNoteRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                NoteId = "",
                Note = new Note(),
            };
            // Make the request
            Note response = grafeasV1Beta1Client.CreateNote(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNotesAsync</summary>
        public async Task BatchCreateNotesAsync()
        {
            // Snippet: BatchCreateNotesAsync(ProjectName,IDictionary<string, Note>,CallSettings)
            // Additional: BatchCreateNotesAsync(ProjectName,IDictionary<string, Note>,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            IDictionary<string, Note> notes = new Dictionary<string, Note>();
            // Make the request
            BatchCreateNotesResponse response = await grafeasV1Beta1Client.BatchCreateNotesAsync(parent, notes);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNotes</summary>
        public void BatchCreateNotes()
        {
            // Snippet: BatchCreateNotes(ProjectName,IDictionary<string, Note>,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            IDictionary<string, Note> notes = new Dictionary<string, Note>();
            // Make the request
            BatchCreateNotesResponse response = grafeasV1Beta1Client.BatchCreateNotes(parent, notes);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNotesAsync</summary>
        public async Task BatchCreateNotesAsync_RequestObject()
        {
            // Snippet: BatchCreateNotesAsync(BatchCreateNotesRequest,CallSettings)
            // Additional: BatchCreateNotesAsync(BatchCreateNotesRequest,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            BatchCreateNotesRequest request = new BatchCreateNotesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Notes = { },
            };
            // Make the request
            BatchCreateNotesResponse response = await grafeasV1Beta1Client.BatchCreateNotesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNotes</summary>
        public void BatchCreateNotes_RequestObject()
        {
            // Snippet: BatchCreateNotes(BatchCreateNotesRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            BatchCreateNotesRequest request = new BatchCreateNotesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Notes = { },
            };
            // Make the request
            BatchCreateNotesResponse response = grafeasV1Beta1Client.BatchCreateNotes(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNoteAsync</summary>
        public async Task UpdateNoteAsync()
        {
            // Snippet: UpdateNoteAsync(NoteName,Note,FieldMask,CallSettings)
            // Additional: UpdateNoteAsync(NoteName,Note,FieldMask,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            Note note = new Note();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Note response = await grafeasV1Beta1Client.UpdateNoteAsync(name, note, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateNote</summary>
        public void UpdateNote()
        {
            // Snippet: UpdateNote(NoteName,Note,FieldMask,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            Note note = new Note();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Note response = grafeasV1Beta1Client.UpdateNote(name, note, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateNoteAsync</summary>
        public async Task UpdateNoteAsync_RequestObject()
        {
            // Snippet: UpdateNoteAsync(UpdateNoteRequest,CallSettings)
            // Additional: UpdateNoteAsync(UpdateNoteRequest,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                Note = new Note(),
            };
            // Make the request
            Note response = await grafeasV1Beta1Client.UpdateNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNote</summary>
        public void UpdateNote_RequestObject()
        {
            // Snippet: UpdateNote(UpdateNoteRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                Note = new Note(),
            };
            // Make the request
            Note response = grafeasV1Beta1Client.UpdateNote(request);
            // End snippet
        }

        /// <summary>Snippet for ListNoteOccurrencesAsync</summary>
        public async Task ListNoteOccurrencesAsync()
        {
            // Snippet: ListNoteOccurrencesAsync(NoteName,string,string,int?,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> response =
                grafeasV1Beta1Client.ListNoteOccurrencesAsync(name, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Occurrence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNoteOccurrencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNoteOccurrences</summary>
        public void ListNoteOccurrences()
        {
            // Snippet: ListNoteOccurrences(NoteName,string,string,int?,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> response =
                grafeasV1Beta1Client.ListNoteOccurrences(name, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Occurrence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNoteOccurrencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNoteOccurrencesAsync</summary>
        public async Task ListNoteOccurrencesAsync_RequestObject()
        {
            // Snippet: ListNoteOccurrencesAsync(ListNoteOccurrencesRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ListNoteOccurrencesRequest request = new ListNoteOccurrencesRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> response =
                grafeasV1Beta1Client.ListNoteOccurrencesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Occurrence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNoteOccurrencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNoteOccurrences</summary>
        public void ListNoteOccurrences_RequestObject()
        {
            // Snippet: ListNoteOccurrences(ListNoteOccurrencesRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            ListNoteOccurrencesRequest request = new ListNoteOccurrencesRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> response =
                grafeasV1Beta1Client.ListNoteOccurrences(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Occurrence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNoteOccurrencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityOccurrencesSummaryAsync</summary>
        public async Task GetVulnerabilityOccurrencesSummaryAsync()
        {
            // Snippet: GetVulnerabilityOccurrencesSummaryAsync(ProjectName,string,CallSettings)
            // Additional: GetVulnerabilityOccurrencesSummaryAsync(ProjectName,string,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string filter = "";
            // Make the request
            VulnerabilityOccurrencesSummary response = await grafeasV1Beta1Client.GetVulnerabilityOccurrencesSummaryAsync(parent, filter);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityOccurrencesSummary</summary>
        public void GetVulnerabilityOccurrencesSummary()
        {
            // Snippet: GetVulnerabilityOccurrencesSummary(ProjectName,string,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string filter = "";
            // Make the request
            VulnerabilityOccurrencesSummary response = grafeasV1Beta1Client.GetVulnerabilityOccurrencesSummary(parent, filter);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityOccurrencesSummaryAsync</summary>
        public async Task GetVulnerabilityOccurrencesSummaryAsync_RequestObject()
        {
            // Snippet: GetVulnerabilityOccurrencesSummaryAsync(GetVulnerabilityOccurrencesSummaryRequest,CallSettings)
            // Additional: GetVulnerabilityOccurrencesSummaryAsync(GetVulnerabilityOccurrencesSummaryRequest,CancellationToken)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = await GrafeasV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            GetVulnerabilityOccurrencesSummaryRequest request = new GetVulnerabilityOccurrencesSummaryRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            VulnerabilityOccurrencesSummary response = await grafeasV1Beta1Client.GetVulnerabilityOccurrencesSummaryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityOccurrencesSummary</summary>
        public void GetVulnerabilityOccurrencesSummary_RequestObject()
        {
            // Snippet: GetVulnerabilityOccurrencesSummary(GetVulnerabilityOccurrencesSummaryRequest,CallSettings)
            // Create client
            GrafeasV1Beta1Client grafeasV1Beta1Client = GrafeasV1Beta1Client.Create();
            // Initialize request argument(s)
            GetVulnerabilityOccurrencesSummaryRequest request = new GetVulnerabilityOccurrencesSummaryRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            VulnerabilityOccurrencesSummary response = grafeasV1Beta1Client.GetVulnerabilityOccurrencesSummary(request);
            // End snippet
        }

    }
}
