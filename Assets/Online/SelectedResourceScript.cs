using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Normal.Realtime;
using TMPro;

public class SelectedResourceScript : RealtimeComponent<SelectedResourceModel>
{

    private SelectedResourceModel _model;
    //public RealtimeAvatarManager _avatarManager;
    private TextMeshProUGUI _selectedResourceText;
    public string selectedResourceCustom;



    //public ResourceStringUpdatedScript resourceStringUpdatedScript;


    private void Awake()
    {
        //get the reference to the selectedResource textygame object
        _selectedResourceText = GetComponent<TextMeshProUGUI>();
    }

    private SelectedResourceModel model
    {
        set
        {

            if (_model != null)
            {
                //unregister from events
                _model.selectedResourceDidChange -= SelectedResourceDidChange;
            }
            //store the model
            _model = value;

            if (_model != null)
            {
                //Update the selectedResource to match new value
                UpdateSelectedResourceText();
                // register for events so we'll nkow if the selectedResource chagnes later
                _model.selectedResourceDidChange += SelectedResourceDidChange;
            }

        }

    }

    private void SelectedResourceDidChange(SelectedResourceModel model, string value)
    {
        UpdateSelectedResourceText();


    }

    private void UpdateSelectedResourceText()
    {
        _selectedResourceText.text = "" + _model.selectedResource;
    }

    public string GetSelectedResource()
    {
        return _model.selectedResource;
    }



    public void SetSelectedResource(string selectedResourceCustom)
    {
        _model.selectedResource = _model.selectedResource = selectedResourceCustom;


    }


}
