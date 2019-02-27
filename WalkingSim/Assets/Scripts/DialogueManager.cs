using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;
    public bool dialogActive;
    public int currentLine;
   

    private bool isTyping = false;
   private bool cancelTyping = false;

    public float typeSpeed;
    public string[] dialogLines;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dialogActive && !isTyping )
        {
            // dBox.SetActive(false);
            //dialogActive = false;
            currentLine++;
            if (currentLine > dialogLines.Length ) {
                dBox.SetActive(false);
                dialogActive = false;
            }
            else
            {
                StartCoroutine(TextScroll(dialogLines[currentLine]));
            }

        }
        else if (isTyping && !cancelTyping){
            cancelTyping = true;
        }

       
    }

    private IEnumerator TextScroll( string dialogLines) {
        int letter = 0;
        dText.text = "";
        isTyping = true;
        cancelTyping = false;
        while (isTyping && !cancelTyping && (letter < dialogLines.Length-1)) {
            dText.text += dialogLines[letter];
            letter += 1;
            yield return new WaitForSeconds(typeSpeed);
        }

        dText.text = dialogLines;
        isTyping = false;
        cancelTyping = false;
    }
    

}
