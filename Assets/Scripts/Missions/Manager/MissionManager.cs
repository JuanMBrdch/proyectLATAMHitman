using Entity;

namespace Mission
{
    public class MissionManager : MonoBehaviourSingleton<MissionManager>
    {
        public MissionSystem[] missionSystems;

        public override void Awake()
        {
            base.Awake();

            foreach (var item in missionSystems)
            {
                MissionSystem.Add(item);
            }
        }

        public void StartMission(MissionEntity missionEntity) 
        {
            missionEntity.MissionSystem.OnStart();
        }
    }
}
