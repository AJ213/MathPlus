using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPlus.Code
{
    class Statistics
    {
        //List<float> data = new List<float>(new float[] { 2, 7, 5});

        public Sort sort;
        public enum Sort
        {
            Assending,
            Descending
        }

        public static List<float> SortInOrder(List<float> data, Sort sort)
        {
            List<float> newData = new List<float>() { data[0] };
            data.RemoveAt(0);

            foreach(float item in data)
            {
                for (int i = 0; i <= newData.Count; i++)
                {
                    if ((sort == Sort.Assending && item >= newData[i]) || (sort == Sort.Descending && item <= newData[i]))
                    {
                        newData.Insert(i, item);
                        break;
                    }
                }
            }
            return newData;
        }

        public static float Mean(List<float> data)
        {
            return (data.Sum() / data.Count);
        }
        
        public static float Median(List<float> data)
        {
            data = SortInOrder(data, Sort.Assending);
            float index = (data.Count / 2);
            return Mean(new List<float>() { (float) Math.Floor(index), (float) Math.Ceiling(index) });
        }

        public static List<float> Deviation (List<float> data, float endPoint)
        {
            data.ForEach(item => item -= endPoint);
            return data;
        }

        public static float StandardDeviation(List<float> data)
        {
            data = Deviation(data, Mean(data));
            return (float) (Math.Sqrt((Math.Pow(data.Sum(), 2)) / (data.Count - 1)));
        }
    }
}
