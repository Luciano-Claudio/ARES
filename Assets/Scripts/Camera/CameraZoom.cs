using UnityEngine;
using Cinemachine;

public class CameraZoom : MonoBehaviour
{
    public CinemachineFreeLook freeLookCamera; // Refer�ncia para a Cinemachine FreeLook Camera
    public ChangeScene changeScene;
    public float zoomSpeed = 200f; // Velocidade do zoom
    public float minZoom = 2f; // Valor m�nimo de zoom (mais pr�ximo)
    public float maxZoom = 10f; // Valor m�ximo de zoom (mais distante)

    public string minScene;
    public string maxScene;

    void Start()
    {
        if (freeLookCamera == null)
        {
            freeLookCamera = GetComponent<CinemachineFreeLook>();
        }
        changeScene = GetComponent<ChangeScene>();
    }

    void Update()
    {
        ZoomCamera();
    }

    void ZoomCamera()
    {
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        float newZoom = freeLookCamera.m_Lens.FieldOfView - scrollInput * zoomSpeed * Time.deltaTime;

        if (newZoom < minZoom && minScene != null)
        {/*
            Control.instance.maxView = true;
            Control.instance.minView = false;
            Control.instance.xMaxCoordinate = freeLookCamera.m_XAxis.Value;
            Control.instance.yMaxCoordinate = freeLookCamera.m_YAxis.Value;
            */
            //changeScene.OnChange(minScene);
        }
        else if (newZoom > maxZoom && maxScene != null)
        {
            //changeScene.OnChange(maxScene);
        }

        newZoom = Mathf.Clamp(newZoom, minZoom, maxZoom);

        freeLookCamera.m_Lens.FieldOfView = newZoom;
    }

}
