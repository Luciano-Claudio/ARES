using UnityEngine;
using UnityEngine.XR.Management;

public class Control : MonoBehaviour
{
    [Header("Control")]
    public bool DNA_Change = false;
    public bool Nucleo_Change = true;
    public bool Swap_DNA = false;
    [Range(-70, -40)]
    public float zoom = 70;
    [Range(-180, 180)]
    public float rotacao;


    [Header("DNA")]
    public GameObject DNA_Area;
    public GameObject DNA_Background;

    public GameObject DNA;
    public GameObject DNAComplete;


    [Header("Nucleous")]
    public GameObject Nucleous_Area;
    public GameObject Nucleous_Background;





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
    void Start()
    {
        // Verifica se o XR está habilitado e inicializa se não estiver
        if (!XRGeneralSettings.Instance.Manager.isInitializationComplete)
        {
            XRGeneralSettings.Instance.Manager.InitializeLoaderSync();
            XRGeneralSettings.Instance.Manager.StartSubsystems();
        }
    }

    private void Update()
    {
        if (DNA_Change) ChangeToDNA();
        if (Nucleo_Change) ChangeToNucleous();
        SwapDNA(Swap_DNA);


    }


    public void ChangeToDNA()
    {
        DNA_Area.SetActive(true);
        DNA_Background.SetActive(true);


        Nucleous_Area.SetActive(false);
        Nucleous_Background.SetActive(false);
    }


    public void ChangeToNucleous()
    {
        Nucleous_Area.SetActive(true);
        Nucleous_Background.SetActive(true);


        DNA_Area.SetActive(false);
        DNA_Background.SetActive(false);
    }
    public void SwapDNA(bool Swap)
    {
        if (!Swap)
        {
            DNA.SetActive(false);
            DNAComplete.SetActive(true);
        }
        else
        {
            DNAComplete.SetActive(false);
            DNA.SetActive(true);
        }
    }
}
