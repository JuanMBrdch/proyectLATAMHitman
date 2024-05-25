using Characters;
using Data;
using System;
using System.Linq;
using UnityEngine;

namespace Entity
{
    public class CharacterEntity
    {
        public string Id { get; set; }

        private CharacterData CharacterData
        {
            get { return GameData.Instance.CharacterDatas.FirstOrDefault(X => X.ID == Id); }
            set { }
        }
        public string Name
        {
            get
            {
                return CharacterData.Name;
            }
            set 
            {
                int index = -1;

                for (int i = 0; i < GameData.Instance.CharacterDatas.Count; i++)
                {
                    if (GameData.Instance.CharacterDatas[i].ID == Id)
                    {
                        index = i; break;
                    }
                }

                if (index != -1)
                {
                    var updateData = CharacterData;
                    updateData.Name = value;
                    GameData.Instance.CharacterDatas[index] = updateData;
                }
            }
        }

        public Vector3 Position 
        {
            get { return CharacterData.Position; }
            set
            {
                int index = -1;

                for (int i = 0; i < GameData.Instance.CharacterDatas.Count; i++)
                {
                    if (GameData.Instance.CharacterDatas[i].ID == Id)
                    {
                        index = i; break;
                    }
                }

                if (index != -1)
                {
                    var updateData = CharacterData;
                    updateData.Position = value;
                    GameData.Instance.CharacterDatas[index] = updateData;
                }
            }
        }

        public GameObject gameObject
        {
            get { return CharacterData.gameObject; }
            set
            {
                int index = -1;

                for (int i = 0; i < GameData.Instance.CharacterDatas.Count; i++)
                {
                    if (GameData.Instance.CharacterDatas[i].ID == Id)
                    {
                        index = i; break;
                    }
                }

                if (index != -1)
                {
                    var updateData = CharacterData;
                    updateData.gameObject = value;
                    GameData.Instance.CharacterDatas[index] = updateData;
                }
            }
        }
        public Character CharacterInfo
        {
            get
            {
                //var data = Character.GetCharacter(CharacterData.CharacterDataID);
                return Character.GetRandom();
            }
            set
            {
                int index = -1;

                for (int i = 0; i < GameData.Instance.CharacterDatas.Count; i++)
                {
                    if (GameData.Instance.CharacterDatas[i].ID == Id)
                    {
                        index = i; break;
                    }
                }

                if (index != -1)
                {
                    var updateData = CharacterData;
                    updateData.CharacterDataID = value.ID;
                    GameData.Instance.CharacterDatas[index] = updateData;
                }
            }
        }
        public CharacterEntity()
        {
            Id = Guid.NewGuid().ToString();
            CharacterData = new CharacterData()
            {
                ID = Id,
            };
            GameData.Instance.CharacterDatas.Add(CharacterData);
        }

        public CharacterEntity(string id)
        {
            CharacterData = GameData.Instance.CharacterDatas.FirstOrDefault(X => X.ID == Id);
        }
    }

}