using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSwitcher : MonoBehaviour
{
    [SerializeField] private DialoguesSO _textUi;
    [SerializeField] private DialogueUi _dialogueUi;
    private string _phrase;

    void Start()
    {
        
    }

    
    void Update()
    {
        
       _phrase = _textUi.GetUIText(1);
        SetPhraseToUI();


    }
    private void SetPhraseToUI()
    {
        _dialogueUi.ShowText(_phrase);
    }






}
