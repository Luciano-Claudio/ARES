using UnityEngine;
using Cinemachine;

public class CameraZoom : MonoBehaviour
{
    float newZoom;
    void Start()
    {
        newZoom = 41f;
    }

    void Update()
    {
        ZoomCamera();
    }

    void ZoomCamera()
    {

        newZoom = Control.instance.zoom;
        Vector3 currentPosition = transform.rotation.eulerAngles;
        currentPosition.z = newZoom;

        transform.position = currentPosition;
    }

}
