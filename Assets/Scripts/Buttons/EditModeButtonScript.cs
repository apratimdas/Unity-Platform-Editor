﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class EditModeButtonScript : MonoBehaviour
    , IPointerClickHandler
    , IPointerEnterHandler
    , IPointerExitHandler
{

    public Text label;

    [SerializeField]
    private GameObject SaveButton;
    [SerializeField]
    private GameObject LoadButton;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        SaveButton.SetActive(false);
        LoadButton.SetActive(false);
        EditorIk.Instance.GetComponent<EditorIk>().ChangeState();
        //transform.parent.gameObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
    }

    public void OnPointerExit(PointerEventData eventData)
    {
    }
}
