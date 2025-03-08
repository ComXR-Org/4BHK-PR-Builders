using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectList : MonoBehaviour
{
    public RoomType listType;
    public List<GameObject> objectList = new List<GameObject>();

    private void Start()
    {
        switch (listType)
        {
            case RoomType.LivingRoom:
                RoomVisibilityManager .instace.LivingRoom = objectList;
                break;
            case RoomType.Bedroom_1:
                RoomVisibilityManager .instace.Bedroom_1 = objectList;
                break;
            case RoomType.Bedroom_2:
                RoomVisibilityManager .instace.Bedroom_2 = objectList;
                break;
            case RoomType.Bedroom_3:
                RoomVisibilityManager .instace.Bedroom_3 = objectList;
                break;
            case RoomType.Bedroom_4:
                RoomVisibilityManager .instace.Bedroom_4 = objectList;
                break;
            case RoomType.Maidroom:
                RoomVisibilityManager .instace.Maidroom = objectList;
                break;
            case RoomType.Kitchen:
                RoomVisibilityManager .instace.Kitchen = objectList;
                break;
        }
    }
}
