using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SearchInList : MonoBehaviour
{
    public TMP_InputField input;
    public TextMeshProUGUI display;

    public TextAsset textFile;
    
    private List<string> flowersList;
    
    // Start is called before the first frame update
    void Start()
    {
        flowersList = new List<string>();
        
        var flowersFromFile = textFile.text.Split('\n');
        
        for (var i = 0; i < flowersFromFile.Length; i++)
        {
            flowersList.Add(flowersFromFile[i].ToUpper().Trim());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (input.text == "")
        {
            display.text = "See if your fav flower is in the list! 🌸";
        }
        else
        {
            display.text = "Oops, not in the list...";
            if (flowersList.Contains(input.text.ToUpper()))
            {
                display.text = input.text + " is in the list!";
            }
        }
    }
}
