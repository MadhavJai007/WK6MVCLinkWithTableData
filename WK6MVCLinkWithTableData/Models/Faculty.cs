using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WK6MVCLinkWithTableData.Models
{
    // specifying which table in the database thise class refers to
    [Table("Faculty")]
    public class Faculty
    {
        [Column(name: "FacultyId")]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> students { get; set; }

    }
}