using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _goodFood = new List<GameObject>();
    [SerializeField] private List<GameObject> _badFood = new List<GameObject>();
    [SerializeField] private List<Transform> _targets = new List<Transform>();

    [SerializeField] private int numberOfGoodFoods = 10;

    private void Start()
    {
        for (int i = 0; i < numberOfGoodFoods; i++)
        {
            int randomTargetIndex = Random.Range(0, _targets.Count - 1);
            int randomFoodIndex = Random.Range(0, _goodFood.Count - 1);

            GameObject newFood = Instantiate(_goodFood[randomFoodIndex], transform);
            newFood.transform.position = _targets[randomTargetIndex].position;

            _targets.RemoveAt(randomTargetIndex);
        }

        while (_targets.Count > 0)
        {
            int randomTargetIndex = Random.Range(0, _targets.Count - 1);
            int randomFoodIndex = Random.Range(0, _badFood.Count - 1);

            GameObject newFood = Instantiate(_badFood[randomFoodIndex], transform);
            newFood.transform.position = _targets[randomTargetIndex].position;

            _targets.RemoveAt(randomTargetIndex);
        }
    }
}
