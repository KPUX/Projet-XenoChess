#pragma strict

var Debut : boolean = false;
var BoutonUn : GameObject;
var BoutonDeux : GameObject;
var BoutonTrois : GameObject;
var BoutonQuatre : GameObject;
var BoutonCinq : GameObject;


function Update () 
{
    if (Debut == true)
    {
        BoutonUn.SetActive(false);
        BoutonDeux.SetActive(true);
        BoutonTrois.SetActive(true);
        BoutonQuatre.SetActive(true);
        BoutonCinq.SetActive(true);
    }
    else{}
}

function EnableGameObject()
{
    Debut = true;
}