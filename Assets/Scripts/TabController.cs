using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TabController : MonoBehaviour
{
    public Image ARPointer;
    public Image HomePointer;
    public Image RecordPointer;

    public Image ARPointer1;
    public Image HomePointer1;
    public Image RecordPointer1;

    public TMP_Text ARtext;
    public TMP_Text Hometext;
    public TMP_Text Recordtext;

   




    public Sprite PointerImage;

    
    public Button ARButton, HomeButton, RecordButton;
    // Start is called before the first frame update
    void Start()
    {
        ARButton.onClick.AddListener(CheckAR);
        HomeButton.onClick.AddListener(CheckHome);
        RecordButton.onClick.AddListener(CheckRecord);
    }
    void CheckAR()
    {
        ARPointer.sprite = PointerImage;
        HomePointer.sprite = null;
        RecordPointer.sprite = null;

        HomePointer1.color = new Color32 (1, 58, 23, 255);

        RecordPointer1.color = new Color32 (1, 58, 23, 255); 
        



        ARPointer1.color = new Color32 (255, 255, 255, 255);

        Hometext.color = new Color32(1, 58, 23, 255);

        Recordtext.color = new Color32(1, 58, 23, 255);

        ARtext.color = Color.white; 





    }
    void CheckHome()
    {
        HomePointer.sprite = PointerImage;
        ARPointer.sprite = null;
        RecordPointer.sprite = null;

        ARPointer1.color = new Color32(1, 58, 23, 255);

        RecordPointer1.color =  new Color32 (1, 58, 23, 255);

        HomePointer1.color = new Color32 (255, 255, 255, 255);

        Hometext.color = Color.white;

        Recordtext.color = new Color32(1, 58, 23, 255);

        ARtext.color = new Color32(1, 58, 23, 255);


    }
    void CheckRecord()
    {
        RecordPointer.sprite = PointerImage;
        ARPointer.sprite = null;
        HomePointer.sprite = null;

        HomePointer1.color = new Color32 (1, 58, 23, 255);

        ARPointer1.color = new Color32 (1, 58, 23, 255);

        RecordPointer1.color = new Color32 (255, 255, 255, 255);

        Hometext.color = new Color32(1, 58, 23, 255);

        Recordtext.color = Color.white;

        ARtext.color = new Color32(1, 58, 23, 255);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
