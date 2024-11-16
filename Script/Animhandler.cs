using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animhandler : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    int index =0;
    void Update()
    {
        if (index!=0){
            switch(index){
                case 1:
                anim.Play("Idle");
                index = 0;

                break;

                case 2:
                anim.Play("Dancing");
                index=0;
                break;

                case 3:
                anim.Play("Idle1");
                index=0;
                break;
            }

        }
    }

    public void indexClicked(int indexClick){
        index = indexClick;
        Debug.Log("Animacion"+index);
    }
}
