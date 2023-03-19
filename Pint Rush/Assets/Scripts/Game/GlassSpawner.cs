using UnityEngine;

namespace PintRush
{
    public class GlassSpawner : MonoBehaviour
    {
        [SerializeField] GameObject parent;
        [SerializeField] private GameObject gmo;
        private GameManagement gm;

        private void Start()
        {
            gm = gmo.GetComponent<GameManagement>();

            // Turha?
            //gm.SetCurrentGlasses(0);
        }

        //Instatiates the glass prefab in the location provided by the Game manager script
        //Sets the glass prefab as the child of canvas
        //Adds +1 to the current glass counter every time a glass is spawned
        public void OnGlassOne()
        {
            Debug.Log($"{gm.GetCurrentGlasses()} : {gm.GetMaxGlasses()}");
            if (gm.GetCurrentGlasses() < gm.GetMaxGlasses())
            {
                Debug.Log("Glass 1 spawned at: " + gm.glassOneSpawn);
                GameObject firstGlass = Instantiate(gm.glassOnePrefab, gm.glassOneSpawn, Quaternion.identity);
                firstGlass.transform.SetParent(parent.transform, false);
                gm.AddGlass();
            }
        }

        public void OnGlassTwo()
        {
            Debug.Log($"{gm.GetCurrentGlasses()} : {gm.GetMaxGlasses()}");
            if (gm.GetCurrentGlasses() < gm.GetMaxGlasses())
            {
                Debug.Log("Glass 2 spawned at: " + gm.glassTwoSpawn);
                GameObject secondGlass = Instantiate(gm.glassTwoPrefab, gm.glassTwoSpawn , Quaternion.identity);
                secondGlass.transform.SetParent(parent.transform, false);
                gm.AddGlass();
            }
        }

        public void OnGlassThree()
        {
            Debug.Log($"{gm.GetCurrentGlasses()} : {gm.GetMaxGlasses()}");
            if (gm.GetCurrentGlasses() < gm.GetMaxGlasses())
            {
                Debug.Log("Glass 3 spawned at: " + gm.glassThreeSpawn);
                GameObject thirdGlass = Instantiate(gm.glassThreePrefab, gm.glassThreeSpawn, Quaternion.identity);
                thirdGlass.transform.SetParent(parent.transform, false);
                gm.AddGlass();
            }
        }
    }
}
