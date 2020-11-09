using System;
namespace IntergenicResearchLibrary
{
    public class Library : IDefaulter
    {
        private int dayIssue;
        private int monthIssue;
        public int YearIssue{get; set;}
        private int dayReturned;
        private int monthReturned;
        public int YearReturned{get; set;}
        public string StudentName{get;set;}
        public string YearStudy{get;set;}
        public string BookName{get;set;}
        public string BookID{get;set;}
        public string DefaulterName{get; set;}
        public string BookToReturnName{get; set;}
        public string BookToReturnID{get; set;}



        public Library(int dayIssue, int monthIssue, int yearIssue, int monthReturned, int dayReturned, int yearReturned, string studentname, string yearstudy, string bookname, string bookid, string defaulterName, string bookToReturnName, string bookToReturnID)
        {
            MonthIssue = monthIssue;
            DayIssue = dayIssue;
            YearIssue = yearIssue;
            MonthReturned = monthReturned;
            DayReturned = dayReturned;
            YearReturned = yearReturned;
            StudentName = studentname;
            YearStudy = yearstudy;
            BookName = bookname;
            BookID = bookid;
            DefaulterName = defaulterName;
            BookToReturnName = bookToReturnName;
            BookToReturnID = bookToReturnID;
        }
        public int MonthIssue
        {
            get{return monthIssue;}
            private set
            {
                if((value > 0) && (value <= 12))
                {
                    monthIssue = value;
                }else {
                    throw new System.ArgumentOutOfRangeException("Day value is out of range");
                }

            }
        }

        public int DayIssue
        {
            get{return dayIssue;}
            set 
            {
                int[] DaysPerMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
                if((value > 0) && (value <= DaysPerMonth[MonthIssue - 1]))
                {
                    dayIssue = value;
                }else if( (MonthIssue == 2 && value == 29) && (YearIssue %  4 == 0 || YearIssue % 400 == 0) && (YearIssue % 100 != 0))
                {
                    dayIssue = value;
                }else{
                    throw new System.ArgumentOutOfRangeException("Day value out of range!");
                }
            }
        }
        public int MonthReturned
        {
            get{return monthReturned;}
            private set
            {
                if((value > 0) && (value <= 12))
                {
                    monthReturned = value;
                }else {
                    throw new System.ArgumentOutOfRangeException("Day value is out of range");
                }

            }
        }

        public int DayReturned
        {
            get{return dayReturned;}
            set 
            {
                int[] DaysPerMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
                if((value > 0) && (value <= DaysPerMonth[MonthReturned - 1]))
                {
                    dayReturned = value;
                }else if( (MonthReturned == 2 && value == 29) && (YearReturned %  4 == 0 || YearReturned % 400 == 0) && (YearReturned % 100 != 0))
                {
                    dayIssue = value;
                }else{
                    throw new System.ArgumentOutOfRangeException("Day value out of range!");
                }
            }
        }
        
        public string GetName()
        {
            return $"Student Name : {StudentName}";
        }

        public string GetYear()
        {
            return $"Student Year : {YearStudy}";
        }

        public string GetBook()
        {
           return $"Book Name: {BookName}\nBook ID:{BookID}";
        }

        public string GetDateIssue()
        {
            return $"The book was issued: {DayIssue}/{MonthIssue}/{YearIssue}";
        }

        public string GetDateReturn()
        {
            return $"The book is to be returned: {DayReturned}/{MonthReturned}/{YearReturned}";
        }

        public string GetDefaulter()
        {
            return $"Defaulter Name: {DefaulterName}\nBook To Return: {BookToReturnName} with ID: {BookToReturnID}";
        }
        public override string ToString()
        {
            return $"{GetName()}\n{GetYear()}\n{GetBook()}\n{GetDateIssue()}\n{GetDateReturn()}\n{GetDefaulter()}\n";
        

        } 
    }
}