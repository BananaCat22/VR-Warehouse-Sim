using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SurveyBehavior : MonoBehaviour
{
    public InputField input1;
    public InputField input2;
    int response1;
    int response2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        input1.onEndEdit.AddListener(SubmitResponse1);
        input2.onEndEdit.AddListener(SubmitResponse2);
    }

    // Update is called once per frame
    void SubmitResponse1(string arg0)
    {
        response1=int.Parse(arg0);
        Debug.Log(response1);
    }
    void SubmitResponse2(string arg0)
    {
        response2=int.Parse(arg0);
        Debug.Log(response2);
    }
       
}
