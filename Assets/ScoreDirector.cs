using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreDirector : MonoBehaviour
{
    public Rin_Test rin_test;
    GameObject scereText;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //score = rin_test.OScore + rin_test.XScore; // SelectScene�̃q�G�����L�[�ɂ���Rin_Test������(ScoreDirector)�ɃA�^�b�`�ł����瓮����������Ȃ�
        this.scereText = GameObject.Find("Score");
        this.scereText.GetComponent<TextMeshProUGUI>().text =
            this.score.ToString() + " ninn";

    }

    // Update is called once per frame
    void Update()
    {
        //SceneManager.LoadScene("");
    }
}
