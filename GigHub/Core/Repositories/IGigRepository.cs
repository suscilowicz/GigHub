using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Core.Repositories
{
    public interface IGigRepository
    {
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        Gig GetGigWithAttendees(int gigId);
        IEnumerable<Gig> GetMineGigs(string userId);
        Gig GetGig(int id);
        IEnumerable<Gig> GetGigsOfFollowingArtist(IEnumerable<string> following);
        Gig GetGigToCancel(int gigId, string userId);
        IEnumerable<Gig> GetUpcomingGigs();
        void Add(Gig gig);
    }
}