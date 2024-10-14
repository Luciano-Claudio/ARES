using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    public float rotacaoY;

    private void Start()
    {
    }

    void Update()
    {
        float rotacaoY = Control.instance.rotacao;
        Vector3 currentRotation = transform.rotation.eulerAngles;
        currentRotation.y = rotacaoY;

        transform.rotation = Quaternion.Euler(currentRotation);
    }
}
