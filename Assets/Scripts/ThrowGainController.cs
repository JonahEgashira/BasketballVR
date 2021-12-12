using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ThrowGainController : MonoBehaviour
{
    private GameObject _rightHand;

    [SerializeField] private Text textArea;
    // Start is called before the first frame update
    private void Awake()
    {
        _rightHand = GameObject.Find("CustomHandRight");
    }

    // Update is called once per frame
    void Update()
    {
        textArea.text = _rightHand.GetComponent<OVRGrabber>().throwGain.
            ToString(CultureInfo.CurrentCulture);
    }
}
