using Characters;
using Data;
using Entity;
using System;
using UnityEngine;

namespace Player
{
    public class PlayerEntity
    {
        public string ID { get; private set; }

        public PlayerData Data
        {
            get
            {
                return GameData.Instance.PlayerData;
            }
            private set { }
        }

        public string PlayerName
        {
            get
            {
                return Data.PlayerName;
            }
            set
            {
                var updateData = Data;
                updateData.PlayerName = value;
                GameData.Instance.PlayerData = Data;

            }
        }
        public GameObject gameObject
        {
            get;
            private set;
        }

        public Vector3 Position
        {
            get { return Data.Position; }
            set
            {
                var updateData = Data;
                updateData.Position = value;
                GameData.Instance.PlayerData = Data;
            }
        }
        public Quaternion Rotation
        {
            get { return Data.Rotation; }
            set
            {
                var updateData = Data;
                updateData.Rotation = value;
                GameData.Instance.PlayerData = Data;
            }
        }
        public int Money
        {
            get { return Data.Money; }
            set
            {
                var updateData = Data;
                updateData.Money = value;
                GameData.Instance.PlayerData = Data;
            }
        }
        public CharacterEntity Character
        {
            get { return new CharacterEntity(Data.CharacterEntityId); }
            set
            {
                var updateData = Data;
                updateData.CharacterEntityId = value.Id;
                GameData.Instance.PlayerData = Data;
            }
        }
        public Character CharacterData
        {
            get { return Data.Character; }
            set
            {
                var updateData = Data;
                updateData.Character = value;
                GameData.Instance.PlayerData = Data;
            }
        }

        public PlayerEntity()
        {
            if (GameData.Instance.PlayerData.Equals(default(PlayerData)))
            {
                ID = Guid.NewGuid().ToString();
                PlayerData playerData = new PlayerData();
                playerData.Id = ID;
                GameData.Instance.PlayerData = playerData;
                return;
            }

            Data = GameData.Instance.PlayerData;


        }

    }
}
