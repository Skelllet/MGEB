using UnityEngine;
using UnityEngine.UI;

public class GenerationRandomSumm : MonoBehaviour
{
    int Value = 0;
    public Text summa;

    public int Valueforteleport = 0;


    int rubl, dvarub, pyatrub, desrub, CountFifthy, CountSto;



    public GameObject[] MoneyObj;
    



   

        void Start()
        {


            Value = Random.Range(1, 1000);
            summa.text = Value.ToString();
            Valueforteleport = Value;



            Debug.Log(Valueforteleport);
            CountSto = Valueforteleport / 125;
            CountFifthy = Valueforteleport / 150;
            rubl = (Valueforteleport - (CountSto * 100 + CountFifthy * 50)) / 5;
            dvarub = (Valueforteleport - (CountSto * 100 + CountFifthy * 50)) / 8;
            pyatrub = (Valueforteleport - (CountSto * 100 + CountFifthy * 50)) / 9;
            desrub = (Valueforteleport - (CountSto * 100 + CountFifthy * 50)) / 10;

            Debug.Log(CountSto);
            Debug.Log(CountFifthy);
            Debug.Log(rubl);
            Debug.Log(dvarub);
            Debug.Log(pyatrub);
            Debug.Log(desrub);

        

            //цикл для генерации сторублевых купюр
            for (int i = 0; i < CountSto; i++)
            {
                Instantiate(MoneyObj[5], MoneyObj[5].transform.position, Quaternion.identity);
            }
       
            //цикл для генерации пятидесятирублевых купюр
            for (int i = 0; i < CountFifthy; i++)
            {
                Instantiate(MoneyObj[4], MoneyObj[4].transform.position, Quaternion.identity);
            }

            //цикл для генерации рублевых купюр
            for (int i = 0; i < rubl; i++)
            {
                Instantiate(MoneyObj[0], MoneyObj[0].transform.position, Quaternion.identity);
            }

            //цикл для генерации 2 рублевых купюр
            for (int i = 0; i < dvarub; i++)
            {
                Instantiate(MoneyObj[1], MoneyObj[1].transform.position, Quaternion.identity);
            }

            //цикл для генерации 5 рублевых купюр
            for (int i = 0; i < pyatrub; i++)
            {
                Instantiate(MoneyObj[2], MoneyObj[2].transform.position, Quaternion.identity);
            }

            //цикл для генерации 10 рублевых купюр
            for (int i = 0; i < desrub; i++)
            {
                Instantiate(MoneyObj[3], MoneyObj[3].transform.position, Quaternion.identity);
            }
        }
    }


     
    

