using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;

    // Update is called once per frame
    void Update () {
        transform.LookAt(player.transform.position);
        Vector3 localOffset = player.transform.up*3f - player.transform.forward * 7f;
        transform.position = player.transform.position + localOffset;
        transform.rotation = player.transform.rotation;
    }
}