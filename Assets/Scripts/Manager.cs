using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    public GameObject[] sto;
    public GameObject[] pyatDes;
    public GameObject[] des;
    public GameObject[] pyat;
    public GameObject[] dva;
    public GameObject[] odin;

    public GameObject stoblack;

    /*pyatdes, des, pyat, dva, odin, stoblack, pyatdesblack, desblack, pyatblack, dvablack, odinblack;*/

    Vector2 stoPos, pyatdesPos, desPos, pyatPos, dvaPos, odinPos, stoPos1;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;

    public int kolvoSto = 0, kolvoPyatdes = 0, kolvodes = 0, kolvoPyat = 0, kolvoDva = 0, kolvoOdin = 0;
    public Text one, two, five, ten, fif, onehu;

    

    void Start  ()
    {
        
        stoPos = sto[0].transform.position;
        
        pyatdesPos = pyatDes[0].transform.position;
        desPos = des[0].transform.position;
        pyatPos = pyat[0].transform.position;
        dvaPos = dva[0].transform.position;
        odinPos = odin[0].transform.position;
    }
   /// <summary>
   /// ////////////////////////////////////////////////////
   /// </summary>
    public void DragSto()
    {
        sto[0].transform.position = Input.mousePosition;
    }

    public void DragSto1()
    {
        sto[1].transform.position = Input.mousePosition;
    }
    public void DragSto2()
    {
        sto[2].transform.position = Input.mousePosition;
    }
    public void DragSto3()
    {
        sto[3].transform.position = Input.mousePosition;
    }
    public void DragSto4()
    {
        sto[4].transform.position = Input.mousePosition;
    }
    public void DragSto5()
    {
        sto[5].transform.position = Input.mousePosition;
    }
    public void DragSto6()
    {
        sto[6].transform.position = Input.mousePosition;
    }
    public void DragSto7()
    {
        sto[7].transform.position = Input.mousePosition;
    }
    public void DragSto8()
    {
        sto[8].transform.position = Input.mousePosition;
    }
    public void DragSto9()
    {
        sto[9].transform.position = Input.mousePosition;
    }
    /// <summary>
    /// /////////////////////////////////////////
    /// </summary>


     public void DragPyatdes()
     {
         pyatDes[0].transform.position = Input.mousePosition;
     }
    public void DragPyatdes1()
    {
        pyatDes[1].transform.position = Input.mousePosition;
    }
    public void DragPyatdes2()
    {
        pyatDes[2].transform.position = Input.mousePosition;
    }
    public void DragPyatdes3()
    {
        pyatDes[3].transform.position = Input.mousePosition;
    }
    public void DragPyatdes4()
    {
        pyatDes[4].transform.position = Input.mousePosition;
    }
    public void DragPyatdes5()
    {
        pyatDes[5].transform.position = Input.mousePosition;
    }
    public void DragPyatdes6()
    {
        pyatDes[6].transform.position = Input.mousePosition;
    }
    public void DragPyatdes7()
    {
        pyatDes[7].transform.position = Input.mousePosition;
    }
    public void DragPyatdes8()
    {
        pyatDes[8].transform.position = Input.mousePosition;
    }
    public void DragPyatdes9()
    {
        pyatDes[9].transform.position = Input.mousePosition;
    }
    /*public void DragDes()
    {
        des.transform.position = Input.mousePosition;
    }

    public void DragPyat()
    {
        pyat.transform.position = Input.mousePosition;
    }

    public void DragDva()
    {
        dva.transform.position = Input.mousePosition;
    }

    public void DragOdin()
    {
        odin.transform.position = Input.mousePosition;
    }
    */
    public void DropSto()
    {
        float Distance = Vector3.Distance(sto[0].transform.position, stoblack.transform.position);
        if (Distance < 50)
        {
            sto[0].transform.position = stoblack.transform.position;
            source.clip = correct[3];
            source.Play();
            kolvoSto++;
            onehu.text = "x" + kolvoSto.ToString();
            
        }
        else
        {
            sto[0].transform.position = stoPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoSto == 0)
            {

            }
            else
            {
                kolvoSto--;
                onehu.text = "x" + kolvoSto.ToString();
            }
        }
    }


    public void DropSto1()
    {
        float Distance = Vector3.Distance(sto[1].transform.position, stoblack.transform.position);
        if (Distance < 500)
        {
            sto[1].transform.position = stoblack.transform.position;
            source.clip = correct[3];
            source.Play();
            kolvoSto++;
            onehu.text = "x" + kolvoSto.ToString();

        }
        else
        {
            sto[1].transform.position = stoPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoSto == 0)
            {

            }
            else
            {
                kolvoSto--;
                onehu.text = "x" + kolvoSto.ToString();
            }
        }
    }

    public void DropSto2()
    {
        float Distance = Vector3.Distance(sto[2].transform.position, stoblack.transform.position);
        if (Distance < 500)
        {
            sto[2].transform.position = stoblack.transform.position;
            source.clip = correct[3];
            source.Play();
            kolvoSto++;
            onehu.text = "x" + kolvoSto.ToString();

        }
        else
        {
            sto[2].transform.position = stoPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoSto == 0)
            {

            }
            else
            {
                kolvoSto--;
                onehu.text = "x" + kolvoSto.ToString();
            }
        }
    }

    public void DropSto3()
    {
        float Distance = Vector3.Distance(sto[3].transform.position, stoblack.transform.position);
        if (Distance < 500)
        {
            sto[3].transform.position = stoblack.transform.position;
            source.clip = correct[3];
            source.Play();
            kolvoSto++;
            onehu.text = "x" + kolvoSto.ToString();

        }
        else
        {
            sto[3].transform.position = stoPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoSto == 0)
            {

            }
            else
            {
                kolvoSto--;
                onehu.text = "x" + kolvoSto.ToString();
            }
        }
    }

    public void DropSto4()
    {
        float Distance = Vector3.Distance(sto[4].transform.position, stoblack.transform.position);
        if (Distance < 500)
        {
            sto[4].transform.position = stoblack.transform.position;
            source.clip = correct[3];
            source.Play();
            kolvoSto++;
            onehu.text = "x" + kolvoSto.ToString();

        }
        else
        {
            sto[4].transform.position = stoPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoSto == 0)
            {

            }
            else
            {
                kolvoSto--;
                onehu.text = "x" + kolvoSto.ToString();
            }
        }
    }

    public void DropSto5()
    {
        float Distance = Vector3.Distance(sto[5].transform.position, stoblack.transform.position);
        if (Distance < 500)
        {
            sto[5].transform.position = stoblack.transform.position;
            source.clip = correct[3];
            source.Play();
            kolvoSto++;
            onehu.text = "x" + kolvoSto.ToString();

        }
        else
        {
            sto[5].transform.position = stoPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoSto == 0)
            {

            }
            else
            {
                kolvoSto--;
                onehu.text = "x" + kolvoSto.ToString();
            }
        }
    }

    public void DropSto6()
    {
        float Distance = Vector3.Distance(sto[6].transform.position, stoblack.transform.position);
        if (Distance < 500)
        {
            sto[6].transform.position = stoblack.transform.position;
            source.clip = correct[3];
            source.Play();
            kolvoSto++;
            onehu.text = "x" + kolvoSto.ToString();

        }
        else
        {
            sto[6].transform.position = stoPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoSto == 0)
            {

            }
            else
            {
                kolvoSto--;
                onehu.text = "x" + kolvoSto.ToString();
            }
        }
    }

    public void DropSto7()
    {
        float Distance = Vector3.Distance(sto[7].transform.position, stoblack.transform.position);
        if (Distance < 500)
        {
            sto[7].transform.position = stoblack.transform.position;
            source.clip = correct[3];
            source.Play();
            kolvoSto++;
            onehu.text = "x" + kolvoSto.ToString();

        }
        else
        {
            sto[7].transform.position = stoPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoSto == 0)
            {

            }
            else
            {
                kolvoSto--;
                onehu.text = "x" + kolvoSto.ToString();
            }
        }
    }

    public void DropSto8()
    {
        float Distance = Vector3.Distance(sto[8].transform.position, stoblack.transform.position);
        if (Distance < 500)
        {
            sto[8].transform.position = stoblack.transform.position;
            source.clip = correct[3];
            source.Play();
            kolvoSto++;
            onehu.text = "x" + kolvoSto.ToString();

        }
        else
        {
            sto[8].transform.position = stoPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoSto == 0)
            {

            }
            else
            {
                kolvoSto--;
                onehu.text = "x" + kolvoSto.ToString();
            }
        }
    }

    public void DropSto9()
    {
        float Distance = Vector3.Distance(sto[9].transform.position, stoblack.transform.position);
        if (Distance < 500)
        {
            sto[9].transform.position = stoblack.transform.position;
            source.clip = correct[3];
            source.Play();
            kolvoSto++;
            onehu.text = "x" + kolvoSto.ToString();

        }
        else
        {
            sto[9].transform.position = stoPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoSto == 0)
            {

            }
            else
            {
                kolvoSto--;
                onehu.text = "x" + kolvoSto.ToString();
            }
        }
    }

    /*
    public void DropPyatdes()
    {
        float Distance = Vector3.Distance(pyatdes.transform.position, pyatdesblack.transform.position);
        if (Distance < 50)
        {
            pyatdes.transform.position = pyatdesblack.transform.position;
            source.clip = correct[3];
            source.Play();
            kolvoPyatdes++;
            fif.text = "x" + kolvoPyatdes.ToString();
        }
        else
        {
            pyatdes.transform.position = pyatdesPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoPyatdes == 0)
            {

            }
            else
            {
                kolvoPyatdes--;
                fif.text = "x" + kolvoPyatdes.ToString();
            }
        }
    }

    public void Dropdes()
    {
        float Distance = Vector3.Distance(des.transform.position, desblack.transform.position);
        if (Distance < 50)
        {
            des.transform.position = desblack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length-1)];
            source.Play();
            kolvodes++;
            ten.text = "x" + kolvodes.ToString();
        }
        else
        {
            des.transform.position = desPos;
            source.clip = incorrect;
            source.Play();
            if (kolvodes == 0)
            {

            }
            else
            {
                kolvodes--;
                ten.text = "x" + kolvodes.ToString();
            }
        }
    }

    public void DropPyat()
    {
        float Distance = Vector3.Distance(pyat.transform.position, pyatblack.transform.position);
        if (Distance < 50)
        {
            pyat.transform.position = pyatblack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length-1)];
            source.Play();
            kolvoPyat++;
            five.text = "x" + kolvoPyat.ToString();
        }
        else
        {
            pyat.transform.position = pyatPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoPyat == 0)
            {

            }
            else
            {
                kolvoPyat--;
                five.text = "x" + kolvoPyat.ToString();
            }
        }
    }

    public void DropDva()
    {
        float Distance = Vector3.Distance(dva.transform.position, dvablack.transform.position);
        if (Distance < 50)
        {
            dva.transform.position = dvablack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length-1)];
            source.Play();
            kolvoDva++;
            two.text = "x" + kolvoDva.ToString();
        }
        else
        {
            dva.transform.position = dvaPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoDva == 0)
            {

            }
            else
            {
                kolvoDva--;
                two.text = "x" + kolvoDva.ToString();
            }
        }
    }

    public void DropOdin()
    {
        float Distance = Vector3.Distance(odin.transform.position, odinblack.transform.position);
        if (Distance < 50)
        {
            odin.transform.position = odinblack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length-1)];
            source.Play();
            kolvoOdin++;
            one.text = "x" + kolvoOdin.ToString();
        }
        else
        {
            odin.transform.position = odinPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoOdin == 0)
            {

            }
            else
            {
                kolvoOdin--;
                one.text = "x" + kolvoOdin.ToString();
            }
        }
    }
    */

}
