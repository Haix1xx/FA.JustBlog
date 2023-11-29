using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string? ShortDescription { get; set; }
        public string PostContent { get; set; } = default!;
        public string UrlSlug { get; set; } = default!;
        public bool Published { get; set; }
        public DateTime PostedOn {  get; set; }
        public string Modified { get; set; } = default!;
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = default!;

        public virtual ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();

    }
}
