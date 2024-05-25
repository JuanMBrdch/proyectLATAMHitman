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
        GameObject gameObject = Instantiate(BaseCharacterPrefab, Position, Quaternion.identity);
        entity.CharacterInfo = characterData;
        entity.Position = Position;
        entity.gameObject = gameObject;
        return entity;
    }

    public CharacterEntity CreateRandomCharacter(Vector3 Position)
    {
        var entity = Create();
        GameObject gameObject = Instantiate(BaseCharacterPrefab, Position, Quaternion.identity);
        entity.CharacterInfo = Character.GetRandom();
        entity.Position = Position;
        entity.gameObject = gameObject;
        return entity;
    }

    public GameObject InstanceCharacterGameObject(CharacterEntity characterEntity) 
    {
        GameObject gameObject = Instantiate(characterEntity.CharacterInfo.Model, characterEntity.Position, Quaternion.identity);
        var parent = characterEntity.gameObject.transform;
        gameObject.transform.SetParent(parent);
        gameObject.name = "Renderer";
        return gameObject;
    }
}
