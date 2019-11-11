using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace C2EpiserverBlog.Models.Blocks
{
    [ContentType(DisplayName = "ButtonBlock", GUID = "c6716618-753d-492d-8177-dec465cc7ef7", Description = "")]
    public class ButtonBlock : BlockData
    {
        [Display(Order = 1, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual string ButtonText { get; set; }

        [Display(Order = 2, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual Url ButtonLink { get; set; }
    }
}