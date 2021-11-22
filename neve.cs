using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neve : MonoBehaviour
{
    [Range(0.01f, 0.1f)]
    public float velocidadeNeve;

    private float valor = 0;

    // Start is called before the first frame update
    void Start()
    {
        Shader.SetGlobalFloat("_neveNivel", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(valor < 1f)
        {
            Shader.SetGlobalFloat("_neveNivel", valor);
            valor += Time.deltaTime * velocidadeNeve;
        }
    }
}
