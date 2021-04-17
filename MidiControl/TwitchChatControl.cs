﻿using System;
using System.Collections.Generic;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Models;

namespace MidiControl
{
    class TwitchChatControl : IExternalControl
    {
        private static TwitchChatControl _instance;
        private TwitchClient client;
        private readonly Dictionary<string, KeyBindEntry> config;
        private readonly OptionsManagment.Options options;
        private bool isReady = false;
        public TwitchChatControl(OptionsManagment.Options options, Dictionary<string, KeyBindEntry> config)
        {
            _instance = this;
            this.config = config;
            this.options = options;
            this.Connect();
        }

        public static TwitchChatControl GetInstance()
        {
            return _instance;
        }

        public void Connect()
        {
            try
            {
                isReady = false;
                ConnectionCredentials credentials = new ConnectionCredentials(options.TwitchLogin, options.TwitchToken);
                var clientOptions = new ClientOptions
                {
                    MessagesAllowedInPeriod = 750,
                    ThrottlingPeriod = TimeSpan.FromSeconds(30)
                };
                WebSocketClient customClient = new WebSocketClient(clientOptions);
                client = new TwitchClient(customClient);
                client.Initialize(credentials);
#if DEBUG
                client.OnLog += Client_OnLog;
#endif
                client.OnConnected += Client_OnConnected;
                client.Connect();
            }
            catch (Exception)
            {

            }
        }
#if DEBUG
        private void Client_OnLog(object sender, OnLogArgs e)
        {
            Console.WriteLine($"{e.DateTime.ToString()}: {e.BotUsername} - {e.Data}");
        }
#endif

        public void SendMessage(string channel, string message)
        {
            if (!isReady) return;

            bool sent = false;
            foreach(JoinedChannel chan in client.JoinedChannels)
            {
                if(chan.Channel == channel)
                {
                    string[] lines = message.Split(new[] { Environment.NewLine },StringSplitOptions.None);
                    foreach (string line in lines)
                    {
                        client.SendMessage(chan, line);
                    }
                    sent = true;
                }
            }

            if (! sent) 
            {
                client.JoinChannel(channel);
            }
        }

        private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            foreach (KeyValuePair<string, KeyBindEntry> entry in config)
            {
                if (entry.Value.TwitchCallBackON != null)
                {
                    client.JoinChannel(entry.Value.TwitchCallBackON.Channel);
                }
                if (entry.Value.TwitchCallBackOFF != null)
                {
                    client.JoinChannel(entry.Value.TwitchCallBackOFF.Channel);
                }
            }
            isReady = true;
        }

        public bool IsEnabled()
        {
            return isReady;
        }
    }
}
