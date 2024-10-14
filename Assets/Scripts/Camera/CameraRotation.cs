using UnityEngine;
using Cinemachine;

public class CameraRotation : MonoBehaviour
{
    public CinemachineFreeLook freeLookCamera;

    void Start()
    {
        if (freeLookCamera == null)
        {
            freeLookCamera = GetComponent<CinemachineFreeLook>();
        }
    }

    void Update()
    {
        // Detecta quando o botão esquerdo do mouse é pressionado
        if (Input.GetMouseButtonDown(0))
        {
            RotateCamera();
        }

        // Detecta quando o botão esquerdo do mouse é solto
        if (Input.GetMouseButtonUp(0))
        {
            StopRotateCamera();
        }
    }

    void RotateCamera()
    {
        freeLookCamera.m_YAxis.m_InputAxisName = "Mouse Y";
        //freeLookCamera.m_XAxis.m_InputAxisName = "Mouse X";
    }
    void StopRotateCamera()
    {
        freeLookCamera.m_YAxis.m_InputAxisName = "";
        //freeLookCamera.m_XAxis.m_InputAxisName = "";
        freeLookCamera.m_YAxis.m_InputAxisValue = 0;
        //freeLookCamera.m_XAxis.m_InputAxisValue = 0;
    }
}