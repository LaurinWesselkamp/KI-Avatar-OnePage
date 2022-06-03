using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 * Dies ist eine selbst erstellte Klasse um den Text aus dem InputField in die Tabelle zu importieren
 * 
 * @author Laurin Wesselkamp
 * @version 01.06.2022
 */

public class SetNameOnScreen : MonoBehaviour
{
    public TextMeshProUGUI _kommentar;
    public TMP_InputField _kommentarInputField;

    public void setKommentar()
    {
        _kommentar.text = _kommentarInputField.text;
    }
  
}
