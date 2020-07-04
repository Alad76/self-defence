using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp2
{
    class Program
    {
        static void SortByOn(int[] Array, int N) //Сортировка включением
        {
            int m, l, k;
            int sort;
            for (l = 1; l < N; l++) 
            {
                k = Array[l];
                m = l - 1;
                while (k<Array[m] && m>=0)
                {
                    sort = Array[m];
                    Array[m] = Array[m + 1];
                    Array[m + 1] = sort;
                    if (m >= 1)
                        m -= 1;
                }
                Array[m + 1] = k;
            }
            Console.WriteLine("Сортировка включением завершена");
        }
        static void SortByChoose(int[] Array, int N) //Сортировка выбором
        {
            int m, n, k, x;
            for (m=0;m<N;m++)
            {
                x = Array[m];
                k = m;
                for (n = m; n < N; n++)
                {
                    if(Array[n]<x)
                    {
                        k = n;
                        x = Array[k];
                    }
                }
                Array[k] = Array[m];
                Array[m] = x;
            }
            Console.WriteLine("Сортировка выбором завершена");
           
        }
        static void SortByReload(int[] Array, int N) //Сортировка обменом
        {
            int i, j, sort;
            for (i = 0; i < N; i++) 
            {
                for (j = N - 1; j >= i; j--)
                {
                    if (Array[j]<Array[j-1])
                    {
                        sort = Array[j];
                        Array[j] = Array[j - 1];
                        Array[j - 1] = sort;
                    }
                }
            }
            Console.WriteLine("Сортировка обменом завершена");
        }
        static void SortByReload1(int[] Array, int N) //Сортировка обменом 1
        {
            int m, l, k, p;
            for (m = 0; m < N - 1; m++)
            {
                p = 0;
                for (l = N - 1; l > m; l--)
                {
                    if (Array[l] < Array[l-1])
                    {
                        k = Array[l];
                        Array[l] = Array[l - 1];
                        Array[l - 1] = k;
                        p = 1;
                    }
                }
                //Если не было перестановок, то сортировка считается выполненной
                if (p == 0)
                    break;
            }
            Console.WriteLine("Сортировка обменом 1 завершена");
        }
        static void SortByReload2(int[] Array, int N) //Сортировка обменом 2
        {
            int i, j, sort;
            i = 0;
            do
            {
                for (j = N - 1; j > 0; j--)
                {
                    if (Array[j - 1] > Array[j])
                    {
                        sort = Array[j];
                        Array[j] = Array[j - 1];
                        Array[j - 1] = sort;
                    }
                    if (i >= j)
                        break;
                }
                i++;
            }
            while (i < N);
            Console.WriteLine("Сортировка обменом 2 завершена");

        }
        static void SortByShella(int[] Array, int N) //Сортировка Шелла
        {
            int j;
            int step = N / 2;
            while (step>0)
            {
                for (int i = 0; i < (N - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (Array[j] > Array[j + step]))
                    {
                        int tmp = Array[j];
                        Array[j] = Array[j + step];
                        Array[j + step] = tmp;
                        j -= step;
                    }
                }
                step = step / 2;
            }
            Console.WriteLine ("Сортировка Шелла завершена");
        }
        static int partition(int[] Array, int start, int end)
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (Array[i]<=Array[end])
                {
                    int temp = Array[marker];
                    Array[marker] = Array[i];
                    Array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }
        static void SortByHoar(int[] Array, int start, int end) //Сортировка Хоара
        {
            if(start>=end)
            {
                return;
            }
            int pivot = partition(Array, start, end);
            SortByHoar(Array, start, pivot - 1);
            SortByHoar(Array, pivot + 1, end);
        }
        static void HeapSort(int[] A, int N) //Пирамидальная сортировка
        {
            int l, r, x, i;
            l = N / 2; r = N - 1;
            while(l>0)
            {
                l = l - 1;
                Sift(A, l, r);
            }
            while(r>0)
            {
                x = A[0];A[0] = A[r];A[r] = x;
                r--;
                Sift(A, l, r);
            }
            Console.WriteLine("Пирамидальная сортировка завершена");
        }
        static void Sift(int[] A, int l,int r)
        {
            int i, j, x, k;
            i = l;
            j = 2 * l + 1;
            x = A[l];
            if ((j < r) && (x < A[j]))
                j++;
            while ((j <= r) && (x < A[j + 1]))
            {
                k = A[i];A[i] = A[j];A[j] = k;
                i = j;
                j = 2 * j + 1;
                if ((j < r) && (A[j] < A[j + 1]))
                    j++;
            }
        }
        static void SetTimer()
        {
            time = new Timer(1);
            time.Elapsed += OnTimedEvent;
            time.AutoReset = true;
            time.enabled = true;
        }
        static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("{0:ss.ffff", e.SignalTime);
        }

    }

}
