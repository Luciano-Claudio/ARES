using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNAChange : MonoBehaviour
{
    public GameObject DNA;
    public GameObject DNAComplete;


    public void OnActive()
    {
        if (DNA.activeInHierarchy)
        {
            DNA.SetActive(false);
            DNAComplete.SetActive(true);
        }else if (DNAComplete.activeInHierarchy)
        {
            DNAComplete.SetActive(false);
            DNA.SetActive(true);
        }
    }
}
