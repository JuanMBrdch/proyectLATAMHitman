using Entity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    public List<MissionEntity> MissionsActivated = new List<MissionEntity>();



    private void Awake()
    {
        
    }
}
