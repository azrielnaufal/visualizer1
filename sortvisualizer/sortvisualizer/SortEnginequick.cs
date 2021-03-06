﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortvisualizer
{
    class SortEnginequick : Interface1
    {
        private bool _sorted = false;
        private int[] Array;
        private Graphics h;
        private int maxVal;
        Brush whiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        public void DoWork(int[] Array_In, Graphics h_In, int maxVal_In)
        {
            Array = Array_In;
            h = h_In;
            maxVal = maxVal_In;

            while (!_sorted)
            {
                for (int i = 0; i < Array.Count() - 1; i++)
                {
                    if (Array[i] > Array[i + 1])
                    {
                        Swap(i, i + 1);
                    }
                }
                _sorted = isSorted();
            }
        }

        private void Swap(int i, int p)
        {
            int temp = Array[i];
            Array[i] = Array[i + 1];
            Array[i + 1] = temp;

            h.FillRectangle(BlackBrush, i, 0, 1, maxVal);
            h.FillRectangle(BlackBrush, p, 0, 1, maxVal);

            h.FillRectangle(whiteBrush, i, maxVal - Array[i], 1, maxVal);
            h.FillRectangle(whiteBrush, p, maxVal - Array[p], 1, maxVal);
        }

        private bool isSorted()
        {
            for (int i = 0; i < Array.Count() - 1; i++)
            {
                if (Array[i] > Array[i + 1]) return false;
            }
            return true;
        }
    }

}

