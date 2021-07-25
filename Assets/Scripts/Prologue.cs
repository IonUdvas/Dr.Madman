using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prologue : MonoBehaviour
{

    private FunctionTimer functionTimer;
    // Start is called before the first frame update
    private void Start()
    {
        functionTimer = new FunctionTimer(TestingAction,62f);
    }

    private void Update(){
        functionTimer.Update();
    }

    private void TestingAction(){
        SceneManager.LoadScene("SampleScene");
    }
}
