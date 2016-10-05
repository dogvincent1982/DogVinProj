using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day1Homework
{
    public class MathService
    {
        public List<int> GetSumPropertyGroupByCount<T>(List<T> objectList, int count, string propertyName)
        {
            List<int> returnValue = new List<int>();
            if (objectList != null && objectList.Count > 0)
            {
                Type type = objectList.First().GetType();
                int nowIndex = 0;
                int tempSum = 0;
                foreach (T obj in objectList)
                {
                    /*
                     * 預設狀態為內部使用Dll
                     * 以下若轉型或取得屬性失敗皆直接throw exception不處理
                    */
                    PropertyInfo propertyInfo = type.GetProperty(propertyName);
                    tempSum += (int)propertyInfo.GetValue((T)obj);
                    nowIndex++;
                    if (nowIndex >= count)
                    {
                        returnValue.Add(tempSum);
                        tempSum = 0;
                        nowIndex = 0;
                    }
                }
                //若nowIndex等於表示剛好跑完，不是等於0則需要把最後一次的Sum加到List
                if (nowIndex != 0)
                    returnValue.Add(tempSum);
            }
            return returnValue;
        }
    }
}
