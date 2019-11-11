using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace C2EpiserverBlog.Models.Pages
{

    [ContentType(DisplayName = "StartPage", GUID = "a6427ae7-d187-490e-8073-da57bd3e5ae6", Description = "")]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(TestPage), typeof(ContactPage), typeof(ThankYouPage) })]
    public class StartPage : PageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 0)]
        [CultureSpecific]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(GroupName = "Concacts page")]
        public virtual PageReference ContactsPageLink { get; set; }

        [Display(GroupName = "Thankyou page")]
        public virtual PageReference ThankYouPageLink { get; set; }
    }
}