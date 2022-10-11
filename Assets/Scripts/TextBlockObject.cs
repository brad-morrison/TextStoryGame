using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBlockObject : Game
{
    // the unique id for this textBlock
    int id;
    // the textual content (text and options text)
    string textBlock = "";
    List<string> options = new List<string>();
    // the id that is called when the option is chosen
    List<int> optionDestinations = new List<int>();

    // constructor
    public TextBlockObject(int _id, string _text, List<string> _options, List<int> _optionDest)
    {
        id = _id;
        textBlock = _text;
        options = new List<string>(_options);
        optionDestinations = new List<int>(_optionDest);
    }

    public int GetID()
    {
        return id;
    }

    public string GetText()
    {
        return textBlock;
    }

    public int GetOptionCount()
    {
        return options.Count;
    }

    public string GetOption(int index)
    {
        return options[index];
    }

    public int GetOptionDestination(int index)
    {
        return optionDestinations[index];
    }

    public void PrintData()
    {
        print("id - " + id);
        print("block - " + textBlock);
        foreach(string s in options)
        {
            print("option - " + s);
        }
        foreach (int i in optionDestinations)
        {
            print("option - " + i);
        }
    }
}
