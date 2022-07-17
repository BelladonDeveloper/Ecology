using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSystem : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private DialoguesSO _dialoguesSO;

    private QuestState _questState = QuestState.NoQuest;

    private string _phrase;

    public void ContinueDialog()
    {
        switch (_questState)
        {
            case QuestState.NoQuest:
                _phrase = _dialoguesSO.GetPhrase(1);
                _questState = QuestState.InProgress;
                _spawner.CreateFood();
                break;
            case QuestState.InProgress:
                break;
            case QuestState.Complete:
                break;
            case QuestState.Finish:

                //    //SceneManager.LoadScene(1);

                //    print("Finish quest )");
                break;
        }
    }

    public void CheckQuest()
    {
        switch (_questState)
        {
            case QuestState.NoQuest: 
                _phrase = _dialoguesSO.GetPhrase(0);
                break;
            case QuestState.InProgress:
                _dialoguesSO.GetPhrase(2);
                break;
            case QuestState.Complete:
                _dialoguesSO.GetPhrase(3);
                _questState = QuestState.Finish;
                break;
            case QuestState.Finish:
                break;
        }
    }

    private void SetPhraseToUI()
    {
        //_dialogUI.ShowPhrase(_phrase);
    }

    public enum QuestState
    {
        NoQuest,
        InProgress,
        Complete,
        Finish
    }
}