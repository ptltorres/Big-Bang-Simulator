using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;


public class SpeechManager : MonoBehaviour {
    KeywordRecognizer keywordRecognizer = null;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    // Use this for initialization
    void Start() {
        keywords.Add("Next level", () => {
            // get a LevelManager Object and calls its loadNextLevel() method
            FindObjectOfType<LevelManager>().loadNextLevel();
        });

        keywords.Add("Start big bang", () => {
            var focusObject = GazeGestureManager.Instance.FocusedObject;
            if (focusObject != null) {
                // Call the Explode method on just the focused object.
                focusObject.SendMessageUpwards("OnSelect"); 
            }
        });

        // Tell the KeywordRecognizer about our keywords.
        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());

        // Register a callback for the KeywordRecognizer and start recognizing!
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args) {
        System.Action keywordAction;
        if (keywords.TryGetValue(args.text, out keywordAction)) {
            keywordAction.Invoke();
        }
    }
}