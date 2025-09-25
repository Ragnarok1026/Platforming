using System.Collections;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements.Experimental;

public class LoadDream : MonoBehaviour
{
    public Animator transition;
    void Update()
    {
        transition.SetTrigger("End");
    }
}
