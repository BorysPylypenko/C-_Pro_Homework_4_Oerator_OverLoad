using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_4_Oerator_OverLoad.Task_4
{
    public class Matrix
    {

    
        private int[,] data;
        
        public int Rows {  get; set; }
        public int Columns { get; set; }
        public int this[int row,int colum]
        {
            get { return data[row, colum]; }
            set { data[row, colum] = value; }
        }

        public Matrix(int rows, int colums) 
        {
            Rows = rows;
            Columns = colums;
            data = new int[rows, colums];
        }
        

    }

    
}
