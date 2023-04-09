using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SearchSystem : MonoBehaviour
{
    public List<GameObject> searchCards = new List<GameObject>();
    private List<string> searchCardName = new List<string>();
    public GameObject scrollView;
    public GameObject contentHolder;
    public GameObject searchBar;
    string searchText;
    
    void Start()
    {
        int n = contentHolder.transform.childCount;
        for(int i=0;i<n;i++){
            searchCards.Add(contentHolder.transform.GetChild(i).gameObject);
        }
    }

    void Update()
    {
        
    }

    public void search(){
        string inputString = searchBar.GetComponent<TMP_InputField>().text;
        if (inputString.Length == 0)
        {
            scrollView.SetActive(false);
            return;
        }
        scrollView.SetActive(true);

        foreach (GameObject card in searchCards)
        {
            string currentCardName = card.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text.ToLower();
            bool isMatch = currentCardName.Contains(inputString.ToLower());

            if(isMatch){
                card.SetActive(true);
            }else{
                card.SetActive(false);
            }
        }
    }
}
