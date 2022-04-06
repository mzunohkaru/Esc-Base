using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  ³‰ğ‚Æˆê’v‚µ‚Ä‚¢‚é‚©ŠÇ—    */
public class PasswordPanel : MonoBehaviour
{
    [SerializeField] int[] correctAnswer;
    [SerializeField] Password[] passNumber;

    [SerializeField] Chest chest;

    //“ü—Í’l‚ª³‰ğ‚©”»’è
    public void OnClickButton()
    {
        if (CheckClear())
        {
            //•ó” ‚ğŠJ‚¯‚é
            chest.Open();
        }
    }

    bool CheckClear()
    {
        for (int i = 0; i < passNumber.Length; i++)
        {
            if(passNumber[i].number != correctAnswer[i])
            {
                return false;
            }
        }
        return true;
    }
}
