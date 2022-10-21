
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public GameObject Player;
    void LateUpdate()
    {
        cameraMovement();
    }
    private void cameraMovement()
    {
        Vector3 p = Player.transform.position;
        p.y = transform.position.y;
        p.z = transform.position.z;
        transform.position = p;
    }


}
