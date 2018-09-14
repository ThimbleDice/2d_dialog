using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour {
    [SerializeField] public GameObject dialogPrefab;
    [SerializeField] public GameObject mainCanvas;

    private bool actionAxisInUse = true;
    private GameObject player;
    private bool dialogIsInitiated = false;
    private DialogText currentDialog;
<<<<<<< HEAD
    private DialogTextDisplayer currentTextDisplayer;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update() {
        ProcessInput();
    }

    public void StartDialog(DialogText dialog) {
        dialogIsInitiated = true;
        player.GetComponent<PlayerMovement>().DisableControl();
        currentDialog = dialog;
        GameObject currentDialogObject = Instantiate(dialogPrefab, mainCanvas.transform);
        currentTextDisplayer = currentDialogObject.GetComponent<DialogTextDisplayer>();
        currentTextDisplayer.SetDialogText(currentDialog.GetDialogText());
    }

    public void ProcessInput() {
        if (ShouldProcessInput()) {
            actionAxisInUse = true;
            if (currentDialog.IsNextDialog()) {
                currentDialog = currentDialog.GetNextDialog();
                currentTextDisplayer.SetDialogText(currentDialog.GetDialogText());
            } else {
                EndDialog();
            }
        }
        ValidateAxisInUse();
    }

    public void EndDialog() {
        dialogIsInitiated = false;
        currentTextDisplayer.CloseDialog();
=======
    private DialogDisplayer currentDialogDisplayer;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        ProcessInput();
    }

    public void StartDialog(DialogText newDialog)
    {
        dialogIsInitiated = true;
        player.GetComponent<PlayerMovement>().DisableControl();
        currentDialog = newDialog;
        GameObject currentDialogObject = Instantiate(dialogPrefab, mainCanvas.transform);
        currentDialogDisplayer = currentDialogObject.GetComponent<DialogDisplayer>();
        currentDialogDisplayer.SetDialogText(currentDialog.GetDialogText());
    }
    public void ProcessInput()
    {
        if (ShouldProcessInput())
        {
            actionAxisInUse = true;
            if (currentDialog.IsNextDialog())
            {
                currentDialog = currentDialog.GetNextDialog();
                currentDialogDisplayer.SetDialogText(currentDialog.GetDialogText());
            }
            else
            {
                EndDialog();
            }
        }
    }
    public void EndDialog()
    {
        dialogIsInitiated = false;
        currentDialogDisplayer.CloseDialog();
>>>>>>> 01173ae9d9efd12812e6ee89730e12938f55446f
        player.GetComponent<PlayerMovement>().EnableControl();
        currentDialog = null;
    }

<<<<<<< HEAD
    private bool ShouldProcessInput() {
        if (dialogIsInitiated) {
            if (!actionAxisInUse && Input.GetAxis("Jump") != 0) {
                print(!actionAxisInUse);
=======
    private bool ShouldProcessInput()
    {
        if (dialogIsInitiated)
        {
            if(!actionAxisInUse && Input.GetAxis("Jump") != 0)
            {
>>>>>>> 01173ae9d9efd12812e6ee89730e12938f55446f
                return true;
            }
        }
        return false;
    }

<<<<<<< HEAD
    private void ValidateAxisInUse() {
        if (Input.GetAxis("Jump") != 0) {
            actionAxisInUse = true;
        } else {
            actionAxisInUse = false;
        }
    }
=======
    private void ValideAxisInUse()
    {
        if (Input.GetAxis("Jump") != 0)
        {
            actionAxisInUse = true;
        }
        else
        {
            actionAxisInUse = false;
        }
    }

>>>>>>> 01173ae9d9efd12812e6ee89730e12938f55446f
}
