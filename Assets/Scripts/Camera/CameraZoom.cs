using UnityEngine;
using Cinemachine;

public class CameraZoom : MonoBehaviour
{
    public CinemachineFreeLook freeLookCamera; // Referência para a Cinemachine FreeLook Camera
    public ChangeScene changeScene;
    public float zoomSpeed = 200f; // Velocidade do zoom
    public float minZoom = 2f; // Valor mínimo de zoom (mais próximo)
    public float maxZoom = 10f; // Valor máximo de zoom (mais distante)

    private bool nucleos;
    private bool dna;


    void Start()
    {
        if (freeLookCamera == null)
        {
            freeLookCamera = GetComponent<CinemachineFreeLook>();
        }
        changeScene = GetComponent<ChangeScene>();

        nucleos = true;
        dna = false;
    }

    void Update()
    {
        ZoomCamera();
    }

    void ZoomCamera()
    {
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        float newZoom = freeLookCamera.m_Lens.FieldOfView - scrollInput * zoomSpeed * Time.deltaTime;

        if (newZoom < minZoom && !dna)
        {
            Control.instance.ChangeToDNA();
            dna = true;
            nucleos = false;
        }
        else if (newZoom > maxZoom && !nucleos)
        {
            Control.instance.ChangeToNucleous();
            dna = false;
            nucleos = true;
        }

        newZoom = Mathf.Clamp(newZoom, minZoom, maxZoom);

        freeLookCamera.m_Lens.FieldOfView = newZoom;
    }

}
