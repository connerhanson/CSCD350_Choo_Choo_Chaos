using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class upgrade : MonoBehaviour
{

    [SerializeField] private Button upgrade1;
    [SerializeField] TextMeshProUGUI m_Object;
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
        m_Object.text += 1;
    }
}
