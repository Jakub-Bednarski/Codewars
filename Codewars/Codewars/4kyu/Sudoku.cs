using System;
using System.Linq;

namespace Codewars._4kyu
{
    /// <summary>
    /// https://www.codewars.com/kata/540afbe2dc9f615d5e000425/train/csharp
    /// </summary>
    public class Sudoku
    {
        int[][] _sudokuData;

        public Sudoku(int[][] sudokuData)
        {
            _sudokuData = sudokuData;
        }

        public bool IsValid()
        {
            int noOfIntsInResult = _sudokuData[0].Length;

            for (int i = 0; i < noOfIntsInResult; i++)
            {
                if (_sudokuData[i].Length != noOfIntsInResult)
                {
                    return false;
                }
            }

            int noOfSquares = (int)Math.Sqrt(noOfIntsInResult);

            int noOfresultArrays = noOfIntsInResult * 3;

            int[] resultArray = new int[noOfIntsInResult];
            for (int i = 0; i < noOfIntsInResult; i++)
            {
                resultArray[i] = i + 1;
            }
            
            int[][] allResultMatrix = new int[noOfresultArrays][];
            for (int i = 0; i < noOfresultArrays; i++)
            {
                allResultMatrix[i] = new int[noOfIntsInResult];
            }

            for (int i = 0; i < noOfIntsInResult; i++)
            {
                for (int j = 0; j < noOfIntsInResult; j++)
                {
                    allResultMatrix[i][j] = _sudokuData[i][j];
                    allResultMatrix[noOfIntsInResult + i][j] = _sudokuData[j][i];
                }
            }

            for (int i = 0; i < noOfSquares; i++)
            {
                for (int j = 0; j < noOfSquares; j++)
                {
                    for (int x = 0; x < noOfSquares; x++)
                    {
                        for (int y = 0; y < noOfSquares; y++)
                        {
                            allResultMatrix[noOfIntsInResult * 2 + noOfSquares * i + j][noOfSquares * x + y] = _sudokuData[i * noOfSquares + x][j * noOfSquares + y];
                        }
                    }
                    
                }
            }

            for (int i = 0; i < noOfresultArrays; i++)
            {
                foreach (var number in resultArray)
                {
                    if (allResultMatrix[i].Contains(number) == false)
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }
    }
}
