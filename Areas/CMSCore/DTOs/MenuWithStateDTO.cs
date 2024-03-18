using CanariasBlog.Areas.CMSCore.Entities;

namespace CanariasBlog.Areas.CMSCore.DTOs
{
    public class MenuWithStateDTO : Menu
    {
        public bool IsSelected { get; set; }
    }
}
