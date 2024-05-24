using Characters;
using Model;
using Player;
using System;
using System.Collections.Generic;

namespace Data
{
    #region Relationship

    public struct PlayerMissionRelationShip
    {
        public string PlayerID;
        public string MissionID;
    }

    #endregion


    public class GameData : MonoBehaviourSingleton<GameData>
    {
 

        public List<MissionData> MissionsData;
        public List<CharacterData> CharacterDatas;
        public ListExtension<PlayerMissionRelationShip> PlayerMissionRelationShip;
        public PlayerData PlayerData;


        public override void Awake()
        {
            base.Awake();
            MissionsData = new List<MissionData>();
            CharacterDatas = new List<CharacterData>();
            PlayerMissionRelationShip = new ListExtension<PlayerMissionRelationShip>();
        }

        private void Start()
        {
            PlayerMissionRelationShip.OnAddEvent += OnPlayerAddMission;
            PlayerMissionRelationShip.OnRemoveEvent += OnPlayerRemoveMission;
            PlayerMissionRelationShip.OnValueChangeEvent += OnPlayerChangeMission;
        }


        #region Event

        private void OnPlayerRemoveMission(PlayerMissionRelationShip ship)
        {
            var player = PlayerModel.LocalPlayerModel;

        }

        private void OnPlayerAddMission(PlayerMissionRelationShip ship)
        {
            throw new NotImplementedException();
        }

        private void OnPlayerChangeMission(PlayerMissionRelationShip oldMission, PlayerMissionRelationShip newMission)
        {
            throw new NotImplementedException();
        }


        #endregion
    }

}