using TMPro;
using UnityEngine;

public class DialogueUi : MonoBehaviour
{
    [SerializeField] private TMP_Text _textComponent;
    [SerializeField] private GameObject _panel;

    public void ShowText(string phrase)
    {
        _textComponent.text = phrase;
    }

    public void EnableDialogWindow(bool isActive)
    {
        _panel.SetActive(isActive);
    }
}
