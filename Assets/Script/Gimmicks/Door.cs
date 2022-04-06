using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    [SerializeField] Animation anim;

    

    public void Open()
    {
        anim.Play();
    }
}
