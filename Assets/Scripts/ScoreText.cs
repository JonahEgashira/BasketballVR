using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    private TextMeshPro _scoreText;
    public static int Score;
    // Start is called before the first frame update
    void Start()
    {
        _scoreText = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = Score.ToString();
    }
}
