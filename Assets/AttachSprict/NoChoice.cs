using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoChoice : MonoBehaviour
{
    public Rin_Test rin_Test;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("x");
        //}

    }

    public void NoButtonDown()
    {
        Debug.Log("x");
        if (rin_Test.QuestionTurn)
        {
            rin_Test.QuestionTurn = false;
            Score.score = rin_Test.questionArray[rin_Test.currentQuestion].XScore;
            rin_Test.OBottonPush = false;
        }
        else
        {
            rin_Test.QuestionTurn = true;
            rin_Test.currentQuestion++;
        }
    }
}
