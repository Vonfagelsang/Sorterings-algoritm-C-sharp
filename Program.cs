using System;
using System.Collections.Generic;




class Program {

    public static void Main () 
    {
        Random a = new Random();
        List<int> b  = new List<int>();
        for (int å = 0; å < 1000; å++){
            b.Add(a.Next(1000));
        }
        int[] C = b.ToArray();
        int[] x = C;
         int y = 0;
          for (int write = 0; write < x.Length; write++) {
              for (int sort = 0; sort < x.Length - 1; sort++) {
                  if (x[sort] > x[sort + 1]) {
                      y = x[sort + 1];
                      x[sort + 1] = x[sort];
                      x[sort] = y;
                  }
              }
          }
          Console.WriteLine("Här är bubbel sort algortimen:");
          for (int å = 0; å < x.Length; å++){
              Console.Write(x[å] + " ");
          }


         Console.WriteLine("");
         Console.WriteLine("");
         Console.WriteLine("");
          Console.WriteLine("Här är Insertion sort algoritmen");

          int[] arr = C;
           int n = 1000, i, j, val, flag;
           for (i = 1; i < n; i++) {
              val = arr[i];
              flag = 0;
              for (j = i - 1; j >= 0 && flag != 1; ) {
                 if (val < arr[j]) {
                    arr[j + 1] = arr[j];
                    j--;
                    arr[j + 1] = val;
                 }
                 else flag = 1;
              }
           }
           for (i = 0; i < n; i++) {
              Console.Write(arr[i] + " ");
           }

         Console.WriteLine("");
         Console.WriteLine("");
         Console.WriteLine("");
        
        int[] numbers = C;
            int len = numbers.Length;
            Console.WriteLine("Här är merge sort algoritmen");
            SortMethod(numbers, 0, len - 1);
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
        } 
        static public void SortMethod(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMethod(numbers, left, mid);
                SortMethod(numbers, (mid + 1), right);
                MergeMethod(numbers, left, (mid + 1), right);
            }
        }
        static public void MergeMethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[1000];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
   }