using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class scoreScript : MonoBehaviour
{
    public TextMeshProUGUI Myscoretext;
    public TextMeshProUGUI multipleText;
    private int ScoreNum;

    private List<int> random_number_list = new List<int>();
    int rand = Random.Range(1, 12);
    random_number_list.Add(rand);
    

// Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        Myscoretext.text = "Score: " + ScoreNum;
        multipleText = random_number_list.ToString();
    }

    void OnCollisionEnter2D(Collision2D flask)
    {
        if (flask.gameObject.tag == "Flask")
        {
            ScoreNum += 2;
            Myscoretext.text = "Score: " + ScoreNum;
            foreach (var num in random_number_list)
            {
                randomNumber.text += num.ToString();
            }
        }
    }
}
