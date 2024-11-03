using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesChoice : MonoBehaviour
{
    public Rin_Test rin_Test;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("o");
        //}
    }

    public void YesButtonDown()
    {
        Debug.Log("o");
        if (rin_Test.QuestionTurn)
        {
            rin_Test.QuestionTurn = false;
            rin_Test.OBottonPush = true;
        }
        else
        {
            rin_Test.QuestionTurn=true;
            rin_Test.OScore += 100;
            rin_Test.currentQuestion++;
        }
    }
    
}
