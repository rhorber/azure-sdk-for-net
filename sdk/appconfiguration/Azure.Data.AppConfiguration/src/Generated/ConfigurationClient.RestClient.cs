// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.Data.AppConfiguration
{
    /// <summary></summary>
    public partial class ConfigurationClient
    {
        private static ResponseClassifier _pipelineMessageClassifier200;
        private static ResponseClassifier _pipelineMessageClassifier200204;
        private static ResponseClassifier _pipelineMessageClassifier201;

        private static ResponseClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 = new StatusCodeClassifier(stackalloc ushort[] { 200 });

        private static ResponseClassifier PipelineMessageClassifier200204 => _pipelineMessageClassifier200204 = new StatusCodeClassifier(stackalloc ushort[] { 200, 204 });

        private static ResponseClassifier PipelineMessageClassifier201 => _pipelineMessageClassifier201 = new StatusCodeClassifier(stackalloc ushort[] { 201 });

        internal HttpMessage CreateGetKeysRequest(string name, string after, string syncToken, string acceptDatetime, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/keys", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (name != null)
            {
                uri.AppendQuery("name", name, true);
            }
            if (after != null)
            {
                uri.AppendQuery("After", after, true);
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (acceptDatetime != null)
            {
                request.Headers.SetValue("Accept-Datetime", acceptDatetime);
            }
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.keyset+json");
            return message;
        }

        internal HttpMessage CreateNextGetKeysRequest(Uri nextPage, string name, string after, string syncToken, string acceptDatetime, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(nextPage);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.keyset+json");
            return message;
        }

        internal HttpMessage CreateCheckKeysRequest(string name, string after, string syncToken, string acceptDatetime, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Head;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/keys", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (name != null)
            {
                uri.AppendQuery("name", name, true);
            }
            if (after != null)
            {
                uri.AppendQuery("After", after, true);
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (acceptDatetime != null)
            {
                request.Headers.SetValue("Accept-Datetime", acceptDatetime);
            }
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetConfigurationSettingsRequest(string key, string label, string syncToken, string after, string acceptDatetime, IEnumerable<string> @select, string snapshot, MatchConditions matchConditions, IEnumerable<string> tags, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/kv", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (key != null)
            {
                uri.AppendQuery("key", key, true);
            }
            if (label != null)
            {
                uri.AppendQuery("label", label, true);
            }
            if (after != null)
            {
                uri.AppendQuery("After", after, true);
            }
            if (@select != null && !(@select is ChangeTrackingList<string> changeTrackingList && changeTrackingList.IsUndefined))
            {
                uri.AppendQueryDelimited("$Select", @select, ",", null, true);
            }
            if (snapshot != null)
            {
                uri.AppendQuery("snapshot", snapshot, true);
            }
            if (tags != null && !(tags is ChangeTrackingList<string> changeTrackingList0 && changeTrackingList0.IsUndefined))
            {
                foreach (var @param in tags)
                {
                    uri.AppendQuery("tags", @param, true);
                }
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (acceptDatetime != null)
            {
                request.Headers.SetValue("Accept-Datetime", acceptDatetime);
            }
            if (matchConditions != null)
            {
                request.Headers.Add(matchConditions);
            }
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.kvset+json");
            return message;
        }

        internal HttpMessage CreateNextGetConfigurationSettingsRequest(Uri nextPage, string key, string label, string syncToken, string after, string acceptDatetime, IEnumerable<string> @select, string snapshot, MatchConditions matchConditions, IEnumerable<string> tags, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(nextPage);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.kvset+json");
            return message;
        }

        internal HttpMessage CreateCheckKeyValuesRequest(string key, string label, string syncToken, string after, string acceptDatetime, IEnumerable<string> @select, string snapshot, MatchConditions matchConditions, IEnumerable<string> tags, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Head;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/kv", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (key != null)
            {
                uri.AppendQuery("key", key, true);
            }
            if (label != null)
            {
                uri.AppendQuery("label", label, true);
            }
            if (after != null)
            {
                uri.AppendQuery("After", after, true);
            }
            if (@select != null && !(@select is ChangeTrackingList<string> changeTrackingList && changeTrackingList.IsUndefined))
            {
                uri.AppendQueryDelimited("$Select", @select, ",", null, true);
            }
            if (snapshot != null)
            {
                uri.AppendQuery("snapshot", snapshot, true);
            }
            if (tags != null && !(tags is ChangeTrackingList<string> changeTrackingList0 && changeTrackingList0.IsUndefined))
            {
                foreach (var @param in tags)
                {
                    uri.AppendQuery("tags", @param, true);
                }
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (acceptDatetime != null)
            {
                request.Headers.SetValue("Accept-Datetime", acceptDatetime);
            }
            if (matchConditions != null)
            {
                request.Headers.Add(matchConditions);
            }
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetConfigurationSettingRequest(string key, string label, IEnumerable<SettingFields> @select, string syncToken, string acceptDatetime, MatchConditions matchConditions, IEnumerable<string> tags, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/kv/", false);
            uri.AppendPath(key, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (label != null)
            {
                uri.AppendQuery("label", label, true);
            }
            if (@select != null && !(@select is ChangeTrackingList<SettingFields> changeTrackingList && changeTrackingList.IsUndefined))
            {
                uri.AppendQueryDelimited("$Select", @select, ",", null, true);
            }
            if (tags != null && !(tags is ChangeTrackingList<string> changeTrackingList0 && changeTrackingList0.IsUndefined))
            {
                foreach (var @param in tags)
                {
                    uri.AppendQuery("tags", @param, true);
                }
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (acceptDatetime != null)
            {
                request.Headers.SetValue("Accept-Datetime", acceptDatetime);
            }
            if (matchConditions != null)
            {
                request.Headers.Add(matchConditions);
            }
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.kv+json");
            return message;
        }

        internal HttpMessage CreateSetConfigurationSettingInternalRequest(string key, string contentType, RequestContent content, string label, string syncToken, MatchConditions matchConditions, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Put;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/kv/", false);
            uri.AppendPath(key, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (label != null)
            {
                uri.AppendQuery("label", label, true);
            }
            request.Uri = uri;
            request.Headers.SetValue("Content-Type", contentType);
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (matchConditions != null)
            {
                request.Headers.Add(matchConditions);
            }
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.kv+json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateDeleteConfigurationSettingRequest(string key, string label, string syncToken, ETag? ifMatch, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200204);
            Request request = message.Request;
            request.Method = RequestMethod.Delete;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/kv/", false);
            uri.AppendPath(key, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (label != null)
            {
                uri.AppendQuery("label", label, true);
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch.Value);
            }
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.kv+json");
            return message;
        }

        internal HttpMessage CreateCheckKeyValueRequest(string key, string label, string syncToken, string acceptDatetime, MatchConditions matchConditions, IEnumerable<SettingFields> @select, IEnumerable<string> tags, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Head;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/kv/", false);
            uri.AppendPath(key, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (label != null)
            {
                uri.AppendQuery("label", label, true);
            }
            if (@select != null && !(@select is ChangeTrackingList<SettingFields> changeTrackingList && changeTrackingList.IsUndefined))
            {
                uri.AppendQueryDelimited("$Select", @select, ",", null, true);
            }
            if (tags != null && !(tags is ChangeTrackingList<string> changeTrackingList0 && changeTrackingList0.IsUndefined))
            {
                foreach (var @param in tags)
                {
                    uri.AppendQuery("tags", @param, true);
                }
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (acceptDatetime != null)
            {
                request.Headers.SetValue("Accept-Datetime", acceptDatetime);
            }
            if (matchConditions != null)
            {
                request.Headers.Add(matchConditions);
            }
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetSnapshotsRequest(string name, string after, IEnumerable<SnapshotFields> @select, IEnumerable<ConfigurationSnapshotStatus> status, string syncToken, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/snapshots", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (name != null)
            {
                uri.AppendQuery("name", name, true);
            }
            if (after != null)
            {
                uri.AppendQuery("After", after, true);
            }
            if (@select != null && !(@select is ChangeTrackingList<SnapshotFields> changeTrackingList && changeTrackingList.IsUndefined))
            {
                uri.AppendQueryDelimited("$Select", @select, ",", null, true);
            }
            if (status != null && !(status is ChangeTrackingList<ConfigurationSnapshotStatus> changeTrackingList0 && changeTrackingList0.IsUndefined))
            {
                uri.AppendQueryDelimited("status", status, ",", null, true);
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.snapshotset+json");
            return message;
        }

        internal HttpMessage CreateNextGetSnapshotsRequest(Uri nextPage, string name, string after, IEnumerable<SnapshotFields> @select, IEnumerable<ConfigurationSnapshotStatus> status, string syncToken, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(nextPage);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.snapshotset+json");
            return message;
        }

        internal HttpMessage CreateCheckSnapshotsRequest(string syncToken, string after, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Head;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/snapshots", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (after != null)
            {
                uri.AppendQuery("After", after, true);
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetSnapshotRequest(string name, IEnumerable<SnapshotFields> @select, string syncToken, MatchConditions matchConditions, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/snapshots/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (@select != null && !(@select is ChangeTrackingList<SnapshotFields> changeTrackingList && changeTrackingList.IsUndefined))
            {
                uri.AppendQueryDelimited("$Select", @select, ",", null, true);
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (matchConditions != null)
            {
                request.Headers.Add(matchConditions);
            }
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.snapshot+json");
            return message;
        }

        internal HttpMessage CreateGetOperationDetailsRequest(string snapshot, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/operations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("snapshot", snapshot, true);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateSnapshotRequest(string name, string contentType, RequestContent content, string syncToken, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier201);
            Request request = message.Request;
            request.Method = RequestMethod.Put;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/snapshots/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Content-Type", contentType);
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.snapshot+json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateUpdateSnapshotStatusRequest(string name, string contentType, RequestContent content, string syncToken, MatchConditions matchConditions, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Patch;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/snapshots/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Content-Type", contentType);
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (matchConditions != null)
            {
                request.Headers.Add(matchConditions);
            }
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.snapshot+json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateCheckSnapshotRequest(string name, string syncToken, MatchConditions matchConditions, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Head;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/snapshots/", false);
            uri.AppendPath(name, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (matchConditions != null)
            {
                request.Headers.Add(matchConditions);
            }
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetLabelsRequest(string name, string syncToken, string after, string acceptDatetime, IEnumerable<SettingLabelFields> @select, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/labels", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (name != null)
            {
                uri.AppendQuery("name", name, true);
            }
            if (after != null)
            {
                uri.AppendQuery("After", after, true);
            }
            if (@select != null && !(@select is ChangeTrackingList<SettingLabelFields> changeTrackingList && changeTrackingList.IsUndefined))
            {
                uri.AppendQueryDelimited("$Select", @select, ",", null, true);
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (acceptDatetime != null)
            {
                request.Headers.SetValue("Accept-Datetime", acceptDatetime);
            }
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.labelset+json");
            return message;
        }

        internal HttpMessage CreateNextGetLabelsRequest(Uri nextPage, string name, string syncToken, string after, string acceptDatetime, IEnumerable<SettingLabelFields> @select, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(nextPage);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.labelset+json");
            return message;
        }

        internal HttpMessage CreateCheckLabelsRequest(string name, string syncToken, string after, string acceptDatetime, IEnumerable<SettingLabelFields> @select, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Head;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/labels", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (name != null)
            {
                uri.AppendQuery("name", name, true);
            }
            if (after != null)
            {
                uri.AppendQuery("After", after, true);
            }
            if (@select != null && !(@select is ChangeTrackingList<SettingLabelFields> changeTrackingList && changeTrackingList.IsUndefined))
            {
                uri.AppendQueryDelimited("$Select", @select, ",", null, true);
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (acceptDatetime != null)
            {
                request.Headers.SetValue("Accept-Datetime", acceptDatetime);
            }
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateReadOnlyLockRequest(string key, string label, string syncToken, MatchConditions matchConditions, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Put;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/locks/", false);
            uri.AppendPath(key, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (label != null)
            {
                uri.AppendQuery("label", label, true);
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (matchConditions != null)
            {
                request.Headers.Add(matchConditions);
            }
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.kv+json");
            return message;
        }

        internal HttpMessage CreateDeleteReadOnlyLockRequest(string key, string label, string syncToken, MatchConditions matchConditions, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Delete;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/locks/", false);
            uri.AppendPath(key, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (label != null)
            {
                uri.AppendQuery("label", label, true);
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (matchConditions != null)
            {
                request.Headers.Add(matchConditions);
            }
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.kv+json");
            return message;
        }

        internal HttpMessage CreateGetRevisionsRequest(string key, string label, string syncToken, string after, string acceptDatetime, IEnumerable<string> @select, IEnumerable<string> tags, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/revisions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (key != null)
            {
                uri.AppendQuery("key", key, true);
            }
            if (label != null)
            {
                uri.AppendQuery("label", label, true);
            }
            if (after != null)
            {
                uri.AppendQuery("After", after, true);
            }
            if (@select != null && !(@select is ChangeTrackingList<string> changeTrackingList && changeTrackingList.IsUndefined))
            {
                uri.AppendQueryDelimited("$Select", @select, ",", null, true);
            }
            if (tags != null && !(tags is ChangeTrackingList<string> changeTrackingList0 && changeTrackingList0.IsUndefined))
            {
                foreach (var @param in tags)
                {
                    uri.AppendQuery("tags", @param, true);
                }
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (acceptDatetime != null)
            {
                request.Headers.SetValue("Accept-Datetime", acceptDatetime);
            }
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.kvset+json");
            return message;
        }

        internal HttpMessage CreateNextGetRevisionsRequest(Uri nextPage, string key, string label, string syncToken, string after, string acceptDatetime, IEnumerable<string> @select, IEnumerable<string> tags, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(nextPage);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/problem+json, application/vnd.microsoft.appconfig.kvset+json");
            return message;
        }

        internal HttpMessage CreateCheckRevisionsRequest(string key, string label, string syncToken, string after, string acceptDatetime, IEnumerable<string> @select, IEnumerable<string> tags, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Head;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/revisions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (key != null)
            {
                uri.AppendQuery("key", key, true);
            }
            if (label != null)
            {
                uri.AppendQuery("label", label, true);
            }
            if (after != null)
            {
                uri.AppendQuery("After", after, true);
            }
            if (@select != null && !(@select is ChangeTrackingList<string> changeTrackingList && changeTrackingList.IsUndefined))
            {
                uri.AppendQueryDelimited("$Select", @select, ",", null, true);
            }
            if (tags != null && !(tags is ChangeTrackingList<string> changeTrackingList0 && changeTrackingList0.IsUndefined))
            {
                foreach (var @param in tags)
                {
                    uri.AppendQuery("tags", @param, true);
                }
            }
            request.Uri = uri;
            if (syncToken != null)
            {
                request.Headers.SetValue("Sync-Token", syncToken);
            }
            if (acceptDatetime != null)
            {
                request.Headers.SetValue("Accept-Datetime", acceptDatetime);
            }
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }
    }
}
