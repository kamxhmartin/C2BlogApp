using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace C2EpiserverBlog.Models.Pages
{
    [ContentType(DisplayName = "ContactPage", GUID = "0240fd5c-306b-4db1-b46f-d7da1798cd54", Description = "")]
    public class ContactPage : PageData
    {
        [CultureSpecific]
        [Display(
                   Name = "Name",
                   Description = "Full Name",
                   GroupName = SystemTabNames.Content,
                   Order = 1)]
        public virtual string FullName { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Email",
           Description = "There probably should be some validation on this",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        [EmailAddress]
        public virtual string Email { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Phone",
           Description = "Phone valdation",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        public virtual string Phone { get; set; }
    }
}