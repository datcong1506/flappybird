using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class InterQuestion : MonoBehaviour
{
    public static int[] ArrayOrderOffset(int[] origin, int offset)
    {
        if (origin == null)
        {
            return null;
        }

        if (origin.Length == 0)
        {
            return new int[1];
        }
        
        var length = origin.Length;

        offset = offset >= length ? offset % length : offset;
        offset = offset <= -length ? -(-offset % length) : offset;


        var rs = new int[length];
        for (int i = 0; i < length; i++)
        {
            var index= offset+i;

            index = index >= length ? index % length : index;
            index = index < 0 ? length + index : index;

            rs[index] = origin[i];
        }

        return rs;
    }

    public static void MaxSizeChildArray(int[] origin)
    {
        if (origin == null)
        {
            Debug.Log("origin null");
            return;
        }
        if (origin.Length < 1)
        {
            Debug.Log("0");
        }
        // sort array
        Array.Sort(origin);

        int rs = 1;
        
        int lowerCount = 1;
        int higherCount = 0;
        
        int lowerFlagValue=origin[0];
        
        for (int i = 1; i < origin.Length; i++)
        {
            if (origin[i] == lowerFlagValue)
            {
                lowerCount++;
            }
            else
            {
                if (origin[i] == lowerFlagValue + 1)
                {
                    higherCount++;
                }
                else
                {
                    if (origin[i] == lowerFlagValue + 2)
                    {
                        if (lowerCount + higherCount > rs)
                        {
                            rs = lowerCount + higherCount;
                        }
                        lowerCount = higherCount;
                        higherCount = 1;

                        lowerFlagValue += 1;
                    }
                    else
                    {
                        if (lowerCount + higherCount > rs)
                        {
                            rs = lowerCount + higherCount;
                        }
                        lowerCount = 1;
                        higherCount = 0;

                        lowerFlagValue = origin[i];
                    }
                }
            }      
        }
        if (lowerCount + higherCount>rs)
        {
            rs = lowerCount + higherCount;
        }
        
        Debug.Log(rs);
        return;
    }
}
