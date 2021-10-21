using UnityEngine;
using UnityEngine.UI;

namespace EasyUI.Dialogs
{
    public class Info
    {
        public string moleculeName = "default name";
        public string info_text = "default molecule info";
    }

    public class DialogUI : MonoBehaviour
    {
        [SerializeField] Text moleculeName;
        [SerializeField] Text moleculeInfo;
        [SerializeField] Button closeUIButton;
        [SerializeField] GameObject canvas;
        public RaycastHit r;
        public Color[] originalMats1;

        Info popUp = new Info();

        public static DialogUI Instance;

        

        void Awake()
        {
            Instance = this;
            closeUIButton.onClick.RemoveAllListeners();
            closeUIButton.onClick.AddListener(closePopUp);
        }

        void Start()
        {
            
            canvas.SetActive(false);
        }

        public DialogUI SetTitle(string title)
        {
            popUp.moleculeName = title;
            return Instance;
        }

        public DialogUI SetInfo(string info_t)
        {
            popUp.info_text = info_t;
            return Instance;
        }

        public void pop(RaycastHit hit)
        {
            //moleculeName.text = "This is a cube";
            //moleculeInfo.text = "A cube is a basic 3-D shape A cube is a very basic 3-D shape A cube is a very basic 3-D shape A cube is a very basic 3-D shape A cube is a very basic 3-D shape";
            //originalMats1 = originalMats;
            r = hit;
            //moleculeName.text = r.collider.name; // testing for what raycast is returning
            
            if(r.collider.name == "Aromatic Group")
            {
                moleculeName.text = "Aromatic Group";
                moleculeInfo.text = "A group consisting of 3 pairs of double bonded carbons forming a planar ring. These rings are stable, but can produce great amounts of energy when broken.";
            }
            else if(r.collider.name == "Amide Group")
            {
                moleculeName.text = "Amide Group";
                moleculeInfo.text = "Amide groups are common in biological systems like proteins and inorganic materials like polymers and kevlar. This Amide group is secondary as the nitrogen is only bonded to one other functional group. ";
            }
            else if(r.collider.name == "Hydroxyl Group")
            {
                moleculeName.text = "Hydroxyl Group";
                moleculeInfo.text = "A reactive group that often denotes a molecule as an acid or alcohol. Its reactivity can be useful in many reactions and makes it soluble in polar solutions.";
            }
            
            canvas.SetActive(true);
        }

        public void closePopUp()
        {
            canvas.SetActive(false);
            popUp = new Info();
            Material[] mat = r.collider.GetComponent<Renderer>().materials;
       
            //for (int i = 0;i < mat.Length;i++)
            //{

            //    mat[i].color = originalMats1[i];
                
            //}
            //r.collider.GetComponent<Renderer>().materials = mat;
        }
    }
}