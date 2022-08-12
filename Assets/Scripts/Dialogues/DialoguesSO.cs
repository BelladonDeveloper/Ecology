using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialoguesSO", menuName = "ScriptableObject/DialoguesSO")]
public class DialoguesSO : ScriptableObject
{
    [SerializeField] private List<string> _phrases = new List<string>();
    [SerializeField] private List<string> _uiTexts = new List<string>();

    public string GetPhrase(int index)
    {
        string phrase = _phrases[index];

        if (index > _phrases.Count - 1)
        {
            return _phrases[0];
        }

        return phrase;
    }

    public string GetUIText(int index)
    {
        string uiText = _uiTexts[index];

        if (index > _uiTexts.Count - 1)
        {
            return _uiTexts[0];
        }

        return uiText;
    }
}
