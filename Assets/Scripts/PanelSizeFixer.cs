using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSizeFixer : MonoBehaviour
{
    public PAData paData;
    private RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {
        this.rectTransform = GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(paData.FRAME*3,64);
    }

}
