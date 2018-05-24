using System;
using System.Collections.Generic;
using System.Linq;
using GigHub.Models;

namespace GigHub.Repositories
{
    public class AttendanceRepository
    {
        private readonly ApplicationDbContext _context;
        public AttendanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Attendance> GetFutureAttendances(string userId)
        {
            return _context.Attendances
                .Where(a => a.AttendeeId == userId && a.Gig.DateTime > DateTime.Now)
                .ToList();
        }

        public Attendance GetAttendance(int gigId, string userId)
        {
            return _context.Attendances.FirstOrDefault(a => a.GigId == gigId && a.AttendeeId == userId);
        }
    }
}