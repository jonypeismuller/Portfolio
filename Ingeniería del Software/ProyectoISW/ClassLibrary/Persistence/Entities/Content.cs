﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Content
    {
        public Authorized Authorized { get; set; }
        public String ContentURI { get; set; }
        public String Description { get; set; }
        public int Id { get; set; }
        public Boolean IsPublic { get; set; }
        public String Title { get; set; }
        public DateTime UploadDate{ get; set; }

        //--------------------RELACIONES--------------------//
        [Required]
        public virtual Member Owner { get; set; }
        public virtual Evaluation Evaluation { get; set; }
        public virtual ICollection<Visualization> Visualizations { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
