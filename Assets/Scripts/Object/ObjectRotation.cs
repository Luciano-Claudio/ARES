using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    public float velocidadeRotacao = 100f; // Velocidade de rotação do objeto
    public GameObject objectToRotate;

    private void Start()
    {
        objectToRotate = gameObject;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float movimentoMouseX = Input.GetAxis("Mouse X");

            float rotacaoY = movimentoMouseX * velocidadeRotacao * Time.deltaTime;

            objectToRotate.transform.Rotate(Vector3.up, rotacaoY, Space.World);
        }
    }
}
