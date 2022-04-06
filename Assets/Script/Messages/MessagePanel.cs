using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagePanel : MonoBehaviour
{
    public static MessagePanel instance;

    [SerializeField] GameObject messagePanel;
    [SerializeField] Text messageText;
    [SerializeField] int letterPerSecond;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        messagePanel.SetActive(true);
        StartCoroutine(TypeDialog("ここは...どこだ?"));
    }


    // パネルの表示/非表示
    public void ShowPanel(string message)
    {
        messagePanel.SetActive(true);
        StartCoroutine(TypeDialog(message));
    }

    public void HidePanel()
    {
        messagePanel.SetActive(false);
    }


    public IEnumerator TypeDialog(string dialog)
    {
        messageText.text = "";
        foreach (char letter in dialog)
        {
            messageText.text += letter;
            yield return new WaitForSeconds(1f / letterPerSecond);
        }

        yield return new WaitForSeconds(0.7f);
    }
}
