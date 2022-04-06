using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  �����ƈ�v���Ă��邩�Ǘ�    */
public class PasswordPanel : MonoBehaviour
{
    [SerializeField] int[] correctAnswer;
    [SerializeField] Password[] passNumber;

    [SerializeField] Chest chest;

    //���͒l������������
    public void OnClickButton()
    {
        if (CheckClear())
        {
            //�󔠂��J����
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
