using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Data : Game
{
    public bool fileImported;
    [SerializeField] private List<TextBlockObject> textData = new List<TextBlockObject>();

    private void Awake()
    {
        fileImported = false;
        ImportFile();
        fileImported = true;
        print("IMPORT SUCESS");
    }

    public void ImportFile()
    {
        // variables
        StreamReader file = new StreamReader("Assets/file.txt");
        List<string> fileLines = new List<string>();
        int currentLine=0;

        // dump from file //
        string line;
        while ((line = file.ReadLine()) != null)
        {
            if (line != "")
                fileLines.Add(line);
        }

        // create textBlock objects //
        currentLine = 0;
        int id;
        string block;
        List<string> option = new List<string>();
        List<int> optionDest = new List<int>();
        bool allLinesParsed = false;

        // loop through and parse //
        while (!allLinesParsed)
        {
            // id
            id = Int32.Parse(fileLines[currentLine]);
            currentLine++;
            // block
            block = fileLines[currentLine];
            currentLine++;
            // options
            if (fileLines[currentLine].Contains(":"))
            {
                bool optionsDone = false;
                while (!optionsDone)
                {
                    currentLine++;
                    // add option string and destination to list //
                    option.Add(GetOptionString(fileLines[currentLine]));
                    optionDest.Add(GetOptionInt(fileLines[currentLine]));
                    currentLine++;
                    // exit if no options left
                    if (fileLines[currentLine].Contains("="))
                        optionsDone = true;
                }
            }

            // create object with data and add to database
            TextBlockObject textObj = new TextBlockObject(id, block, option, optionDest);
            AddToTextData(textObj);

            // reset temp variables
            option.Clear();
            optionDest.Clear();

            // check if done
            if (currentLine+1 == fileLines.Count)
                allLinesParsed = true;
            else
                currentLine++;
        }
    }

    string GetOptionString(string s)
    {
        return s.Substring(0, s.IndexOf("@"));
    }

    int GetOptionInt(string s)
    {
        return Int32.Parse(s.Substring(s.IndexOf("@") + 1));
    }

    public void AddToTextData(TextBlockObject textObj)
    {
        textData.Add(textObj);
    }

    public void PrintAllTextObj()
    {
        foreach(TextBlockObject t in textData)
        {
            t.PrintData();
        }
    }

    public TextBlockObject GetTextDataAt(int index)
    {
        return textData[index];
    }
}
