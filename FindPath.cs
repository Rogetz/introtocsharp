using System;
/*This wasnt successful, apparently my idea is great.
But I was using a variable(array), There's a presolved
better algorithm for this known as the breadth-first_search algorithm 
that uses data structures like queues and tree nodes.
Ensure you learn it*/
namespace FindPath{
    class FindPath{
        static void Main(string[] args){
            char[,] puzzle = new char[,]{
                {'\"','*'},
                {'\"','*'},
                {'\"','e'}
            };
            PathFinder(puzzle);
        }
        static void PathFinder(char[,] fullPuzzle){
            /*special characters in/for puzzle*/
            char avoid = '*';
            char valid = '\"';
            char end = 'e';
            char passed = 'p';

            /*moves for rows and colums, we move by rows and columns*/
            int row = 0;
            int column = 0;

            /*storage for right paths*/
            string[] storedPath = new string[6];
            
            /*loop*/
            int i = 0;
            int j = 0;
            while(fullPuzzle[i,j] != 'e'){
                /*right / frontwards*/
                if(fullPuzzle[row,column++] == valid){
                    /*increment the column*/
                    column++;
                    storedPath[i] = "row"+row+"column"+column;
                    i++;
                }
                /*downwards / down*/
                else if(fullPuzzle[row++,column] == valid){
                    /*increment row */
                    row++;
                    storedPath[i] = "row"+row+"column"+column;
                    i++;
                }
                /*backwards /left */
                else if(fullPuzzle[row,column--] >= 0 && fullPuzzle[row,column--] == valid){
                    /*decrement column*/
                    column--;
                    storedPath[i] = "row"+row+"column"+column;
                    i++;
                }
                /* upwards / up*/
                else if(fullPuzzle[row--,column] >= 0 && fullPuzzle[row--,column] == valid){
                    /*decrement row*/
                    row--;
                    storedPath[i] = "row"+row+"column"+column;
                    i++;
                }
            }
            return storedPath;
        }
    }

}