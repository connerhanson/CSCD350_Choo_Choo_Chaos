using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgrade : MonoBehaviour
{

    [SerializeField] private Button upgrade1;
    // Start is called before the first frame update
    void Start()
    {
        Button btn1 = upgrade1.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick(){
        Debug.Log("CLICKED");
    }
}
