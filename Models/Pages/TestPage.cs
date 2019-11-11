using System.ComponentModel.DataAnnotations;
using C2EpiserverBlog.Models.Random;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace C2EpiserverBlog.Models.Pages
{
    [ContentType(DisplayName = "TestPage", GUID = "6e0d0e85-517d-49ca-b2ca-55d13c40c6ad", Description = "")]
    public class TestPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "This is the heading?",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Spell Name",
            Description = "Name of the spell found",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string SpellName { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Spell description",
            Description = "Description of the spell found",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string SpellDescription { get; set; }
    }
}