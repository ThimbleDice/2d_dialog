using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
[CreateAssetMenu(menuName = "Dialog")]
public class DialogText : ScriptableObject {
    [TextArea(10, 14)] [SerializeField] string scriptableText;
    [SerializeField] DialogText nextDialog;

    public string GetDialogText() {
        return scriptableText;
    }

    public DialogText GetNextDialog() {
        return this.nextDialog;
    }

    public bool IsNextDialog() {
        if (nextDialog) {
=======
[CreateAssetMenu(menuName ="Dialog")]
public class DialogText : ScriptableObject {
    [TextArea(10, 14)] [SerializeField] string scriptableText;
    [SerializeField] DialogText nextDialog;
    public string GetDialogText()
    {
        return this.scriptableText;
    }

    public DialogText GetNextDialog()
    {
        return this.nextDialog;
    }

    public bool IsNextDialog()
    {
        if (nextDialog)
        {
>>>>>>> 01173ae9d9efd12812e6ee89730e12938f55446f
            return true;
        }
        return false;
    }
<<<<<<< HEAD

=======
>>>>>>> 01173ae9d9efd12812e6ee89730e12938f55446f
}
