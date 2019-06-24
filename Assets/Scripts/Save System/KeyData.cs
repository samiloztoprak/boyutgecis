using UnityEngine;

[System.Serializable]
public class KeyData
{
    public bool[] inInventory;
    public int[] keyNo;
    public string[] name;
    public float[,] position;

    public KeyData(Key[] keyList)
    {
        int index = 0, count = keyList.Length;

        inInventory = new bool[count];
        keyNo = new int[count];
        name = new string[count];
        position = new float[count, 3];

        for (index = 0; index < count; index++)
        {
            if (!inInventory[index]) // object is invalid?
            {
                position[index, 0] = keyList[index].gameObject.transform.position.x;
                position[index, 0] = keyList[index].gameObject.transform.position.y;
                position[index, 2] = keyList[index].gameObject.transform.position.z;
            }

            inInventory[index] = keyList[index].GetInInventory();
            keyNo[index] = keyList[index].GetKeyNo();
            name[index] = keyList[index].GetName();
        }

    }
}
