using Rocket.API;


namespace ChatGestures
{

    public class Config : IRocketPluginConfiguration

    {
        public string MessageColor { get; set; }
        public bool PointBool;
        public string PointIcon;
        public string PointText;
        public bool SaluteBool;
        public string SaluteIcon;
        public string SaluteText;
        public bool WaveBool;
        public string WaveIcon;
        public string WaveText;
        public bool SurrenderStartBool;
        public string SurrenderStartIcon;
        public string SurrenderStartText;
        public bool SurrenderStopBool;  
        public string SurrenderStopIcon;
        public string SurrenderStopText;
        public bool FacePalmBool;
        public string FacePalmIcon;
        public string FacePalmText;
        public bool RestStartBool;
        public string RestStartIcon;
        public string RestStartText;
        public bool RestStopBool;
        public string RestStopIcon;
        public string RestStopText;


        public void LoadDefaults()
        {
            MessageColor = "white";
            PointBool = true;
            PointIcon = "URL";
            PointText = "* !playerName! Points *";
            SaluteBool = true;
            SaluteIcon = "URL";
            SaluteText = "* !playerName! Salutes *";
            WaveBool = true;
            WaveIcon = "URL";
            WaveText = "* !playerName! Waves *";
            SurrenderStartBool = true;
            SurrenderStartIcon = "URL";
            SurrenderStartText = "* !playerName! Surrender *";
            SurrenderStopBool = true;
            SurrenderStopIcon = "URL";
            SurrenderStopText = "* !playerName! Stops Surrendering *";
            FacePalmBool = true;
            FacePalmIcon = "URL";
            FacePalmText = "* !playerName! makes a FacePalm*";
            RestStartBool = true;
            RestStartIcon = "URL";
            RestStartText = "* !playerName! is now resting.";
            RestStopBool = true;
            RestStopIcon = "URL";
            RestStopText = "* !playerName! is no longer resting. *";



        }
    }
}


