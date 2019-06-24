
public class CrateData
{
    public bool[] isOpen;
    public int[] keyNo;
    public string[] name;
    public float[,] position;
    public CrateData(Key[] keyList)
    {
        int index = 0, count = keyList.Length;

        isOpen = new bool[count];
        keyNo = new int[count];
        name = new string[count];
        position = new float[count, 3];

        for (index = 0; index < count; index++)
        {
            position[index, 0] = keyList[index].gameObject.transform.position.x;
            position[index, 0] = keyList[index].gameObject.transform.position.y;
            position[index, 2] = keyList[index].gameObject.transform.position.z;

            isOpen[index] = keyList[index].GetInInventory();
            keyNo[index] = keyList[index].GetKeyNo();
            name[index] = keyList[index].GetName();
        }

    }
}
