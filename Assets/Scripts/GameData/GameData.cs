using Characters;
using System.Collections.Generic;

namespace Data
{
    public class GameData : MonoBehaviourSingleton<GameData>
    {
        public List<MissionData> MissionsData;
        public List<CharacterData> CharacterDatas;
        public PlayerData PlayerData;


        public override void Awake()
        {
            base.Awake();
            MissionsData = new List<MissionData>();
            CharacterDatas = new List<CharacterData>();
        }
    }

}