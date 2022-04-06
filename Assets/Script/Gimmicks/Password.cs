using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Password : MonoBehaviour
{
    [SerializeField] TMP_Text numberText; //UI変数
    public int number;

    //クリックされたら、数字を増やす
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
