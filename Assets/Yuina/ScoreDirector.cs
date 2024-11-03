using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreDirector : MonoBehaviour
{
    public Rin_Test rin_test;
    GameObject scereText;

    // Start is called before the first frame update
    void Start()
    {
        this.scereText = GameObject.Find("Score");
        this.scereText.GetComponent<TextMeshProUGUI>().text =
            Score.score.ToString() + " 票\n獲得しました。";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        SceneManager.LoadScene("Titlecene");
    }
}
