using System;
using GigHub.Models;

namespace GigHub.ViewModels
{
    public class GigDetailsViewModel
    {
        public Gig Gig { get; set; }
        public bool UserIsGoing  { get; set; }
        public bool ShowAction { get; set; }

    }
}