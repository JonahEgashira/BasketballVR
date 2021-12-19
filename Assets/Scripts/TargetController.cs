using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    [SerializeField] private GameObject scoreObject;
    [SerializeField] private GameObject attemptObject;
    private TextMeshProUGUI _scoreText;
    private TextMeshProUGUI _attemptText;
    
    public static int attempt;
    public static int score;
    
    // Start is called before the first frame update
    void Start()
    {
        attempt = 0;
        score = 0;
        _scoreText = scoreObject.GetComponent<TextMeshProUGUI>();
        _attemptText = attemptObject.GetComponent<TextMeshProUGUI>();
    }
    
    // Update is called once per frame
    void Update()
    {
        _scoreText.text = score.ToString();
        _attemptText.text = attempt.ToString();
    }
}
