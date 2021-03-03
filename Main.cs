using Rocket.API;
using Rocket.API.Collections;
using Rocket.Core.Commands;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;

namespace ChatGestures
{
    public class MQSPlugin : RocketPlugin<Config>

    {
        public static MQSPlugin Instance;

        public UnityEngine.Color MessageColor { get; private set; }
        protected override void Load()
        {
            {
                MQSPlugin.Instance = this;
                MessageColor = UnturnedChat.GetColorFromName(Configuration.Instance.MessageColor, UnityEngine.Color.white);
                Rocket.Unturned.Events.UnturnedPlayerEvents.OnPlayerUpdateGesture += GestureChange;
                Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
                Logger.LogWarning($"[{Name}] has been loaded! ");
                Logger.LogWarning("Dev: MQS#7816");
                Logger.LogWarning("Join this Discord for Support: https://discord.gg/Ssbpd9cvgp");
                Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");

                if(Configuration.Instance.PointBool == true)
                {
                    Logger.LogWarning("ChatGestures >> Point Enabled");
                }

                if(Configuration.Instance.SaluteBool == true)
                {
                    Logger.LogWarning("ChatGestures >> Salute Enabled");
                }

                if (Configuration.Instance.WaveBool == true)
                {
                    Logger.LogWarning("ChatGestures >> Wave Enabled");
                }

                if (Configuration.Instance.SurrenderStartBool == true)
                {
                    Logger.LogWarning("ChatGestures >> SurrenderStart Enabled");
                }

                if (Configuration.Instance.SurrenderStopBool == true)
                {
                    Logger.LogWarning("ChatGestures >> SurrenderStop Enabled");
                }

                if (Configuration.Instance.FacePalmBool == true)
                {
                    Logger.LogWarning("ChatGestures >> FacePalm Enabled");
                }

                if (Configuration.Instance.RestStartBool == true)
                {
                    Logger.LogWarning("ChatGestures >> RestStart Enabled");
                }

                if (Configuration.Instance.RestStopBool == true)
                {
                    Logger.LogWarning("ChatGestures >> RestStop Enabled");
                }

                //////////////////////////////////////////////////////////////////////

                if (Configuration.Instance.PointBool == false)
                {
                    Logger.LogError("ChatGestures >> Point Disabled");
                }

                if (Configuration.Instance.SaluteBool == false)
                {
                    Logger.LogError("ChatGestures >> Salute Disabled");
                }

                if (Configuration.Instance.WaveBool == false)
                {
                    Logger.LogError("ChatGestures >> Wave Disabled");
                }

                if (Configuration.Instance.SurrenderStartBool == false)
                {
                    Logger.LogError("ChatGestures >> SurrenderStart Disabled");
                }

                if (Configuration.Instance.SurrenderStopBool == false)
                {
                    Logger.LogError("ChatGestures >> SurrenderStop Disabled");
                }

                if (Configuration.Instance.FacePalmBool == false)
                {
                    Logger.LogError("ChatGestures >> FacePalm Disabled");
                }

                if (Configuration.Instance.RestStartBool == false)
                {
                    Logger.LogError("ChatGestures >> RestStart Disabled");
                }

                if (Configuration.Instance.RestStopBool == false)
                {
                    Logger.LogError("ChatGestures >> RestStop Disabled");
                }
            }
        }

