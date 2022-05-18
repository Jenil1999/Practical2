using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Find_Words : MonoBehaviour
{
    string FilePath, FileName;
    [SerializeField] string Characteratoz; //Field For start Character of name Which we want to Print.
    [SerializeField] int WordsLength;  //Field For Length of Name Which We Want to print.

    string[] NameArray; 

    void Start()
    {
        FileName = "words_alpha.txt";
        FilePath = Application.dataPath + "/" + FileName; //FileLocation
       ReadFromFile();
    }
    public void ReadFromFile()
    {
        NameArray = File.ReadAllLines(FilePath); //Reading All Lines.
        foreach(string line in NameArray)
        {
            if(line.StartsWith(Characteratoz) && line.Length == WordsLength) //check Our COnditions
            {
                Debug.Log(line);
            }
        }
    }
}
