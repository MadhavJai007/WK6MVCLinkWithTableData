using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WK6MVCLinkWithTableData.Models
{
    // specifying which table in the database thise class refers to
    [Table("Student")]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        // specifying which column in the table thise property refers to
        [Column(name: "Faculty")]
        public int FacultyId { get; set; }

    }
}