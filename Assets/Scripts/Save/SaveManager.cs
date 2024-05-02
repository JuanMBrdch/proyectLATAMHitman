using System;
using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviourSingleton<SaveManager>
{

 

    public void Save<T>(T Save,string folderName ,string fileName)
    {
        string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Hitman", folderName);
        string filePath = Path.Combine(folderPath, fileName);

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Create new directory");
        }

        string json = JsonUtility.ToJson(Save);

        File.WriteAllText(filePath, json);

    }


    public T Load<T>(T Save, string folderName, string fileName)
    {
        string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Hitman", folderName);
        string filePath = Path.Combine(folderPath, fileName);

        if (!Directory.Exists(folderPath))
        {
            Debug.Log("File not found: " + filePath);
            return default(T);
        }

        string json = File.ReadAllText(filePath);

        T obj = JsonUtility.FromJson<T>(json);

        return obj;

    }
    //public T Load<T>(string path) 
    //{
    //    var asd = ;
    //    return ;
    //}
}
