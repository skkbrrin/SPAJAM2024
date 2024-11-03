using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreDirector : MonoBehaviour
{
    public Rin_Test rin_test;
    GameObject scereText;

    // Start is called before the first frame update
    void Start()
    {
        this.scereText = GameObject.Find("Score");
        this.scereText.GetComponent<TextMeshProUGUI>().text =
            Score.score.ToString() + " ninn";

    }

    // Update is called once per frame
    void Update()
    {
        //SceneManager.LoadScene("");
    }
}
