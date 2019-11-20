using System.Collections.Generic;
using UnityEngine;
using Zork.Common;
using TMPro;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    private TextMeshProUGUI TextLinePreFab;

    [SerializeField]
    private Transform OutputTextContainer;

    [SerializeField]
    private int MaxTextLines = 60;

    public UnityOutputService()
    {
        mTextLines = new List<GameObject>();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public void Write(string value)
    {
        throw new System.NotImplementedException();
    }

    public void Write(object value)
    {
        throw new System.NotImplementedException();
    }

    public void WriteLine(string value)
    {
        if (mTextLines.Count >= MaxTextLines)
        {
            Destroy(mTextLines[0]);
            mTextLines.RemoveAt(0);
        }

        var textLine = Instantiate(TextLinePreFab);
        textLine.transform.SetParent(OutputTextContainer, false);
        textLine.text = value;
        mTextLines.Add(textLine.gameObject);

    }

    public void WriteLine(object value)
    {
        WriteLine(value.ToString());
    }

    private List<GameObject> mTextLines;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
