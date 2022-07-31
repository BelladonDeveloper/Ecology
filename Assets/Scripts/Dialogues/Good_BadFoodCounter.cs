using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Good_BadFoodCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _textGoodFood;
    [SerializeField] private TMP_Text _textBadfood;

    private int _counterGoodFood;
    private int _counterBadFood;


    void Start()
    {
        QuestObject.PickUpQuestObject += UpdateNumberFood;
    }

    private void UpdateNumberFood(bool isGoodFood)
    {
        if (isGoodFood)
        {
            _counterGoodFood++;
            _textGoodFood.text = $"Good Food: {_counterGoodFood}";
        }
        else
        {
            _counterBadFood++;
            _textBadfood.text = $"Bad Food: {_counterBadFood}";
        }
    }
}