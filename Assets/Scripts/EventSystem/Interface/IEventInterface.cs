using UnityEngine;

namespace EventMissionInterface
{
    public interface IEventInterface
    {
        public GameObject interfaceGameObject { get; }
        public GameObject interfaceText { get; }
        public Edge edge { get; }
        public ScreenSide side { get; }
        public EventInterfaceGameObjectScreenSize eventInterfaceGameObjectScreenSize { get; }
        public string EventTextInformation { get; }
        public void InvokeEventInterface(GameObject InterfaceGameObject);
        public void CancelInvokeEventInterface(GameObject InterfaceGameObject);

    }

}