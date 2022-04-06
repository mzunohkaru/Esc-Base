using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    [SerializeField] Animator animator;
    bool isOpen = false;

    public void OnClickPlate()
    {
        if(isOpen)
        {
            Close();
        }
        else
        {
            Open();
        }
    }

    void Open()
    {
        isOpen = true;
        animator.Play("PlateOpenAnim");
    }

    void Close()
    {
        isOpen = false;
        animator.Play("PlateCloseAnim");
    }
}
