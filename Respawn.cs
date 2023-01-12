using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject[] ObjToRespawn;
    public GameObject[] PointForRespawn;
    //The RespawnObject function is for respawning only one desired object
    public void RespawnObject(int i)
    {
        if (ObjToRespawn[i]!=null&&PointForRespawn[i]!=null)
        {
            ObjToRespawn[i].transform.position = PointForRespawn[i].transform.position;
            ObjToRespawn[i].transform.localRotation = Quaternion.EulerAngles(PointForRespawn[i].transform.localRotation.x, PointForRespawn[i].transform.localRotation.y, PointForRespawn[i].transform.localRotation.z);
        }
    }
}
