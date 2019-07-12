using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject sto, pyatdes, des, pyat, dva, odin, stoblack, pyatdesblack, desblack, pyatblack, dvablack, odinblack;

    public GameObject noBlackOne, noBlackTwo, noBlackFive, noBlackTen, noBlackFif, noBlackOnehun;

    public GameObject Message;

    public GameObject normal, kiss, happy, sad;

    public GameObject viloji, kruto, otlichno, tutnexvataet, perebor, taklushe;

    Vector2 stoPos, pyatdesPos, desPos, pyatPos, dvaPos, odinPos, stoPos1;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;
    public AudioClip start, cool, excellent, bust, taktolushe, nexvataetv;

    public Image imgviloji, imgkruto, imgotlichno, imgtutnexvataet, imgperebor, imgtaklushe;
    public AnimationCurve curve;
    float t;


    public int kolvoSto = 0, kolvoPyatdes = 0, kolvodes = 0, kolvoPyat = 0, kolvoDva = 0, kolvoOdin = 0;
    public Text one, two, five, ten, fif, onehu;

    int SummOnChek;



    void Start()
    {


        source.clip = start;
        source.Play();

        StartCoroutine(FadeIn());
        SummOnChek = GenerationRandomSumm.Valueforteleport;
        if (PlayerPrefs.GetString("Music") == ("no"))
        {
            AudioListener.volume = 0f;
        }
        else
        {
            AudioListener.volume = 1f;
        }
        stoPos = sto.transform.position;
        pyatdesPos = pyatdes.transform.position;
        desPos = des.transform.position;
        pyatPos = pyat.transform.position;
        dvaPos = dva.transform.position;
        odinPos = odin.transform.position;
    }

    public void DragSto()
    {
        sto.transform.position = Input.mousePosition;
    }

    public void DragPyatdes()
    {
        pyatdes.transform.position = Input.mousePosition;
    }


    public void DragDes()
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

    public void DropSto()
    {
        float Distance = Vector3.Distance(sto.transform.position, stoblack.transform.position);
        if (Distance < 500)
        {
            sto.transform.position = stoblack.transform.position;
            source.clip = correct[3];
            source.Play();
            kolvoSto++;
            noBlackOnehun.SetActive(true);
            onehu.text = "x" + kolvoSto.ToString();
            

        }
        else
        {
            sto.transform.position = stoPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoSto == 0)
            {
                noBlackOnehun.SetActive(false);
            }
            else
            {
                kolvoSto--;
                onehu.text = "x" + kolvoSto.ToString();
            }
        }
    }






    public void DropPyatdes()
    {
        float Distance = Vector3.Distance(pyatdes.transform.position, pyatdesblack.transform.position);
        if (Distance < 500)
        {
            pyatdes.transform.position = pyatdesblack.transform.position;
            source.clip = correct[3];
            source.Play();
            kolvoPyatdes++;
            noBlackFif.SetActive(true);
            fif.text = "x" + kolvoPyatdes.ToString();
        }
        else
        {
            pyatdes.transform.position = pyatdesPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoPyatdes == 0)
            {
                noBlackFif.SetActive(false);
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
        if (Distance < 500)
        {
            des.transform.position = desblack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length - 1)];
            source.Play();
            kolvodes++;
            noBlackTen.SetActive(true);
            ten.text = "x" + kolvodes.ToString();
        }
        else
        {
            des.transform.position = desPos;
            source.clip = incorrect;
            source.Play();
            if (kolvodes == 0)
            {
                noBlackTen.SetActive(false);
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
        if (Distance < 500)
        {
            pyat.transform.position = pyatblack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length - 1)];
            source.Play();
            kolvoPyat++;
            noBlackFive.SetActive(true);
            five.text = "x" + kolvoPyat.ToString();
            
        }
        else
        {
            pyat.transform.position = pyatPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoPyat == 0)
            {
                noBlackFive.SetActive(false);
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
        if (Distance < 500)
        {
            dva.transform.position = dvablack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length - 1)];
            source.Play();
            kolvoDva++;
            noBlackTwo.SetActive(true);
            two.text = "x" + kolvoDva.ToString();
            
        }
        else
        {
            dva.transform.position = dvaPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoDva == 0)
            {
                noBlackTwo.SetActive(false);
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
        if (Distance < 500)
        {
            odin.transform.position = odinblack.transform.position;
            source.clip = correct[Random.Range(0, correct.Length - 1)];
            source.Play();
            kolvoOdin++;
            noBlackOne.SetActive(true);
            one.text = "x" + kolvoOdin.ToString();
        }
        else
        {
            odin.transform.position = odinPos;
            source.clip = incorrect;
            source.Play();
            if (kolvoOdin == 0)
            {
                noBlackOne.SetActive(false);
            }
            else
            {
                kolvoOdin--;
                one.text = "x" + kolvoOdin.ToString();
            }
        }
    }

    int i = 0, j = 0;

    public void Pay()
    {
        int SummaPay;
        
       
           SummaPay = kolvodes * 10 + kolvoDva * 2 + kolvoOdin + kolvoPyat * 5 + kolvoPyatdes * 50 + kolvoSto * 100;
        if (SummaPay == SummOnChek)
        {
            if (j > 1)
            {
                Debug.Log(j);
                StartCoroutine(MessageShow());
                
                normal.SetActive(false);
                kiss.SetActive(true);
                source.clip = excellent;
                kruto.SetActive(false);
                tutnexvataet.SetActive(false);
                taklushe.SetActive(false);
                perebor.SetActive(false);
                viloji.SetActive(false);
                otlichno.SetActive(true);
                StartCoroutine(Otlechno());
                source.Play();
            }

            else if (i > 1)
            {
                StartCoroutine(MessageShow());
                normal.SetActive(false);
                kiss.SetActive(true);
                source.clip = taktolushe;
                kruto.SetActive(false);
                tutnexvataet.SetActive(false);
                otlichno.SetActive(false);
                perebor.SetActive(false);
                viloji.SetActive(false);
                taklushe.SetActive(true);
                StartCoroutine(luch());
                source.Play();
            }
            else if (j == 0 && i == 0)
            {
                Debug.Log(j);
                Debug.Log(i);
                StartCoroutine(MessageShow());
                source.clip = cool;
                kruto.SetActive(false);
                tutnexvataet.SetActive(false);
                taklushe.SetActive(false);
                perebor.SetActive(false);
                viloji.SetActive(false);
                otlichno.SetActive(false);
                kruto.SetActive(true);
                StartCoroutine(Coool());
                source.Play();
            }

        }
        else if (SummaPay > SummOnChek)
        {
            StartCoroutine(more());
            normal.SetActive(false);
            happy.SetActive(true);
            source.clip = correct[3];
            source.Play();
            source.clip = bust;
            kruto.SetActive(false);
            tutnexvataet.SetActive(false);
            taklushe.SetActive(false);
            otlichno.SetActive(false);
            viloji.SetActive(false);
            perebor.SetActive(true);
            StartCoroutine(Perebo());
            source.Play();
            Debug.Log(j);
            j = 2;
        }
        


        else if (SummaPay < SummOnChek)
        {
            StartCoroutine(less());
            normal.SetActive(false);
            sad.SetActive(true);
            source.clip = nexvataetv;
            kruto.SetActive(false);
            otlichno.SetActive(false);
            taklushe.SetActive(false);
            perebor.SetActive(false);
            viloji.SetActive(false);
            tutnexvataet.SetActive(true);
            StartCoroutine(Nexvat());
            source.Play();
            i = 2;
            Debug.Log(i);
        }
           
            
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("play");
        normal.SetActive(true);
        kiss.SetActive(false);
        happy.SetActive(false);
        sad.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("menu");
    }

    IEnumerator MessageShow()
    {
        yield return new WaitForSeconds(3);
        Message.SetActive(true);
    }

    IEnumerator more()
    {
        yield return new WaitForSeconds(2);
        normal.SetActive(true);
        happy.SetActive(false);
    }

    IEnumerator less()
    {
        yield return new WaitForSeconds(5);
        normal.SetActive(true);
        sad.SetActive(false);
    }


    

   

    IEnumerator FadeIn()
    {
        float t = 1f;
        yield return new WaitForSeconds(2);
        while (t > 0f)
        {
            t -= Time.deltaTime * 1.5f;
            float a = curve.Evaluate(t);
            imgviloji.color = new Color(255f, 255f, 255f, a);
            yield return 0;
            
        }
    }

    IEnumerator Coool()
    {
        float t = 1f;
        yield return new WaitForSeconds(1);
        while (t > 0f)
        {
            t -= Time.deltaTime * 1.5f;
            float a = curve.Evaluate(t);
            imgkruto.color = new Color(255f, 255f, 255f, a);
            yield return 0;

        }
    }

    IEnumerator Otlechno()
    {
        float t = 1f;
        yield return new WaitForSeconds(1);
        while (t > 0f)
        {
            t -= Time.deltaTime * 1.5f;
            float a = curve.Evaluate(t);
            imgotlichno.color = new Color(255f, 255f, 255f, a);
            yield return 0;

        }
    }

    IEnumerator Nexvat()
    {
        float t = 1f;
        yield return new WaitForSeconds(2);
        while (t > 0f)
        {
            t -= Time.deltaTime * 1.5f;
            float a = curve.Evaluate(t);
            imgtutnexvataet.color = new Color(255f, 255f, 255f, a);
            yield return 0;

        }
    }

    IEnumerator Perebo()
    {
        float t = 1f;
        yield return new WaitForSeconds(2);
        while (t > 0f)
        {
            t -= Time.deltaTime * 1.5f;
            float a = curve.Evaluate(t);
            imgperebor.color = new Color(255f, 255f, 255f, a);
            yield return 0;

        }
    }

    IEnumerator luch()
    {
        float t = 1f;
        yield return new WaitForSeconds(1);
        while (t > 0f)
        {
            t -= Time.deltaTime * 1.5f;
            float a = curve.Evaluate(t);
            imgtaklushe.color = new Color(255f, 255f, 255f, a);
            yield return 0;

        }
    }


}



