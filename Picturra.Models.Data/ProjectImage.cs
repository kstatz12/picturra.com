using System;
using ServiceStack.DataAnnotations;

namespace Picturra.Models.Data
{
    public class ProjectImage : DataImage
    {
        [ForeignKey(typeof (Project))]
        public int ProjectId { get; set; }
    }
}