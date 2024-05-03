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

        public CharacterData CharacterData
        {
            get { return GameData.Instance.CharacterDatas.FirstOrDefault(X => X.ID == Id); }
            private set { }
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