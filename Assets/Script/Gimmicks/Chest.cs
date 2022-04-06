using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] Animation anim;
    [SerializeField] GameObject item;

    private void Start()
    {
        item.SetActive(false);
    }


    public void Open()
    {
        item.SetActive(true);
        anim.Play();
    }
}
