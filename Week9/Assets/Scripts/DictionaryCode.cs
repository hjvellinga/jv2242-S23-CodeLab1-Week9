using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 

public class DictionaryCode : MonoBehaviour
{
    private Dictionary<string, Sprite> characterTraits = new Dictionary<string, Sprite>();
    public int characterPoints = 5;
    public TMP_Text characterPointsDisplay;
    public Image image;
    public Sprite athleticism;
    public Sprite humor; 
    public Sprite intelligence;
    public Sprite charisma;
    public Sprite clearance; 
        
    // Start is called before the first frame update
    void Start()
    {
        characterTraits.Add("athleticism", athleticism);
        characterTraits.Add("humor", humor);
        characterTraits.Add("intelligence", intelligence);
        characterTraits.Add("charisma", charisma);
        characterTraits.Add("clearance", clearance);
    }

    public void SpawnSprite (string heaviestAttribute)
    {
        Sprite attributeSprite = characterTraits[heaviestAttribute];
        Debug.Log(message: heaviestAttribute);
        image.sprite = attributeSprite; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
