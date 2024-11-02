using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Rin_Test : MonoBehaviour
{
    GameObject Question;
    public bool QuestionTurn = true; // trueが問題ターン
    public bool OBottonPush = false; // trueがOを押したとき
    public int currentQuestion = 0;

    [SerializeField]
    private Question[] questionArray = new Question[10];
    [SerializeField]
    private GameObject WAKU;
    [SerializeField]
    private GameObject KAISETUWAKU;

    // Start is called before the first frame update
    void Start()
    {
        this.Question = GameObject.Find("Rin_Test");
    }

    // Update is called once per frame
    void Update()
    {
        if (currentQuestion < questionArray.Length)
        {
            if (QuestionTurn)
            {
                WAKU.SetActive(true);
                this.Question.GetComponent<TextMeshProUGUI>().text = this.questionArray[currentQuestion].QestionText;

            }
            else
            {
                if (OBottonPush == true)
                {
                    KAISETUWAKU.SetActive(true);
                    this.Question.GetComponent<TextMeshProUGUI>().text = this.questionArray[currentQuestion].OText;
                }
                else
                {
                    KAISETUWAKU.SetActive(true);
                    this.Question.GetComponent<TextMeshProUGUI>().text = this.questionArray[currentQuestion].XText;
                }
            }
        }else
        {
        SceneManager.LoadScene("Titlecene");
        }
    }
}
