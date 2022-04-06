using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Password : MonoBehaviour
{
    [SerializeField] TMP_Text numberText; //UI�ϐ�
    public int number;

    //�N���b�N���ꂽ��A�����𑝂₷
    public void OnClickPassword()
    {
        number++;
        if (number > 9) 
        {
            number = 0;
        }
        numberText.text = number.ToString();
    }
}
