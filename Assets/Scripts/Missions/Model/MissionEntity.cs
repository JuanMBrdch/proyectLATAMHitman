using Data;
using System;
using System.Linq;

namespace Entity
{
    public class MissionEntity
    {
        public string ID { get; private set; }

        private MissionData MissionData
        {
            get
            {
                return GameData.Instance.MissionsData.FirstOrDefault(x => x.MissionID == ID);
            }
            set
            {
            }
        }

        public string Information
        {
            get
            {
                return MissionData.Information;
            }
            set
            {
                int index = -1;
                for (int i = 0; i < GameData.Instance.MissionsData.Count; i++)
                {
                    if (GameData.Instance.MissionsData[i].MissionID == ID)
                    {
                        index = i;
                        break;
                    }
                }

                if (index == -1) return;

                var updateDasta = MissionData;
                updateDasta.Information = value;
                GameData.Instance.MissionsData[index] = updateDasta;
            }
        }


        public MissionSystem MissionSystem
        {
            get
            {
                return MissionSystem.Get(MissionData.SystemID);
            }
            set
            {
                int index = -1;
                for (int i = 0; i < GameData.Instance.MissionsData.Count; i++)
                {
                    if (GameData.Instance.MissionsData[i].MissionID == ID)
                    {
                        index = i;
                        break;
                    }
                }

                if (index == -1) return;

                var updateDasta = MissionData;
                updateDasta.SystemID = value.MissionID;
                GameData.Instance.MissionsData[index] = updateDasta;
            }
        }

        public MissionEntity()
        {
            ID = Guid.NewGuid().ToString();
            MissionData = new MissionData
            {
                MissionID = ID
            };
            GameData.Instance.MissionsData.Add(MissionData);
        }

        public MissionEntity(string ID)
        {
            MissionData = GameData.Instance.MissionsData.FirstOrDefault(x => x.MissionID == ID);
        }
    }

}