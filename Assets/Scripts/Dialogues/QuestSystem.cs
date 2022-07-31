using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestSystem : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private DialoguesSO _dialoguesSO;
    [SerializeField] private DialogueUi _dialogueUi;
    [SerializeField] private FoodQuest _foodQuest;

    private QuestState _questState = QuestState.NoQuest;

    private string _phrase;
    private bool _isDialogOpen = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && _isDialogOpen)
        {
            ContinueDialog();
        }
    }

    public void ContinueDialog()
    {
        switch (_questState)
        {
            case QuestState.NoQuest:
                _phrase = _dialoguesSO.GetPhrase(1);
                SetPhraseToUI();
                _questState = QuestState.InProgress;
                _spawner.CreateFood();
                break;

            case QuestState.InProgress:
                _dialogueUi.EnableDialogWindow(false);
                _isDialogOpen = false;
                break;

            case QuestState.Complete:
                _phrase = _dialoguesSO.GetPhrase(5);
                SetPhraseToUI();
                _questState = QuestState.Finish;
                break;

            case QuestState.Finish:
                print("Finish quest )");
                SceneManager.LoadScene(1);
                break;
        }
    }

    public void CheckQuest()
    {
        _isDialogOpen = true;

        switch (_questState)
        {
            case QuestState.NoQuest:
                OpenDialogWithPhrase(0);
                break;

            case QuestState.InProgress:
                _dialogueUi.EnableDialogWindow(true);
                int qualityFood = _foodQuest.GetQualityGoodFood();
                _phrase = _dialoguesSO.GetPhrase(2) + qualityFood + _dialoguesSO.GetPhrase(3);
                SetPhraseToUI();
                break;

            case QuestState.Complete:
                OpenDialogWithPhrase(4);
                break;
        }
    }

    private void OpenDialogWithPhrase(int phraseNumber)
    {
        _dialogueUi.EnableDialogWindow(true);
        _phrase = _dialoguesSO.GetPhrase(phraseNumber);
        SetPhraseToUI();
    }

    private void SetPhraseToUI()
    {
        _dialogueUi.ShowText(_phrase);
    }

    public void ChangeState(QuestState state)
    {
        _questState = state;
    }

    public enum QuestState
    {
        NoQuest,
        InProgress,
        Complete,
        Finish
    }
}