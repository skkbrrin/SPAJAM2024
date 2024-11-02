using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;



public class Rin_Test : MonoBehaviour
{
    GameObject Question;
    int QuestionCount;

    Question questionObject;

    // Start is called before the first frame update
    void Start()
    {
        this.Question = GameObject.Find("Rin_Test");
        this.questionObject = new Question();
        this.questionObject.QestionText = "質問1";
    }

    // Update is called once per frame
    void Update()
    {
        this.Question.GetComponent<TextMeshProUGUI>().text = this.questionObject.QestionText;
    }
}
