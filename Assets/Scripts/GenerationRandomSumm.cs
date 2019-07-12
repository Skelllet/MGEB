using UnityEngine;
using UnityEngine.UI;

public class GenerationRandomSumm : MonoBehaviour
{
    int Value = 0;
    public Text summa;

    public static int Valueforteleport;

    [SerializeField]
    Transform newParent;

    int rubl, dvarub, pyatrub, desrub, CountFifthy, CountSto;



    public Transform onehun, fift, tenn, fivve, twwo, onne;



    void Start()
    {



        Value = Random.Range(1, 1000);
        summa.text = Value.ToString();
        Valueforteleport = Value;

        CountSto = Valueforteleport / 200;

        if (CountSto <= 1)
        {
            CountSto = 2;
        }

        CountFifthy = Valueforteleport / 250;

        if (CountFifthy <= 1)
        {
            CountFifthy = 2;
        }
        rubl = (Valueforteleport - (CountSto * 100 + CountFifthy * 50)) / 5;

        if (rubl <= 1)
        {
            rubl = 2;
        }

        dvarub = (Valueforteleport - (CountSto * 100 + CountFifthy * 50)) / 8;

        if (dvarub <= 1)
        {
            dvarub = 2;
        }

        pyatrub = (Valueforteleport - (CountSto * 100 + CountFifthy * 50)) / 9;

        if (pyatrub <= 1)
        {
            pyatrub = 2;
        }

        desrub = (Valueforteleport - (CountSto * 100 + CountFifthy * 50)) / 10;

        if (desrub <= 1)
        {
            desrub = 2;
        }

       



        //цикл для генерации сторублевых купюр
        for (int i = 0; i < CountSto; i++)
        {
            var child = Instantiate(onehun, newParent);

        }


        //цикл для генерации пятидесятирублевых купюр
        for (int i = 0; i < CountFifthy; i++)
        {
            var child = Instantiate(fift, newParent);
        }

        //цикл для генерации рублевых купюр
        for (int i = 0; i < rubl; i++)
        {
            var child = Instantiate(onne, newParent);
        }

        //цикл для генерации 2 рублевых купюр
        for (int i = 0; i < dvarub; i++)
        {
            var child = Instantiate(twwo, newParent);
        }

        //цикл для генерации 5 рублевых купюр
        for (int i = 0; i < pyatrub; i++)
        {
            var child = Instantiate(fivve, newParent);
        }

        //цикл для генерации 10 рублевых купюр
        for (int i = 0; i < desrub; i++)
        {
            var child = Instantiate(tenn, newParent);
        }
    }
}





