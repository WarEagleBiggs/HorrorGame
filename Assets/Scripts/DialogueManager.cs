using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public List<String> Dialogue;
    public int curr;
    public bool canContinue;
    public TextMeshProUGUI txt;
    public DoorDetect DetectScriptRef;
    
    void Update()
    {
        updateDialogue();
        checkInput();

        
    }

    /*private void LateUpdate()
    {
        
        if (DetectScriptRef.DialogueObj.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            DetectScriptRef.DialogueObj.SetActive(!DetectScriptRef.DialogueObj.activeSelf);
            DetectScriptRef.m_move.enabled = !DetectScriptRef.m_move.isActiveAndEnabled;
            DetectScriptRef.m_look.enabled = !DetectScriptRef.m_look.isActiveAndEnabled;
        }
    }*/

    public void updateDialogue()
    {
        txt.SetText(Dialogue[curr]);
    }

    public void checkInput()
    {
        if (Input.GetKeyDown(KeyCode.N) && canContinue)
        {
            Dialogue[curr] = Dialogue[curr++];
        } else if (Input.GetKeyDown(KeyCode.N))
        {
            
        }
    }
    

    
}
