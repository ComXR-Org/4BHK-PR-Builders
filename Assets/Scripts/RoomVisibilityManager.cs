using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RoomType
{
    LivingRoom,
    Bedroom_1,
    Bedroom_2,
    Bedroom_3,
    Bedroom_4,    
    Maidroom,
    Kitchen    
}
public class RoomVisibilityManager : MonoBehaviour
{
    public static RoomVisibilityManager instace;

    void Awake()
    {
        if (instace == null) instace = this;
    }
    public Camera mainCamera;
    public List<GameObject> LivingRoom = new List<GameObject>();
    public List<GameObject> Bedroom_1 = new List<GameObject>();
    public List<GameObject> Bedroom_2 = new List<GameObject>();
    public List<GameObject> Bedroom_3 = new List<GameObject>();
    public List<GameObject> Bedroom_4 = new List<GameObject>();
    public List<GameObject> Maidroom = new List<GameObject>();
    public List<GameObject> Kitchen = new List<GameObject>();

    private void Update()
    {
        CheckAndToggleListVisibility(LivingRoom);
        CheckAndToggleListVisibility(Bedroom_1);
        CheckAndToggleListVisibility(Bedroom_2);
        CheckAndToggleListVisibility(Bedroom_3);
        CheckAndToggleListVisibility(Bedroom_4);
        CheckAndToggleListVisibility(Maidroom);
        CheckAndToggleListVisibility(Kitchen);
    }

    private void CheckAndToggleListVisibility(List<GameObject> roomList)
    {
        if (roomList.Count == 0) return;

        bool isAnyObjectVisible = false;
        Plane[] frustumPlanes = GeometryUtility.CalculateFrustumPlanes(mainCamera);

        foreach (GameObject obj in roomList)
        {
            if (obj == null) continue;

            Collider objCollider = obj.GetComponent<Collider>();
            if (objCollider != null && GeometryUtility.TestPlanesAABB(frustumPlanes, objCollider.bounds))
            {
                isAnyObjectVisible = true;
                break;
            }
        }

        // Enable or disable all objects in the list based on visibility
        foreach (GameObject obj in roomList)
        {
            if (obj != null)
            {
                obj.SetActive(isAnyObjectVisible);
            }
        }
    }

}
