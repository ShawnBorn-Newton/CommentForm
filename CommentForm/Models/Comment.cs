using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CommentForm.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        public string Name { get; set; }
        public string CommentText { get; set; }
        public int Priority { get; set; }

        [ForeignKey("Procedure")]
        public int ProcedureId { get; set; }
        public virtual Procedure Procedure { get; set; }
    }
}