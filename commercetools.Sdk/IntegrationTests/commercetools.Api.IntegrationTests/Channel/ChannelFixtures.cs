using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Models.Channels;
using static commercetools.Api.IntegrationTests.GenericFixture;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.Api.Models.Common;

namespace commercetools.Api.IntegrationTests.Channel
{
    public class ChannelFixtures
    {
        #region DraftBuilds

        public static ChannelDraft DefaultChannelDraft(ChannelDraft channelDraft)
        {
            var randomInt = TestingUtility.RandomInt();
            var randomStr = TestingUtility.RandomString();

            channelDraft.Key = $"Channel-Key-${randomInt}";
            channelDraft.GeoLocation = new GeoJsonPoint()
            {
                Type = "Point",
                Coordinates = new List<decimal>() { 18, 9 }
            };

            channelDraft.Roles = new List<IChannelRoleEnum>()
            {
                IChannelRoleEnum.InventorySupply
            };

            return channelDraft;
        }

        #endregion

        public static ChannelDraft DefaultChannelDraftWithKey(ChannelDraft draft, string key)
        {
            var channelDraft = DefaultChannelDraft(draft);
            channelDraft.Key = key;

            return channelDraft;
        }

        // public static async Task<IChannelSigninResult>
        public static async Task<IChannel> CreateChannel(IClient client, ChannelDraft channelDraft)
        {
            try
            {
                return await client
                    .WithApi()
                    .WithProjectKey(DefaultProjectKey)
                    .Channels()
                    .Post(channelDraft)
                    .ExecuteAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static async Task DeleteChannel(IClient client, IChannel channel)
        {
            try
            {
                await client
                    .WithApi()
                    .WithProjectKey(DefaultProjectKey)
                    .Channels()
                    .WithId(channel.Id)
                    .Delete()
                    .WithVersion(channel.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #region

        public static async Task WithChannel(IClient client, Func<ChannelDraft, ChannelDraft> draftAction,
            Action<IChannel> func)
        {
            await With(client, new ChannelDraft(), draftAction, func, CreateChannel, DeleteChannel);
        }

        public static async Task WithChannel(IClient client, Func<ChannelDraft, ChannelDraft> draftAction,
            Func<IChannel, Task> func)
        {
            await WithAsync(client, new ChannelDraft(), draftAction, func, CreateChannel, DeleteChannel);
        }

        public static async Task WithUpdateableChannel(IClient client, Func<IChannel, Task<IChannel>> func)
        {
            await WithUpdateableAsync(client, new ChannelDraft(), DefaultChannelDraft, func, CreateChannel,
                DeleteChannel);
        }

        #endregion
    }
}