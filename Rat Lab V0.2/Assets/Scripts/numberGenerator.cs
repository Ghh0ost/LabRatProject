using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class numberGenerator : MonoBehaviour
{
    private List<int> random_number_list = new List<int>();
    public TextMeshProUGUI randomNumber;
    public int total_numbers_in_list = 1;

    random_number_list.Add()

    void Start()
    {
    }

    public void randomNumberGenerator()
    {
        while (true)
        {
            for (int i = 0; i < total_numbers_in_list; i++)
            {
                int rand = Random.Range(1, 12);
                random_number_list.Add(rand);
            }
            foreach (var num in random_number_list)
            {
                randomNumber.text += num.ToString();
            }
        }

    }
}
