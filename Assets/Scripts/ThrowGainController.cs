using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ThrowGainController : MonoBehaviour
{
    private GameObject _rightHand;
    public static int throwState;
    private string _throwStateText;

    [SerializeField] private TextMeshProUGUI gainText;
    [SerializeField] private TextMeshProUGUI modeText;
    // Start is called before the first frame update
    private void Awake()
    {
        throwState = 2;
        _rightHand = GameObject.Find("CustomHandRight");
    }

    // Update is called once per frame
    void Update()
    {
        gainText.text = _rightHand.GetComponent<OVRGrabber>().throwGain.
            ToString(CultureInfo.CurrentCulture);

        switch (throwState)
        {
            case 0:
                _throwStateText = "Normal";
                break;
            case 1:
                _throwStateText = "Random";
                break;
            case 2:
                _throwStateText = "Alt";
                break;
            case 3:
                _throwStateText = "High";
                break;
            default:
                _throwStateText = "Normal";
                break;
        }

        modeText.text = _throwStateText;
    }
}
