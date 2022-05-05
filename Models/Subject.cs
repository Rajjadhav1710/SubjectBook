using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SubjectBook.Models{
    public class Subject{
        [Key]
        public int subjectID {get;set;}

        [DisplayName("Subject Name")]
        [Required]
        public string subjectName {get;set;}

        [DisplayName("Subject Syllabus")]
        [Required]
        public string subjectSyllabus {get;set;}

        [DisplayName("Subject Credits")]
        [Required]
        [Range(1,5)]
        public int subjectCredits {get;set;}        
    }
}