using System;

namespace ReportFromObject
{
    public class StudentsInfo
    {
        // تسلس الطالب
        public int ID
        { set; get; }
        // اسم الطالب
        public string FullName
        { set; get; }
        // تاريخ ولادة الطالب
        public DateTime BirthDate
        { set; get; }
        // عنوان الطالب
        public string Address
        { set; get; }
    }
}
