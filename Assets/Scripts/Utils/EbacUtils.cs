using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Random = UnityEngine.Random;
using System;

public static class EbacUtils 
{
    public static T GetRandom<T>(this T[] array)
    {
        if(array == null || array.Length == 0) return default(T);

        return array[Random.Range(0,array.Length)];
    }

    public static T GetRandom<T>(this List<T> list)
    {
        if(list == null) return default(T);

        return list[Random.Range(0,list.Count)];
    }
    
    public static T GetRandomButNotSame<T>(this List<T> list, T unique)
    {
        if(list == null) return default(T);
        if(list.Count == 1) return unique;

        int index = Random.Range(0, list.Count);
        return list[index];
    }

    private static IEnumerator CoroutineDelayedCallback(float delay, Action callback)
    {
        yield return new WaitForSeconds(delay);
        callback?.Invoke(); 
    }

    public static void DelayedCallback(MonoBehaviour mono, float delay, Action action)
    {
        mono.StartCoroutine(CoroutineDelayedCallback(delay, action));  
    }

    public static void Scale(List<GameObject> objsToScale, float duration, float delayInEach = 0f)
    {
        for(int i = 0; i < objsToScale.Count; i++)
        {
            objsToScale[i].transform.DOScale(1, duration).SetDelay(delayInEach * i);
        }
    }

    public static string FormatTimeInMinutesAndSeconds(float time)
    {
        string minutes = Mathf.Floor(time / 60).ToString("00");
        string seconds = (time / 60).ToString("00");
        return string.Format("{0}:{1}", minutes, seconds);

    }

}
