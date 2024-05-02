using Mission;
using System.Collections.Generic;

namespace Data
{
    public class GameData : MonoBehaviourSingleton<GameData>
    {
        public List<MissionData> MissionsData;
        public PlayerData PlayerData;


        public override void Awake()
        {
            base.Awake();
            MissionsData = new List<MissionData>();
        }
    }

}