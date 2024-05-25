using Characters;
using Entity;
using UnityEngine;

public class CharacterFactory : MonoBehaviourSingleton<CharacterFactory>
{
    public GameObject BaseCharacterPrefab;


    public CharacterEntity Create() 
    {
        return new CharacterEntity();
    }

    public CharacterEntity CreateCustomCharacter(Character characterData, Vector3 Position) 
    {
        var entity = Create();
        entity.CharacterInfo = characterData;
        entity.Position = Position;
        return entity;
    }

    public CharacterEntity CreateRandomCharacter(Vector3 Position)
    {
        var entity = Create();
        entity.CharacterInfo = Character.GetRandom();
        entity.Position = Position;
        return entity;
    }

    public GameObject InstanceCharacterGameObject(CharacterEntity characterEntity) 
    {
        GameObject gameObject = Instantiate(characterEntity.CharacterInfo.Model, characterEntity.Position, Quaternion.identity);
        characterEntity.gameObject = gameObject;
        return gameObject;
    }
}
