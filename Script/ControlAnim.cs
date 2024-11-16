using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class ControlAnim : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animator anim;
    void Start()
    {
        anim.Play("Idle");
    }

    // Update is called once per frame
    int index =0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            switch (index){
                case 0: anim.Play("Dacing");
                break;

                case 1: anim.Play("Idle1");
                break;

            }
            index ++;
            index =index %2;
                

        }
    }
}
