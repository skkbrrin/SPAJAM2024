using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;



public class Rin_Test : MonoBehaviour
{
    GameObject Question;
   public bool QuestionTurn = true; // trueが問題ターン
   public bool OBottonPush = false; // trueがOを押したとき

    [SerializeField]
    private Question[] questionArray = new Question[10];

    // Start is called before the first frame update
    void Start()
    {
        this.Question = GameObject.Find("Rin_Test");
    }

    // Update is called once per frame
    void Update()
    {
        if (QuestionTurn)
        {
            this.Question.GetComponent<TextMeshProUGUI>().text = this.questionArray[0].QestionText;
        }
        else
        {
            if (OBottonPush == true)
            {
                this.Question.GetComponent<TextMeshProUGUI>().text = this.questionArray[0].OText;
            }
            else
            {
                this.Question.GetComponent<TextMeshProUGUI>().text = this.questionArray[0].XText;
            }

        }
    }
}
