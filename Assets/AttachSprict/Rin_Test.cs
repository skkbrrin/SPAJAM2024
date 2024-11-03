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
    public int OScore = 0;
    public int XScore = 0;

    [SerializeField]
    public Question[] questionArray = new Question[10];
    [SerializeField]
    private GameObject WAKU;
    [SerializeField]
    private GameObject KAISETUWAKU;
    [SerializeField]
    private GameObject NEXT;
    [SerializeField]
    private GameObject ABOTTON;
    [SerializeField]
    private GameObject BBOTTON;

    // Start is called before the first frame update
    void Start()
    {
        this.Question = GameObject.Find("Rin_Test");
        Score.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentQuestion < questionArray.Length)
        {
            if (QuestionTurn)
            {
                WAKU.SetActive(true);
                KAISETUWAKU.SetActive(false);
                NEXT.SetActive(false);
                ABOTTON.SetActive(true);
                BBOTTON.SetActive(true);
                this.Question.GetComponent<TextMeshProUGUI>().text = this.questionArray[currentQuestion].QestionText;

            }
            else
            {
                if (OBottonPush == true)
                {
                    WAKU.SetActive(false);
                    KAISETUWAKU.SetActive(true);
                    NEXT.SetActive(true) ;
                    ABOTTON.SetActive(false);
                    BBOTTON.SetActive(false);

                    this.Question.GetComponent<TextMeshProUGUI>().text = this.questionArray[currentQuestion].OText;
                    
                }
                else
                {
                    WAKU.SetActive(false);
                    KAISETUWAKU.SetActive(true);
                    NEXT.SetActive(true);
                    ABOTTON.SetActive(false);
                    BBOTTON.SetActive(false);

                    this.Question.GetComponent<TextMeshProUGUI>().text = this.questionArray[currentQuestion].XText;
                }
            }
        }else
        {
        SceneManager.LoadScene("ResultScene");
        }
    }
}
