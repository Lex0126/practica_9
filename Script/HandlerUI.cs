using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandlerUI : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]

    GameObject objetoPanel;
        int cont;

        float contT;

        [SerializeField] TextMeshProUGUI texto_contador;

    void Start()
    {   cont = 0;
        contT = 0;
        texto_contador.text = contT.ToString();
        objetoPanel.SetActive(false);
    }
    

    // Update is called once per frame
    void Update()
    {   
        if (SceneManager.GetActiveScene().buildIndex ==0 && objetoPanel.activeSelf){
             contT += Time.deltaTime;
             if(contT>=1f){
                cont++;
                texto_contador.text = cont.ToString();
                contT =0;
             }

        }
    }

    public void activaPanel (bool isVisible){
        cont = 0;
        texto_contador.text = cont.ToString();
        objetoPanel.SetActive(isVisible);
    }
}
