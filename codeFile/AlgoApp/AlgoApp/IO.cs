using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoApp
{

    public class IO
    {
        

        public void Print<E>( E vall)
        {
            Console.WriteLine(vall);
        }

        public void PrintAt<E>(E vall)
        {
            Console.Write(vall);
        }
        public string Get()
        {
            string vall;
            PrintAt("Enter Your Command : ");
            vall = Console.ReadLine();
            return vall;
        }


        public bool Command()
        {
            Print("Hello What do you want ? " +
                "\n1-binarySearch\n2-bubbleSort\n3-mergeSort\n4-quickSort" +
                "\n5-selectionSort\n6InsertionSort\n7-EXIT");
            string commandVall;
            commandVall = Get();
            if (commandVall != "7")
            {
                Print("\n----------\n");
                DoCommand(commandVall);
                Print("\n----------\n");
                return true;
            }
            else
            {
                Print("\n----------\n");
                Print("Good Bye");
                return false;
            }
        }

        public void DoCommand( string vall)
        {
            switch (vall)
            {
                case "1":
                    BinarySearchC binarySearchC = new BinarySearchC();
                    binarySearchC.BinarySearchF();
                    break;

                case "2":
                    BubbleSortC bubbleSortC = new BubbleSortC();
                    bubbleSortC.BubbleSortF();
                    break ;

                case "3":
                    MergeSortC mergeSortC = new MergeSortC();
                    mergeSortC.MergeSortF();
                    break;

                case "4":
                    QuickSortC quickSortC = new QuickSortC();
                    quickSortC.QuickSortF();
                    break;

                case "5":
                    SelectionSortC selectionSortC = new SelectionSortC();
                    selectionSortC.SelectionSortF();
                    break;

                case "6":
                    InsetionSortC insetionSortC = new InsetionSortC();
                    insetionSortC.InsertionSortF();
                    break;

                default:
                    Print("Invalid Command\n");
                    break;
            }
        }
    }
}
