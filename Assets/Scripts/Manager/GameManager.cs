using Data;
using Entity;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    public List<MissionEntity> MissionsActivated 
    {
        get
        {
            List< MissionEntity > missionEntities = new List< MissionEntity >();

            foreach (var item in GameData.Instance.PlayerMissionRelationShip.ToList())
            {
                missionEntities.Add(new MissionEntity(item.MissionID));
            }

            return missionEntities;
        }
    }

}
