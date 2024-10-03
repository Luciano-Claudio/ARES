using UnityEngine;
using Cinemachine;

public class Control : MonoBehaviour
{
    [Header("DNA")]
    public GameObject DNA_Area;
    public GameObject DNA_Background;
    public GameObject DNA_Button;


    [Header("Nucleous")]
    public GameObject Nucleous_Area;
    public GameObject Nucleous_Background;


    [Header("Camera")]
    public CinemachineFreeLook freeLookCamera; // Referência para a Cinemachine FreeLook Camera



    public static Control instance;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void ChangeToDNA()
    {
        DNA_Area.SetActive(true);
        //DNA_Background.SetActive(true);
        DNA_Button.SetActive(true);


        Nucleous_Area.SetActive(false);
        //Nucleous_Background.SetActive(false);
    }


    public void ChangeToNucleous()
    {
        Nucleous_Area.SetActive(true);
        Nucleous_Background.SetActive(true);


        DNA_Area.SetActive(false);
        //DNA_Background.SetActive(false);
        DNA_Button.SetActive(false);
    }
}
