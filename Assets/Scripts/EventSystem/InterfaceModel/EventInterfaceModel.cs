using EventMissionInterface;
using UnityEngine;
namespace EventMissionInterface 
{
public class EventInterfaceModel : MonoBehaviour, IEventInterface
{
    public GameObject InterfaceGameObject;
    public GameObject interfaceGameObject => InterfaceGameObject;

    public GameObject InterfaceText;
    public GameObject interfaceText => InterfaceText;

    public Edge Edge;
    public Edge edge => Edge;

    public ScreenSide Side;
    public ScreenSide side => Side;

    public EventInterfaceGameObjectScreenSize EventInterfaceGameObjectScreenSize;
    public EventInterfaceGameObjectScreenSize eventInterfaceGameObjectScreenSize => EventInterfaceGameObjectScreenSize;

    public string eventTextInformation;
    public string EventTextInformation => eventTextInformation;

    public void CancelInvokeEventInterface(GameObject InterfaceGameObject)
    {
        throw new System.NotImplementedException();
    }

    public void InvokeEventInterface(GameObject InterfaceGameObject)
    {
        throw new System.NotImplementedException();
    }
}
  

}