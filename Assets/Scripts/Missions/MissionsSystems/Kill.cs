using UnityEngine;
[CreateAssetMenu(fileName = "KillMission", menuName = "Missions/KillMission")]
public class Kill : MissionSystem
{
    public TargetCharacter character;

    public Vector3 TargetPosition;
    public override void OnStart()
    {
        base.OnStart();
    }

    public override void OnGameTick()
    {
        base.OnGameTick();
    }

    public override void OnReward()
    {
        base.OnReward();
    }

    public override void OnEnd()
    {
        base.OnEnd();
    }


}