        private void GestureChange(UnturnedPlayer player, UnturnedPlayerEvents.PlayerGesture gesture)
        {
            if (gesture == UnturnedPlayerEvents.PlayerGesture.Point)
            {
                if (Configuration.Instance.PointBool)
                {
                   var playername = "!playerName!";
                   var name = player.DisplayName;
                   var iconURL = MQSPlugin.Instance.Configuration.Instance.PointIcon;
                   ChatManager.serverSendMessage(MQSPlugin.Instance.Configuration.Instance.PointText.Replace('{', '<').Replace('}', '>').Replace(playername, name), MessageColor, null, null, EChatMode.LOCAL, iconURL, true);

                }
            }

            if (gesture == UnturnedPlayerEvents.PlayerGesture.Salute)
            {
                if (Configuration.Instance.SaluteBool)
                {

                    var playername = "!playerName!";
                    var name = player.DisplayName;
                    var iconURL = MQSPlugin.Instance.Configuration.Instance.SaluteIcon;
                    ChatManager.serverSendMessage(MQSPlugin.Instance.Configuration.Instance.SaluteText.Replace('{', '<').Replace('}', '>').Replace(playername, name), MessageColor, null, null, EChatMode.LOCAL, iconURL, true);

                }
            }

            if (gesture == UnturnedPlayerEvents.PlayerGesture.Wave)
            {
                if (Configuration.Instance.WaveBool)
                {

                    var playername = "!playerName!";
                    var name = player.DisplayName;
                    var iconURL = MQSPlugin.Instance.Configuration.Instance.WaveIcon;
                    ChatManager.serverSendMessage(MQSPlugin.Instance.Configuration.Instance.WaveText.Replace('{', '<').Replace('}', '>').Replace(playername, name), MessageColor, null, null, EChatMode.LOCAL, iconURL, true);
                
                }
            }

            if (gesture == UnturnedPlayerEvents.PlayerGesture.SurrenderStart)
            {
                if (Configuration.Instance.SurrenderStartBool)
                {
                    var playername = "!playerName!";
                    var name = player.DisplayName;
                    var iconURL = MQSPlugin.Instance.Configuration.Instance.SurrenderStartIcon;
                    ChatManager.serverSendMessage(MQSPlugin.Instance.Configuration.Instance.SurrenderStartText.Replace('{', '<').Replace('}', '>').Replace(playername, name), MessageColor, null, null, EChatMode.LOCAL, iconURL, true);
                
                }

            }

            if (gesture == UnturnedPlayerEvents.PlayerGesture.SurrenderStop)
            {
                if (Configuration.Instance.SurrenderStopBool)
                {

                    var playername = "!playerName!";
                    var name = player.DisplayName;
                    var iconURL = MQSPlugin.Instance.Configuration.Instance.SurrenderStopIcon;
                    ChatManager.serverSendMessage(MQSPlugin.Instance.Configuration.Instance.SurrenderStopText.Replace('{', '<').Replace('}', '>').Replace(playername, name), MessageColor, null, null, EChatMode.LOCAL, iconURL, true);
                }

            }

            if (gesture == UnturnedPlayerEvents.PlayerGesture.Facepalm)
            {
                if (Configuration.Instance.FacePalmBool)
                {

                    var playername = "!playerName!";
                    var name = player.DisplayName;
                    var iconURL = MQSPlugin.Instance.Configuration.Instance.FacePalmIcon;
                    ChatManager.serverSendMessage(MQSPlugin.Instance.Configuration.Instance.FacePalmText.Replace('{', '<').Replace('}', '>').Replace(playername, name), MessageColor, null, null, EChatMode.LOCAL, iconURL, true);
                }
            }

            if (gesture == UnturnedPlayerEvents.PlayerGesture.Rest_Start)
            {
                if (Configuration.Instance.RestStartBool)
                {
                    var playername = "!playerName!";
                    var name = player.DisplayName;
                    var iconURL = MQSPlugin.Instance.Configuration.Instance.RestStartIcon;
                    ChatManager.serverSendMessage(MQSPlugin.Instance.Configuration.Instance.RestStartText.Replace('{', '<').Replace('}', '>').Replace(playername, name), MessageColor, null, null, EChatMode.LOCAL, iconURL, true);
                }

            }

            if (gesture == UnturnedPlayerEvents.PlayerGesture.Rest_Stop)
            {
                if (Configuration.Instance.RestStopBool)
                {
                    var playername = "!playerName!";
                    var name = player.DisplayName;
                    var iconURL = MQSPlugin.Instance.Configuration.Instance.RestStopIcon;
                    ChatManager.serverSendMessage(MQSPlugin.Instance.Configuration.Instance.RestStopText.Replace('{', '<').Replace('}', '>').Replace(playername, name), MessageColor, null, null, EChatMode.LOCAL, iconURL, true);

                }


            }



        }

        protected override void Unload()
        {
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            Logger.LogWarning($"[{Name}] has been unloaded! ");
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            Rocket.Unturned.Events.UnturnedPlayerEvents.OnPlayerUpdateGesture -= GestureChange;


        }


    }

}
