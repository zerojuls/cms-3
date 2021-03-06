﻿using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.CMS.Core;
using SiteServer.CMS.Model;
using SiteServer.Plugin;

namespace SiteServer.Cli.Updater.Model40
{
    public partial class TableChannelGroup
    {
        [JsonProperty("nodeGroupName")]
        public string NodeGroupName { get; set; }

        [JsonProperty("publishmentSystemID")]
        public long PublishmentSystemId { get; set; }

        [JsonProperty("taxis")]
        public long Taxis { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class TableChannelGroup
    {
        public const string OldTableName = "NodeGroup";

        public static ConvertInfo Converter => new ConvertInfo
        {
            NewTableName = NewTableName,
            NewColumns = NewColumns,
            ConvertKeyDict = ConvertKeyDict,
            ConvertValueDict = ConvertValueDict
        };

        private static readonly string NewTableName = DataProvider.ChannelGroupDao.TableName;

        private static readonly List<TableColumn> NewColumns = DataProvider.ChannelGroupDao.TableColumns;

        private static readonly Dictionary<string, string> ConvertKeyDict =
            new Dictionary<string, string>
            {
                {nameof(ChannelGroupInfo.GroupName), nameof(NodeGroupName)},
                {nameof(ChannelGroupInfo.SiteId), nameof(PublishmentSystemId)}
            };

        private static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}
