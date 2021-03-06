using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  正解と一致しているか管理    */
public class PasswordPanel : MonoBehaviour
{
    [SerializeField] int[] correctAnswer;
    [SerializeField] Password[] passNumber;

    [SerializeField] Chest chest;

    //入力値が正解か判定
    public void OnClickButton()
    {
        if (CheckClear())
        {
            //宝箱を開ける
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
