using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace C2EpiserverBlog.Models.Pages
{
    [ContentType(DisplayName = "ThankYouPage", GUID = "cd317043-f1b4-4bdd-9447-8c870a293f45", Description = "")]
    public class ThankYouPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "Generic redirect after submitting contact us form",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}