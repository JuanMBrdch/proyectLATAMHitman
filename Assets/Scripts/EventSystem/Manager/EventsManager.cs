using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EventMissionInterface
{

    public enum Edge { High, Medium, Low }
    public enum ScreenSide { Right, Down, Up, Left }
    public enum EventInterfaceGameObjectScreenSize { Big, Medium, Small }

    public class EventsManager : MonoBehaviour
    {
        public List<IEventInterface> Events = new List<IEventInterface>();

        private Camera mainCamera;

        void Start()
        {
            mainCamera = Camera.main;
        }


        public void CreateEventInterface(IEventInterface eventInterface)
        {
            if (eventInterface == null) return;


            Events.Add(eventInterface);

            GameObject interfaceGameObject = Instantiate(eventInterface.interfaceGameObject);
            GameObject interfaceText = Instantiate(eventInterface.interfaceText);

            SetEventInterfaceScreenPosition(eventInterface.edge, eventInterface.side, interfaceGameObject);

            ModifiedTextInterface(eventInterface.EventTextInformation, interfaceText);
        }
        private void SetEventInterfaceScreenPosition(Edge edge, ScreenSide side, GameObject gameObject)
        {
            if (gameObject == null) return;

            Vector3 screenBottomLeft = mainCamera.ScreenToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane));
            Vector3 screenTopRight = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.nearClipPlane));

            float screenWidth = screenTopRight.x - screenBottomLeft.x;
            float screenHeight = screenTopRight.y - screenBottomLeft.y;

            float horizontalSegmentWidth = screenWidth / 3;
            float verticalSegmentHeight = screenHeight / 3;

            float xPos = 0;
            float yPos = 0;

            switch (side)
            {
                case ScreenSide.Right:
                    xPos = screenTopRight.x;
                    break;
                case ScreenSide.Left:
                    xPos = screenBottomLeft.x;
                    break;
                case ScreenSide.Up:
                    yPos = screenTopRight.y;
                    break;
                case ScreenSide.Down:
                    yPos = screenBottomLeft.y;
                    break;
            }

            switch (edge)
            {
                case Edge.High:
                    if (side == ScreenSide.Right || side == ScreenSide.Left)
                        yPos = screenTopRight.y;
                    else
                        xPos = screenTopRight.x;
                    break;
                case Edge.Medium:
                    if (side == ScreenSide.Right || side == ScreenSide.Left)
                        yPos = screenBottomLeft.y + screenHeight / 2;
                    else
                        xPos = screenBottomLeft.x + screenWidth / 2;
                    break;
                case Edge.Low:
                    if (side == ScreenSide.Right || side == ScreenSide.Left)
                        yPos = screenBottomLeft.y;
                    else
                        xPos = screenBottomLeft.x;
                    break;
            }

            gameObject.transform.position = new Vector3(xPos, yPos, 0);
        }

        private void ModifiedTextInterface(string Text, GameObject gameObject)
        {
            if (Text == string.Empty) return;

            gameObject.GetComponent<Text>().text = Text;

        }
    }

}