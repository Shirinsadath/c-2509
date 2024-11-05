using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace OOPS_Assignment_5
{
    public class Library
    {
        public string[] books;
        public Library()
        {
            books = new string[] { "Kite Runner", "a little life", "it ends with us" };
        }
        public string this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
        public void DisplayBooks()
        {
            Console.WriteLine("Books in the library :"); 
            for (int i = 0; i < books.Length; i++) 
            {
                Console.WriteLine($"{books[i]}");
                
            }
        }
    }
    public class Classroom
    {
        private string[,] seats;
        public Classroom()
        { 
            // Initialize the 2D array with student names
            seats = new string[,]
            {
                { "zeba", "naja", "Shahad" },
                { "Nabeel", "Nafi", "Shahin" },
                { "Nazreen", "Nujoum", "Shirin" } 
            };
        } 
        public string this[int row, int column] 
        {
            get { return seats[row, column]; } 
            set { seats[row, column] = value; }
        }
        public void DisplaySeats() 
        {
            Console.WriteLine("Classroom seating arrangement:");
            for (int i = 0; i < seats.GetLength(0); i++) 
            {
                for (int j = 0; j < seats.GetLength(1); j++) 
                {
                    Console.Write(seats[i, j] + "\t"); 
                }
                Console.WriteLine();
            }
        }
    }
        }
