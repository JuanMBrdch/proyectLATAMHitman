using Characters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGameContent : MonoBehaviour
{
    private void Awake()
    {
        Character.Load(LoadContent<Character>("CharactersTypes"));

        MissionSystem.Load(LoadContent<MissionSystem>("MissionsTypes"));

    }


    public List<T> LoadContent<T>(string path) where T : ScriptableObject
    {
        List<T> loadedContent = new List<T>();

        // Cargar todos los objetos del tipo T en el path especificado
        T[] assets = Resources.LoadAll<T>(path);

        // Verificar si se han encontrado objetos
        if (assets != null && assets.Length > 0)
        {
            loadedContent.AddRange(assets);
        }
        else
        {
            Debug.LogWarning($"No se encontraron objetos del tipo {typeof(T).Name} en la ruta: {path}");
        }

        return loadedContent;
    }
}
