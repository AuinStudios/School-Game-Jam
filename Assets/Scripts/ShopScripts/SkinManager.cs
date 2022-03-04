using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinManager", menuName = "Skin Manager")]
public class SkinManager : ScriptableObject
{
    public bool skinbool = false;
    [SerializeField] public Skin[] skins;
    [SerializeField] public Trail[] trails;
    private const string Prefix = "Skin_";
    private const string SelectedSkin = "SelectedSkin";
    private const string selectedtrail = " selectedtrail";
    public void SelectSkin(int skinIndex) => PlayerPrefs.SetInt(SelectedSkin, skinIndex);
    public void selecttrail(int trailindex) => PlayerPrefs.SetInt(selectedtrail, trailindex);


    public Trail GetTrail()
    {
        return null;
    }
    public Skin GetSelectedSkin()
    {
       
            int skinIndex = PlayerPrefs.GetInt(SelectedSkin, 0);
            if (skinIndex >= 0 && skinIndex < skins.Length)
            {
                return skins[skinIndex];
            }
            else
            {
                return null;
            }

    }

    public void Unlock(int skinIndex) => PlayerPrefs.SetInt(Prefix + skinIndex, 1);

    public bool IsUnlocked(int skinIndex) => PlayerPrefs.GetInt(Prefix + skinIndex, 0) == 1;
}