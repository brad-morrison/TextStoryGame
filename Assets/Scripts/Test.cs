using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : Game
{
    public GameObject IDText;
    public GameObject BlockText;

    // Start is called before the first frame update
    void Start()
    {
        SetIDText();
        SetBlockText();
    }

    public void SetIDText()
    {
        IDText.GetComponent<UnityEngine.UI.Text>().text = game.data.GetTextDataAt(0).GetID().ToString();
    }

    public void SetBlockText()
    {
        BlockText.GetComponent<UnityEngine.UI.Text>().text = game.data.GetTextDataAt(0).GetText();
    }
}
