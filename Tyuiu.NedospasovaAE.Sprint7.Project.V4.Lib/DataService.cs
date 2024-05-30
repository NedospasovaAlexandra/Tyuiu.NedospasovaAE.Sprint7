using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.NedospasovaAE.Sprint7.Project.V4.Lib
{
    public class Book_NAE
    {
        public int PublishYear_NAE { get; set; }
        public string WriteAuthor_NAE { get; set; }
        public string NameBook_NAE { get; set; }
        public int CountQuantity_NAE { get; set; }
        public double CostPrise_NAE { get; set; }
        public DateTime EnrollData_NAE { get; set; }
        public Book_NAE(int PublishYear_NAE, string WriteAuthor_NAE, string NameBook_NAE, int CountQuantity_NAE, double CostPrise_NAE, DateTime EnrollData_NAE)
        {
            this.PublishYear_NAE = PublishYear_NAE;
            this.WriteAuthor_NAE = WriteAuthor_NAE;
            this.NameBook_NAE = NameBook_NAE;
            this.CountQuantity_NAE = CountQuantity_NAE;
            this.CostPrise_NAE = CostPrise_NAE;
            this.EnrollData_NAE = EnrollData_NAE;
        }
    }
    public static class BD_NAE
    {
        public static List<Book_NAE> Books;
        public static List<Book_NAE> SortedBooks;
        public static string SortedColumnName = "WriteAuthor_NAE";
        public static bool SortDirectionASC = true;
        public static string SearchString = "";
        public static void LoadFromCsvFile()
        {
            Books = new List<Book_NAE>();
            string[] Lines = File.ReadAllLines("InPutBase.csv");
            for (int LineNumber = 0; LineNumber < Lines.Length; LineNumber++)
            {
                string[] Cells = Lines[LineNumber].Split(';');
                Books.Add(new Book_NAE(Convert.ToInt32(Cells[0]), Cells[1], Cells[2], Convert.ToInt32(Cells[3]), Convert.ToDouble(Cells[4]), Convert.ToDateTime(Cells[5])));
            }
            SortBooks();
        }
        
        public static void SaveToCsvFile()
        {
            string Text = "";
            for (int LineNumber = 0; LineNumber < Books.Count; LineNumber++)
            {
                Text = Text + Books[LineNumber].PublishYear_NAE + ";" + Books[LineNumber].WriteAuthor_NAE + ";" + Books[LineNumber].NameBook_NAE + ";" + Books[LineNumber].CountQuantity_NAE + ";" + Books[LineNumber].CostPrise_NAE + ";" + Books[LineNumber].EnrollData_NAE + ";\n";           
            }
            File.WriteAllText("InPutBase.csv", Text);
        }
        public static void FindBooks() //вызывать только после SortBooks
        {
            if (SearchString != "")
            {
                SortedBooks = SortedBooks.Where(o => o.WriteAuthor_NAE.Contains(SearchString) || o.NameBook_NAE.Contains(SearchString)).ToList();
            }
            
        }
        public static void SortBooks()
        {
            if (SortedColumnName == "PublishYear_NAE")
            {
                if (SortDirectionASC == true)
                {
                    SortedBooks = Books.OrderBy(o => o.PublishYear_NAE).ToList();       
                }
                else
                {
                    SortedBooks = Books.OrderByDescending(o => o.PublishYear_NAE).ToList();
                }
                
            }
            else if (SortedColumnName == "WriteAuthor_NAE")
            {
                if (SortDirectionASC == true)
                {
                    SortedBooks = Books.OrderBy(o => o.WriteAuthor_NAE).ToList();
                }
                else
                {
                    SortedBooks = Books.OrderByDescending(o => o.WriteAuthor_NAE).ToList();
                }
                
            }
            else if (SortedColumnName == "NameBook_NAE")
            {
                if (SortDirectionASC == true)
                {
                    SortedBooks = Books.OrderBy(o => o.NameBook_NAE).ToList();
                }
                else
                {
                    SortedBooks = Books.OrderByDescending(o => o.NameBook_NAE).ToList();
                }
                    
            }
            else if (SortedColumnName == "CountQuantity_NAE")
            {
                if (SortDirectionASC == true)
                {
                    SortedBooks = Books.OrderBy(o => o.CountQuantity_NAE).ToList();
                }
                else
                {
                    SortedBooks = Books.OrderByDescending(o => o.CountQuantity_NAE).ToList();
                }
                    
            }
            else if (SortedColumnName == "CostPrise_NAE")
            {
                if (SortDirectionASC == true)
                {
                    SortedBooks = Books.OrderBy(o => o.CostPrise_NAE).ToList();
                }
                else
                {
                    SortedBooks = Books.OrderByDescending(o => o.CostPrise_NAE).ToList();
                }
                    
            }
            else if (SortedColumnName == "EnrollData_NAE")
            {
                if (SortDirectionASC == true)
                {
                    SortedBooks = Books.OrderBy(o => o.EnrollData_NAE).ToList();
                }
                else
                {
                    SortedBooks = Books.OrderByDescending(o => o.EnrollData_NAE).ToList();
                }
                    
            }
        }

    }
}
