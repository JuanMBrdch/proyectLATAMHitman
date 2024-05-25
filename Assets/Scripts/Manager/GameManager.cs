using Data;
using Entity;
using Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    public GameObject PlayerPrefab;

    public ReadOnlyCollection<MissionEntity> MissionsActivated
    {
        get
        {
            List<MissionEntity> missionEntities = new List<MissionEntity>();

            foreach (var item in GameData.Instance.PlayerMissionRelationShip.ToList())
            {
                missionEntities.Add(new MissionEntity(item.MissionID));
            }

            return new ReadOnlyCollection<MissionEntity>(missionEntities);
        }
    }

    public ReadOnlyCollection<CharacterEntity> Characters
    {
        get
        {
            List<CharacterEntity> charactersEntity = new List<CharacterEntity>();

            foreach (var item in GameData.Instance.CharacterDatas)
            {
                charactersEntity.Add(new CharacterEntity(item.ID));
            }

            return new ReadOnlyCollection<CharacterEntity>(charactersEntity);
        }
    }


    public override void Awake()
    {
        base.Awake();

    }

    private void Start()
    {
        InicializePlayer();
    }

    private void InicializePlayer()
    {
        GameObject player = Instantiate(PlayerPrefab);
        PlayerModel playerModel = PlayerModel.LocalPlayerModel;

        if (playerModel.Entity == null)
        {
            playerModel.Entity.Character = CharacterFactory.Instance.CreateCustomCharacter(playerModel.Entity.CharacterData, new Vector3(0, 0, 0));
        }
        CharacterFactory.Instance.InstanceCharacterGameObject(playerModel.Entity.Character);
    }
}
