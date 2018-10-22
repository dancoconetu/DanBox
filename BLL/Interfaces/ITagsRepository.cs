using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    interface ITagsRepository
    {
        Guid CreateTag(string name);
        bool DeleteTag(Guid guid);
        bool UpdateTag(Guid id, string name);
        Tag GetTag(Guid id);
        IEnumerable<Tag> GetTags();
    }
}
