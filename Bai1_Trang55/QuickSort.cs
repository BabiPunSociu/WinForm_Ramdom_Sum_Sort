using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Trang55
{
    internal class QuickSort
    {
        /*
        public static void swap(ref int a,ref int b)
        {
            int tg = a; a=b; b=tg; 
        }
        */
        public static int partition(List<int> arr, int low, int high)
        {
            int pivot = arr[high];    // pivot
            int left = low;
            int right = high - 1;
            while (true)
            {
                while (left <= right && arr[left] > pivot) left++;
                while (right >= left && arr[right] < pivot) right--;
                if (left >= right) break;
            //            swap(ref arr[left],ref arr[right]);
                pivot = arr[left];  arr[left] = arr[right]; arr[right] = pivot;

                left++;
                right--;
            }

            //            swap(ref arr[left],ref arr[high]);
            pivot = arr[left]; arr[left] = arr[high]; arr[high] = pivot;

            return left;
        }

        /* Hàm thực hiện giải thuật quick sort */
        public static void quickSort(List<int> arr, int low, int high)
        {
            if (low < high)
            {
                /* pi là chỉ số nơi phần tử này đã đứng đúng vị trí
                 và là phần tử chia mảng làm 2 mảng con trái & phải */
                int pi = partition(arr, low, high);

                // Gọi đệ quy sắp xếp 2 mảng con trái và phải
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }
    }
}
